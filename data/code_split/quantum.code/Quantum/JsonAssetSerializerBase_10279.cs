// Namespace: Quantum
public abstract class JsonAssetSerializerBase : IAssetSerializer // TypeDefIndex: 10279
{
	// Fields
	private List<ComponentPrototype> _prototypeBuffer; // 0x10
	[CompilerGenerated]
	private bool <IsPrettyPrintEnabled>k__BackingField; // 0x18
	[CompilerGenerated]
	private int <CompressBinaryDataOnSerializationThreshold>k__BackingField; // 0x1C
	[CompilerGenerated]
	private bool <DecompressBinaryDataOnDeserialization>k__BackingField; // 0x20

	// Properties
	public bool IsPrettyPrintEnabled { get; }
	public int CompressBinaryDataOnSerializationThreshold { get; }
	public bool DecompressBinaryDataOnDeserialization { get; }
	public Encoding Encoding { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x676D40 Offset: 0x675340 VA: 0x180676D40
	public bool get_IsPrettyPrintEnabled() { }

	[CompilerGenerated]
	// RVA: 0x6678B0 Offset: 0x665EB0 VA: 0x1806678B0
	public int get_CompressBinaryDataOnSerializationThreshold() { }

	[CompilerGenerated]
	// RVA: 0x627880 Offset: 0x625E80 VA: 0x180627880
	public bool get_DecompressBinaryDataOnDeserialization() { }

	// RVA: 0x854950 Offset: 0x852F50 VA: 0x180854950
	public Encoding get_Encoding() { }

	// RVA: 0x2175720 Offset: 0x2173D20 VA: 0x182175720
	public ReplayFile DeserializeReplay(byte[] data) { }

	// RVA: 0x2175620 Offset: 0x2173C20 VA: 0x182175620
	public ChecksumFile DeserializeChecksum(byte[] data) { }

	// RVA: 0x21758F0 Offset: 0x2173EF0 VA: 0x1821758F0 Slot: 4
	public byte[] SerializeAssets(IEnumerable<AssetObject> assets) { }

	// RVA: 0x2175820 Offset: 0x2173E20 VA: 0x182175820 Slot: 5
	public string PrintAsset(AssetObject asset) { }

	// RVA: 0x2174BE0 Offset: 0x21731E0 VA: 0x182174BE0
	public IEnumerable<AssetObject> DeserializeAssets(byte[] data) { }

	// RVA: 0x2174BF0 Offset: 0x21731F0 VA: 0x182174BF0 Slot: 6
	public IEnumerable<AssetObject> DeserializeAssets(byte[] data, int index, int count) { }

	// RVA: -1 Offset: -1
	protected void Collect<AssetType>(List<AssetType> source, List<AssetObject> destination) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB8FA60 Offset: 0xB8E060 VA: 0x180B8FA60
	|-JsonAssetSerializerBase.Collect<object>
	*/

	// RVA: -1 Offset: -1 Slot: 7
	protected abstract object FromJson(string json, Type type);

	// RVA: -1 Offset: -1 Slot: 8
	protected abstract string ToJson(object obj);

	// RVA: 0x2174840 Offset: 0x2172E40 VA: 0x182174840
	private static JsonAssetSerializerBase.EntityPrototypeSurrogate CreateSurrogate(EntityPrototype asset) { }

	// RVA: 0x21749A0 Offset: 0x2172FA0 VA: 0x1821749A0
	private static JsonAssetSerializerBase.MapSurrogate CreateSurrogate(Map asset) { }

	// RVA: 0x2174530 Offset: 0x2172B30 VA: 0x182174530
	private EntityPrototype CreateFromSurrogate(JsonAssetSerializerBase.EntityPrototypeSurrogate surrogate) { }

	// RVA: 0x21742F0 Offset: 0x21728F0 VA: 0x1821742F0
	private Map CreateFromSurrogate(JsonAssetSerializerBase.MapSurrogate surrogate) { }

	// RVA: 0x21746E0 Offset: 0x2172CE0 VA: 0x1821746E0
	private JsonAssetSerializerBase.BinaryDataSurrogate CreateSurrogate(BinaryData asset) { }

	// RVA: 0x2174220 Offset: 0x2172820 VA: 0x182174220
	private BinaryData CreateFromSurrogate(JsonAssetSerializerBase.BinaryDataSurrogate surrogate) { }

	// RVA: 0x2175D90 Offset: 0x2174390 VA: 0x182175D90
	protected void .ctor() { }
}
