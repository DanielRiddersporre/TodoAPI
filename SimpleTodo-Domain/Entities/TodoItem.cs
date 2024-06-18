namespace SimpleTodo_Domain
{
    public class TodoItem
    {
        public Guid Id { get; set; }
        public Guid TodoListId { get; set; }
        public string Description { get; set; }
        public bool IsDone { get; set; }
    }
}
