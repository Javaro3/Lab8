using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class Bus : GroundTransport
    {
        public int FreePlace;

        public Bus(string transportType, string startPoint, string endPoint, int tripNum, int[] ticketPrice) : base(transportType, startPoint, endPoint, tripNum, ticketPrice)
        {
        }

        public int this[string placeType]
        {
            set
            {
                if (placeType == "Мягкий")
                {
                    TicketPrice[0] = value;
                }
                else if (placeType == "Жесткий")
                {
                    TicketPrice[1] = value;
                }
            }
            get
            {
                if (placeType == "Мягкий")
                {
                    return TicketPrice[0];
                }
                else if (placeType == "Жесткий")
                {
                    return TicketPrice[1];
                }
                else
                {
                    return -1;
                }
            }
        }

        public override int GetFreePlace()
        {
            return FreePlace;
        }

        public override string ShowInfo()
        {
            return $"{base.ShowInfo()} Номер - {TripNum}; Мягкие - {TicketPrice[0]} Жесткие - {TicketPrice[1]}";
        }
    }
}
