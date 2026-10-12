// Namespace: 
public class IntroBanner : SRMonoBehaviour // TypeDefIndex: 2944
{
	// Fields
	public TMP_Text UsernameText; // 0x20
	public Image BannerCharacterIcon; // 0x28
	public Animator Animator; // 0x30
	public BadgePlatformIcon BadgePlatformIcon; // 0x38
	[CompilerGenerated]
	private bool <Initialized>k__BackingField; // 0x40
	[CompilerGenerated]
	private StellarCharacter <Character>k__BackingField; // 0x48

	// Properties
	public bool Initialized { get; set; }
	public StellarCharacter Character { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x5CC0D0 Offset: 0x5CA6D0 VA: 0x1805CC0D0
	public bool get_Initialized() { }

	[CompilerGenerated]
	// RVA: 0x611280 Offset: 0x60F880 VA: 0x180611280
	public void set_Initialized(bool value) { }

	[CompilerGenerated]
	// RVA: 0x767A40 Offset: 0x766040 VA: 0x180767A40
	public StellarCharacter get_Character() { }

	[CompilerGenerated]
	// RVA: 0x767AB0 Offset: 0x7660B0 VA: 0x180767AB0
	public void set_Character(StellarCharacter value) { }

	// RVA: 0x7674E0 Offset: 0x765AE0 VA: 0x1807674E0
	public void Initialize(StellarCharacter character) { }

	// RVA: 0x767950 Offset: 0x765F50 VA: 0x180767950
	public void ShowBanner() { }

	// RVA: 0x767480 Offset: 0x765A80 VA: 0x180767480
	public void HideBanner() { }

	// RVA: 0x543640 Offset: 0x541C40 VA: 0x180543640
	public void OnHideBannerAnimationEnd() { }

	// RVA: 0x53A8F0 Offset: 0x538EF0 VA: 0x18053A8F0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x7679B0 Offset: 0x765FB0 VA: 0x1807679B0
	private void <Initialize>b__12_0(AsyncOperationHandle handle) { }
}
