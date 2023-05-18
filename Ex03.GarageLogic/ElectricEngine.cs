using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Ex03.GarageLogic
{
    internal class ElectricEngine
    {
        private float m_HoursLeftInBattery;
        private float m_MaxHoursInBattery;

        public ElectricEngine(float i_HoursLeftInBattery, float i_MaxHoursInBattery)
        {
            m_HoursLeftInBattery = i_HoursLeftInBattery; 
            m_MaxHoursInBattery = i_MaxHoursInBattery;
        }
        public void ChargeBattery(float i_HoursToAddToBattery)
        {
            if( m_HoursLeftInBattery + i_HoursToAddToBattery <= m_MaxHoursInBattery)
            {
                m_HoursLeftInBattery += i_HoursToAddToBattery;
            }
        }
    }
}
