// Namespace: Quantum
[Extension]
public static class GameObjectUtils // TypeDefIndex: 3847
{
	// Methods

	[Extension]
	// RVA: 0x65B1B0 Offset: 0x6597B0 VA: 0x18065B1B0
	public static void Show(GameObject[] gameObjects) { }

	[Extension]
	// RVA: 0x65B080 Offset: 0x659680 VA: 0x18065B080
	public static void Hide(GameObject[] gameObjects) { }

	[Extension]
	// RVA: 0x65B2A0 Offset: 0x6598A0 VA: 0x18065B2A0
	public static void Show(GameObject gameObject) { }

	[Extension]
	// RVA: 0x65B000 Offset: 0x659600 VA: 0x18065B000
	public static void Hide(GameObject gameObject) { }

	[Extension]
	// RVA: 0x65B3F0 Offset: 0x6599F0 VA: 0x18065B3F0
	public static bool Toggle(GameObject gameObject) { }

	[Extension]
	// RVA: 0x65B4E0 Offset: 0x659AE0 VA: 0x18065B4E0
	public static bool Toggle(GameObject gameObject, bool state) { }

	[Extension]
	// RVA: 0x65B580 Offset: 0x659B80 VA: 0x18065B580
	public static bool Toggle(Component component, bool state) { }

	[Extension]
	// RVA: 0x65B320 Offset: 0x659920 VA: 0x18065B320
	public static void Show(Component component) { }

	[Extension]
	// RVA: 0x65B210 Offset: 0x659810 VA: 0x18065B210
	public static void Show(Image component, Sprite sprite) { }

	[Extension]
	// RVA: 0x65B0E0 Offset: 0x6596E0 VA: 0x18065B0E0
	public static void Hide(Component component) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static void Show<T>(T[] gameObjects) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB572E0 Offset: 0xB558E0 VA: 0x180B572E0
	|-GameObjectUtils.Show<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static void Hide<T>(T[] gameObjects) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB57250 Offset: 0xB55850 VA: 0x180B57250
	|-GameObjectUtils.Hide<object>
	*/
}
