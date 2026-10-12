// Namespace: 
public class MainMenuWorldScreen : SRMonoBehaviour // TypeDefIndex: 3115
{
	// Fields
	public Animator Animator; // 0x20
	protected MainMenuScreen mainMenuScreen; // 0x28

	// Properties
	protected MainMenu mainMenu { get; }

	// Methods

	// RVA: 0x567060 Offset: 0x565660 VA: 0x180567060
	protected MainMenu get_mainMenu() { }

	// RVA: 0x566E20 Offset: 0x565420 VA: 0x180566E20 Slot: 4
	public virtual void Initialize(MainMenuScreen mainMenuScreen) { }

	// RVA: 0x566E30 Offset: 0x565430 VA: 0x180566E30
	protected void RestrictNavigatorToPlayer1(UINavigator navigator) { }

	// RVA: 0x566FB0 Offset: 0x5655B0 VA: 0x180566FB0 Slot: 5
	public virtual void Show() { }

	// RVA: 0x566D70 Offset: 0x565370 VA: 0x180566D70 Slot: 6
	public virtual void Hide() { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 7
	public virtual void UpdateScreen() { }

	// RVA: 0x53A8F0 Offset: 0x538EF0 VA: 0x18053A8F0
	public void .ctor() { }
}
