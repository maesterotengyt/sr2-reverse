// Namespace: 
public class SaveManager : SRMonoBehaviour // TypeDefIndex: 2619
{
	// Fields
	public DefaultSaveData DefaultSaveDataFile; // 0x20
	public DefaultSaveData DefaultSaveData; // 0x28
	public SaveData Data; // 0x30
	public string EncryptedSaveData; // 0x38
	[CompilerGenerated]
	private static Action SaveDataReady; // 0x0
	private const string saveFileName = "SaveData";

	// Properties
	private StellarSaveSystem stellarSystem { get; }

	// Methods

	// RVA: 0x7065B0 Offset: 0x704BB0 VA: 0x1807065B0
	private StellarSaveSystem get_stellarSystem() { }

	[CompilerGenerated]
	// RVA: 0x7064F0 Offset: 0x704AF0 VA: 0x1807064F0
	public static void add_SaveDataReady(Action value) { }

	[CompilerGenerated]
	// RVA: 0x706600 Offset: 0x704C00 VA: 0x180706600
	public static void remove_SaveDataReady(Action value) { }

	// RVA: 0x705BA0 Offset: 0x7041A0 VA: 0x180705BA0
	public void Initialize() { }

	// RVA: 0x706310 Offset: 0x704910 VA: 0x180706310
	public void Save() { }

	// RVA: 0x706080 Offset: 0x704680 VA: 0x180706080
	public void LoadSaveData() { }

	// RVA: 0x705910 Offset: 0x703F10 VA: 0x180705910
	private void EncryptedSave(string data) { }

	// RVA: 0x705C30 Offset: 0x704230 VA: 0x180705C30
	private void LoadResult(string data) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940
	private void SaveDataValidations() { }

	// RVA: 0x705A40 Offset: 0x704040 VA: 0x180705A40
	private void FirstSaveFileResult(bool success) { }

	// RVA: 0x706420 Offset: 0x704A20 VA: 0x180706420
	private void Update() { }

	// RVA: 0x53A8F0 Offset: 0x538EF0 VA: 0x18053A8F0
	public void .ctor() { }
}
