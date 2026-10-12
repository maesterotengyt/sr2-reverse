// Namespace: 
public class MainMenuSubPanel : SRMonoBehaviour // TypeDefIndex: 3106
{
	// Fields
	public bool Active; // 0x20
	public UINavigator UINavigator; // 0x28
	public StellarUIAnimator Animator; // 0x30
	public CanvasGroup CanvasGroup; // 0x38
	protected MainMenuHub newMainMenu; // 0x40

	// Properties
	protected MainMenu mainMenu { get; }

	// Methods

	// RVA: 0x566D10 Offset: 0x565310 VA: 0x180566D10
	protected MainMenu get_mainMenu() { }

	// RVA: 0x553EB0 Offset: 0x5524B0 VA: 0x180553EB0 Slot: 4
	public virtual void Initialize(MainMenuHub newMainMenu) { }

	// RVA: 0x566C80 Offset: 0x565280 VA: 0x180566C80 Slot: 5
	public virtual void Show() { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 6
	public virtual void UpdatePanel() { }

	// RVA: 0x566BF0 Offset: 0x5651F0 VA: 0x180566BF0 Slot: 7
	public virtual void Hide() { }

	// RVA: 0x566C50 Offset: 0x565250 VA: 0x180566C50
	public void OnDisable() { }

	// RVA: 0x53A8F0 Offset: 0x538EF0 VA: 0x18053A8F0
	public void .ctor() { }
}
