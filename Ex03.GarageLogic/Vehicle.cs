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
            m_LisenceNumber = io_Data[0];
            m_LisenceNumber = io_Data[1];
            FillPrecentageOfEnergyLeft(io_Data[2]);
            io_Data = io_Data.Skip(3).ToList();
        }
        public void FillPrecentageOfEnergyLeft(String i_PrecentageOfEnergyLeft)
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
    }
}