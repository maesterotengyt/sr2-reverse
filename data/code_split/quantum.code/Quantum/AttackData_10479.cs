// Namespace: Quantum
[Serializable]
public class AttackData // TypeDefIndex: 10479
{
	// Fields
	public HashString ID; // 0x10
	public AttackDataValues AttackDataValues; // 0x20
	public AttackVictimDirection VictimDirection; // 0x110
	public HitBoxSpecialBehaviour HitBoxHorizontalBehaviour; // 0x114
	public SpecialAnglePreset SpecialAngle; // 0x118
	public FP Angle; // 0x120
	public FP InstigatorPushBack; // 0x128
	public bool Flinchless; // 0x130
	public bool Unblockable; // 0x131
	public bool Reversible; // 0x132
	public bool CannotRebound; // 0x133
	public bool Trascendence; // 0x134
	public bool Trample; // 0x135
	public bool UntechableIfGrounded; // 0x136
	public bool OnlyHitGroundedTargets; // 0x137
	public bool OnlyHitAirborneTargets; // 0x138
	public bool OnlyHitOwner; // 0x139
	public bool OnlyHitOwned; // 0x13A
	public HashString VFXID; // 0x140
	public VFXPlayAttributes PlayAttributes; // 0x150
	public HashString SFXEventName; // 0x1E8
	public bool UpdateSoundPosition; // 0x1F8
	public bool HasConditions; // 0x1F9
	[DrawIf("HasConditions", 1, 0, 3)]
	public AdvancedConditionLogicalOperator LogicalOperator; // 0x1FC
	[DrawIf("HasConditions", 1, 0, 3)]
	public AdvancedCondition[] Conditions; // 0x200

	// Methods

	// RVA: 0x21B13F0 Offset: 0x21AF9F0 VA: 0x1821B13F0
	public HitInfo GenerateHitInfo(Frame frame, CombatSettingsData combatSettingsData, HitResult hitResult) { }

	// RVA: 0x21B15E0 Offset: 0x21AFBE0 VA: 0x1821B15E0
	internal FP GetHitLagFrames(CombatSettingsData combatSettingsData) { }

	// RVA: 0x21B1580 Offset: 0x21AFB80 VA: 0x1821B1580
	internal FP GetAngle(Frame frame, CombatSettingsData combatSettingsData, Combat* instigator, Combat* victim, FPVector2 hitBoxPosition, int facingDirection) { }

	// RVA: 0x21B1630 Offset: 0x21AFC30 VA: 0x1821B1630
	public void .ctor() { }
}
