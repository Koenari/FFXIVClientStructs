namespace FFXIVClientStructs.FFXIV.Common;

[StructLayout(LayoutKind.Explicit, Size = 0x18)]
public struct AccurateTime {
    [FieldOffset(0x00)] public uint TimeStamp;
    [FieldOffset(0x08)] public ulong CpuMilliSeconds;
    [FieldOffset(0x10)] public ulong CpuNanoSeconds;
}
