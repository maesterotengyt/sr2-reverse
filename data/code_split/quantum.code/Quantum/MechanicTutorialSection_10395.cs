// Namespace: Quantum
[Serializable]
public struct MechanicTutorialSection // TypeDefIndex: 10395
{
	// Fields
	public string ID; // 0x0
	public string LayoutToLoad; // 0x8
	public MechanicTutorialGoal[] GoalIDs; // 0x10
	public HurtEvents HurtEvents; // 0x18
	public bool HasTimer; // 0x1B
	public FP TimerSeconds; // 0x20
	public ActionOnTimerCompletion ActionOnTimerCompletion; // 0x28
	[Space(10)]
	public string InitialMessage; // 0x30
}
