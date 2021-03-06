﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    class Program // Projelerde çokça kullanılır. 
                  // Yazılım geliştirme prensiblerinin D harfidir. bir nesnenin başka bir nesneye bağımlılığının olmaması gerektiğini söyler. (dependency)
                  // Harfler arası geçiş yaparken çokça kullanırız. 
                  // farklı ormler kullanırken geçişleri kolayca yapmak 
                  // cross cutting concernlerin yine dependency I ile kullanımı yoğundur.
                  // Genelikle bussiness kodu yazarken, bir bussiness kodunda farklı birini kullanırken kendi içinde bağımlılığı minimize etmeyi önerir.
    {
        static void Main(string[] args)
        {
         
            ProductManager productManager = new ProductManager(new NhProductDal());
            productManager.Save();

            Console.ReadLine();
        }
    }

    interface IProductDal
    {
        void Save();
    }

    class EfProductDal : IProductDal {

        public void Save()
        {
            Console.WriteLine("Saved with Ef");
        }
    }

    class NhProductDal : IProductDal
    {

        public void Save()
        {
            Console.WriteLine("Saved with Nh");
        }
    }

    class ProductDataAccessLayer
    {
        public void Save()
        {
            Console.WriteLine("Saved with entityFramework");
        }
    } 

    class ProductManager
    {

        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Save()
        {
            //Busiiness Code

            _productDal.Save();
            
        }
    }
}
