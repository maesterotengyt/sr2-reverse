// Namespace: 
public class BossHealthBar : SRMonoBehaviour // TypeDefIndex: 2872
{
	// Fields
	public Image HealthBar; // 0x20
	public Image BossIcon; // 0x28
	public TMP_Text BossName; // 0x30
	public float animationDuration; // 0x38
	private int bossMaxHealthPoints; // 0x3C
	private int bossCurrentHealthPoints; // 0x40
	private Coroutine currentAnimation; // 0x48

	// Methods

	// RVA: 0x744BE0 Offset: 0x7431E0 VA: 0x180744BE0
	public void Initialize() { }

	[IteratorStateMachine(typeof(BossHealthBar.<AnimateFill>d__8))]
	// RVA: 0x744AD0 Offset: 0x7430D0 VA: 0x180744AD0
	private IEnumerator AnimateFill(float target) { }

	// RVA: 0x744B50 Offset: 0x743150 VA: 0x180744B50
	public void DecreaseHealth() { }

	// RVA: 0x744B50 Offset: 0x743150 VA: 0x180744B50
	public void IncreaseHealth() { }

	// RVA: 0x744FC0 Offset: 0x7435C0 VA: 0x180744FC0
	private void OnUpdateBossHealthBarPoints(EventUpdateBossHealthPointsHUD callback) { }

	// RVA: 0x744E50 Offset: 0x743450 VA: 0x180744E50
	private void OnResetBossHealthBarPoints(EventResetBossHealthPointsHUD callback) { }

	// RVA: 0x744ED0 Offset: 0x7434D0 VA: 0x180744ED0
	private void OnSetInitialBossHUDInfo(EventSetInitialBossHUDInfo callback) { }

	// RVA: 0x543640 Offset: 0x541C40 VA: 0x180543640
	private void OnDisableBossHealthHUD(EventDisableBossHealthHUD callback) { }

	// RVA: 0x7450A0 Offset: 0x7436A0 VA: 0x1807450A0
	public void .ctor() { }
}
