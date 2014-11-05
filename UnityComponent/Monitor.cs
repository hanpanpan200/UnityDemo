
namespace UnityComponent
{
    public class Monitor:IMonitor
    {
        private INotify notify;
        public Monitor()
        { 
        }
        //使用构造函数初始化内部的INotify与用方法注入的方式初始化它具有相同的效果
        //public Monitor(INotify argNotify)
        //{
        //    notify = argNotify;
        //}
        
        //根据特性InjetionMethod，容器会自动实例化GetNotify方法所依赖的对象，并自动调用该方法，将其注入到方法中。
        [Microsoft.Practices.Unity.InjectionMethod]
        public void GetNotify(INotify n)
        {
            notify = n;
        }
        #region IMonitor 成员

        public void Alarm()
        {
            if (notify == null) return;
            notify.SendMessage();
        }
        
        #endregion
    }
}
