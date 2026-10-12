// Namespace: BrainFailProductions.PolyFew.AsImpL
public class PathSettings : MonoBehaviour // TypeDefIndex: 4125
{
	// Fields
	[Tooltip("Default root path for models")]
	public RootPathEnum defaultRootPath; // 0x20
	[Tooltip("Root path for models on mobile devices")]
	public RootPathEnum mobileRootPath; // 0x24

	// Properties
	public string RootPath { get; }

	// Methods

	// RVA: 0x6C01B0 Offset: 0x6BE7B0 VA: 0x1806C01B0
	public string get_RootPath() { }

	// RVA: 0x6C0030 Offset: 0x6BE630 VA: 0x1806C0030
	public static PathSettings FindPathComponent(GameObject obj) { }

	// RVA: 0x6C0130 Offset: 0x6BE730 VA: 0x1806C0130
	public string FullPath(string path) { }

	// RVA: 0x4F3DE0 Offset: 0x4F23E0 VA: 0x1804F3DE0
	public void .ctor() { }
}
