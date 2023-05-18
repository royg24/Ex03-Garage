using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex03.GarageLogic;
namespace Ex03.GarageLogic
{
    public class VehiclesCreator
    {
        private String[] m_VehiclesArray = { "Electric car", "Electric motorcycle", "Fuled car", "Fuled motorcycle", "Truck" };
        public Vehicle CreateVehicle(string i_UserChoice)
        {
            int userChoiceNumber;
            if(int.TryParse(i_UserChoice, out userChoiceNumber) == false)
            {
                throw new FormatException();
            }
            Vehicle result;
            if(i_UserChoice == "1")
            {
                result = new ElectricCar();
            }
            else if(i_UserChoice == "2")
            {
                result = new ElectricMotorCycle();
            }
            else if(i_UserChoice == "3")
            {
                result = new FueledCar();
            }
            else if(i_UserChoice == "4")
            {
                result = new ElectricCar();
            }
            else if(i_UserChoice == "5") 
            {
                result = new Truck();
            }
            else
            {
                throw new ArgumentException();
            }
            return result;
        }
        public String[] VehiclesArray
        {
            get
            {
                return m_VehiclesArray;
            }
        }
    }
}
