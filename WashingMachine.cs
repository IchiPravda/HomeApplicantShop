using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeApplicantShop
{
    class WashingMachine : Product
    {
        public string color;
        public string capacity;
        public Boolean isPortable;

        public WashingMachine(string id, string brand, string model, string price, string color, string capacity, bool isPortable)
            :base(id,brand,model,price)
        {
            this.color = color;
            this.capacity = capacity;
            this.isPortable = isPortable;
        }

        public string display()
        {
            return $"{this.brand}:{this.model}";
        }
    }
}
