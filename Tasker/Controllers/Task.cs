using System;
using Tasker.Models;

namespace Tasker.Controllers
{
    public class Task
    {
        public int TaskId { get; set; }
        public ApplicationUser User { get; set; }
        public Customer Customer { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTime DeadLine { get; set; }
        public int Progress { get; set; }

        public Task()
        {
            DeadLine = DateTime.Now;
        }
    }
}