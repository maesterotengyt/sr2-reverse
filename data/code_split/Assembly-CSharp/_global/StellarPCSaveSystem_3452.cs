// Namespace: 
public class StellarPCSaveSystem : StellarPlatformSaveSystem // TypeDefIndex: 3452
{
	// Fields
	private bool saving; // 0x20
	private Dictionary<string, string> pendingSaves; // 0x28

	// Methods

	// RVA: 0x5F1C10 Offset: 0x5F0210 VA: 0x1805F1C10 Slot: 4
	public override void FileExists(string fileName) { }

	// RVA: 0x5F1B00 Offset: 0x5F0100 VA: 0x1805F1B00 Slot: 5
	public override void SaveFile(string fileName, string data) { }

	[AsyncStateMachine(typeof(StellarPCSaveSystem.<AsyncSave>d__4))]
	// RVA: 0x5F1B00 Offset: 0x5F0100 VA: 0x1805F1B00
	private void AsyncSave(string fileName, string data) { }

	// RVA: 0x5F1C90 Offset: 0x5F0290 VA: 0x1805F1C90 Slot: 6
	public override void LoadFile(string fileName) { }

	// RVA: 0x5F1BF0 Offset: 0x5F01F0 VA: 0x1805F1BF0 Slot: 7
	public override void DeleteFile(string fileName) { }

	// RVA: 0x5F1F00 Offset: 0x5F0500 VA: 0x1805F1F00
	public string ProcessFilePath(string fileName) { }

	// RVA: 0x5F1F80 Offset: 0x5F0580 VA: 0x1805F1F80
	public void .ctor() { }
}
