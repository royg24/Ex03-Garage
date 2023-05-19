using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Ex03.GarageLogic
{
    public enum eFuelType
    {
        Soler,
        Octan95,
        Octan96,
        Octan98
    }
    internal class FueledEngine : Engine
    {
        private eFuelType m_FuelType;
        public FueledEngine(float i_CurrentFuelAmount, float i_MaxHoursInBattery) : base(i_CurrentFuelAmount, i_MaxHoursInBattery)
        {

        }

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
