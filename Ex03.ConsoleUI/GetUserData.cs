using Ex03.GarageLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.ConsoleUI
{
    internal class GetUserData
    {
        internal static string GetUserChoice()
        {
            VehiclesCreator creator = new VehiclesCreator();
            string message = null;
            string userChoice = null;
            int index = 1;
            Console.WriteLine("Choose the type of vehicle to add from the following:");
            foreach (string element in creator.VehiclesArray)
            {
                message = string.Format("{0}. {1}", index, element);
                Console.WriteLine(message);
                index++;
            }
            userChoice = Console.ReadLine();
            return userChoice;
        }
        internal static string GetOwnerName()
        {
            Console.WriteLine("Please enter your name:");
            string ownerName = Console.ReadLine();
            return ownerName;
        }
        internal static string GetOwnerPhoneNumber()
        {
            Console.WriteLine("Please enter your phone number:");
            string ownerPhoneNumber = Console.ReadLine();
            return ownerPhoneNumber;
        }
        internal static string GetLicensePlateID(Garage i_Garage, bool i_ExcistOrNot)
        {
            Console.WriteLine("Please enter the license plate's ID of your vehicle:");
            string licensePlateID = Console.ReadLine();
            i_Garage.CheckIfLicensePlateIDExcistsOrNot(licensePlateID, i_ExcistOrNot);
            return licensePlateID;
        }
        internal static eVehicleStatus GetVehicleStatus(Garage i_Garage)
        {
            Console.WriteLine("Choose the status of vehicle:");
            string vheicleStatusString = Console.ReadLine();
            eVehicleStatus vehicleStatus = i_Garage.CheckIfStatusValid(vheicleStatusString);
            return vehicleStatus;
        }
        internal static eFuelType GetFuelType(Garage i_Garage)
        {
            Console.WriteLine("Choose vehicle's fuel type:");
            string fuelTypeString = Console.ReadLine();
            eFuelType fuelType = i_Garage.CheckIfFuelTypeValid(fuelTypeString);
            return fuelType;
        }
        internal static float ChooseAmountOfFuelToFill()
        {
            Console.WriteLine("Choose amount to fuel to fill");
            float amountToFill = float.Parse(Console.ReadLine());
            return amountToFill;
        }
    }
}
