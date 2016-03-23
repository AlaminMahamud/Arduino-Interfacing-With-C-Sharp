using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO.Ports;

namespace Arduino_First_interfacing
{
    class Program
    {
        static void Main(string[] args)
        {
            SerialPort workingPort = new SerialPort();
            workingPort.BaudRate = 9600;
            workingPort.PortName = "COM15";
            workingPort.Open();

            whil    e (true)
            {
                string mystring = workingPort.ReadLine();
                Console.WriteLine(mystring);
            }
        }
    }
}
