using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoCTesting.IoC
{
    public interface IIoC : IDisposable
    {
        void Register<T1, T2>()
            where T1 : class
            where T2 : class, T1;

        void Register(Type service, Type implementation);

        void RegisterInstance<T>(T instance)
            where T : class;

        T Get<T>() where T : class;

        object Get(Type type);

        IEnumerable<T> GetAll<T>() where T : class;
    }
}