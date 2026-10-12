// Namespace: 
public struct HitBoxVisualInstance // TypeDefIndex: 3354
{
	// Fields
	private const float identifiersFontSize = 1;
	public string ID; // 0x0
	public HitBoxType HitBoxType; // 0x8
	public HitBoxPriority Priority; // 0xC
	public Vector3 CurrentPosition; // 0x10
	public Vector3 PreviousPosition; // 0x1C
	public float Radius; // 0x28

	// Methods

	// RVA: 0x5BB1C0 Offset: 0x5B97C0 VA: 0x1805BB1C0
	public void .ctor(HitBoxType hitBoxType, HitBoxPriority hitBoxPriority, Vector3 currentPosition, Vector3 previousPosition, float radius) { }

	// RVA: 0x5BB150 Offset: 0x5B9750 VA: 0x1805BB150
	public void .ctor(string id, HitBoxType hitBoxType, HitBoxPriority hitBoxPriority, Vector3 currentPosition, Vector3 previousPosition, float radius) { }

	// RVA: 0x5BAE30 Offset: 0x5B9430 VA: 0x1805BAE30
	public void DrawInterpolation(StellarCollisionsVisualizerData visualizerData) { }

	// RVA: 0x5BAB70 Offset: 0x5B9170 VA: 0x1805BAB70
	public void DrawEndpoint(StellarCollisionsVisualizerData visualizerData) { }

	// RVA: 0x5BACE0 Offset: 0x5B92E0 VA: 0x1805BACE0
	public void DrawIdentifier(StellarCollisionsVisualizerData visualizerData, TextElement textElement) { }

	// RVA: 0x5BB070 Offset: 0x5B9670 VA: 0x1805BB070
	private Color UseColor(StellarCollisionsVisualizerData visualizerData) { }
}
