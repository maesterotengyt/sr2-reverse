// Namespace: 
[CreateAssetMenu(fileName = "CharactersDetails", menuName = "Stellar/CharactersDetails")]
public class CharactersDetails : ScriptableObject // TypeDefIndex: 3502
{
	// Fields
	public List<CharacterDetails> Characters; // 0x18

	// Properties
	private StellarDLCSystem dlcSystem { get; }

	// Methods

	// RVA: 0x5E4000 Offset: 0x5E2600 VA: 0x1805E4000
	private StellarDLCSystem get_dlcSystem() { }

	// RVA: 0x5E3B30 Offset: 0x5E2130 VA: 0x1805E3B30
	public CharacterDetails GetCharacterDetails(int characterID) { }

	// RVA: 0x5E3DF0 Offset: 0x5E23F0 VA: 0x1805E3DF0
	public List<int> GetUnlockedCharacters() { }

	// RVA: 0x5E3CB0 Offset: 0x5E22B0 VA: 0x1805E3CB0
	public List<CharacterCostumeData> GetUnlockedCharacterSkins(int characterID) { }

	// RVA: 0x503080 Offset: 0x501680 VA: 0x180503080
	public void .ctor() { }
}
