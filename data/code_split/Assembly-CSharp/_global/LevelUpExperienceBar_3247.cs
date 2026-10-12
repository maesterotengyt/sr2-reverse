// Namespace: 
public class LevelUpExperienceBar : SRMonoBehaviour // TypeDefIndex: 3247
{
	// Fields
	[Header("UI Elements")]
	public Image LevelIcon; // 0x20
	public Image UnlockIcon; // 0x28
	public Image LevelBar; // 0x30
	public TMP_Text Level; // 0x38
	public TMP_Text ExperienceGained; // 0x40
	public TMP_Text ExperiencePoints; // 0x48
	[Header("Localization")]
	public LocalizedString ExperiencePointsString; // 0x50
	public LocalizedString ExperienceGainedString; // 0x58
	[Header("Settings")]
	public float animationDuration; // 0x60
	public Animator Animator; // 0x68
	public LevelUpExperienceBar.OnLevelUpBarFinished LevelUpBarFinished; // 0x70
	private Coroutine currentAnimation; // 0x78

	// Methods

	// RVA: 0x59BF30 Offset: 0x59A530 VA: 0x18059BF30
	public void Initialize(PlayerLevelData currentLevelData, Nullable<PlayerLevelData> nextLevelData, int previousExperience, int experienceGained, int currentLevel) { }

	[IteratorStateMachine(typeof(LevelUpExperienceBar.<LevelUpSequence>d__14))]
	// RVA: 0x59C2D0 Offset: 0x59A8D0 VA: 0x18059C2D0
	private IEnumerator LevelUpSequence(int oldLevelNumber, PlayerLevelData oldLevelData, PlayerLevelData nextLevelData, int totalXP) { }

	[IteratorStateMachine(typeof(LevelUpExperienceBar.<AnimateFill>d__15))]
	// RVA: 0x59BEB0 Offset: 0x59A4B0 VA: 0x18059BEB0
	private IEnumerator AnimateFill(float target) { }

	// RVA: 0x59C380 Offset: 0x59A980 VA: 0x18059C380
	public void SetUnlockImage(Unlockable unlockable) { }

	// RVA: 0x59C540 Offset: 0x59AB40 VA: 0x18059C540
	public void .ctor() { }
}
