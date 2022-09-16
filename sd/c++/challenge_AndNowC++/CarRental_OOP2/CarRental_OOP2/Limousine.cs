using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental_OOP2
{
    public class Limousine: Car
    {
        private const Decimal pricePerKm = 2.5m;
        private bool needsCleaning;
        
        public bool HasMinibar { get; private set; }
        public override bool NeedsCleaning
        {
            get
            {
                return needsCleaning;
            }
        }

        public Limousine(string manufacturer, string model, int buildYear, string licencePlate, bool hasMinibar)
            : base(manufacturer, model, buildYear, licencePlate, pricePerKm)
        {
            HasMinibar = hasMinibar;
            needsCleaning = false;
        }

        public override decimal Return(int kilometers)
        {
            decimal price = base.Return(kilometers);
            needsCleaning = true;
            return price;
        }

        public override void Clean()
        {
            needsCleaning = false;
        }

    }
}
