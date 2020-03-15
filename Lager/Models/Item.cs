using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Lager.Models
{
    public class Item
    {
        public int Id { get; set; }
        [DisplayName("Package")]
        public string ItemName { get; set; }

        public int Price { get; set; }

        [DisplayName("Requests / mo")]
        public int Requests { get; set; }

        [DisplayName("Customer Support")]
        public string Support { get; set; }
    }
}
