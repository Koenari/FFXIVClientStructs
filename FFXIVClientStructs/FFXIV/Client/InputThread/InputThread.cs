using Thread = FFXIVClientStructs.FFXIV.Client.System.Threading.Thread;

namespace FFXIVClientStructs.FFXIV.Client.InputThread;


[StructLayout(LayoutKind.Explicit, Size = 0x100)]
public struct InputThread {
    [FieldOffset(0x000)] public nint ResourceEventListener;
    [FieldOffset(0x008)] public Thread Thread;
}
