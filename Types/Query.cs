namespace Types;

[QueryType]
public class Query
{
    [UseProjection]
    public IQueryable<Item> GetItems()
    {
        return new List<Item>([new() { Subject = "a", User = "b" }]).AsQueryable();
    }
}
