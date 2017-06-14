using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Aggregate;
using System.Linq;
using FluentAssertions;

namespace AggregateTest.Test
{
    [TestClass()]
    public class AggregateTest
    {
        [TestMethod()]
        public void rows_3_column_cost_sum_should_be_6_15_24_21()
        {
            //arrange
            var target = new AggregateGoods();
            var goods = GetGoods();
            var excepted = new List<int> { 6, 15, 24, 21};

            //act
            var actual = target.Sum(goods, 3, "Code");

            //assert
            Assert.AreEqual(excepted, actual);
        }

        [TestMethod()]
        public void rows_4_column_revenue_sum_should_be_50_66_60()
        {
            //arrange
            var target = new AggregateGoods();
            var goods = GetGoods();
            var excepted = new List<int> { 50, 66, 60};

            //act
            var actual = target.Sum(goods, 4, "Revenue");

            //assert
            Assert.AreEqual(excepted, actual);
        }

        [TestMethod()]
        public void rows_less_than_0_throw_argumentException()
        {
            //arrange
            var target = new AggregateGoods();
            var goods = GetGoods();

            //act
            Action actual = () => target.Sum(goods, 0, "Revenue");

            //assert
            actual.ShouldThrow<ArgumentException>();
        }

        private class Goods
        {
            public int Id { get; set; }
            public int Cost { get; set; }
            public int Revenue { get; set; }
            public int SellPrice { get; set; }
        }

        private List<Goods> GetGoods()
        {
            var goods = new List<Goods>()
            {
                new Goods() { Id = 1, Cost = 1, Revenue = 11, SellPrice = 21 },
                new Goods() { Id = 2, Cost = 2, Revenue = 12, SellPrice = 22 },
                new Goods() { Id = 3, Cost = 3, Revenue = 13, SellPrice = 23 },
                new Goods() { Id = 4, Cost = 4, Revenue = 14, SellPrice = 24 },
                new Goods() { Id = 5, Cost = 5, Revenue = 15, SellPrice = 25 },
                new Goods() { Id = 6, Cost = 6, Revenue = 16, SellPrice = 26 },
                new Goods() { Id = 7, Cost = 7, Revenue = 17, SellPrice = 27 },
                new Goods() { Id = 8, Cost = 8, Revenue = 18, SellPrice = 28 },
                new Goods() { Id = 9, Cost = 9, Revenue = 19, SellPrice = 29 },
                new Goods() { Id = 10, Cost = 10, Revenue = 20, SellPrice = 30 },
                new Goods() { Id = 11, Cost = 11, Revenue = 21, SellPrice = 31 }
            };
            return goods;
        }
    }
}
