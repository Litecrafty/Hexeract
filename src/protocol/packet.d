import vibe.d;
import std.bitmanip : peek;

/// Input stream operations
public abstract class Readable {
    protected TCPConnection connection;

    /// Read a defined amount of bytes
    protected ubyte[] readUBytes(int amount = 1) {
        ubyte[] o = new ubyte[amount];
        connection.read(o);

        return o;
    }

    /// Read an incoming signed byte
    protected byte[] readBytes(int amount = 1) {
        return cast(byte[]) readUBytes(amount);
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
}

/// IO stream operations
public abstract class Writeable : Readable {
    
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
