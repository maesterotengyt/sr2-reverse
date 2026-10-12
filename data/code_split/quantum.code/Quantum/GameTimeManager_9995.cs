// Namespace: Quantum
public struct GameTimeManager : IComponent // TypeDefIndex: 9995
{
	// Fields
	public FP GameSpeed; // 0x8
	public QBoolean Paused; // 0x0
	[PtrQList(typeof(RuntimeGameSpeedModifier))]
	private Ptr SpeedModifiersPtr; // 0x4

	// Properties
	public QListPtr<RuntimeGameSpeedModifier> SpeedModifiers { get; set; }

	// Methods

	// RVA: 0x211A810 Offset: 0x2118E10 VA: 0x18211A810
	public QListPtr<RuntimeGameSpeedModifier> get_SpeedModifiers() { }

	// RVA: 0x526D50 Offset: 0x525350 VA: 0x180526D50
	public void set_SpeedModifiers(QListPtr<RuntimeGameSpeedModifier> value) { }

	// RVA: 0x2119F60 Offset: 0x2118560 VA: 0x182119F60 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20CCF30 Offset: 0x20CB530 VA: 0x1820CCF30
	public void ClearPointers(Frame f, EntityRef entity) { }

	// RVA: 0x2119F90 Offset: 0x2118590 VA: 0x182119F90
	public static void OnRemoved(FrameBase frame, EntityRef entity, void* ptr) { }

	// RVA: 0x211A160 Offset: 0x2118760 VA: 0x18211A160
	public static void Serialize(void* ptr, FrameSerializer serializer) { }

	// RVA: 0x211A620 Offset: 0x2118C20 VA: 0x18211A620
	public static bool TryFind(Frame frame, out GameTimeManager* gameTimeManager) { }

	// RVA: 0x2119EC0 Offset: 0x21184C0 VA: 0x182119EC0
	public static FP DeltaTime(Frame frame) { }

	// RVA: 0x211A7E0 Offset: 0x2118DE0 VA: 0x18211A7E0
	public static FP UnscaledDeltaTime(Frame frame) { }

	// RVA: 0x21199F0 Offset: 0x2117FF0 VA: 0x1821199F0
	public static void AddSpeedModifier(Frame frame, GameSpeedModifier speedModifier) { }

	// RVA: 0x211A010 Offset: 0x2118610 VA: 0x18211A010
	public static void RemoveSpeedModifier(Frame frame, int speedModifierID) { }

	// RVA: 0x2119D60 Offset: 0x2118360 VA: 0x182119D60
	private void CalculateGameSpeed(Frame frame) { }

	// RVA: 0x211A220 Offset: 0x2118820 VA: 0x18211A220
	public static void StartFrameByFrame(Frame frame) { }

	// RVA: 0x211A470 Offset: 0x2118A70 VA: 0x18211A470
	public static void StopFrameByFrame(Frame frame) { }

	// RVA: 0x2119BA0 Offset: 0x21181A0 VA: 0x182119BA0
	public static void AdvanceFrameByFrame(Frame frame) { }
}
