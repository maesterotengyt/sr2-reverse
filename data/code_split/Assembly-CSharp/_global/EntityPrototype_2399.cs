// Namespace: 
public class EntityPrototype : MonoBehaviour, IQuantumPrefabNestedAssetHost // TypeDefIndex: 2399
{
	// Fields
	public EntityPrototypeTransformMode TransformMode; // 0x20
	[Optional("Transform2DVertical.IsEnabled")]
	[DrawIf("TransformMode", 0, 0, 3)]
	public EntityPrototype.Transform2DVerticalInfo Transform2DVertical; // 0x28
	[Optional("PhysicsCollider.IsEnabled")]
	[DrawIf("TransformMode", 2, 1, 3)]
	public EntityPrototype.PhysicsColliderGeneric PhysicsCollider; // 0x40
	[Optional("PhysicsBody.IsEnabled")]
	[DrawIf("PhysicsCollider.IsTrigger", 0, 0, 2)]
	[DrawIf("PhysicsCollider.IsEnabled", 1, 0, 2)]
	[DrawIf("TransformMode", 2, 1, 3)]
	[Tooltip("To enable make sure PhysicsCollider is enabled and not a trigger")]
	public EntityPrototype.PhysicsBodyGeneric PhysicsBody; // 0x78
	[Optional("NavMeshPathfinder.IsEnabled")]
	[DrawIf("TransformMode", 2, 1, 3)]
	public EntityPrototype.NavMeshPathfinderInfo NavMeshPathfinder; // 0xD8
	[Optional("NavMeshSteeringAgent.IsEnabled")]
	[DrawIf("NavMeshPathfinder.IsEnabled", 1, 0, 2)]
	[DrawIf("TransformMode", 2, 1, 3)]
	public EntityPrototype.NavMeshSteeringAgentInfo NavMeshSteeringAgent; // 0x128
	[Optional("NavMeshAvoidanceAgent.IsEnabled")]
	[DrawIf("NavMeshPathfinder.IsEnabled", 1, 0, 2)]
	[DrawIf("NavMeshSteeringAgent.IsEnabled", 1, 0, 2)]
	[DrawIf("TransformMode", 2, 1, 3)]
	public EntityPrototype.NavMeshAvoidanceAgentInfo NavMeshAvoidanceAgent; // 0x150
	public AssetRefEntityView View; // 0x158

	// Properties
	private Type IQuantumPrefabNestedAssetHost.NestedAssetType { get; }
	private Type IQuantumPrefabNestedAssetHost.SplitAssetType { get; }

	// Methods

	// RVA: 0x51ED80 Offset: 0x51D380 VA: 0x18051ED80 Slot: 4
	private Type IQuantumPrefabNestedAssetHost.get_NestedAssetType() { }

	// RVA: 0x51EDD0 Offset: 0x51D3D0 VA: 0x18051EDD0 Slot: 5
	private Type IQuantumPrefabNestedAssetHost.get_SplitAssetType() { }

	// RVA: 0x51EE20 Offset: 0x51D420 VA: 0x18051EE20
	public void PreSerialize() { }

	// RVA: 0x51F0D0 Offset: 0x51D6D0 VA: 0x18051F0D0
	public void SerializeImplicitComponents(ComponentPrototypeVisitor visitor, out EntityView selfView) { }

	[Conditional("UNITY_EDITOR")]
	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940
	public void CheckComponentDuplicates(Action<string> duplicateCallback) { }

	[Conditional("UNITY_EDITOR")]
	// RVA: 0x51E9D0 Offset: 0x51CFD0 VA: 0x18051E9D0
	public void CheckComponentDuplicates(Action<Type, List<Component>> duplicateCallback) { }

	// RVA: 0x51F920 Offset: 0x51DF20 VA: 0x18051F920
	public void .ctor() { }
}
