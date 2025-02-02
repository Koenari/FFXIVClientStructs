using FFXIVClientStructs.FFXIV.Application.Network;
using FFXIVClientStructs.FFXIV.Client.System.String;
using FFXIVClientStructs.FFXIV.Common;
using Unknown = nint;

namespace FFXIVClientStructs.FFXIV.Client.Network;

[GenerateInterop]
[StructLayout(LayoutKind.Explicit, Size = 0xB60)]
public unsafe partial struct NetworkModule {

    [FieldOffset(0x008)] public nint* UnkArr;
    [FieldOffset(0x010)] public uint UnkCount;

    [FieldOffset(0x028)] public byte LobbyCount;
    [FieldOffset(0x02C)] public fixed uint LobbyPorts[12];
    [FieldOffset(0x060),FixedSizeArray] internal FixedSizeArray12<Utf8String> _lobbyHosts;
    [FieldOffset(0x540)] public Utf8String Unk540;
    [FieldOffset(0x5A8)] public int Unk5A8; //OS related Win: 4944 Mac: 4985
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
    [FieldOffset(0x998)] public ZoneConnection* Unk998; //seen in getting FC info
    [FieldOffset(0x9A0)] public ChatConnection* Unk9A0; //Struct is similar to 930Obj
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
    [FieldOffset(0x9EC)] public int LobbyConnectionState; // 1=failure
    [FieldOffset(0x9F0)] public byte Unk9F0; //guessing bool

    //TODO: Offsets (+0x68)

    [FieldOffset(0x9F8)] public TimePoint Unk9F8;
    [FieldOffset(0xA10)] public int UnkA10;

    [FieldOffset(0xA40)] public int UnkA40; //Init = 30 (0x1e)
    [FieldOffset(0xA44)] public int UnkA44;
    [FieldOffset(0xA48)] public TimePoint UnkA48;
    [FieldOffset(0xA60)] public int UnkA60; //Init = 60 (0x3C)
    [FieldOffset(0xA68)] public void* UnkA68;
    [FieldOffset(0xA70)] public int UnkA70; // Struct spanning at lest 0x30
    [FieldOffset(0xA74)] public int CurrentDeviceTime; //Timestamp
    [FieldOffset(0xA78)] public int CurrentDeviceTimeMillis; //Milliseconds for A74
    [FieldOffset(0xA80)] public void* UnkA80;
    [FieldOffset(0xA88)] public TimePoint UnkA88;
    [FieldOffset(0xAA0)] public byte UnkAA0;
    [FieldOffset(0xAA8)] public TimePoint UnkAA8;

    [FieldOffset(0xAC0)] public uint ZoneConnectionState; //related to 998
    [FieldOffset(0xAC4)] public uint UnkAC4;
    [FieldOffset(0xAC8)] public uint ChatConnectionState; //related to 9A0
    [FieldOffset(0xAD0)] public TimePoint LastKeepAliveTimePoint;
    [FieldOffset(0xAE8)] public uint KeepAliveInterval; //init 0xbb8 (3000)
    [FieldOffset(0xAF0)] public TimePoint UnkAF0;
    [FieldOffset(0xB08)] public TimePoint UnkB08;
    [FieldOffset(0xB20)] public float UnkB20; //Init to 100
    [FieldOffset(0xB24)] public byte UnkB24; //Init 0
    [FieldOffset(0xB26)] public short CurrentInstance;
    [FieldOffset(0xB28)] public byte UnkB28; //Init 0
    [FieldOffset(0xB2C)] public int ClientLanguage;
    [FieldOffset(0xB30)] public int KeepAliveZone;
    [FieldOffset(0xB34)] public int KeepAliveIntervalZone;
    [FieldOffset(0xB38)] public int KeepAliveChat;
    [FieldOffset(0xB3C)] public int KeepAliveIntervalChat;
    [FieldOffset(0xB40)] public TimePoint UnkB40;
    [FieldOffset(0xB58)] public bool IsInCrossWorldDuty;

    //FUN_14021c0b0
    [MemberFunction("E8 ?? ?? ?? ?? 4C 8B B3 ?? ?? ?? ?? 48 89 BB")]
    public partial void GetCharacterData(void* p2, void* p3);

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

    //ctor "33 C0 41 B8 ?? ?? ?? ?? 48 89 01"
    [StructLayout(LayoutKind.Explicit, Size = 0x38)]
    public struct Unk9B8Obj {
        [FieldOffset(0x34)] public uint LobbyPing;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Unk9B0Obj {
        [FieldOffset(0x80)] public LobbyConnection* Unk80;
    }
}
