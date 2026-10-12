// Namespace: 
internal class DrawObjectsPass : ScriptableRenderPass // TypeDefIndex: 2565
{
	// Fields
	private FilteringSettings m_FilteringSettings; // 0xB8
	private RenderStateBlock m_RenderStateBlock; // 0xD8
	private List<ShaderTagId> m_ShaderTagIdList; // 0x148
	private string m_ProfilerTag; // 0x150
	private bool m_IsOpaque; // 0x158

	// Methods

	// RVA: 0x6F4580 Offset: 0x6F2B80 VA: 0x1806F4580
	public void .ctor(string profilerTag, ShaderTagId shaderTag, bool isOpaque, RenderPassEvent evt, RenderQueueRange renderQueueRange, LayerMask layerMask, StencilStateData stencilState, int stencilReference) { }

	// RVA: 0x6F44D0 Offset: 0x6F2AD0 VA: 0x1806F44D0 Slot: 6
	public override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData) { }

	// RVA: 0x6F41C0 Offset: 0x6F27C0 VA: 0x1806F41C0 Slot: 10
	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }
}
