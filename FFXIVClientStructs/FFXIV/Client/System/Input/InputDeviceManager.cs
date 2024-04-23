namespace FFXIVClientStructs.FFXIV.Client.System.Input;

//ctor 48 83 EC ?? 33 D2 45 33 C0 8D 4A ?? E8 ?? ?? ?? ?? 48 8B C8
[StructLayout(LayoutKind.Explicit, Size = 0x38)]
public unsafe struct InputDeviceManager {
    [FieldOffset(0x00)] internal void* Unk00;
}
