// Namespace: 
public class CancelHoldBar : SRMonoBehaviour // TypeDefIndex: 2992
{
	// Fields
	[Header("Data")]
	public float TimeToHold; // 0x20
	public float FillAmoutToCancel; // 0x24
	public string HoldSFX; // 0x28
	[Header("Elements")]
	public Animator Animator; // 0x30
	public Image HoldBar; // 0x38
	private float barHoldTime; // 0x40
	private bool start; // 0x44

	// Methods

	// RVA: 0x772940 Offset: 0x770F40 VA: 0x180772940
	public void ResetBar() { }

	// RVA: 0x7726C0 Offset: 0x770CC0 VA: 0x1807726C0
	public bool CheckHoldBar() { }

	// RVA: 0x7729D0 Offset: 0x770FD0 VA: 0x1807729D0
	public void .ctor() { }
}
