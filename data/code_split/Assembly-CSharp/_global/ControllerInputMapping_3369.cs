// Namespace: 
[Serializable]
public struct ControllerInputMapping // TypeDefIndex: 3369
{
	// Fields
	[ArrayElementTitle("GameplayKey")]
	public List<GameplayControllerMapping> GameplayInputs; // 0x0
	public MovementType MovementType; // 0x8
	[ArrayElementTitle("Direction")]
	public List<MovementControllerMapping> MovementInputs; // 0x10
	[ArrayElementTitle("UIKey")]
	public List<UIControllerMapping> UIInputs; // 0x18

	// Methods

	// RVA: 0x5AE510 Offset: 0x5ACB10 VA: 0x1805AE510
	public GameplayControllerMapping GetGameplayInput(InputFlag inputFlag) { }
}
