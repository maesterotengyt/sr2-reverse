// Namespace: Quantum
public struct AxisSettings // TypeDefIndex: 10449
{
	// Fields
	public int DirectionFrames; // 0x0
	public FP AxisDeadzone; // 0x8
	public FP AxisDetectionThreshold; // 0x10
	public FP UpMinAngle; // 0x18
	public FP UpMaxAngle; // 0x20
	public FP ForwardMinAngle; // 0x28
	public FP ForwardMaxAngle; // 0x30
	public FP DownMinAngle; // 0x38
	public FP DownMaxAngle; // 0x40

	// Methods

	// RVA: 0x21B1690 Offset: 0x21AFC90 VA: 0x1821B1690
	public void Initialize(GameplayInputSettingsData gameplayInputSettingsData, bool grounded) { }
}
