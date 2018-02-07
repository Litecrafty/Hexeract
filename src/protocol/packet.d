import vibe.d;
import std.bitmanip : peek, nativeToBigEndian;

/// Input stream operations
public abstract class Readable {
    protected TCPConnection connection;

    /// Read a defined amount of bytes
    protected ubyte[] readUBytes(int amount = 1) {
        ubyte[] o = new ubyte[amount];
        connection.read(o);

        return o;
    }

    /// Read incoming signed bytes
    protected byte[] readBytes(int amount = 1) {
        return cast(byte[]) readUBytes(amount);
    }

    /// Read an incoming byte
    protected byte readUByte() {
        return readUBytes[0];
    }

    /// Read an incoming signed byte
    protected byte readByte() {
        return readBytes[0];
    }

    /// Read an incoming boolean
    protected bool readBoolean() {
        return readUBytes.peek!bool;
    }

    /// Read an incoming short
    protected short readShort() {
        return readUBytes(2).peek!short;
    }

    /// Read an incoming unsigned short
    protected ushort readUShort() {
        return readUBytes(2).peek!ushort;
    }

    /// Read an incoming integer
    protected int readInt() {
        return readUBytes(4).peek!int;
    }

    /// Read an incoming unsigned integer
    protected uint readUInt() {
        return readUBytes(4).peek!uint;
    }

    /// Read an incoming long
    protected long readLong() {
        return readUBytes(8).peek!long;
    }

    /// Read an incoming single-precision 32-bit floating point number
    protected float readFloat() {
        return readUBytes(4).peek!float;
    }

    /// Read an incoming double-precision 64-bit floating point number
    protected double readDouble() {
        return readUBytes(8).peek!double;
    }

    /// Read an incoming variable size integer
    protected int readVarInt() {
        int numRead;
        int result;
        byte read;

        do {
            read = readByte;
            const int value = (read & 0b01111111);
            result |= (value << (7 * numRead));

            numRead++;
            if (numRead > 5) {
                throw new Exception("VarInt is too big");
            }
        }
        while ((read & 0b10000000) != 0);

        return result;
    }

    /// Read an incoming variable size integer
    protected long readVarLong() {
        int numRead;
        long result;
        byte read;

        do {
            read = readByte;
            const int value = (read & 0b01111111);
            result |= (value << (7 * numRead));

            numRead++;
            if (numRead > 10) {
                throw new Exception("VarLong is too big");
            }
        }
        while ((read & 0b10000000) != 0);

        return result;
    }
}

/// IO stream operations
public abstract class Writeable : Readable {
    protected void writeByte(byte b) {
        ubyte[1] o = [cast(ubyte) b];
        connection.write(o);
    }

    protected void writeUByte(ubyte b) {
        ubyte[1] o = [b];
        connection.write(o);
    }

    protected void writeBool(bool input) {
        connection.write(nativeToBigEndian(input));
    }

    protected void writeShort(short input) {
        connection.write(nativeToBigEndian(input));
    }

    protected void writeUShort(ushort input) {
        connection.write(nativeToBigEndian(input));
    }

    protected void writeInt(int input) {
        connection.write(nativeToBigEndian(input));
    }

    protected void writeLong(long input) {
        connection.write(nativeToBigEndian(input));
    }

    protected void writeFloat(float input) {
        connection.write(nativeToBigEndian(input));
    }

    protected void writeDouble(double input) {
        connection.write(nativeToBigEndian(input));
    }

    protected void writeVarInt(int value) {
        do {
            byte temp = cast(byte) (value & 0b01111111);

            value >>>= 7;
            if (value != 0) {
                temp |= 0b10000000;
            }
            writeByte(temp);
        }
        while (value != 0);
    }
}

/// Packet base
public abstract class Packet : Writeable {
    /// Create a new Packet using an open connection
    this(TCPConnection connection) {
        this.connection = connection;
    }

    /// Decode an incoming Packet
    public void decode();

    /// Encode an outgoing Packet, you must write your packet ID to the byte stream
    public void encode() nothrow;
}
