using System.Collections.Generic;

namespace TodoLib
{
    public class AppState
    {
        public AppState()
        {
            Todos = new List<ToDoItem> { new ToDoItem { Text = "Test me" } };
        }
        public AppState(List<ToDoItem> todos)
        {
            Todos = todos;
        }
        public List<ToDoItem> Todos { get; }
    }
}
