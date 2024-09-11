namespace Types;

[ExtendObjectType(typeof(Item))]
public class ItemTypeExtension
{
    [BindMember(nameof(Item.User))]
    public async Task<User> GetUser([Parent] Item item)
    {
        var user = new User() { Username = item.User };

        return await Task.FromResult(user);
    }
}