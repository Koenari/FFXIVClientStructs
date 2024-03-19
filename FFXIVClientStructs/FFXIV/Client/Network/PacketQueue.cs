namespace FFXIVClientStructs.FFXIV.Client.Network;

[StructLayout(LayoutKind.Explicit)]
public unsafe struct PacketQueue {

    [FieldOffset(0x48)] public DataStruct* Data;
    [FieldOffset(0x58)] public uint EntryCount;
    
    
    [StructLayout(LayoutKind.Explicit)]
    public struct DataStruct {
        [FieldOffset(0x408)] public Entry* Entries;
        [StructLayout(LayoutKind.Explicit,Size = 0x410)]
        public struct Entry {
        
        }
    }
    
    
}
