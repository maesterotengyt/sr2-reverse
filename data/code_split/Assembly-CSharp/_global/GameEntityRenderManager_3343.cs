// Namespace: 
public class GameEntityRenderManager : MonoBehaviour // TypeDefIndex: 3343
{
	// Fields
	public GameEntityRenderer[] Objects; // 0x20
	[CompilerGenerated]
	private bool <IsVisible>k__BackingField; // 0x28
	public TintData TintActionsContainer; // 0x30
	private static readonly int overallTintBoolParamID; // 0x0
	private static readonly int overallTintParamID; // 0x4
	private static readonly int gameplayTintBoolParamID; // 0x8
	private static readonly int gameplayTintParamID; // 0xC
	private static readonly int gameplayTintDarkParamID; // 0x10
	private static readonly int statusTintBoolParamID; // 0x14
	private static readonly int statusTintParamID; // 0x18
	private static readonly int statusTintDarkParamID; // 0x1C
	private static readonly int entityTintBoolParamID; // 0x20
	private static readonly int entityTintParamID; // 0x24
	private static readonly int entityTintDarkParamID; // 0x28
	private MaterialPropertyBlock materialPropertyBlock; // 0x38
	private ActiveTint overallTint; // 0x40
	private ActiveTint statusTint; // 0x78
	private ActiveTint gameplayTint; // 0xB0
	private ActiveTint entityTint; // 0xE8

	// Properties
	public bool IsVisible { get; set; }
	public Tint CurrentOverallTint { get; }
	public Tint CurrentStatusTint { get; }
	public Tint CurrentGameplayTint { get; }
	public Tint CurrentEntityTint { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x5BA5A0 Offset: 0x5B8BA0 VA: 0x1805BA5A0
	public bool get_IsVisible() { }

	[CompilerGenerated]
	// RVA: 0x5BA5B0 Offset: 0x5B8BB0 VA: 0x1805BA5B0
	public void set_IsVisible(bool value) { }

	// RVA: 0x5BA550 Offset: 0x5B8B50 VA: 0x1805BA550
	public Tint get_CurrentOverallTint() { }

	// RVA: 0x5BA570 Offset: 0x5B8B70 VA: 0x1805BA570
	public Tint get_CurrentStatusTint() { }

	// RVA: 0x5BA520 Offset: 0x5B8B20 VA: 0x1805BA520
	public Tint get_CurrentGameplayTint() { }

	// RVA: 0x5BA4F0 Offset: 0x5B8AF0 VA: 0x1805BA4F0
	public Tint get_CurrentEntityTint() { }

	// RVA: 0x5B9060 Offset: 0x5B7660 VA: 0x1805B9060
	private void Awake() { }

	// RVA: 0x5B9F00 Offset: 0x5B8500 VA: 0x1805B9F00
	public void ToggleVisibility(bool visible) { }

	// RVA: 0x5B93B0 Offset: 0x5B79B0 VA: 0x1805B93B0
	public void PlayTint(int tintHash) { }

	// RVA: 0x5B9CC0 Offset: 0x5B82C0 VA: 0x1805B9CC0
	public void StopTint(TintCategories tintCategory) { }

	// RVA: 0x5B8CA0 Offset: 0x5B72A0 VA: 0x1805B8CA0
	public void ApplyColor(Tint tintAction, float currentFrame) { }

	// RVA: 0x5B8EE0 Offset: 0x5B74E0 VA: 0x1805B8EE0
	public ActiveTint ApplyTint(ActiveTint activeTint) { }

	// RVA: 0x5BA060 Offset: 0x5B8660 VA: 0x1805BA060
	private void Update() { }

	// RVA: 0x5B9D80 Offset: 0x5B8380 VA: 0x1805B9D80
	public void TintAllMaterials(Color color, TintCategories tintCategory) { }

	// RVA: 0x5B95D0 Offset: 0x5B7BD0 VA: 0x1805B95D0
	public void SetBooleanAllMaterials(bool active, TintCategories tintCategory) { }

	// RVA: 0x5B9B70 Offset: 0x5B8170 VA: 0x1805B9B70
	public void SetTintColor(Color color, Renderer renderer, TintCategories tintCategory) { }

	// RVA: 0x5B90D0 Offset: 0x5B76D0 VA: 0x1805B90D0
	public int GetParameter(ParamType type, TintCategories tintCategory) { }

	// RVA: 0x5B97D0 Offset: 0x5B7DD0 VA: 0x1805B97D0
	public void SetTintBool(bool active, Renderer renderer, TintCategories tintCategory) { }

	// RVA: 0x5B9790 Offset: 0x5B7D90 VA: 0x1805B9790
	private void SetDarkColor(bool active, Tint tint, int paramDarkColorID) { }

	// RVA: 0x5B90C0 Offset: 0x5B76C0 VA: 0x1805B90C0
	private void ClearTint(TintCategories tintCategory) { }

	// RVA: 0x5BA490 Offset: 0x5B8A90 VA: 0x1805BA490
	public void .ctor() { }

	// RVA: 0x5BA280 Offset: 0x5B8880 VA: 0x1805BA280
	private static void .cctor() { }
}
