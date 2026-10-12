// Namespace: 
public class QuantumInstantReplayDemo : MonoBehaviour // TypeDefIndex: 2474
{
	// Fields
	public float PlaybackSpeed; // 0x20
	[QuantumInspector]
	[ReadOnly]
	public bool IsReplayRunning; // 0x24
	[InspectorButton("Editor_StartInstantReplay", "Start", True)]
	public bool Button_StartInstantReplay; // 0x25
	[InspectorButton("Editor_StopInstantReplay", "Stop", True)]
	public bool Button_StopInstantReplay; // 0x26
	public float ReplayLengthSec; // 0x28
	public bool ShowReplayLabel; // 0x2C
	public bool ShowFadingEffect; // 0x2D
	[Space]
	public QuantumInstantReplaySeekMode RewindMode; // 0x30
	[Header("These only work if RewindMode is set")]
	public bool EnableLoop; // 0x34
	[Range(0, 1)]
	public float NormalizedTime; // 0x38
	private float previousNormalizedTime; // 0x3C
	private QuantumInstantReplay _instantReplay; // 0x40
	private bool _isFading; // 0x48
	private float _fadingAlpha; // 0x4C
	private Texture2D _fadingTexture; // 0x50
	private float _fadingTime; // 0x58

	// Methods

	// RVA: 0x62FEF0 Offset: 0x62E4F0 VA: 0x18062FEF0
	private void Awake() { }

	// RVA: 0x630CD0 Offset: 0x62F2D0 VA: 0x180630CD0
	public void Update() { }

	// RVA: 0x62FFB0 Offset: 0x62E5B0 VA: 0x18062FFB0
	private void CleanUpReplay() { }

	// RVA: 0x6303E0 Offset: 0x62E9E0 VA: 0x1806303E0
	public void OnDisable() { }

	// RVA: 0x630340 Offset: 0x62E940 VA: 0x180630340
	private void OnDestroy() { }

	// RVA: 0x6304A0 Offset: 0x62EAA0 VA: 0x1806304A0
	private void OnGUI() { }

	// RVA: 0x6308B0 Offset: 0x62EEB0 VA: 0x1806308B0
	private void OnReplayStarted(QuantumGame game) { }

	// RVA: 0x630A80 Offset: 0x62F080 VA: 0x180630A80
	private void OnReplayStopped() { }

	// RVA: 0x630C10 Offset: 0x62F210 VA: 0x180630C10
	private void StartFading() { }

	// RVA: 0x630000 Offset: 0x62E600 VA: 0x180630000
	public void Editor_StartInstantReplay() { }

	// RVA: 0x6302F0 Offset: 0x62E8F0 VA: 0x1806302F0
	public void Editor_StopInstantReplay() { }

	// RVA: 0x630EB0 Offset: 0x62F4B0 VA: 0x180630EB0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x630C30 Offset: 0x62F230 VA: 0x180630C30
	private void <Awake>b__16_0(CallbackGameDestroyed c) { }
}
