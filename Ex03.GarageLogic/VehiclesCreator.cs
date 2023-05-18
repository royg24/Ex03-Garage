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
            if(userChoiceNumber == 1)
            {
                result = new ElectricCar();
            }
            else if(userChoiceNumber == 2)
            {
                result = new ElectricMotorCycle();
            }
            else if(userChoiceNumber == 3)
            {
                result = new FueledCar();
            }
            else if(userChoiceNumber == 4)
            {
                result = new ElectricCar();
            }
            else if(userChoiceNumber == 5) 
            {
                result = new Truck();
            }
            else
            {
                throw new ArgumentException();
            }
            return result;
        }
        public static String[] VehiclesArray
        {
            get
            {
                return m_VehiclesArray;
            }
        }
    }
}
