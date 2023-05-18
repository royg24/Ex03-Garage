using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Ex03.GarageLogic.LisenceType;
namespace Ex03.GarageLogic
{
    public abstract class MotorCycle : Vehicle
    {
        private eLisenceType m_LisenceType;
        private int m_EngineVolume;
    }
}
