using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomException
{
    public class CarlsDeadException : ApplicationException
    {
        private string messageDetails = String.Empty;
        public DateTime ErrorTimeStamp { get; set; }
        public string CauseOfTerror { get; set; }
        public CarlsDeadException() { }
        public CarlsDeadException(string message, string cause, DateTime time)
            :base(message)
        {

            CauseOfTerror = cause;
            ErrorTimeStamp = time;
        }
    }
}
