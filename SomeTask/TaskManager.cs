using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SomeTask.Adapters;
using log4net;

namespace SomeTask
{
    public class TaskManager : ITaskManager
    {
        private readonly ILog _logger;
        public List<ITask> Tasks { get; private set; }

        public TaskManager(ILog logger)
        {
            _logger = logger;
            Tasks = new List<ITask>();
            _logger.Info("TaskManager created");
        }

        /// <summary>
        /// Gets the task by the task name
        /// </summary>
        /// <param name="name">task name</param>
        /// <returns>task</returns>
        public ITask GetTask(string name)
        {
            _logger.Info(string.Format("GetTask {0}", name));
            return Tasks.Find(t => t.Name == name);
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the task by the task id
        /// </summary>
        /// <param name="id">task id</param>
        /// <returns>task</returns>
        public ITask GetTask(int id)
        {
            _logger.Info(string.Format("GetTask {0}", id));
            throw new NotImplementedException();
        }

        /// <summary>
        /// Add a new task to the manager.  If tha task name or id already exists the result will be false, otherwise true
        /// </summary>
        /// <param name="task">task to add</param>
        /// <returns>success</returns>
        public bool AddTask(ITask task)
        {
            _logger.Info(string.Format("AddTask {0}", task.Name));
            throw new NotImplementedException();
        }

        /// <summary>
        /// Runs the specified task.  If the task does not exist, or there is an error in execution, the result will be false, otherwise true
        /// </summary>
        /// <param name="task">task to run</param>
        /// <returns>success</returns>
        public bool RunTask(ITask task)
        {
            _logger.Info(string.Format("RunTask {0}", task.Name));
            throw new NotImplementedException();
        }
    }
}
