// Namespace: Quantum
public class CombatSystem : SystemMainThread // TypeDefIndex: 10676
{
	// Methods

	// RVA: 0x20E9510 Offset: 0x20E7B10 VA: 0x1820E9510 Slot: 10
	public override void Update(Frame frame) { }

	// RVA: 0x20E7A80 Offset: 0x20E6080 VA: 0x1820E7A80
	private void EvaluateRedirectsAndReflects(Frame frame, CombatSettingsData combatSettingsData, CombatEntity check, CombatEntity target) { }

	// RVA: 0x20E6A10 Offset: 0x20E5010 VA: 0x1820E6A10
	private void EvaluateHitBoxes(Frame frame, CombatSettingsData combatSettingsData, CombatEntity check, CombatEntity target, bool hittingOwner, bool hitFromOwner, bool sameTeam, int facingDirection) { }

	// RVA: 0x20E7260 Offset: 0x20E5860 VA: 0x1820E7260
	private void EvaluateHurtBoxes(Frame frame, CombatEntity check, CombatEntity target, bool hittingOwner, bool hitFromOwner, bool sameTeam, int facingDirection, ref List<HitResult> registeredHits, ref List<GrabResult> registeredGrabs) { }

	// RVA: 0x20E7F50 Offset: 0x20E6550 VA: 0x1820E7F50
	private void EvaluateRegisteredHitsAndGrabs(Frame frame, CombatSettingsData combatSettingsData, ref List<HitResult> registeredHits, ref List<GrabResult> registeredGrabs) { }

	// RVA: 0x20E8F40 Offset: 0x20E7540 VA: 0x1820E8F40
	private void RegisterHit(ref List<HitResult> registeredHits, HitResult newHitResult) { }

	// RVA: 0x20E8D50 Offset: 0x20E7350 VA: 0x1820E8D50
	private void RegisterGrab(ref List<GrabResult> registeredGrabs, GrabResult newGrabResult) { }

	// RVA: 0x20E6950 Offset: 0x20E4F50 VA: 0x1820E6950
	private bool CanEntityClank(Frame frame, AttackData attackData, CombatEntity entity) { }

	// RVA: 0x20EA200 Offset: 0x20E8800 VA: 0x1820EA200
	public void .ctor() { }
}
