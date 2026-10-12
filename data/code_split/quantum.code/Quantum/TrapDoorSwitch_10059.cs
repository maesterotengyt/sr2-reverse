// Namespace: Quantum
public struct TrapDoorSwitch : IComponent // TypeDefIndex: 10059
{
	// Fields
	public TrapDoorSwitchActivationMode ActivationMode; // 0x8
	public EntityRef Entity; // 0x10
	public FP FramesToDeactivate; // 0x18
	[HideInInspector]
	public QBoolean IsOn; // 0x4
	[HideInInspector]
	public FP RuntimeFramesToDeactivate; // 0x20
	public QString64 SwitchID; // 0x28
	[HideInInspector]
	public int SwitchIDHash; // 0x0

	// Methods

	// RVA: 0x21357A0 Offset: 0x2133DA0 VA: 0x1821357A0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2135B50 Offset: 0x2134150 VA: 0x182135B50
	public static void Serialize(void* ptr, FrameSerializer serializer) { }

	// RVA: 0x2135820 Offset: 0x2133E20 VA: 0x182135820
	public void Init(Frame frame) { }

	// RVA: 0x2135C30 Offset: 0x2134230 VA: 0x182135C30
	public void Update(Frame frame) { }

	// RVA: 0x2135860 Offset: 0x2133E60 VA: 0x182135860
	public void OnBodyEnter(Frame frame) { }

	// RVA: 0x2135100 Offset: 0x2133700 VA: 0x182135100
	public void Activate(Frame frame, bool notifyOthers = False) { }

	// RVA: 0x2135450 Offset: 0x2133A50 VA: 0x182135450
	public void Deactivate(Frame frame, bool notifyOthers = False) { }

	// RVA: 0x2135890 Offset: 0x2133E90 VA: 0x182135890
	private void PlayActivationFX(Frame frame, bool notifyOthers) { }
}
