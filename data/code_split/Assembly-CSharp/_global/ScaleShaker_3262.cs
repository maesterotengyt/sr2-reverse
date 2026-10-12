// Namespace: 
public class ScaleShaker : MonoBehaviour // TypeDefIndex: 3262
{
	// Fields
	[Header("Shake Settings")]
	[Tooltip("How much the object scales up/down during the shake.")]
	public float shakeIntensity; // 0x20
	[Tooltip("How fast the scale changes.")]
	public float shakeSpeed; // 0x24
	[Tooltip("Random variation applied to the shake speed.")]
	public float speedRandomness; // 0x28
	[Tooltip("Enable or disable shaking.")]
	public bool isShaking; // 0x2C
	private Vector3 originalScale; // 0x30
	private float timeOffset; // 0x3C

	// Methods

	// RVA: 0x5A2F90 Offset: 0x5A1590 VA: 0x1805A2F90
	private void Start() { }

	// RVA: 0x5A2FF0 Offset: 0x5A15F0 VA: 0x1805A2FF0
	private void Update() { }

	// RVA: 0x5A2F40 Offset: 0x5A1540 VA: 0x1805A2F40
	private void OnDisable() { }

	// RVA: 0x5A3100 Offset: 0x5A1700 VA: 0x1805A3100
	public void .ctor() { }
}
