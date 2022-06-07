using System.Collections.Generic;

namespace Dominisoft.NetworkMapper.Models
{
    public class IpConfiguration
    {
        public IpConfiguration()
        {
            DnsHosts = new List<string>();
            VlanId = 1;
        }
        public string Address { get; set; }
        public string SubnetMask { get; set; }
        public string DefaultGateway { get; set; }
        public List<string> DnsHosts { get; set; }
        public int VlanId { get; set; }
    }
}
