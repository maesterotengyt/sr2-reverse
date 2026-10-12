// Namespace: 
public abstract class ComponentPrototypeRefWrapperBase // TypeDefIndex: 2385
{
	// Fields
	public AssetRefEntityPrototype AssetPrototype; // 0x10

	// Properties
	public abstract string ComponentTypeName { get; }
	public abstract EntityComponentBase ScenePrototype { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract string get_ComponentTypeName();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract EntityComponentBase get_ScenePrototype();

	// RVA: 0x4FA6F0 Offset: 0x4F8CF0 VA: 0x1804FA6F0
	protected void .ctor() { }
}
