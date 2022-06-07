using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Dominisoft.NetworkMapper.Models;

namespace Dominisoft.NetworkMapper.Static
{
    public static class Network
    {
        public static List<Device> Devices = new List<Device>();
        
        public static List<KeyValuePair<Guid, Guid>> Connections = new List<KeyValuePair<Guid, Guid>>();

        public static List<MacTableEntry> DetectedMacTableEntries = new List<MacTableEntry>();
        public static List<string> Locations = new List<string>();
        public static List<DeviceIcon> DeviceIcons = new List<DeviceIcon>();







        public static List<NetworkInterface> AllInterfaces =>
            Devices.SelectMany(device => device.NetworkInterfaces).ToList();

        public static void Initialize()
        {
            Devices = new List<Device>();
            Connections = new List<KeyValuePair<Guid, Guid>>();
            DetectedMacTableEntries = new List<MacTableEntry>();
            Locations = new List<string>();
        }
    }
}
