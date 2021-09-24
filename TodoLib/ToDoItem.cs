using System;

namespace TodoLib
{
    public class ToDoItem
    {
        //public Guid ID { get; set; } = Guid.NewGuid();
        public string? Text { get; set; }
        public bool Done { get; set; }

        public bool RealyDone { get; set; }
    }
}
