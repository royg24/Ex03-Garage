using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Ex03.GarageLogic
{
    internal class ElectricMotorCycle : MotorCycle
    {
        private const int k_NumOfWheels = 2;
        private const float k_MaxAirPressure = 31f;
        private const float k_MaxHoursInBattery = 2.6f;
        private ElectricEngine m_Engine;
        public override void FillVehicleData(ref List<string> io_Data)
        {
            base.FillVehicleData(ref io_Data);
            FillWheelsData(io_Data[0], io_Data[1], k_NumOfWheels, k_MaxAirPressure);
            ElectricEngine.FillElectricEngineData(io_Data[2], k_MaxHoursInBattery);
            io_Data = io_Data.Skip(3).ToList();
        }
    }
}
