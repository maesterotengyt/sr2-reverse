// Namespace: 
[Serializable]
public class StellarPlayer // TypeDefIndex: 3406
{
	// Fields
	public int PlayerIndex; // 0x10
	public PlayerSettings PlayerSettings; // 0x18
	public List<CharacterSpawnData> Characters; // 0x20
	[CompilerGenerated]
	private string <Nickname>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <SpawnOrder>k__BackingField; // 0x30
	public bool IsSpectator; // 0x34

	// Properties
	public string Nickname { get; set; }
	public int SpawnOrder { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x566E20 Offset: 0x565420 VA: 0x180566E20
	private void set_Nickname(string value) { }

	[CompilerGenerated]
	// RVA: 0x504CA0 Offset: 0x5032A0 VA: 0x180504CA0
	public string get_Nickname() { }

	[CompilerGenerated]
	// RVA: 0x5C5B70 Offset: 0x5C4170 VA: 0x1805C5B70
	private void set_SpawnOrder(int value) { }

	[CompilerGenerated]
	// RVA: 0x5114B0 Offset: 0x50FAB0 VA: 0x1805114B0
	public int get_SpawnOrder() { }

	// RVA: 0x5DD110 Offset: 0x5DB710 VA: 0x1805DD110
	public void .ctor() { }

	// RVA: 0x5DCFD0 Offset: 0x5DB5D0 VA: 0x1805DCFD0
	public void .ctor(StellarPlayer source) { }

	// RVA: 0x5DCAA0 Offset: 0x5DB0A0 VA: 0x1805DCAA0
	public void AddCharacter(HashString characterID, int costume = 0, bool randomSelection = False) { }

	// RVA: 0x5DCE70 Offset: 0x5DB470 VA: 0x1805DCE70
	public void SetNickname(string nickName) { }

	// RVA: 0x5DCF30 Offset: 0x5DB530 VA: 0x1805DCF30
	public void SetSpawnOrder(int spawnOrder) { }

	// RVA: 0x5DCBC0 Offset: 0x5DB1C0 VA: 0x1805DCBC0
	public static List<StellarPlayer> GetOnePlayerList(HashString characterID, int costume = 0) { }
}
