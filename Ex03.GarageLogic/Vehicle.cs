using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Ex03.GarageLogic
{
    public enum eNumOfWheels
    {
        two,
        five,
        fourteen
    }
    public abstract class Vehicle
    {
        protected string m_ModelName;
        protected string m_LisenceNumber;
        protected float m_PrecentageOfEnergyLeft;
        protected Wheel[] m_Wheels;
        public virtual void FillVehicleData(ref List<String> io_Data)
        {
            m_ModelName = io_Data[0];
            fillPrecentageOfEnergyLeft(io_Data[1]);
            io_Data = io_Data.Skip(2).ToList();
        }
        private void fillPrecentageOfEnergyLeft(String i_PrecentageOfEnergyLeft)
        {
            float precenatgeOfEnergyLeft;
            if(float.TryParse(i_PrecentageOfEnergyLeft, out precenatgeOfEnergyLeft) == true)
            {
                if((precenatgeOfEnergyLeft >= 0) && (precenatgeOfEnergyLeft <= 1))
                {
                    m_PrecentageOfEnergyLeft = precenatgeOfEnergyLeft;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
            else
            {
                throw new FormatException();
            }
        }
        protected Wheel[] FillWheelsData(string i_ManufacturerName, string i_CurrentAirPressure, int i_NumOfWheels, float i_MaxAirPressure)
        {
            float currentAirPressure;
            if (float.TryParse(i_CurrentAirPressure, out currentAirPressure) == false)
            {
                throw new FormatException();
            }
            else if (currentAirPressure > i_MaxAirPressure)
            {
                throw new ValueOutOfRangeException();
            }
            else
            {
                Wheel[] wheels = new Wheel[i_NumOfWheels];
                Wheel wheel = new Wheel(i_ManufacturerName, currentAirPressure, i_MaxAirPressure);
                for (int i = 0; i < i_NumOfWheels; i++)
                {
                    wheels[i] = wheel.ShallowClone();
                }
                return wheels;
            }
        }
    }
}