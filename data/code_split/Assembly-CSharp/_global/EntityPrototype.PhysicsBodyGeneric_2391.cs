// Namespace: 
[Serializable]
public struct EntityPrototype.PhysicsBodyGeneric // TypeDefIndex: 2391
{
	// Fields
	[HideInInspector]
	public bool IsEnabled; // 0x0
	[HideInInspector]
	public int Version2D; // 0x4
	[HideInInspector]
	public int Version3D; // 0x8
	[EnumFlags]
	[DisplayName("Config")]
	public PhysicsBody2D.ConfigFlags Config2D; // 0xC
	[EnumFlags]
	[DisplayName("Config")]
	public PhysicsBody3D.ConfigFlags Config3D; // 0xD
	[EnumFlags]
	public RotationFreezeFlags RotationFreeze; // 0xE
	public FP Mass; // 0x10
	public FP Drag; // 0x18
	public FP AngularDrag; // 0x20
	[DisplayName("Center Of Mass")]
	public FPVector2 CenterOfMass2D; // 0x28
	[DisplayName("Center Of Mass")]
	public FPVector3 CenterOfMass3D; // 0x38
	public NullableFP GravityScale; // 0x50

	// Properties
	[Obsolete("Use Version2D or Version3D instead.")]
	public int Version { get; set; }

	// Methods

	// RVA: 0x526D40 Offset: 0x525340 VA: 0x180526D40
	public int get_Version() { }

	// RVA: 0x526D50 Offset: 0x525350 VA: 0x180526D50
	public void set_Version(int value) { }

	// RVA: 0x526CC0 Offset: 0x5252C0 VA: 0x180526CC0
	public void EnsureVersionUpdated() { }
}
