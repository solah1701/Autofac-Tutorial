using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Autofac_Tutorial.Services
{
    public class TodayWriter : IDateWriter
    {
        #region Implementation of IDateWriter

        public void WriteDate()
        {
            Console.WriteLine("Todays date is {0}", DateTime.Now);
        }

        #endregion
    }
}
