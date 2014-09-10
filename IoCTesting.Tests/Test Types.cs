using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoCTesting.Tests
{
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

    public interface I5
    {
        I2 I2 { get; }

        I3 I3 { get; }
    }

    public interface I6
    {
        string Type { get; }
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

    public class Test4 : I4
    {
    }

    public class Test5 : I5
    {
        public Test5()
        {
        }

        public Test5(I2 i2, I3 i3)
        {
            this.I2 = i2;
            this.I3 = i3;
        }

        public I2 I2 { get; set; }

        public I3 I3 { get; set; }
    }

    public class Test6_1 : I6
    {
        public string Type { get { return "6_1"; } }
    }

    public class Test6_2 : I6
    {
        public string Type { get { return "6_2"; } }
    }
}