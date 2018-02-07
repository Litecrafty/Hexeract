# Hexeract
[![Discord](https://img.shields.io/discord/371055566480605184.svg)](https://discord.gg/qKjuDxx)

Work in progress, [Open source](https://en.wikipedia.org/wiki/Free_and_open-source_software) blazing fast [clean room](https://en.wikipedia.org/wiki/Clean_room_design) implementation of [Minecraft](https://minecraft.net) Server.

# Features
- [X] Native perfomance (D Programming Language).
- [X] Better memory management.
- [X] It does not use a main tick, with the possibilities of concurrency of modern programming languages, this is no longer necessary
- [ ] Allow multiple nodes sharing the same world.
- [ ] All vanilla server features.
- [X] Easy to use
- [ ] Server side plugin and mod API (Send mod textures and models from server to client)
- [x] More soon™ We have some crazy ideas... ;)

# Multi-node world sharing
Each server will load necessary chunks, but not the entire world. Every user and chunk on the network is assigned a timestamp – the date and time when it was created. When a [network split](https://en.wikipedia.org/wiki/Netsplit) occurs, two users with on each side are free to use the same chunk or nick, but when the two sides are joined, only one can survive. Although this prevents desynchronization, it can lead to loss of changes, so it is more advisable to have stable nodes. Using graph theory, would be something like this:

<img src="https://i.imgur.com/EILD6bY.png" width="300">

# Compile

 - Download `dub`, `ldc2` (or another D compiler), `gcc`
 - Install libraries: `libz-dev`, `libevent-dev` and `libssl-dev`
 - Build and run by using `dub` command.
 - Profit!

# Contributing
[Bug reports](https://github.com/KernelFreeze/Hexeract/issues) and [pull requests](https://github.com/KernelFreeze/Hexeract/pulls) are welcome on our GitHub. This project is intended to be a safe, welcoming space for collaboration and discussion, and contributors are expected to adhere to the [Contributor Covenant code of conduct](https://github.com/KernelFreeze/Hexeract/blob/master/CONTRIBUTING.md), you can read it on your Language [here](https://www.contributor-covenant.org/translations.html).

# License
[Apache License 2.0](https://github.com/KernelFreeze/Hexeract/blob/master/LICENSE)