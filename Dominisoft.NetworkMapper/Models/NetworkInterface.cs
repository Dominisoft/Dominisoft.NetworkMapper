using System;
using System.Collections.Generic;

namespace Dominisoft.NetworkMapper.Models
{
    public class NetworkInterface
    {
        public NetworkInterface()
        {
            Name = "new_interface";
            InterfaceType = NetworkInterfaceType.Copper_Cable;
            Number = 0;
            IsDisabled = true;
            IPs = new List<IpConfiguration>();
            MacAddress = string.Empty;
            Id = Guid.NewGuid();
            Notes = string.Empty;
        }
        public Guid Id { get; set; }
        public NetworkInterfaceType InterfaceType { get; set; }
        public int Number { get; set; }
        public string Name { get; set; }
        public bool IsDisabled { get; set; }
        public List<IpConfiguration> IPs { get; set; }
        public string MacAddress { get; set; }
        public string Notes { get; set; }

    }
}
