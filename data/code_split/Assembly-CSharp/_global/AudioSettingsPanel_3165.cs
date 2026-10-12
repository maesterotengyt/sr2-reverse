// Namespace: 
public class AudioSettingsPanel : SettingsSubPanel // TypeDefIndex: 3165
{
	// Fields
	public StellarSliderOption MasterVolumeSlider; // 0x50
	public StellarSliderOption MusicVolumeSlider; // 0x58
	public StellarSliderOption AmbientVolumeSlider; // 0x60
	public StellarSliderOption SFXVolumeSlider; // 0x68
	public StellarSliderOption VOVolumeSlider; // 0x70
	public bool fromPauseMenu; // 0x78
	private bool audioChanged; // 0x79
	private Coroutine saveCoroutine; // 0x80
	private const float saveDelay = 1.5;

	// Methods

	// RVA: 0x569180 Offset: 0x567780 VA: 0x180569180 Slot: 5
	public override void Show() { }

	// RVA: 0x5693A0 Offset: 0x5679A0 VA: 0x1805693A0 Slot: 7
	protected override void Update() { }

	[IteratorStateMachine(typeof(AudioSettingsPanel.<SaveSettingsWithDelay>d__11))]
	// RVA: 0x569110 Offset: 0x567710 VA: 0x180569110
	private IEnumerator SaveSettingsWithDelay() { }

	// RVA: 0x568A80 Offset: 0x567080 VA: 0x180568A80
	public void MasterVolumeChanged(float value) { }

	// RVA: 0x568CB0 Offset: 0x5672B0 VA: 0x180568CB0
	public void MusicVolumeChanged(float value) { }

	// RVA: 0x568850 Offset: 0x566E50 VA: 0x180568850
	public void AmbientVolumeChanged(float value) { }

	// RVA: 0x568EE0 Offset: 0x5674E0 VA: 0x180568EE0
	public void SFXVolumeChanged(float value) { }

	// RVA: 0x5694A0 Offset: 0x567AA0 VA: 0x1805694A0
	public void VOVolumeChanged(float value) { }

	// RVA: 0x568BE0 Offset: 0x5671E0 VA: 0x180568BE0
	public void MasterVolumeStepIncrease() { }

	// RVA: 0x568B10 Offset: 0x567110 VA: 0x180568B10
	public void MasterVolumeStepDecrease() { }

	// RVA: 0x568E10 Offset: 0x567410 VA: 0x180568E10
	public void MusicVolumeStepIncrease() { }

	// RVA: 0x568D40 Offset: 0x567340 VA: 0x180568D40
	public void MusicVolumeStepDecrease() { }

	// RVA: 0x5689B0 Offset: 0x566FB0 VA: 0x1805689B0
	public void AmbientVolumeStepIncrease() { }

	// RVA: 0x5688E0 Offset: 0x566EE0 VA: 0x1805688E0
	public void AmbientVolumeStepDecrease() { }

	// RVA: 0x569040 Offset: 0x567640 VA: 0x180569040
	public void SFXVolumeStepIncrease() { }

	// RVA: 0x568F70 Offset: 0x567570 VA: 0x180568F70
	public void SFXVolumeStepDecrease() { }

	// RVA: 0x569600 Offset: 0x567C00 VA: 0x180569600
	public void VOVolumeStepIncrease() { }

	// RVA: 0x569530 Offset: 0x567B30 VA: 0x180569530
	public void VOVolumeStepDecrease() { }

	// RVA: 0x539650 Offset: 0x537C50 VA: 0x180539650
	public void .ctor() { }
}
