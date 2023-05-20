using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Ex03.GarageLogic
{
    public class Garage
    {
        Dictionary<String, VehicleInGarage> m_VehiclesInGarage;
        public Garage()
        {
            m_VehiclesInGarage = new Dictionary<string, VehicleInGarage> ();
        }
        public Dictionary<String, VehicleInGarage> VehiclesInGarage
        {
            get
            {
                return m_VehiclesInGarage;
            }
        }
        public Vehicle CreateNewVehicle(String i_VehicleType)
        {
            VehiclesCreator creator = new VehiclesCreator();
            Vehicle newVehicle = creator.CreateVehicle(i_VehicleType);
            return newVehicle;
        }
        public void AddNewVehicle(String i_LisenceNumber,VehicleInGarage i_NewVehicle)
        {
            m_VehiclesInGarage.Add(i_LisenceNumber, i_NewVehicle);
        }
        public Tuple<String, eVehicleStatus>[] GetLisencePlateID()
        {
            Tuple<String, eVehicleStatus>[] LisenceNumbersArray = new Tuple<String, eVehicleStatus>[m_VehiclesInGarage.Count];
            int index = 0;
            foreach (string licensePlateId in m_VehiclesInGarage.Keys)
            {
                Tuple<String, eVehicleStatus> item = new Tuple<string, eVehicleStatus>(licensePlateId, m_VehiclesInGarage[licensePlateId].VehicleStatus);
                LisenceNumbersArray[index] = item;
                index++;
            }
            return LisenceNumbersArray;
        }
        public eVehicleStatus CheckIfStatusValid(string i_VehicleStatus)
        {
            eVehicleStatus result;
            if (Enum.TryParse(i_VehicleStatus, true, out result) == false)
            {
                throw new ArgumentException();
            }
            else
            {
                return result;
            }
        }
        public void ChangeVehicleStatus()
        {

        }
        public void AddAirToVehicleWheelsInVehicle()
        {

        }
        public void RefuelVheicleInGarage()
        {

        }
        public void ChargeVehicleInGarage()
        {

        }
        public void ShowAllDataOfVehicle()
        {

        }
    }
}
