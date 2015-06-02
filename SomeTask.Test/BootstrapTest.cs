using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace SomeTask.Test
{
    [TestFixture]
    public class BootstrapTest
    {
        [SetUp]
        public void SetUp()
        {
            Bootstrap.Init();
        }

        [Test]
        public void GetTaskManager_Is_Instanciated()
        {
            // Arrange
            
            // Act
            var actual = Bootstrap.GetTaskManager();

            // Assert
            Assert.IsInstanceOf<ITaskManager>(actual);
        }

        [Test]
        public void GetTaskManager_Tasks_Is_Instanciated()
        {
            // Arrange

            // Act
            var actual = Bootstrap.GetTaskManager();

            // Assert
            Assert.IsNotNull(actual.Tasks);
        }
    }
}
