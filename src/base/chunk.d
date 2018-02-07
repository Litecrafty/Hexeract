import accessors;
import block;

/// Representation of Minecraft Chunk
public class Chunk {
    @Read private int _x, _y;
    @Read private Block[] _blocks;

    mixin(GenerateFieldAccessors);
}
