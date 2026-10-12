// Namespace: Quantum
[Serializable]
public class Hurt_Behaviour : StateBehaviour // TypeDefIndex: 10356
{
	// Fields
	private FP STUN_TIME_LETHALS; // 0x60
	private FP STUN_TIME_FIREBALL; // 0x68
	private FP STUN_TIME_ROCKET; // 0x70
	public ExecuteGroupEvent TripGroup; // 0x78
	public HashString[] TripAttackDatas; // 0x90
	[Space(10)]
	public ExecuteGroupEvent TumbleGroup; // 0x98
	public HashString[] TumbleAttackDatas; // 0xB0
	[Space(10)]
	public ExecuteGroupEvent FreezeGroup; // 0xB8
	public HashString[] FreezeAttackDatas; // 0xD0
	[DrawWithLabel]
	public EntityVariable FreezeFrames; // 0xD8
	[DrawWithLabel]
	public EntityVariable OutIsOnFire; // 0xE0
	[Header("Attack data specific identifiers")]
	public HashString TackleAttackData; // 0xE8
	public HashString LethalObstacleAttackData; // 0xF8
	public HashString RocketAttackData; // 0x108
	public HashString RocketSelfExplosionAttackData; // 0x118
	public HashString FireballAttackData; // 0x128
	public HashString ShockwaveAttackData; // 0x138
	public HashString RemoteBombAttackData; // 0x148
	public HashString CrateAttackData; // 0x158
	public HashString InvinciDrillAttackData; // 0x168
	public HashString PlasmaBlasterAttackData; // 0x178
	[Header("Pushback")]
	public HashString[] PushbackAttackDatas; // 0x188

	// Methods

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 7
	protected override void OnEnter(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x218C540 Offset: 0x218AB40 VA: 0x18218C540 Slot: 8
	protected override void OnExecute(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 10
	protected override void OnExit(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 9
	protected override void OnUpdate(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData, int currentFrame) { }

	// RVA: 0x218EB30 Offset: 0x218D130 VA: 0x18218EB30
	public void .ctor() { }
}
