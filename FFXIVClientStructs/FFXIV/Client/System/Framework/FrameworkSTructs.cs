using FFXIVClientStructs.FFXIV.Client.System.Configuration;
using FFXIVClientStructs.FFXIV.Client.System.String;

namespace FFXIVClientStructs.FFXIV.Client.System.Framework;

public partial struct Framework {
    // ctor "E8 ?? ?? ?? ?? 48 8B C8 48 89 83 ?? ?? ?? ?? E8 ?? ?? ?? ?? 45 33 C0"
    [StructLayout(LayoutKind.Explicit, Size = 0x220)]
    public unsafe struct Unk578Obj {
        [FieldOffset(0x001)] public bool Unk001;
        [FieldOffset(0x008)] public SystemConfig* SystemConfig;
        [FieldOffset(0x010)] public nint Unk010;
        [FieldOffset(0x018)] public nint Unk018;
        [FieldOffset(0x020)] public nint Unk020;
        [FieldOffset(0x028)] public nint Unk028;
        [FieldOffset(0x030)] public nint Unk030;
        [FieldOffset(0x038)] public bool Unk038;
        [FieldOffset(0x040)] public bool Unk040;
        [FieldOffset(0x048)] public Utf8String Unk048;
        [FieldOffset(0x0B0)] public Utf8String Unk0B0;
        [FieldOffset(0x118)] public Utf8String Unk118;
        [FieldOffset(0x180)] public Utf8String Unk180;
        [FieldOffset(0x1E8)] public nint Unk1E8; //Function Pointer
        [FieldOffset(0x1F0)] public Framework* Framework;
        [FieldOffset(0x1F8)] public nint Unk1F8; //Function Pointer
        [FieldOffset(0x200)] public nint Unk200;
        [FieldOffset(0x210)] public nint Unk210;
        [FieldOffset(0x218)] public int Unk218;
    }

    //ctor -Unsiggable-
    [StructLayout(LayoutKind.Explicit, Size = 0x28)]
    public struct Unk2B98Obj {

    }

    // ctor E8 ?? ?? ?? ?? 48 8D 8E ?? ?? ?? ?? 48 89 AE ?? ?? ?? ?? 66 C7 86 
    [StructLayout(LayoutKind.Explicit, Size = 0xA8)]
    public unsafe struct Unk15C8Obj {
        //Some derived class 
        [FieldOffset(0x00)] public Thread Thread;
        [FieldOffset(0x38)] public Task Task;
    }

    // ctor C6 01 ?? 48 8D 81 
    [StructLayout(LayoutKind.Explicit, Size = 0x494)]
    public struct Unk2A8Obj {

    }

    //ctor 33 D2 C6 41 ?? ?? 48 89 51 ?? 8B C2 
    [StructLayout(LayoutKind.Explicit, Size = 0x30)]
    public struct Unk9F8Obj {
        [FieldOffset(0x00)] public int CursorPosX;
        [FieldOffset(0x04)] public int CursorPosY;
    }

    // ctor E8 ?? ?? ?? ?? 33 C0 45 89 BE 
    [StructLayout(LayoutKind.Explicit, Size = 0x194)]
    public struct Unk7B0Obj {
    }
}
