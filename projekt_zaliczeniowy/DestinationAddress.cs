using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_zaliczeniowy
{
    public class DestinationAddress
    {
        public DestinationAddress() { }

        public DestinationAddress(string? street, string? house, int deliverycost)
        {
            streetName = street;
            houseNumber = house;
            deliveryCost = deliverycost;
        }

        public string? streetName { get; set; } = string.Empty;
        public string? houseNumber { get; set; } = string.Empty;

        public int deliveryCost { get; set; } = 20;

        public override string ToString()
        {
            return $"{streetName} {houseNumber}";
        }
    }
}
