namespace FFXIVClientStructs.FFXIV.Client.System.Threading;

// Client::System::Threading::WatchDogThread
//   Client::System::Threading::Thread
//     Client::System::Common::NonCopyable
[GenerateInterop]
[Inherits<Thread>]
[StructLayout(LayoutKind.Explicit, Size = 0x48)]
public unsafe partial struct WatchDogThread {
    [FieldOffset(0x28)] public Framework.Framework* Framework;

    [FieldOffset(0x34)] public int Unk34; //-1 init

    [FieldOffset(0x40)] public int Unk40;

}
