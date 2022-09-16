#include <stdexcept>
using namespace std;

#include "Car.h"

Car::Car(string manufacturer, string model, int buildYear, string licencePlate, float pricePerKm){
    this->Manufacturer = manufacturer;
    this->Model = model;
    this->BuildYear = buildYear;
    this->LicencePlate = licencePlate;
    this->pricePerKm = pricePerKm;
    this->Kilometers = 0;
    this->IsAvailable = true;

    if(manufacturer.empty() || model.empty() || licencePlate.empty()){
        throw invalid_argument("Manufacturer, model and licence plate must not be empty.");
    }
    if(buildYear < 1890){
        throw invalid_argument("The car cannot be build before 1890.");
    }
}


bool Car::Rent(){
    
}

float Car::Return(int kilometers){

}


void Car::Clean(){

}
