using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Ex03.GarageLogic
{
    public abstract class Vehicle
    {
        private string m_ModelName;
        private string m_LisenceNumber;
        private float m_PrecentageOfEnergyLeft;
        protected Wheel[] m_Wheels;
    }
}