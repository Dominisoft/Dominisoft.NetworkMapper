using System;
using System.Collections.Generic;
using System.Net;

namespace Dominisoft.NetworkMapper.Models
{
    public class Device
    {
        public Device()
        {
            NetworkInterfaces = new List<NetworkInterface> { };
            Id = Guid.NewGuid();
            GlobalDeviceIp = new IpConfiguration();
            NetworkCredential = new NetworkCredential();
        }
        public Guid Id { get; set; }
        public string Type { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string Icon { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
        public NetworkCredential NetworkCredential { get; set; }
        public IpConfiguration GlobalDeviceIp { get; set; }
        public List<NetworkInterface> NetworkInterfaces { get; set; }

    }
}
