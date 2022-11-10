using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class Plain : Transport
    {
        public int FreePlace;
        public int TripNum;
        public int[] TicketPrice;

        public Plain(string transportType, string startPoint, string endPoint, int tripNum, int[] ticketPrice) : base(transportType, startPoint, endPoint)
        {
            TripNum = tripNum;
            TicketPrice = ticketPrice;
        }

        public int this[string placeType]
        {
            set
            {
                switch (placeType)
                {
                    case "Эконом":
                        TicketPrice[0] = value;
                        break;
                    case "Бизнес":
                        TicketPrice[1] = value;
                        break;
                    case "Первый":
                        TicketPrice[2] = value;
                        break;
                }
            }
            get
            {
                switch (placeType)
                {
                    case "Эконом":
                        return TicketPrice[0];
                    case "Бизнес":
                        return TicketPrice[1];
                    case "Первый":
                        return TicketPrice[2];
                    default:
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
            return $"{base.ShowInfo()} Номер - {TripNum}; Эконом - {TicketPrice[0]} Бизнес - {TicketPrice[1]} Первый - {TicketPrice[2]}";
        }
    }
}
