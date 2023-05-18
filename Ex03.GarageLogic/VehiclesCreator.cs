using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex03.GarageLogic;
namespace Ex03.ConsoleUI
{
    public class VehiclesCreator
    {
        public enum eVehiclesTypes
        {
            FuledMotorcycle,
            ElectricMotocycle,
            FuledCar,
            ElectricCar,
            Truck
        }
        public Vehicle CreateVehicle(string i_VehicleType)
        {
            if(i_VehicleType == eVehiclesTypes.ElectricCar.ToString())
            {
                return new ElectricCar();
            }
            else if(i_VehicleType == eVehiclesTypes.ElectricMotocycle.ToString())
            {
                return new ElectricMotorCycle();
            }
            else if(i_VehicleType == eVehiclesTypes.FuledCar.ToString())
            {
                return new FueledCar();
            }
            else if(i_VehicleType==eVehiclesTypes.ElectricCar.ToString())
            {
                return new ElectricCar();
            }
            else if(i_VehicleType == eVehiclesTypes.Truck.ToString()) 
            {
                return new Truck();
            }
            else
            {
                //exception
                return null;
            }
        }
    }
}
