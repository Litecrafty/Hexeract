import accessors;

/// Available material types
public enum Material {
    AIR
}

/// Block data
public class Block {
    @Read private Material _material;

    mixin(GenerateFieldAccessors);
}