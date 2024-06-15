namespace TodoAPI
{
    public class TodoItem
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public bool IsDone { get; set; }
    }
}
