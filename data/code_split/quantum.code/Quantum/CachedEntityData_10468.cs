// Namespace: Quantum
public struct CachedEntityData // TypeDefIndex: 10468
{
	// Fields
	public EntityRef Entity; // 0x0
	public GameEntity* GameEntity; // 0x8
	public EntityModifierTarget* EntityModifierTarget; // 0x10
	public StellarCharacter* Character; // 0x18
	public Transform2D* Transform; // 0x20
	public InputBuffer* InputBuffer; // 0x28
	public StateMachine* StateMachine; // 0x30
	public CustomAnimator* CustomAnimator; // 0x38
	public PhysicsBody* PhysicsBody; // 0x40
	public KinematicBody* KinematicBody; // 0x48
	public Combat* Combat; // 0x50
	public Grab* Grab; // 0x58
	public bool HasCachedHashSets; // 0x60
	public QHashSet<AssetGuid> ExecutedBehaviours; // 0x68
	public QHashSet<AssetGuid> FinishedBehaviours; // 0x78

	// Methods

	// RVA: 0x21B1740 Offset: 0x21AFD40 VA: 0x1821B1740
	public static CachedEntityData Create(Frame frame, EntityRef entity, bool generateBehaviourHashSets = False) { }
}
