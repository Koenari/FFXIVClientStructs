namespace FFXIVClientStructs.FFXIV.Client.System.Threading;

[StructLayout(LayoutKind.Explicit, Size = 0x1048)]
public unsafe partial struct ThreadManager {
    [FieldOffset(0x0008)] public nint FrameworkThread;
    [FieldOffset(0x0010)] public void* CriticalSection;
    [FixedSizeArray<Pointer<Thread>>(512)]
    [FieldOffset(0x0038)] public fixed byte Threads[8 * 512];
    [FieldOffset(0x1038)] public Thread* ActiveThread;
    [FieldOffset(0x1040)] public int ThreadCount;
}
