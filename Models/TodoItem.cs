using System;

namespace todo_api.Models
{
    public class TodoItem
    {
        private DateTime _Date = DateTime.Now;

        public DateTime Date { 
            get
            {
                return _Date;
            }
        }

        public string Item { get; set; }

        public string Link { get; set; }
    }
}
