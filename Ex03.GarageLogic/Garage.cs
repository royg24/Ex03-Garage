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
        public void ChangeVehicleStatus(string i_LicensePlateID, eVehicleStatus i_VehicleStatus)
        {
            m_VehiclesInGarage[i_LicensePlateID].VehicleStatus = i_VehicleStatus;
        }
        public void MakeAirPressureInVehicleMaximum(string i_LicensePlateID)
        {
            float maxAirPressure = m_VehiclesInGarage[i_LicensePlateID].Vehicle.Wheels[0].MaxAirPressure;
            m_VehiclesInGarage[i_LicensePlateID].Vehicle.ChangeAirPressure(maxAirPressure);
        }
        public eFuelType CheckIfFuelTypeValid(string i_FuelType)
        {
            eFuelType result;
            if (Enum.TryParse(i_FuelType, true, out result) == false)
            {
                throw new ArgumentException();
            }
            else
            {
                return result;
            }
        }
        public void RefuelVheicle(string i_LicenePlateID ,float i_AmountToFuel, eFuelType i_FuelType)
        {
            
        }
        public void ChargeVehicleInGarage(string i_LicensePlateID, float i_AmountToCharge)
        {

        }
        public void ShowAllDataOfVehicle()
        {

        }
        public void CheckIfLicensePlateIDExcistsOrNot(string i_licensePlateId, bool i_ExcistOrNot)
        {
             if(VehiclesInGarage.ContainsKey(i_licensePlateId) == i_ExcistOrNot)
            {
                throw new ArgumentException();
            }
        }

    }
}
