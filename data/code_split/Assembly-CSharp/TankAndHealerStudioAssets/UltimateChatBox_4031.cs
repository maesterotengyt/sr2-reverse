// Namespace: TankAndHealerStudioAssets
[ExecuteAlways]
[RequireComponent(typeof(CanvasGroup))]
public class UltimateChatBox : MonoBehaviour // TypeDefIndex: 4031
{
	// Fields
	[CompilerGenerated]
	private List<UltimateChatBox.ChatInformation> <ChatInformations>k__BackingField; // 0x20
	[CompilerGenerated]
	private List<TextMeshProUGUI> <AllTextObjects>k__BackingField; // 0x28
	private List<TextMeshProUGUI> UnusedTextPool; // 0x30
	[CompilerGenerated]
	private Canvas <ParentCanvas>k__BackingField; // 0x38
	private RectTransform parentCanvasRectTrans; // 0x40
	private Vector3 parentCanvasScale; // 0x48
	private Vector2 parentCanvasSize; // 0x54
	[CompilerGenerated]
	private bool <Interactable>k__BackingField; // 0x5C
	[CompilerGenerated]
	private bool <IsEnabled>k__BackingField; // 0x5D
	[CompilerGenerated]
	private bool <InputOnChatBox>k__BackingField; // 0x5E
	[CompilerGenerated]
	private float <LineHeight>k__BackingField; // 0x60
	private float totalContentSpace; // 0x64
	private bool isDraggingScrollHandle; // 0x68
	[CompilerGenerated]
	private Vector3 <InputPosition>k__BackingField; // 0x6C
	private Vector3 previousInputPosition; // 0x78
	[CompilerGenerated]
	private bool <GetButtonDown>k__BackingField; // 0x84
	[CompilerGenerated]
	private bool <GetButton>k__BackingField; // 0x85
	private float scrollValue; // 0x88
	[CompilerGenerated]
	private Vector2 <TotalChatBoxSize>k__BackingField; // 0x8C
	private int inputFieldStringPosition; // 0x94
	private bool isDirty; // 0x98
	[SerializeField]
	[HideInInspector]
	private CanvasGroup chatBoxCanvasGroup; // 0xA0
	[SerializeField]
	[Tooltip("Should the chat box calculate any touch input on it?")]
	private bool allowTouchInput; // 0xA8
	private bool isDraggingWithTouch; // 0xA9
	private int currentTouchId; // 0xAC
	private bool customInputRecieved; // 0xB0
	private Vector2 customScreenPosition; // 0xB4
	private bool customGetButtonDown; // 0xBC
	private bool customGetButton; // 0xBD
	private RectTransform baseTransform; // 0xC0
	[SerializeField]
	[Tooltip("The ratio of the chat box.")]
	private Vector2 chatBoxSizeRatio; // 0xC8
	[SerializeField]
	[Tooltip("The overall size of the chat box.")]
	private float chatBoxSize; // 0xD0
	[SerializeField]
	[Tooltip("The position of the chat box on the screen. These values are calculated as percentages, so they are divided by 100 and calculated off the canvas size so that it will be consistent across all screen sizes.")]
	private Vector2 chatBoxPosition; // 0xD4
	[SerializeField]
	[Tooltip("The visible bounding box for the chat in the chat box.")]
	private RectTransform visibleChatBoundingBox; // 0xE0
	[SerializeField]
	[Tooltip("The horizontal bounds for the content of the chat box.")]
	private RectTransform chatContentBox; // 0xE8
	[SerializeField]
	[Tooltip("The horizontal spacing for the left and right of the content box.")]
	[Range(0, 50)]
	private float horizontalSpacing; // 0xF0
	[SerializeField]
	[Tooltip("The vertical spacing for the top and bottom of the bounding box.")]
	[Range(0, 50)]
	private float verticalSpacing; // 0xF4
	[SerializeField]
	[Tooltip("The position of the content within the chat box.")]
	private Vector2 contentPosition; // 0xF8
	[SerializeField]
	[HideInInspector]
	private Rect chatBoxScreenRect; // 0x100
	private Rect chatBoxVisiblityRect; // 0x110
	private bool chatBoxPositionCustom; // 0x120
	private Vector2 bottomContentPosition; // 0x124
	[SerializeField]
	[Tooltip("The TextMeshPro GameObject to use as base settings for all the chats in the chat box.")]
	private TextMeshProUGUI textObject; // 0x130
	[SerializeField]
	[Tooltip("The color of the text in the chat box.")]
	private Color textColor; // 0x138
	[SerializeField]
	[Tooltip("The maximum number of chats in the chat box before the old ones will be filtered out.")]
	private int maxTextInChatBox; // 0x148
	[SerializeField]
	[Tooltip("Determines if the players should be able to use custom rich text in the input field or if the chat box should filter out the rich text.")]
	private bool disableRichTextFromPlayers; // 0x14C
	[SerializeField]
	[Tooltip("The string to add at the end of a username.")]
	private string usernameFollowup; // 0x150
	[SerializeField]
	[Tooltip("The space between each chat registered to the chat box.")]
	[Range(0, 1)]
	private float spaceBetweenChats; // 0x158
	[SerializeField]
	[Range(0, 0.2)]
	[Tooltip("The relative size of the font to the chat box height.")]
	private float smartFontSize; // 0x15C
	[SerializeField]
	[Tooltip("Should the usernames of the chats registered by interactable?")]
	private bool useInteractableUsername; // 0x160
	[SerializeField]
	[Tooltip("The image used in association with highlighting the username.")]
	private Image interactableUsernameImage; // 0x168
	[SerializeField]
	[Tooltip("The color of the highlight image when the input is hovering over the username.")]
	private Color interactableUsernameColor; // 0x170
	[SerializeField]
	[Tooltip("The percentage of the line height to add as a modifier to the username highlight image.")]
	[Range(0, 1)]
	private float interactableUsernameWidthModifier; // 0x180
	[CompilerGenerated]
	private bool <UsernameHighlighted>k__BackingField; // 0x184
	[CompilerGenerated]
	private int <CurrentHoveredChatIndex>k__BackingField; // 0x188
	[SerializeField]
	[Tooltip("Should the chat box fade the alpha of the CanvasGroup when enabling/disabling the chat box?")]
	private bool fadeWhenDisabled; // 0x18C
	[SerializeField]
	[Tooltip("The speed for the chat box to fade in.")]
	private float fadeInSpeed; // 0x190
	[SerializeField]
	[Tooltip("The speed for the chat box to fade out.")]
	private float fadeOutSpeed; // 0x194
	[SerializeField]
	[Range(0, 1)]
	[Tooltip("The alpha to apply to the chat box when it is disabled.")]
	private float toggledAlpha; // 0x198
	private bool fadeIn; // 0x19C
	private bool fadeOut; // 0x19D
	private float fadeLerpValue; // 0x1A0
	[SerializeField]
	[Tooltip("Should the chat box collapse when enabling/disabling the chat box?")]
	private bool collapseWhenDisabled; // 0x1A4
	[SerializeField]
	[Tooltip("The speed for the chat box to expand.")]
	private float expandSpeed; // 0x1A8
	[SerializeField]
	[Tooltip("The speed for the chat box to collapse.")]
	private float collapseSpeed; // 0x1AC
	[SerializeField]
	[Tooltip("How many lines of chat should be visible when the chat box is in a collapsed state?")]
	private int visibleLineCount; // 0x1B0
	private Vector2 baseTransformSize; // 0x1B4
	private Vector2 baseTransformCollapsedSize; // 0x1BC
	private Vector2 visibleBoundingBoxSize; // 0x1C4
	private Vector2 boundingBoxCollapsedSize; // 0x1CC
	private bool expandChatBox; // 0x1D4
	private bool collapseChatBox; // 0x1D5
	private float collapseLerpValue; // 0x1D8
	[SerializeField]
	[Tooltip("Should emojis be allowed in chat?")]
	private bool useTextEmoji; // 0x1DC
	[SerializeField]
	[Tooltip("The emoji asset to assign to all the chats.")]
	private TMP_SpriteAsset emojiAsset; // 0x1E0
	[SerializeField]
	[Tooltip("Should the chat box display a vertical scrollbar to help navigate chat?")]
	private bool useScrollbar; // 0x1E8
	[SerializeField]
	private RectTransform scrollbarBase; // 0x1F0
	[SerializeField]
	private RectTransform scrollbarHandle; // 0x1F8
	[SerializeField]
	private Image scrollbarHandleImage; // 0x200
	[SerializeField]
	[Tooltip("The default color for the scrollbar handle.")]
	private Color scrollbarHandleNormalColor; // 0x208
	[SerializeField]
	[Tooltip("The color for when the input is hovering the scrollbar handle.")]
	private Color scrollbarHandleHoverColor; // 0x218
	[SerializeField]
	[Tooltip("The color of the scrollbar handle when the input is active.")]
	private Color scrollbarHandleActiveColor; // 0x228
	[SerializeField]
	[Tooltip("Should the player be able to use the scroll wheel on their mouse to navigate the chat box?")]
	private bool useScrollWheel; // 0x238
	[SerializeField]
	[Tooltip("The speed that the chat box will navigate using the scroll wheel.")]
	private float mouseScrollSpeed; // 0x23C
	[SerializeField]
	[Tooltip("The minimum size that the scrollbar handle will get when the chat box is filled with chats.")]
	[Range(0.01, 0.25)]
	private float scrollbarMinimumSize; // 0x240
	[SerializeField]
	[Tooltip("The width of the scrollbar relative to the chat box width.")]
	[Range(0.01, 0.25)]
	private float scrollbarWidth; // 0x244
	[SerializeField]
	[Tooltip("The horizontal position of the scrollbar relative to the chat box center.")]
	private float scrollbarHorizontalPosition; // 0x248
	[SerializeField]
	[Tooltip("Should the scrollbar only be visible when hovering input over the chat box?")]
	private bool visibleOnlyOnHover; // 0x24C
	[SerializeField]
	[Tooltip("The speed to apply for the scrollbar to toggle visually.")]
	private float scrollbarToggleSpeed; // 0x250
	[SerializeField]
	[Tooltip("The time in seconds that the input has NOT been in the chat box for the scrollbar to disable itself.")]
	private float scrollbarInactiveTime; // 0x254
	[SerializeField]
	[Tooltip("Should clicking on the base of the scrollbar to navigate be disabled?")]
	private bool disableBaseNavigation; // 0x258
	[SerializeField]
	[HideInInspector]
	private Rect scrollbarBaseRect; // 0x25C
	[SerializeField]
	[HideInInspector]
	private Rect scrollbarHandleRect; // 0x26C
	[SerializeField]
	[HideInInspector]
	private CanvasGroup scrollbarCanvasGroup; // 0x280
	[CompilerGenerated]
	private bool <ScrollbarActive>k__BackingField; // 0x288
	private Vector2 scrollbarHandleInputStart; // 0x28C
	private Vector2 scrollbarBottomPosition; // 0x294
	private float scrollbarToggleLerpValue; // 0x29C
	private float _inactiveTime; // 0x2A0
	private bool scrollbarToggle; // 0x2A4
	private bool scrollbarHandleHovered; // 0x2A5
	private bool scrollbarHandleActive; // 0x2A6
	[SerializeField]
	[Tooltip("Determines if you want to have navigation arrows at the top and bottom of the scrollbar to help navigate the chat box.")]
	private bool useNavigationArrows; // 0x2A7
	[SerializeField]
	[Tooltip("The image component to use for the up arrow.")]
	private Image navigationArrowUp; // 0x2A8
	[SerializeField]
	[Tooltip("The image component to use for the down arrow.")]
	private Image navigationArrowDown; // 0x2B0
	[SerializeField]
	[Tooltip("The default color for the navigation arrows to be.")]
	private Color navigationNormalColor; // 0x2B8
	[SerializeField]
	[Tooltip("The color to apply when the navigation arrows are hovered.")]
	private Color navigationHoverColor; // 0x2C8
	[SerializeField]
	[Tooltip("The color to apply when the input is active on the navigation arrows.")]
	private Color navigationActiveColor; // 0x2D8
	[SerializeField]
	[Tooltip("The time in seconds before the navigation arrows will repeat the navigation when the input is held.")]
	private float navigationInitialHoldDelay; // 0x2E8
	[SerializeField]
	[Tooltip("The time in seconds between repeating navigation from holding the input on the navigation arrows.")]
	private float navigationIntervalDelay; // 0x2EC
	[SerializeField]
	[HideInInspector]
	private Rect scrollbarNavigationArrowUpRect; // 0x2F0
	[SerializeField]
	[HideInInspector]
	private Rect scrollbarNavigationArrowDownRect; // 0x300
	private bool scrollbarNavigationArrowUpHovered; // 0x310
	private bool scrollbarNavigationArrowUpActivated; // 0x311
	private bool scrollbarNavigationArrowDownHovered; // 0x312
	private bool scrollbarNavigationArrowDownActivated; // 0x313
	private float navigationIntervalTime; // 0x314
	private float navigationInitialHoldTime; // 0x318
	[SerializeField]
	[Tooltip("Should an input field be available for players to use?")]
	private bool useInputField; // 0x31C
	[SerializeField]
	[Tooltip("The input field component to use for the chat box.")]
	private TMP_InputField inputField; // 0x320
	[SerializeField]
	[Tooltip("The size of the input field relative to the chat box.")]
	private Vector2 inputFieldSize; // 0x328
	[SerializeField]
	[Tooltip("The position of the input field relative to the chat box.")]
	private Vector2 inputFieldPosition; // 0x330
	[SerializeField]
	[Range(0, 1)]
	[Tooltip("The relative size of the font to the input field height.")]
	private float inputFieldSmartFontSize; // 0x338
	[SerializeField]
	[Tooltip("The size of the input field text area relative to the input field transform.")]
	private Vector2 inputFieldTextAreaSize; // 0x33C
	[SerializeField]
	[Range(-50, 50)]
	private float inputFieldTextHorizontalPosition; // 0x344
	[SerializeField]
	[HideInInspector]
	private RectTransform inputFieldTransform; // 0x348
	[SerializeField]
	[HideInInspector]
	private Rect inputFieldRect; // 0x350
	[CompilerGenerated]
	private bool <InputFieldEnabled>k__BackingField; // 0x360
	private string inputFieldValue; // 0x368
	[CompilerGenerated]
	private bool <InputFieldContainsCommand>k__BackingField; // 0x370
	[SerializeField]
	[Tooltip("Should an extra image be used inside the input field?")]
	private bool useExtraImage; // 0x371
	[SerializeField]
	[Tooltip("The image component to use as the extra image.")]
	private Image extraImage; // 0x378
	[SerializeField]
	[HideInInspector]
	private Rect extraImageRect; // 0x380
	[SerializeField]
	[Range(0, 100)]
	[Tooltip("The height of the input field extra image.")]
	private float extraImageHeight; // 0x390
	[SerializeField]
	[Range(0, 100)]
	[Tooltip("The width of the input field extra image.")]
	private float extraImageWidth; // 0x394
	[SerializeField]
	[Range(-50, 50)]
	[Tooltip("The horizontal position in relation to the input field.")]
	private float extraImageHorizontalPosition; // 0x398
	[SerializeField]
	[Tooltip("Should the players be able to add emojis through a provided window?")]
	private bool useEmojiWindow; // 0x39C
	[SerializeField]
	[Tooltip("The image component to be used as a button to open the emoji window.")]
	private Image emojiButtonImage; // 0x3A0
	[SerializeField]
	[Tooltip("The size of the button.")]
	private float emojiButtonSize; // 0x3A8
	[SerializeField]
	[Range(0, 150)]
	[Tooltip("The horizontal position of the emoji button in relation to the left side of the input field.")]
	private float emojiButtonHorizontalPosition; // 0x3AC
	[SerializeField]
	[Tooltip("The image component used as the background of the emoji window.")]
	private Image emojiWindowImage; // 0x3B0
	[SerializeField]
	[Tooltip("The overall size of the emoji window.")]
	private Vector2 emojiWindowSize; // 0x3B8
	[SerializeField]
	[Tooltip("The position of the emoji window in relation to the bottom right of the input field.")]
	private Vector2 emojiWindowPosition; // 0x3C0
	[SerializeField]
	[Tooltip("The text to display all the available emojis.")]
	private TextMeshProUGUI emojiText; // 0x3C8
	[SerializeField]
	[Range(0, 0.2)]
	[Tooltip("The padding to add to the edges of the emoji window text.")]
	private float emojiTextEdgePadding; // 0x3D0
	[SerializeField]
	[Tooltip("How many emojis should be displayed in a row inside the window?")]
	private int emojiPerRow; // 0x3D4
	[SerializeField]
	[HideInInspector]
	private List<Rect> emojiRects; // 0x3D8
	[SerializeField]
	[HideInInspector]
	private Rect emojiButtonRect; // 0x3E0
	[SerializeField]
	[HideInInspector]
	private Rect emojiWindowRect; // 0x3F0
	[SerializeField]
	[HideInInspector]
	private CanvasGroup emojiWindowCanvasGroup; // 0x400
	[CompilerGenerated]
	private bool <EmojiWindowEnabled>k__BackingField; // 0x408
	[CompilerGenerated]
	private Action<UltimateChatBox.ChatInformation> OnChatRegistered; // 0x410
	[CompilerGenerated]
	private Action<Vector2, UltimateChatBox.ChatInformation> OnUsernameHover; // 0x418
	[CompilerGenerated]
	private Action<Vector2, UltimateChatBox.ChatInformation> OnUsernameInteract; // 0x420
	[CompilerGenerated]
	private Action OnInputFieldEnabled; // 0x428
	[CompilerGenerated]
	private Action OnInputFieldDisabled; // 0x430
	[CompilerGenerated]
	private Action<string> OnInputFieldUpdated; // 0x438
	[CompilerGenerated]
	private Action<string> OnInputFieldSubmitted; // 0x440
	[CompilerGenerated]
	private Action<string, string> OnInputFieldCommandUpdated; // 0x448
	[CompilerGenerated]
	private Action<string, string> OnInputFieldCommandSubmitted; // 0x450
	[CompilerGenerated]
	private Action OnExtraImageInteract; // 0x458
	[Header("Hide Settings")]
	[SerializeField]
	[Range(5, 40)]
	[Tooltip("The duration to hide the chat")]
	private float disableDuration; // 0x460
	[SerializeField]
	[Tooltip("The speed for the chat box to fade out when hide.")]
	private float fadeOutHideSpeed; // 0x464
	[SerializeField]
	[Tooltip("Should the chat box fade the alpha of the CanvasGroup when enabling/disabling the chat box?")]
	private bool hideChat; // 0x468
	private bool hideIn; // 0x469
	private bool hideOut; // 0x46A
	private float timeToDisableChat; // 0x46C
	private float fadeHideLerpValue; // 0x470
	[CompilerGenerated]
	private bool <Initializing>k__BackingField; // 0x474
	[CompilerGenerated]
	private bool <DisableInteraction>k__BackingField; // 0x475

	// Properties
	public List<UltimateChatBox.ChatInformation> ChatInformations { get; set; }
	public List<TextMeshProUGUI> AllTextObjects { get; set; }
	public Canvas ParentCanvas { get; set; }
	public bool Interactable { get; set; }
	public bool IsEnabled { get; set; }
	public bool InputOnChatBox { get; set; }
	public float LineHeight { get; set; }
	public Vector3 InputPosition { get; set; }
	public bool GetButtonDown { get; set; }
	public bool GetButton { get; set; }
	public float ScrollValue { set; }
	public Vector2 TotalChatBoxSize { get; set; }
	public RectTransform BaseTransform { get; }
	public RectTransform VisibleChatBoundingBox { get; }
	public RectTransform ChatContentBox { get; }
	public TextMeshProUGUI TextObject { get; }
	public Color TextColor { get; set; }
	public float CalculatedFontSize { get; }
	public Image InteractableUsernameImage { get; }
	public Color InteractableUsernameColor { get; set; }
	public bool UsernameHighlighted { get; set; }
	public int CurrentHoveredChatIndex { get; set; }
	public bool LeaveTextVisible { get; set; }
	public TMP_SpriteAsset EmojiAsset { get; }
	public bool ScrollbarActive { get; set; }
	public TMP_InputField InputField { get; }
	public bool InputFieldEnabled { get; set; }
	public string InputFieldValue { get; set; }
	public bool InputFieldContainsCommand { get; set; }
	public Sprite ExtraImageSprite { get; set; }
	public Color ExtraImageColor { get; set; }
	public bool EmojiWindowEnabled { get; set; }
	public Sprite EmojiButtonSprite { get; set; }
	public Color EmojiButtonColor { get; set; }
	private bool Initializing { get; set; }
	public bool DisableInteraction { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x504300 Offset: 0x502900 VA: 0x180504300
	public List<UltimateChatBox.ChatInformation> get_ChatInformations() { }

	[CompilerGenerated]
	// RVA: 0x656A00 Offset: 0x655000 VA: 0x180656A00
	private void set_ChatInformations(List<UltimateChatBox.ChatInformation> value) { }

	[CompilerGenerated]
	// RVA: 0x504CA0 Offset: 0x5032A0 VA: 0x180504CA0
	public List<TextMeshProUGUI> get_AllTextObjects() { }

	[CompilerGenerated]
	// RVA: 0x566E20 Offset: 0x565420 VA: 0x180566E20
	private void set_AllTextObjects(List<TextMeshProUGUI> value) { }

	[CompilerGenerated]
	// RVA: 0x5C5B40 Offset: 0x5C4140 VA: 0x1805C5B40
	public Canvas get_ParentCanvas() { }

	[CompilerGenerated]
	// RVA: 0x5C5B90 Offset: 0x5C4190 VA: 0x1805C5B90
	private void set_ParentCanvas(Canvas value) { }

	[CompilerGenerated]
	// RVA: 0x6A3940 Offset: 0x6A1F40 VA: 0x1806A3940
	public bool get_Interactable() { }

	[CompilerGenerated]
	// RVA: 0x6A4630 Offset: 0x6A2C30 VA: 0x1806A4630
	public void set_Interactable(bool value) { }

	[CompilerGenerated]
	// RVA: 0x6A3950 Offset: 0x6A1F50 VA: 0x1806A3950
	public bool get_IsEnabled() { }

	[CompilerGenerated]
	// RVA: 0x6A4640 Offset: 0x6A2C40 VA: 0x1806A4640
	private void set_IsEnabled(bool value) { }

	[CompilerGenerated]
	// RVA: 0x6A38F0 Offset: 0x6A1EF0 VA: 0x1806A38F0
	public bool get_InputOnChatBox() { }

	[CompilerGenerated]
	// RVA: 0x6A4560 Offset: 0x6A2B60 VA: 0x1806A4560
	private void set_InputOnChatBox(bool value) { }

	[CompilerGenerated]
	// RVA: 0x6A39C0 Offset: 0x6A1FC0 VA: 0x1806A39C0
	public float get_LineHeight() { }

	[CompilerGenerated]
	// RVA: 0x6A46C0 Offset: 0x6A2CC0 VA: 0x1806A46C0
	private void set_LineHeight(float value) { }

	[CompilerGenerated]
	// RVA: 0x6A3900 Offset: 0x6A1F00 VA: 0x1806A3900
	public Vector3 get_InputPosition() { }

	[CompilerGenerated]
	// RVA: 0x6A4570 Offset: 0x6A2B70 VA: 0x1806A4570
	private void set_InputPosition(Vector3 value) { }

	[CompilerGenerated]
	// RVA: 0x6A3880 Offset: 0x6A1E80 VA: 0x1806A3880
	public bool get_GetButtonDown() { }

	[CompilerGenerated]
	// RVA: 0x6A44A0 Offset: 0x6A2AA0 VA: 0x1806A44A0
	private void set_GetButtonDown(bool value) { }

	[CompilerGenerated]
	// RVA: 0x6A3890 Offset: 0x6A1E90 VA: 0x1806A3890
	public bool get_GetButton() { }

	[CompilerGenerated]
	// RVA: 0x6A44B0 Offset: 0x6A2AB0 VA: 0x1806A44B0
	private void set_GetButton(bool value) { }

	// RVA: 0x6A46D0 Offset: 0x6A2CD0 VA: 0x1806A46D0
	public void set_ScrollValue(float value) { }

	[CompilerGenerated]
	// RVA: 0x6A3A00 Offset: 0x6A2000 VA: 0x1806A3A00
	public Vector2 get_TotalChatBoxSize() { }

	[CompilerGenerated]
	// RVA: 0x6A47B0 Offset: 0x6A2DB0 VA: 0x1806A47B0
	private void set_TotalChatBoxSize(Vector2 value) { }

	// RVA: 0x6A3380 Offset: 0x6A1980 VA: 0x1806A3380
	public RectTransform get_BaseTransform() { }

	// RVA: 0x6A3A30 Offset: 0x6A2030 VA: 0x1806A3A30
	public RectTransform get_VisibleChatBoundingBox() { }

	// RVA: 0x6A34B0 Offset: 0x6A1AB0 VA: 0x1806A34B0
	public RectTransform get_ChatContentBox() { }

	// RVA: 0x6A39F0 Offset: 0x6A1FF0 VA: 0x1806A39F0
	public TextMeshProUGUI get_TextObject() { }

	// RVA: 0x6A39E0 Offset: 0x6A1FE0 VA: 0x1806A39E0
	public Color get_TextColor() { }

	// RVA: 0x6A46F0 Offset: 0x6A2CF0 VA: 0x1806A46F0
	public void set_TextColor(Color value) { }

	// RVA: 0x6A3420 Offset: 0x6A1A20 VA: 0x1806A3420
	public float get_CalculatedFontSize() { }

	// RVA: 0x6A3930 Offset: 0x6A1F30 VA: 0x1806A3930
	public Image get_InteractableUsernameImage() { }

	// RVA: 0x6A3920 Offset: 0x6A1F20 VA: 0x1806A3920
	public Color get_InteractableUsernameColor() { }

	// RVA: 0x6A4580 Offset: 0x6A2B80 VA: 0x1806A4580
	public void set_InteractableUsernameColor(Color value) { }

	[CompilerGenerated]
	// RVA: 0x6A3A20 Offset: 0x6A2020 VA: 0x1806A3A20
	public bool get_UsernameHighlighted() { }

	[CompilerGenerated]
	// RVA: 0x6A47C0 Offset: 0x6A2DC0 VA: 0x1806A47C0
	private void set_UsernameHighlighted(bool value) { }

	[CompilerGenerated]
	// RVA: 0x6A35A0 Offset: 0x6A1BA0 VA: 0x1806A35A0
	public int get_CurrentHoveredChatIndex() { }

	[CompilerGenerated]
	// RVA: 0x6A41D0 Offset: 0x6A27D0 VA: 0x1806A41D0
	private void set_CurrentHoveredChatIndex(int value) { }

	// RVA: 0x6A3960 Offset: 0x6A1F60 VA: 0x1806A3960
	public bool get_LeaveTextVisible() { }

	// RVA: 0x6A4650 Offset: 0x6A2C50 VA: 0x1806A4650
	public void set_LeaveTextVisible(bool value) { }

	// RVA: 0x6A35C0 Offset: 0x6A1BC0 VA: 0x1806A35C0
	public TMP_SpriteAsset get_EmojiAsset() { }

	[CompilerGenerated]
	// RVA: 0x6A39D0 Offset: 0x6A1FD0 VA: 0x1806A39D0
	public bool get_ScrollbarActive() { }

	[CompilerGenerated]
	// RVA: 0x6A46E0 Offset: 0x6A2CE0 VA: 0x1806A46E0
	private void set_ScrollbarActive(bool value) { }

	// RVA: 0x6A38E0 Offset: 0x6A1EE0 VA: 0x1806A38E0
	public TMP_InputField get_InputField() { }

	[CompilerGenerated]
	// RVA: 0x6A38C0 Offset: 0x6A1EC0 VA: 0x1806A38C0
	public bool get_InputFieldEnabled() { }

	[CompilerGenerated]
	// RVA: 0x6A44E0 Offset: 0x6A2AE0 VA: 0x1806A44E0
	private void set_InputFieldEnabled(bool value) { }

	// RVA: 0x6A38D0 Offset: 0x6A1ED0 VA: 0x1806A38D0
	public string get_InputFieldValue() { }

	// RVA: 0x6A44F0 Offset: 0x6A2AF0 VA: 0x1806A44F0
	public void set_InputFieldValue(string value) { }

	[CompilerGenerated]
	// RVA: 0x6A38B0 Offset: 0x6A1EB0 VA: 0x1806A38B0
	public bool get_InputFieldContainsCommand() { }

	[CompilerGenerated]
	// RVA: 0x6A44D0 Offset: 0x6A2AD0 VA: 0x1806A44D0
	private void set_InputFieldContainsCommand(bool value) { }

	// RVA: 0x6A37F0 Offset: 0x6A1DF0 VA: 0x1806A37F0
	public Sprite get_ExtraImageSprite() { }

	// RVA: 0x6A4400 Offset: 0x6A2A00 VA: 0x1806A4400
	public void set_ExtraImageSprite(Sprite value) { }

	// RVA: 0x6A3730 Offset: 0x6A1D30 VA: 0x1806A3730
	public Color get_ExtraImageColor() { }

	// RVA: 0x6A4350 Offset: 0x6A2950 VA: 0x1806A4350
	public void set_ExtraImageColor(Color value) { }

	[CompilerGenerated]
	// RVA: 0x6A3720 Offset: 0x6A1D20 VA: 0x1806A3720
	public bool get_EmojiWindowEnabled() { }

	[CompilerGenerated]
	// RVA: 0x6A4340 Offset: 0x6A2940 VA: 0x1806A4340
	private void set_EmojiWindowEnabled(bool value) { }

	// RVA: 0x6A3690 Offset: 0x6A1C90 VA: 0x1806A3690
	public Sprite get_EmojiButtonSprite() { }

	// RVA: 0x6A42A0 Offset: 0x6A28A0 VA: 0x1806A42A0
	public void set_EmojiButtonSprite(Sprite value) { }

	// RVA: 0x6A35D0 Offset: 0x6A1BD0 VA: 0x1806A35D0
	public Color get_EmojiButtonColor() { }

	// RVA: 0x6A41F0 Offset: 0x6A27F0 VA: 0x1806A41F0
	public void set_EmojiButtonColor(Color value) { }

	[CompilerGenerated]
	// RVA: 0x6A2CD0 Offset: 0x6A12D0 VA: 0x1806A2CD0
	public void add_OnChatRegistered(Action<UltimateChatBox.ChatInformation> value) { }

	[CompilerGenerated]
	// RVA: 0x6A3B20 Offset: 0x6A2120 VA: 0x1806A3B20
	public void remove_OnChatRegistered(Action<UltimateChatBox.ChatInformation> value) { }

	[CompilerGenerated]
	// RVA: 0x6A3220 Offset: 0x6A1820 VA: 0x1806A3220
	public void add_OnUsernameHover(Action<Vector2, UltimateChatBox.ChatInformation> value) { }

	[CompilerGenerated]
	// RVA: 0x6A4070 Offset: 0x6A2670 VA: 0x1806A4070
	public void remove_OnUsernameHover(Action<Vector2, UltimateChatBox.ChatInformation> value) { }

	[CompilerGenerated]
	// RVA: 0x6A32D0 Offset: 0x6A18D0 VA: 0x1806A32D0
	public void add_OnUsernameInteract(Action<Vector2, UltimateChatBox.ChatInformation> value) { }

	[CompilerGenerated]
	// RVA: 0x6A4120 Offset: 0x6A2720 VA: 0x1806A4120
	public void remove_OnUsernameInteract(Action<Vector2, UltimateChatBox.ChatInformation> value) { }

	[CompilerGenerated]
	// RVA: 0x6A3020 Offset: 0x6A1620 VA: 0x1806A3020
	public void add_OnInputFieldEnabled(Action value) { }

	[CompilerGenerated]
	// RVA: 0x6A3E70 Offset: 0x6A2470 VA: 0x1806A3E70
	public void remove_OnInputFieldEnabled(Action value) { }

	[CompilerGenerated]
	// RVA: 0x6A2F80 Offset: 0x6A1580 VA: 0x1806A2F80
	public void add_OnInputFieldDisabled(Action value) { }

	[CompilerGenerated]
	// RVA: 0x6A3DD0 Offset: 0x6A23D0 VA: 0x1806A3DD0
	public void remove_OnInputFieldDisabled(Action value) { }

	[CompilerGenerated]
	// RVA: 0x6A3170 Offset: 0x6A1770 VA: 0x1806A3170
	public void add_OnInputFieldUpdated(Action<string> value) { }

	[CompilerGenerated]
	// RVA: 0x6A3FC0 Offset: 0x6A25C0 VA: 0x1806A3FC0
	public void remove_OnInputFieldUpdated(Action<string> value) { }

	[CompilerGenerated]
	// RVA: 0x6A30C0 Offset: 0x6A16C0 VA: 0x1806A30C0
	public void add_OnInputFieldSubmitted(Action<string> value) { }

	[CompilerGenerated]
	// RVA: 0x6A3F10 Offset: 0x6A2510 VA: 0x1806A3F10
	public void remove_OnInputFieldSubmitted(Action<string> value) { }

	[CompilerGenerated]
	// RVA: 0x6A2ED0 Offset: 0x6A14D0 VA: 0x1806A2ED0
	public void add_OnInputFieldCommandUpdated(Action<string, string> value) { }

	[CompilerGenerated]
	// RVA: 0x6A3D20 Offset: 0x6A2320 VA: 0x1806A3D20
	public void remove_OnInputFieldCommandUpdated(Action<string, string> value) { }

	[CompilerGenerated]
	// RVA: 0x6A2E20 Offset: 0x6A1420 VA: 0x1806A2E20
	public void add_OnInputFieldCommandSubmitted(Action<string, string> value) { }

	[CompilerGenerated]
	// RVA: 0x6A3C70 Offset: 0x6A2270 VA: 0x1806A3C70
	public void remove_OnInputFieldCommandSubmitted(Action<string, string> value) { }

	[CompilerGenerated]
	// RVA: 0x6A2D80 Offset: 0x6A1380 VA: 0x1806A2D80
	public void add_OnExtraImageInteract(Action value) { }

	[CompilerGenerated]
	// RVA: 0x6A3BD0 Offset: 0x6A21D0 VA: 0x1806A3BD0
	public void remove_OnExtraImageInteract(Action value) { }

	// RVA: 0x69C440 Offset: 0x69AA40 VA: 0x18069C440
	private void Start() { }

	// RVA: 0x6A1570 Offset: 0x69FB70 VA: 0x1806A1570
	private void Update() { }

	// RVA: 0x698F70 Offset: 0x697570 VA: 0x180698F70
	private void OnEnable() { }

	// RVA: 0x69A320 Offset: 0x698920 VA: 0x18069A320
	private void ProcessNavigationSections() { }

	// RVA: 0x69B240 Offset: 0x699840 VA: 0x18069B240
	private void ProcessToggle() { }

	// RVA: 0x699130 Offset: 0x697730 VA: 0x180699130
	private void ProcessCollapse() { }

	// RVA: 0x69B030 Offset: 0x699630 VA: 0x18069B030
	private void ProcessScrollbarToggle() { }

	// RVA: 0x697E40 Offset: 0x696440 VA: 0x180697E40
	private void DisableScrollbar() { }

	// RVA: 0x6996F0 Offset: 0x697CF0 VA: 0x1806996F0
	private void ProcessInputField() { }

	// RVA: 0x69CB30 Offset: 0x69B130 VA: 0x18069CB30
	private void UpdateChatBoxComponentSizes() { }

	// RVA: 0x696E90 Offset: 0x695490 VA: 0x180696E90
	private Rect CalculateRect(RectTransform rectTransform) { }

	// RVA: 0x696CE0 Offset: 0x6952E0 VA: 0x180696CE0
	private void AdjustChatBoxScreenRect() { }

	// RVA: 0x696FE0 Offset: 0x6955E0 VA: 0x180696FE0
	private void CalculateUsernameRect(UltimateChatBox.ChatInformation chatInfo) { }

	// RVA: 0x697270 Offset: 0x695870 VA: 0x180697270
	private void ConstrainContentBox() { }

	// RVA: 0x697630 Offset: 0x695C30 VA: 0x180697630
	private void ConstrainScrollbarHandle() { }

	// RVA: 0x69D1D0 Offset: 0x69B7D0 VA: 0x18069D1D0
	private void UpdateChatBoxVisibility() { }

	// RVA: 0x69BF70 Offset: 0x69A570 VA: 0x18069BF70
	private void RepositionAllChats() { }

	// RVA: 0x698F80 Offset: 0x697580 VA: 0x180698F80
	private void OnTransformParentChanged() { }

	// RVA: 0x698BD0 Offset: 0x6971D0 VA: 0x180698BD0
	private TextMeshProUGUI GetTextFromPool() { }

	// RVA: 0x69C370 Offset: 0x69A970 VA: 0x18069C370
	private void SendTextToPool(TextMeshProUGUI chatText) { }

	// RVA: 0x69B3E0 Offset: 0x6999E0 VA: 0x18069B3E0
	private void RegisterChatInternal(string username, string message, UltimateChatBox.ChatStyle style) { }

	// RVA: 0x698A80 Offset: 0x697080 VA: 0x180698A80
	private static string FormatDebug(string error, string solution, string objectName) { }

	// RVA: 0x69D930 Offset: 0x69BF30 VA: 0x18069D930
	public void UpdatePositioning() { }

	// RVA: 0x69BC40 Offset: 0x69A240 VA: 0x18069BC40
	public void RegisterChat(string message) { }

	// RVA: 0x69BCD0 Offset: 0x69A2D0 VA: 0x18069BCD0
	public void RegisterChat(string message, UltimateChatBox.ChatStyle style) { }

	// RVA: 0x69BDE0 Offset: 0x69A3E0 VA: 0x18069BDE0
	public void RegisterChat(string username, string message) { }

	// RVA: 0x69BE70 Offset: 0x69A470 VA: 0x18069BE70
	public void RegisterChat(string username, string message, UltimateChatBox.ChatStyle style) { }

	// RVA: 0x698400 Offset: 0x696A00 VA: 0x180698400
	public void Enable() { }

	// RVA: 0x697E90 Offset: 0x696490 VA: 0x180697E90
	public void Disable(bool instant = False) { }

	// RVA: 0x697070 Offset: 0x695670 VA: 0x180697070
	public void ClearChat() { }

	// RVA: 0x6980A0 Offset: 0x6966A0 VA: 0x1806980A0
	public void EnableInputField(string inputFieldValue = "") { }

	// RVA: 0x69CAC0 Offset: 0x69B0C0 VA: 0x18069CAC0
	public void ToggleInputField() { }

	// RVA: 0x6979C0 Offset: 0x695FC0 VA: 0x1806979C0
	public void DisableInputField() { }

	// RVA: 0x69C350 Offset: 0x69A950 VA: 0x18069C350
	public void SendCustomInput(Vector2 screenPosition, bool getButtonDown, bool getButton) { }

	// RVA: 0x6985A0 Offset: 0x696BA0 VA: 0x1806985A0
	public List<UltimateChatBox.ChatInformation> FindChatsFromUser(string username) { }

	// RVA: 0x698830 Offset: 0x696E30 VA: 0x180698830
	public List<UltimateChatBox.ChatInformation> FindChatsOfStyle(UltimateChatBox.ChatStyle style) { }

	// RVA: 0x698E40 Offset: 0x697440 VA: 0x180698E40
	private void InjectUpdate() { }

	// RVA: 0x698E20 Offset: 0x697420 VA: 0x180698E20
	private void InjectRegisterChat() { }

	// RVA: 0x698DF0 Offset: 0x6973F0 VA: 0x180698DF0
	private void InjectOnEnable() { }

	// RVA: 0x698DB0 Offset: 0x6973B0 VA: 0x180698DB0
	private void InjectOnDisable(bool instant) { }

	[CompilerGenerated]
	// RVA: 0x6A38A0 Offset: 0x6A1EA0 VA: 0x1806A38A0
	private bool get_Initializing() { }

	[CompilerGenerated]
	// RVA: 0x6A44C0 Offset: 0x6A2AC0 VA: 0x1806A44C0
	public void set_Initializing(bool value) { }

	[CompilerGenerated]
	// RVA: 0x6A35B0 Offset: 0x6A1BB0 VA: 0x1806A35B0
	public bool get_DisableInteraction() { }

	[CompilerGenerated]
	// RVA: 0x6A41E0 Offset: 0x6A27E0 VA: 0x1806A41E0
	public void set_DisableInteraction(bool value) { }

	// RVA: 0x699520 Offset: 0x697B20 VA: 0x180699520
	private void ProcessHide(bool skipTimer = False) { }

	// RVA: 0x69B110 Offset: 0x699710 VA: 0x18069B110
	private void ProcessShow(bool receivedChat = False) { }

	// RVA: 0x6978F0 Offset: 0x695EF0 VA: 0x1806978F0
	public void DisableChat(bool forced = False) { }

	// RVA: 0x69D760 Offset: 0x69BD60 VA: 0x18069D760
	public void UpdateDisplayConfig(UltimateChatBox.DisplayConfig config, RectTransform chatPrompt) { }

	// RVA: 0x6A25A0 Offset: 0x6A0BA0 VA: 0x1806A25A0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x69CB20 Offset: 0x69B120 VA: 0x18069CB20
	private void <Start>b__276_0(TouchScreenKeyboard.Status status) { }
}
