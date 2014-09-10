using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoCTesting
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            foreach (var ioc in DependencyResolver.DependencyResolver.GetAllContainers())
            {
                ioc.Register<I1, Test1>();
                ioc.Register<I2, Test2>();
                ioc.Register(typeof(I3), typeof(Test3));

                ioc.Get<I1>();
                ioc.Get<I2>();
                ioc.Get<I3>();
            }
        }
    }

    public interface I1
    {
    }

    public interface I2
    {
    }

    public interface I3
    {
    }

    public interface I4
    {
    }

    public class Test1 : I1
    {
        public Test1(I2 i2, I3 i3)
        {
        }
    }

    public class Test2 : I2
    {
        public Test2(I3 i3)
        {
        }
    }

    public class Test3 : I3
    {
    }
}