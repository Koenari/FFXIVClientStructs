﻿using System.Runtime.InteropServices;

namespace FFXIVClientStructs.FFXIV.Client.Game.Character {
    // Client::Game::Character::Ornament
    //   Client::Game::Character::Character
    //     Client::Game::Object::GameObject
    //     Client::Graphics::Vfx::VfxDataListenner
    // ornament = accessory

    // ctor E8 ?? ?? ?? ?? 48 8B C8 EB 03 48 8B CF 48 8B 46 08 45 33 C9
    [StructLayout(LayoutKind.Explicit, Size = 0x1A00)]
    public struct Ornament {
        [FieldOffset(0x0)] public Character Character;

        [FieldOffset(0x19F0)] public uint OrnamentId;
    }
}
