using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoCTesting.IoC.TinyIoC
{
    public class TinyIoCIoC : IIoC
    {
        private readonly global::TinyIoC.TinyIoCContainer ioc = new global::TinyIoC.TinyIoCContainer();

        public void Register<T1, T2>()
            where T1 : class
            where T2 : class, T1
        {
            ioc.Register<T1, T2>();
        }

        public void Register(Type service, Type implementation)
        {
            ioc.Register(service, implementation);
        }

        public void RegisterAsSingleton<T1, T2>()
            where T1 : class
            where T2 : class, T1
        {
            ioc.Register<T1, T2>();
        }

        public T Get<T>()
            where T : class
        {
            return ioc.Resolve<T>();
        }

        public IEnumerable<T> GetAll<T>() where T : class
        {
            return ioc.ResolveAll<T>();
        }

        public void Dispose()
        {
            ioc.Dispose();
        }

        public void RegisterInstance<T>(T instance) where T : class
        {
            ioc.Register(instance);
        }

        public void RegisterWithCallback<T>(Func<T> callback) where T : class
        {
            ioc.Register((c, o) => callback());
        }

        public object Get(Type type)
        {
            return ioc.Resolve(type);
        }
    }
}