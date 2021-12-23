using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework.Models
{

    internal class Visitor
    {
        public int ticketId { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string gender { get; set; }
        public string startTime { get; set; }
        public string endTime { get; set; }
        public int groupId { get; set; }
        public long phoneNumber { get; set; }
        public double checkoutPrice { get; set; }
        public bool receivedHolidayDiscount { get; set; }
        public override string ToString() {
            return toJson();
        }

        public string toJson() {
            return JsonConvert.SerializeObject(this);
        }
    }
}
