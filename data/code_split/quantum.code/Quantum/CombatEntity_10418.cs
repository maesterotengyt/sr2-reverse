// Namespace: Quantum
public struct CombatEntity // TypeDefIndex: 10418
{
	// Fields
	public CombatData CombatData; // 0x0
	public EntityRef Entity; // 0x8
	public GameEntity* GameEntity; // 0x10
	public Combat* Combat; // 0x18
	public Grab* Grab; // 0x20
	public PhysicsBody* PhysicsBody; // 0x28
	public Transform2D* Transform; // 0x30

	// Methods

	// RVA: 0x21B25F0 Offset: 0x21B0BF0 VA: 0x1821B25F0
	public static CombatEntity Create(Frame frame, EntityRef entity) { }
}
