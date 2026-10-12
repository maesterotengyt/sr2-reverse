// Namespace: 
public class StellarHoldBar : StellarMonoBehaviour // TypeDefIndex: 3697
{
	// Fields
	[Header("Data")]
	public float TimeToHold; // 0x20
	public float FillAmoutToExecuteAction; // 0x24
	public UnityEvent FillEvent; // 0x28
	public UIKey UIKey; // 0x30
	[Header("Elements")]
	public Animator Animator; // 0x38
	public Image HoldBar; // 0x40
	private float barHoldTime; // 0x48
	private bool complete; // 0x4C

	// Methods

	// RVA: 0x64DC50 Offset: 0x64C250 VA: 0x18064DC50
	public void ResetBar() { }

	// RVA: 0x64DA30 Offset: 0x64C030 VA: 0x18064DA30
	public bool CheckHoldBar(int inputDeviceIndex = -1) { }

	// RVA: 0x64DD20 Offset: 0x64C320 VA: 0x18064DD20
	public void .ctor() { }
}
