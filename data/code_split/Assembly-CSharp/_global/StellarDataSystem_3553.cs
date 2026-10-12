// Namespace: 
public class StellarDataSystem : StellarMonoBehaviour // TypeDefIndex: 3553
{
	// Fields
	public MatchData MatchData; // 0x20
	[CompilerGenerated]
	private List<StellarPlayer> <LocalPlayers>k__BackingField; // 0x48
	[CompilerGenerated]
	private int <PlayersAmount>k__BackingField; // 0x50
	[CompilerGenerated]
	private bool <StartedFromGameStage>k__BackingField; // 0x54
	[CompilerGenerated]
	private string <MainUserNickname>k__BackingField; // 0x58

	// Properties
	public List<StellarPlayer> LocalPlayers { get; set; }
	public int PlayersAmount { get; set; }
	public bool StartedFromGameStage { get; set; }
	public string MainUserNickname { get; set; }
	public int Player1Index { get; }
	public int OnlinePlayerCharacter { get; }
	public int OnlinePlayerSkin { get; }
	public bool PlayerIsSpectator { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x5C9FA0 Offset: 0x5C85A0 VA: 0x1805C9FA0
	public List<StellarPlayer> get_LocalPlayers() { }

	[CompilerGenerated]
	// RVA: 0x58D130 Offset: 0x58B730 VA: 0x18058D130
	public void set_LocalPlayers(List<StellarPlayer> value) { }

	[CompilerGenerated]
	// RVA: 0x5D3AF0 Offset: 0x5D20F0 VA: 0x1805D3AF0
	public int get_PlayersAmount() { }

	[CompilerGenerated]
	// RVA: 0x5D3B10 Offset: 0x5D2110 VA: 0x1805D3B10
	public void set_PlayersAmount(int value) { }

	[CompilerGenerated]
	// RVA: 0x5EB800 Offset: 0x5E9E00 VA: 0x1805EB800
	public bool get_StartedFromGameStage() { }

	[CompilerGenerated]
	// RVA: 0x5EB810 Offset: 0x5E9E10 VA: 0x1805EB810
	public void set_StartedFromGameStage(bool value) { }

	[CompilerGenerated]
	// RVA: 0x5B45B0 Offset: 0x5B2BB0 VA: 0x1805B45B0
	public string get_MainUserNickname() { }

	[CompilerGenerated]
	// RVA: 0x5B45D0 Offset: 0x5B2BD0 VA: 0x1805B45D0
	public void set_MainUserNickname(string value) { }

	// RVA: 0x5EB730 Offset: 0x5E9D30 VA: 0x1805EB730
	public int get_Player1Index() { }

	// RVA: 0x5EB630 Offset: 0x5E9C30 VA: 0x1805EB630
	public int get_OnlinePlayerCharacter() { }

	// RVA: 0x5EB6B0 Offset: 0x5E9CB0 VA: 0x1805EB6B0
	public int get_OnlinePlayerSkin() { }

	// RVA: 0x5EB7A0 Offset: 0x5E9DA0 VA: 0x1805EB7A0
	public bool get_PlayerIsSpectator() { }

	// RVA: 0x5EB3A0 Offset: 0x5E99A0 VA: 0x1805EB3A0
	public void Initialize() { }

	// RVA: 0x5EB250 Offset: 0x5E9850 VA: 0x1805EB250
	public StellarPlayer GetLocalPlayer(int playerIndex) { }

	// RVA: 0x5EB410 Offset: 0x5E9A10 VA: 0x1805EB410
	public void SetDefaultPlayer() { }

	// RVA: 0x5EB550 Offset: 0x5E9B50 VA: 0x1805EB550
	public void SetPlayerSpectatorState(bool isSpectator) { }

	// RVA: 0x5EB5B0 Offset: 0x5E9BB0 VA: 0x1805EB5B0
	public void .ctor() { }
}
