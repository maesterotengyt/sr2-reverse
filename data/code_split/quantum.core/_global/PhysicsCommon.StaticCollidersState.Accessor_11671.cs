// Namespace: 
[IsReadOnly]
public struct PhysicsCommon.StaticCollidersState.Accessor // TypeDefIndex: 11671
{
	// Fields
	private readonly ulong* _buffer; // 0x0
	private readonly int _collidersCount; // 0x8

	// Methods

	// RVA: 0xE03C30 Offset: 0xE02230 VA: 0x180E03C30
	internal void .ctor(ulong* buffer, int collidersCount) { }

	// RVA: 0x21E9EE0 Offset: 0x21E84E0 VA: 0x1821E9EE0
	public bool IsStaticColliderEnabled(int staticColliderIndex) { }

	// RVA: 0x21E9FC0 Offset: 0x21E85C0 VA: 0x1821E9FC0
	public void SetStaticColliderEnabled(int staticColliderIndex, bool enabled) { }

	// RVA: 0x22164E0 Offset: 0x2214AE0 VA: 0x1822164E0
	internal static bool IsStaticColliderEnabledUnchecked(ulong* buffer, int staticColliderIndex) { }

	// RVA: 0x2216510 Offset: 0x2214B10 VA: 0x182216510
	internal static void SetStaticColliderEnabledUnchecked(ulong* buffer, int staticColliderIndex, bool enabled) { }
}
