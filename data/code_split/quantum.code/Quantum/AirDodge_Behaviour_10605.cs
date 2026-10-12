// Namespace: Quantum
[Serializable]
public class AirDodge_Behaviour : StateBehaviour // TypeDefIndex: 10605
{
	// Fields
	public int FramesToDetectAirDodgeLand; // 0x60
	public FP LandDistanceCheck; // 0x68
	public ColorRGBA AirDodgeLandDebugColor; // 0x70
	[DrawWithLabel]
	public EntityVariable OutAirDodges; // 0x78

	// Methods

	// RVA: 0x20EC110 Offset: 0x20EA710 VA: 0x1820EC110 Slot: 7
	protected override void OnEnter(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x21AF750 Offset: 0x21ADD50 VA: 0x1821AF750 Slot: 8
	protected override void OnExecute(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 10
	protected override void OnExit(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x21AF890 Offset: 0x21ADE90 VA: 0x1821AF890 Slot: 9
	protected override void OnUpdate(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData, int currentFrame) { }

	// RVA: 0x21AFE80 Offset: 0x21AE480 VA: 0x1821AFE80
	public void .ctor() { }
}
