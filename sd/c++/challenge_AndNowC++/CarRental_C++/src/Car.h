#ifndef CAR_H
#define CAR_H

#include <string>


class Car {
    private:
        float pricePerKm;
    public:
        string Manufacturer; 
        string Model;
        int BuildYear;
        string LicencePlate;
        int Kilometers;
        bool IsAvailable;

        Car(string manufacturer, string model, int buildYear, string licencePlate, float pricePerKm);

        bool Rent();
        virtual float Return(int kilometers);
        void Clean();

};

#endif
