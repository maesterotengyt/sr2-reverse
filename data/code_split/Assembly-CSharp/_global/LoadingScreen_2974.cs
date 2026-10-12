// Namespace: 
public class LoadingScreen : UIScreen // TypeDefIndex: 2974
{
	// Fields
	[HideInInspector]
	public bool LoadingScreenActive; // 0x58
	private bool loadingBarActive; // 0x59

	// Properties
	protected UIManager uiManager { get; }
	protected SceneLoader sceneLoader { get; }

	// Methods

	// RVA: 0x777D60 Offset: 0x776360 VA: 0x180777D60
	protected UIManager get_uiManager() { }

	// RVA: 0x777D10 Offset: 0x776310 VA: 0x180777D10
	protected SceneLoader get_sceneLoader() { }

	// RVA: 0x777B40 Offset: 0x776140 VA: 0x180777B40
	private void Awake() { }

	// RVA: 0x777C70 Offset: 0x776270 VA: 0x180777C70 Slot: 13
	public virtual void ShowScreen(bool immediate = False) { }

	// RVA: 0x777BB0 Offset: 0x7761B0 VA: 0x180777BB0 Slot: 14
	public virtual void HideScreen(bool immediate = False) { }

	// RVA: 0x777B70 Offset: 0x776170 VA: 0x180777B70 Slot: 12
	public override void Disable() { }

	// RVA: 0x5A1C80 Offset: 0x5A0280 VA: 0x1805A1C80
	public void .ctor() { }
}
