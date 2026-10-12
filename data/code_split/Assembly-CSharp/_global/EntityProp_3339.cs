// Namespace: 
[Serializable]
public class EntityProp // TypeDefIndex: 3339
{
	// Fields
	public HashString ID; // 0x10
	public GameObject ObjectRef; // 0x20
	public GameObject MirrorObjectRef; // 0x28

	// Methods

	// RVA: 0x5B3D70 Offset: 0x5B2370 VA: 0x1805B3D70
	public void .ctor(string identifier, GameObject objectRef, GameObject mirrorObjectRef) { }

	// RVA: 0x5B38D0 Offset: 0x5B1ED0 VA: 0x1805B38D0
	public void UpdateTransform(Transform slotTransform, int facingDirection) { }

	// RVA: 0x5B3C30 Offset: 0x5B2230 VA: 0x1805B3C30
	public void UpdateVisibility(bool visible, int facingDirection) { }
}
