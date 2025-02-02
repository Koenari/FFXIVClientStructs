namespace FFXIVClientStructs.FFXIV.Client.System.File;

// Client::System::File::FileInterface
[StructLayout(LayoutKind.Explicit)]
public unsafe struct FileInterface {
    
    [FieldOffset(0x10)] public nint FileHandle;
    [FieldOffset(0x18)] public void* Unk18; //related to FileSearch
    
    [FieldOffset(0x20)] public byte IsFile;
    [FieldOffset(0x21)] public bool IsFileSearch;
}
