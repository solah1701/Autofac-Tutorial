using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using NSubstitute;
using SomeTask.Adapters;
using log4net;

namespace SomeTask.Test
{
    [TestFixture]
    public class TaskManagerTest
    {
        private ITaskManager TaskManager { get; set; }
        private ILog Log { get; set; }

        [SetUp]
        public void SetUp()
        {
            Log = Substitute.For<ILog>();
            TaskManager = new TaskManager(Log);
        }

        private ITask AddTask(string name, int id)
        {
            var task = new LoadTask { Name = name, Id = id };
            TaskManager.Tasks.Add(task);
            return task;
        }

        [Test]
        public void GetTask_Name_Logs_Message()
        {
            // Arrange
            const string NAME = "Name";
            AddTask(NAME, 1);
            var expected = string.Format("GetTask {0}", NAME);

            // Act
            TaskManager.GetTask(NAME);

            // Assert
            Log.Received(1).Info(expected);
        }

        [Test]
        public void GetTask_Name_Returns_Task()
        {
            // Arrange
            Bootstrap.Init();
            TaskManager = Bootstrap.GetTaskManager();
            const string NAME = "Name";
            var expected = AddTask(NAME, 1);

            // Act
            var actual = TaskManager.GetTask(NAME);

            // Assert
            Assert.AreSame(expected, actual);
        }

    }
}
