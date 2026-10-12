// Namespace: 
public class CharacterSelectSubPanel : SRMonoBehaviour // TypeDefIndex: 3026
{
	// Fields
	public List<CharacterSelectorLocation> Locations; // 0x20
	public UINavigator UINavigator; // 0x28
	public StellarUIAnimator Animator; // 0x30
	protected CharacterSelectBase characterSelect; // 0x38
	protected int selectorNumber; // 0x40

	// Properties
	public CharacterSelector selector { get; }

	// Methods

	// RVA: 0x792320 Offset: 0x790920 VA: 0x180792320
	public CharacterSelector get_selector() { }

	// RVA: 0x791FE0 Offset: 0x7905E0 VA: 0x180791FE0 Slot: 4
	public virtual void Initialize(int selectorNumber, CharacterSelectBase characterSelect) { }

	// RVA: 0x7921B0 Offset: 0x7907B0 VA: 0x1807921B0 Slot: 5
	public virtual void Show() { }

	// RVA: 0x791F30 Offset: 0x790530 VA: 0x180791F30 Slot: 6
	public virtual void Hide() { }

	// RVA: 0x543640 Offset: 0x541C40 VA: 0x180543640 Slot: 7
	public virtual void Clean() { }

	// RVA: 0x792090 Offset: 0x790690 VA: 0x180792090
	public void ReturnToLocation(CharacterSelectorLocation location) { }

	// RVA: 0x53A8F0 Offset: 0x538EF0 VA: 0x18053A8F0
	public void .ctor() { }
}
