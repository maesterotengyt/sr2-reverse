// Namespace: 
[CreateAssetMenu(fileName = "StageData", menuName = "ScriptableObjects/Stage/StageData")]
public class StageData : ScriptableObject // TypeDefIndex: 2847
{
	// Fields
	public AssetReference AudioBank; // 0x18
	public Sprite RenderSprite; // 0x20
	public bool Locked; // 0x28
	public string MusicID; // 0x30
	public HashString StageID; // 0x38
	public StageType Type; // 0x48
	public List<StageLayout> Layouts; // 0x50

	// Methods

	// RVA: 0x751300 Offset: 0x74F900 VA: 0x180751300
	public StageLayout GetLayout(string id) { }

	// RVA: 0x751170 Offset: 0x74F770 VA: 0x180751170
	public bool ContainsLayout(string id) { }

	// RVA: 0x7515F0 Offset: 0x74FBF0 VA: 0x1807515F0
	public void .ctor() { }
}
