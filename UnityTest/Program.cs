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
            if (ConfigurationManager.AppSettings["UseNewStructure"] != null &&
                ConfigurationManager.AppSettings["UseNewStructure"].ToString() == "true")
            {
                Console.WriteLine("通过appSettings配置此处不执行其他语句直接返回");
                return;
            }
            Console.WriteLine("appSettings中不配置值为true的UseNewStructure节点，下面根据Unity配置进行依赖注入");
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
