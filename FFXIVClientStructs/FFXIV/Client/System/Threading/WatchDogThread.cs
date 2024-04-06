namespace FFXIVClientStructs.FFXIV.Client.System.Threading;

[StructLayout(LayoutKind.Explicit, Size = 0x48)]
public unsafe struct WatchDogThread {
    [FieldOffset(0x00)] public Thread Base;
    [FieldOffset(0x28)] public Framework.Framework* Framework;

    [FieldOffset(0x34)] public int Unk34; //-1 init

    [FieldOffset(0x40)] public int Unk40;

}
