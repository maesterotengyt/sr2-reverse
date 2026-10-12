// Namespace: Quantum
public struct GameModeItemAutoTrigger : IComponent // TypeDefIndex: 9994
{
	// Fields
	[HideInInspector]
	public EntityRef Entity; // 0x0
	public QString64 ItemToUse; // 0x8

	// Methods

	// RVA: 0x20E5270 Offset: 0x20E3870 VA: 0x1820E5270 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20E5310 Offset: 0x20E3910 VA: 0x1820E5310
	public static void Serialize(void* ptr, FrameSerializer serializer) { }

	// RVA: 0x20E52A0 Offset: 0x20E38A0 VA: 0x1820E52A0
	public void Init(Frame frame, EntityRef entity) { }

	// RVA: 0x20E3EC0 Offset: 0x20E24C0 VA: 0x1820E3EC0
	public void Activate(Frame frame) { }

	// RVA: 0x20E3C90 Offset: 0x20E2290 VA: 0x1820E3C90
	public void ActivateHazardsRace(Frame frame, HazardSpawnDirection direction, HashString hazard) { }

	// RVA: 0x20E4E40 Offset: 0x20E3440 VA: 0x1820E4E40
	private bool FindVerticalSpawn(Frame frame, FPVector2 playerPosition, FPVector2 directionVector) { }

	// RVA: 0x20E4A10 Offset: 0x20E3010 VA: 0x1820E4A10
	private bool FindHorizontalSpawn(Frame frame, FPVector2 playerPosition, FPVector2 directionVector) { }

	// RVA: -1 Offset: -1
	private void ShuffleList<T>(Frame frame, List<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB56E20 Offset: 0xB55420 VA: 0x180B56E20
	|-GameModeItemAutoTrigger.ShuffleList<SpawnTargetCandidate>
	|
	|-RVA: 0xB56B90 Offset: 0xB55190 VA: 0x180B56B90
	|-GameModeItemAutoTrigger.ShuffleList<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x20E4390 Offset: 0x20E2990 VA: 0x1820E4390
	private bool FindHazardSpawn(Frame frame, HazardSpawnDirection spawnSide, out EntityRef targetEntity) { }
}
