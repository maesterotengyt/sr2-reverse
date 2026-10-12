// Namespace: 
public class MatchCountdownHud : SRMonoBehaviour // TypeDefIndex: 2951
{
	// Fields
	[Header("Data")]
	public Color WarningColor; // 0x20
	public Color DefaultColor; // 0x30
	public int TimerWarningThreshold; // 0x40
	public int TimerCriticalThreshold; // 0x44
	public bool RocketWaveTimer; // 0x48
	[Header("Elements")]
	public Animator TimerAnimator; // 0x50
	public GameObject TimerGlow; // 0x58
	public TMP_Text TimerText; // 0x60
	private bool bombTimerActive; // 0x68
	private bool warningActive; // 0x69

	// Methods

	// RVA: 0x778120 Offset: 0x776720 VA: 0x180778120
	public void Initialization() { }

	// RVA: 0x778350 Offset: 0x776950 VA: 0x180778350
	private void OnUpdateCountdownTimer(EventTimeRaceTimer callback) { }

	// RVA: 0x778480 Offset: 0x776A80 VA: 0x180778480
	private void OnUpdateRocketsIncomingTimer(EventRocketsIncoming callback) { }

	// RVA: 0x7782D0 Offset: 0x7768D0 VA: 0x1807782D0
	public void OnResetTimer(EventResetRaceTimer callback) { }

	// RVA: 0x778580 Offset: 0x776B80 VA: 0x180778580
	public void ResetBombTimer() { }

	// RVA: 0x53A8F0 Offset: 0x538EF0 VA: 0x18053A8F0
	public void .ctor() { }
}
