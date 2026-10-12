// Namespace: 
public class GameplayEmote : SRMonoBehaviour // TypeDefIndex: 2937
{
	// Fields
	public RectTransform RectTransform; // 0x20
	public StellarUIAnimator ContainerAnimator; // 0x28
	public StellarUIAnimator EmoteGraphicAnimator; // 0x30
	public EmotesGraphicData EmotesGraphicData; // 0x38
	public GameObject ButtonIcon; // 0x40
	public Image IconImage; // 0x48
	public Key Key; // 0x50
	public Image EmoteBackground; // 0x58
	public Image EmoteSpriteSheet; // 0x60
	public bool Subscribed; // 0x68
	[CompilerGenerated]
	private string <CurrentEmoteID>k__BackingField; // 0x70
	[CompilerGenerated]
	private bool <IsActive>k__BackingField; // 0x78
	[CompilerGenerated]
	private EntityRef <CharacterEntity>k__BackingField; // 0x80
	[CompilerGenerated]
	private string <PlayerNickname>k__BackingField; // 0x88
	private Coroutine hideEmoteCoroutine; // 0x90
	private Transform followPoint; // 0x98
	private Camera currentCamera; // 0xA0
	private RectTransform canvasRect; // 0xA8
	private DispatcherSubscription pickUpItemEvent; // 0xB0
	public float LocalPS5Offset; // 0xB8
	public float OnlinePS5Offset; // 0xBC

	// Properties
	public string CurrentEmoteID { get; set; }
	public bool IsActive { get; set; }
	public EntityRef CharacterEntity { get; set; }
	public string PlayerNickname { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x5DC820 Offset: 0x5DAE20 VA: 0x1805DC820
	public string get_CurrentEmoteID() { }

	[CompilerGenerated]
	// RVA: 0x5DC940 Offset: 0x5DAF40 VA: 0x1805DC940
	public void set_CurrentEmoteID(string value) { }

	[CompilerGenerated]
	// RVA: 0x5BAA00 Offset: 0x5B9000 VA: 0x1805BAA00
	public bool get_IsActive() { }

	[CompilerGenerated]
	// RVA: 0x5BAB60 Offset: 0x5B9160 VA: 0x1805BAB60
	public void set_IsActive(bool value) { }

	[CompilerGenerated]
	// RVA: 0x54C330 Offset: 0x54A930 VA: 0x18054C330
	public EntityRef get_CharacterEntity() { }

	[CompilerGenerated]
	// RVA: 0x763530 Offset: 0x761B30 VA: 0x180763530
	public void set_CharacterEntity(EntityRef value) { }

	[CompilerGenerated]
	// RVA: 0x531670 Offset: 0x52FC70 VA: 0x180531670
	public string get_PlayerNickname() { }

	[CompilerGenerated]
	// RVA: 0x54C3B0 Offset: 0x54A9B0 VA: 0x18054C3B0
	public void set_PlayerNickname(string value) { }

	// RVA: 0x7633E0 Offset: 0x7619E0 VA: 0x1807633E0
	public void SubscribeToPickupItemEvent() { }

	// RVA: 0x763110 Offset: 0x761710 VA: 0x180763110
	private void OnPickupItem(EventOnPickupItem callback) { }

	// RVA: 0x763160 Offset: 0x761760 VA: 0x180763160
	public void SetEmoteGraphic(EmoteData emoteData, CharacterHUD.CharacterColorData colorData, bool isFloatingEmote = False) { }

	// RVA: 0x762FB0 Offset: 0x7615B0 VA: 0x180762FB0
	public void LateUpdate() { }

	// RVA: 0x763370 Offset: 0x761970 VA: 0x180763370
	public void SetFollow(Transform followPoint, RectTransform canvasRect) { }

	// RVA: 0x762E70 Offset: 0x761470 VA: 0x180762E70
	public void InitializeAsPreviewEmote(EmoteData emoteData) { }

	// RVA: 0x762D20 Offset: 0x761320 VA: 0x180762D20
	public void HideEmote(float time = 0) { }

	[IteratorStateMachine(typeof(GameplayEmote.<HideEmoteWithDelay>d__40))]
	// RVA: 0x762CA0 Offset: 0x7612A0 VA: 0x180762CA0
	private IEnumerator HideEmoteWithDelay(float time) { }

	// RVA: 0x7634B0 Offset: 0x761AB0 VA: 0x1807634B0
	public void ToggleEmoteActive() { }

	// RVA: 0x7630A0 Offset: 0x7616A0 VA: 0x1807630A0
	private void OnDestroy() { }

	// RVA: 0x53A8F0 Offset: 0x538EF0 VA: 0x18053A8F0
	public void .ctor() { }
}
