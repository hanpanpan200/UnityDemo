using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnityComponent
{
    public class SMSNotify:INotify
    {

        #region INotify 成员

        public void SendMessage()
        {
            Console.WriteLine("SMS Send Message......");
        }

        #endregion
    }
}
