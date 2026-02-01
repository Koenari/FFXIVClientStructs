using FFXIVClientStructs.FFXIV.Client.System.String;
using FFXIVClientStructs.FFXIV.Common;
using Unknown = nint;
namespace FFXIVClientStructs.FFXIV.Client.Network;

//
// ctor "E8 ?? ?? ?? ?? 48 8B D8 48 8B 85"
// ctor(host, port, ticket)
[StructLayout(LayoutKind.Explicit, Size = 0x7C8)]
public unsafe struct LobbyConnection {
    [FieldOffset(0x28)] public int Unk028;
    [FieldOffset(0x2C)] public short Unk02C;
    [FieldOffset(0x30)] public int Unk030;
    [FieldOffset(0x038)] public TimePoint Unk038;
    [FieldOffset(0x050)] public int Unk050;
    [FieldOffset(0x070)] public Utf8String Unk070;
    [FieldOffset(0x0D8)] public uint Unk0D8;
    [FieldOffset(0x0E0)] public short Unk0E0;
    [FieldOffset(0x0E8)] public Utf8String Unk0E8;
    [FieldOffset(0x150)] public Utf8String Unk150;
    [FieldOffset(0x208)] public byte Unk208;
    [FieldOffset(0x210)] public Unknown Unk210;
    [FieldOffset(0x218)] public Unknown Unk218;
    [FieldOffset(0x220)] public short Unk220;
    [FieldOffset(0x222)] public byte Unk222;
    [FieldOffset(0x228)] public Unknown Unk228;
    [FieldOffset(0x230)] public Unknown Unk230;
    [FieldOffset(0x238)] public Unknown Unk238; //Same as 228
    [FieldOffset(0x240)] public Unknown Unk240;
    [FieldOffset(0x248)] public Unknown Unk248;
    [FieldOffset(0x250)] public Unknown Unk250;
    [FieldOffset(0x258)] public Unknown Unk258;
    [FieldOffset(0x260)] public Unk260Obj Unk260;
    [FieldOffset(0x278)] public Unknown Unk278;
    [FieldOffset(0x280)] public Unknown Unk280;
    [FieldOffset(0x288)] public Unknown Unk288;
    [FieldOffset(0x290)] public Unknown Unk290;
    [FieldOffset(0x298)] public Unknown Unk298;
    [FieldOffset(0x2A0)] public Unknown Unk2A0;
    [FieldOffset(0x2A8)] public Unk2A8Obj Unk2A8;
    [FieldOffset(0x2C8)] public Unk2C8Obj Unk2C8;
    [FieldOffset(0x328)] public Unk260Obj Unk328;
    [FieldOffset(0x240)] public Utf8String Unk340;
    [FieldOffset(0x3B0)] public Utf8String Unk3B0;
    [FieldOffset(0x418)] public Utf8String Unk418;
    [FieldOffset(0x480)] public Unknown Unk480;
    [FieldOffset(0x488)] public int Unk488; //Init to 30(0x1e)
    [FieldOffset(0x48C)] public int Unk48C; //Init to 30(0x1e)
    [FieldOffset(0x490)] public int Unk490; //Init to 30(0x1e)
    [FieldOffset(0x498)] public Unknown Unk498; //Copied from param_5
    [FieldOffset(0x4A0)] public Unknown Unk4A0;
    [FieldOffset(0x4A8)] public Unknown Unk4A8;
    [FieldOffset(0x4B0)] public Unknown Unk4B0;
    [FieldOffset(0x4B8)] public Unknown Unk4B8;
    [FieldOffset(0x4C0)] public Unknown Unk4C0;
    [FieldOffset(0x4C8)] public Utf8String Host;
    [FieldOffset(0x530)] public int Port;
    [FieldOffset(0x538)] public Unk538Obj* Unk538;
    [FieldOffset(0x540)] public int Unk540;
    [FieldOffset(0x548)] public Utf8String Ticket;
    [FieldOffset(0x5B0)] public Utf8String World;
    [FieldOffset(0x618)] public Utf8String Zone;
    [FieldOffset(0x680)] public Utf8String Unk680;
    [FieldOffset(0x6E8)] public short Unk6E8;
    [FieldOffset(0x6EC)] public Unknown Unk6EC;
    [FieldOffset(0x6F8)] public Utf8String Unk6F8;
    [FieldOffset(0x760)] public Utf8String Unk760;

    [StructLayout(LayoutKind.Explicit, Size = 0x130)]
    public struct Unk538Obj {
        [FieldOffset(0x010)] public Unk010Obj* Unk010;
        
        [FieldOffset(0x118)] public TimePoint TimePoint;
        
        
        //ctor "E8 ?? ?? ?? ?? 48 8B F0 48 8B CE 48 89"
        //vtable 0x141c8ff08 (base 0x141c8fdc8)
        [StructLayout(LayoutKind.Explicit, Size = 0x1B8)]
        public struct Unk010Obj {
            [FieldOffset(0x080)] public nint CriticalSection080;
            [FieldOffset(0x0A8)] public nint CriticalSection0A8;
            [FieldOffset(0x0D8)] public Unk0D8Obj* Unk0D8;
            [FieldOffset(0x110)] public void* Unbk110; //freed in dtor
            [FieldOffset(0x120)] public Utf8String Host;
            [FieldOffset(0x190)] public Unk190Obj* Unk190;
            [FieldOffset(0x198)] public TimePoint Time198;

            //vtable 0x141c8fe40 (base 0x141c8fdf8)
            [StructLayout(LayoutKind.Explicit, Size = 0x1048)]
            public struct Unk0D8Obj {
                [FieldOffset(0x0)] public void* vtbl;
                [FieldOffset(0x38)] public Unk38Obj* Unk38;

                //ctor "E8 ?? ?? ?? ?? 49 83 FD ?? 0F 84"
                [StructLayout(LayoutKind.Explicit, Size = 0x1048)]
                public struct Unk38Obj {

                }
            }

            //ctor "E8 ?? ?? ?? ?? EB ?? 49 8B C6 48 8B 5C 24"
            //vtable 0x141c8fec8 (base 0x141c8fe88)
            [StructLayout(LayoutKind.Explicit, Size = 0x9168)]
            public struct Unk190Obj {

            }
        }
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x18)]
    public struct Unk260Obj {
        [FieldOffset(0x00)] public Unknown Unk00;
        [FieldOffset(0x08)] public Unknown Unk08;
        [FieldOffset(0x10)] public Unknown Unk10;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x20)]
    public struct Unk2A8Obj {
        [FieldOffset(0x00)] public Unknown Unk00;
        [FieldOffset(0x08)] public Unknown Unk08;
        [FieldOffset(0x10)] public Unknown Unk10;
        [FieldOffset(0x18)] public Unknown Unk18;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x5B)]
    public struct Unk2C8Obj {
    }


}
