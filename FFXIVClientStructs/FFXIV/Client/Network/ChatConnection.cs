using FFXIVClientStructs.FFXIV.Client.System.String;

namespace FFXIVClientStructs.FFXIV.Client.Network;

[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct ChatConnection {
    [FieldOffset(0x00)] public Utf8String Unk00;
    //0x10 byte
    [FieldOffset(0x78)] public StdVector<ulong> Unk78; //ulong is a placeholder
    [FieldOffset(0xA0)] public UnkA0Obj* UnkA0;

    [StructLayout(LayoutKind.Explicit)]
    public partial struct UnkA0Obj {
        [FieldOffset(0x00)] public void** vtbl;

        [FieldOffset(0x108)] public uint Unk108;
        [FieldOffset(0x110)] public uint Unk110;
    }
}
