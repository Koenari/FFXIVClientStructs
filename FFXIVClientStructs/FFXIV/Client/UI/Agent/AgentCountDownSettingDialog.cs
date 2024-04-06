using FFXIVClientStructs.FFXIV.Component.GUI;

namespace FFXIVClientStructs.FFXIV.Client.UI.Agent;

[Agent(AgentId.CountDownSettingDialog)]
[StructLayout(LayoutKind.Explicit, Size = 0x48)]
public partial struct AgentCountDownSettingDialog {
    [FieldOffset(0x00)] public AgentInterface AgentInterface;
    [FieldOffset(0x28)] public float TimeRemaining;
    [FieldOffset(0x2C)] public float TimeRemainingLastFrame;
    
    
    [FieldOffset(0x38)] public bool CountDownActive;
}
