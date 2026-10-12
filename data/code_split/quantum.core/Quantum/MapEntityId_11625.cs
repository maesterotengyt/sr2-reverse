// Namespace: Quantum
[Serializable]
public struct MapEntityId : IEquatable<MapEntityId> // TypeDefIndex: 11625
{
	// Fields
	public const int SIZE = 4;
	public int SceneIndexPlusOne; // 0x0

	// Properties
	public int SceneIndex { get; }
	public bool IsValid { get; }
	public static MapEntityId Invalid { get; }

	// Methods

	// RVA: 0x21DC770 Offset: 0x21DAD70 VA: 0x1821DC770
	public int get_SceneIndex() { }

	// RVA: 0x21DC760 Offset: 0x21DAD60 VA: 0x1821DC760
	public bool get_IsValid() { }

	// RVA: 0x81E2E0 Offset: 0x81C8E0 VA: 0x18081E2E0
	public static MapEntityId get_Invalid() { }

	// RVA: 0x21DC600 Offset: 0x21DAC00 VA: 0x1821DC600
	public static MapEntityId Create(int sceneIndex) { }

	// RVA: 0x21DC690 Offset: 0x21DAC90 VA: 0x1821DC690
	public static void Serialize(void* ptr, FrameSerializer serializer) { }

	// RVA: 0x21DC700 Offset: 0x21DAD00 VA: 0x1821DC700 Slot: 3
	public override string ToString() { }

	// RVA: 0x93A610 Offset: 0x938C10 VA: 0x18093A610 Slot: 4
	public bool Equals(MapEntityId other) { }

	// RVA: 0xB72450 Offset: 0xB70A50 VA: 0x180B72450 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x21DC610 Offset: 0x21DAC10 VA: 0x1821DC610 Slot: 0
	public override bool Equals(object obj) { }
}
