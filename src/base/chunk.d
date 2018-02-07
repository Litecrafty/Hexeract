import accessors;
import block;
import std.datetime.date;

/// Representation of Minecraft Chunk
public class Chunk {
    @Read private int _x, _y;
    @Read private Block[] _blocks;

    @Read private Date _timestamp;

    mixin(GenerateFieldAccessors);
}
