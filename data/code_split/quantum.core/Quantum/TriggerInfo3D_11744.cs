// Namespace: Quantum
public struct TriggerInfo3D // TypeDefIndex: 11744
{
	// Fields
	private Map _map; // 0x0
	private bool _isStatic; // 0x8
	private bool _isInverse; // 0x9
	private ManifoldData3D* _manifold; // 0x10
	private Entry3D* _entryA; // 0x18
	private Entry3D* _entryB; // 0x20

	// Methods

	// RVA: 0x2220B30 Offset: 0x221F130 VA: 0x182220B30
	internal void .ctor(ManifoldData3D* manifold, Entry3D* entryA, Entry3D* entryB, Map map, bool isStatic, bool isInverse) { }
}
