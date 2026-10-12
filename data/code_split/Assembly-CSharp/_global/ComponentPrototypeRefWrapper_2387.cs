// Namespace: 
[Serializable]
public class ComponentPrototypeRefWrapper : ComponentPrototypeRefWrapperBase // TypeDefIndex: 2387
{
	// Fields
	[LocalReference]
	[SerializeField]
	private EntityComponentBase _scenePrototype; // 0x18
	[SerializeField]
	private string _componentTypeName; // 0x20

	// Properties
	public override string ComponentTypeName { get; }
	public override EntityComponentBase ScenePrototype { get; }

	// Methods

	// RVA: 0x504300 Offset: 0x502900 VA: 0x180504300 Slot: 4
	public override string get_ComponentTypeName() { }

	// RVA: 0x4FA3A0 Offset: 0x4F89A0 VA: 0x1804FA3A0 Slot: 5
	public override EntityComponentBase get_ScenePrototype() { }

	// RVA: 0x4FA6F0 Offset: 0x4F8CF0 VA: 0x1804FA6F0
	public void .ctor() { }
}
