// Namespace: 
public class SimulationManager : SRMonoBehaviour // TypeDefIndex: 2621
{
	// Fields
	public AssetGuid CurrentMapGuid; // 0x20
	private DispatcherSubscription onEventOnLoadingFinishedSubscription; // 0x28

	// Properties
	public StellarSimulationSystem StellarSystem { get; }

	// Methods

	// RVA: 0x70B040 Offset: 0x709640 VA: 0x18070B040
	public StellarSimulationSystem get_StellarSystem() { }

	// RVA: 0x70A720 Offset: 0x708D20 VA: 0x18070A720
	public void StartSimulation(MapData forcedMapData) { }

	// RVA: 0x709F80 Offset: 0x708580 VA: 0x180709F80
	private void SimulationStarted() { }

	// RVA: 0x70A5A0 Offset: 0x708BA0 VA: 0x18070A5A0
	private void SpawnNPCs() { }

	// RVA: 0x709780 Offset: 0x707D80 VA: 0x180709780
	public void SetMatchCharactersAmount() { }

	// RVA: 0x708910 Offset: 0x706F10 VA: 0x180708910
	private void OnLoadingFinished(EventOnLoadingFinished callback) { }

	// RVA: 0x709E10 Offset: 0x708410 VA: 0x180709E10
	private void SimulationClosed() { }

	// RVA: 0x708C50 Offset: 0x707250 VA: 0x180708C50
	public void PrintCharacterData() { }

	// RVA: 0x7093C0 Offset: 0x7079C0 VA: 0x1807093C0
	public void SetCharactersSpawnOrder() { }

	// RVA: 0x708B00 Offset: 0x707100 VA: 0x180708B00
	public void PlayerLeftDuringMatch() { }

	// RVA: 0x53A8F0 Offset: 0x538EF0 VA: 0x18053A8F0
	public void .ctor() { }
}
