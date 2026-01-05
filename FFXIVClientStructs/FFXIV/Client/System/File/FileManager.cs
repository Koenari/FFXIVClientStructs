namespace FFXIVClientStructs.FFXIV.Client.System.File;

// Client::System::File::FileManager
//   Client::System::Framework::Task
[GenerateInterop]
[StructLayout(LayoutKind.Explicit, Size = 0x141a8)]
public unsafe partial struct FileManager {
    [StaticAddress("48 8B 3D ?? ?? ?? ?? 48 85 C0 48 8B CF", 3, isPointer: true)]
    public static partial FileManager* Instance();
    
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
