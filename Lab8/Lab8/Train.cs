using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class Train : GroundTransport
    {
        int[] KolFreePlaceInTram;

        public Train(string transportType, string startPoint, string endPoint, int tripNum, int[] ticketPrice) : base(transportType, startPoint, endPoint, tripNum, ticketPrice)
        {
        }

        public int this[string placeType]
        {
            set
            {
                switch (placeType)
                {
                    case "Люкс":
                        TicketPrice[0] = value;
                        break;
                    case "Купейный":
                        TicketPrice[1] = value;
                        break;
                    case "Плацкартный":
                        TicketPrice[2] = value;
                        break;
                    case "Общий":
                        TicketPrice[3] = value;
                        break;
                }
            }
            get
            {
                switch (placeType)
                {
                    case "Люкс":
                        return TicketPrice[0];
                    case "Купейный":
                        return TicketPrice[1];
                    case "Плацкартный":
                        return TicketPrice[2];
                    case "Общий":
                        return TicketPrice[3];
                    default:
                        return -1;
                }
            }
        }
        public override int GetFreePlace()
        {
            int sum = 0;
            for (int i = 0; i < KolFreePlaceInTram.Length; i++)
            {
                sum += KolFreePlaceInTram[i];
            }
            return sum;
        }

        public override string ShowInfo()
        {
            return $"{base.ShowInfo()}; Номер - {TripNum}; Люкс - {TicketPrice[0]} Купейный - {TicketPrice[1]} Плацкартный - {TicketPrice[2]} Общий - {TicketPrice[3]}";
        }
    }
}
