// Namespace: Quantum
public struct Combat : IComponent // TypeDefIndex: 9967
{
	// Fields
	public QBoolean Active; // 0x4
	[HideInInspector]
	public QBoolean AffectedByFlinchlessHits; // 0x8
	[HideInInspector]
	public QBoolean CanBeRedirected; // 0xC
	[HideInInspector]
	public QBoolean CanBeReflected; // 0x10
	[HideInInspector]
	public AssetRefCombatData CombatData; // 0x38
	[HideInInspector]
	[PtrQList(typeof(EntityRef))]
	private Ptr EntitiesHitPtr; // 0x28
	public EntityRef Entity; // 0x40
	[HideInInspector]
	[PtrQList(typeof(HitBox))]
	private Ptr HitBoxesPtr; // 0x2C
	[HideInInspector]
	public SimpleAABB HitBoxesRect; // 0x90
	[HideInInspector]
	public EntityHitFilter HitFilter; // 0xF0
	[HideInInspector]
	public FP HitLagFrames; // 0x60
	[HideInInspector]
	public FP HitStunFrames; // 0x68
	public int HitlagFramesOverride; // 0x0
	[HideInInspector]
	[PtrQList(typeof(HurtBox))]
	private Ptr HurtBoxesPtr; // 0x30
	[HideInInspector]
	public SimpleAABB HurtBoxesRect; // 0xB0
	[HideInInspector]
	public FP IntangibilityFrames; // 0x70
	[HideInInspector]
	public FP InvincibilityFrames; // 0x78
	[HideInInspector]
	public QBoolean IsDown; // 0x14
	[HideInInspector]
	public QBoolean IsIntangible; // 0x18
	[HideInInspector]
	public QBoolean IsInvincible; // 0x1C
	[HideInInspector]
	public QBoolean KnockedOut; // 0x20
	[HideInInspector]
	public HitInfo LastInflictedHit; // 0x138
	[HideInInspector]
	public HitInfo LastReceivedHit; // 0x210
	[HideInInspector]
	public EntityRef LastRedirector; // 0x48
	[HideInInspector]
	public EntityRef LastReflector; // 0x50
	[HideInInspector]
	public EntityRef OwnerOverride; // 0x58
	[HideInInspector]
	public SimpleAABB RedirectAndReflectRect; // 0xD0
	[HideInInspector]
	public FP RedirectAngle; // 0x80
	[HideInInspector]
	public QBoolean RedirectedByAnything; // 0x24
	[HideInInspector]
	public FP WeightForKnockback; // 0x88
	private static ColorRGBA DIAngleColor; // 0x0
	private static ColorRGBA LaunchAngleColor; // 0x4

	// Properties
	public QListPtr<EntityRef> EntitiesHit { get; set; }
	public QListPtr<HitBox> HitBoxes { get; set; }
	public QListPtr<HurtBox> HurtBoxes { get; set; }

	// Methods

	// RVA: 0x20DB7C0 Offset: 0x20D9DC0 VA: 0x1820DB7C0
	public QListPtr<EntityRef> get_EntitiesHit() { }

	// RVA: 0x51AE50 Offset: 0x519450 VA: 0x18051AE50
	public void set_EntitiesHit(QListPtr<EntityRef> value) { }

	// RVA: 0x20DB800 Offset: 0x20D9E00 VA: 0x1820DB800
	public QListPtr<HitBox> get_HitBoxes() { }

	// RVA: 0x11DAC00 Offset: 0x11D9200 VA: 0x1811DAC00
	public void set_HitBoxes(QListPtr<HitBox> value) { }

	// RVA: 0x20DB840 Offset: 0x20D9E40 VA: 0x1820DB840
	public QListPtr<HurtBox> get_HurtBoxes() { }

	// RVA: 0x5C5B70 Offset: 0x5C4170 VA: 0x1805C5B70
	public void set_HurtBoxes(QListPtr<HurtBox> value) { }

	// RVA: 0x20D5C50 Offset: 0x20D4250 VA: 0x1820D5C50 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xE1ECA0 Offset: 0xE1D2A0 VA: 0x180E1ECA0
	public void ClearPointers(Frame f, EntityRef entity) { }

	// RVA: 0x20D8320 Offset: 0x20D6920 VA: 0x1820D8320
	public static void OnRemoved(FrameBase frame, EntityRef entity, void* ptr) { }

	// RVA: 0x20D8500 Offset: 0x20D6B00 VA: 0x1820D8500
	public static void Serialize(void* ptr, FrameSerializer serializer) { }

	// RVA: 0x20D6250 Offset: 0x20D4850 VA: 0x1820D6250
	internal void Initialize(Frame frame, EntityRef entity, AssetRefCombatData combatData) { }

	// RVA: 0x20D83C0 Offset: 0x20D69C0 VA: 0x1820D83C0
	internal void Reset(Frame frame) { }

	// RVA: 0x20D5F20 Offset: 0x20D4520 VA: 0x1820D5F20
	internal FP GetValue(Frame frame, CombatVariable variable) { }

	// RVA: 0x20D8860 Offset: 0x20D6E60 VA: 0x1820D8860
	internal void SetValue(Frame frame, CombatVariable variable, FP value) { }

	// RVA: 0x20D9E20 Offset: 0x20D8420 VA: 0x1820D9E20
	internal void Update(Frame frame, CombatSettingsData combatSettingsData, Transform2D* transform) { }

	// RVA: 0x20D4C80 Offset: 0x20D3280 VA: 0x1820D4C80
	internal void ApplyDamage(Frame frame, FP damage, out bool knockedOut) { }

	// RVA: 0x20D6770 Offset: 0x20D4D70 VA: 0x1820D6770
	internal void NotifyKnockOut(Frame frame) { }

	// RVA: 0x20D68F0 Offset: 0x20D4EF0 VA: 0x1820D68F0
	internal void NotifyRespawn(Frame frame) { }

	// RVA: 0x20D70C0 Offset: 0x20D56C0 VA: 0x1820D70C0
	internal void OnHurt(Frame frame, CombatSettingsData combatSettingsData, CombatData combatData, HitInfo hitInfo) { }

	// RVA: 0x20D6A80 Offset: 0x20D5080 VA: 0x1820D6A80
	internal void OnHit(Frame frame, CombatSettingsData combatSettingsData, CombatData combatData, HitInfo hitInfo) { }

	// RVA: 0x20D7FA0 Offset: 0x20D65A0 VA: 0x1820D7FA0
	internal void OnRebound(Frame frame, CombatData combatData, FP hitLagFrames, bool trample = False) { }

	// RVA: 0x20D80C0 Offset: 0x20D66C0 VA: 0x1820D80C0
	internal void OnRedirected(Frame frame, Combat* redirector, FP redirectAngle) { }

	// RVA: 0x20D81F0 Offset: 0x20D67F0 VA: 0x1820D81F0
	internal void OnReflected(Frame frame, Combat* reflector) { }

	// RVA: 0x20D4870 Offset: 0x20D2E70 VA: 0x1820D4870
	internal void AddEntityToHitList(Frame frame, EntityRef entity) { }

	// RVA: 0x20D4970 Offset: 0x20D2F70 VA: 0x1820D4970
	internal void AddHitLag(FP hitLagFrames) { }

	// RVA: 0x16D9840 Offset: 0x16D7E40 VA: 0x1816D9840
	internal void AddHitStun(FP hitStun) { }

	// RVA: 0x20D8C60 Offset: 0x20D7260 VA: 0x1820D8C60
	internal void SetupHitBoxes(Frame frame, HitBoxData[] hitBoxesData, FP scale, bool clearEntitiesHit = True) { }

	// RVA: 0x20D98C0 Offset: 0x20D7EC0 VA: 0x1820D98C0
	internal void UpdateHitBoxes(Frame frame, HitBoxData[] hitBoxesData, int currentFrame, FP scale) { }

	// RVA: 0x20D5730 Offset: 0x20D3D30 VA: 0x1820D5730
	internal void ClearHitBoxes(Frame frame) { }

	// RVA: 0x20D9480 Offset: 0x20D7A80 VA: 0x1820D9480
	internal void SetupHurtBoxes(Frame frame, HurtBoxData[] hurtBoxesData, FP scale) { }

	// RVA: 0x20D9B70 Offset: 0x20D8170 VA: 0x1820D9B70
	internal void UpdateHurtBoxes(Frame frame, HurtBoxData[] hurtBoxesData, int currentFrame, FP scale) { }

	// RVA: 0x20D58D0 Offset: 0x20D3ED0 VA: 0x1820D58D0
	internal void ClearHurtBoxes(Frame frame) { }

	// RVA: 0x20D5670 Offset: 0x20D3C70 VA: 0x1820D5670
	internal void ClearEntitiesHit(Frame frame) { }

	// RVA: 0x20D61D0 Offset: 0x20D47D0 VA: 0x1820D61D0
	public bool HasIntangibility() { }

	// RVA: 0x20D6210 Offset: 0x20D4810 VA: 0x1820D6210
	public bool HasInvincibility() { }

	// RVA: 0x20D6750 Offset: 0x20D4D50 VA: 0x1820D6750
	internal bool IsInHitLag() { }

	// RVA: 0x20D6730 Offset: 0x20D4D30 VA: 0x1820D6730
	internal bool IsHitStunned() { }

	// RVA: 0x20D5E30 Offset: 0x20D4430 VA: 0x1820D5E30
	internal FP GetHitStunnedFrames() { }

	// RVA: 0x20D6600 Offset: 0x20D4C00 VA: 0x1820D6600
	internal bool IsEntityAlreadyHit(Frame frame, EntityRef entity) { }

	// RVA: 0x20D5390 Offset: 0x20D3990 VA: 0x1820D5390
	private FPVector2 CalculateCombatCapsulePoint(Frame frame, int jointID, bool foundKeyFrame, JointKeyFrame keyFrame, Transform2D* transform, FPVector2 cachePoint, FPVector3 localOffset, FPVector2 globalOffset) { }

	// RVA: 0x20D8B30 Offset: 0x20D7130 VA: 0x1820D8B30
	private void SetupDI(Frame frame, CombatSettingsData combatSettingsData, InputBuffer* inputBuffer, CombatDI* combatDI) { }

	// RVA: 0x20D4B90 Offset: 0x20D3190 VA: 0x1820D4B90
	private void ApplyDI(Frame frame, PhysicsBody* physicsBody, CombatDI* combatDI) { }

	// RVA: 0x20D4990 Offset: 0x20D2F90 VA: 0x1820D4990
	public void ApplyASDI(Frame frame, CombatSettingsData combatSettingsData, InputBuffer* inputBuffer, PhysicsBody* physicsBody, Transform2D* transform, CombatDI* combatDI) { }

	// RVA: 0x20D4FB0 Offset: 0x20D35B0 VA: 0x1820D4FB0
	public void ApplySDI(Frame frame, CombatSettingsData combatSettingsData, InputBuffer* inputBuffer, PhysicsBody* physicsBody, Transform2D* transform, CombatDI* combatDI) { }

	// RVA: 0x20D5E50 Offset: 0x20D4450 VA: 0x1820D5E50
	internal EntityRef GetOwnerEntity(Frame frame) { }

	// RVA: 0x20D5990 Offset: 0x20D3F90 VA: 0x1820D5990
	internal EntityRef GetCharacterOwnerEntity(Frame frame) { }

	// RVA: 0x20D6A00 Offset: 0x20D5000 VA: 0x1820D6A00
	internal void OnChangeOwner(Frame frame, EntityRef newOwner) { }

	// RVA: 0x20DB760 Offset: 0x20D9D60 VA: 0x1820DB760
	private static void .cctor() { }
}
