namespace FFXIVClientStructs.FFXIV.Client.System.File;

// Client::System::File::FileThread
//   Client::System::Threading::Thread
// ctor "E8 ?? ?? ?? ?? 48 8D 0D ?? ?? ?? ?? 48 89 43 ?? 48 89 4C 24"
[StructLayout(LayoutKind.Explicit, Size = 0x2518)]
public unsafe struct FileThread {
    [FieldOffset(0x0008)] public void* SecurityAttributes; //https://learn.microsoft.com/en-us/windows/win32/api/synchapi/nf-synchapi-createeventa
    
    [FixedSizeArray<Pointer<Unk28Obj>>(20)]
    [FieldOffset(0x0028)] public fixed byte Unk28Arr[20*0x8];

    
    [FieldOffset(0x04E8)] public Unk4E8Obj Unk4E8;
    
    [StructLayout(LayoutKind.Explicit, Size = 0xAF)]
    public struct Unk28Obj {
        
    }
    
    [StructLayout(LayoutKind.Explicit, Size = 0x203)]
    public struct Unk4E8Obj {
        
    }
}
