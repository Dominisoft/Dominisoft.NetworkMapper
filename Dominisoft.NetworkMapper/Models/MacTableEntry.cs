using System;

namespace Dominisoft.NetworkMapper.Models
{
    public class MacTableEntry
    {
        public string MacAddress { get; set; }
        public Guid InterfaceId { get; set; }
        public Guid DeviceId { get; set; }
    }
}
