// Namespace: 
public class SpeedRunnersCharacterTrailManager : SRMonoBehaviour // TypeDefIndex: 2515
{
	// Fields
	public const string ColorMaterialParameterID = "_Color";
	public const string ColorBMaterialParameterID = "_ColorB";
	public const string ColorCMaterialParameterID = "_ColorC";
	public const string PowerMaterialParameterID = "_Power";
	public GameObject RootGameObject; // 0x20
	public SpeedRunnersCharacterManager CharacterManager; // 0x28
	public int PoolSize; // 0x30
	public float MaxTrailTime; // 0x34
	public Material TrailMaterial; // 0x38
	[Header("Character Shader Trail ")]
	public string MainTextureString; // 0x40
	public string AlphaReferenceString; // 0x48
	public string BaseColorReferenceString; // 0x50
	public string LerpValueReferenceString; // 0x58
	public float DuplicationRefreshRate; // 0x60
	public float DuplicationSpeed; // 0x64
	public float DuplicationFadeSpeed; // 0x68
	public float ZDuplicationDistance; // 0x6C
	[Header("Character Trail Renderer ")]
	public float FadeSpeed; // 0x70
	public float MinDistance; // 0x74
	public float AngleThreshold; // 0x78
	public float TrailRendererOffset; // 0x7C
	public bool HasSuperSpeed; // 0x80
	private SpeedRunnersCharacterTrail currentTrail; // 0x88
	private SuperSpeedPreset currentPreset; // 0x90
	private bool isLocalTrail; // 0x98
	private int poolIndex; // 0x9C
	private SpeedRunnersCharacterTrailManager.TrailObject[] trailPool; // 0xA0
	private MaterialPropertyBlock materialPropertyBlock; // 0xA8
	private GameEntityRenderer[] skinnedMeshRenderers; // 0xB0
	private float duplicationRefreshRateCount; // 0xB8

	// Methods

	// RVA: 0x638460 Offset: 0x636A60 VA: 0x180638460
	public void Awake() { }

	// RVA: 0x639440 Offset: 0x637A40 VA: 0x180639440
	private void Update() { }

	// RVA: 0x638B90 Offset: 0x637190 VA: 0x180638B90
	private void OnDestroy() { }

	// RVA: 0x638550 Offset: 0x636B50 VA: 0x180638550
	public void Initialize(SuperSpeedPreset superSpeedPreset, bool isLocal) { }

	// RVA: 0x6384B0 Offset: 0x636AB0 VA: 0x1806384B0
	public SpeedRunnersCharacterTrailManager.TrailObject GetPooledObject() { }

	// RVA: 0x638CB0 Offset: 0x6372B0 VA: 0x180638CB0
	public void UpdateCharacterDuplication() { }

	// RVA: 0x6389F0 Offset: 0x636FF0 VA: 0x1806389F0
	public void OnCharacterTrailInstanced(string operationID, GameObject trailGameObject) { }

	// RVA: 0x639800 Offset: 0x637E00 VA: 0x180639800
	public void .ctor() { }
}
