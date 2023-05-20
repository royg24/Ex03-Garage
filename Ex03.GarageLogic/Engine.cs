using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{public abstract class Engine
    {
        protected float m_MaxValue;
        protected float m_CurrentValue;
        internal Engine(string i_MaxValue, float i_CurrentValue)
        {
            fillEngineData(i_MaxValue, i_CurrentValue);
        }
        internal void AddValue(float i_Value)
        {
            if (m_CurrentValue + i_Value <= m_MaxValue)
            {
                m_CurrentValue += i_Value;
            }
            else
            {
                throw new ValueOutOfRangeException();
            }
        }
        private void fillEngineData(string i_CurrentValue, float i_MaxValue)
        {
            float currentValue;
            if (float.TryParse(i_CurrentValue, out currentValue) == false)
            {
                throw new FormatException();
            }
            else
            {
                if (currentValue > i_MaxValue)
                {
                    throw new ValueOutOfRangeException();
                }
                else
                {
                    m_MaxValue = i_MaxValue;
                    m_CurrentValue = currentValue;
                }
            }
        }
    }
}
