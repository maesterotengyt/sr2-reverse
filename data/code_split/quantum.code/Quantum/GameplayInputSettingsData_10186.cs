// Namespace: Quantum
[Serializable]
public class GameplayInputSettingsData : AssetObject // TypeDefIndex: 10186
{
	// Fields
	public FPVector2 StickMinValues; // 0x20
	public FPVector2 StickMaxValues; // 0x30
	[Space(10)]
	public int GeneralDirectionHoldBufferFrames; // 0x40
	public FP GeneralAxisDeadzone; // 0x48
	public FP GeneralAxisThreshold; // 0x50
	[Space(10)]
	public int FlickDirectionBufferFrames; // 0x58
	public FP FlickAxisDeadzone; // 0x60
	public FP FlickAxisThreshold; // 0x68
	public InputDirectionDetectionSettings GroundedDirectionSettings; // 0x70
	public InputDirectionDetectionSettings AirDirectionSettings; // 0xA0
	public GameSpecificInputSettings GameSpecificButtonSettings; // 0xD0

	// Methods

	// RVA: 0x2148010 Offset: 0x2146610 VA: 0x182148010
	public InputDirectionSettings GenerateDirectionSettings(InputDirection direction, bool flick, bool grounded) { }

	// RVA: 0x50D320 Offset: 0x50B920 VA: 0x18050D320
	public void .ctor() { }
}
