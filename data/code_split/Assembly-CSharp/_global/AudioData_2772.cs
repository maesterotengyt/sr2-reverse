// Namespace: 
public class AudioData : ScriptableObject // TypeDefIndex: 2772
{
	// Fields
	public List<AssetReference> DefaultBanks; // 0x18
	public AssetReference BaseCharacterAudioBank; // 0x20
	public AssetReference BaseStageAudioBank; // 0x28
	public List<StageMusicData> StagesMusic; // 0x30
	public string ForceStageMusic; // 0x38

	// Methods

	// RVA: 0x7269C0 Offset: 0x724FC0 VA: 0x1807269C0
	public StageMusicData GetStageMusicData(string ID) { }

	// RVA: 0x503080 Offset: 0x501680 VA: 0x180503080
	public void .ctor() { }
}
