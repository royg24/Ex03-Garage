using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Ex03.GarageLogic.Color;
using static Ex03.GarageLogic.NumOfDoors;
namespace Ex03.GarageLogic
{
    public abstract class Car : Vehicle
    {
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
