// Namespace: 
public class LapsAndPlacementManager : SRMonoBehaviour // TypeDefIndex: 2949
{
	// Fields
	public Animator LapContainerAnimator; // 0x20
	public TextMeshProUGUI LapText; // 0x28
	public Animator PlacementContainerAnimator; // 0x30
	public TextMeshProUGUI PlacementText; // 0x38
	public Image PlacementImage; // 0x40
	public Animator FinalLapContainerAnimator; // 0x48
	public LocalizedString[] OrdinalStrings; // 0x50
	public Sprite[] OrdinalSprites; // 0x58
	private int lastRegisteredLap; // 0x60
	private int lastRegisteredPlacement; // 0x64
	private bool isInFinalLap; // 0x68

	// Methods

	// RVA: 0x769520 Offset: 0x767B20 VA: 0x180769520
	private void Awake() { }

	// RVA: 0x76A000 Offset: 0x768600 VA: 0x18076A000
	public void ResetState() { }

	// RVA: 0x7695E0 Offset: 0x767BE0 VA: 0x1807695E0
	private void OnLapFinished(EventOnLapFinished callback) { }

	// RVA: 0x769C10 Offset: 0x768210 VA: 0x180769C10
	public void OnUpdate() { }

	// RVA: 0x76A330 Offset: 0x768930 VA: 0x18076A330
	public void .ctor() { }
}
