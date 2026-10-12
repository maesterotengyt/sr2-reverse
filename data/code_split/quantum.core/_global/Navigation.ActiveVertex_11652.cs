// Namespace: 
private struct Navigation.ActiveVertex // TypeDefIndex: 11652
{
	// Fields
	public int Slot; // 0x0
	public int Index; // 0x4
	public Navigation.ActiveVertex* Parent; // 0x8
	public FPVector3 Pivot; // 0x10
	public long F; // 0x28
	public long G; // 0x30
	public long H; // 0x38
	public int PortalLeft; // 0x40
	public int PortalRight; // 0x44
	public int Link; // 0x48

	// Methods

	// RVA: 0x2217F90 Offset: 0x2216590 VA: 0x182217F90 Slot: 3
	public override string ToString() { }

	// RVA: 0x526D40 Offset: 0x525340 VA: 0x180526D40 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2217D60 Offset: 0x2216360 VA: 0x182217D60 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2217C50 Offset: 0x2216250 VA: 0x182217C50
	public void Create(int index, FPVector3 pivot) { }

	// RVA: 0x2217C10 Offset: 0x2216210 VA: 0x182217C10
	public void Create(int index, FPVector3 pivot, int portalLeft, int portalRight, Navigation.ActiveVertex* parent, Navigation.PathQuality quality, int slot = 0) { }

	// RVA: 0x2217C80 Offset: 0x2216280 VA: 0x182217C80
	internal static long Distance(FPVector3 a, FPVector3 b, Navigation.PathQuality quality) { }

	// RVA: 0x22175B0 Offset: 0x2215BB0 VA: 0x1822175B0
	public static FPVector3 CreatePivot(int index, int portalLeft, int portalRight, FPVector3 start, FPVector3 goal, Navigation.ActiveVertex* parent, Navigation.PathQuality quality, NavMesh navmesh) { }

	// RVA: 0x2217120 Offset: 0x2215720 VA: 0x182217120
	public static long CalculateCost(FPVector3 start, FPVector3 pivot, Navigation.ActiveVertex* parent, Navigation.PathQuality quality, long costFactor) { }

	// RVA: 0x2217360 Offset: 0x2215960 VA: 0x182217360
	internal static FPVector3 ClosestPointOnSegment(FPVector3 pt, FPVector3 v0, FPVector3 v1) { }

	// RVA: 0x2217DD0 Offset: 0x22163D0 VA: 0x182217DD0
	public static bool LineIntersectsLine(FPVector3 p1, FPVector3 p2, FPVector3 q1, FPVector3 q2, out FPVector3 point) { }
}
