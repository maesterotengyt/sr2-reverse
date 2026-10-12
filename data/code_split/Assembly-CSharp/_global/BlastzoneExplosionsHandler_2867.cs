// Namespace: 
public class BlastzoneExplosionsHandler : SRMonoBehaviour // TypeDefIndex: 2867
{
	// Fields
	public List<VFXObject> KnockoutVFXList; // 0x20
	public ScreenExplosionVFX ScreenExplosion; // 0x28
	public Transform TopLeft; // 0x30
	public Transform BottomRight; // 0x38
	public Vector2 SingleExplosionOffsetRatio; // 0x40
	private int knockoutVFXIndex; // 0x48
	private float width; // 0x4C
	private float height; // 0x50

	// Methods

	// RVA: 0x741840 Offset: 0x73FE40 VA: 0x180741840
	private void Awake() { }

	// RVA: 0x741920 Offset: 0x73FF20 VA: 0x180741920
	public Vector2 FromRatioToLocalPosition(Vector2 positionRatio) { }

	// RVA: 0x741A20 Offset: 0x740020 VA: 0x180741A20
	public void StartSingleExplosion(Vector2 localPosition) { }

	// RVA: 0x7419B0 Offset: 0x73FFB0 VA: 0x1807419B0
	private VFXObject GetNextKnockoutVFX() { }

	// RVA: 0x53A8F0 Offset: 0x538EF0 VA: 0x18053A8F0
	public void .ctor() { }
}
