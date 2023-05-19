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
        public void ShowLisenceNumbers()
        {

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
