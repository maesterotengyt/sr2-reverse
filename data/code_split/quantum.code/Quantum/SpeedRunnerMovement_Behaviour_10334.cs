// Namespace: Quantum
[Serializable]
public class SpeedRunnerMovement_Behaviour : StateBehaviour // TypeDefIndex: 10334
{
	// Fields
	public bool Sliding; // 0x60
	public bool Swinging; // 0x61
	public FacingDirectionUpdateMode FacingDirectionMode; // 0x64

	// Methods

	// RVA: 0x2177FE0 Offset: 0x21765E0 VA: 0x182177FE0 Slot: 7
	protected override void OnEnter(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 8
	protected override void OnExecute(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x2178270 Offset: 0x2176870 VA: 0x182178270 Slot: 10
	protected override void OnExit(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x2178300 Offset: 0x2176900 VA: 0x182178300 Slot: 9
	protected override void OnUpdate(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData, int currentFrame) { }

	// RVA: 0x2178610 Offset: 0x2176C10 VA: 0x182178610
	private void UpdateVelocity(Frame frame, CachedEntityData targetEntityData, int currentFrame) { }

	// RVA: 0x21795B0 Offset: 0x2177BB0 VA: 0x1821795B0
	private void UseBoost(Frame frame, CachedEntityData targetEntityData, SpeedRunnersCharacter* speedRunnerCharacter, SpeedRunnersSettingsData speedRunnersSettingsData, FP delta) { }

	// RVA: 0x2178560 Offset: 0x2176B60 VA: 0x182178560
	private FP SlopeMaxVelocityCorrection(FPVector2 movDirection, int facingDirection) { }

	// RVA: 0x21776B0 Offset: 0x2175CB0 VA: 0x1821776B0
	private void CalculateAcceleration(Frame frame, CachedEntityData targetEntityData, SpeedRunnersCharacter* speedRunnersCharacter, SpeedRunnersSettingsData speedRunnersSettingsData, FP delta) { }

	// RVA: 0x20EBB30 Offset: 0x20EA130 VA: 0x1820EBB30
	public void .ctor() { }
}
