using FFXIVClientStructs.FFXIV.Component.GUI;

namespace FFXIVClientStructs.FFXIV.Client.UI;

// Client::UI::AddonExp
//   Component::GUI::AtkUnitBase
//     Component::GUI::AtkEventListener
[Addon("_Exp")]
[GenerateInterop]
[Inherits<AtkUnitBase>]
[StructLayout(LayoutKind.Explicit, Size = 0x290)]
public partial struct AddonExp {
    [FieldOffset(0x270)] public byte ClassJob;

    [FieldOffset(0x278)] public uint CurrentExp;
    [FieldOffset(0x27C)] public uint RequiredExp;
    [FieldOffset(0x280)] public uint RestedExp;

    public float CurrentExpPercent => (float)CurrentExp / RequiredExp * 100;
}
