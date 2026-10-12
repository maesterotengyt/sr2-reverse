// Namespace: 
public class GamecubeAdapterDriver : MonoBehaviour // TypeDefIndex: 3434
{
	// Fields
	public const int READSIZE = 37;
	private static ErrorCode lastErrorCode; // 0x0
	public static bool hasDevice; // 0x4
	public static bool hasReader; // 0x5
	public static long lastDriverTick; // 0x8
	public static ThreadPriority currentDriverPriority; // 0x10
	public const int ADAPTER_VENDOR = 1406;
	public const int ADAPTER_PRODUCT = 823;
	private static GamecubeAdapterDriver _instance; // 0x18
	private float checkdevicestimer; // 0x20
	private Thread driverThread; // 0x28
	private static readonly bool[] STICK_bytes; // 0x20
	private bool rundriver; // 0x30
	private bool closeDevice; // 0x31

	// Properties
	public static ErrorCode LastErrorCode { get; }

	// Methods

	// RVA: 0x5CE960 Offset: 0x5CCF60 VA: 0x1805CE960
	public static ErrorCode get_LastErrorCode() { }

	// RVA: 0x5CDAE0 Offset: 0x5CC0E0 VA: 0x1805CDAE0
	public static void EnsureGamecubeAdapterDriver() { }

	// RVA: 0x5CE6B0 Offset: 0x5CCCB0 VA: 0x1805CE6B0
	private void Update() { }

	// RVA: 0x5CE560 Offset: 0x5CCB60 VA: 0x1805CE560
	private void StartDriver() { }

	// RVA: 0x5CDD30 Offset: 0x5CC330 VA: 0x1805CDD30
	private void OnApplicationQuit() { }

	// RVA: 0x5CE670 Offset: 0x5CCC70 VA: 0x1805CE670
	private bool StickBig(byte ns, byte ps) { }

	// RVA: 0x5CDA30 Offset: 0x5CC030 VA: 0x1805CDA30
	private static void DefaultStick(ref byte[] data) { }

	// RVA: 0x5CDD50 Offset: 0x5CC350 VA: 0x1805CDD50
	private void RunDriver() { }

	// RVA: 0x4F3DE0 Offset: 0x4F23E0 VA: 0x1804F3DE0
	public void .ctor() { }

	// RVA: 0x5CE870 Offset: 0x5CCE70 VA: 0x1805CE870
	private static void .cctor() { }
}
