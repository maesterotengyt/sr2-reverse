// Namespace: Quantum
public static class Log // TypeDefIndex: 11786
{
	// Fields
	private static object sync; // 0x0
	private static Action<string> infoCallback; // 0x8
	private static Action<string> warnCallback; // 0x10
	private static Action<string> errorCallback; // 0x18
	private static Action<Exception> exnCallback; // 0x20

	// Methods

	// RVA: 0x2225120 Offset: 0x2223720 VA: 0x182225120
	public static void Init(Action<string> info, Action<string> warn, Action<string> error, Action<Exception> exn) { }

	// RVA: 0x2224F00 Offset: 0x2223500 VA: 0x182224F00
	public static void Info(string fmt, object[] args) { }

	// RVA: 0x2225010 Offset: 0x2223610 VA: 0x182225010
	public static void Info(string fmt, string arg0) { }

	// RVA: 0x2225260 Offset: 0x2223860 VA: 0x182225260
	public static void Warn(string fmt, object[] args) { }

	// RVA: 0x2224D00 Offset: 0x2223300 VA: 0x182224D00
	public static void Error(string fmt, object[] args) { }

	// RVA: 0x2224AD0 Offset: 0x22230D0 VA: 0x182224AD0
	public static void Error(string fmt, string arg0) { }

	// RVA: 0x2224BE0 Offset: 0x22231E0 VA: 0x182224BE0
	public static void Error(object value) { }

	// RVA: 0x2224E10 Offset: 0x2223410 VA: 0x182224E10
	public static void Exception(Exception exn) { }
}
