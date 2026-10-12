// Namespace: Quantum
[Serializable]
public class CharacterController3DConfig : AssetObject, IBuiltInAssetObject // TypeDefIndex: 11474
{
	// Fields
	public const long DEFAULT_ID = 4;
	public FPVector3 Offset; // 0x20
	public FP Radius; // 0x38
	public FP MaxPenetration; // 0x40
	public FP PenetrationCorrection; // 0x48
	public FP Extent; // 0x50
	public int MaxContacts; // 0x58
	public LayerMask LayerMask; // 0x5C
	public bool UseManifoldNormal; // 0x60
	public bool AirControl; // 0x61
	public FP Acceleration; // 0x68
	public FP Braking; // 0x70
	public FP BaseJumpImpulse; // 0x78
	public FP MaxSpeed; // 0x80
	public FPVector3 Gravity; // 0x88
	public FP MaxSlope; // 0xA0
	public FP MaxSlopeSpeed; // 0xA8
	[CompilerGenerated]
	private FP <GravityStrength>k__BackingField; // 0xB0
	[CompilerGenerated]
	private FPVector3 <GravityNormalized>k__BackingField; // 0xB8

	// Properties
	public FP GravityStrength { get; set; }
	public FPVector3 GravityNormalized { get; set; }

	// Methods

	// RVA: 0x21C5D70 Offset: 0x21C4370 VA: 0x1821C5D70 Slot: 6
	private void Quantum.IBuiltInAssetObject.Dispatch(IAssetObjectVisitor visitor) { }

	[CompilerGenerated]
	// RVA: 0x7A80B0 Offset: 0x7A66B0 VA: 0x1807A80B0
	public FP get_GravityStrength() { }

	[CompilerGenerated]
	// RVA: 0x21C5F60 Offset: 0x21C4560 VA: 0x1821C5F60
	private void set_GravityStrength(FP value) { }

	[CompilerGenerated]
	// RVA: 0x16760C0 Offset: 0x16746C0 VA: 0x1816760C0
	public FPVector3 get_GravityNormalized() { }

	[CompilerGenerated]
	// RVA: 0x21C5F40 Offset: 0x21C4540 VA: 0x1821C5F40
	private void set_GravityNormalized(FPVector3 value) { }

	// RVA: 0x21C5CD0 Offset: 0x21C42D0 VA: 0x1821C5CD0 Slot: 4
	public override void Loaded(IResourceManager assets, Native.Allocator allocator) { }

	// RVA: 0x21C5E30 Offset: 0x21C4430 VA: 0x1821C5E30
	public void .ctor() { }
}
