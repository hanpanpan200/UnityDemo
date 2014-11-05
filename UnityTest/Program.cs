using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using UnityComponent;

namespace UnityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            IUnityContainer container = new UnityContainer();
            //注入时要注入当前目标类以及其依赖的类-当不用配置指定注册时，将程序用这种方式写死
            //container.RegisterType<IMonitor, Monitor>().RegisterType<INotify, EmailNotify>();
            UnityConfigurationSection section = 
                (UnityConfigurationSection)ConfigurationManager.GetSection("unity");
            section.Configure(container);
            IMonitor monitor = container.Resolve<IMonitor>();
            monitor.Alarm();            
        }
    }
}
