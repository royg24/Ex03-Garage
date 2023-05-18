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
        //protected data members not private
        protected string m_ModelName;
        protected string m_LisenceNumber;
        protected float m_PrecentageOfEnergyLeft;
        protected Wheel[] m_Wheels;
    }
}