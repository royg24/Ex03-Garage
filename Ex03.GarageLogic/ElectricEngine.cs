using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Ex03.GarageLogic
{
    internal class ElectricEngine : Engine
    {
        public ElectricEngine(string i_HoursLeftInBattery, float i_MaxHoursInBattery) : base(i_HoursLeftInBattery, i_MaxHoursInBattery)
        {
            
        }
        public void ChargeBattery(float i_HoursToAddToBattery)
        {
            AddValue(i_HoursToAddToBattery);
        }
    }
}
