// Namespace: Quantum
[Serializable]
public class LapsRaceGameMode : RaceGameMode // TypeDefIndex: 10393
{
	// Fields
	public int LapsToFinish; // 0xA0

	// Methods

	// RVA: 0x21A5100 Offset: 0x21A3700 VA: 0x1821A5100 Slot: 6
	public override void OnLoadingFinished(Frame frame) { }

	// RVA: 0x219C2A0 Offset: 0x219A8A0 VA: 0x18219C2A0 Slot: 11
	public override void OnCharacterKnockOut(Frame frame, EntityRef entity) { }

	// RVA: 0x21A51A0 Offset: 0x21A37A0 VA: 0x1821A51A0 Slot: 7
	public override void OnMatchEnd(Frame frame) { }

	// RVA: 0x219C330 Offset: 0x219A930 VA: 0x18219C330 Slot: 8
	public override void OnCharacterSpawn(Frame frame, EntityRef entity, CharacterSpawnData characterSpawnData) { }

	// RVA: 0x4F6BD0 Offset: 0x4F51D0 VA: 0x1804F6BD0 Slot: 12
	public override bool OnCharacterEnterBlastzone(Frame frame, BlastzoneEdge blastzoneEdge, EntityRef entity) { }

	// RVA: 0x21A5040 Offset: 0x21A3640 VA: 0x1821A5040 Slot: 23
	public override void OnLapCompleted(Frame frame, EntityRef checkpointEntity, EntityRef characterEntity) { }

	// RVA: 0x21A5450 Offset: 0x21A3A50 VA: 0x1821A5450
	public void .ctor() { }
}
