using FFXIVClientStructs.FFXIV.Component.GUI;

namespace FFXIVClientStructs.FFXIV.Client.UI.Agent;

//  Client::UI::Agent::AgentCountDownSettingDialog
// ctor "48 8D 05 ?? ?? ?? ?? 48 89 51 ?? 33 D2 48 89 01 48 89 51 ?? 48 8B C1 89 51 ?? 66 89 51 ?? 48 89 51 ?? 48 89 51 ?? 66 89 51" 
[Agent(AgentId.CountDownSettingDialog)]
[StructLayout(LayoutKind.Explicit, Size = 0x48)]
public partial struct AgentCountDownSettingDialog {
    [FieldOffset(0x00)] public AgentInterface AgentInterface;
    [FieldOffset(0x28)] public float TimeRemaining;
    [FieldOffset(0x2C)] public float TimeRemainingLastFrame;
    [FieldOffset(0x30)] public uint Unk30;
    [FieldOffset(0x34)] public uint Unk34;
    [FieldOffset(0x38)] public bool CountDownActive;
    [FieldOffset(0x3C)] public uint InitiatorObjectId;
}
