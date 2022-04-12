using ProductCatalog.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductCatalog.API.ViewModel
{
    public class ProductModel
    {
       
        //sucess ghh


        public List<productModel> _products { get; set; }
        public List<productModel> findAll()
        {
            _products = new List<productModel>
            {
                new productModel()
                {
                    Id ="1",
                    Name="SAMSUNG",
                    price =20000

                },
                new productModel()
                {
                    Id ="2",
                    Name="NOKIA",
                    price =25000

                },
                 new productModel()
                {
                    Id ="3",
                    Name="SONY",
                    price =25000

                },
                  new productModel()
                {
                    Id ="4",
                    Name="REDMI",
                    price =25000

                },
                   new productModel()
                {
                    Id ="5",
                    Name="Realme",
                    price =20000

                }
            };
            return _products;
        }
        

    }
}

