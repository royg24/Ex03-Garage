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
        public FueledEngine(string i_CurrentFuelAmount, float i_MaxFuelAmount, eFuelType i_FuelType) : base(i_CurrentFuelAmount, i_MaxFuelAmount)
        {
            m_FuelType = i_FuelType;
        }
        public void ToFuel(float i_AmountOfFuelToAdd , eFuelType i_FuelType)
        {
            if(i_FuelType == m_FuelType)
            {
                AddValue(i_AmountOfFuelToAdd);
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
}
