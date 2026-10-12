// Namespace: Quantum
[Serializable]
public struct MessagePart // TypeDefIndex: 10541
{
	// Fields
	public MessagePartType MessagePartType; // 0x0
	[DrawIf("MessagePartType", 0, 0, 3)]
	public string Text; // 0x8
	[DrawWithLabel]
	[DrawIf("MessagePartType", 1, 0, 3)]
	public EntityVariable Variable; // 0x10
}
