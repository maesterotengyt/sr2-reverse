// Namespace: 
public class StellarIconsManager : StellarMonoBehaviour // TypeDefIndex: 3685
{
	// Fields
	public static StellarIconsManager.OnRefreshButtonIcons RefreshedButtonIcons; // 0x0
	private List<ButtonIconRef> buttonIconRefs; // 0x20
	private bool singlePlayerValidation; // 0x28

	// Methods

	// RVA: 0x61D0E0 Offset: 0x61B6E0 VA: 0x18061D0E0
	private void Start() { }

	// RVA: 0x61C850 Offset: 0x61AE50 VA: 0x18061C850
	public void OnLoadingScene() { }

	// RVA: 0x61C8B0 Offset: 0x61AEB0 VA: 0x18061C8B0
	public void RefreshButtonIcons() { }

	// RVA: 0x61C140 Offset: 0x61A740 VA: 0x18061C140
	public Sprite GetUIIcon(UIKey key, int playerIndex = -1) { }

	// RVA: 0x61B8B0 Offset: 0x619EB0 VA: 0x18061B8B0
	private Sprite GetDefaultUIIcon(UIKey key) { }

	// RVA: 0x61B610 Offset: 0x619C10 VA: 0x18061B610
	public Sprite GetControllerKeyIcon(ControllerKey controllerKey, int playerIndex = -1) { }

	// RVA: 0x61CE70 Offset: 0x61B470 VA: 0x18061CE70
	public void SetButtonIcon(Image image, UIKey uiKey, int playerIndex = -1) { }

	// RVA: 0x61CB30 Offset: 0x61B130 VA: 0x18061CB30
	public void SetButtonIcon(Image image, InputFlag inputFlag, int playerIndex = -1) { }

	// RVA: 0x61CDA0 Offset: 0x61B3A0 VA: 0x18061CDA0
	public void SetButtonIcon(Image image, Key key, int playerIndex = -1, int style = 1) { }

	// RVA: 0x61BC40 Offset: 0x61A240 VA: 0x18061BC40
	public Sprite GetGameplayIcon(InputFlag inputFlag, int playerIndex = -1, int style = 1) { }

	// RVA: 0x61C730 Offset: 0x61AD30 VA: 0x18061C730
	private void OnDestroy() { }

	// RVA: 0x61D200 Offset: 0x61B800 VA: 0x18061D200
	public void .ctor() { }
}
