// Namespace: Platforms.Xbox
public class MicrosoftStoreSaveSystem : StellarPlatformSaveSystem // TypeDefIndex: 3766
{
	// Fields
	private const string MainContainerName = "MainContainer";
	private MicrosoftStoreSystem _microsoftSeriesSystem; // 0x20
	private XGameSaveProviderHandle _providerHandle; // 0x28

	// Methods

	[AsyncStateMachine(typeof(MicrosoftStoreSaveSystem.<InitAsync>d__4))]
	// RVA: 0x649180 Offset: 0x647780 VA: 0x180649180
	public Task InitAsync(MicrosoftStoreSystem microsoftSeriesSystem) { }

	// RVA: 0x648C10 Offset: 0x647210 VA: 0x180648C10 Slot: 4
	public override void FileExists(string fileName) { }

	// RVA: 0x649650 Offset: 0x647C50 VA: 0x180649650 Slot: 5
	public override void SaveFile(string fileName, string data) { }

	// RVA: 0x649270 Offset: 0x647870 VA: 0x180649270 Slot: 6
	public override void LoadFile(string fileName) { }

	// RVA: 0x648BC0 Offset: 0x6471C0 VA: 0x180648BC0 Slot: 7
	public override void DeleteFile(string fileName) { }

	// RVA: 0x648AA0 Offset: 0x6470A0 VA: 0x180648AA0
	public bool CheckFile(string fileName) { }

	// RVA: 0x648A40 Offset: 0x647040 VA: 0x180648A40
	private string CheckFileName(string path) { }

	// RVA: 0x648D70 Offset: 0x647370 VA: 0x180648D70
	public string[] GetAllSaveDataFiles(string containerName = "MainContainer") { }

	// RVA: 0x649F70 Offset: 0x648570 VA: 0x180649F70
	private bool XboxSave(string fileName, byte[] data, string containerName = "MainContainer") { }

	// RVA: 0x649DB0 Offset: 0x6483B0 VA: 0x180649DB0
	private byte[] XboxLoad(string fileName, string containerName = "MainContainer") { }

	// RVA: 0x649A60 Offset: 0x648060 VA: 0x180649A60
	public bool XboxDelete(string fileName, string containerName = "MainContainer") { }

	// RVA: 0x649710 Offset: 0x647D10 VA: 0x180649710
	public void Shutdown() { }

	// RVA: 0x649020 Offset: 0x647620 VA: 0x180649020
	private XGameSaveBlobInfo[] GetBlobInfo(XGameSaveContainerHandle containerHandle, string blobName) { }

	// RVA: 0x539650 Offset: 0x537C50 VA: 0x180539650
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x649920 Offset: 0x647F20 VA: 0x180649920
	internal static bool <XboxSave>g__PerformXboxSave|12_0(ref MicrosoftStoreSaveSystem.<>c__DisplayClass12_0 ) { }

	[CompilerGenerated]
	// RVA: 0x6497D0 Offset: 0x647DD0 VA: 0x1806497D0
	internal static bool <XboxDelete>g__PerformXboxDelete|14_0(ref MicrosoftStoreSaveSystem.<>c__DisplayClass14_0 ) { }
}
