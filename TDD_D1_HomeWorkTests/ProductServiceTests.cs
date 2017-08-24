using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD_D1_HomeWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpectedObjects;
using FluentAssertions;

namespace TDD_D1_HomeWork.Tests
{
    [TestClass()]
    public class ProductServiceTests
    {
        /// <summary>
        /// 該11筆資料，如果要3筆成一組，取得Cost的總和的話，預期結果是 6,15, 24, 21
        /// </summary>
        [TestMethod]
        public void Three_group_of_costs_return_sum()
        {
            //arrange
            List<ProductData> ProductData = new List<ProductData>();
            ProductData.Add(new ProductData { Id = 1, Cost = 1, Revenue = 11, SellPrice = 21 });
            ProductData.Add(new ProductData { Id = 2, Cost = 2, Revenue = 12, SellPrice = 22 });
            ProductData.Add(new ProductData { Id = 3, Cost = 3, Revenue = 13, SellPrice = 23 });
            ProductData.Add(new ProductData { Id = 4, Cost = 4, Revenue = 14, SellPrice = 24 });
            ProductData.Add(new ProductData { Id = 5, Cost = 5, Revenue = 15, SellPrice = 25 });
            ProductData.Add(new ProductData { Id = 6, Cost = 6, Revenue = 16, SellPrice = 26 });
            ProductData.Add(new ProductData { Id = 7, Cost = 7, Revenue = 17, SellPrice = 27 });
            ProductData.Add(new ProductData { Id = 8, Cost = 8, Revenue = 18, SellPrice = 28 });
            ProductData.Add(new ProductData { Id = 9, Cost = 9, Revenue = 19, SellPrice = 29 });
            ProductData.Add(new ProductData { Id = 10, Cost = 10, Revenue = 20, SellPrice = 30 });
            ProductData.Add(new ProductData { Id = 11, Cost = 11, Revenue = 21, SellPrice = 31 });

            Product product = new Product()
            {
                Count = 3,
                Column = "Cost",
                ProductData = ProductData
            };

            var PS = new ProductService();
            int[] expected = new int[] { 6, 15, 24, 21 };

            //act
            int[] actual = PS.GetResult(product);

            //assert
            expected.ToExpectedObject().ShouldEqual(actual);

        }

        /// <summary>
        /// 該11筆資料，如果是4筆一組，取得 Revenue 總和的話，預期結果會是 50,66,60
        /// </summary>
        [TestMethod]
        public void Four_group_of_Revenues_return_sum()
        {
            //arrange
            List<ProductData> ProductData = new List<ProductData>();
            ProductData.Add(new ProductData { Id = 1, Cost = 1, Revenue = 11, SellPrice = 21 });
            ProductData.Add(new ProductData { Id = 2, Cost = 2, Revenue = 12, SellPrice = 22 });
            ProductData.Add(new ProductData { Id = 3, Cost = 3, Revenue = 13, SellPrice = 23 });
            ProductData.Add(new ProductData { Id = 4, Cost = 4, Revenue = 14, SellPrice = 24 });
            ProductData.Add(new ProductData { Id = 5, Cost = 5, Revenue = 15, SellPrice = 25 });
            ProductData.Add(new ProductData { Id = 6, Cost = 6, Revenue = 16, SellPrice = 26 });
            ProductData.Add(new ProductData { Id = 7, Cost = 7, Revenue = 17, SellPrice = 27 });
            ProductData.Add(new ProductData { Id = 8, Cost = 8, Revenue = 18, SellPrice = 28 });
            ProductData.Add(new ProductData { Id = 9, Cost = 9, Revenue = 19, SellPrice = 29 });
            ProductData.Add(new ProductData { Id = 10, Cost = 10, Revenue = 20, SellPrice = 30 });
            ProductData.Add(new ProductData { Id = 11, Cost = 11, Revenue = 21, SellPrice = 31 });

            Product product = new Product()
            {
                Count = 4,
                Column = "Revenue",
                ProductData = ProductData
            };

            var PS = new ProductService();
            int[] expected = new int[] { 50, 66, 60 };

            //act
            int[] actual = PS.GetResult(product);

            //assert
            expected.ToExpectedObject().ShouldEqual(actual);

        }

        /// <summary>
        /// 筆數輸入負數，預期會拋 ArgumentException
        /// </summary>
        [TestMethod]
        public void Input_negative_return_argumentException()
        {
            //arrange
            List<ProductData> ProductData = new List<ProductData>();
            ProductData.Add(new ProductData { Id = 1, Cost = 1, Revenue = 11, SellPrice = 21 });
            ProductData.Add(new ProductData { Id = 2, Cost = 2, Revenue = 12, SellPrice = 22 });
            ProductData.Add(new ProductData { Id = 3, Cost = 3, Revenue = 13, SellPrice = 23 });
            ProductData.Add(new ProductData { Id = 4, Cost = 4, Revenue = 14, SellPrice = 24 });
            ProductData.Add(new ProductData { Id = 5, Cost = 5, Revenue = 15, SellPrice = 25 });
            ProductData.Add(new ProductData { Id = 6, Cost = 6, Revenue = 16, SellPrice = 26 });
            ProductData.Add(new ProductData { Id = 7, Cost = 7, Revenue = 17, SellPrice = 27 });
            ProductData.Add(new ProductData { Id = 8, Cost = 8, Revenue = 18, SellPrice = 28 });
            ProductData.Add(new ProductData { Id = 9, Cost = 9, Revenue = 19, SellPrice = 29 });
            ProductData.Add(new ProductData { Id = 10, Cost = 10, Revenue = 20, SellPrice = 30 });
            ProductData.Add(new ProductData { Id = 11, Cost = 11, Revenue = 21, SellPrice = 31 });

            Product product = new Product()
            {
                Count = -4,
                Column = "Revenue",
                ProductData = ProductData
            };

            var PS = new ProductService();
            int[] expected = new int[] { 50, 66, 60 };

            //act
            Action act = () => PS.GetResult(product);

            //assert
            act.ShouldThrow<ArgumentException>();

        }

        /// <summary>
        /// 尋找的欄位若不存在，預期會拋 ArgumentException
        /// </summary>
        [TestMethod]
        public void Item_is_not_found_return_argumentException()
        {
            //arrange
            List<ProductData> ProductData = new List<ProductData>();
            ProductData.Add(new ProductData { Id = 1, Cost = 1, Revenue = 11, SellPrice = 21 });
            ProductData.Add(new ProductData { Id = 2, Cost = 2, Revenue = 12, SellPrice = 22 });
            ProductData.Add(new ProductData { Id = 3, Cost = 3, Revenue = 13, SellPrice = 23 });
            ProductData.Add(new ProductData { Id = 4, Cost = 4, Revenue = 14, SellPrice = 24 });
            ProductData.Add(new ProductData { Id = 5, Cost = 5, Revenue = 15, SellPrice = 25 });
            ProductData.Add(new ProductData { Id = 6, Cost = 6, Revenue = 16, SellPrice = 26 });
            ProductData.Add(new ProductData { Id = 7, Cost = 7, Revenue = 17, SellPrice = 27 });
            ProductData.Add(new ProductData { Id = 8, Cost = 8, Revenue = 18, SellPrice = 28 });
            ProductData.Add(new ProductData { Id = 9, Cost = 9, Revenue = 19, SellPrice = 29 });
            ProductData.Add(new ProductData { Id = 10, Cost = 10, Revenue = 20, SellPrice = 30 });
            ProductData.Add(new ProductData { Id = 11, Cost = 11, Revenue = 21, SellPrice = 31 });

            Product product = new Product()
            {
                Count = 4,
                Column = "Costs",
                ProductData = ProductData
            };

            var PS = new ProductService();
            int[] expected = new int[] { 50, 66, 60 };

            //act
            Action act = () => PS.GetResult(product);

            //assert
            act.ShouldThrow<ArgumentException>();

        }

        /// <summary>
        /// 筆數若輸入為0, 則傳回0
        /// </summary>
        [TestMethod]
        public void Item_zero_return_zero()
        {
            //arrange
            List<ProductData> ProductData = new List<ProductData>();
            ProductData.Add(new ProductData { Id = 1, Cost = 1, Revenue = 11, SellPrice = 21 });
            ProductData.Add(new ProductData { Id = 2, Cost = 2, Revenue = 12, SellPrice = 22 });
            ProductData.Add(new ProductData { Id = 3, Cost = 3, Revenue = 13, SellPrice = 23 });
            ProductData.Add(new ProductData { Id = 4, Cost = 4, Revenue = 14, SellPrice = 24 });
            ProductData.Add(new ProductData { Id = 5, Cost = 5, Revenue = 15, SellPrice = 25 });
            ProductData.Add(new ProductData { Id = 6, Cost = 6, Revenue = 16, SellPrice = 26 });
            ProductData.Add(new ProductData { Id = 7, Cost = 7, Revenue = 17, SellPrice = 27 });
            ProductData.Add(new ProductData { Id = 8, Cost = 8, Revenue = 18, SellPrice = 28 });
            ProductData.Add(new ProductData { Id = 9, Cost = 9, Revenue = 19, SellPrice = 29 });
            ProductData.Add(new ProductData { Id = 10, Cost = 10, Revenue = 20, SellPrice = 30 });
            ProductData.Add(new ProductData { Id = 11, Cost = 11, Revenue = 21, SellPrice = 31 });

            Product product = new Product()
            {
                Count = 0,
                Column = "Revenue",
                ProductData = ProductData
            };

            var PS = new ProductService();
            int[] expected = new int[]{ 0};

            //act
            int[] actual = PS.GetResult(product);

            //assert
            expected.ToExpectedObject().ShouldEqual(actual);

        }

        /// <summary>
        /// 希望這個API可以給其他 domain entity 用，例如 Employee
        /// </summary>
        [TestMethod]
        public void Use_Employee()
        {
            //arrange
            Employee employee = new Employee();
              var PS = new ProductService();
            int expected = 0;

            //act
            int[] actual = PS.GetResult(employee);

            //assert
            expected.ToExpectedObject().ShouldEqual(actual.Length);

        }

        /// <summary>
        /// 未來可能會新增其他欄位
        /// </summary>
        [TestMethod]
        public void Create_other_column()
        {

            //arrange

            //act

            //assert

        }

    }

}