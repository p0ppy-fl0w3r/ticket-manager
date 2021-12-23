using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework.Models
{
    internal class TicketPrice
    {
               
        public double hourPrice { get; set; }
        public double twoHourPrice { get; set; }
        public double threeHourPrice { get; set; }
        public double fourHourPrice { get; set; }
        public double dayPrice { get; set; }

        public double weekendDiscount { get; set; }
        public double holidayDiscount { get; set; }
        public double seniorDiscount { get; set; }
        public double childDiscount { get; set; }  
        public double groupFiveDiscount { get; set; }
        public double groupTenDiscount { get; set; }
        public double groupFifteenDiscount { get; set; }

        public string openTime { get; set; }
        public string closeTime { get; set; }

        public string toJson() {
            return JsonConvert.SerializeObject(this);
        }

        public override string ToString()
        {
            return this.toJson();
        }
    }
}
