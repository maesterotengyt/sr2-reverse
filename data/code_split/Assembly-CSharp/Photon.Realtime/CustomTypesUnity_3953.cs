// Namespace: Photon.Realtime
internal static class CustomTypesUnity // TypeDefIndex: 3953
{
	// Fields
	private const int SizeV2 = 8;
	private const int SizeV3 = 12;
	private const int SizeQuat = 16;
	public static readonly byte[] memVector3; // 0x0
	public static readonly byte[] memVector2; // 0x8
	public static readonly byte[] memQuarternion; // 0x10

	// Methods

	// RVA: 0x674460 Offset: 0x672A60 VA: 0x180674460
	internal static void Register() { }

	// RVA: 0x674B30 Offset: 0x673130 VA: 0x180674B30
	private static short SerializeVector3(StreamBuffer outStream, object customobject) { }

	// RVA: 0x674230 Offset: 0x672830 VA: 0x180674230
	private static object DeserializeVector3(StreamBuffer inStream, short length) { }

	// RVA: 0x674910 Offset: 0x672F10 VA: 0x180674910
	private static short SerializeVector2(StreamBuffer outStream, object customobject) { }

	// RVA: 0x674020 Offset: 0x672620 VA: 0x180674020
	private static object DeserializeVector2(StreamBuffer inStream, short length) { }

	// RVA: 0x6746A0 Offset: 0x672CA0 VA: 0x1806746A0
	private static short SerializeQuaternion(StreamBuffer outStream, object customobject) { }

	// RVA: 0x673DA0 Offset: 0x6723A0 VA: 0x180673DA0
	private static object DeserializeQuaternion(StreamBuffer inStream, short length) { }

	// RVA: 0x674D70 Offset: 0x673370 VA: 0x180674D70
	private static void .cctor() { }
}
