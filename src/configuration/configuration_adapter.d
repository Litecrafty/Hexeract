import accessors;

/// Customizable configuration adapter
public abstract class ConfigurationAdapter {
    @Read @Write
    protected int _renderDistance = 12;

    @Read
    protected int _port = 25565;

    @Read
    protected string _host = "0.0.0.0";

    mixin(GenerateFieldAccessors);
}
