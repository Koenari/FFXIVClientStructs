using FFXIVClientStructs.FFXIV.Client.System.Framework;
using Thread = FFXIVClientStructs.FFXIV.Client.System.Threading.Thread;

namespace FFXIVClientStructs.FFXIV.Client.System.Task;
// Client::System::Task::SpursManager
//
// ctor "40 53 56 57 41 56 41 57 48 81 EC ?? ?? ?? ?? 48 8B 05 ?? ?? ?? ?? 48 33 C4 48 89 84 24 ?? ?? ?? ?? 48 8D 05"
[StructLayout(LayoutKind.Explicit, Size = 0x318)]
public unsafe struct SpursManager {
    [FieldOffset(0x008)] public SpursJobEntity Unk008;
    [FieldOffset(0x038)] public GameWindow* GameWindow;


    [FieldOffset(0x138)] public UnkownThread Unk138;
    [FieldOffset(0x1D8)] public UnkownThread Unk1D8;
    [FieldOffset(0x278)] public UnkownThread Unk278;
}
//ctor "E8 ?? ?? ?? ?? 49 89 5E ?? 49 8D BE"
[StructLayout(LayoutKind.Explicit, Size = 0x30)]
public struct SpursJobEntity {
    [FieldOffset(0x00)] public Thread Base;
    [FieldOffset(0x28)] public uint Unk28;
    [FieldOffset(0x2C)] public uint Unk2C;
}

//ctor "E8 ?? ?? ?? ?? 48 81 C7 ?? ?? ?? ?? 48 83 EB ?? 75 ?? 33 FF"
//dtor "E8 ?? ?? ?? ?? 48 83 EB ?? 75 ?? 49 8D 4E"
[StructLayout(LayoutKind.Explicit, Size = 0xA0)]
public struct UnkownThread {
    [FieldOffset(0x00)] public Thread Base;


}
