# GLPI API
### Signin
- appkey see in settings api
- EAuthorizationType.UserToken - for authentication from user token
- EAuthorizationType.LoginPassInBase64 - for use LDAP and internal auth and other method; Session continue ~ 20 min
```csharp
Client client = new Client("http://localhost:5555","appkey");
```
#### necessary to use
```csharp
await client.InitSession("glpiClientToken",EAuthorizationType.UserToken,true);
```
- I recommend using a user token to avoid leaking user data
#### or
```csharp
await client.InitSession(Client.ConvertToBase64("log", "pass"), EAuthorizationType.LoginPassInBase64, true);
```

### Get Ticket
- If you need 1 element from the dashboard descendants, then you only need to specify the ID in the parameters
- If you need to make a special collection, then don't use ID
- If you need to get all the elements then use an overload without parameters
```csharp
Ticket? tic = await Ticket.GetItemAsync(client, new Parameter()
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
- 3 arg: isForcePurge (default false) - If the itemtype have a trashbin, you can force purge (delete finally)
- 4 arg: isHistory (default true) - Set to false to disable saving of deletion in global history
```csharp
Ticket? tic = await Ticket.GetItemAsync(client,new Parameter
{
    id = 2
});

if(!Equals(tic, null))
{
    await Ticket.DeleteItemAsync(client, tic, true, false);
}
```
