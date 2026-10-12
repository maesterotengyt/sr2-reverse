// Namespace: 
public class CharacterSelectWorldBackground : MonoBehaviour // TypeDefIndex: 3029
{
	// Fields
	public List<CharacterSelectWorldBackgroundStateData> StateColorOverrideData; // 0x20
	public Color CPUColor; // 0x28
	public float UIEffectIntensitySpeed; // 0x38
	[Header("Elements")]
	public Image BackgroundImage; // 0x40
	public Image FloorImage; // 0x48
	public GameObject MouseButtonChangeSkin; // 0x50
	public UIEffect BackgroundUIEffect; // 0x58
	public UIEffect FloorUIEffect; // 0x60
	public GameObject EditMenusElements; // 0x68
	private bool editPresetActive; // 0x70
	private float floorUIEffectTargetIntensity; // 0x74
	private float backgroundUIEffectTargetIntensity; // 0x78
	private CharacterSelectBase characterSelect; // 0x80

	// Methods

	// RVA: 0x54C390 Offset: 0x54A990 VA: 0x18054C390 Slot: 4
	public virtual void Initialize(CharacterSelectBase characterSelect) { }

	// RVA: 0x794150 Offset: 0x792750 VA: 0x180794150
	public void SetSelectorLocation(CharacterSelectorLocation location, int selectorNumber, int playerIndex, bool isCPU) { }

	// RVA: 0x794590 Offset: 0x792B90 VA: 0x180794590
	private void Update() { }

	// RVA: 0x7946D0 Offset: 0x792CD0 VA: 0x1807946D0
	public void .ctor() { }
}
