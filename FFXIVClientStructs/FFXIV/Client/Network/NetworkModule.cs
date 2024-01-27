using FFXIVClientStructs.FFXIV.Application.Network;
using FFXIVClientStructs.FFXIV.Client.System.String;
using FFXIVClientStructs.FFXIV.Common;
using Unknown = nint;

namespace FFXIVClientStructs.FFXIV.Client.Network;

[StructLayout(LayoutKind.Explicit, Size = 0xB60)]
public unsafe partial struct NetworkModule {

    [FieldOffset(0x008)] public nint* UnkArr;
    [FieldOffset(0x010)] public uint UnkCount;

    [FieldOffset(0x028)] public byte LobbyCount;
    [FieldOffset(0x02C)] public fixed uint LobbyPorts[12];
    [FixedSizeArray<Utf8String>(12)]
    [FieldOffset(0x060)] public fixed byte LobbyHosts[12 * 0x68];
    [FieldOffset(0x540)] public Utf8String Unk540;
    [FieldOffset(0x5A8)] public int Unk5A8; //Set by FUN_14021be20, OS related
    [FieldOffset(0x5AC)] public int OperatingSystemTypeAndVersion; //Most likely this is an enum
    [FieldOffset(0x5B0)] public uint SaveDataBankPort;
    [FieldOffset(0x5B8)] public Utf8String SaveDataBankHost; //Config Saves
    [FieldOffset(0x620)] public uint SaveDataBankMode;
    [FieldOffset(0x624)] public uint DktWebPort;
    [FieldOffset(0x628)] public Utf8String DktWebHost; //DC Travel
    [FieldOffset(0x690)] public uint ActiveLobbyPort;
    [FieldOffset(0x698)] public Utf8String ActiveLobbyHost;
    [FieldOffset(0x700)] public uint AlternateLobbyPort;
    [FieldOffset(0x708)] public Utf8String AlternateLobbyHost;
    [FieldOffset(0x770)] public uint LobbyRetryCount;
    [FieldOffset(0x774)] public uint LobbyRetryInterval;
    [FieldOffset(0x778)] public uint LobbyPing;
    [FieldOffset(0x77C)] public uint FrontPort;
    [FieldOffset(0x780)] public Utf8String FrontHost;
    [FieldOffset(0x7E8)] public Utf8String FrontProtocol;
    [FieldOffset(0x850)] public bool UseCfgFrontend;
    [FieldOffset(0x858)] public Utf8String Ticket;
    [FieldOffset(0x8C0)] public Utf8String World;
    [FieldOffset(0x928)] public Utf8String ZoneName;
    [FieldOffset(0x990)] public byte Unk990;
    [FieldOffset(0x994)] public int Unk994;
    //This region seems to generally hold references to other objects
    [FieldOffset(0x998)] public Unk998Obj* Unk998; //seen in getting FC info
    [FieldOffset(0x9A0)] public Unk9A0Obj* Unk9A0; //Struct is similar to 930Obj
    [FieldOffset(0x9A8)] public LobbyConnection* Unk9A8;
    [FieldOffset(0x9B0)] public Unk9B0Obj* Unk9B0;
    [FieldOffset(0x9B8)] public Unk9B8Obj* Unk9B8;
    [FieldOffset(0x9C0)] public Unk9C0Struct* Unk9C0; //Has vtbl
    [FieldOffset(0x9C8)] public byte Unk9C8; //Related to 940
    [FieldOffset(0x9C9)] public bool WinSockInitialized;
    [FieldOffset(0x9D0)] public NetworkModulePacketReceiverCallback* PacketReceiverCallback;
    [FieldOffset(0x9D8)] public void* Unk9D8;
    [FieldOffset(0x9E0)] public void* Unk9E0;

    [FieldOffset(0x9E8)] public int Unk9E8; //Compared to 4, most likely state

    //OVERLAP!!
    [FieldOffset(0x9EC)] public int Unk9EC; //State related to Unk940
    [FieldOffset(0x9F0)] public byte Unk9F0; //guessing bool

    //TODO: Offsets (+0x68)

    [FieldOffset(0x9F8)] public AccurateTime Unk9F8;
    [FieldOffset(0xA10)] public int UnkA10;

    [FieldOffset(0xA40)] public int UnkA40; //Init = 30 (0x1e)
    [FieldOffset(0xA44)] public int UnkA44;
    [FieldOffset(0xA48)] public AccurateTime UnkA48;
    [FieldOffset(0xA60)] public int UnkA60; //Init = 60 (0x3C)
    [FieldOffset(0xA68)] public void* UnkA68;
    [FieldOffset(0xA70)] public int UnkA70;
    [FieldOffset(0xA74)] public int CurrentDeviceTime; //Timestamp
    [FieldOffset(0xA78)] public int CurrentDeviceTimeMillis; //Milliseconds for A74
    [FieldOffset(0xA80)] public void* UnkA80;
    [FieldOffset(0xA88)] public AccurateTime UnkA88;
    [FieldOffset(0xAA0)] public byte UnkAA0;
    [FieldOffset(0xAA8)] public AccurateTime UnkAA8;

    [FieldOffset(0xAC0)] public uint UnkAC0; //related to 998
    [FieldOffset(0xAC4)] public uint UnkAC4;
    [FieldOffset(0xAC8)] public void* UnkAC8; //related to 9A0
    [FieldOffset(0xAD0)] public AccurateTime UnkAD0;
    [FieldOffset(0xAE8)] public void* UnkAE8; //init 0xbb8 (3000)
    [FieldOffset(0xAF0)] public AccurateTime UnkAF0;
    [FieldOffset(0xB08)] public AccurateTime UnkB08;
    [FieldOffset(0xB20)] public int UnkB20; //Init 0x42c80000
    [FieldOffset(0xB24)] public byte UnkB24; //Init 0
    [FieldOffset(0xB26)] public short CurrentInstance;
    [FieldOffset(0xB28)] public byte UnkB28; //Init 0
    [FieldOffset(0xB2C)] public int UnkB2C; //Init 0xffffffff
    [FieldOffset(0xB30)] public int KeepAliveZone;
    [FieldOffset(0xB34)] public int KeepAliveIntervalZone;
    [FieldOffset(0xB38)] public int KeepAliveChat;
    [FieldOffset(0xB3C)] public int KeepAliveIntervalChat;
    [FieldOffset(0xB40)] public AccurateTime UnkB40;
    [FieldOffset(0xB58)] public bool IsInCrossWorldDuty;

    //FUN_14021c0b0
    [MemberFunction("E8 ?? ?? ?? ?? 4C 8B B3 ?? ?? ?? ?? 48 89 BB")]
    public partial void GetChracterData(void* p2, void* p3);

    public enum OSTypeVersion : short {
        Windows7 = 4, //0000000000000100
        Windows8 = 10, //0000000000001010
        Windows10 = 16, //0000000000010000
        Windows11 = 22, //0000000000010110    //Build > 21999
        WindowsXPOrVista = 28, //0000000000011010
        MacOS = 31, //0000000000011111
        UnkownWindows = 34 //0000000000100110
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct Unk9C0Struct {
        [FieldOffset(0x0)] public LobbyClient.LobbyRequestCallback LobbyRequestCallback;
    }


    [StructLayout(LayoutKind.Explicit, Size = 0xA0)]
    public partial struct Unk998Obj {
        [FieldOffset(0x00)] public Utf8String ServerIp;

        [FieldOffset(0x68)] public short Unk68;
        [FieldOffset(0x6C)] public int Unk6C;
        [FieldOffset(0x70)] public short Unk70;
        [FieldOffset(0x72)] public short Unk72;

        //Stays the same for eacch character
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
            [FieldOffset(0x040)] public Unknown* Unk040; //Looks like a self referenceing empty vector
            [FieldOffset(0x048)] public Unknown* Unk048;
            [FieldOffset(0x088)] public void* Unk088;
            [FieldOffset(0x090)] public void* Unk090; //Maybe a fucntion pointer

            //vtbl at 141c161e8
            [FieldOffset(0x098)] public void* Unk098; //Maybe a fucntion pointer

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
                [FieldOffset(0x000)] public void** vtbl;
                [FieldOffset(0x008)] public Unk008Obj2 Unk008;
                [FieldOffset(0x010)] public Unknown* Unk010; //Looks like a self referenceing empty vector
                [FieldOffset(0x030)] public uint PacketNumber1; //Counts up (packet #)?
                [FieldOffset(0x034)] public uint PacketNumber2; //counts up (packet #)?
                [FieldOffset(0x038)] public ulong Unk038; //Counts up and resets (.. since last ...)
                [FieldOffset(0x040)] public ulong Unk040; //Timestamp in ms

                [FieldOffset(0x048)]
                public ulong Unk048; //Seen values between 140 and 200 (changes each tick) (maybe ns since last ...)

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
                    [FieldOffset(0x000)] public void** vtbl;
                }
            }
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct Unk9A0Obj {
        [FieldOffset(0x00)] public Utf8String Unk00;
        //0x10 byte
        [FieldOffset(0x78)] public StdVector<ulong> Unk78; //ulong is a placeholder
        [FieldOffset(0xA0)] public UnkA0Obj* UnkA0;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct UnkA0Obj {
            [FieldOffset(0x00)] public void** vtbl;

            [FieldOffset(0x108)] public uint Unk108;
            [FieldOffset(0x110)] public uint Unk110;
        }
    }

    // ctor "E8 ?? ?? ?? ?? 48 8B D8 48 8B 85"
    // ctor(host, port, ticket)
    [StructLayout(LayoutKind.Explicit, Size = 0x7C8)]
    public struct LobbyConnection {
        //ctor FUN_141586030
        [FieldOffset(0x28)] public int Unk028;
        [FieldOffset(0x2C)] public short Unk02C;
        [FieldOffset(0x30)] public int Unk030;
        [FieldOffset(0x038)] public AccurateTime Unk038;
        [FieldOffset(0x050)] public int Unk050;
        [FieldOffset(0x070)] public Utf8String Unk070;
        [FieldOffset(0x0D8)] public uint Unk0D8;
        [FieldOffset(0x0E0)] public short Unk0E0;
        [FieldOffset(0x0E8)] public Utf8String Unk0E8;
        [FieldOffset(0x150)] public Utf8String Unk150;
        [FieldOffset(0x1B8)] public fixed byte Unk1B8[0x50]; //MemSet to 0x0
        [FieldOffset(0x208)] public byte Unk208;
        [FieldOffset(0x210)] public Unknown Unk210;
        [FieldOffset(0x218)] public Unknown Unk218;
        [FieldOffset(0x220)] public short Unk220;
        [FieldOffset(0x222)] public byte Unk222;
        [FieldOffset(0x228)] public void* Unk228;
        [FieldOffset(0x230)] public Unknown Unk230;
        [FieldOffset(0x238)] public void* Unk238; //Same as 228
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
        [FieldOffset(0x5B0)] public Utf8String Unk5B0;
        [FieldOffset(0x618)] public Utf8String Unk618;
        [FieldOffset(0x680)] public Utf8String Unk680;
        [FieldOffset(0x6E8)] public short Unk6E8;
        [FieldOffset(0x6EC)] public Unknown Unk6EC;
        [FieldOffset(0x6F8)] public Utf8String Unk6F8;
        [FieldOffset(0x760)] public Utf8String Unk760;

        [StructLayout(LayoutKind.Explicit, Size = 0x130)]
        public struct Unk538Obj {
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

    [StructLayout(LayoutKind.Explicit, Size = 0x38)]
    public struct Unk9B8Obj {
        [FieldOffset(0x34)] public uint LobbyPing;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Unk9B0Obj {
        [FieldOffset(0x80)] public LobbyConnection* Unk80;
    }
}
