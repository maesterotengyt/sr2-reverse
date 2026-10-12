// Namespace: Quantum
public class FrameCountUtils // TypeDefIndex: 10687
{
	// Methods

	// RVA: 0x20EBB40 Offset: 0x20EA140 VA: 0x1820EBB40
	public static FP FrameTime(Frame frame) { }

	// RVA: 0x20EBD60 Offset: 0x20EA360 VA: 0x1820EBD60
	public static FP UpdateFrameCounter(Frame frame, FP currentValue) { }

	// RVA: 0x20EBDB0 Offset: 0x20EA3B0 VA: 0x1820EBDB0
	public static FP UpdateFrameCounter(Frame frame, FP currentValue, FP speedMultiplier) { }

	// RVA: 0x20EBCB0 Offset: 0x20EA2B0 VA: 0x1820EBCB0
	public static FP UpdateFrameCountdown(Frame frame, FP currentValue) { }

	// RVA: 0x20EBD00 Offset: 0x20EA300 VA: 0x1820EBD00
	public static FP UpdateFrameCountdown(Frame frame, FP currentValue, FP speedMultiplier) { }

	// RVA: 0x20EBBB0 Offset: 0x20EA1B0 VA: 0x1820EBBB0
	public static bool IsFrameCounterComplete(FP currentFrame, FP target) { }

	// RVA: 0x20EBB80 Offset: 0x20EA180 VA: 0x1820EBB80
	public static bool IsFrameCountDownComplete(FP currentFrame) { }

	// RVA: 0x20EBBF0 Offset: 0x20EA1F0 VA: 0x1820EBBF0
	public static FP Progress(FP start, FP end, FP current, bool loop = False) { }

	// RVA: 0x20EBCA0 Offset: 0x20EA2A0 VA: 0x1820EBCA0
	public static int RoundFrame(FP frame) { }
}
