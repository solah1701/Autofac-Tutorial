using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SomeTask.Adapters;

namespace SomeTask
{
    public interface ITaskManager
    {
        /// <summary>
        /// List of tasks
        /// </summary>
        List<ITask> Tasks { get; }

        /// <summary>
        /// Gets the task by the task name
        /// </summary>
        /// <param name="name">task name</param>
        /// <returns>task</returns>
        ITask GetTask(string name);

        /// <summary>
        /// Gets the task by the task id
        /// </summary>
        /// <param name="id">task id</param>
        /// <returns>task</returns>
        ITask GetTask(int id);

        /// <summary>
        /// Add a new task to the manager.  If tha task name or id already exists the result will be false, otherwise true
        /// </summary>
        /// <param name="task">task to add</param>
        /// <returns>success</returns>
        bool AddTask(ITask task);

        /// <summary>
        /// Runs the specified task.  If the task does not exist, or there is an error in execution, the result will be false, otherwise true
        /// </summary>
        /// <param name="task">task to run</param>
        /// <returns>success</returns>
        bool RunTask(ITask task);
    }
}
