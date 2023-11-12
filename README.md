# GLPI API
### Signin
- `appkey` see in settings api `/front/config.form.php`
- `EAuthorizationType.UserToken` - for authentication from user token. See in the user settings `/front/preference.php` in _**Remote access keys**_
- `EAuthorizationType.LoginPassInBase64` - for use LDAP and internal auth and other method; Session continue ~ 20 min
```csharp
await using Client client = new Client("http://localhost:5555/apirest.php/","appkey");
```
#### _necessary to use_
```csharp
await client.InitSession("glpiClientToken",EAuthorizationType.UserToken, true);
```
- I recommend using a user token to avoid leaking user data
#### or
```csharp
await client.InitSession(Client.ConvertToBase64("log", "pass"), EAuthorizationType.LoginPassInBase64, true);
```
- `log` and `pass` any type auth

### Get Ticket
- If you need 1 element from the dashboard descendants, then you only need to specify the ID in the parameters
- If you need to make a special collection, then don't use ID
- If you need to get all the elements then use an overload without parameters
```csharp
Ticket? tic = await Ticket.GetItemAsync(client, new Parameter
{
    id = 1
});
IEnumerable<Ticket>? tics = await Ticket.GetItemsAsync(client);
IEnumerable<Ticket>? ticsWithParameters = await Ticket.GetItemsAsync(_client, new Parameter
{
    order = Parameter.EOrder.DESC,
    range = new Range(0, 9)
});
```
- In the last example, returning the last 10 tickets.
#### Get with *criteria*
```csharp
ResponseSearch? searchTickets = await Ticket.GetItemsAsync(client, new[]
        {
            Criteria.Create<Ticket>((int) EFieldTicket.TicketStatus,
                false,
                Criteria.ESearchType.equals,
                $"{(int) Ticket.EStatus.Await}")            
        });
```
- Search for tickets based on a given criterion.
- For each heir, the dashboard has its own listing. For tickets this is `EFieldTicket`.
- To initialize the criterion, use the static `Create` method. 
```csharp
 Criteria.Create<Ticket>((int) EFieldTicket.TicketStatus,
                false,
                Criteria.ESearchType.equals,
                $"{(int) Ticket.EStatus.Await}")
```
#### or
```csharp
 Criteria.Create((int) EFieldTicket.TicketStatus,
                false,
                typeof(Ticket),
                Criteria.ESearchType.equals,
                $"{(int) Ticket.EStatus.Await}")
```
- _Argument 1_ `int`:
  - field identifier. It can be obtained from the enumeration I wrote above.
- _Argument 2_ `bool`:
  - it indicates different types. For example, if you are building a query for computers and want to sort by monitors, then in the meta field you need to indicate false, in other cases true.
- _Argument 3_ `ESearchType`:
  - for the accuracy of the request, you need to know which parameter is suitable for the field. You can find it (for tickets):
 ```csharp
IEnumerable<SearchOption> searchOptions = await Ticket.ListSearchOptionsAsync(client);
```
- _Argument 4_ `int` and _conversion_ to `string` (for `enum`) or `string`: 
  - takes a value to search for; if this is an enumeration, then you need to use the int data type.
### Get Ticket from `ResponseSearch`
```csharp
responseSearchTickets.Data
            .Select(s => s.FirstOrDefault().Value)
            .AsParallel()
            .Select(p => Ticket.GetItemAsync(client,
                new Parameter
                {
                    id = (long) p
                }).Result)
            .ToList();
```
`responseSearchTickets` was obtained from the previous example.
In `s.FirstOrDefault().Value` contains `EFieldTicket.TicketStatus` (ticket id). At the same time I download tickets by ID.
### Get Ticket from `ResponseSearch` and `Parameter`
```csharp
ResponseSearch? responseSearch = await Ticket.GetItemsAsync(client,
new Parameter
{
    is_deleted = false,
    range = new Range(0, 9),
    sort = (int)EFieldTicket.TicketId
},
new Criteria[]
{
    Criteria.Create<Ticket>
    (
      (int) EFieldTicket.TicketStatus,
      false,
      Criteria.ESearchType.equals,
      $"{(int)Ticket.EStatus.Await}"
    )
});
```
- In the parameters:
  - `is_deleted = false` (sorting will ignore deleted objects)
  - `range: from 0 to 9 (10 objects)` will be taken into account in sorting
  - `sorting: the number of the field` by which sorting will be performed.
- In the `criteria` (`search` for `tickets` whose `status` is `equal` to `Await`)
- **_In the final: loading 10 non-deleted tickets, sorted by their ID, that are in Await status_**
```csharp
var ticks = responseSearch?.Data
.Select(s => (long) s.FirstOrDefault().Value)
.AsParallel()
.Select(q => Ticket.GetItemAsync(client, new Parameter
{
    id = q
}).Result)
.ToList();
```
### Create Ticket
```csharp
string ticItem = await Ticket.AddItemAsync(client, new Ticket
{
    Content = "This is a new ticket"
});

string ticItems = await Ticket.AddItemsAsync(client, new Ticket[]
{
    new ()
    {
        Content = "Help me! From 1 room",
        IdLocation = 2
    },
    new ()
    {
        Content = "<div><h3>Help me! From 2 room</h3></div>",
        IdLocation = 3
    }
});
```

### Update Ticket
#### In the tic receives a ticket with ID 2. We update the location ID and ticket status on the closed using the UpdateItemAsync method; the same for several tickets
```csharp
Ticket? tic = await Ticket.GetItemAsync(client,new Parameter
{
    id = 2
});

tic.IdLocation = 4;
tic.Status = Ticket.EStatus.Close;

string updateTic = await Ticket.UpdateItemAsync(client, tic);

var tics = (await Ticket.GetItemsAsync(client, new Parameter
{
    is_deleted = true
})).ToList();

tics.ForEach(tic => tic.IsDeleted = false);

string updateTicks = await Ticket.UpdateItemAsync(client, tics);
```

### Delete Ticket
- _Argument 3_ `bool`: `isForcePurge` (default `false`) 
  - If the itemtype have a trashbin, you can force purge (delete finally)
- _Argument 4_ `bool`: `isHistory` (default `true`) 
  - Set to false to disable saving of deletion in global history
```csharp
Ticket? tic = await Ticket.GetItemAsync(client,new Parameter
{
    id = 2
});

if(!Equals(tic, null))
    await Ticket.DeleteItemAsync(client, tic, true, false);
```
- If the ticket exists, it can be deleted.

### WebHook with plugin the [Webhook](https://github.com/ericferon/glpi-webhook/wiki/Webhook)
```csharp
const string adr = "http://localhost:5533/"; 
```
```csharp
client.InitListener(new[]
{
    new Listening(
        string.Join(string.Empty, adr, "createtic"),
        "POST",
        (result, id) => Task.CompletedTask),
        Guid.NewGuid().ToString()
    new Listening(
        string.Join(string.Empty, adr, "updatetic"),
        HttpMethod.Put.Method,
        (result, id) => Task.CompletedTask),
    new Listening(
        string.Join(string.Empty, adr, "deltic"),
        HttpMethod.Delete.Method,
        ResponseObj, 
        typeof(Ticket))
});
```
- _Argument 1_ `string`: http listening address with port if needed
- _Argument 2_ `string`: http method. Default `put` or `post`
- _Argument 3_ `Func<string?,string?,Task>` or `Func<objeck?,string?,Task>`: a function whose 
  - _1 argument_ is a `string` or an `object`;
  - _2 optional parameter_: listener identifier,
  - and _output_ is used for `async`.
- _Argument 4_ `string`: optional parameter. Listener ID
- If you use an `object` in the _3rd argument_, then for **_deserialization_** you must specify the `type of the object`, otherwise it will `default to a string`
```csharp
private Task ResponseObj(object? result, string? id)
{
    Ticket? tic = result as Ticket;
    return Task.CompletedTask;
}
```
```csharp
await client.DisposableListener();
```
### Closing the client can be done in two ways
- use `using`
```csharp
await using Client client = new Client("http://localhost:5555/apirest.php/","appkey");
```
#### or
- use `DisposeAsync()`
```csharp
Client client = new Client("http://localhost:5555/apirest.php/","appkey");
await client.DisposeAsync();
```
##### _If you used a `InitListener`, then always use_ `DisposableListener()`