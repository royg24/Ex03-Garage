using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Ex03.GarageLogic.FuelType;
namespace Ex03.GarageLogic
{
    public class FueledEngine
    {
        private eFuelType m_FuelType;
        private float m_CurrentFuelAmount;
        private float m_MaxFuelAmount;

        public void ToFuel(float i_AmountOfFuelToAdd , eFuelType i_FuelType)
        {
            if(m_FuelType == i_FuelType)
            {
                if(m_CurrentFuelAmount + i_AmountOfFuelToAdd <= m_MaxFuelAmount)
                {
                    m_CurrentFuelAmount += i_AmountOfFuelToAdd;
                }
            }
        }
    }
}
