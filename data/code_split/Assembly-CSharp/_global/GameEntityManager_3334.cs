// Namespace: 
public class GameEntityManager : StellarMonoBehaviour // TypeDefIndex: 3334
{
	// Fields
	public EntityView Entity; // 0x20
	public StellarCharacterManager Character; // 0x28
	public bool ApplyMirror; // 0x30
	[Header("•Additional Components")]
	public GameEntityObjectsManager ObjectsManager; // 0x38
	public GameEntityRenderManager RenderersManager; // 0x40
	public CustomAnimatorManager CustomAnimator; // 0x48
	public SimpleLineRendererManager SimpleLineRendererManager; // 0x50
	[Header("•General References")]
	public Transform MainTransform; // 0x58
	public Transform RotationPivotTransform; // 0x60
	public Transform RotationOffsetTransform; // 0x68
	public Transform Visuals; // 0x70
	[Header("•VFX")]
	public GameObject[] VFXManagers; // 0x78
	[Header("•Updaters")]
	public GameEntityPollUpdater[] AdditionalPollUpdaters; // 0x80
	private int lastFacingDirection; // 0x88
	private FP lastScale; // 0x90
	private EntityRef lastGrabberEntityRef; // 0x98
	private Transform lastGrabberItemSlot; // 0xA0
	private Transform lastGrabberIGrabSlot; // 0xA8

	// Properties
	public int LastFacingDirection { get; }

	// Methods

	// RVA: 0x5B7BD0 Offset: 0x5B61D0 VA: 0x1805B7BD0
	public int get_LastFacingDirection() { }

	// RVA: 0x5B6230 Offset: 0x5B4830 VA: 0x1805B6230
	public void OnInstantiated(QuantumGame game) { }

	// RVA: 0x5B58A0 Offset: 0x5B3EA0 VA: 0x1805B58A0
	private void Awake() { }

	// RVA: 0x5B64D0 Offset: 0x5B4AD0 VA: 0x1805B64D0
	public void OnUpdate(Frame frame, GameEntity* gameEntity, out bool visibilityChanged, out bool changedFacingDirection) { }

	// RVA: 0x5B60D0 Offset: 0x5B46D0 VA: 0x1805B60D0
	private void LateUpdate() { }

	// RVA: 0x5B7140 Offset: 0x5B5740 VA: 0x1805B7140
	private void UpdateGrabEntityPosition() { }

	// RVA: 0x5B5C50 Offset: 0x5B4250 VA: 0x1805B5C50
	private Transform GetGrabJointTransform(GrabJoint jointType, Grab* grab) { }

	// RVA: 0x5B5AF0 Offset: 0x5B40F0 VA: 0x1805B5AF0
	private Transform GetEntityItemSlot(EntityRef entityRef) { }

	// RVA: 0x5B5990 Offset: 0x5B3F90 VA: 0x1805B5990
	private Transform GetEntityGrabSlot(EntityRef entityRef) { }

	// RVA: 0x5B60E0 Offset: 0x5B46E0 VA: 0x1805B60E0
	private void OnClearPropSlots(EventClearSlots callback) { }

	// RVA: 0x5B7B40 Offset: 0x5B6140 VA: 0x1805B7B40
	public void .ctor() { }
}
