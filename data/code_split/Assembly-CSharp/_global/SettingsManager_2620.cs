// Namespace: 
public class SettingsManager : SRMonoBehaviour // TypeDefIndex: 2620
{
	// Fields
	[CompilerGenerated]
	private bool <SavesInitialized>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <CurrentLanguage>k__BackingField; // 0x28

	// Properties
	public bool SavesInitialized { get; set; }
	public string CurrentLanguage { get; set; }
	public StellarSettingsSystem StellarSystem { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x627880 Offset: 0x625E80 VA: 0x180627880
	public bool get_SavesInitialized() { }

	[CompilerGenerated]
	// RVA: 0x4FA000 Offset: 0x4F8600 VA: 0x1804FA000
	public void set_SavesInitialized(bool value) { }

	[CompilerGenerated]
	// RVA: 0x504CA0 Offset: 0x5032A0 VA: 0x180504CA0
	public string get_CurrentLanguage() { }

	[CompilerGenerated]
	// RVA: 0x566E20 Offset: 0x565420 VA: 0x180566E20
	public void set_CurrentLanguage(string value) { }

	// RVA: 0x7088C0 Offset: 0x706EC0 VA: 0x1807088C0
	public StellarSettingsSystem get_StellarSystem() { }

	// RVA: 0x707DE0 Offset: 0x7063E0 VA: 0x180707DE0
	public void ApplySavedSettings() { }

	// RVA: 0x708550 Offset: 0x706B50 VA: 0x180708550
	public void UpdateVolumes() { }

	// RVA: 0x708420 Offset: 0x706A20 VA: 0x180708420
	private void AudioManagerInitialized() { }

	// RVA: 0x53A8F0 Offset: 0x538EF0 VA: 0x18053A8F0
	public void .ctor() { }
}
