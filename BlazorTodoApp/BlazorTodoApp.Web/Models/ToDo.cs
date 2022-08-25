namespace BlazorTodoApp.Web.Models
{
    public class ToDo
    {
        public ToDo(string text)
        {
            Text = text;
        }

        public string Text { get; }

        public bool IsComplete { get; set; }
    }
}
