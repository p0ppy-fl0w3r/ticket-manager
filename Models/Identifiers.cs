using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework.Models
{
    internal class Identifiers
    {
        public int ticketId { get; set; }
        public int groupId { get; set; }

        public string toJson() {
            return JsonConvert.SerializeObject(this);
        }

        public override string ToString()
        {
            return this.toJson();
        }
    }

}
