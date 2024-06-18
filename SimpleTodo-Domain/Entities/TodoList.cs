namespace SimpleTodo_Domain
{
    public class TodoList
    {
        public Guid Id { get; set; }
        public HashSet<Guid> Items { get; set; }
    }
}
