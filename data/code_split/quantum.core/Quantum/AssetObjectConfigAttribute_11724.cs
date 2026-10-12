// Namespace: Quantum
public class AssetObjectConfigAttribute : Attribute // TypeDefIndex: 11724
{
	// Fields
	private bool _generateLinkingScripts; // 0x10
	private bool _generateAssetCreateMenu; // 0x11
	private bool _generateAssetResetMethod; // 0x12
	private bool _generateAsMainScript; // 0x13
	private int _customCreateAssetMenuOrder; // 0x14

	// Properties
	public bool GenerateLinkingScripts { set; }
	public bool GenerateAssetCreateMenu { set; }
	public bool GenerateAssetResetMethod { set; }
	public bool GenerateAsMainScript { set; }

	// Methods

	// RVA: 0x667A30 Offset: 0x666030 VA: 0x180667A30
	public void set_GenerateLinkingScripts(bool value) { }

	// RVA: 0x6811B0 Offset: 0x67F7B0 VA: 0x1806811B0
	public void set_GenerateAssetCreateMenu(bool value) { }

	// RVA: 0x2049BD0 Offset: 0x20481D0 VA: 0x182049BD0
	public void set_GenerateAssetResetMethod(bool value) { }

	// RVA: 0x2221FC0 Offset: 0x22205C0 VA: 0x182221FC0
	public void set_GenerateAsMainScript(bool value) { }

	// RVA: 0x2221FA0 Offset: 0x22205A0 VA: 0x182221FA0
	public void .ctor() { }
}
