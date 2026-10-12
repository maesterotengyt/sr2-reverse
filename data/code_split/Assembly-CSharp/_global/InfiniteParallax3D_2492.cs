// Namespace: 
public class InfiniteParallax3D : MonoBehaviour // TypeDefIndex: 2492
{
	// Fields
	[Header("Settings")]
	[Tooltip("0 = Foreground (moves fast/static to world). 1 = Sky (follows camera perfectly).")]
	public float ParallaxEffect; // 0x20
	[Tooltip("The manual width/distance of your prefabs. Make sure this matches their actual size in Unity units.")]
	public float panelWidth; // 0x24
	private Transform[] backgroundPanels; // 0x28
	private float lastCameraX; // 0x30
	private Transform cam; // 0x38

	// Methods

	// RVA: 0x62EAE0 Offset: 0x62D0E0 VA: 0x18062EAE0
	private void Start() { }

	// RVA: 0x62E710 Offset: 0x62CD10 VA: 0x18062E710
	private void LateUpdate() { }

	// RVA: 0x62ECA0 Offset: 0x62D2A0 VA: 0x18062ECA0
	public void .ctor() { }
}
