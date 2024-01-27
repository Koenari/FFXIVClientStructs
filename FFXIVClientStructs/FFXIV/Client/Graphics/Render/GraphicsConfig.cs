namespace FFXIVClientStructs.FFXIV.Client.Graphics.Render;

[StructLayout(LayoutKind.Explicit, Size = 0x40)]
public struct GraphicsConfig {
    [FieldOffset(0x08)] public uint LoadFlags;
    [FieldOffset(0x0C)] public byte Gamma; //LoadFlag 0x200
    [FieldOffset(0x10)] public bool UseLod; //LoadFlga 0x1
    [FieldOffset(0x11)] public bool Unk11; //LoadFlag 0x1
    [FieldOffset(0x12)] public bool UseShadowLod; //LoadFlag 0x80
    [FieldOffset(0x13)] public bool OcclusionCulling; //LoadFlag 0x100
    [FieldOffset(0x14)] public bool WaterWet;

    [FieldOffset(0x16)] public bool ParallaxOcclusion;
    [FieldOffset(0x17)] public bool Tessellation; //LoadFlag 0x400
    [FieldOffset(0x1C)] public byte ReflectionType; //LoadFlag 0x400
    [FieldOffset(0x1D)] public byte GlareRepresentation; //LoadFlag 0x400
    [FieldOffset(0x1E)] public byte GrassQuality; //LoadFlag 0x10
    [FieldOffset(0x1F)] public byte SSAO; //LoadFlag 0x2
    [FieldOffset(0x20)] public byte Glare; //LoadFlag 0x2
    [FieldOffset(0x21)] public bool GlareActive; //LoadFlag 0x2
    [FieldOffset(0x22)] public bool DoF; //LoadFlag 0x2
    //23 is unused/old
    [FieldOffset(0x24)] public bool RadialBlur; //LoadFlag 0x2
    [FieldOffset(0x25)] public bool Vignetting; //LoadFlag 0x2
    [FieldOffset(0x26)] public byte AntiAliasing; //LoadFlag 0xA
    [FieldOffset(0x27)] public byte TextureFilterQuality; //LoadFlag 0x4
    [FieldOffset(0x28)] public byte TextureAnisotropicQuality; //LoadFlag 0x4
    [FieldOffset(0x29)] public ushort Unk29; //LoadFlag 0x8
    [FieldOffset(0x2A)] public byte TranslucentQuality; //LoadFlag 0x8
    [FieldOffset(0x2B)] public byte ShadowVisibiltyFlags; //LoadFlag 0x20

}
