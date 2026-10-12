// Namespace: 
public class UINavigatorExtendedCalls : MonoBehaviour // TypeDefIndex: 3679
{
	// Fields
	public bool UpEnabled; // 0x20
	[ShowIfBool("UpEnabled", True)]
	[SerializeField]
	public UINavigatorExtendedCalls.UpOverflowEventClass UpOverflowEvent; // 0x28
	public bool DownEnabled; // 0x30
	[ShowIfBool("DownEnabled", True)]
	[SerializeField]
	public UINavigatorExtendedCalls.DownOverflowClass DownOverflowEvent; // 0x38
	public bool LeftEnabled; // 0x40
	[ShowIfBool("LeftEnabled", True)]
	[SerializeField]
	public UINavigatorExtendedCalls.LeftOverflowClass LeftOverflowEvent; // 0x48
	public bool RightEnabled; // 0x50
	[ShowIfBool("RightEnabled", True)]
	[SerializeField]
	public UINavigatorExtendedCalls.RightOverflowClass RightOverflowEvent; // 0x58

	// Methods

	// RVA: 0x620290 Offset: 0x61E890 VA: 0x180620290
	public bool IsIncrementElementEnabled() { }

	// RVA: 0x620280 Offset: 0x61E880 VA: 0x180620280
	public bool IsDecrementElementEnabled() { }

	// RVA: 0x620310 Offset: 0x61E910 VA: 0x180620310
	public void ProcessIncrementElement(int playerIndex) { }

	// RVA: 0x6202A0 Offset: 0x61E8A0 VA: 0x1806202A0
	public void ProcessDecrementElement(int playerIndex) { }

	// RVA: 0x4F3DE0 Offset: 0x4F23E0 VA: 0x1804F3DE0
	public void .ctor() { }
}
