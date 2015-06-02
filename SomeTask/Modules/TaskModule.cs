using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Autofac;
using SomeTask.Adapters;

namespace SomeTask.Modules
{
    public class TaskModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<SaveTask>()
                .As<ITask>()
                .WithMetadata("Name", "Save Task");
            builder.RegisterType<LoadTask>()
                .As<ITask>()
                .WithMetadata("Name", "Load Task");
        }
    }
}
