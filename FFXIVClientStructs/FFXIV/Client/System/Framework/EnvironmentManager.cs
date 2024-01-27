using FFXIVClientStructs.FFXIV.Common.Configuration;

namespace FFXIVClientStructs.FFXIV.Client.System.Framework;

[StructLayout(LayoutKind.Explicit, Size = 0x698)]
public struct EnvironmentManager {
    [FieldOffset(0x000)] public Task Task;
    [FieldOffset(0x038)] public ChangeEventInterface ChangeEventInterface;

    [FieldOffset(0x060)] public float Unk060; //1
    [FieldOffset(0x064)] public float Unk064; //0.5
    [FieldOffset(0x068)] public float Unk068; //0.5
    [FieldOffset(0x06C)] public int Unk06C; //1

    [FieldOffset(0x084)] public int CutsceneMovieVoice;
}
