// Namespace: 
public class StellarOnlineTimer : StellarMonoBehaviour // TypeDefIndex: 3399
{
	// Fields
	public StellarOnlineTimer.OnTimerUpdate TimerUpdate; // 0x20
	public StellarOnlineTimer.OnTimerEnd TimerEnd; // 0x28
	[CompilerGenerated]
	private bool <Active>k__BackingField; // 0x30
	[CompilerGenerated]
	private int <currentTimerSeconds>k__BackingField; // 0x34
	private float currentTimer; // 0x38

	// Properties
	public bool Active { get; set; }
	public int currentTimerSeconds { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x5DCA80 Offset: 0x5DB080 VA: 0x1805DCA80
	public bool get_Active() { }

	[CompilerGenerated]
	// RVA: 0x5DCA90 Offset: 0x5DB090 VA: 0x1805DCA90
	private void set_Active(bool value) { }

	[CompilerGenerated]
	// RVA: 0x5061E0 Offset: 0x5047E0 VA: 0x1805061E0
	public int get_currentTimerSeconds() { }

	[CompilerGenerated]
	// RVA: 0x5061F0 Offset: 0x5047F0 VA: 0x1805061F0
	private void set_currentTimerSeconds(int value) { }

	// RVA: 0x5DC990 Offset: 0x5DAF90 VA: 0x1805DC990
	public void SetTimer(int seconds) { }

	// RVA: 0x5DC9A0 Offset: 0x5DAFA0 VA: 0x1805DC9A0
	public void StartTimer() { }

	// RVA: 0x5DC9B0 Offset: 0x5DAFB0 VA: 0x1805DC9B0
	public void StopTimer(bool callback = True) { }

	// RVA: 0x5DC9E0 Offset: 0x5DAFE0 VA: 0x1805DC9E0
	private void Update() { }

	// RVA: 0x53A8F0 Offset: 0x538EF0 VA: 0x18053A8F0
	public void .ctor() { }
}
