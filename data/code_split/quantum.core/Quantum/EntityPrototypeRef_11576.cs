// Namespace: Quantum
[Serializable]
public struct EntityPrototypeRef : IEquatable<EntityPrototypeRef> // TypeDefIndex: 11576
{
	// Fields
	public AssetRef Asset; // 0x0
	public int InnerAssetId; // 0x8
	private int _padding; // 0xC

	// Properties
	public static EntityPrototypeRef Invalid { get; }
	public bool IsValid { get; }

	// Methods

	// RVA: 0x1128E00 Offset: 0x1127400 VA: 0x181128E00
	public static EntityPrototypeRef get_Invalid() { }

	// RVA: 0x1FA0950 Offset: 0x1F9EF50 VA: 0x181FA0950
	public bool get_IsValid() { }

	// RVA: 0x21C7440 Offset: 0x21C5A40 VA: 0x1821C7440 Slot: 4
	public bool Equals(EntityPrototypeRef other) { }

	// RVA: 0x21CCCC0 Offset: 0x21CB2C0 VA: 0x1821CCCC0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x21CCDC0 Offset: 0x21CB3C0 VA: 0x1821CCDC0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x21CCDE0 Offset: 0x21CB3E0 VA: 0x1821CCDE0 Slot: 3
	public override string ToString() { }

	// RVA: 0x21CCD90 Offset: 0x21CB390 VA: 0x1821CCD90
	public static EntityPrototypeRef FromPrototypeAsset(EntityPrototype prototype) { }

	// RVA: 0x21CCD70 Offset: 0x21CB370 VA: 0x1821CCD70
	public static EntityPrototypeRef FromPrototypeAsset(AssetRefEntityPrototype prototype) { }

	// RVA: 0x21CCD40 Offset: 0x21CB340 VA: 0x1821CCD40
	public static EntityPrototypeRef FromMasterAsset(Map asset, int internalAssetId) { }
}
