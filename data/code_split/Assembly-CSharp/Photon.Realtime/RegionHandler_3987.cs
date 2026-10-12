// Namespace: Photon.Realtime
public class RegionHandler // TypeDefIndex: 3987
{
	// Fields
	public static Type PingImplementation; // 0x0
	[CompilerGenerated]
	private List<Region> <EnabledRegions>k__BackingField; // 0x10
	private string availableRegionCodes; // 0x18
	private Region bestRegionCache; // 0x20
	private readonly List<RegionPinger> pingerList; // 0x28
	private Action<RegionHandler> onCompleteCall; // 0x30
	private int previousPing; // 0x38
	private string previousSummaryProvided; // 0x40
	protected internal static ushort PortToPingOverride; // 0x8
	private float rePingFactor; // 0x48
	private float pingSimilarityFactor; // 0x4C
	public int BestRegionSummaryPingLimit; // 0x50
	[CompilerGenerated]
	private bool <IsPinging>k__BackingField; // 0x54
	[CompilerGenerated]
	private bool <Aborted>k__BackingField; // 0x55
	private MonoBehaviourEmpty emptyMonoBehavior; // 0x58

	// Properties
	public List<Region> EnabledRegions { get; set; }
	public Region BestRegion { get; }
	public string SummaryToCache { get; }
	public bool IsPinging { get; set; }
	public bool Aborted { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x63D470 Offset: 0x63BA70 VA: 0x18063D470
	public List<Region> get_EnabledRegions() { }

	[CompilerGenerated]
	// RVA: 0x5A8440 Offset: 0x5A6A40 VA: 0x1805A8440
	protected internal void set_EnabledRegions(List<Region> value) { }

	// RVA: 0x67F950 Offset: 0x67DF50 VA: 0x18067F950
	public Region get_BestRegion() { }

	// RVA: 0x67FC60 Offset: 0x67E260 VA: 0x18067FC60
	public string get_SummaryToCache() { }

	// RVA: 0x67E7E0 Offset: 0x67CDE0 VA: 0x18067E7E0
	public string GetResults() { }

	// RVA: 0x67F5F0 Offset: 0x67DBF0 VA: 0x18067F5F0
	public void SetRegions(OperationResponse opGetRegions) { }

	[CompilerGenerated]
	// RVA: 0x5EB800 Offset: 0x5E9E00 VA: 0x1805EB800
	public bool get_IsPinging() { }

	[CompilerGenerated]
	// RVA: 0x5EB810 Offset: 0x5E9E10 VA: 0x1805EB810
	private void set_IsPinging(bool value) { }

	[CompilerGenerated]
	// RVA: 0x67F940 Offset: 0x67DF40 VA: 0x18067F940
	public bool get_Aborted() { }

	[CompilerGenerated]
	// RVA: 0x67FE10 Offset: 0x67E410 VA: 0x18067FE10
	private void set_Aborted(bool value) { }

	// RVA: 0x67F880 Offset: 0x67DE80 VA: 0x18067F880
	public void .ctor(ushort masterServerPortOverride = 0) { }

	// RVA: 0x67F070 Offset: 0x67D670 VA: 0x18067F070
	public bool PingMinimumOfRegions(Action<RegionHandler> onCompleteCallback, string previousSummary) { }

	// RVA: 0x67E560 Offset: 0x67CB60 VA: 0x18067E560
	public void Abort() { }

	// RVA: 0x67EA90 Offset: 0x67D090 VA: 0x18067EA90
	private void OnPreferredRegionPinged(Region preferredRegion) { }

	// RVA: 0x67ED40 Offset: 0x67D340 VA: 0x18067ED40
	private bool PingEnabledRegions() { }

	// RVA: 0x67EAF0 Offset: 0x67D0F0 VA: 0x18067EAF0
	private void OnRegionDone(Region region) { }
}
