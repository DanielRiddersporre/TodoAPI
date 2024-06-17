namespace TodoAPI
{
    public class TodoList
    {
        Guid Id { get; set; }
        HashSet<Guid> Items { get; set; }
    }
}
