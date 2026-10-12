// Namespace: Quantum
[Serializable]
public class InputBufferEventChecker // TypeDefIndex: 10453
{
	// Fields
	public int Frames; // 0x10
	public InputBufferEventChecker.InputActionTypes ActionType; // 0x14
	public InputBufferEventChecker.ButtonState State; // 0x18
	public InputFlag Button; // 0x1C
	public InputDirection Direction; // 0x20
	public bool UseFacingDirection; // 0x24
	public InputBufferEventChecker.DirectionOverride DirectionOverrides; // 0x28
	public FP Deadzone; // 0x30
	public FP DetectionThreshold; // 0x38
	public FP MinAngle; // 0x40
	public FP MaxAngle; // 0x48
	public FP OutputValue; // 0x50

	// Methods

	// RVA: 0x21B9470 Offset: 0x21B7A70 VA: 0x1821B9470
	public bool Check(GameplayInputSettingsData gameplayInputSettingsData, InputBuffer* inputBuffer, out int eventIndex, int startFrame = -1, bool grounded = True, bool invertX = False, bool spendAction = True) { }

	// RVA: 0x21B97E0 Offset: 0x21B7DE0 VA: 0x1821B97E0
	public void .ctor() { }
}
