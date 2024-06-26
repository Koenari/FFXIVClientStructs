namespace FFXIVClientStructs.FFXIV.Client.System.File;

// Client::System::File::FileThread
//   Client::System::Threading::Thread
//     Client::System::Common::NonCopyable
// ctor "E8 ?? ?? ?? ?? 48 8D 0D ?? ?? ?? ?? 48 89 43 ?? 48 89 4C 24"

[StructLayout(LayoutKind.Explicit, Size = 0x2518)]
public unsafe partial struct FileThread {
    [FieldOffset(0x0008)] public void* SecurityAttributes; //https://learn.microsoft.com/en-us/windows/win32/api/synchapi/nf-synchapi-createeventa
    
    [FieldOffset(0x0028),FixedSizeArray] internal FixedSizeArray20<Pointer<Unk28Obj>> _unk28Arr;

    
    [FieldOffset(0x04E8)] public Unk4E8Obj Unk4E8;
    
    [StructLayout(LayoutKind.Explicit, Size = 0xAF)]
    public struct Unk28Obj {
        
    }
    
    [StructLayout(LayoutKind.Explicit, Size = 0x203)]
    public struct Unk4E8Obj {
        
    }
}
