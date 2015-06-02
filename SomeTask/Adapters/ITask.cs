using System;

namespace SomeTask.Adapters
{
    public interface ITask
    {
        string Name { get; set; }
        int Id { get; set; }
        Action Action { get; set; }
    }
}
