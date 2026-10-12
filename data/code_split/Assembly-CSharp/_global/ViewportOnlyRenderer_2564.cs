// Namespace: 
public class ViewportOnlyRenderer : ScriptableRenderer // TypeDefIndex: 2564
{
	// Fields
	private ViewportOnlyRendererData m_Data; // 0x148
	private DrawObjectsPass m_RenderOpaqueForwardPass; // 0x150
	private DrawObjectsPass m_RenderTransparentForwardPass; // 0x158

	// Methods

	// RVA: 0x70C360 Offset: 0x70A960 VA: 0x18070C360
	public void .ctor(ViewportOnlyRendererData data) { }

	// RVA: 0x70C2D0 Offset: 0x70A8D0 VA: 0x18070C2D0 Slot: 13
	public override void Setup(ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x70C1F0 Offset: 0x70A7F0 VA: 0x18070C1F0 Slot: 15
	public override void SetupCullingParameters(ref ScriptableCullingParameters cullingParameters, ref CameraData cameraData) { }
}
