using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Lab8
{
    abstract class Transport
    {
        public string StartPoint;
        public string EndPoint;
        public string TransportType;

        public Transport(string transportType, string startPoint, string endPoint)
        {
            StartPoint = startPoint;
            EndPoint = endPoint;
            TransportType = transportType;
        }

        public abstract int GetFreePlace();

        public virtual string ShowInfo()
        {
            return $"{TransportType}; {StartPoint} - {EndPoint};";
        }
    }
}