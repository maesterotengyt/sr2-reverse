// Namespace: 
public class GameCubeAdapterState // TypeDefIndex: 3435
{
	// Fields
	public static GameCubeAdapterState[] states; // 0x0
	private static Stopwatch updLeniency; // 0x8
	private static List<DateTime> receivedTimes; // 0x10
	private static float disconnectTimer; // 0x18
	public static byte[] lastbytes; // 0x20
	public int inputDeviceIndex; // 0x10
	public bool activateOnPlug; // 0x14
	public bool pluggedIn; // 0x15
	public Vector2 controlStick; // 0x18
	public Vector2 cStick; // 0x20
	public bool dpadUp; // 0x28
	public bool dpadDown; // 0x29
	public bool dpadRight; // 0x2A
	public bool dpadLeft; // 0x2B
	public bool Start; // 0x2C
	public bool A; // 0x2D
	public bool B; // 0x2E
	public bool X; // 0x2F
	public bool Y; // 0x30
	public bool Z; // 0x31
	public float RT; // 0x34
	public float LT; // 0x38
	public bool RF; // 0x3C
	public bool LF; // 0x3D
	private const float stickDiv = 0.0078125;
	private const float trigDiv = 0.00390625;
	private const float stickMult = 1.4285715;
	private int stickOriginX; // 0x40
	private int stickOriginY; // 0x44
	private int cstickOriginX; // 0x48
	private int cstickOriginY; // 0x4C
	private byte[] myBytes; // 0x50

	// Properties
	public static int DataPerSecond { get; }

	// Methods

	// RVA: 0x5CD850 Offset: 0x5CBE50 VA: 0x1805CD850
	public static int get_DataPerSecond() { }

	// RVA: 0x5CD470 Offset: 0x5CBA70 VA: 0x1805CD470
	private static void .cctor() { }

	// RVA: 0x5CC9E0 Offset: 0x5CAFE0 VA: 0x1805CC9E0
	public static void ReceiveData(ref byte[] gcdata) { }

	// RVA: 0x5CC0E0 Offset: 0x5CA6E0 VA: 0x1805CC0E0
	public static void CheckDisconnect() { }

	// RVA: 0x5CC3A0 Offset: 0x5CA9A0 VA: 0x1805CC3A0
	private void ClearState() { }

	// RVA: 0x5CC440 Offset: 0x5CAA40 VA: 0x1805CC440
	public void DrawGUI() { }

	// RVA: 0x5CCCA0 Offset: 0x5CB2A0 VA: 0x1805CCCA0
	private void UpdateState(byte[] data, int startindex) { }

	// RVA: 0x5CD780 Offset: 0x5CBD80 VA: 0x1805CD780
	public void .ctor() { }
}
