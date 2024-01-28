using FFXIVClientStructs.FFXIV.Client.Game;
using FFXIVClientStructs.FFXIV.Client.Network;
using FFXIVClientStructs.FFXIV.Client.Sound;
using FFXIVClientStructs.FFXIV.Client.System.Configuration;
using FFXIVClientStructs.FFXIV.Client.System.File;
using FFXIVClientStructs.FFXIV.Client.System.Input;
using FFXIVClientStructs.FFXIV.Client.System.String;
using FFXIVClientStructs.FFXIV.Client.System.Threading;
using FFXIVClientStructs.FFXIV.Client.System.Timer;
using FFXIVClientStructs.FFXIV.Client.UI;
using FFXIVClientStructs.FFXIV.Common;
using FFXIVClientStructs.FFXIV.Common.Component.BGCollision;
using FFXIVClientStructs.FFXIV.Common.Lua;
using FFXIVClientStructs.FFXIV.Component.Excel;
using FFXIVClientStructs.FFXIV.Component.Exd;
using FFXIVClientStructs.FFXIV.Component.SteamApi;
using Thread = FFXIVClientStructs.FFXIV.Client.System.Threading.Thread;

namespace FFXIVClientStructs.FFXIV.Client.System.Framework;

// Client::System::Framework::Framework
// ctor "E8 ?? ?? ?? ?? 48 8B C8 48 89 05 ?? ?? ?? ?? EB 0A 48 8B CE"
[StructLayout(LayoutKind.Explicit, Size = 0x35C8)]
public unsafe partial struct Framework {
    [FieldOffset(0x0008)] public byte Unk8;
    [FieldOffset(0x0009)] public bool Unk9;
    [FieldOffset(0x000C)] public int UnkC;
    [FieldOffset(0x0010)] public SystemConfig SystemConfig;
    [FieldOffset(0x0460)] public DevConfig DevConfig;
    [FieldOffset(0x0570)] public SavedAppearanceManager* SavedAppearanceData;
    [FieldOffset(0x0578)] public Unk578Obj* Unk578;
    [FieldOffset(0x0580)] public byte ClientLanguage;
    [FieldOffset(0x0581)] public char Region;
    [FieldOffset(0x0588)] public Cursor* Cursor;
    [FieldOffset(0x0590)] public nint CallerWindow;
    [FieldOffset(0x0598)] public FileAccessPath ConfigPath;
    [FieldOffset(0x07A8)] public GameWindow* GameWindow;
    [FieldOffset(0x07B0)] public Unk7B0Obj Unk7B0;
    //180 byte
    [FieldOffset(0x09F8)] public Unk9F8Obj Unk9F8;
    [Obsolete] [FieldOffset(0x09F8)] public int CursorPosX;
    [Obsolete] [FieldOffset(0x09FC)] public int CursorPosY;
    [FieldOffset(0x0A28)] public Unk2A8Obj Unk2A8;
    [FieldOffset(0x0EBC)] public Unk7B0Obj UnkEBC;
    //180 byte
    [FieldOffset(0x1104)] public Unk9F8Obj Unk1104;
    [Obsolete] [FieldOffset(0x1104)] public int CursorPosX2;
    [Obsolete] [FieldOffset(0x1108)] public int CursorPosY2;
    [FieldOffset(0x1134)] public Unk2A8Obj Unk1134;
    [FieldOffset(0x15C8)] public Unk15C8Obj Unk15C8;
    [FieldOffset(0x1670)] public NetworkModuleProxy* NetworkModuleProxy;
    [FieldOffset(0x1678)] public bool IsNetworkModuleInitialized;
    [FieldOffset(0x1679)] public bool EnableNetworking;
    [FieldOffset(0x1680)] public AccurateTime UtcTime;
    [Obsolete("Use UtcTiem.Timestamp")] [FieldOffset(0x1680)]
    public long ServerTime; // TODO: change to uint
    [Obsolete("Use UtcTiem.CpuMilliSeconds")] [FieldOffset(0x1688)]
    public long PerformanceCounterInMilliSeconds;
    [Obsolete("Use UtcTime.CpuNanoSeconds")] [FieldOffset(0x1690)]
    public long PerformanceCounterInMicroSeconds;
    [FieldOffset(0x1698)] public uint TimerResolutionMillis;
    [FieldOffset(0x16A0)] public long PerformanceCounterFrequency;
    [FieldOffset(0x16A8)] public long PerformanceCounterValue;

    [FieldOffset(0x16B8)] public float FrameDeltaTime;
    [FieldOffset(0x16BC)] public int Unk16BC;
    [FieldOffset(0x16C0)] public float FrameDeltaTimeOverride;
    [FieldOffset(0x16C8)] public uint FrameCounter;
    [FieldOffset(0x16F0)] public SpursManager* Unk16F0;
    [FieldOffset(0x16F8)] public TaskManager TaskManager;
    [FieldOffset(0x1768)] public ClientTime ClientTime;
    [FieldOffset(0x1770)] [Obsolete("Use ClientTime.EorzeaTime")]
    public long EorzeaTime;
    [FieldOffset(0x1798)] [Obsolete("Use ClientTime.EorzeaTimeOverride")]
    public long EorzeaTimeOverride;
    [FieldOffset(0x17A0)] [Obsolete("Use ClientTime.IsEorzeaTimeOverridden")]
    public bool IsEorzeaTimeOverridden;
    [FieldOffset(0x17C4)] public float FrameRate;
    [FieldOffset(0x17D0)] public bool WindowInactive;

    [FieldOffset(0x19EC)] private fixed char gamePath[260]; // WideChar Array
    [FieldOffset(0x1DFC)] private fixed char sqPackPath[260]; // WideChar Array
    [FieldOffset(0x220C)] private fixed char userPath[260]; // WideChar Array

    [FieldOffset(0x2B30)] public ExcelModuleInterface* ExcelModuleInterface;
    [FieldOffset(0x2B38)] public ExdModule* ExdModule;
    [FieldOffset(0x2B40)] public void* VulgarWordFilter;
    [FieldOffset(0x2B48)] public void* VulgarWordFilterParty;
    [FieldOffset(0x2B50)] public BGCollisionModule* BGCollisionModule;
    [FieldOffset(0x2B60)] public UIModule* UIModule;
    [FieldOffset(0x2B68)] public UIClipboard* UIClipboard;
    [FieldOffset(0x2B78)] public EnvironmentManager* EnvironmentManager;
    [FieldOffset(0x2B80)] public SoundManager* SoundManager;
    [FieldOffset(0x2B90)] public InputThread.InputThread* InputThread;
    [FieldOffset(0x2B98)] public Unk2B98Obj Unk2B98;
    [FieldOffset(0x2BC8)] public LuaState LuaState;

    [FieldOffset(0x2BF0)] public GameVersion GameVersion;
    //8 byte
    [FieldOffset(0x34F8)] public WatchDogThread* WatchDogThread;
    [FieldOffset(0x3500)] public bool UseWatchDogThread;

    [FieldOffset(0x3570)] public AccurateTime Time3570;

    /// <summary>
    /// Set if <c>IsSteam</c> was set for this instance as part of <c>SetupSteamApi</c>. Set even if loading the Steam API
    /// fails for some reason.
    /// </summary>
    [FieldOffset(0x35B4)] public bool IsSteamGame;

    /// <summary>
    /// Access the Steam API wrapper/interface.
    /// </summary>
    /// <remarks>
    /// The struct backed by this API should not be considered stable. If you use this, you are signing up for API breakage.
    /// </remarks>
    [FieldOffset(0x35B8)] public SteamApi* SteamApi;

    /// <summary>
    /// Handle (type HMODULE) of steam_api64.dll
    /// </summary>
    [FieldOffset(0x35C0)] public nint SteamApiLibraryHandle;

    [StaticAddress("44 0F B6 C0 48 8B 0D ?? ?? ?? ??", 7, true)]
    public static partial Framework* Instance();

    [MemberFunction("E8 ?? ?? ?? ?? 80 7B 1D 01")]
    public partial UIModule* GetUiModule();

    [MemberFunction("E8 ?? ?? ?? ?? 4C 8B 44 24 ?? 48 8B C8 48 8B D3")]
    public partial UIClipboard* GetUIClipboard();

    [MemberFunction("80 B9 ?? ?? ?? ?? 00 74 ?? 48 8B 81 ?? ?? ?? ?? C3")]
    public partial NetworkModuleProxy* GetNetworkModuleProxy();

    [MemberFunction("E8 ?? ?? ?? ?? 89 47 2C")]
    public static partial long GetServerTime();

    /// <summary>
    /// Checks if the Steam API has been initialized by checking whether the <see cref="SteamApi"/> pointer is valid,
    /// and whether the sub-struct reports itself as ready.
    /// </summary>
    /// <returns>Returns true if the API is ready, false otherwise.</returns>
    [MemberFunction("E8 ?? ?? ?? ?? 88 43 08 84 C0 74 16")]
    public partial bool IsSteamApiInitialized();

    public string GamePath {
        get {
            fixed (char* p = gamePath)
                return new string(p);
        }
    }
    public string SqPackPath {
        get {
            fixed (char* p = sqPackPath)
                return new string(p);
        }
    }
    public string UserPath {
        get {
            fixed (char* p = userPath)
                return new string(p);
        }
    }

    // ctor "E8 ?? ?? ?? ?? 48 8B C8 48 89 83 ?? ?? ?? ?? E8 ?? ?? ?? ?? 45 33 C0"
    [StructLayout(LayoutKind.Explicit, Size = 0x220)]
    public struct Unk578Obj {
        [FieldOffset(0x048)] public Utf8String Unk048;
        [FieldOffset(0x0B0)] public Utf8String Unk0B0;
        [FieldOffset(0x118)] public Utf8String Unk118;
        [FieldOffset(0x180)] public Utf8String Unk180;
    }

    //ctor -Unsiggable-
    [StructLayout(LayoutKind.Explicit, Size = 0x28)]
    public struct Unk2B98Obj {

    }

    // ctor E8 ?? ?? ?? ?? 48 8D 8E ?? ?? ?? ?? 48 89 AE ?? ?? ?? ?? 66 C7 86 
    [StructLayout(LayoutKind.Explicit, Size = 0xA8)]
    public struct Unk15C8Obj {
        //Some derived class 
        [FieldOffset(0x00)] public Thread Thread;
        [FieldOffset(0x38)] public Task Task;
    }

    // ctor C6 01 ?? 48 8D 81 
    [StructLayout(LayoutKind.Explicit, Size = 0x494)]
    public struct Unk2A8Obj {

    }

    //ctor 33 D2 C6 41 ?? ?? 48 89 51 ?? 8B C2 
    [StructLayout(LayoutKind.Explicit, Size = 0x30)]
    public struct Unk9F8Obj {
        [FieldOffset(0x00)] public int CursorPosX;
        [FieldOffset(0x04)] public int CursorPosY;
    }

    // ctor E8 ?? ?? ?? ?? 33 C0 45 89 BE 
    [StructLayout(LayoutKind.Explicit, Size = 0x194)]
    public struct Unk7B0Obj {
    }

    //ctor "40 53 56 57 41 56 41 57 48 81 EC ?? ?? ?? ?? 48 8B 05 ?? ?? ?? ?? 48 33 C4 48 89 84 24 ?? ?? ?? ?? 48 8D 05"
    //dtor "48 89 5C 24 ?? 48 89 74 24 ?? 48 89 7C 24 ?? 41 56 48 83 EC ?? 48 8D 05 ?? ?? ?? ?? 4C 8B F1 48 89 01 48 8D 99 ?? ?? ?? ?? BE"
    [StructLayout(LayoutKind.Explicit, Size = 0x318)]
    public struct SpursManager {
        [FieldOffset(0x008)] public SpecialThread Unk008;
        [FieldOffset(0x038)] public GameWindow* GameWindow;


        [FieldOffset(0x138)] public UnkownThread Unk138;
        [FieldOffset(0x1D8)] public UnkownThread Unk1D8;
        [FieldOffset(0x278)] public UnkownThread Unk278;


        //ctor "E8 ?? ?? ?? ?? 49 89 5E ?? 49 8D BE"
        [StructLayout(LayoutKind.Explicit, Size = 0x30)]
        public struct SpecialThread {
            [FieldOffset(0x00)] public Thread Base;
            [FieldOffset(0x28)] public uint Unk28;
            [FieldOffset(0x2C)] public uint Unk2C;
        }

        //ctor "E8 ?? ?? ?? ?? 48 81 C7 ?? ?? ?? ?? 48 83 EB ?? 75 ?? 33 FF"
        //dtor "E8 ?? ?? ?? ?? 48 83 EB ?? 75 ?? 49 8D 4E"
        [StructLayout(LayoutKind.Explicit, Size = 0xA0)]
        public struct UnkownThread {
            [FieldOffset(0x00)] public Thread Base;


        }
    }
}
