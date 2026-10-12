// Namespace: Quantum
[Serializable]
public class AssetResource // TypeDefIndex: 11499
{
	// Fields
	public AssetGuid Guid; // 0x10
	public string Path; // 0x18
	internal AssetObject Asset; // 0x20
	internal AtomicInt State; // 0x28

	// Properties
	public AssetObjectIdentifier Identifier { get; }
	public bool IsLoaded { get; }
	internal bool HasPath { get; }

	// Methods

	// RVA: 0x21C55A0 Offset: 0x21C3BA0 VA: 0x1821C55A0
	public AssetObjectIdentifier get_Identifier() { }

	// RVA: 0x21C55D0 Offset: 0x21C3BD0 VA: 0x1821C55D0
	public bool get_IsLoaded() { }

	// RVA: 0x21C5580 Offset: 0x21C3B80 VA: 0x1821C5580
	internal bool get_HasPath() { }

	// RVA: 0x21C5450 Offset: 0x21C3A50 VA: 0x1821C5450
	internal bool TryTransition(int newLoadingState, bool allowReentry = False) { }

	// RVA: 0x4FA6F0 Offset: 0x4F8CF0 VA: 0x1804FA6F0
	public void .ctor() { }
}
