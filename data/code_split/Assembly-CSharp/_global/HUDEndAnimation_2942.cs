// Namespace: 
public class HUDEndAnimation : SRMonoBehaviour // TypeDefIndex: 2942
{
	// Fields
	public List<HUDEndAnimation.CharacterColorData> ColorsData; // 0x20
	public List<RoundWinnerBannerStar> Stars; // 0x28
	[Header("Data")]
	public float CameraBlendTime; // 0x30
	public float LowFOVPositionOffset; // 0x34
	public float MediumFOVPositionOffset; // 0x38
	public float HighFOVPositionOffset; // 0x3C
	[Header("Elements")]
	public Animator WinnerBannerAnimator; // 0x40
	public Animator WinnerPatternAnimator; // 0x48
	public Transform WinnerCharacterSpot; // 0x50
	public OnlineBadgeElement OnlineBadge; // 0x58
	public GameObject StarContainer; // 0x60
	public GameObject PlayerUsername; // 0x68
	public TMP_Text UsernameShadowText; // 0x70
	public TMP_Text UsernameText; // 0x78
	public TMP_Text CatchPhraseText; // 0x80
	public TMP_Text CatchPhraseShadow; // 0x88
	public CinemachineVirtualCamera RoundWinnerCamera; // 0x90
	[CompilerGenerated]
	private EntityRef <WinnerEntity>k__BackingField; // 0x98
	private int totalRounds; // 0xA0
	private int completedRounds; // 0xA4
	private CinemachineTransposer roundWinnerCameraTransposer; // 0xA8

	// Properties
	public EntityRef WinnerEntity { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x54C320 Offset: 0x54A920 VA: 0x18054C320
	public EntityRef get_WinnerEntity() { }

	[CompilerGenerated]
	// RVA: 0x764CD0 Offset: 0x7632D0 VA: 0x180764CD0
	public void set_WinnerEntity(EntityRef value) { }

	// RVA: 0x763540 Offset: 0x761B40 VA: 0x180763540
	public HUDEndAnimation.CharacterColorData GetColorData(int spawnOrder) { }

	// RVA: 0x7640A0 Offset: 0x7626A0 VA: 0x1807640A0
	public void ShowRoundFinishedAnimation(StellarCharacterData winnerData, int completedRounds, int totalRounds, bool isRaceFinished) { }

	// RVA: 0x7636A0 Offset: 0x761CA0 VA: 0x1807636A0
	public void HideWinnerBannerAnimation() { }

	// RVA: 0x763B00 Offset: 0x762100 VA: 0x180763B00
	public void ResetWinnerBanner() { }

	// RVA: 0x7639D0 Offset: 0x761FD0 VA: 0x1807639D0
	public void ResetStarsHighlight() { }

	// RVA: 0x7637B0 Offset: 0x761DB0 VA: 0x1807637B0
	public void PlayStarHighlightAnimation() { }

	// RVA: 0x7649F0 Offset: 0x762FF0 VA: 0x1807649F0
	public void ZoomInCamera(EntityRef winnerEntity) { }

	// RVA: 0x763D00 Offset: 0x762300 VA: 0x180763D00
	public void SetRoundWinnerFlagVisibility(EntityRef winnerEntity, bool show) { }

	// RVA: 0x7638E0 Offset: 0x761EE0 VA: 0x1807638E0
	public void PlayWinnerPatternAnimation() { }

	// RVA: 0x7635C0 Offset: 0x761BC0 VA: 0x1807635C0
	private RoundWinnerBannerStar GetStarByIndex(int index) { }

	// RVA: 0x763930 Offset: 0x761F30 VA: 0x180763930
	public void ResetCamera() { }

	// RVA: 0x763700 Offset: 0x761D00 VA: 0x180763700
	public void PlayMatchFinishSFX() { }

	// RVA: 0x764CB0 Offset: 0x7632B0 VA: 0x180764CB0
	public void .ctor() { }
}
