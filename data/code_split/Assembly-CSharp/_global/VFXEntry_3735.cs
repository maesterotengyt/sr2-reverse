// Namespace: 
[Serializable]
public struct VFXEntry // TypeDefIndex: 3735
{
	// Fields
	[ReadOnlyField]
	public HashString ID; // 0x0
	[ReadOnlyField]
	public VFXPool VFXPool; // 0x10
	[ReadOnlyField]
	public VFXObject VFXObject; // 0x18

	// Methods

	// RVA: 0x6542E0 Offset: 0x6528E0 VA: 0x1806542E0
	public void Play(EntityRef Entity, VFXPlayAttributes playAttributes) { }

	// RVA: 0x6544F0 Offset: 0x652AF0 VA: 0x1806544F0
	public void Stop(int entityIndex, VFXStopAttributes stopAttributes) { }
}
