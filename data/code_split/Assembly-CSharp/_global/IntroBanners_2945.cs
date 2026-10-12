// Namespace: 
public class IntroBanners : SRMonoBehaviour // TypeDefIndex: 2945
{
	// Fields
	public List<IntroBanner> Banners; // 0x20
	private List<EntityRef> characterRefs; // 0x28
	private List<StellarCharacterData> charactersData; // 0x30
	private bool isIntroBannerShown; // 0x38

	// Methods

	// RVA: 0x767F50 Offset: 0x766550 VA: 0x180767F50
	public void Initialization() { }

	// RVA: 0x768560 Offset: 0x766B60 VA: 0x180768560
	private void OnCharacterCreation(StellarCharacterData characterData) { }

	// RVA: 0x7681A0 Offset: 0x7667A0 VA: 0x1807681A0
	private void InitializeBanner(EntityRef entity) { }

	// RVA: 0x767D20 Offset: 0x766320 VA: 0x180767D20
	private Nullable<float> GetCharacterSpawnPositionX(Frame frame, EntityRef entity) { }

	// RVA: 0x767B20 Offset: 0x766120 VA: 0x180767B20
	private StellarCharacterData GetCharacterData(EntityRef entity) { }

	// RVA: 0x768900 Offset: 0x766F00 VA: 0x180768900
	private void ShowCountdownBannerAnimation(EventShowCountdownBannerAnimation callback) { }

	// RVA: 0x768390 Offset: 0x766990 VA: 0x180768390
	private void InsertionSortCharacterRefs(Frame frame) { }

	// RVA: 0x7687A0 Offset: 0x766DA0 VA: 0x1807687A0
	private void OnPlayersInputEnabled(EventOnPlayersInputEnabled callback) { }

	// RVA: 0x7687B0 Offset: 0x766DB0 VA: 0x1807687B0
	public void ShowBanners() { }

	// RVA: 0x767DD0 Offset: 0x7663D0 VA: 0x180767DD0
	public void HideBanners() { }

	// RVA: 0x768620 Offset: 0x766C20 VA: 0x180768620
	private void OnDestroy() { }

	// RVA: 0x768E40 Offset: 0x767440 VA: 0x180768E40
	public void .ctor() { }
}
