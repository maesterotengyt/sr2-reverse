// Namespace: 
public abstract class CharacterViewerAnimationListElement : MonoBehaviour // TypeDefIndex: 3588
{
	// Fields
	public TMP_Text NameText; // 0x20
	public CharacterViewerAnimationData AnimationData; // 0x28
	public int Index; // 0xD0
	public bool Active; // 0xD4

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void LoadCharacterData(CharacterViewerAnimationData animationData);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Show(int index);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void Select(bool selected);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void Highlight(bool highlighted);

	// RVA: 0x4F3DE0 Offset: 0x4F23E0 VA: 0x1804F3DE0
	protected void .ctor() { }
}
