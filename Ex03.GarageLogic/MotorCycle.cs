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
        public override void FillVehicleData(ref List<string> io_Data)
        {
            base.FillVehicleData(ref io_Data);
            fillLisenceType(io_Data[0]);
            fillEngineVolume(io_Data[1]);
            io_Data = io_Data.Skip(2).ToList();
        }
        private void fillLisenceType(string i_LisenceType)
        {
            if(Enum.TryParse(i_LisenceType, true, out m_LisenceType) == false)
            {
                throw new ArgumentException();
            }
        }
        private void fillEngineVolume(string i_EngineVolume)
        {
            if(int.TryParse(i_EngineVolume, out m_EngineVolume) == false)
            {
                throw new ArgumentException();
            }
        }
    }
}
