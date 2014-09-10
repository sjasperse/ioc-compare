using System;
using IoCTesting.IoC.Ninject;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IoCTesting.Tests
{
    [TestClass]
    public class NinjectTests : BaseTests
    {
        protected override IoC.IIoC GetContainer()
        {
            return new NinjectIoC();
        }
    }
}