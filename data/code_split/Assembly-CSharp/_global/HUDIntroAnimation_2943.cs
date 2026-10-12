// Namespace: 
public class HUDIntroAnimation : SRMonoBehaviour // TypeDefIndex: 2943
{
	// Fields
	public Animator CountdownAnimator; // 0x20
	public Animator CharactersHUDAnimator; // 0x28
	public GameObject CountdownContainer; // 0x30
	public Image IntroCard; // 0x38
	public GameObject Top2Text; // 0x40
	private int spawnDirection; // 0x48
	private bool introCardShown; // 0x4C
	private int RoundsPlayed; // 0x50

	// Methods

	// RVA: 0x764D20 Offset: 0x763320 VA: 0x180764D20
	public void Initialization() { }

	// RVA: 0x765020 Offset: 0x763620 VA: 0x180765020
	public void OnDestroy() { }

	// RVA: 0x765310 Offset: 0x763910 VA: 0x180765310
	private void ShowIntroAnimation(EventShowIntroAnimation callback) { }

	// RVA: 0x765210 Offset: 0x763810 VA: 0x180765210
	public void PlayIntroSound(string soundEvent) { }

	// RVA: 0x7652C0 Offset: 0x7638C0 VA: 0x1807652C0
	public void ShowCharactersHUD() { }

	// RVA: 0x765180 Offset: 0x763780 VA: 0x180765180
	public void OnPauseStateChanged(bool isPaused) { }

	// RVA: 0x7656E0 Offset: 0x763CE0 VA: 0x1807656E0
	private void ShowTop2Text() { }

	// RVA: 0x764CE0 Offset: 0x7632E0 VA: 0x180764CE0
	public void AddRoundPlayed() { }

	// RVA: 0x53A8F0 Offset: 0x538EF0 VA: 0x18053A8F0
	public void .ctor() { }
}
