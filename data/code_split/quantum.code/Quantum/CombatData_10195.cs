// Namespace: Quantum
[Serializable]
public class CombatData : AssetObject // TypeDefIndex: 10195
{
	// Fields
	public EntityHitFilter HitFilter; // 0x20
	public FP MaxKnockbackForFlinch; // 0x68
	public FP MaxKnockbackForFlop; // 0x70
	public FP Weight; // 0x78
	public bool RedirectedByAnything; // 0x80
	public bool CanBeRedirected; // 0x81
	public bool CanBeReflected; // 0x82
	public HurtBoxPreset[] HurtBoxPresets; // 0x88
	public AssetRefAttackDatasPool[] AttackDataPools; // 0x90
	[Header("Extensions")]
	public bool CanBlock; // 0x98
	public bool CanTech; // 0x99
	public bool CanChargeAttacks; // 0x9A
	public bool CanUseArmor; // 0x9B
	public bool CanUseDI; // 0x9C
	public bool CanStatusEffectsModifiersBeApplied; // 0x9D
	[Header("Combat State Events")]
	public StateNotificationMode ReboundNotificationMode; // 0xA0
	[DrawIf("ReboundNotificationMode", 0, 1, 3)]
	public HashString ReboundState; // 0xA8
	[Space(5)]
	public StateNotificationMode DownFlinchNotificationMode; // 0xB8
	[DrawIf("DownFlinchNotificationMode", 0, 1, 3)]
	public HashString DownFlinchState; // 0xC0
	[Space(5)]
	public StateNotificationMode FlinchNotificationMode; // 0xD0
	[DrawIf("FlinchNotificationMode", 0, 1, 3)]
	public HashString FlinchState; // 0xD8
	[Space(5)]
	public StateNotificationMode FlopNotificationMode; // 0xE8
	[DrawIf("FlopNotificationMode", 0, 1, 3)]
	public HashString FlopState; // 0xF0
	[Space(5)]
	public StateNotificationMode LaunchedNotificationMode; // 0x100
	[DrawIf("LaunchedNotificationMode", 0, 1, 3)]
	public HashString LaunchedState; // 0x108
	[Space(5)]
	public StateNotificationMode RedirectedNotificationMode; // 0x118
	[DrawIf("RedirectedNotificationMode", 0, 1, 3)]
	public HashString RedirectedState; // 0x120
	[Space(5)]
	public StateNotificationMode ReflectedNotificationMode; // 0x130
	[DrawIf("ReflectedNotificationMode", 0, 1, 3)]
	public HashString ReflectedState; // 0x138
	[Space(5)]
	public StateNotificationMode HitNotificationMode; // 0x148
	[DrawIf("HitNotificationMode", 0, 1, 3)]
	public HashString HitState; // 0x150
	[Space(5)]
	public StateNotificationMode HurtNotificationMode; // 0x160
	[DrawIf("HurtNotificationMode", 0, 1, 3)]
	public HashString HurtState; // 0x168
	[Space(5)]
	public StateNotificationMode BlockBreakNotificationMode; // 0x178
	[DrawIf("BlockBreakNotificationMode", 0, 1, 3)]
	public HashString BlockBreakState; // 0x180
	[Space(5)]
	public StateNotificationMode StaminaDepletedNotificationMode; // 0x190
	[DrawIf("StaminaDepletedNotificationMode", 0, 1, 3)]
	public HashString StaminaDepletedState; // 0x198
	[Space(5)]
	public StateNotificationMode KnockedOutNotificationMode; // 0x1A8
	[DrawIf("KnockedOutNotificationMode", 0, 1, 3)]
	public HashString KnockedOutState; // 0x1B0
	[Space(5)]
	public StateNotificationMode RespawnNotificationMode; // 0x1C0
	[DrawIf("RespawnNotificationMode", 0, 1, 3)]
	public HashString RespawnState; // 0x1C8

	// Methods

	// RVA: 0x2150940 Offset: 0x214EF40 VA: 0x182150940
	public bool TryGetHurtBoxPreset(int identifier, out HurtBoxPreset preset) { }

	// RVA: 0x21507C0 Offset: 0x214EDC0 VA: 0x1821507C0
	public bool TryGetAttackData(Frame frame, int attackDataID, out AttackData attackData) { }

	// RVA: 0x21509E0 Offset: 0x214EFE0 VA: 0x1821509E0
	public void .ctor() { }
}
