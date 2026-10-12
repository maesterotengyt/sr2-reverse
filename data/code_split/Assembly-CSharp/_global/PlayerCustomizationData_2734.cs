// Namespace: 
public class PlayerCustomizationData : ScriptableObject // TypeDefIndex: 2734
{
	// Fields
	public List<BadgeBackgroundData> Backgrounds; // 0x18
	public List<BadgeTrailData> Trails; // 0x20
	public List<BadgeIconData> Icons; // 0x28
	public List<BadgeTitleData> Titles; // 0x30
	public List<CatchPhraseData> CatchPhrases; // 0x38
	public List<EmoteData> Emotes; // 0x40
	public Sprite DefaultSkinMiniaturePreview; // 0x48

	// Methods

	// RVA: 0x736CD0 Offset: 0x7352D0 VA: 0x180736CD0
	public PlayerCustomization StringToPlayerCustomization(string dataString) { }

	// RVA: 0x736510 Offset: 0x734B10 VA: 0x180736510
	public PlayerCustomization GetPlayerCustomization(int title, int background, int icon, int catchPhrase, int trail) { }

	// RVA: 0x735B00 Offset: 0x734100 VA: 0x180735B00
	public BadgeBackgroundData GetBackground(HashString ID) { }

	// RVA: 0x735CE0 Offset: 0x7342E0 VA: 0x180735CE0
	public BadgeBackgroundData GetBackground(int index) { }

	// RVA: 0x736A00 Offset: 0x735000 VA: 0x180736A00
	public BadgeTrailData GetTrail(HashString ID) { }

	// RVA: 0x736C30 Offset: 0x735230 VA: 0x180736C30
	public BadgeTrailData GetTrail(int index) { }

	// RVA: 0x736290 Offset: 0x734890 VA: 0x180736290
	public BadgeIconData GetIcon(HashString ID) { }

	// RVA: 0x736470 Offset: 0x734A70 VA: 0x180736470
	public BadgeIconData GetIcon(int index) { }

	// RVA: 0x736820 Offset: 0x734E20 VA: 0x180736820
	public BadgeTitleData GetTitle(HashString ID) { }

	// RVA: 0x736780 Offset: 0x734D80 VA: 0x180736780
	public BadgeTitleData GetTitle(int index) { }

	// RVA: 0x735E60 Offset: 0x734460 VA: 0x180735E60
	public CatchPhraseData GetCatchPhrase(HashString ID) { }

	// RVA: 0x735DC0 Offset: 0x7343C0 VA: 0x180735DC0
	public CatchPhraseData GetCatchPhrase(int index) { }

	// RVA: 0x735D80 Offset: 0x734380 VA: 0x180735D80
	public string GetCatchPhraseString(HashString catchPhraseID) { }

	// RVA: 0x736040 Offset: 0x734640 VA: 0x180736040
	public EmoteData GetEmote(HashString ID) { }

	// RVA: 0x736200 Offset: 0x734800 VA: 0x180736200
	public EmoteData GetEmote(int index) { }

	// RVA: 0x503080 Offset: 0x501680 VA: 0x180503080
	public void .ctor() { }
}
