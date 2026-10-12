// Namespace: 
[Serializable]
public class Panel // TypeDefIndex: 2780
{
	// Fields
	[SerializeField]
	public AssetReference SpriteReference; // 0x10
	public Transition Transition; // 0x18
	public float FadeSpeed; // 0x1C
	public List<CutsceneDialogue> CutsceneDialogues; // 0x20
	public HashString MusicEventID; // 0x28
	public bool StopPreviousMusicEvent; // 0x38
	public HashString PanelSFX; // 0x40
	public bool hasScreenText; // 0x50
	public LocalizedString ScreenText; // 0x58
	public float ScreenTextDuration; // 0x60

	// Methods

	// RVA: 0x735A80 Offset: 0x734080 VA: 0x180735A80
	public void .ctor() { }
}
