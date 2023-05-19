using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Ex03.GarageLogic
{
    public enum eNumOfDoors
    {
        two,
        three,
        four,
        five
    }
    public enum eColor
    {
        white,
        black,
        yellow,
        red
    }
    public abstract class Car : Vehicle
    {
        protected eColor m_CarColor;
        protected eNumOfDoors m_NumOfDoors;
        public eNumOfDoors NumOfDoors
        {
            get
            {
                return m_NumOfDoors;
            }         
        }
        public eColor CarColor
        {
            get
            {
                return m_CarColor;
            }
        }
        public override void FillVehicleData(ref List<string> io_Data)
        {
            base.FillVehicleData(ref io_Data);
            fillCarColor(io_Data[0]);
            fillNumberOfDoors(io_Data[1]);
            io_Data = io_Data.Skip(2).ToList();
        }
        private void fillCarColor(string i_CarColor)
        {
            if(Enum.TryParse(i_CarColor, true, out m_CarColor) == false)
            {
                throw new ArgumentException();
            }
        }
        private void fillNumberOfDoors(string i_NumberOfDoors)
        {
            if (Enum.TryParse(i_NumberOfDoors, true, out m_NumOfDoors) == false)
            {
                throw new ArgumentException();
            }
        }

    }
}
