using FFXIVClientStructs.FFXIV.Client.System.String;

namespace FFXIVClientStructs.FFXIV.Client.UI.Info;

[InfoProxy(InfoProxyId.PvPTeam)]
[StructLayout(LayoutKind.Explicit, Size = 0x110)]
public unsafe partial struct InfoProxyPvPTeam {
    [FieldOffset(0x00)] public InfoProxyInterface InfoProxyInterface;
    [FieldOffset(0x20)] public long Unk020;
    [FieldOffset(0x28)] public int Unk028;
    [FieldOffset(0x30)] public byte Unk030;
    [FieldOffset(0x32)] public short Unk032;
    [FieldOffset(0x34)] public byte Unk034;
    [FieldOffset(0x038)] public Utf8String UnkString0;
    [FieldOffset(0x0A0)] public Utf8String UnkString1;
    [FieldOffset(0x108)] public void* Unk108; //Ui struct
}
