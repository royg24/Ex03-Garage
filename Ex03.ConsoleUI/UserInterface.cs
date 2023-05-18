using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                switch(userChoiceNumber)
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
