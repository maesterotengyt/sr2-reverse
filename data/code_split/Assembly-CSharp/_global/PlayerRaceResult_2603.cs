// Namespace: 
public struct PlayerRaceResult // TypeDefIndex: 2603
{
	// Fields
	public string PlayerID; // 0x0
	public int MatchPlacement; // 0x8
	public PlayerStats PlayerStats; // 0x10
	public PlayerSimulationData PlayerSimulationData; // 0x90
	public bool IsLocalPlayer; // 0xB0
	public bool IsNPC; // 0xB1
	public PlayerCustomization PlayerCustomization; // 0xB8

	// Methods

	// RVA: 0x6FF940 Offset: 0x6FDF40 VA: 0x1806FF940
	public void .ctor(string playerID, int matchPlacement, PlayerStats playerStats, PlayerSimulationData playerSimulationData, PlayerCustomization playerCustomization, bool isLocalPlayer, bool isNPC = False) { }
}
