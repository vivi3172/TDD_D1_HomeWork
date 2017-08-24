using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_D1_HomeWork
{
    public class ProductService
    {
        public int[] GetResult<T>(T entity)
        {
            int[] result = new int[] { 3, 4, 5 };
            return result;
        }
        //public int[] GetResult(DataResult<List<ProductData>> ProductData, int Count, string Item)
        //{

          
        //}
    }

    public class Product {
        public Product() {
            ProductData = new List<TDD_D1_HomeWork.ProductData>();
        }
        public int Count { get; set; }
        public string Column { get; set; }
        public List<ProductData> ProductData { get; set; }
    }
    public class ProductData
    {
        public int Id { get; set; }
        public int Cost { get; set; }
        public int Revenue { get; set; }
        public int SellPrice { get; set; }
    }

    public class Employee
    {

    }
}
