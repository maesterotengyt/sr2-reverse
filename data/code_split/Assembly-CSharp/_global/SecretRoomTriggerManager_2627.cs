// Namespace: 
public class SecretRoomTriggerManager : MonoBehaviour // TypeDefIndex: 2627
{
	// Fields
	public GameObject WallMesh; // 0x20
	public EntityView View; // 0x28
	public string AlphaShaderProperty; // 0x30
	public float FadeOutTime; // 0x38
	public float MaxAlpha; // 0x3C
	public float MinAlpha; // 0x40
	private Renderer wallMeshRenderer; // 0x48
	private MaterialPropertyBlock mpb; // 0x50
	private bool fadingOut; // 0x58
	private float fadeOutTimer; // 0x5C
	private int alphaPropertyID; // 0x60

	// Methods

	// RVA: 0x722130 Offset: 0x720730 VA: 0x180722130
	private void Awake() { }

	// RVA: 0x7222F0 Offset: 0x7208F0 VA: 0x1807222F0
	private void Update() { }

	// RVA: 0x7222A0 Offset: 0x7208A0 VA: 0x1807222A0
	private void OnSecretRoomDiscovered(EventOnSecretRoomDiscovered callback) { }

	// RVA: 0x722440 Offset: 0x720A40 VA: 0x180722440
	public void .ctor() { }
}
