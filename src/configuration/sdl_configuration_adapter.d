import configuration_adapter;
import sdlang;
import std.file : FileException;
import std.experimental.logger;

/// SDL implentation of ConfigurationAdapter
public final class SDLConfigurationAdapter : ConfigurationAdapter {
    /// Load configuration from file
    this() {
        try {
            auto data = parseFile("configs/hexeract.sdl");

            _host = data.getTagValue!string("bind-host", "0.0.0.0");
            _port = data.getTagAttribute!int("bind-host", "port", 25565);

            _renderDistance = data.getTagValue!int("render-distance", 12);
        }
        catch (FileException e) {
            warning("Generating new configuration...");
            save();
        }
    }

    /// Save configuration to file
    public void save() {
        auto data = new Tag();

        auto port_tag = new Attribute(null, "port", Value(port));
        new Tag(data, null, "bind-host", [Value(host)], [port_tag]);

        new Tag(data, null, "render-distance", [Value(renderDistance)]);

        import std.file : exists, mkdir, write;

        if (!exists("configs")) {
            mkdir("configs");
        }

        write("configs/hexeract.sdl", data.toSDLDocument());
    }
}
