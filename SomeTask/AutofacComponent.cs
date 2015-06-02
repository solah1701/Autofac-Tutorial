using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace SomeTask
{
    public partial class AutofacComponent : Component
    {
        public AutofacComponent()
        {
            InitializeComponent();
            Init();
        }

        public AutofacComponent(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
            Init();
        }

        public void Init()
        {
            Bootstrap.Init();
        }
    }
}
