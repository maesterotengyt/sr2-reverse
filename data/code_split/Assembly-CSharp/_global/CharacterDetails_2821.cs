// Namespace: 
[CreateAssetMenu(fileName = "CharacterDetails", menuName = "Stellar/Character/CharacterDetails")]
public class CharacterDetails : ScriptableObject // TypeDefIndex: 2821
{
	// Fields
	public AssetReference AudioBank; // 0x18
	public RuntimeAnimatorController BasicAnimator; // 0x20
	public AssetReferenceSprite HUDShadowSprite; // 0x28
	public bool Locked; // 0x30
	public HashString CharacterID; // 0x38
	public LocalizedString CharacterName; // 0x48
	public List<CharacterCostumeData> Costumes; // 0x50
	public string DLCIdentifier; // 0x58

	// Methods

	// RVA: 0x727220 Offset: 0x725820 VA: 0x180727220
	public string GetCharacterName() { }

	// RVA: 0x7272D0 Offset: 0x7258D0 VA: 0x1807272D0
	public void .ctor() { }
}
