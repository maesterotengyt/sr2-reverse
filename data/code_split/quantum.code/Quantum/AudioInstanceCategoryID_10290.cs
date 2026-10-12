// Namespace: Quantum
public class AudioInstanceCategoryID // TypeDefIndex: 10290
{
	// Fields
	public static HashString Announcer; // 0x0
	public static HashString General; // 0x10
	public static HashString CharacterVoiceOver; // 0x20
	public static HashString UI; // 0x30

	// Methods

	// RVA: 0x2165570 Offset: 0x2163B70 VA: 0x182165570
	public static List<HashString> GetAllCategories() { }

	// RVA: 0x2165850 Offset: 0x2163E50 VA: 0x182165850
	private static void PopulateCategories(List<HashString> categories) { }

	// RVA: 0x2165330 Offset: 0x2163930 VA: 0x182165330
	public static bool AllowsMultipleInstancesPerSource(HashString category) { }

	// RVA: 0x21654E0 Offset: 0x2163AE0 VA: 0x1821654E0
	private static void AllowsMultipleInstancesPerSource(HashString category, ref bool result) { }

	// RVA: 0x2165930 Offset: 0x2163F30 VA: 0x182165930
	private static void .cctor() { }
}
