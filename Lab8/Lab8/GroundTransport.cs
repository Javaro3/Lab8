using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Lab8
{
    abstract class GroundTransport : Transport
    {
        public int TripNum;
        public int[] TicketPrice;

        public GroundTransport(string transportType, string startPoint, string endPoint, int tripNum, int[] ticketPrice) : base(transportType, startPoint, endPoint)
        {
            TripNum = tripNum;
            TicketPrice = ticketPrice;
        }
    }
}
