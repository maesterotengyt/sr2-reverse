// Namespace: 
public struct Navigation.VelocityObstacle // TypeDefIndex: 11651
{
	// Fields
	public bool IsValid; // 0x0
	public FPVector2 Apex; // 0x8
	public FPVector2 Left; // 0x18
	public FPVector2 Right; // 0x28
	public FP TruncationLength; // 0x38
	internal Navigation.VelocityObstacle* Next; // 0x40
	private const long CorrectionBiasCandidates0 = 39321;

	// Properties
	private static FPVector2 ZeroVector { get; }

	// Methods

	// RVA: 0x1128E00 Offset: 0x1127400 VA: 0x181128E00
	private static FPVector2 get_ZeroVector() { }

	// RVA: 0x2220F20 Offset: 0x221F520 VA: 0x182220F20
	internal static void GetCandidates0(FPVector2 preferredVelocity, FP preferredSpeed, FP preferredDistanceSqr, int voIndex, Navigation.VelocityObstacle* vo, ref int candidateIndex, Navigation.VelocityCandidate[] candidates, int maxCandidates) { }

	// RVA: 0x2221230 Offset: 0x221F830 VA: 0x182221230
	internal static void GetCandidates1(FPVector2 preferredVelocity, FP preferredDistanceSqr, int voIndex, Navigation.VelocityObstacle* vo, ref int candidateIndex, Navigation.VelocityCandidate[] candidates, int maxCandidates) { }

	// RVA: 0x22214F0 Offset: 0x221FAF0 VA: 0x1822214F0
	internal static void GetCandidates2(FPVector2 preferredVelocity, FP preferredDistanceSqr, int voIndex, Navigation.VelocityObstacle* vo, ref int candidateIndex, Navigation.VelocityCandidate[] candidates, int maxCandidates) { }

	// RVA: 0x22219A0 Offset: 0x221FFA0 VA: 0x1822219A0
	internal static void GetCandidates3(FPVector2 preferredVelocity, FP preferredDistanceSqr, int vo1Index, Navigation.VelocityObstacle* vo1, int vo2Index, Navigation.VelocityObstacle* vo2, ref int candidateIndex, Navigation.VelocityCandidate[] candidates, int maxCandidates) { }
}
