// Namespace: 
public struct SimulatedDeviceInput // TypeDefIndex: 3635
{
	// Fields
	public SimulatedButton FaceTop; // 0x0
	public SimulatedButton FaceBottom; // 0x3
	public SimulatedButton FaceLeft; // 0x6
	public SimulatedButton FaceRight; // 0x9
	public SimulatedButton BumperL; // 0xC
	public SimulatedButton BumperR; // 0xF
	public SimulatedButton TriggerL; // 0x12
	public SimulatedButton TriggerR; // 0x15
	public SimulatedButton DPadUp; // 0x18
	public SimulatedButton DPadDown; // 0x1B
	public SimulatedButton DPadLeft; // 0x1E
	public SimulatedButton DPadRight; // 0x21
	public SimulatedButton Start; // 0x24
	public SimulatedButton Select; // 0x27
	public SimulatedButton LeftStickButton; // 0x2A
	public SimulatedButton LeftStickUp; // 0x2D
	public SimulatedButton LeftStickDown; // 0x30
	public SimulatedButton LeftStickLeft; // 0x33
	public SimulatedButton LeftStickRight; // 0x36
	public Vector2 LeftStickDirection; // 0x3C
	public SimulatedButton RightStickButton; // 0x44
	public SimulatedButton RightStickUp; // 0x47
	public SimulatedButton RightStickDown; // 0x4A
	public SimulatedButton RightStickLeft; // 0x4D
	public SimulatedButton RightStickRight; // 0x50
	public Vector2 RightStickDirection; // 0x54

	// Methods

	// RVA: 0x61AAC0 Offset: 0x6190C0 VA: 0x18061AAC0
	public void Init() { }

	// RVA: 0x61AAD0 Offset: 0x6190D0 VA: 0x18061AAD0
	public void Reset() { }

	// RVA: 0x61AE30 Offset: 0x619430 VA: 0x18061AE30
	public void SetLeftStick(Vector2 leftStick) { }

	// RVA: 0x61AE40 Offset: 0x619440 VA: 0x18061AE40
	public void SetRightStick(Vector2 rightStick) { }

	// RVA: 0x61AC10 Offset: 0x619210 VA: 0x18061AC10
	public void SetButton(ControllerKey button, bool isUp, bool isDown, bool isHold) { }

	// RVA: 0x61A870 Offset: 0x618E70 VA: 0x18061A870
	public SimulatedButton GetButton(ControllerKey button) { }
}
