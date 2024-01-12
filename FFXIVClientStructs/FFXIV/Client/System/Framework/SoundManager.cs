namespace FFXIVClientStructs.FFXIV.Client.System.Framework;

[StructLayout(LayoutKind.Explicit)]
public struct SoundManager {
    [FieldOffset(0x031)] public bool IsActive; //Or similar
    [FieldOffset(0x180)] public bool IsSoundBgmAlways;
    [FieldOffset(0x181)] public bool IsSoundSeAlways;
    [FieldOffset(0x182)] public bool IsSoundVoiceAlways;
    [FieldOffset(0x183)] public bool IsSoundSystemAlways;
    [FieldOffset(0x184)] public bool IsSoundEnvAlways;

    [FieldOffset(0x18F)] public bool IsSoundBgmAlways2;
    [FieldOffset(0x190)] public bool IsSoundPErformAlways;

    [FieldOffset(0x1CA)] public bool IsSoundAlways;

    [FieldOffset(0x1CC)] public bool WindowActive;
}
