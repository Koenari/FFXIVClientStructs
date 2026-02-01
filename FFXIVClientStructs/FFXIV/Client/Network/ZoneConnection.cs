using FFXIVClientStructs.FFXIV.Client.System.String;
using Unknown = nint;

namespace FFXIVClientStructs.FFXIV.Client.Network;

// ctor "E8 ?? ?? ?? ?? EB ?? 49 8B C6 48 89 86"
[StructLayout(LayoutKind.Explicit, Size = 0xA0)]
public unsafe partial struct ZoneConnection {
    [FieldOffset(0x00)] public Utf8String ServerIp;
    [FieldOffset(0x68)] public short RemotePort;
    [FieldOffset(0x6C)] public int Unk6C;
    [FieldOffset(0x70)] public short Unk70;
    [FieldOffset(0x72)] public short Unk72;

    //Stays the same for each character
    //Neither ContentID nor LodestoneID
    [FieldOffset(0x78)] public StdVector<byte> Unk78;
    [FieldOffset(0x90)] public int Unk90;
    [FieldOffset(0x94)] public int Unk94;
    [FieldOffset(0x98)] public Unk98Obj* Unk098;

    //FUN_1415858f0 proxies Unk098.FUN_1415ea880(...)
    [StructLayout(LayoutKind.Explicit, Size = 0x118)]
    public partial struct Unk98Obj {
        [FieldOffset(0x00)] public void** vtbl; //vfunc 0: Dispose
        [FieldOffset(0x008)] public Unk008Obj* Unk008; //Some struct
        [FieldOffset(0x010)] public Unk010Obj* Unk010;
        [FieldOffset(0x040)] public Unknown* Unk040; //Looks like a self referencing empty vector
        [FieldOffset(0x048)] public Unknown* Unk048;
        [FieldOffset(0x088)] public void* Unk088;
        [FieldOffset(0x090)] public void* Unk090; //Maybe a function pointer

        //vtbl at 141c161e8
        [FieldOffset(0x098)] public void* Unk098; //Maybe a function pointer

        //vtbl at 141c16280
        [FieldOffset(0x0C8)] public void* Unk0C8;

        [FieldOffset(0x108)] public uint Unk108;

        [FieldOffset(0x110)]
        public uint Unk110; //Very likely a state (4 seems special). Set based on Unk010Obj.UnkD8

        [FieldOffset(0x114)] public ushort Unk114;


        public struct Unk008Obj {
        }

        [StructLayout(LayoutKind.Explicit, Size = 0x270)]
        public struct Unk010Obj {
            [FieldOffset(0x008)] public Unk008Obj2 Unk008;
            [FieldOffset(0x010)] public Unknown* Unk010; //Looks like a self referenceing empty vector
            [FieldOffset(0x030)] public uint PacketNumber1; //Counts up (packet #)?
            [FieldOffset(0x034)] public uint PacketNumber2; //counts up (packet #)?
            [FieldOffset(0x038)] public ulong Unk038; //Counts up and resets (.. since last ...)
            [FieldOffset(0x040)] public ulong Unk040; //Timestamp in ms

            [FieldOffset(0x048)]
            public ulong Unk048; //Seen values between 140 and 200 (changes each tick) (maybe time since last ...)

            [FieldOffset(0x050)] public ulong Unk050; //Timestamp in ms
            [FieldOffset(0x080)] public void* Unk080; //CriticalSection
            [FieldOffset(0x0A8)] public void* Unk0A8; //CriticalSection
            [FieldOffset(0x0D8)] public int Unk0D8; //State
            [FieldOffset(0x0E0)] public Utf8String IpAddress;
            [FieldOffset(0x148)] public int ServerPort;
            [FieldOffset(0x150)] public Unknown Unk150;
            [FieldOffset(0x158)] public StdVector<byte> Unk158; //Holds character specific number
            [FieldOffset(0x170)] public Unknown Unk170;
            [FieldOffset(0x178)] public void* Unk178;

            [FieldOffset(0x190)] public void* Unk190; //CriticalSection
            [FieldOffset(0x200)] public void* Unk200; //CriticalSection

            [StructLayout(LayoutKind.Explicit)]
            public struct Unk008Obj2 {
                
            }
        }
    }
}
