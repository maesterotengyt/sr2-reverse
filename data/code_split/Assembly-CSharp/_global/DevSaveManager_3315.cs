// Namespace: 
public static class DevSaveManager // TypeDefIndex: 3315
{
	// Fields
	private static string devSavePath; // 0x0
	private static int currentVersion; // 0x8

	// Methods

	// RVA: 0x5B23C0 Offset: 0x5B09C0 VA: 0x1805B23C0
	public static void SaveDevSave(DevSaveManager.DeveloperSave data) { }

	// RVA: 0x5B22A0 Offset: 0x5B08A0 VA: 0x1805B22A0
	public static DevSaveManager.DeveloperSave LoadDevSave() { }

	// RVA: -1 Offset: -1
	public static void Save<T>(T data, string path) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB0DD70 Offset: 0xB0C370 VA: 0x180B0DD70
	|-DevSaveManager.Save<GameEntityEditorSaveData>
	|
	|-RVA: 0xB0DE20 Offset: 0xB0C420 VA: 0x180B0DE20
	|-DevSaveManager.Save<GameEntityEditorWorkspaces>
	|
	|-RVA: 0xB0DED0 Offset: 0xB0C4D0 VA: 0x180B0DED0
	|-DevSaveManager.Save<__Il2CppFullySharedGenericStructType>
	|
	|-RVA: 0xB0DCA0 Offset: 0xB0C2A0 VA: 0x180B0DCA0
	|-DevSaveManager.Save<DevSaveManager.DeveloperSave>
	*/

	// RVA: -1 Offset: -1
	public static T Load<T>(string path) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB0D9E0 Offset: 0xB0BFE0 VA: 0x180B0D9E0
	|-DevSaveManager.Load<GameEntityEditorSaveData>
	|
	|-RVA: 0xB0DAA0 Offset: 0xB0C0A0 VA: 0x180B0DAA0
	|-DevSaveManager.Load<GameEntityEditorWorkspaces>
	|
	|-RVA: 0xB0DB40 Offset: 0xB0C140 VA: 0x180B0DB40
	|-DevSaveManager.Load<__Il2CppFullySharedGenericStructType>
	|
	|-RVA: 0xB0D8E0 Offset: 0xB0BEE0 VA: 0x180B0D8E0
	|-DevSaveManager.Load<DevSaveManager.DeveloperSave>
	*/

	// RVA: 0x5B2010 Offset: 0x5B0610 VA: 0x1805B2010
	public static DevSaveManager.DeveloperSave GetDefaultDeveloperSave() { }

	// RVA: 0x5B2460 Offset: 0x5B0A60 VA: 0x1805B2460
	private static void .cctor() { }
}
