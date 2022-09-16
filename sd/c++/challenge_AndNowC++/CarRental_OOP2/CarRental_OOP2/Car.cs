using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental_OOP2
{
    public abstract class Car
    {
        private Decimal pricePerKm;

        public string Manufacturer { get; private set; }
        public string Model { get; private set; }
        public int BuildYear { get; private set; }
        public string LicencePlate { get; private set; }
        public int Kilometers { get; set; }
        public bool IsAvailable { get; set; }

        public abstract bool NeedsCleaning { get; }


        public Car(string manufacturer, string model, int buildYear, string licencePlate, Decimal pricePerKm)
        {
            if ((manufacturer == null) || (model == null) || (licencePlate == null))
            {
                throw new ArgumentNullException();
            }
            if (buildYear < 1890)
            {
                throw new ArgumentOutOfRangeException("buildYear", "cars cannot be built before 1890!");
            }
            if (pricePerKm < 0)
            {
                throw new ArgumentOutOfRangeException("pricePerKm", "cannot be smaller than 0");
            }

            Manufacturer = manufacturer;
            Model = model;
            BuildYear = buildYear;
            LicencePlate = licencePlate;
            Kilometers = 0;
            IsAvailable = true;
            this.pricePerKm = pricePerKm;
        }

        public bool Rent()
        {
            if (!IsAvailable)
            {
                return false;
            }

            IsAvailable = false;
            return true;
        }

        public virtual decimal Return(int kilometers)
        {
            if (IsAvailable)
            {
                throw new InvalidOperationException("car was not rented");
            }
            if (kilometers < Kilometers)
            {
                throw new ArgumentException("car is returned with less kilometers than it had", "kilometers");
            }

            Decimal cost = pricePerKm * (kilometers - Kilometers);
            Kilometers = kilometers;
            IsAvailable = true;
            return cost;
        }

        public abstract void Clean();

        public override string ToString()
        {
            return Manufacturer +
                   " - " + Model +
                   ", " + LicencePlate;
        }
    }
}
