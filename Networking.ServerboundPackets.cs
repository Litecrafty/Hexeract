using Hexeract.Networking.PacketHandler;

namespace Hexeract.Networking.ServerboundPackets
{
    public class Handshake : IPacket
    {
        public int ProtocolVersion { get; private set; }
        public string ServerAddress { get; private set; }
        public short ServerPort { get; private set; }
        public int NextState { get; private set; }
        public Handshake(byte[] packetData)
        {
            short pointer = 0;
            ProtocolVersion = DataTypeReader.ReadVarInt(ref pointer, packetData);
            ServerAddress = DataTypeReader.ReadString(ref pointer, packetData, 255);
            ServerPort = DataTypeReader.ReadShort(ref pointer, packetData);
            NextState = DataTypeReader.ReadVarInt(ref pointer, packetData);
        }
    }
}
