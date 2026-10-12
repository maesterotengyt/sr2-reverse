// Namespace: 
public class StellarGameTimeSystem : StellarMonoBehaviour // TypeDefIndex: 3566
{
	// Fields
	private float timeScale; // 0x20
	private bool isFrameByFrameActive; // 0x24
	private bool isAdvancingFrame; // 0x25

	// Properties
	public float TimeScale { get; set; }

	// Methods

	// RVA: 0x5A3A00 Offset: 0x5A2000 VA: 0x1805A3A00
	public float get_TimeScale() { }

	// RVA: 0x5EE510 Offset: 0x5ECB10 VA: 0x1805EE510
	public void set_TimeScale(float value) { }

	// RVA: 0x5EE310 Offset: 0x5EC910 VA: 0x1805EE310
	internal void Initialize() { }

	// RVA: 0x5EE4C0 Offset: 0x5ECAC0 VA: 0x1805EE4C0
	public void RestoreDefaultTime() { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940
	public void Pause() { }

	// RVA: 0x5EE4F0 Offset: 0x5ECAF0 VA: 0x1805EE4F0
	public void Unpause() { }

	// RVA: 0x5EE3F0 Offset: 0x5EC9F0 VA: 0x1805EE3F0
	public bool IsFrameByFrameActive() { }

	// RVA: 0x5EE300 Offset: 0x5EC900 VA: 0x1805EE300
	public void EnableFrameByFrame() { }

	// RVA: 0x5EE270 Offset: 0x5EC870 VA: 0x1805EE270
	public void DisableFrameByFrame() { }

	// RVA: 0x5EE400 Offset: 0x5ECA00 VA: 0x1805EE400
	public void NextFrame() { }

	// RVA: 0x5EE480 Offset: 0x5ECA80 VA: 0x1805EE480
	private void OnUpdateTimeScale(EventOnUpdateTimeScale callback) { }

	[IteratorStateMachine(typeof(StellarGameTimeSystem.<AdvanceFrame>d__15))]
	// RVA: 0x5EE200 Offset: 0x5EC800 VA: 0x1805EE200
	private IEnumerator AdvanceFrame() { }

	// RVA: 0x5EE500 Offset: 0x5ECB00 VA: 0x1805EE500
	public void .ctor() { }
}
