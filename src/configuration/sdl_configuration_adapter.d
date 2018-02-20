/*
 * Copyright 2014-2018 Miguel Peláez <kernelfreeze@outlook.com>
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy of this software
 * and associated documentation files (the "Software"), to deal in the Software without restriction,
 * including without limitation the rights to use, copy, modify, merge, publish, distribute,
 * sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in all copies or
 * substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING
 * BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
 * DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/
module configuration.sdl_configuration_adapter;

import configuration.configuration_adapter;
import sdlang;
import std.file : FileException;
import std.experimental.logger;

/// SDL implentation of ConfigurationAdapter
public final class SDLConfigurationAdapter : ConfigurationAdapter {
    /// Load configuration from file
    this() {
        try {
            auto data = parseFile("configs/hexeract.sdl");

            _host = data.getTagValue!string("bind-host", host);
            _port = data.getTagAttribute!int("bind-host", "port", port);

            _renderDistance = data.getTagValue!int("render-distance", renderDistance);
            _compressionLevel = data.getTagValue!int("network-compression", compressionLevel);
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
        new Tag(data, null, "network-compression", [Value(compressionLevel)]);

        import std.file : exists, mkdir, write;

        if (!exists("configs")) {
            mkdir("configs");
        }

        write("configs/hexeract.sdl", data.toSDLDocument());
    }
}
