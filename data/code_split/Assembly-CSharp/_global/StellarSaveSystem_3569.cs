// Namespace: 
public class StellarSaveSystem : StellarMonoBehaviour // TypeDefIndex: 3569
{
	// Fields
	public static StellarSaveSystem.OnStartedSavingData StartedSavingData; // 0x0
	public static StellarSaveSystem.OnLoadDataResult LoadDataResult; // 0x8
	private string backupSavePath; // 0x20

	// Methods

	// RVA: 0x5F3100 Offset: 0x5F1700 VA: 0x1805F3100
	private StellarPlatformSaveSystem GetSaveSystem() { }

	// RVA: -1 Offset: -1
	public void SaveData<T>(object data, string fileName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC40FE0 Offset: 0xC3F5E0 VA: 0x180C40FE0
	|-StellarSaveSystem.SaveData<object>
	*/

	// RVA: 0x5F31C0 Offset: 0x5F17C0 VA: 0x1805F31C0
	public void LoadData(string fileName) { }

	// RVA: 0x5F3630 Offset: 0x5F1C30 VA: 0x1805F3630
	private void SaveDataExist(string fileName, bool exist) { }

	// RVA: 0x5F33D0 Offset: 0x5F19D0 VA: 0x1805F33D0
	private void PlaformSaveDataLoaded(string data) { }

	// RVA: 0x5F2BA0 Offset: 0x5F11A0 VA: 0x1805F2BA0
	public void BackupSave(string filepath) { }

	// RVA: 0x5F3A00 Offset: 0x5F2000 VA: 0x1805F3A00
	private void SaveDataLoadedForBackup(string data) { }

	// RVA: -1 Offset: -1
	public string ObjectToString<T>(object data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC40E70 Offset: 0xC3F470 VA: 0x180C40E70
	|-StellarSaveSystem.ObjectToString<object>
	*/

	// RVA: -1 Offset: -1
	public T StringToObject<T>(string data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC410C0 Offset: 0xC3F6C0 VA: 0x180C410C0
	|-StellarSaveSystem.StringToObject<object>
	*/

	// RVA: 0x5F3000 Offset: 0x5F1600 VA: 0x1805F3000
	private string EncryptData(string toEncrypt) { }

	// RVA: 0x5F2EF0 Offset: 0x5F14F0 VA: 0x1805F2EF0
	private string DecryptData(string toDecrypt) { }

	// RVA: 0x5F2DC0 Offset: 0x5F13C0 VA: 0x1805F2DC0
	private RijndaelManaged CreateRijndaelManaged() { }

	// RVA: 0x5F3160 Offset: 0x5F1760 VA: 0x1805F3160
	private bool IsSaveEncrypted(string data) { }

	// RVA: 0x53A8F0 Offset: 0x538EF0 VA: 0x18053A8F0
	public void .ctor() { }
}
