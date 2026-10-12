// Namespace: Quantum
[Serializable]
public class BossFightCameraManagerData : CameraManagerData // TypeDefIndex: 10352
{
	// Fields
	[Header("Boss Fight specific Camera Settings")]
	public FPVector2 ViewportPosition; // 0xC0

	// Methods

	// RVA: 0x217B8B0 Offset: 0x2179EB0 VA: 0x18217B8B0 Slot: 6
	public override SimpleAABB UpdateCameraRect(Frame frame, GlobalCameraSettingsData globalData, bool forceUpdate = False) { }

	// RVA: 0x217BAB0 Offset: 0x217A0B0 VA: 0x18217BAB0
	public void .ctor() { }
}
