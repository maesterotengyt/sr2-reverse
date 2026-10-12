// Namespace: Quantum
[Flags]
public enum QueryOptions // TypeDefIndex: 11746
{
	// Fields
	public int value__; // 0x0
	public const QueryOptions HitStatics = 1;
	public const QueryOptions HitKinematics = 2;
	public const QueryOptions HitDynamics = 4;
	public const QueryOptions HitTriggers = 8;
	public const QueryOptions HitAll = 15;
	public const QueryOptions ComputeDetailedInfo = 32768;
}
