// Namespace: 
public class EscapeRoomTimer : SRMonoBehaviour // TypeDefIndex: 2935
{
	// Fields
	[Header("References")]
	public Animator Animator; // 0x20
	public CanvasGroup CanvasGroup; // 0x28
	public RectTransform RectTransform; // 0x30
	public TextMeshProUGUI CurrentTimeText; // 0x38
	public Image TimerBar; // 0x40
	public int WarningTimeThreshold; // 0x48
	public int FinalWarningTimeThreshold; // 0x4C
	public Color IdleColor; // 0x50
	[Range(0, 1)]
	public float TransparencyLevel; // 0x60
	private float lastKnownTime; // 0x64
	private bool warningStateActive; // 0x68
	private Camera currentCamera; // 0x70

	// Methods

	// RVA: 0x7627B0 Offset: 0x760DB0 VA: 0x1807627B0
	public void Initialize() { }

	// RVA: 0x762830 Offset: 0x760E30 VA: 0x180762830
	public void OnUpdate() { }

	// RVA: 0x7621F0 Offset: 0x7607F0 VA: 0x1807621F0
	public void AnimateTransparency() { }

	// RVA: 0x762B80 Offset: 0x761180 VA: 0x180762B80
	public void ResetTimerAnimation() { }

	// RVA: 0x762C90 Offset: 0x761290 VA: 0x180762C90
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x762C20 Offset: 0x761220 VA: 0x180762C20
	private bool <AnimateTransparency>b__14_0(Vector2 pos) { }
}
