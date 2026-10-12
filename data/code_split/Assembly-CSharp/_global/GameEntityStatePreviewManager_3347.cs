// Namespace: 
[ExecuteAlways]
public class GameEntityStatePreviewManager : MonoBehaviour // TypeDefIndex: 3347
{
	// Fields
	public GameObject SimulationVisualizerObject; // 0x20
	public GameObject GeneralVFXManager; // 0x28
	public Transform EntityContainer; // 0x30
	public Transform VFXContainer; // 0x38
	public int CostumeIndex; // 0x40
	public GameEntityDataAsset TargetEntityData; // 0x48
	private SimpleCustomAnimator mainCustomAnimator; // 0x50
	private AnimationClipDataAsset currentClipData; // 0x58
	[HideInInspector]
	public GameEntityManager targetEntity; // 0x60
	public StellarCollisionsVisualizerData VisualizerData; // 0x68
	private IStellarCollisionsVisualizer simulationVisualizer; // 0x70
	[CompilerGenerated]
	private bool <VFXVisible>k__BackingField; // 0x78

	// Properties
	public GameEntityManager TargetEntity { get; }
	public IStellarCollisionsVisualizer SimulationVisualizer { get; }
	public bool ECBVisible { get; set; }
	public bool HurtBoxesVisible { get; set; }
	public bool HitBoxesVisible { get; set; }
	public bool VFXVisible { get; set; }

	// Methods

	// RVA: 0x5BA920 Offset: 0x5B8F20 VA: 0x1805BA920
	public GameEntityManager get_TargetEntity() { }

	// RVA: 0x5BA7B0 Offset: 0x5B8DB0 VA: 0x1805BA7B0
	public IStellarCollisionsVisualizer get_SimulationVisualizer() { }

	// RVA: 0x5BA690 Offset: 0x5B8C90 VA: 0x1805BA690
	public bool get_ECBVisible() { }

	// RVA: 0x5BAA10 Offset: 0x5B9010 VA: 0x1805BAA10
	public void set_ECBVisible(bool value) { }

	// RVA: 0x5BA750 Offset: 0x5B8D50 VA: 0x1805BA750
	public bool get_HurtBoxesVisible() { }

	// RVA: 0x5BAAF0 Offset: 0x5B90F0 VA: 0x1805BAAF0
	public void set_HurtBoxesVisible(bool value) { }

	// RVA: 0x5BA6F0 Offset: 0x5B8CF0 VA: 0x1805BA6F0
	public bool get_HitBoxesVisible() { }

	// RVA: 0x5BAA80 Offset: 0x5B9080 VA: 0x1805BAA80
	public void set_HitBoxesVisible(bool value) { }

	[CompilerGenerated]
	// RVA: 0x5BAA00 Offset: 0x5B9000 VA: 0x1805BAA00
	public bool get_VFXVisible() { }

	[CompilerGenerated]
	// RVA: 0x5BAB60 Offset: 0x5B9160 VA: 0x1805BAB60
	public void set_VFXVisible(bool value) { }

	// RVA: 0x5BA5C0 Offset: 0x5B8BC0 VA: 0x1805BA5C0
	private void Start() { }

	// RVA: 0x5BA680 Offset: 0x5B8C80 VA: 0x1805BA680
	public void .ctor() { }
}
