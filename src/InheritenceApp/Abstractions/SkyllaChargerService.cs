using InheritenceApp.Infrastructure;
using InheritenceApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceApp.Abstractions
{
    internal class MqttChargerService : IChargerService
    {
        public MqttChargerService(string host)
        {

        }

        public ChargerParameters GetChargerParameters()
        {
            throw new NotImplementedException();
        }
    }


    internal class SkyllaChargerServiceSettings
    {
        public int Id { get; set; }
        public int RegisterAddress { get; set; }
    }


    internal class Server
    {
        public string Host { get; set; }
        public int Port { get; set; }
        public Server(string host, int port = 502)
        {
            Host = host;
            Port = port;
        }
    }

    internal class SkyllaChargerService : IChargerService
    {
        public SkyllaChargerServiceSettings Settings { get; set; }

        public object modbus;

        public SkyllaChargerService(Server server, SkyllaChargerServiceSettings settings)
        {
            Settings = settings;

            modbus = new object();
        }   

        public ChargerParameters GetChargerParameters()
        {
            throw new NotImplementedException();
        }
    }
}
