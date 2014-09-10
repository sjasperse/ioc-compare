using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IoCTesting.IoC;
using IoCTesting.IoC.LightInject;
using IoCTesting.IoC.Ninject;
using IoCTesting.IoC.SimpleInject;
using IoCTesting.IoC.TinyIoC;

namespace IoCTesting.DependencyResolver
{
    public class DependencyResolver
    {
        public static IEnumerable<IIoC> GetAllContainers()
        {
            yield return new NinjectIoC();
            yield return new LightInjectIoC();
            yield return new TinyIoCIoC();
            yield return new SimpleInjectIoC();
        }
    }
}