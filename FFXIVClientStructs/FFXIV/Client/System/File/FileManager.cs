namespace FFXIVClientStructs.FFXIV.Client.System.File;
// Client::System::File::FileManager
//   Client::System::Framework::Task
// ctor "48 89 5C 24 ?? 48 89 6C 24 ?? 48 89 74 24 ?? 57 41 54 41 55 41 56 41 57 48 83 EC ?? 33 D2 48 8B F9"
[StructLayout(LayoutKind.Explicit, Size = 0x141A8)]
public unsafe partial struct FileManager {
    [FieldOffset(0x00038)] public FileThread* FileThread;
    [FieldOffset(0x00040)] public FileInterface* File;
    [FieldOffset(0x00048)] public Unk48Obj* Unk48;
    [FieldOffset(0x00158),FixedSizeArray] internal FixedSizeArray128<FileEntry> _fileEntries;
    //0x28D8 after
    [FieldOffset(0x14180)] public nint SemaphoreHandle;
    [FieldOffset(0x14188)] public nint EventHandle;

    [StructLayout(LayoutKind.Explicit, Size = 0x13C000)]
    public partial struct Unk48Obj {

        
        [FieldOffset(0x8),FixedSizeArray] internal FixedSizeArray2048<FileEntry> _entries;

        
    }
    [StructLayout(LayoutKind.Explicit, Size = 0x4F)]
    public struct FileEntry {
        [FieldOffset(0x38)] public byte* UnkString;

    }
}
