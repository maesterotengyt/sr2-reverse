// Namespace: Quantum
[Serializable]
public class SetupHitBoxesFromLinecast_Behaviour : StateBehaviourWithEndFrame // TypeDefIndex: 10527
{
	// Fields
	[DrawWithLabel]
	public EntityVariable XPosition; // 0x68
	[DrawWithLabel]
	public EntityVariable YPosition; // 0x70
	public bool PositionRelativeToEntity; // 0x78
	[Space(10)]
	public bool OutputToLineRenderer; // 0x79
	public CollisionLayer[] LinecastLayers; // 0x80
	[DrawWithLabel]
	public EntityVariable CastAngle; // 0x88
	public bool AngleRelativeToEntity; // 0x90
	[DrawWithLabel]
	public EntityVariable CastDistance; // 0x98
	[DrawWithLabel]
	public EntityVariable HitBoxesRadius; // 0xA0
	public HashString[] AttackDatas; // 0xA8

	// Methods

	// RVA: 0x20EC110 Offset: 0x20EA710 VA: 0x1820EC110 Slot: 7
	protected override void OnEnter(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 8
	protected override void OnExecute(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x21C05F0 Offset: 0x21BEBF0 VA: 0x1821C05F0 Slot: 10
	protected override void OnExit(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x21C0710 Offset: 0x21BED10 VA: 0x1821C0710 Slot: 9
	protected override void OnUpdate(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData, int currentFrame) { }

	// RVA: 0x21BFA00 Offset: 0x21BE000 VA: 0x1821BFA00
	private void GenerateHitBoxes(Frame frame, CachedEntityData targetEntityData) { }

	// RVA: 0x21C0790 Offset: 0x21BED90 VA: 0x1821C0790
	public void .ctor() { }
}
