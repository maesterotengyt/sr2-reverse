// Namespace: 
public class LogoParadeScreen : MainMenuScreen // TypeDefIndex: 3081
{
	// Fields
	public List<Animator> LogoGroup; // 0x90
	public float LogoDuration; // 0x98
	public float InBetweenDelay; // 0x9C
	private int currentLogoIndex; // 0xA0
	private float currentTimer; // 0xA4
	private bool inBetween; // 0xA8
	private bool firstLogo; // 0xA9

	// Properties
	private StellarInputSystem stellarInputSystem { get; }

	// Methods

	// RVA: 0x5496B0 Offset: 0x547CB0 VA: 0x1805496B0
	private StellarInputSystem get_stellarInputSystem() { }

	// RVA: 0x549350 Offset: 0x547950 VA: 0x180549350 Slot: 7
	public override void Show() { }

	// RVA: 0x5493B0 Offset: 0x5479B0 VA: 0x1805493B0 Slot: 10
	public override void UpdateScreen() { }

	// RVA: 0x5492C0 Offset: 0x5478C0 VA: 0x1805492C0
	public void ChangeScreen() { }

	// RVA: 0x549330 Offset: 0x547930 VA: 0x180549330 Slot: 8
	public override void Hide() { }

	// RVA: 0x549620 Offset: 0x547C20 VA: 0x180549620
	public void .ctor() { }
}
