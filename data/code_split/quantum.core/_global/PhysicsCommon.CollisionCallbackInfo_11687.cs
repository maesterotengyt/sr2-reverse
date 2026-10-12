// Namespace: 
internal struct PhysicsCommon.CollisionCallbackInfo // TypeDefIndex: 11687
{
	// Fields
	private PhysicsCommon.CollisionCallbackInfo.Flags _flags; // 0x0
	public int StaticColliderIndex; // 0x4
	[FieldOverlap(8)]
	public AssetGuid MapGuid; // 0x8
	[FieldOverlap(8)]
	public EntityRef Entity; // 0x8

	// Properties
	public bool IsActive { get; set; }
	public bool IsStatic { get; set; }
	public bool IsStaticTrigger { get; set; }

	// Methods

	// RVA: 0x21C6E00 Offset: 0x21C5400 VA: 0x1821C6E00
	public bool get_IsActive() { }

	// RVA: 0x2207790 Offset: 0x2205D90 VA: 0x182207790
	public void set_IsActive(bool value) { }

	// RVA: 0x2207760 Offset: 0x2205D60 VA: 0x182207760
	public bool get_IsStatic() { }

	// RVA: 0x22119C0 Offset: 0x220FFC0 VA: 0x1822119C0
	public void set_IsStatic(bool value) { }

	// RVA: 0x221A3C0 Offset: 0x22189C0 VA: 0x18221A3C0
	public bool get_IsStaticTrigger() { }

	// RVA: 0x221A3D0 Offset: 0x22189D0 VA: 0x18221A3D0
	public void set_IsStaticTrigger(bool value) { }

	// RVA: 0x221A310 Offset: 0x2218910 VA: 0x18221A310
	public static void Serialize(void* ptr, FrameSerializer serializer) { }
}
