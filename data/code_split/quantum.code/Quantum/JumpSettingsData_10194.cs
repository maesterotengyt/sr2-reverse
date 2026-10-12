// Namespace: Quantum
[Serializable]
public class JumpSettingsData : AssetObject // TypeDefIndex: 10194
{
	// Fields
	[Tooltip("Number of frames before triggering the jump")]
	public int JumpAnticipationFrames; // 0x20
	public JumpData GroundJump; // 0x28
	[Space(10)]
	public JumpData GroundShortJump; // 0x30
	[Space(10)]
	public JumpData AirJump; // 0x38
	[Space(10)]
	public JumpData WallJump; // 0x40

	// Methods

	// RVA: 0x2153E10 Offset: 0x2152410 VA: 0x182153E10
	public void .ctor() { }
}
