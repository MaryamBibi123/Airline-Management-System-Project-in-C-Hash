using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectSignUp
{
    public static class Class3
    {

       private static int flightNo;
      private static   int customerId;
       private static List<string> bookedSeats= new List<string>();
       public static int CustomerId
        {
            set
            {
                customerId= value;
            }
            get
            {
                return customerId;
            }

        }
      public static int FlightNo
        {
            set
            {
                flightNo = value;
            }
            get
            {
                return flightNo;
            }
        }

        public static List<string> BookedSeats
        {
            set
            {
                bookedSeats = value;

            }
            get
            {
               return bookedSeats;
            }
        }
        
    }
}
