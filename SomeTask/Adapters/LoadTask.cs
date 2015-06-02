using System;

namespace SomeTask.Adapters
{
    public class LoadTask : ITask
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public Action Action { get; set; }
    }
}
