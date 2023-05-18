using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Ex03.GarageLogic
{
    public abstract class MotorCycle : Vehicle
    {
        public enum eLisenceType
        {
            A1,
            A2,
            AA,
            B1
        }
        private eLisenceType m_LisenceType;
        private int m_EngineVolume;
    }
}
