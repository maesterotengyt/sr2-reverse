// Namespace: 
public class BlastzoneExplosionCameraUpdater : SRMonoBehaviour // TypeDefIndex: 2866
{
	// Fields
	public Camera TargetCamera; // 0x20
	public RenderTexture OutputTexture; // 0x28
	[Range(1, 60)]
	public int RenderFrameRate; // 0x30
	[Range(1, 60)]
	public int RenderFrameRateSwitch; // 0x34
	private UniversalRenderPipeline.SingleCameraRequest renderRequest; // 0x38
	private Coroutine renderCoroutine; // 0x40
	private float renderInterval; // 0x48
	private float nextRenderTime; // 0x4C

	// Methods

	// RVA: 0x741470 Offset: 0x73FA70 VA: 0x180741470
	private void Awake() { }

	// RVA: 0x7417F0 Offset: 0x73FDF0 VA: 0x1807417F0
	private void Start() { }

	// RVA: 0x741620 Offset: 0x73FC20 VA: 0x180741620
	private void OnEnable() { }

	// RVA: 0x7415E0 Offset: 0x73FBE0 VA: 0x1807415E0
	private void OnDisable() { }

	[IteratorStateMachine(typeof(BlastzoneExplosionCameraUpdater.<RenderAtFixedRate>d__12))]
	// RVA: 0x741780 Offset: 0x73FD80 VA: 0x180741780
	private IEnumerator RenderAtFixedRate() { }

	// RVA: 0x53A8F0 Offset: 0x538EF0 VA: 0x18053A8F0
	public void .ctor() { }
}
