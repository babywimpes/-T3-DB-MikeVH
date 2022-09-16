using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental_OOP2
{
    public class Sedan : Car
    {
        private int lastCleanedAtKm;

        private const Decimal pricePerKm = 0.29m;
        public bool HasTowbar { get; private set; }

        public override bool NeedsCleaning
        {
            get
            {
                return (Kilometers - lastCleanedAtKm) >= 1000;
            }
        }       

        public Sedan(string manufacturer, string model, int buildYear, string licencePlate, bool hasTowbar)
            : base(manufacturer, model, buildYear, licencePlate, pricePerKm)
        {
            HasTowbar = hasTowbar;
            lastCleanedAtKm = 0;
        }

        public override void Clean()
        {
            lastCleanedAtKm = Kilometers;
        }

    }
}
