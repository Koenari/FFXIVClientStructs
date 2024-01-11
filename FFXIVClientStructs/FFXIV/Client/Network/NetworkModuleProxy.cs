using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FFXIVClientStructs.FFXIV.Common.Configuration;

namespace FFXIVClientStructs.FFXIV.Client.Network;

[StructLayout(LayoutKind.Explicit, Size = 0x20)]
public unsafe partial struct NetworkModuleProxy {
    [FieldOffset(0x00)] public void* Vtbl;
    [FieldOffset(0x08)] public NetworkModule* NetworkModule;
    [FieldOffset(0x10)] public NetworkModulePacketReceiverCallback PacketReceiverCallback;

    [MemberFunction("E8 ?? ?? ?? ?? 48 8B 9C 24 ?? ?? ?? ?? 0F B6 C8")]
    public partial void RequestCharacterData(byte idx, long contentId, long p4, long p5);

    [MemberFunction("E8 ?? ?? ?? ?? EB ?? 49 8B 85")]
    public partial bool IsInCrossWorlDuty();

    /// <summary>
    /// Gets current instance<br/>
    /// Does NOT invoke network request
    /// </summary>
    /// <returns>Current instance or 0 for non instanced zones</returns>
    [MemberFunction("E8 ?? ?? ?? ?? 48 8D 0D ?? ?? ?? ?? 0F B7 F0 E8 ?? ?? ?? ?? 8B D8")]
    public partial short GetCurrentInstance();
}
