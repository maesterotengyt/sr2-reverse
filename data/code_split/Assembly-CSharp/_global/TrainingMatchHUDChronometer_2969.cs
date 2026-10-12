// Namespace: 
public class TrainingMatchHUDChronometer : SRMonoBehaviour // TypeDefIndex: 2969
{
	// Fields
	public const float DefaultBestTime = 120;
	[Header("References")]
	public TextMeshProUGUI CurrentTimeText; // 0x20
	public TextMeshProUGUI BestTimeText; // 0x28
	public Image ChronometerBar; // 0x30
	[Header("Visual Settings")]
	public Color TimerDefaultColor; // 0x38
	public Color TimerFailColor; // 0x48
	private float bestTime; // 0x58
	private float lastKnownLapTime; // 0x5C

	// Methods

	// RVA: 0x7831A0 Offset: 0x7817A0 VA: 0x1807831A0
	public void OnUpdate() { }

	// RVA: 0x782B00 Offset: 0x781100 VA: 0x180782B00
	public void Initialize() { }

	// RVA: 0x782D90 Offset: 0x781390 VA: 0x180782D90
	private void OnLapFinished(EventOnLapFinished callback) { }

	// RVA: 0x783310 Offset: 0x781910 VA: 0x180783310
	private void UpdateBestTimeText() { }

	// RVA: 0x783370 Offset: 0x781970 VA: 0x180783370
	public void .ctor() { }
}
