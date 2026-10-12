// Namespace: 
public class StellarStageLayoutLoader : StellarMonoBehaviour // TypeDefIndex: 3546
{
	// Fields
	[SerializeField]
	public StageData StageData; // 0x20
	public string LayoutID; // 0x28
	public bool NotifySceneLoaded; // 0x30

	// Methods

	// RVA: 0x5F6C10 Offset: 0x5F5210 VA: 0x1805F6C10
	public void Start() { }

	// RVA: 0x5F6550 Offset: 0x5F4B50 VA: 0x1805F6550
	public void LoadStageLayout() { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 4
	public virtual void SetLayoutData() { }

	// RVA: 0x5F68A0 Offset: 0x5F4EA0 VA: 0x1805F68A0
	private void OnLayoutSceneLoaded(string scenePath) { }

	// RVA: 0x5F6A40 Offset: 0x5F5040 VA: 0x1805F6A40
	private string SetSceneToLoad() { }

	// RVA: 0x5F6320 Offset: 0x5F4920 VA: 0x1805F6320
	private StageLayout GetCurrentLayout() { }

	// RVA: 0x5F62E0 Offset: 0x5F48E0 VA: 0x1805F62E0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x53A8F0 Offset: 0x538EF0 VA: 0x18053A8F0
	public void .ctor() { }
}
