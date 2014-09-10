using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoCTesting.IoC.LightInject
{
    public class LightInjectIoC : IIoC
    {
        private readonly global::LightInject.ServiceContainer ioc = new global::LightInject.ServiceContainer();

        public void Register<T1, T2>()
            where T1 : class
            where T2 : class, T1
        {
            ioc.Register<T1, T2>();
        }

        public void RegisterAsSingleton<T1, T2>()
            where T1 : class
            where T2 : class, T1
        {
            Register<T1, T2>();
        }

        public void Register(Type service, Type implementation)
        {
            ioc.Register(service, implementation);
        }

        public T Get<T>() where T : class
        {
            return ioc.GetInstance<T>();
        }

        public IEnumerable<T> GetAll<T>() where T : class
        {
            return ioc.GetAllInstances<T>();
        }

        public void Dispose()
        {
            ioc.Dispose();
        }

        public void RegisterInstance<T>(T instance) where T : class
        {
            ioc.RegisterInstance(instance);
        }

        public void RegisterWithCallback<T>(Func<T> callback) where T : class
        {
            throw new NotImplementedException();
        }

        public object Get(Type type)
        {
            return ioc.GetInstance(type);
        }
    }
}