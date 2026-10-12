// Namespace: 
[Serializable]
public struct UltimateChatBox.DisplayConfig // TypeDefIndex: 4030
{
	// Fields
	[Header("ChatBox")]
	[Range(0, 100)]
	[Tooltip("X Positioning using percentages")]
	public float HorizontalPosition; // 0x0
	[Range(0, 100)]
	[Tooltip("Y Positioning using percentages")]
	public float VerticalPosition; // 0x4
	[Range(0, 1)]
	[Tooltip("X Scaling using percentages")]
	public float HorizontalRatio; // 0x8
	[Range(0, 1)]
	[Tooltip("Y Scaling using percentages")]
	public float VerticalRatio; // 0xC
	[Min(0.1)]
	[Tooltip("Box scale, modifies size of all elements")]
	public float ChatBoxSize; // 0x10
	[Header("Content")]
	[Range(-50, 50)]
	[Tooltip("X Positioning for the text lines")]
	public float HorizontalContentPosition; // 0x14
	[Range(-50, 50)]
	[Tooltip("Y Positioning for the text lines")]
	public float VerticalContentPosition; // 0x18
	[Range(0, 50)]
	[Tooltip("X Spacing for the text lines")]
	public float HorizontalContentSpacing; // 0x1C
	[Range(0, 50)]
	[Tooltip("Y Spacing for the text lines")]
	public float VerticalContentSpacing; // 0x20
	[Range(0, 0.2)]
	[Tooltip("Automatic text size")]
	public float SmartFontSize; // 0x24
	[Min(0)]
	[Tooltip("Automatic text size")]
	public float SpaceBetweenChats; // 0x28
	[Range(0, 1)]
	[Tooltip("Alpha when it's disabled")]
	public float ToggledAlpha; // 0x2C
	[Header("Children Transforms")]
	[Tooltip("Vertical distance from the input field center")]
	public float EscapePromptVerticalOffset; // 0x30
	[Tooltip("Is the prompt located at the right border? Else it is at the left border")]
	public bool RightSided; // 0x34
}
