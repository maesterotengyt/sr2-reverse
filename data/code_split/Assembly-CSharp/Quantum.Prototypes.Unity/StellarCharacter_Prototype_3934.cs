// Namespace: Quantum.Prototypes.Unity
[Prototype(typeof(StellarCharacter))]
[Serializable]
public class StellarCharacter_Prototype : PrototypeAdapter<StellarCharacter_Prototype> // TypeDefIndex: 3934
{
	// Fields
	[LocalReference]
	public EntityPrototype Entity; // 0x10
	public QBoolean Active; // 0x18
	public int CharacterID; // 0x1C
	[MaxStringByteCount(62, "Unicode")]
	public string PlayerID; // 0x20
	public PlayerRef PlayerRef; // 0x28
	public int PartnerCharacterIndex; // 0x2C
	public int SpawnOrder; // 0x30
	[MaxStringByteCount(62, "UTF-8")]
	public string Nickname; // 0x38
	public QBoolean StartDisabled; // 0x40

	// Methods

	// RVA: 0x6835F0 Offset: 0x681BF0 VA: 0x1806835F0 Slot: 5
	public sealed override StellarCharacter_Prototype Convert(EntityPrototypeConverter converter) { }

	// RVA: 0x6836C0 Offset: 0x681CC0 VA: 0x1806836C0
	public void .ctor() { }
}
