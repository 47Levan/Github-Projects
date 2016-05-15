using System;

namespace Project_Airline_info
{
    class DateYearCheck :Exception
    {
        internal DateYearCheck()
        {

        }
        internal DateYearCheck(string message):base(message)
        {
            message ="Year is out of range";
        }
        internal DateYearCheck(Exception inner,string message) : base(message,inner)
        {
            message = "Year is out of range";
            inner = new Exception("Try enter birthday or flight year again");
            
        }
    }
}
