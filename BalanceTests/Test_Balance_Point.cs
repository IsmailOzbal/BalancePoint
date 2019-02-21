using BalancePoint;
using BalancePoint.Interface;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalanceTests
{
    [TestFixture]
    class Test_Balance_Point
    {

        private Balance<int[], int> manager;

        [SetUp]
        public void Init()
        {
            manager = new BalancePoints();
        }


        [TestCase(new int[] { 100, 200,300,400,500,600 })]
        public void GivenArrayFindBalancePointReturnNotFound(int[] value)
        {
            var balancetest = manager.Manage(value);
            Assert.AreEqual(balancetest,-1);
        }


        [TestCase(new int[] { 1, 5, 9, 7, -1 })]
        public void GivenArrayFindBalancePointReturnFound(int[] value)
        {
            var balancetest = manager.Manage(value);
            Assert.AreEqual(balancetest, 2);
        }

    }
}
