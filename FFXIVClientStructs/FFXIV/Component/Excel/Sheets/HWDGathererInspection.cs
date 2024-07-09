// <auto-generated/>
namespace FFXIVClientStructs.FFXIV.Component.Excel.Sheets;

[GenerateInterop]
[StructLayout(LayoutKind.Explicit, Size = 0x62C)]
public unsafe partial struct HWDGathererInspection {
    [FieldOffset(0x00), FixedSizeArray] internal FixedSizeArray79<HWDGathererInspectionDataStruct> _hWDGathererInspectionData;

    [GenerateInterop]
    [StructLayout(LayoutKind.Explicit, Size = 0x14)]
    public partial struct HWDGathererInspectionDataStruct {
        /// <remarks>GatheringItem</remarks>
        [FieldOffset(0x00)] public uint RequiredItem;
        /// <remarks>FishParameter</remarks>
        [FieldOffset(0x04)] public uint FishParameter;
        /// <remarks>Item</remarks>
        [FieldOffset(0x08)] public uint ItemReceived;
        [FieldOffset(0x0C), FixedSizeArray] internal FixedSizeArray2<ushort> _reward;
        [FieldOffset(0x10)] public byte AmountRequired;
        /// <remarks>HWDGathereInspectTerm</remarks>
        [FieldOffset(0x11)] public byte Phase;
    }
}