// Namespace: Photon.Deterministic
internal static class Log // TypeDefIndex: 17490
{
	// Fields
	private static object sync; // 0x0
	private static Action<string> infoCallback; // 0x8
	private static Action<string> warnCallback; // 0x10
	private static Action<string> errorCallback; // 0x18
	private static Action<Exception> exnCallback; // 0x20

	// Methods

	// RVA: 0x20B1920 Offset: 0x20AFF20 VA: 0x1820B1920
	public static void Init(Action<string> info, Action<string> warn, Action<string> error, Action<Exception> exn) { }

	// RVA: 0x20BEE10 Offset: 0x20BD410 VA: 0x1820BEE10
	public static void Info(string fmt, object[] args) { }

	// RVA: 0x20BEF20 Offset: 0x20BD520 VA: 0x1820BEF20
	public static void Warn(string fmt, object[] args) { }

	// RVA: 0x20BEC10 Offset: 0x20BD210 VA: 0x1820BEC10
	public static void Error(string fmt, object[] args) { }

	// RVA: 0x20BED20 Offset: 0x20BD320 VA: 0x1820BED20
	public static void Exception(Exception exn) { }
}
