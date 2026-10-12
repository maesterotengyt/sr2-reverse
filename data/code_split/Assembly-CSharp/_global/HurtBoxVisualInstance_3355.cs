// Namespace: 
public struct HurtBoxVisualInstance // TypeDefIndex: 3355
{
	// Fields
	private const float identifiersFontSize = 1;
	public string ID; // 0x0
	public Vector3 PointA; // 0x8
	public Vector3 PointB; // 0x14
	public float Radius; // 0x20
	public bool IsIntangible; // 0x24
	public bool IsInvincible; // 0x25

	// Methods

	// RVA: 0x5BB550 Offset: 0x5B9B50 VA: 0x1805BB550
	public void .ctor(Vector3 pointA, Vector3 pointB, float radius, bool isIntangible, bool isInvincible) { }

	// RVA: 0x5BB5F0 Offset: 0x5B9BF0 VA: 0x1805BB5F0
	public void .ctor(string id, Vector3 pointA, Vector3 pointB, float radius, bool isIntangible, bool isInvincible) { }

	// RVA: 0x5BB250 Offset: 0x5B9850 VA: 0x1805BB250
	public void DrawHurtbox(StellarCollisionsVisualizerData visualizerData) { }

	// RVA: 0x5BB370 Offset: 0x5B9970 VA: 0x1805BB370
	internal void DrawIdentifier(StellarCollisionsVisualizerData visualizerData, TextElement textElement) { }

	// RVA: 0x5BB4F0 Offset: 0x5B9AF0 VA: 0x1805BB4F0
	private Color UseColor(StellarCollisionsVisualizerData visualizerData) { }
}
