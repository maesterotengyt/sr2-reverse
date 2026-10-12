// Namespace: 
public class CharacterViewerExtraSettings : MonoBehaviour // TypeDefIndex: 2842
{
	// Fields
	public CharacterViewerPanelType PanelType; // 0x20
	public GameObject SettingsContainer; // 0x28
	public Button AddButton; // 0x30
	public Button RemoveButton; // 0x38
	public RectTransform Content; // 0x40
	public float ListControlSize; // 0x48
	public float ContentExpandYSize; // 0x4C
	public float ContentYOffset; // 0x50
	public RectTransform PanelContainer; // 0x58
	public CharacterViewer CharacterViewer; // 0x60
	public bool IsCPU; // 0x68
	public bool Active; // 0x69
	public int LastSelectedIndex; // 0x6C
	public CharacterViewerAnimationData AnimationData; // 0x70
	private List<CharacterViewerExtraSettingsElement> settingsList; // 0x118
	private int elementCount; // 0x120

	// Methods

	// RVA: 0x729440 Offset: 0x727A40 VA: 0x180729440
	private void OnEnable() { }

	// RVA: 0x7297B0 Offset: 0x727DB0 VA: 0x1807297B0
	public void RefreshCPUInputs() { }

	// RVA: 0x728CC0 Offset: 0x7272C0 VA: 0x180728CC0
	private void AddCPUInputs(int index) { }

	// RVA: 0x72A650 Offset: 0x728C50 VA: 0x18072A650
	private void Start() { }

	// RVA: 0x72A600 Offset: 0x728C00 VA: 0x18072A600
	public void SetSettings(CharacterViewer characterViewer, bool isCPU, RectTransform panel) { }

	// RVA: 0x7299A0 Offset: 0x727FA0 VA: 0x1807299A0
	public void RefreshData() { }

	// RVA: 0x72A050 Offset: 0x728650 VA: 0x18072A050
	public void ResizeList() { }

	// RVA: 0x72A260 Offset: 0x728860 VA: 0x18072A260
	public void SaveChanges() { }

	// RVA: 0x729DD0 Offset: 0x7283D0 VA: 0x180729DD0
	private void ResetChanges(CharacterViewerAnimationEditor editor) { }

	// RVA: 0x7293D0 Offset: 0x7279D0 VA: 0x1807293D0
	private void GetElementCount() { }

	// RVA: 0x729560 Offset: 0x727B60 VA: 0x180729560
	private void PopulateList() { }

	// RVA: 0x728FB0 Offset: 0x7275B0 VA: 0x180728FB0
	private void AddSetting() { }

	// RVA: 0x729B20 Offset: 0x728120 VA: 0x180729B20
	private void RemoveSetting() { }

	// RVA: 0x729DC0 Offset: 0x7283C0 VA: 0x180729DC0
	public void ResetChangesCall(CharacterViewerAnimationEditor editor) { }

	// RVA: 0x729350 Offset: 0x727950 VA: 0x180729350
	public int GetElementCountCall() { }

	// RVA: 0x729550 Offset: 0x727B50 VA: 0x180729550
	public void PopulateListCall() { }

	// RVA: 0x728FA0 Offset: 0x7275A0 VA: 0x180728FA0
	public void AddSettingCall() { }

	// RVA: 0x729B10 Offset: 0x728110 VA: 0x180729B10
	public void RemoveSettingCall() { }

	// RVA: 0x4F3DE0 Offset: 0x4F23E0 VA: 0x1804F3DE0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x72A6E0 Offset: 0x728CE0 VA: 0x18072A6E0
	private bool <SaveChanges>b__23_0(CharacterViewerAnimationData x) { }
}
