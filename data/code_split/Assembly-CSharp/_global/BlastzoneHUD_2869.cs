// Namespace: 
public class BlastzoneHUD : SRMonoBehaviour // TypeDefIndex: 2869
{
	// Fields
	public GameObject ExplosionHandlerPrefab; // 0x20
	[HideInInspector]
	public BlastzoneExplosionCameraUpdater ExplosionCameraUpdater; // 0x28
	private const float ExplosionCameraMaxDuration = 15;
	private Coroutine disableExplosionCameraCoroutine; // 0x30
	[Header("Data")]
	public Color WarningColor; // 0x38
	public Color DefaultColor; // 0x48
	public int TimerWarningThreshold; // 0x58
	public int TimerCriticalThreshold; // 0x5C
	public HashString ExplosionCameraShakePreset; // 0x60
	public float VFXBoundsMargin; // 0x70
	public string MaskSizeParamID; // 0x78
	public float MaskSizePercentageOffset; // 0x80
	public float MinBlastzonePercentage; // 0x84
	public float MaxBlastzonePercentage; // 0x88
	public float MinBlastzonePercentageOffset; // 0x8C
	public float MaxBlastzonePercentageOffset; // 0x90
	public AnimationCurve BlastzoneOffsetInterpolationCurve; // 0x98
	[Header("Elements")]
	public Canvas Canvas; // 0xA0
	public CanvasScaler CanvasScaler; // 0xA8
	public RectTransform CanvasRectTransform; // 0xB0
	public Image BlastzoneImage; // 0xB8
	public Material BlastzoneFireMaterial; // 0xC0
	public Animator TimerAnimator; // 0xC8
	public GameObject TimerGlow; // 0xD0
	public TMP_Text TimerText; // 0xD8
	public bool IsSuddenDeathTriggered; // 0xE0
	[Header("Debug")]
	public bool ShowCameraBounds; // 0xE1
	public Vector2 CameraBoundsDebugOffset; // 0xE4
	private bool bombTimerActive; // 0xEC
	private bool bombTimerTriggered; // 0xED
	private bool warningActive; // 0xEE
	private bool matchEnded; // 0xEF
	private int maskSizeParamIndex; // 0xF0
	private BlastzoneExplosionsHandler _explosionsHandler; // 0xF8
	private RawImage explosionOutputImage; // 0x100

	// Properties
	private BlastzoneExplosionsHandler explosionsHandler { get; set; }

	// Methods

	// RVA: 0x743300 Offset: 0x741900 VA: 0x180743300
	private BlastzoneExplosionsHandler get_explosionsHandler() { }

	// RVA: 0x60C870 Offset: 0x60AE70 VA: 0x18060C870
	private void set_explosionsHandler(BlastzoneExplosionsHandler value) { }

	// RVA: 0x741B70 Offset: 0x740170 VA: 0x180741B70
	private void Awake() { }

	// RVA: 0x743120 Offset: 0x741720 VA: 0x180743120
	private void Start() { }

	// RVA: 0x742000 Offset: 0x740600 VA: 0x180742000
	public void Initialization() { }

	// RVA: 0x742AD0 Offset: 0x7410D0 VA: 0x180742AD0
	private void OnRaceEnd(EventNotifyRaceEnd callback) { }

	// RVA: 0x742AE0 Offset: 0x7410E0 VA: 0x180742AE0
	private void OnResetRaceRound(EventOnResetRaceRound callback) { }

	// RVA: 0x741E90 Offset: 0x740490 VA: 0x180741E90
	public void HideExplosionOutput() { }

	// RVA: 0x742E20 Offset: 0x741420 VA: 0x180742E20
	public void ResetBlastzone() { }

	// RVA: 0x742D40 Offset: 0x741340 VA: 0x180742D40
	private void OnUpdateBlastzone(EventUpdateBlastzone callback) { }

	// RVA: 0x743010 Offset: 0x741610 VA: 0x180743010
	private void SetBlastzoneSizePercentage(float percentage) { }

	// RVA: 0x742AF0 Offset: 0x7410F0 VA: 0x180742AF0
	private void OnUpdateBlastzoneTimer(EventUpdateBlastzoneTimer callback) { }

	// RVA: 0x742FC0 Offset: 0x7415C0 VA: 0x180742FC0
	public void ResetBombTimer() { }

	// RVA: 0x7423E0 Offset: 0x7409E0 VA: 0x1807423E0
	public void OnCharacterKnockout(EventCharacterKnockout callback) { }

	// RVA: 0x741CF0 Offset: 0x7402F0 VA: 0x180741CF0
	private void EnableExplosionCamera() { }

	[IteratorStateMachine(typeof(BlastzoneHUD.<DisableExplosionCameraAfterDelay>d__51))]
	// RVA: 0x741C70 Offset: 0x740270 VA: 0x180741C70
	private IEnumerator DisableExplosionCameraAfterDelay(float delay) { }

	// RVA: 0x743290 Offset: 0x741890 VA: 0x180743290
	public void .ctor() { }
}
