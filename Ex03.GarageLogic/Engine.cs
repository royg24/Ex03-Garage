using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    internal abstract class Engine
    {
        protected float m_MaxValue;
        protected float m_CurrentValue;
        internal Engine(float i_MaxValue, float i_CurrentValue)
        {
            m_MaxValue = i_MaxValue;
            m_CurrentValue = i_CurrentValue;
            internal void AddValur(float i_Value)
            {
                if (m_HoursLeftInBattery + i_Value <= m_MaxHoursInBattery)
                {
                    m_HoursLeftInBattery += i_Value;
                }
            }
        }
    }
}
