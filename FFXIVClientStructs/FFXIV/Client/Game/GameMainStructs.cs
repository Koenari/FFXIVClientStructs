namespace FFXIVClientStructs.FFXIV.Client.Game;

// Client::Game::GameMainUnk58ObjBaseBase
// ctor "E8 ?? ?? ?? ?? 49 89 76 ?? B8"
[GenerateInterop]
[StructLayout(LayoutKind.Explicit, Size = 0x10)]
public partial struct GameMainUnk58ObjBaseBase {

    [VirtualFunction(0)] public partial void dtor(bool a);
}
// Client::Game::GameMainUnk58ObjBase
//   Client::Game::GameMainUnk58ObjBaseBase
// no explicit ctor
[GenerateInterop]
[StructLayout(LayoutKind.Explicit, Size = 0x38)]
public unsafe partial struct GameMainUnk58ObjBase {
    [FieldOffset(0x00)] public GameMainUnk58ObjBaseBase GameMainUnk58ObjBaseBase;
    [FieldOffset(0x32)] public byte Unk32;
    [FieldOffset(0x33)] public byte Unk33;
    [FieldOffset(0x34)] public byte Unk34;

    [VirtualFunction(2)] public partial uint GetSheetIndex();
    [VirtualFunction(5)] public partial void* GetEntry(long index);
    [VirtualFunction(6)] public partial void* GetEntry2(long index);
}
// Client::Game::GameMainUnk58Obj
//   Client::Game::GameMainUnk58ObjBase
// ctor "E8 ?? ?? ?? ?? 48 8D 8B ?? ?? ?? ?? E8 ?? ?? ?? ?? 48 8D 8B ?? ?? ?? ?? E8 ?? ?? ?? ?? 48 8D 8B ?? ?? ?? ?? E8 ?? ?? ?? ?? 48 8D 05 ?? ?? ?? ?? C6 83"
[StructLayout(LayoutKind.Explicit, Size = 0x1B8)]
public unsafe partial struct GameMainUnk58Obj {
    [FieldOffset(0x0)] public GameMainUnk58ObjBase GameMainUnk58ObjBase;
    
    [FieldOffset(0x38), FixedSizeArray] internal FixedSizeArray8<Entry> _entries;
    
    [StructLayout(LayoutKind.Explicit, Size = 0x30)]
    public struct Entry {
        
    }
}

// Client::Game::GameMainUnk210Obj
//   Client::Game::GameMainUnk58ObjBase
// ctor "E8 ?? ?? ?? ?? 48 8D 8B ?? ?? ?? ?? E8 ?? ?? ?? ?? 48 8D 8B ?? ?? ?? ?? E8 ?? ?? ?? ?? 48 8D 05 ?? ?? ?? ?? C6 83"
[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct GameMainUnk210Obj {
    [FieldOffset(0x0)] public GameMainUnk58ObjBase Base;
    [FieldOffset(0x38),FixedSizeArray] internal FixedSizeArray10<Entry> _entries;
    
    [StructLayout(LayoutKind.Explicit, Size = 0x70)]
    public struct Entry {
        
    }
    
}
// Client::Game::GameMainUnk948Obj
//   Client::Game::GameMainUnk58ObjBaseBase
// ctor "40 53 48 83 EC ?? 33 D2 48 8B D9 E8 ?? ?? ?? ?? 48 8D 05 ?? ?? ?? ?? 66 C7 83"
[StructLayout(LayoutKind.Explicit)]
public unsafe struct GameMainUnk948Obj {
    
    
}
