import vibe.d;
import std.bitmanip : peek, nativeToBigEndian;
import std.utf;

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

    /// Read a incoming string
    protected string readString(int max = 32_767) {
        const int size = readVarInt;

        if (size > (max * 4) + 3) {
            throw new Exception("String is too big");
        }
        const auto output = cast(string) readBytes(size);
        validate(output);

        return output;
    }
}

/// IO stream operations
public abstract class Writeable : Readable {
    /// Write byte to outgoing connection
    protected void writeByte(byte b) {
        ubyte[1] o = [cast(ubyte) b];
        connection.write(o);
    }

    /// Write unsigned byte to outgoing connection
    protected void writeUByte(ubyte b) {
        ubyte[1] o = [b];
        connection.write(o);
    }

    /// Write boolean to outgoing connection
    protected void writeBool(bool input) {
        connection.write(nativeToBigEndian(input));
    }

    /// Write short to outgoing connection
    protected void writeShort(short input) {
        connection.write(nativeToBigEndian(input));
    }

    /// Write unsigned short to outgoing connection
    protected void writeUShort(ushort input) {
        connection.write(nativeToBigEndian(input));
    }

    /// Write int to outgoing connection
    protected void writeInt(int input) {
        connection.write(nativeToBigEndian(input));
    }

    /// Write float to outgoing connection
    protected void writeLong(long input) {
        connection.write(nativeToBigEndian(input));
    }

    /// Write float to outgoing connection
    protected void writeFloat(float input) {
        connection.write(nativeToBigEndian(input));
    }

    /// Write double to outgoing connection
    protected void writeDouble(double input) {
        connection.write(nativeToBigEndian(input));
    }

    /// Write varint to outgoing connection
    protected void writeVarInt(int value) {
        do {
            byte temp = cast(byte)(value & 0b01111111);

            value >>>= 7;
            if (value != 0) {
                temp |= 0b10000000;
            }
            writeByte(temp);
        }
        while (value != 0);
    }

    /// Write string to outgoing connection
    protected void writeString(string input, int max = 32_767) {
        const ubyte[] bytes = cast(ubyte[]) input;
        const long size = bytes.length;

        if (size > (max * 4) + 3) {
            throw new Exception("String is too big");
        }

        writeVarInt(cast(int) size);
        connection.write(bytes);
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
