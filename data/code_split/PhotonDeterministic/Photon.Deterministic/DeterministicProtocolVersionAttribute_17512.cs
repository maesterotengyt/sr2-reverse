// Namespace: Photon.Deterministic
[Usage(1, Inherited = False, AllowMultiple = True)]
public sealed class DeterministicProtocolVersionAttribute : Attribute // TypeDefIndex: 17512
{
	// Fields
	private string _version; // 0x10
	private string[] _compatible; // 0x18

	// Properties
	public string Version { get; }

	// Methods

	// RVA: 0x63D470 Offset: 0x63BA70 VA: 0x18063D470
	public string get_Version() { }

	// RVA: 0x1E411D0 Offset: 0x1E3F7D0 VA: 0x181E411D0
	public void .ctor(string version, string[] compatible) { }

	// RVA: 0x20B4710 Offset: 0x20B2D10 VA: 0x1820B4710
	public static DeterministicProtocolVersionAttribute Get(Assembly asm) { }

	// RVA: 0x20B4530 Offset: 0x20B2B30 VA: 0x1820B4530
	public static DeterministicProtocolVersions GetEnum(string version) { }
}
