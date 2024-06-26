using FFXIVClientStructs.FFXIV.Client.Game;
using FFXIVClientStructs.FFXIV.Client.Network;
using FFXIVClientStructs.FFXIV.Client.Sound;
using FFXIVClientStructs.FFXIV.Client.System.Configuration;
using FFXIVClientStructs.FFXIV.Client.System.File;
using FFXIVClientStructs.FFXIV.Client.System.Input;
using FFXIVClientStructs.FFXIV.Client.System.String;
using FFXIVClientStructs.FFXIV.Client.System.Task;
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
[GenerateInterop]
[StructLayout(LayoutKind.Explicit, Size = 0x35C8)]
public unsafe partial struct Framework {
    [StaticAddress("49 8B DC 48 89 1D ?? ?? ?? ??", 6, true)]
    public static partial Framework* Instance();
    [FieldOffset(0x0008)] public byte Unk8;
    [FieldOffset(0x0009)] public bool Unk9;
    [FieldOffset(0x000A)] public bool StopRequested; 
    [FieldOffset(0x000C)] public int ProgramReturnCode;
    [FieldOffset(0x0010)] public SystemConfig SystemConfig;
    [FieldOffset(0x0460)] public DevConfig DevConfig;
    [FieldOffset(0x0570)] public SavedAppearanceManager* SavedAppearanceData;
    [FieldOffset(0x0578)] public Unk578Obj* Unk578;
    [FieldOffset(0x0580)] public byte ClientLanguage;
    [FieldOffset(0x0581)] public byte Region;
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
    [FieldOffset(0x1680)] public TimePoint UtcTime;
    [Obsolete("Use UtcTime.Timestamp")][FieldOffset(0x1680)] public long ServerTime; // TODO: change to uint
    [Obsolete("Use UtcTime.CpuMilliSeconds")][FieldOffset(0x1688)] public long PerformanceCounterInMilliSeconds;
    [Obsolete("Use UtcTime.CpuMicroSeconds")][FieldOffset(0x1688)] public long PerformanceCounterInMicroSeconds;
    [FieldOffset(0x1698)] public uint TimerResolutionMillis;
    [FieldOffset(0x16A0)] public long PerformanceCounterFrequency;
    [FieldOffset(0x16A8)] public long PerformanceCounterValue;
    /// <summary>
    /// Frame time (in seconds) to use for calculating animations, tasks, game logic and such. This is not necessarily the real time since the last frame.
    /// </summary>
    [FieldOffset(0x16B8)] public float FrameDeltaTime;
    /// <summary>
    /// Holds the unaltered real time since last frame in seconds.
    /// </summary>
    [FieldOffset(0x16BC)] public float RealFrameDeltaTime;
    /// <summary>
    /// If set to anything non-zero, overrides <see cref="FrameDeltaTime"/>. Has lower precedence than <see cref="FrameDeltaTimeOverride2"/>.
    /// </summary>
    [FieldOffset(0x16C0)] public float FrameDeltaTimeOverride;
    /// <summary>
    /// If non-zero <see cref="FrameDeltaTime"/> is multiplied with this.
    /// </summary>
    [FieldOffset(0x16C4)] public float FrameDeltaFactor;
    [FieldOffset(0x16C8)] public uint FrameCounter;
    [FieldOffset(0x16D0)] public long FrameDeltaTimeMSInt; // FrameDeltaTime in milliseconds, rounded to integer
    [FieldOffset(0x16D8)] public float FrameDeltaTimeMSRem; // sub-millisecond difference between real and rounded dt, added to the next frame
    [FieldOffset(0x16E0)] public long FrameDeltaTimeUSInt; // FrameDeltaTime in microseconds, rounded to integer
    [FieldOffset(0x16E8)] public float FrameDeltaTimeUSRem; // sub-microsecond difference between real and rounded dt, added to the next frame
    [FieldOffset(0x16F0)] public SpursManager* SpursManager;
    [FieldOffset(0x16F8)] public TaskManager TaskManager;
    [FieldOffset(0x1768)] public ClientTime ClientTime;
    [FieldOffset(0x17B0)] public float GameSpeedMultiplier; // usually 1, but during recording replay could be different
    [FieldOffset(0x17C4)] public float FrameRate;
    /// <summary>
    /// If true <see cref="FrameDeltaTime"/> is set to 0.
    /// </summary>
    [FieldOffset(0x17C8)] public bool DiscardFrame;
    /// <summary>
    /// If set to anything non-zero, overrides <see cref="FrameDeltaTime"/>. If negative <see cref="FrameDeltaTimeOverride"/> is used and 60fps as a fallback.
    /// Unlike <see cref="FrameDeltaTimeOverride"/>, this applies only to the next frame, and is reset to zero on next tick.
    /// </summary>
    [FieldOffset(0x17CC)] public float NextFrameDeltaTimeOverride;
    [FieldOffset(0x17D0)] public bool WindowInactive;

    [FieldOffset(0x17E0)] public int DataPathType;

    [FieldOffset(0x19EC), FixedSizeArray(isString: true)] internal FixedSizeArray260<char> _gamePath;
    [FieldOffset(0x1DFC), FixedSizeArray(isString: true)] internal FixedSizeArray260<char> _sqPackPath;
    [FieldOffset(0x220C), FixedSizeArray(isString: true)] internal FixedSizeArray260<char> _userPath;

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

    [FieldOffset(0x2BF0), FixedSizeArray(isString: true)] internal FixedSizeArray256<byte> _gameVersion;
    // TODO: convert to array of 64 strings each 32 bytes long if possible
    [FieldOffset(0x2CF0 + 0 * 0x20), FixedSizeArray(isString: true)] internal FixedSizeArray32<byte> _ex1Version; // Heavensward
    [FieldOffset(0x2CF0 + 1 * 0x20), FixedSizeArray(isString: true)] internal FixedSizeArray32<byte> _ex2Version; // Stormblood
    [FieldOffset(0x2CF0 + 2 * 0x20), FixedSizeArray(isString: true)] internal FixedSizeArray32<byte> _ex3Version; // Shadowbringers
    [FieldOffset(0x2CF0 + 3 * 0x20), FixedSizeArray(isString: true)] internal FixedSizeArray32<byte> _ex4Version; // Endwalker
    [FieldOffset(0x2CF0 + 4 * 0x20), FixedSizeArray(isString: true)] internal FixedSizeArray32<byte> _ex5Version; // Dawntrail

    [FieldOffset(0x34F8)] public WatchDogThread* WatchDogThread;
    [FieldOffset(0x3500)] public bool UseWatchDogThread;

    [FieldOffset(0x3510)] public int FramesUntilDebugCheck;
    
    [FieldOffset(0x3570)] public TimePoint Time3570;
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

    [MemberFunction("E8 ?? ?? ?? ?? 80 7B 1D 01")]
    public partial UIModule* GetUIModule();

    [MemberFunction("E8 ?? ?? ?? ?? 4C 8B 44 24 ?? 48 8B C8 48 8B D3")]
    public partial UIClipboard* GetUIClipboard();

    [MemberFunction("80 B9 ?? ?? ?? ?? 00 74 ?? 48 8B 81 ?? ?? ?? ?? C3")]
    public partial NetworkModuleProxy* GetNetworkModuleProxy();

    [MemberFunction("E8 ?? ?? ?? ?? 03 07")]
    public static partial long GetServerTime();

    /// <summary>
    /// Checks if the Steam API has been initialized by checking whether the <see cref="SteamApi"/> pointer is valid,
    /// and whether the sub-struct reports itself as ready.
    /// </summary>
    /// <returns>Returns true if the API is ready, false otherwise.</returns>
    [MemberFunction("E8 ?? ?? ?? ?? 88 43 08 84 C0 74 16")]
    public partial bool IsSteamApiInitialized();
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
}
