import vibe.d;
import configuration;
import accessors;
import std.experimental.logger;

/// Main server class
public final class Hexeract {
	@Read @Write private ConfigurationAdapter _configuration;

	@Read private static const string _hexeract = "0.1";

	@Read private static const string _minecraft = "1.13";

	mixin(GenerateFieldAccessors);
}

/// Main function
shared static this() {
	Hexeract server = new Hexeract;

	// TODO: Fancy logger: colors, only [INFO], etc
	infof("Starting Hexeract v%s for Minecraft %s...", server.hexeract, server.minecraft);

	info("Pre-initializing plugins and services...");
	// TODO: Call pre-init function here

	if (server.configuration is null) {
		server.configuration = new SDLConfigurationAdapter;
	}

	info("Initializing plugins and services...");
	// TODO: Call init function here

	listenTCP(cast(short) server.configuration.port, delegate void(TCPConnection conn) {
		conn.pipe(conn);
	}, server.configuration.host);

	infof("Listening at: %s:%d", server.configuration.host, server.configuration.port);

	// TODO: Call post post-init function
}
