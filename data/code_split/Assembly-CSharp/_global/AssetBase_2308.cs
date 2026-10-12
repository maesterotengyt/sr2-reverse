// Namespace: 
public abstract class AssetBase : ScriptableObject // TypeDefIndex: 2308
{
	// Fields
	public const string DefaultAssetObjectPropertyPath = "Settings";
	public const char NestedPathSeparator = '\x7c';

	// Properties
	public abstract AssetObject AssetObject { get; }
	public bool IsTransient { get; }
	public virtual string AssetObjectPropertyPath { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract AssetObject get_AssetObject();

	// RVA: 0x503C10 Offset: 0x502210 VA: 0x180503C10
	public bool get_IsTransient() { }

	// RVA: 0x503BE0 Offset: 0x5021E0 VA: 0x180503BE0 Slot: 5
	public virtual string get_AssetObjectPropertyPath() { }

	// RVA: 0x503BC0 Offset: 0x5021C0 VA: 0x180503BC0 Slot: 6
	public virtual void Loaded() { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 7
	public virtual void PrepareAsset() { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 8
	public virtual void Disposed() { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 9
	public virtual void Reset() { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 10
	public virtual void Awake() { }

	// RVA: 0x503B30 Offset: 0x502130 VA: 0x180503B30
	private string GetNameForNesting() { }

	// RVA: 0x503AB0 Offset: 0x5020B0 VA: 0x180503AB0
	public static bool GetMainAssetPath(string path, out string mainAssetPath) { }

	// RVA: 0x503080 Offset: 0x501680 VA: 0x180503080
	protected void .ctor() { }
}
