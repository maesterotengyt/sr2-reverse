// Namespace: 
private class EntityPrototype.CheckComponentDuplicatesVisitor : ComponentPrototypeVisitor // TypeDefIndex: 2398
{
	// Fields
	public EntityPrototype Source; // 0x10
	public Dictionary<Type, List<Component>> TypeToSources; // 0x18

	// Methods

	// RVA: 0x51D030 Offset: 0x51B630 VA: 0x18051D030 Slot: 22
	protected override void VisitFallback(ComponentPrototype prototype) { }

	// RVA: 0x51CCF0 Offset: 0x51B2F0 VA: 0x18051CCF0
	public void .ctor() { }
}
