using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IPChangerForLab
{
    /// <summary>
    /// Stores network card configuration for a profile
    /// </summary>
    class NicProfile
    {

        private string name;
        private string ipAddr;
        private string subnetAddr;
        private string gatewayAddr;
        private bool useDhcp;

        public NicProfile(string name, string ipAddr, string subnetAddr, string gatewayAddr, bool useDhcp)
        {
            this.name = name;
            this.ipAddr = ipAddr;
            this.subnetAddr = subnetAddr;
            this.gatewayAddr = gatewayAddr;
            this.useDhcp = useDhcp;
        }

        public string Name { get => name; set => name = value; }
        public string IpAddr { get => ipAddr; set => ipAddr = value; }
        public string SubnetAddr { get => subnetAddr; set => subnetAddr = value; }
        public string GatewayAddr { get => gatewayAddr; set => gatewayAddr = value; }
        public bool UseDhcp { get => useDhcp; set => useDhcp = value; }
    }            
}
