using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeApplicantShop
{
    class LightBulb : Product
    {
        public string brightness, wattage;
        public bool isSmart;

        public LightBulb(string id, string brand, string model, string price, string brightness, string wattage, bool isSmart)
            :base(id, brand, model, price)
        {
            this.brightness = brightness;
            this.wattage = wattage;
            this.isSmart = isSmart;
        }
        public string display()
        {
            return $"{this.brand}:{this.model}";
        }
    }
}
