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
        private const string k_EndString = "END";
        private const string k_ReturnString = "RETURN";
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
                Console.Clear();
                Console.WriteLine(message);
                userChoice = Console.ReadLine();
                Console.Clear();
                finish = ChooseMethod(garage, userChoice);
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
                        ShowLisencePlatesIDInGarage(garage);
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
            string licensePlate = null;
            Console.WriteLine("Please enter the licesne plate's ID number of your vehicle");
            licensePlate = Console.ReadLine();
            Console.Clear();
            if (i_Garage.VehiclesInGarage.ContainsKey(licensePlate) == true)
            {
                Console.WriteLine("A vehicle with this license plate's ID is already excsits.");
            }
            else
            {
                Console.WriteLine("Please enter your name:");
                ownerName = Console.ReadLine();
                Console.WriteLine("Please enter your phone number:");
                ownerPhone = Console.ReadLine();
                Console.Clear();
                Vehicle newVehicle = CreateVehicle(i_Garage, licensePlate);
                VehicleInGarage newVehicleInGarage = new VehicleInGarage(ownerName, ownerPhone, newVehicle);
                i_Garage.AddNewVehicle(licensePlate, newVehicleInGarage);
            }
        }
        internal static Vehicle CreateVehicle(Garage i_Garage,string i_LicensePlate)
        {
            VehiclesCreator creator = new VehiclesCreator();
            List<string> vehicleData = null;
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
            Console.Clear();
            Vehicle newVehicle = i_Garage.CreateNewVehicle(userChoice);
            newVehicle.AddLisencePlate(i_LicensePlate);
            vehicleData = GetVehicleData();
            newVehicle.FillVehicleData(ref vehicleData);
            return newVehicle;
        }
        internal static List<string> GetVehicleData()
        {
            List<string> data = new List<string>();
            string message = null;
            string input = null;
            message = string.Format(
 @"Please enter your vehicle's data in the following order:
for every vehicle:
    1. Vehicle's model.
    2. Presentage of energy left.

according to vehicle's type:
    for a car:
        1. Car's color (red, white, yellow or black).
        2. Number of doors.
    for a motorcycle:
        1. Lisence type (A1, A2, AA, B1).
        2. Engine volume.
    for a truck:
        1. is it delivers a dangerous substance (Y/N).
        2. Cargo volume.

for every vehicle:
    1. Wheels manufacturer Name.
    2. Wheels current air pressure.

according to vehicle's engine type:
    for a vehicle with a fuled engine
        1. Vehicle' current fuel amount.
    for a vehicle with an electric engine:
        1. Vehicle's current hours left in the battery.

Please write END when you finish put the data."
                        );
            Console.WriteLine(message);
            do
            {
                input = Console.ReadLine();
                data.Add(input);
            } while (input != k_EndString);
            return data;
        }
        internal static void ShowLisencePlatesIDInGarage(Garage i_Garage)
        {
            string returnString = null;
            string message = null;
            string vheicleStatusString = null;
            eVehicleStatus vehicleStatus;
            int counter = 0;
            Console.WriteLine("Choose the status to see all license plate's ID from vehicles with this status");
            vheicleStatusString = Console.ReadLine();
            vehicleStatus = i_Garage.CheckIfStatusValid(vheicleStatusString);
            message = string.Format("The license plate's ID of vehicle that {0} are:", vheicleStatusString);
            Tuple<string, eVehicleStatus>[] lisencePlatesIdArray = i_Garage.GetLisencePlateID();
            foreach (Tuple<string, eVehicleStatus> element in lisencePlatesIdArray)
            {
                if(element.Item2 == vehicleStatus)
                {
                    Console.WriteLine(element.Item1);
                    counter++;
                }
            }
            if (counter == 0)
            {
                message = string.Format("No vehicles under the status \"{0}\" in the garage", vheicleStatusString);
                Console.WriteLine(message);
            }
            Console.WriteLine("Press RETURN to return to main menu");
            do
            {
                returnString = Console.ReadLine();
            } while (returnString != k_ReturnString);
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
