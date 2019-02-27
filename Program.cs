using Hexeract.Networking.PacketHandler;
using System;

namespace Hexeract
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(BitConverter.IsLittleEndian);
            PacketHandler packet = new PacketHandler(new byte[8] { 0b10000001, 0b10000001, 0b10000001, 0b10000001, 0b00000001, 0b10000001, 0b00000001, 0b00000001 }, false);
            Console.WriteLine(packet.PacketLength);
            Console.WriteLine(packet.PacketId);
            Console.ReadKey();
        }
    }
}