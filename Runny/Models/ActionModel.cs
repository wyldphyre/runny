using System;
using System.Collections.Generic;
using System.Text;

namespace Runny.Models
{
    class Action
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Executor> Executors { get; set; }
    }
}
