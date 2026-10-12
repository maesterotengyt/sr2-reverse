// Namespace: 
public class CutsceneCharacterTextBox : SRMonoBehaviour // TypeDefIndex: 2926
{
	// Fields
	public Transform CharacterSpot; // 0x20
	public TMP_Text CharacterNameText; // 0x28
	public TMP_Text DialogueText; // 0x30
	public Animator DialogueBoxAnimator; // 0x38
	public bool IsTyping; // 0x40
	public GameObject CharacterBox; // 0x48
	public GameObject CharacterNameBox; // 0x50
	public GameObject Divider; // 0x58
	public GameObject Ornament; // 0x60
	public GameObject Background; // 0x68
	private int currentVisibleCharacterIndex; // 0x70
	private WaitForSeconds simpleDelay; // 0x78
	private Coroutine TypeWriterCorroutine; // 0x80
	private HashString VODialogue; // 0x88
	private HashString MusicParameter; // 0x98
	[Header("Typewritter settings")]
	[SerializeField]
	private float charactersPerSecond; // 0xA8
	public static CutsceneCharacterTextBox.OnCharacterInstanced CharacterInstanced; // 0x0

	// Methods

	[IteratorStateMachine(typeof(CutsceneCharacterTextBox.<SetupPlayCharacterAnimation>d__18))]
	// RVA: 0x75B390 Offset: 0x759990 VA: 0x18075B390
	private IEnumerator SetupPlayCharacterAnimation(Animator animator, string triggerName) { }

	// RVA: 0x75B420 Offset: 0x759A20 VA: 0x18075B420
	public void ShowBoxData(HashString characterID, string dialogue, HashString CharVODialogue, HashString MusicParameterEffect, bool longAnimation) { }

	[IteratorStateMachine(typeof(CutsceneCharacterTextBox.<ShowBox>d__20))]
	// RVA: 0x75BBF0 Offset: 0x75A1F0 VA: 0x18075BBF0
	public IEnumerator ShowBox(bool hasCharacter) { }

	[IteratorStateMachine(typeof(CutsceneCharacterTextBox.<ShowButtonsOnly>d__21))]
	// RVA: 0x75BC70 Offset: 0x75A270 VA: 0x18075BC70
	public IEnumerator ShowButtonsOnly(float Timer) { }

	[IteratorStateMachine(typeof(CutsceneCharacterTextBox.<StopDialogueMusic>d__22))]
	// RVA: 0x75C050 Offset: 0x75A650 VA: 0x18075C050
	private IEnumerator StopDialogueMusic(float delay) { }

	// RVA: 0x75B9C0 Offset: 0x759FC0 VA: 0x18075B9C0
	public void ShowBoxDialogue(HashString characterID, string dialogue, bool isMirrored, bool stopMusic, float delay) { }

	// RVA: 0x75BE90 Offset: 0x75A490 VA: 0x18075BE90
	public void StartTyping() { }

	// RVA: 0x75BCF0 Offset: 0x75A2F0 VA: 0x18075BCF0
	public void Skip() { }

	[IteratorStateMachine(typeof(CutsceneCharacterTextBox.<Typewritter>d__26))]
	// RVA: 0x75C0D0 Offset: 0x75A6D0 VA: 0x18075C0D0
	private IEnumerator Typewritter() { }

	// RVA: 0x75B120 Offset: 0x759720 VA: 0x18075B120
	public void HideBox() { }

	// RVA: 0x75C140 Offset: 0x75A740 VA: 0x18075C140
	public void .ctor() { }
}
