using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental_OOP2
{
    public class RentalAdministration
    {
        public List<Car> Cars { get; private set; }

        public RentalAdministration()
        {
            Cars = new List<Car>();
        }

        public bool Add(Car car)
        {
            if (car == null)
            {
                throw new ArgumentNullException();
            }

            if (FindCar(car.LicencePlate) != null)
            {
                return false;
            }
            Cars.Add(car);
            return true;
        }

        public bool RentCar(string licencePlate)
        {
            if (licencePlate == null)
            {
                throw new ArgumentNullException();
            }

            Car car = FindCarWithException(licencePlate);
            return car.Rent();
        }

        public decimal ReturnCar(string licencePlate, int kilometers)
        {
            if(licencePlate == null)
            {
                throw new ArgumentNullException();
            }

            Car car = FindCarWithException(licencePlate);
            if (car.IsAvailable)
            {
                throw new ArgumentException("car is not rented", "licencePlate");
            }

            return car.Return(kilometers);
        }

        public void CleanCar(string licencePlate)
        {
            if (licencePlate == null)
            {
                throw new ArgumentNullException();
            }

            Car car = FindCarWithException(licencePlate);
            car.Clean();
        }

        private Car FindCar(string licencePlate)
        {
            foreach (Car car in Cars)
            {
                if (car.LicencePlate == licencePlate)
                {
                    return car;
                }
            }
            return null;
        }

        private Car FindCarWithException(string licencePlate)
        {
            Car car = FindCar(licencePlate);
            if (car == null)
            {
                throw new ArgumentOutOfRangeException("licencePlate", "no car with this licenceplate in administration");
            }
            return car;
        }
    }
}
