// Namespace: Quantum
public struct SpeedRunnersBlastzone : IComponent // TypeDefIndex: 10035
{
	// Fields
	[HideInInspector]
	public QBoolean Active; // 0x0
	[HideInInspector]
	public QBoolean IsInSuddenDeath; // 0x4
	[HideInInspector]
	public FP SuddenDeathMultiplier; // 0x10
	[HideInInspector]
	public FP TimeToStartSuddenDeath; // 0x18
	[HideInInspector]
	public QBoolean TimerSuddenDeath; // 0x8

	// Methods

	// RVA: 0x212BA10 Offset: 0x212A010 VA: 0x18212BA10 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x212BFC0 Offset: 0x212A5C0 VA: 0x18212BFC0
	public static void Serialize(void* ptr, FrameSerializer serializer) { }

	// RVA: 0x212C170 Offset: 0x212A770 VA: 0x18212C170
	public static bool TryFind(Frame frame, out SpeedRunnersBlastzone* speedRunnersBlastzone) { }

	// RVA: 0x212BAC0 Offset: 0x212A0C0 VA: 0x18212BAC0
	public void Initialize(Frame frame) { }

	// RVA: 0x212C2C0 Offset: 0x212A8C0 VA: 0x18212C2C0
	public void UpdateBlastzone(Frame frame) { }

	// RVA: 0x212BBE0 Offset: 0x212A1E0 VA: 0x18212BBE0
	private void ReduceBlastzone(Frame frame, SpeedRunnersSettingsData speedRunnersSettingsData, CameraManager* cameraManager) { }

	// RVA: 0x212C640 Offset: 0x212AC40 VA: 0x18212C640
	public void UpdateSuddenDeathMultiplier(Frame frame, SpeedRunnersSettingsData speedRunnersSettingsData) { }

	// RVA: 0x212BA60 Offset: 0x212A060 VA: 0x18212BA60
	public FP GetSuddenDeathMultiplier(Frame frame) { }

	// RVA: 0x212BD60 Offset: 0x212A360 VA: 0x18212BD60
	public void ResetBlastzone(Frame frame) { }

	// RVA: 0x212BF40 Offset: 0x212A540 VA: 0x18212BF40
	private void ResetData(Frame frame) { }

	// RVA: 0x212C030 Offset: 0x212A630 VA: 0x18212C030
	public void StartSuddenDeath(Frame frame, bool fromTime = False) { }

	// RVA: 0x212B990 Offset: 0x2129F90 VA: 0x18212B990
	public void Disable(Frame frame) { }
}
