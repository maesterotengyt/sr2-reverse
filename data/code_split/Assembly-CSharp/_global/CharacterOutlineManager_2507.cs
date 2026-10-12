// Namespace: 
public class CharacterOutlineManager : SRMonoBehaviour // TypeDefIndex: 2507
{
	// Fields
	public const string OutlineColorParamID = "_Outline_Color_Default";
	public const string OutlineThicknessMultiplierParamID = "_OutlineThicknessMultiplier";
	public GameEntityManager GameEntityManager; // 0x20
	public OutlinesData OutlinesData; // 0x28
	private OutlineColor outlineColorSetting; // 0x30
	private OutlineVisibility outlineVisibilitySetting; // 0x34
	private StellarCharacterData characterData; // 0x38
	private MaterialPropertyBlock materialPropertyBlock; // 0x1B8

	// Methods

	// RVA: 0x629180 Offset: 0x627780 VA: 0x180629180
	private void Awake() { }

	// RVA: 0x6291F0 Offset: 0x6277F0 VA: 0x1806291F0
	public void Initialize(StellarCharacterData initialCharacterData) { }

	// RVA: 0x629280 Offset: 0x627880 VA: 0x180629280
	private void UpdateOutlineSettings() { }

	// RVA: 0x53A8F0 Offset: 0x538EF0 VA: 0x18053A8F0
	public void .ctor() { }
}
