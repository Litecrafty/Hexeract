using Hexeract.Networking.ServerboundPackets;
using System;

namespace Hexeract.Networking.PacketHandler
{
    /// <summary>
    /// There is only a packet here which toggles states. 
    /// 
    /// For further information about the protocol Handshake state: https://wiki.vg/Protocol#Serverbound
    /// </summary>
    public enum ServerPacketHandshakingIds
    {
        Handshake = 0x00
    }

    /// <summary>
    /// The reason the IDs are set and are not automatically assigned is because 
    /// the packet protocol may change and the IDs may change as well.
    /// 
    /// For further information about the protocol Play state: https://wiki.vg/Protocol#Clientbound_2
    /// </summary>
    public enum ClientPacketPlayIds
    {
        SpawnObject = 0x00, 
        SpawnExperienceOrb = 0x01, 
        SpawnGlobalEntity = 0x02, 
        SpawnMob = 0x03, 
        SpawnPainting = 0x04, 
        SpawnPlayer = 0x05, 
        Animation = 0x06, 
        Statistics = 0x07, 
        BlockBreakAnimation = 0x08, 
        UpdateBlockEntity = 0x09, 
        BlockAction = 0x0A, 
        BlockChange = 0x0B, 
        BossBar = 0x0C, 
        ServerDifficulty = 0x0D, 
        ChatMessage = 0x0E, 
        MultiBlockChange = 0x0F, 
        TabComplete = 0x10, 
        DeclareCommands = 0x11, 
        ConfirmTransaction = 0x12, 
        CloseWindow = 0x13, 
        OpenWindow = 0x14, 
        WindowItems = 0x15, 
        WindowProperty = 0x16, 
        SetSlot = 0x17, 
        SetCooldown = 0x18, 
        PluginMessage = 0x19, 
        NamedSoundEffect = 0x1A, 
        Disconnect = 0x1B, 
        EntityStatus = 0x1C, 
        NBTQueryResponse = 0x1D, 
        Explosion = 0x1E, 
        UnloadChunk = 0x1F, 
        ChangeGameState = 0x20, 
        KeepAlive = 0x21, 
        ChunkData = 0x22, 
        Effect = 0x23, 
        Particle = 0x24, 
        JoinGame = 0x25, 
        MapData = 0x26, 
        Entity = 0x27, 
        EntityRelativeMove = 0x28, 
        EntityLookAndRelativeMove = 0x29, 
        EntityLook = 0x2A, 
        VehicleMove = 0x2B, 
        OpenSignEditor = 0x2C, 
        CraftRecipeResponse = 0x2D, 
        PlayerAbilities = 0x2E, 
        CombatEvent = 0x2F, 
        PlayerInfo = 0x30, 
        FacePlayer = 0x31, 
        PlayerPositionAndLook = 0x32, 
        UseBed = 0x33, 
        UnlockRecipes = 0x34, 
        DestroyEntities = 0x35, 
        RemoveEntityEffect = 0x36, 
        ResourcePackSend = 0x37, 
        Respawn = 0x38, 
        EntityHeadLook = 0x39, 
        SelectAdvancementTab = 0x3A, 
        WorldBorder = 0x3B, 
        Camera = 0x3C, 
        HeldItemChange = 0x3D, 
        DisplayScoreboard = 0x3E, 
        EntityMetadata = 0x3F, 
        AttatchEntity = 0x40, 
        EntityVelocity = 0x41, 
        EntityEquipment = 0x42, 
        SetExperience = 0x43, 
        UpdateHealth = 0x44, 
        ScoreboardObjective = 0x45, 
        SetPassengers = 0x46, 
        Teams = 0x47, 
        UpdateScore = 0x48, 
        SpawnPosition = 0x49, 
        TimeUpdate = 0x4A, 
        Title = 0x4B, 
        StopSound = 0x4C, 
        SoundEffect = 0x4D, 
        PlayerListHeaderAndFooter = 0x4E, 
        CollectItem = 0x4F, 
        EntityTeleport = 0x50, 
        Advancements = 0x51, 
        EntityProperties = 0x52, 
        EntityEffect = 0x53, 
        DeclareRecipes = 0x54, 
        Tags = 0x55
    }

    /// <summary>
    /// The reason the IDs are set and are not automatically assigned is because 
    /// the packet protocol may change and the IDs may change as well.
    /// 
    /// For further information about the protocol Play state: https://wiki.vg/Protocol#Serverbound_2 https://wiki.vg/Protocol#Clientbound_3
    /// </summary>
    public enum ServerPacketPlayIds
    {
        TeleportConfirm = 0x00, 
        QueryBlockNBT = 0x01, 
        ChatMessage = 0x02, 
        ClientStatus = 0x03, 
        ClientSettings = 0x04, 
        TabComplete = 0x05, 
        ConfirmTransaction = 0x06, 
        EnchantItem = 0x07, 
        ClickWindow = 0x08, 
        CloseWindow = 0x09, 
        PluginMessage = 0x0A, 
        EditBook = 0x0B, 
        QueryEntityNBT = 0x0C, 
        UseEntity = 0x0D, 
        KeepAlive = 0x0E, 
        Player = 0x0F, 
        PlayerPosition = 0x10, 
        PlayerPositionAndLook = 0x11, 
        PlayerLook = 0x12, 
        VehicleMove = 0x13, 
        SteerBoat = 0x14, 
        PickItem = 0x15, 
        CraftRecipeRequest = 0x16, 
        PlayerAbilities = 0x17, 
        PlayerDigging = 0x18, 
        EntityAction = 0x19, 
        SteerVehicle = 0x1A, 
        RecipeBookData = 0x1B, 
        NameItem = 0x1C, 
        ResourcePackStatus = 0x1D, 
        AdvancementTab = 0x1E, 
        SelectTrade = 0x1F, 
        SetBeaconEffect = 0x20, 
        HeldItemChange = 0x21, 
        UpdateCommandBlock = 0x22, 
        UpdateCommandBlockMinecart = 0x23, 
        CreativeInventoryAction = 0x24, 
        UpdateStructureBlock = 0x25, 
        UpdateSign = 0x26, 
        Animation = 0x27, 
        Spectate = 0x28, 
        PlayerBlockPlacement = 0x29, 
        UseItem = 0x2A
    }

    /// <summary>
    /// The reason the IDs are set and are not automatically assigned is because 
    /// the packet protocol may change and the IDs may change as well.
    /// 
    /// For further information about the protocol Status state: https://wiki.vg/Protocol#Clientbound_3
    /// </summary>
    public enum ClientPacketStatusIds
    {
        Response = 0x00, 
        Pong = 0x01
    }

    /// <summary>
    /// The reason the IDs are set and are not automatically assigned is because 
    /// the packet protocol may change and the IDs may change as well.
    /// 
    /// For further information about the protocol Status state: https://wiki.vg/Protocol#Serverbound_3
    /// </summary>
    public enum ServerPacketStatusIds
    {
        Request = 0x00,
        Ping = 0x01
    }

    /// <summary>
    /// The reason the IDs are set and are not automatically assigned is because 
    /// the packet protocol may change and the IDs may change as well.
    /// 
    /// For further information about the protocol Login state: https://wiki.vg/Protocol#Clientbound_4
    /// </summary>
    public enum ClientPacketLoginIds
    {
        Disconnect = 0x00, 
        EncryptionRequest = 0x01, 
        LoginSuccess = 0x02, 
        SetCompression = 0x03, 
        LoginPluginRequest = 0x04
    }

    /// <summary>
    /// The reason the IDs are set and are not automatically assigned is because 
    /// the packet protocol may change and the IDs may change as well.
    /// 
    /// For further information about the protocol Login state: https://wiki.vg/Protocol#Serverbound_4
    /// </summary>
    public enum ServerPacketLoginIds
    {
        LoginStart = 0x00, 
        EncryptionResponse = 0x01, 
        LoginPluginResponse = 0x02
    }

    /// <summary>
    /// This interface was created purely with the objective 
    /// of getting a packet with a single method, saving time.
    /// </summary>
    public interface IPacket
    {
    }

    public class PacketHandler
    {
        public int PacketLength { get; private set; }
        public int PacketId { get; private set; }
        public byte[] PacketData { get; private set; }

        public PacketHandler(byte[] packet, bool compression)
        {
            byte[] receivedPacket = packet;
            short packetCursor = 0;
            
            if (!BitConverter.IsLittleEndian)
            {
                Array.Reverse(receivedPacket);
            }
            PacketLength = DataTypeReader.ReadVarInt(ref packetCursor, receivedPacket);
            PacketId = DataTypeReader.ReadVarInt(ref packetCursor, receivedPacket);

            if (compression)
            {
                // TODO: Compression, not compression
            }
        }

        public IPacket GetPacket(byte status)
        {
            switch (status)
            {
                case 0:
                    return GetHandshakePacket();
                default:
                    throw new Exception("Error A02: Unsupported entrant packet");
            }
        }

        private IPacket GetHandshakePacket()
        {
            return new Handshake(PacketData);
        }

        private IPacket
    }

    /// <summary>
    /// This class takes for every method a pointer to know where to start 
    /// at the packet as a reference so the pointer can change outside scope, and 
    /// the packet itself to be processed.
    /// </summary>
    static public class DataTypeReader
    {
        /// <summary>
        /// This method is used mostly by ReadVarInt and ReadVarLong, returns the 
        /// following byte of the packet.
        /// </summary>
        /// <param name="pointer">Index of the packet to be read</param>
        /// <param name="packet">The packet to be processed</param>
        /// <returns>Next byte of the packet</returns>
        static public byte ReadByte(ref short pointer, byte[] packet)
        {
            if (pointer >= packet.Length)
            {
                throw new Exception("Error A01: Cursor is positioned after last byte of packet");
            }
            byte readByte = packet[pointer];
            pointer++;
            return readByte;
        }

        /// <summary>
        /// This method reads the next boolean value of the packet.
        /// </summary>
        /// <param name="pointer">Index of the packet to be read</param>
        /// <param name="packet">The packet to be processed</param>
        /// <returns>Next boolean of the packet</returns>
        static public bool ReadBool(ref short pointer, byte[] packet)
        {
            bool readBool = BitConverter.ToBoolean(packet, pointer);
            pointer += 1;
            return readBool;
        }

        /// <summary>
        /// This method reads the next short value of the packet.
        /// </summary>
        /// <param name="pointer">Index of the packet to be read</param>
        /// <param name="packet">The packet to be processed</param>
        /// <returns>Next short of the packet</returns>
        static public short ReadShort(ref short pointer, byte[] packet)
        { 
            short readShort = BitConverter.ToInt16(packet, pointer);
            pointer += 2;
            return readShort;
        }

        /// <summary>
        /// This method reads the next int (Int32) value of the packet.
        /// </summary>
        /// <param name="pointer">Index of the packet to be read</param>
        /// <param name="packet">The packet to be processed</param>
        /// <returns>Next int of the packet</returns>
        static public int ReadInt(ref short pointer, byte[] packet)
        {
            int readInt = BitConverter.ToInt32(packet, pointer);
            pointer += 4;
            return readInt;
        }

        /// <summary>
        /// This method reads the next long (Int64) value of the packet.
        /// </summary>
        /// <param name="pointer">Index of the packet to be read</param>
        /// <param name="packet">The packet to be processed</param>
        /// <returns>Next long of the packet</returns>
        static public long ReadLong(ref short pointer, byte[] packet)
        {
            long readLong = BitConverter.ToInt64(packet, pointer);
            pointer += 8;
            return readLong;
        }

        /// <summary>
        /// This method reads the next float value of the packet.
        /// </summary>
        /// <param name="pointer">Index of the packet to be read</param>
        /// <param name="packet">The packet to be processed</param>
        /// <returns>Next float of the packet</returns>
        static public float ReadFloat(ref short pointer, byte[] packet)
        {
            float readFloat = BitConverter.ToSingle(packet, pointer);
            pointer += 4;
            return readFloat;
        }

        /// <summary>
        /// This method reads the next double value of the packet.
        /// </summary>
        /// <param name="pointer">Index of the packet to be read</param>
        /// <param name="packet">The packet to be processed</param>
        /// <returns>Next double of the packet</returns>
        static public double ReadDouble(ref short pointer, byte[] packet)
        {
            double readDouble = BitConverter.ToDouble(packet, pointer);
            pointer += 8;
            return readDouble;
        }

        /// <summary>
        /// This method reads the next string value of the packet.
        /// </summary>
        /// <param name="pointer">Index of the packet to be read</param>
        /// <param name="packet">The packet to be processed</param>
        /// <param name="stringSize">The string size, must be given</param>
        /// <returns>Next string of the packet</returns>
        static public string ReadString(ref short pointer, byte[] packet, short stringSize)
        {
            string readString = BitConverter.ToString(packet, pointer, stringSize);
            pointer += stringSize;
            return readString;
        }

        /// <summary>
        /// This method reads the next VarInt value of the packet. 
        /// For further information on how VarInt works check https://developers.google.com/protocol-buffers/docs/encoding.
        /// </summary>
        /// <param name="pointer">Index of the packet to be read</param>
        /// <param name="packet">The packet to be processed</param>
        /// <returns>Next VarInt of the packet</returns>
        static public int ReadVarInt(ref short pointer, byte[] packet)
        {
            byte readByte;
            byte count = 0;
            int result = 0;
            do
            {
                if (count > 5)
                {
                    throw new Exception("Error A02: Packet has a VarInt with a length over 5 bytes");
                }
                readByte = ReadByte(ref pointer, packet);
                result += readByte & 0x7F;
            } while ((readByte & 0x80) > 0);
            return result;
        }

        /// <summary>
        /// This method reads the next VarLong value of the packet. 
        /// For further information on how VarInt works check https://developers.google.com/protocol-buffers/docs/encoding.
        /// </summary>
        /// <param name="pointer">Index of the packet to be read</param>
        /// <param name="packet">The packet to be processed</param>
        /// <returns>Next VarLong of the packet</returns>
        static public long ReadVarLong(ref short pointer, byte[] packet)
        {
            byte readByte;
            byte count = 0;
            int result = 0;
            do
            {
                if (count > 10)
                {
                    throw new Exception("Error A02: Packet has a VarInt with a length over 5 bytes");
                }
                readByte = ReadByte(ref pointer, packet);
                result += readByte & 0x7F;
            } while ((readByte & 0x80) > 0);
            return result;
        }
    }
}
