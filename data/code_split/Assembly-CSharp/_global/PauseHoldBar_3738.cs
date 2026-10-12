// Namespace: 
public class PauseHoldBar : SRMonoBehaviour // TypeDefIndex: 3738
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

	// RVA: 0x64CA40 Offset: 0x64B040 VA: 0x18064CA40
	public void ResetBar() { }

	// RVA: 0x64C7C0 Offset: 0x64ADC0 VA: 0x18064C7C0
	public bool CheckHoldBar() { }

	// RVA: 0x64CAD0 Offset: 0x64B0D0 VA: 0x18064CAD0
	public void .ctor() { }
}
