// Namespace: 
[Serializable]
public class UltimateChatBox.ChatInformation // TypeDefIndex: 4028
{
	// Fields
	public UltimateChatBox chatBox; // 0x10
	[CompilerGenerated]
	private bool <IsVisible>k__BackingField; // 0x18
	public TextMeshProUGUI chatText; // 0x20
	[CompilerGenerated]
	private string <Username>k__BackingField; // 0x28
	[CompilerGenerated]
	private string <DisplayUsername>k__BackingField; // 0x30
	[CompilerGenerated]
	private string <Message>k__BackingField; // 0x38
	[CompilerGenerated]
	private string <DisplayMessage>k__BackingField; // 0x40
	public Rect usernameRect; // 0x48
	public float contentSpace; // 0x58
	public Vector2 anchoredPosition; // 0x5C
	public float usernameWidth; // 0x64
	public float lineHeight; // 0x68
	public int lineCount; // 0x6C
	public UltimateChatBox.ChatStyle chatBoxStyle; // 0x70

	// Properties
	public bool IsVisible { get; set; }
	public string Username { get; set; }
	public string DisplayUsername { get; set; }
	public string Message { get; set; }
	public string DisplayMessage { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x676D40 Offset: 0x675340 VA: 0x180676D40
	public bool get_IsVisible() { }

	[CompilerGenerated]
	// RVA: 0x676D50 Offset: 0x675350 VA: 0x180676D50
	private void set_IsVisible(bool value) { }

	[CompilerGenerated]
	// RVA: 0x504CA0 Offset: 0x5032A0 VA: 0x180504CA0
	public string get_Username() { }

	[CompilerGenerated]
	// RVA: 0x566E20 Offset: 0x565420 VA: 0x180566E20
	public void set_Username(string value) { }

	[CompilerGenerated]
	// RVA: 0x503090 Offset: 0x501690 VA: 0x180503090
	public string get_DisplayUsername() { }

	[CompilerGenerated]
	// RVA: 0x52CEF0 Offset: 0x52B4F0 VA: 0x18052CEF0
	public void set_DisplayUsername(string value) { }

	[CompilerGenerated]
	// RVA: 0x5C5B40 Offset: 0x5C4140 VA: 0x1805C5B40
	public string get_Message() { }

	[CompilerGenerated]
	// RVA: 0x5C5B90 Offset: 0x5C4190 VA: 0x1805C5B90
	public void set_Message(string value) { }

	[CompilerGenerated]
	// RVA: 0x5C5B30 Offset: 0x5C4130 VA: 0x1805C5B30
	public string get_DisplayMessage() { }

	[CompilerGenerated]
	// RVA: 0x5C5B80 Offset: 0x5C4180 VA: 0x1805C5B80
	public void set_DisplayMessage(string value) { }

	// RVA: 0x6A5340 Offset: 0x6A3940 VA: 0x1806A5340
	public void UpdateText() { }

	// RVA: 0x6A53E0 Offset: 0x6A39E0 VA: 0x1806A53E0
	public void UpdateVisibility() { }

	// RVA: 0x6A5280 Offset: 0x6A3880 VA: 0x1806A5280
	public void RemoveChat() { }

	// RVA: 0x6A5610 Offset: 0x6A3C10 VA: 0x1806A5610
	public void .ctor() { }
}
