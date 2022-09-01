using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeApplicantShop
{
    class Product
    {
        public string id, brand, model, price;

        public Product(string id, string brand, string model, string price)
        {
            this.id = id;
            this.brand = brand;
            this.model = model;
            this.price = price;
        }

    }
}
