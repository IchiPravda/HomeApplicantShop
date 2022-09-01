using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeApplicantShop
{
    class Table : Product
    {
        public string material;
        public string height;
        public Boolean isSecond;

        public Table(string id, string brand, string model, string price, string material, string height, bool isSecond)
            : base(id, brand, model, price)
        {
            this.material = material;
            this.height = height;
            this.isSecond = isSecond;
        }

        public string display()
        {
            return $"{this.brand}:{this.model}";
        }
    }
}
