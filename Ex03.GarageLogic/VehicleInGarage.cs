using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Ex03.GarageLogic
{
    public class VehicleInGarage
    {
        public enum eVehicleStatus
        {
            underRepair,
            wasFixed,
            paidUp
        }
        string m_OwnerName;
        string m_OwnerPhone;
        eVehicleStatus m_Status;
        Vehicle m_Vehicle;
    }
}
