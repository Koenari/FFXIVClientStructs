namespace FFXIVClientStructs.FFXIV.Client.UI.Info;

[InfoProxy(InfoProxyId.Mentor)]
[StructLayout(LayoutKind.Explicit, Size = 0x28)]
public unsafe partial struct InfoProxyMentor {
    [FieldOffset(0x00)] public InfoProxyInterface InfoProxyInterface;
    [FieldOffset(0x18)] public byte Unk18; //Some Status
}
