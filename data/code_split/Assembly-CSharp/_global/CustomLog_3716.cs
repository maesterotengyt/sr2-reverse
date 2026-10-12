// Namespace: 
public class CustomLog // TypeDefIndex: 3716
{
	// Fields
	public static string UsernamePrefix; // 0x0
	private const string customLogDataPath = "CustomLog.txt";
	private static CustomLogData logs; // 0x8
	private static string pendingNewData; // 0x10
	private static bool currentSessionHasLog; // 0x18
	private static string previousLog; // 0x20

	// Properties
	private static StellarDataSystem dataSystem { get; }
	private static StellarPlatformSystem platformSystem { get; }
	private static StellarOnlineSystem onlineSystem { get; }
	private static StellarData stellarData { get; }

	// Methods

	// RVA: 0x641640 Offset: 0x63FC40 VA: 0x180641640
	private static StellarDataSystem get_dataSystem() { }

	// RVA: 0x6416E0 Offset: 0x63FCE0 VA: 0x1806416E0
	private static StellarPlatformSystem get_platformSystem() { }

	// RVA: 0x641690 Offset: 0x63FC90 VA: 0x180641690
	private static StellarOnlineSystem get_onlineSystem() { }

	// RVA: 0x641730 Offset: 0x63FD30 VA: 0x180641730
	private static StellarData get_stellarData() { }

	// RVA: 0x640420 Offset: 0x63EA20 VA: 0x180640420
	public static void Print(string logText, string category = "") { }

	// RVA: 0x640180 Offset: 0x63E780 VA: 0x180640180
	public static void PrintError(string logText, string category = "") { }

	// RVA: 0x63E460 Offset: 0x63CA60 VA: 0x18063E460
	private static bool CanPrint(string category) { }

	// RVA: 0x640EB0 Offset: 0x63F4B0 VA: 0x180640EB0
	public static void SaveFile() { }

	// RVA: 0x63E5F0 Offset: 0x63CBF0 VA: 0x18063E5F0
	private static void CheckExistingLog(string fileName, bool exist) { }

	// RVA: 0x6408A0 Offset: 0x63EEA0 VA: 0x1806408A0
	private static void RenameOldLog(string data) { }

	// RVA: 0x63EE90 Offset: 0x63D490 VA: 0x18063EE90
	private static string GetStacktrace() { }

	// RVA: 0x640840 Offset: 0x63EE40 VA: 0x180640840
	private static string RemoveFirstLine(string stackTrace) { }

	// RVA: 0x63F870 Offset: 0x63DE70 VA: 0x18063F870
	public static void PrintCurrentMatch() { }

	// RVA: 0x63F430 Offset: 0x63DA30 VA: 0x18063F430
	public static void PrintCurrentMatchState() { }

	// RVA: 0x63E950 Offset: 0x63CF50 VA: 0x18063E950
	public static string GetCurrentLog() { }

	// RVA: 0x63EB00 Offset: 0x63D100 VA: 0x18063EB00
	public static string GetPlayerLog() { }

	// RVA: 0x640B40 Offset: 0x63F140 VA: 0x180640B40
	public static void RequestPreviousLog() { }

	// RVA: 0x63F2B0 Offset: 0x63D8B0 VA: 0x18063F2B0
	private static void OnPreviousLogLoaded(string data) { }

	// RVA: 0x63EE40 Offset: 0x63D440 VA: 0x18063EE40
	public static string GetPreviousLog() { }

	// RVA: 0x4FA6F0 Offset: 0x4F8CF0 VA: 0x1804FA6F0
	public void .ctor() { }

	// RVA: 0x6414A0 Offset: 0x63FAA0 VA: 0x1806414A0
	private static void .cctor() { }
}
