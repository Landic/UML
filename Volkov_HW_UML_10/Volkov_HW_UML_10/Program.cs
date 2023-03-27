using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_UML_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VideoCard video = new VideoCard();
            RAM ram = new RAM();
            Disk disk = new Disk();
            ReadDisk readdisk = new ReadDisk(); 
            PowerUnit power = new PowerUnit();
            Sensor sensor = new Sensor();

            Facade obj = new Facade(ram, disk, readdisk, sensor, power, video);
            Client client = new Client();
            client.StartPC(obj);
            Console.WriteLine("----------------------END----------------------");
            client.StopPC(obj);
        }
    }
}
