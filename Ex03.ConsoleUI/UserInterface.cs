using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Ex03.GarageLogic.VehiclesCreator;
using Ex03.GarageLogic;
namespace Ex03.ConsoleUI
{
    internal class UserInterface
    {
        internal static void WelcomeToTheGarage()
        {
            Garage garage = new Garage();
            bool finish = false;
            string userChoice = null;
            string message = string.Format(
@"Welcome to the garage!
Please choose one of the following options:
1.Enter a new vehicle to the garage
2.Show vehicles's lisence number
3.Change a vehicle's status
4.Add the maximum air value to a vehicle
5.Refule a fuled vehicle
6.Charge an electric vehicle
7.Show a vehicle's data
8.Finish your visit in the garage"
                                        );
            do
            {
                Console.WriteLine(message);
                userChoice = Console.ReadLine();
                finish = ChooseMethod(garage, userChoice);
                Console.Clear();
            } while (finish == false);
        }
        internal static bool ChooseMethod(Garage garage, string i_UserChoice)
        {
            bool finish = false;
            int userChoiceNumber;
            if (int.TryParse(i_UserChoice, out userChoiceNumber) == false)
            {
                throw new FormatException();
            }
            else
            {
                switch (userChoiceNumber)
                {
                    case 1:
                        AddNewVehicleToGarage(garage);
                        break;
                    case 2:
                        ShowLisenceNumbersInGarage(garage);
                        break;
                    case 3:
                        ChangeVehicleStatusInGarage(garage);
                        break;
                    case 4:
                        AddAirToVehicleWheels(garage);
                        break;
                    case 5:
                        RefuelVheicleInGarage(garage);
                        break;
                    case 6:
                        ChargeVehicleInGarage(garage);
                        break;
                    case 7:
                        ShowAllDataOfVehicleInGarage(garage);
                        break;
                    case 8:
                        finish = true;
                        break;
                    default:
                        throw new ArgumentException();
                }
                return finish;
            }
        }
        internal static void AddNewVehicleToGarage(Garage i_Garage)
        {
            string ownerName = null;
            string ownerPhone = null;
            string licenseNumber = null;
            Console.WriteLine("Please enter the licesne number of your vehicle");
            licenseNumber = Console.ReadLine();
            if (i_Garage.VehiclesInGarage.ContainsKey(licenseNumber) == true)
            {
                Console.WriteLine("A vehicle with this license number is already excsits.");
            }
            else
            {
                Console.WriteLine("Please enter your name:");
                ownerName = Console.ReadLine();
                Console.WriteLine("Please enter your phone number:");
                ownerPhone = Console.ReadLine();
                Vehicle newVehicle = CreateVehicle(i_Garage, licenseNumber);
                VehicleInGarage newVehicleInGarage = new VehicleInGarage(ownerName, ownerPhone, newVehicle);
                i_Garage.AddNewVehicle(licenseNumber, newVehicleInGarage);
            }
        }
        internal static Vehicle CreateVehicle(Garage i_Garage,String i_LicenseNumber)
        {
            VehiclesCreator creator = new VehiclesCreator();
            string message = null;
            string userChoice = null;
            int index = 1;
            Console.WriteLine("Choose the type of vehicle to add from the following:");
            foreach (String element in VehiclesArray)
            {
                message = string.Format("{0}. {1}", index, element);
                Console.WriteLine(message);
                index++;
            }
            userChoice = Console.ReadLine();
            Vehicle newVehicle = i_Garage.CreateNewVehicle(userChoice);
            //method for a vehicle data
            //method for type of vehicle data
            //method for type of engine data
            return newVehicle;
        }
        internal static void ShowLisenceNumbersInGarage(Garage i_Garage)
        {

        }
        internal static void ChangeVehicleStatusInGarage(Garage i_Garage)
        {

        }
        internal static void AddAirToVehicleWheels(Garage i_Garage)
        {

        }
        internal static void RefuelVheicleInGarage(Garage i_Garage)
        {

        }
        internal static void ChargeVehicleInGarage(Garage i_Garage)
        {

        }
        internal static void ShowAllDataOfVehicleInGarage(Garage i_Garage)
        {

        }
    }
}
