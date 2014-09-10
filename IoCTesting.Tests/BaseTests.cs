using System;
using FluentAssertions;
using IoCTesting.IoC;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IoCTesting.Tests
{
    [TestClass]
    public abstract class BaseTests
    {
        protected abstract IIoC GetContainer();

        private IIoC ioc;

        [TestInitialize]
        public virtual void TestInitialize()
        {
            ioc = GetContainer();

            ioc.Register<I1, Test1>();
            ioc.Register<I2, Test2>();
            ioc.Register(typeof(I3), typeof(Test3));
            ioc.RegisterInstance<I4>(new Test4());
        }

        [TestMethod]
        public void Get_DeepObject()
        {
            ioc.Get<I1>().Should().NotBeNull();
        }

        [TestMethod]
        public void Get_ReturnSameInstance()
        {
            var i1 = ioc.Get<I1>();
            var i2 = ioc.Get<I1>();

            i1.Should().BeSameAs(i2);
        }

        [TestMethod]
        public void Get_TypeRegisteredByInstance()
        {
            ioc.Get<I4>().Should().NotBeNull();
        }

        [TestMethod]
        public void Get_TypeRegisteredByInstance_SameInstance()
        {
            var i1 = ioc.Get<I4>();
            var i2 = ioc.Get<I4>();

            i1.Should().BeSameAs(i2);
        }

        [TestMethod]
        public void Get_ByType()
        {
            ioc.Get(typeof(I1)).Should().NotBeNull();
        }

        [TestMethod]
        public void Register_Double_GetShouldNotBeNull()
        {
            ioc.Register<I6, Test6_1>();
            ioc.Register<I6, Test6_2>();

            ioc.Get<I6>().Should().NotBeNull();
        }

        [TestMethod]
        public void Register_Double_GetShouldReturnSecondType()
        {
            ioc.Register<I6, Test6_1>();
            ioc.Register<I6, Test6_2>();

            ioc.Get<I6>().Should().BeOfType<Test6_2>();
        }

        [TestMethod]
        public void Register_Double_GetAllShouldReturnBoth()
        {
            ioc.Register<I6, Test6_1>();
            ioc.Register<I6, Test6_2>();

            ioc.GetAll<I6>().Should().HaveCount(2);
        }

        [TestMethod]
        public void RegisterHandlesMultipleConstructors()
        {
            ioc.Register<I5, Test5>();

            var i5 = ioc.Get<I5>();
            i5.Should().NotBeNull();
            i5.I2.Should().NotBeNull();
            i5.I3.Should().NotBeNull();
        }
    }
}