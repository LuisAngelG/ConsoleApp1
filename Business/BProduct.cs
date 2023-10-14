using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Data;
using Entity;


namespace Business
{
    public class BProduct
    {
       // public List<Product> GetByProductName(string Name)
        //{
         //   List<Product> result = new List<Product>();

         //   DProduct data = new DProduct();

         //   var products = data.Get();

         //   foreach (var item in products)
         //   {
         //       if (item.Name == Name)
         //       {
         //           result.Add(item);
         //       }
         //   }
        //    return result;
        //}

        public List<Product> GetByName(string Name) 
        {
            if (string.IsNullOrEmpty(Name))
            {
                throw new ArgumentNullException("name");
            }

            List<Product> product = new List<Product>();

            DProduct dProduct = new DProduct();
            product = dProduct.GetProducts();

            var results = product.Where(x => x.Name == Name).ToList();

            return results;
        }
    }
}
