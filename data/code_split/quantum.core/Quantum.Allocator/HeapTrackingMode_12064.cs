// Namespace: Quantum.Allocator
[Serializable]
public enum HeapTrackingMode // TypeDefIndex: 12064
{
	// Fields
	public byte value__; // 0x0
	public const HeapTrackingMode Disabled = 0;
	public const HeapTrackingMode DetectLeaks = 1;
	public const HeapTrackingMode TraceAllocations = 2;
}
