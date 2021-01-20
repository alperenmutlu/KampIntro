using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product
    {
        public int Id { get; set; }

        public int CategoryId { get; set; }

        public string ProductName { get; set; }
        
        //ürünün birim fiyatı
        public double UnitPrice { get; set; }
        
        //ürünün stok adedi
        public int UnitsInStock { get; set; }

        //CRUD,create,read,update,delete

    }
}
