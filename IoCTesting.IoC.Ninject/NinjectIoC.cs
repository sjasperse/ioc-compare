using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace IoCTesting.IoC.Ninject
{
    public class NinjectIoC : IIoC
    {
        private readonly IKernel ioc = new StandardKernel();

        public void Register<T1, T2>()
            where T1 : class
            where T2 : class, T1
        {
            ioc.Bind<T1>().To<T2>();
        }

        public void Register(Type service, Type implementation)
        {
            ioc.Bind(service).To(implementation);
        }

        public void RegisterAsSingleton<T1, T2>()
            where T1 : class
            where T2 : class, T1
        {
            ioc.Bind<T1>().To<T2>().InSingletonScope();
        }

        public T Get<T>()
            where T : class
        {
            return ioc.Get<T>();
        }

        public IEnumerable<T> GetAll<T>() where T : class
        {
            return ioc.GetAll<T>();
        }

        public void Dispose()
        {
            ioc.Dispose();
        }

        public void RegisterInstance<T>(T instance) where T : class
        {
            ioc.Bind<T>().ToConstant(instance);
        }

        public void RegisterWithCallback<T>(Func<T> callback) where T : class
        {
            ioc.Bind<T>().ToMethod((context => callback()));
        }

        public object Get(Type type)
        {
            return ioc.Get(type);
        }
    }
}