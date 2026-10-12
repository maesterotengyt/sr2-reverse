// Namespace: Quantum
[Serializable]
public struct EscapeRoomCourse // TypeDefIndex: 10388
{
	// Fields
	public string ID; // 0x0
	public HashString LevelToLoad; // 0x8
	public string LayoutToLoad; // 0x18
	public bool HasTimer; // 0x20
	public FP[] TimerSeconds; // 0x28
	public OnTimerCompletion OnTimerCompletion; // 0x30
}
