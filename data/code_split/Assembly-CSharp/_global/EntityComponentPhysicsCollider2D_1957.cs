// Namespace: 
[DisallowMultipleComponent]
public class EntityComponentPhysicsCollider2D : EntityComponentBase<PhysicsCollider2D_Prototype> // TypeDefIndex: 1957
{
	// Fields
	[MultiTypeReference(new[] { typeof(BoxCollider2D), typeof(CircleCollider2D) })]
	public Component SourceCollider; // 0x28

	// Methods

	// RVA: 0x50EC20 Offset: 0x50D220 VA: 0x18050EC20
	private void OnValidate() { }

	// RVA: 0x50EC20 Offset: 0x50D220 VA: 0x18050EC20 Slot: 5
	public override void Refresh() { }

	// RVA: 0x50ECB0 Offset: 0x50D2B0 VA: 0x18050ECB0
	public void .ctor() { }
}
