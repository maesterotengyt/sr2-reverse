// Namespace: 
public class ShapesCollisionVisualizer : ImmediateModeShapeDrawer, IStellarCollisionsVisualizer // TypeDefIndex: 3659
{
	// Fields
	public bool HurtBoxesVisible; // 0x28
	public bool HitboxesVisible; // 0x29
	public bool EnvironmentCollisionBoxesVisible; // 0x2A
	[HideInInspector]
	public bool DrawIdentifiers; // 0x2B
	public StellarCollisionsVisualizerData VisualizerData; // 0x30
	private List<HurtBoxVisualInstance> hurtBoxVisuals; // 0x38
	private List<TextElement> hurtBoxesTextElements; // 0x40
	private List<HitBoxVisualInstance> hitBoxVisuals; // 0x48
	private List<TextElement> hitBoxesTextElements; // 0x50
	private List<ECBVisualInstance> ecbVisuals; // 0x58

	// Methods

	// RVA: 0x618EB0 Offset: 0x6174B0 VA: 0x180618EB0
	private void Awake() { }

	// RVA: 0x619890 Offset: 0x617E90 VA: 0x180619890
	private void OnUpdateView(CallbackUpdateView callback) { }

	// RVA: 0x619150 Offset: 0x617750 VA: 0x180619150 Slot: 4
	public override void DrawShapes(Camera cam) { }

	// RVA: 0x619840 Offset: 0x617E40 VA: 0x180619840 Slot: 7
	public void Initialize(StellarCollisionsVisualizerData visualizerData) { }

	// RVA: 0x618F70 Offset: 0x617570 VA: 0x180618F70 Slot: 8
	public void Clear() { }

	// RVA: 0x61A490 Offset: 0x618A90 VA: 0x18061A490 Slot: 9
	public void SaveHitBoxVisualInstance(HitBoxVisualInstance hitBoxVisualsData) { }

	// RVA: 0x61A5B0 Offset: 0x618BB0 VA: 0x18061A5B0 Slot: 10
	public void SaveHurtBoxVisualInstance(HurtBoxVisualInstance hurtBoxVisualsData) { }

	// RVA: 0x61A410 Offset: 0x618A10 VA: 0x18061A410 Slot: 11
	public void SaveECBVisualInstance(ECBVisualInstance ecbVisualsData) { }

	// RVA: 0x619820 Offset: 0x617E20 VA: 0x180619820 Slot: 12
	public bool GetECBsVisible() { }

	// RVA: 0x61A6D0 Offset: 0x618CD0 VA: 0x18061A6D0 Slot: 13
	public void SetECBsVisible(bool value) { }

	// RVA: 0x5BA5A0 Offset: 0x5B8BA0 VA: 0x1805BA5A0 Slot: 14
	public bool GetHurtBoxesVisible() { }

	// RVA: 0x5BA5B0 Offset: 0x5B8BB0 VA: 0x1805BA5B0 Slot: 15
	public void SetHurtBoxesVisible(bool value) { }

	// RVA: 0x619830 Offset: 0x617E30 VA: 0x180619830 Slot: 16
	public bool GetHitBoxesVisible() { }

	// RVA: 0x61A6E0 Offset: 0x618CE0 VA: 0x18061A6E0 Slot: 17
	public void SetHitBoxesVisible(bool value) { }

	// RVA: 0x61A6F0 Offset: 0x618CF0 VA: 0x18061A6F0
	public void .ctor() { }
}
