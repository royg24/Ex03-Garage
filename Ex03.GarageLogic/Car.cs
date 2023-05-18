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
          
    }
}
