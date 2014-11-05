using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnityComponent
{
    public class EmailNotify:INotify
    {

        #region INotify 成员

        public void SendMessage()
        {
            Console.WriteLine("Email Send Message......");
        }

        #endregion
    }
}
