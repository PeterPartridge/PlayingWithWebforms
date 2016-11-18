using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Webforms.Models;
using Webforms.BusinessLogic;

namespace Webforms.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            productsLogic prolog = new productsLogic();

            prolog.listProducts(500000);
            prolog.listProducts(-200000);
            prolog.listProducts(null);
        }

        [TestMethod]
        public void TestMethod2()
        {
            productsLogic prolog = new productsLogic();

            prolog.productGetItem(2000000);
            prolog.productGetItem(-200000);
            prolog.productGetItem(null);
        }


       
    }
}
