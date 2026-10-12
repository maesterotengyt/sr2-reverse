// Namespace: Photon.Realtime
public class RegionPinger // TypeDefIndex: 3989
{
	// Fields
	public static int Attempts; // 0x0
	public static int MaxMillisecondsPerPing; // 0x4
	public static int PingWhenFailed; // 0x8
	public int CurrentAttempt; // 0x10
	[CompilerGenerated]
	private bool <Done>k__BackingField; // 0x14
	[CompilerGenerated]
	private bool <Aborted>k__BackingField; // 0x15
	private Action<Region> onDoneCall; // 0x18
	private PhotonPing ping; // 0x20
	private List<int> rttResults; // 0x28
	private Region region; // 0x30
	private string regionAddress; // 0x38

	// Properties
	public bool Done { get; set; }
	public bool Aborted { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x680AB0 Offset: 0x67F0B0 VA: 0x180680AB0
	public bool get_Done() { }

	[CompilerGenerated]
	// RVA: 0x680AD0 Offset: 0x67F0D0 VA: 0x180680AD0
	private void set_Done(bool value) { }

	[CompilerGenerated]
	// RVA: 0x680AA0 Offset: 0x67F0A0 VA: 0x180680AA0
	public bool get_Aborted() { }

	[CompilerGenerated]
	// RVA: 0x680AC0 Offset: 0x67F0C0 VA: 0x180680AC0
	internal void set_Aborted(bool value) { }

	// RVA: 0x6809F0 Offset: 0x67EFF0 VA: 0x1806809F0
	public void .ctor(Region region, Action<Region> onDoneCallback) { }

	// RVA: 0x67FE50 Offset: 0x67E450 VA: 0x18067FE50
	private PhotonPing GetPingImplementation() { }

	// RVA: 0x680710 Offset: 0x67ED10 VA: 0x180680710
	public bool Start() { }

	// RVA: 0x67FE20 Offset: 0x67E420 VA: 0x18067FE20
	protected internal void Abort() { }

	// RVA: 0x6801F0 Offset: 0x67E7F0 VA: 0x1806801F0
	protected internal bool RegionPingThreaded() { }

	[IteratorStateMachine(typeof(RegionPinger.<RegionPingCoroutine>d__22))]
	// RVA: 0x680180 Offset: 0x67E780 VA: 0x180680180
	protected internal IEnumerator RegionPingCoroutine() { }

	// RVA: 0x6800B0 Offset: 0x67E6B0 VA: 0x1806800B0
	public string GetResults() { }

	// RVA: 0x680530 Offset: 0x67EB30 VA: 0x180680530
	public static string ResolveHost(string hostName) { }

	// RVA: 0x680980 Offset: 0x67EF80 VA: 0x180680980
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x680970 Offset: 0x67EF70 VA: 0x180680970
	private void <Start>b__19_0(object o) { }
}
