using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Ex03.GarageLogic
{
    public class FueledCar : Car
    {
        private const int k_NumOfWheels = 5;
        private const float k_MaxAirPressure = 33f;
        private const float k_MaxFuelAmount = 46f;
        FueledEngine m_Engine;
        public override void FillVehicleData(ref List<string> io_Data)
        {
            base.FillVehicleData(ref io_Data);
            FillWheelsData(io_Data[0], io_Data[1], k_NumOfWheels, k_MaxAirPressure);
            m_Engine = new FueledEngine(io_Data[2], k_MaxFuelAmount, eFuelType.Octan95);
            io_Data = io_Data.Skip(3).ToList();
        }
    }
}
