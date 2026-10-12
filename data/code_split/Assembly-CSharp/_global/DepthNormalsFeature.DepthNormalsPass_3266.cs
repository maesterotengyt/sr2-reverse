// Namespace: 
private class DepthNormalsFeature.DepthNormalsPass : ScriptableRenderPass // TypeDefIndex: 3266
{
	// Fields
	private int kDepthBufferBits; // 0xB8
	private RTHandle depthAttachmentHandle2; // 0xC0
	[CompilerGenerated]
	private RenderTextureDescriptor <descriptor>k__BackingField; // 0xC8
	private Material depthNormalsMaterial; // 0x100
	private FilteringSettings m_FilteringSettings; // 0x108
	private string m_ProfilerTag; // 0x128
	private ShaderTagId m_ShaderTagId; // 0x130

	// Properties
	internal RenderTextureDescriptor descriptor { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x598520 Offset: 0x596B20 VA: 0x180598520
	internal RenderTextureDescriptor get_descriptor() { }

	[CompilerGenerated]
	// RVA: 0x598550 Offset: 0x596B50 VA: 0x180598550
	private void set_descriptor(RenderTextureDescriptor value) { }

	// RVA: 0x5983A0 Offset: 0x5969A0 VA: 0x1805983A0
	public void .ctor(RenderQueueRange renderQueueRange, LayerMask layerMask, Material material) { }

	// RVA: 0x598320 Offset: 0x596920 VA: 0x180598320
	public void Setup(RenderTextureDescriptor baseDescriptor, RTHandle depthAttachmentHandle) { }

	// RVA: 0x597D70 Offset: 0x596370 VA: 0x180597D70 Slot: 7
	public override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor) { }

	// RVA: 0x597E80 Offset: 0x596480 VA: 0x180597E80 Slot: 10
	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x5982A0 Offset: 0x5968A0 VA: 0x1805982A0 Slot: 5
	public override void FrameCleanup(CommandBuffer cmd) { }
}
