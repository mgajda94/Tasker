using System.Collections.Generic;

namespace Tasker.Controllers
{
    public class Customer
    {
        public int CustomerId { get; set; } 
        public string Name { get; set; }

        public ICollection<Task> Tasks { get; set; }

    }
}