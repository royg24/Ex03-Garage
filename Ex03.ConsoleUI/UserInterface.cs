using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Ex03.GarageLogic.VehiclesCreator;
using static Ex03.ConsoleUI.GetUserData;
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
                        AddAMaxAirAmountVehicleWheels(garage);
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
            string ownerPhoneNumber = null;
            string licensePlateID = null;
            licensePlateID = GetLicensePlateID(i_Garage, true);
            Console.Clear();
            ownerName = GetOwnerName();
            ownerPhoneNumber = GetOwnerPhoneNumber();
            Console.Clear();
            Vehicle newVehicle = CreateVehicle(i_Garage, licensePlateID);
            VehicleInGarage newVehicleInGarage = new VehicleInGarage(ownerName, ownerPhoneNumber, newVehicle);
            i_Garage.AddNewVehicle(licensePlateID, newVehicleInGarage);
        }
        internal static Vehicle CreateVehicle(Garage i_Garage,string i_LicensePlate)
        {
            List<string> vehicleData = null;
            string userChoice = GetUserChoice();
            Console.Clear();
            Vehicle newVehicle = i_Garage.CreateNewVehicle(userChoice);
            newVehicle.LicensePlateID = i_LicensePlate;
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
            string message = null;
            string vheicleStatusString = null;
            eVehicleStatus vehicleStatus;
            int counter = 0;
            vehicleStatus = GetVehicleStatus(i_Garage);
            message = string.Format("The license plate's ID of vehicle that {0} are:", vheicleStatusString);
            Tuple<string, eVehicleStatus>[] lisencePlatesIdArray = i_Garage.GetLisencePlateID();
            foreach (Tuple<string, eVehicleStatus> element in lisencePlatesIdArray)
            {
                if (element.Item2 == vehicleStatus)
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
            waitToReturn();
        }
        internal static void ChangeVehicleStatusInGarage(Garage i_Garage)
        {
            string lisencePlateID = GetLicensePlateID(i_Garage, false);
            eVehicleStatus vehicleStatus = GetVehicleStatus(i_Garage);
            i_Garage.ChangeVehicleStatus(lisencePlateID, vehicleStatus);
        }
        internal static void AddAMaxAirAmountVehicleWheels(Garage i_Garage)
        {
            string licensePlateID = GetLicensePlateID(i_Garage, false);
            i_Garage.MakeAirPressureInVehicleMaximum(licensePlateID);
        }
        internal static void RefuelVheicleInGarage(Garage i_Garage)
        {
            string licensePlateID = GetLicensePlateID(i_Garage, false);
            eFuelType fuelType = GetFuelType(i_Garage);
            Console.WriteLine("Choose amount to fuel to fill");
            float amountToFuel = GetFloatFromUser();
            i_Garage.RefuelVheicle(licensePlateID, amountToFuel, fuelType);
        }
        internal static void ChargeVehicleInGarage(Garage i_Garage)
        {
            string licensePlateID = GetLicensePlateID(i_Garage, false);
            Console.WriteLine("Choose amount to minutes to add battery");
            float amountToCharge = GetFloatFromUser();
            amountToCharge /= 60;
            i_Garage.ChargeVehicle(licensePlateID, amountToCharge);
        }
        internal static void ShowAllDataOfVehicleInGarage(Garage i_Garage)
        {

        }
        private static void waitToReturn()
        {
            string returnString = null;
            Console.WriteLine("Press RETURN to return to main menu");
            do
            {
               returnString = Console.ReadLine();
            } while (returnString != k_ReturnString);
        }
    }
}
