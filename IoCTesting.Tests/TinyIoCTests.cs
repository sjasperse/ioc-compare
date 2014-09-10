using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IoCTesting.IoC.TinyIoC;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IoCTesting.Tests
{
    [TestClass]
    public class TinyIoCTests : BaseTests
    {
        protected override IoC.IIoC GetContainer()
        {
            return new TinyIoCIoC();
        }
    }
}