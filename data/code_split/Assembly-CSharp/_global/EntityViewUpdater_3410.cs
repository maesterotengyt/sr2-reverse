// Namespace: 
public class EntityViewUpdater : MonoBehaviour // TypeDefIndex: 3410
{
	// Fields
	[Tooltip("Optionally provide a transform that all entity views will be parented under.")]
	public Transform ViewParentTransform; // 0x20
	[Tooltip("Disable you don't intend to use MapData component.")]
	public bool AutoFindMapData; // 0x28
	private MapData _mapData; // 0x30
	private HashSet<EntityRef> _removeEntities; // 0x38
	private HashSet<EntityRef> _activeEntities; // 0x40
	private Dictionary<EntityRef, EntityView> _activeViews; // 0x48
	private bool _teleport; // 0x50
	private QuantumGame _observedGame; // 0x58

	// Properties
	protected MapData MapData { get; }
	protected HashSet<EntityRef> ActiveEntities { get; }
	protected HashSet<EntityRef> RemoveEntities { get; }
	protected Dictionary<EntityRef, EntityView> ActiveViews { get; }
	protected bool Teleport { get; }
	public QuantumGame ObservedGame { get; }

	// Methods

	// RVA: 0x503090 Offset: 0x501690 VA: 0x180503090
	protected MapData get_MapData() { }

	// RVA: 0x5C5B30 Offset: 0x5C4130 VA: 0x1805C5B30
	protected HashSet<EntityRef> get_ActiveEntities() { }

	// RVA: 0x5C5B40 Offset: 0x5C4140 VA: 0x1805C5B40
	protected HashSet<EntityRef> get_RemoveEntities() { }

	// RVA: 0x5C9FA0 Offset: 0x5C85A0 VA: 0x1805C9FA0
	protected Dictionary<EntityRef, EntityView> get_ActiveViews() { }

	// RVA: 0x5C9FB0 Offset: 0x5C85B0 VA: 0x1805C9FB0
	protected bool get_Teleport() { }

	// RVA: 0x5B45B0 Offset: 0x5B2BB0 VA: 0x1805B45B0
	public QuantumGame get_ObservedGame() { }

	[Obsolete("Use GetView instead")]
	// RVA: 0x5C86B0 Offset: 0x5C6CB0 VA: 0x1805C86B0
	public EntityView GetPrefab(EntityRef entityRef) { }

	// RVA: 0x5C86B0 Offset: 0x5C6CB0 VA: 0x1805C86B0
	public EntityView GetView(EntityRef entityRef) { }

	[Obsolete("Use TeleportAllEntities() instead")]
	// RVA: 0x5C9700 Offset: 0x5C7D00 VA: 0x1805C9700
	public void SetTeleportOnce() { }

	// RVA: 0x5C9700 Offset: 0x5C7D00 VA: 0x1805C9700
	public void TeleportAllEntities() { }

	// RVA: 0x5B45D0 Offset: 0x5B2BD0 VA: 0x1805B45D0
	public void SetCurrentGame(QuantumGame game) { }

	// RVA: 0x5C7580 Offset: 0x5C5B80 VA: 0x1805C7580
	public void Awake() { }

	// RVA: 0x5C8B30 Offset: 0x5C7130 VA: 0x1805C8B30
	private void OnGameStarted(QuantumGame game) { }

	// RVA: 0x5C8B50 Offset: 0x5C7150 VA: 0x1805C8B50
	private void OnObservedGameDestroyed(QuantumGame game, bool destroyed) { }

	// RVA: 0x5C8D10 Offset: 0x5C7310 VA: 0x1805C8D10
	private void OnObservedGameUpdated(QuantumGame game) { }

	// RVA: 0x5C9710 Offset: 0x5C7D10 VA: 0x1805C9710
	private void SyncViews(QuantumGame game, Frame frame, EntityViewBindBehaviour createBehaviour) { }

	// RVA: 0x5C7F30 Offset: 0x5C6530 VA: 0x1805C7F30
	private void CreateViewIfNeeded(QuantumGame game, Frame f, EntityRef handle, View view, EntityViewBindBehaviour createBehaviour) { }

	// RVA: 0x5C78A0 Offset: 0x5C5EA0 VA: 0x1805C78A0
	private void BindMapEntityIfNeeded(QuantumGame game, Frame f, EntityRef handle, MapEntityLink mapEntity, EntityViewBindBehaviour createBehaviour) { }

	// RVA: 0x5C8120 Offset: 0x5C6720 VA: 0x1805C8120
	private EntityView CreateView(QuantumGame game, Frame f, EntityRef handle, EntityView view, EntityViewBindBehaviour createBehaviour) { }

	// RVA: 0x5C79D0 Offset: 0x5C5FD0 VA: 0x1805C79D0
	private EntityView BindMapEntity(QuantumGame game, Frame f, EntityRef handle, MapEntityLink mapEntity, EntityViewBindBehaviour createBehaviour) { }

	// RVA: 0x5C8950 Offset: 0x5C6F50 VA: 0x1805C8950
	private void OnEntityViewInstantiated(QuantumGame game, Frame f, EntityView instance, EntityRef handle) { }

	// RVA: 0x5C84A0 Offset: 0x5C6AA0 VA: 0x1805C84A0
	private void DestroyEntityView(QuantumGame game, EntityRef entityRef) { }

	// RVA: 0x5C8560 Offset: 0x5C6B60 VA: 0x1805C8560 Slot: 4
	protected virtual void DestroyEntityView(QuantumGame game, EntityView view) { }

	// RVA: 0x5C8770 Offset: 0x5C6D70 VA: 0x1805C8770
	private void OnDestroy() { }

	// RVA: 0x5C7DB0 Offset: 0x5C63B0 VA: 0x1805C7DB0 Slot: 5
	protected virtual EntityView CreateEntityViewInstance(EntityViewAsset asset, Nullable<Vector3> position, Nullable<Quaternion> rotation) { }

	// RVA: 0x5C8430 Offset: 0x5C6A30 VA: 0x1805C8430 Slot: 6
	protected virtual void DestroyEntityViewInstance(EntityView instance) { }

	// RVA: 0x5C7420 Offset: 0x5C5A20 VA: 0x1805C7420 Slot: 7
	protected virtual void ActivateMapEntityInstance(EntityView instance, Nullable<Vector3> position, Nullable<Quaternion> rotation) { }

	// RVA: 0x5C8670 Offset: 0x5C6C70 VA: 0x1805C8670 Slot: 8
	protected virtual void DisableMapEntityInstance(EntityView instance) { }

	// RVA: 0x5C8720 Offset: 0x5C6D20 VA: 0x1805C8720 Slot: 9
	protected virtual void LoadMissingPrefab(EntityViewAsset viewAsset) { }

	// RVA: 0x5C9BC0 Offset: 0x5C81C0 VA: 0x1805C9BC0
	private static bool TryGetTransform(Frame f, EntityRef handle, out Vector3 position, out Quaternion rotation) { }

	// RVA: 0x5C9EA0 Offset: 0x5C84A0 VA: 0x1805C9EA0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x5C9D80 Offset: 0x5C8380 VA: 0x1805C9D80
	private void <Awake>b__25_0(CallbackGameStarted c) { }

	[CompilerGenerated]
	// RVA: 0x5C9D80 Offset: 0x5C8380 VA: 0x1805C9D80
	private void <Awake>b__25_1(CallbackUnitySceneLoadDone c) { }

	[CompilerGenerated]
	// RVA: 0x5C9DD0 Offset: 0x5C83D0 VA: 0x1805C9DD0
	private void <Awake>b__25_2(CallbackUpdateView c) { }

	[CompilerGenerated]
	// RVA: 0x5C9E10 Offset: 0x5C8410 VA: 0x1805C9E10
	private bool <Awake>b__25_3(IDeterministicGame game) { }

	[CompilerGenerated]
	// RVA: 0x5C9E20 Offset: 0x5C8420 VA: 0x1805C9E20
	private void <Awake>b__25_4(CallbackGameDestroyed c) { }

	[CompilerGenerated]
	// RVA: 0x5C9E10 Offset: 0x5C8410 VA: 0x1805C9E10
	private bool <Awake>b__25_5(IDeterministicGame game) { }

	[CompilerGenerated]
	// RVA: 0x5C9E60 Offset: 0x5C8460 VA: 0x1805C9E60
	private void <Awake>b__25_6(CallbackUnitySceneLoadBegin c) { }

	[CompilerGenerated]
	// RVA: 0x5C9E10 Offset: 0x5C8410 VA: 0x1805C9E10
	private bool <Awake>b__25_7(IDeterministicGame game) { }
}
