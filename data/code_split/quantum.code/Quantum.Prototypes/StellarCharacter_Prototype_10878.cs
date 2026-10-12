// Namespace: Quantum.Prototypes
[Prototype(typeof(StellarCharacter))]
[Serializable]
public sealed class StellarCharacter_Prototype : ComponentPrototype<StellarCharacter> // TypeDefIndex: 10878
{
	// Fields
	public MapEntityId Entity; // 0x18
	public QBoolean Active; // 0x1C
	public int CharacterID; // 0x20
	[MaxStringByteCount(62, "Unicode")]
	public string PlayerID; // 0x28
	public PlayerRef PlayerRef; // 0x30
	public int PartnerCharacterIndex; // 0x34
	public int SpawnOrder; // 0x38
	[MaxStringByteCount(62, "UTF-8")]
	public string Nickname; // 0x40
	public QBoolean StartDisabled; // 0x48

	// Methods

	// RVA: 0x21129C0 Offset: 0x2110FC0 VA: 0x1821129C0 Slot: 5
	public override bool AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) { }

	// RVA: 0x2112C70 Offset: 0x2111270 VA: 0x182112C70
	public void Materialize(Frame frame, ref StellarCharacter result, in PrototypeMaterializationContext context) { }

	// RVA: 0x2112BE0 Offset: 0x21111E0 VA: 0x182112BE0 Slot: 6
	public override void Dispatch(ComponentPrototypeVisitorBase visitor) { }

	// RVA: 0x2112D40 Offset: 0x2111340 VA: 0x182112D40
	public void .ctor() { }
}
