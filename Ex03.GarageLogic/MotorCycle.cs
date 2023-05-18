using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Ex03.GarageLogic
{
    public enum eLisenceType
    {
        A1,
        A2,
        AA,
        B1
    }
    public abstract class MotorCycle : Vehicle
    {
        protected eLisenceType m_LisenceType;
        protected int m_EngineVolume;
    }
}
