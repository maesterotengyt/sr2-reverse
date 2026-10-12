// Namespace: 
[Serializable]
public struct KeyboardInputMapping // TypeDefIndex: 3447
{
	// Fields
	[ArrayElementTitle("GameplayKey")]
	public List<GameplayKeyboardMapping> GameplayInputs; // 0x0
	[ArrayElementTitle("Direction")]
	public List<MovementKeyboardMapping> MovementInputs; // 0x8
	[ArrayElementTitle("UIKey")]
	public List<UIKeyboardMapping> UIInputs; // 0x10

	// Methods

	// RVA: 0x5E61D0 Offset: 0x5E47D0 VA: 0x1805E61D0
	public GameplayKeyboardMapping GetGameplayInput(InputFlag inputFlag) { }
}
