// Namespace: Quantum
[Serializable]
public class RocketLauncher_Behaviour : StateBehaviour // TypeDefIndex: 10351
{
	// Fields
	public AssetRefGameEntityData RocketGameEntity; // 0x60
	public int ShootCooldownFrames; // 0x68
	public FPVector2 SpawnPosition; // 0x70
	public CollisionLayer[] LinecastLayers; // 0x80

	// Methods

	// RVA: 0x20EC110 Offset: 0x20EA710 VA: 0x1820EC110 Slot: 7
	protected override void OnEnter(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x2191960 Offset: 0x218FF60 VA: 0x182191960 Slot: 8
	protected override void OnExecute(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 10
	protected override void OnExit(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x21919D0 Offset: 0x218FFD0 VA: 0x1821919D0 Slot: 9
	protected override void OnUpdate(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData, int currentFrame) { }

	// RVA: 0x2191870 Offset: 0x218FE70 VA: 0x182191870
	private bool HasLineOfSight(Frame frame, EntityRef entity, FPVector2 startPoint, FPVector2 endPoint, int layerMask) { }

	// RVA: 0x2192190 Offset: 0x2190790 VA: 0x182192190
	public void .ctor() { }
}
