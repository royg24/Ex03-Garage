using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Ex03.GarageLogic
{
    public abstract class Car : Vehicle
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
        private eColor m_CarColor;
        private eNumOfDoors m_NumOfDoors;
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
