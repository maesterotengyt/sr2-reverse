// Namespace: Quantum
public struct ComponentCallbacks // TypeDefIndex: 11527
{
	// Fields
	public ComponentSerializeDelegate Serialize; // 0x0
	public ComponentChangedDelegate OnAdded; // 0x8
	public ComponentChangedDelegate OnRemoved; // 0x10

	// Methods

	// RVA: 0x21C6190 Offset: 0x21C4790 VA: 0x1821C6190
	public void .ctor(ComponentSerializeDelegate serialize) { }

	// RVA: 0x891290 Offset: 0x88F890 VA: 0x180891290
	public void .ctor(ComponentSerializeDelegate serialize, ComponentChangedDelegate onAdded, ComponentChangedDelegate onRemoved) { }
}
