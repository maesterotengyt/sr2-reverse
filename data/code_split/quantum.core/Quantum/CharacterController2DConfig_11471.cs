// Namespace: Quantum
[Serializable]
public class CharacterController2DConfig : AssetObject, IBuiltInAssetObject // TypeDefIndex: 11471
{
	// Fields
	public const long DEFAULT_ID = 3;
	public FPVector2 Offset; // 0x20
	public FP Radius; // 0x30
	public FP MaxPenetration; // 0x38
	public FP PenetrationCorrection; // 0x40
	public FP Extent; // 0x48
	public int MaxContacts; // 0x50
	public LayerMask LayerMask; // 0x54
	public bool UseManifoldNormal; // 0x58
	public bool AirControl; // 0x59
	public FP Acceleration; // 0x60
	public FP Braking; // 0x68
	public FP BaseJumpImpulse; // 0x70
	public FP MaxSpeed; // 0x78
	public FPVector2 Gravity; // 0x80
	public FP MaxSlope; // 0x90
	public FP MaxSlopeSpeed; // 0x98
	[CompilerGenerated]
	private FP <GravityStrength>k__BackingField; // 0xA0
	[CompilerGenerated]
	private FPVector2 <GravityNormalized>k__BackingField; // 0xA8

	// Properties
	private FP GravityStrength { set; }
	private FPVector2 GravityNormalized { set; }

	// Methods

	// RVA: 0x21C5B40 Offset: 0x21C4140 VA: 0x1821C5B40 Slot: 6
	private void Quantum.IBuiltInAssetObject.Dispatch(IAssetObjectVisitor visitor) { }

	[CompilerGenerated]
	// RVA: 0x20165B0 Offset: 0x2014BB0 VA: 0x1820165B0
	private void set_GravityStrength(FP value) { }

	[CompilerGenerated]
	// RVA: 0x21C5CC0 Offset: 0x21C42C0 VA: 0x1821C5CC0
	private void set_GravityNormalized(FPVector2 value) { }

	// RVA: 0x21C5AD0 Offset: 0x21C40D0 VA: 0x1821C5AD0 Slot: 4
	public override void Loaded(IResourceManager assets, Native.Allocator allocator) { }

	// RVA: 0x21C5C00 Offset: 0x21C4200 VA: 0x1821C5C00
	public void .ctor() { }
}
