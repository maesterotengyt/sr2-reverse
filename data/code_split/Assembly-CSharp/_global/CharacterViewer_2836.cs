// Namespace: 
public class CharacterViewer : StellarTestRunner // TypeDefIndex: 2836
{
	// Fields
	public GameObject CPUExtraSettingsHeader; // 0x58
	public RectTransform CPUExtraSettingsContainer; // 0x60
	public GameObject GeneralExtraSettingsHeader; // 0x68
	public RectTransform GeneralExtraSettingsContainer; // 0x70
	public CharacterViewerExtraSettings CPUExtraSettings; // 0x78
	public CharacterViewerExtraSettings GeneralExtraSettings; // 0x80
	private int settingIndex; // 0x88
	private int CPUSettingIndex; // 0x8C
	private StellarCharacterData mainCharacter; // 0x90
	private StellarCharacterData CPUCharacter; // 0x210
	[Header("Data")]
	public CharacterViewerData CharacterViewerData; // 0x390
	public AssetReference BaseCharacterAudioBank; // 0x398
	public AssetReference BaseStageAudioBank; // 0x3A0
	public CharactersDetails CharactersDetails; // 0x3A8
	public int DefaultDelayFrames; // 0x3B0
	public int DefaultStartPlayListFrames; // 0x3B4
	public GameEntityDataAsset InstigatorGameEntityDataRef; // 0x3B8
	public AssetRefAttackDatasPool InstigatorAttackDatasPoolRef; // 0x3C0
	public ControllerMapping SimulatedInputMapping; // 0x3C8
	public CharacterViewerSimulatedController SimulatedDevice1; // 0x3D0
	public CharacterViewerSimulatedController SimulatedDevice2; // 0x3D8
	public CharacterViewerCPU ViewerCPU; // 0x3E0
	public UnityEvent AnimationFinished; // 0x3E8
	[Header("Map Coordinates")]
	public Transform WorldTopLeft; // 0x3F0
	public Transform WorldBottomRight; // 0x3F8
	public Transform WorldZero; // 0x400
	public CharacterViewerCharacterData CharacterData; // 0x408
	public CharacterViewerAnimationData CurrentAnimation; // 0x410
	public bool RunningAnimation; // 0x4B8
	public bool PausedAnimation; // 0x4B9
	public bool RunDelayFrames; // 0x4BA
	protected HashString selectedCharacterHashstring; // 0x4C0
	private StellarCharacterData stellarCharacter; // 0x4D0
	private EntityRef instigatorEntityRef; // 0x650
	private int startHashState; // 0x658
	private float currentAnimationProgress; // 0x65C
	private int frameProgress; // 0x660
	private bool hasLoops; // 0x664
	private bool inmediateChange; // 0x665
	private bool startedState; // 0x666
	private bool inDelayTime; // 0x667
	private bool playLoop; // 0x668
	private int loopCounter; // 0x66C
	private int actionIndex; // 0x670
	private List<CharacterViewerSimulatedInput> lastInputs1; // 0x678
	private List<CharacterViewerSimulatedInput> lastInputs2; // 0x680
	private int input1Index; // 0x688
	private int input2Index; // 0x68C
	private HashString leftStickHashString; // 0x690
	private HashString rightStickHashString; // 0x6A0
	private List<int> saveIndexes; // 0x6B0
	private List<AssetReference> matchBanks; // 0x6B8
	private List<string> banksLoading; // 0x6C0
	private DispatcherSubscription onEventOnLoadingFinishedSubscription; // 0x6C8

	// Properties
	public CharacterViewerAnimationData AnimationDelay { get; }
	public int CharacterIndex { get; }
	private StellarAudioSystem StellarSystem { get; }

	// Methods

	// RVA: 0x731330 Offset: 0x72F930 VA: 0x180731330
	private void Start() { }

	// RVA: 0x72BF40 Offset: 0x72A540 VA: 0x18072BF40
	private void ExtraSettingsCall(CharacterViewerExtraSetting setting, bool IsCPU) { }

	// RVA: 0x72CEA0 Offset: 0x72B4A0 VA: 0x18072CEA0
	public List<string> GetOptionStrings() { }

	// RVA: 0x731B50 Offset: 0x730150 VA: 0x180731B50
	public CharacterViewerAnimationData get_AnimationDelay() { }

	// RVA: 0x731D50 Offset: 0x730350 VA: 0x180731D50
	public int get_CharacterIndex() { }

	// RVA: 0x731D60 Offset: 0x730360 VA: 0x180731D60
	private StellarAudioSystem get_StellarSystem() { }

	// RVA: 0x72AAF0 Offset: 0x7290F0 VA: 0x18072AAF0
	public void Awake() { }

	// RVA: 0x731960 Offset: 0x72FF60 VA: 0x180731960
	private void Update() { }

	// RVA: 0x72AAF0 Offset: 0x7290F0 VA: 0x18072AAF0
	private void StartMatch() { }

	// RVA: 0x730E60 Offset: 0x72F460 VA: 0x180730E60
	private void StartSimulation() { }

	// RVA: 0x7300F0 Offset: 0x72E6F0 VA: 0x1807300F0
	private void SimulationStarted() { }

	// RVA: 0x72FF80 Offset: 0x72E580 VA: 0x18072FF80
	private void SimulationClosed() { }

	// RVA: 0x72DD60 Offset: 0x72C360 VA: 0x18072DD60
	private void OnLoadingFinished(EventOnLoadingFinished callback) { }

	// RVA: 0x7307E0 Offset: 0x72EDE0 VA: 0x1807307E0
	public void SpawnCPU(HashString characterId, int costume = 0) { }

	// RVA: 0x72D0A0 Offset: 0x72B6A0 VA: 0x18072D0A0
	public void LoadAudioBank(AssetReference AudioBank, string bankID) { }

	// RVA: 0x72D200 Offset: 0x72B800 VA: 0x18072D200
	public void LoadCPU() { }

	// RVA: 0x72FDB0 Offset: 0x72E3B0 VA: 0x18072FDB0
	public void SetUpInput() { }

	// RVA: 0x72D320 Offset: 0x72B920 VA: 0x18072D320
	public void LoadCharacterData() { }

	// RVA: 0x72F5F0 Offset: 0x72DBF0 VA: 0x18072F5F0
	public void RefreshCurrentAnimation() { }

	// RVA: 0x72AC40 Offset: 0x729240 VA: 0x18072AC40
	public CharacterViewerCharacterData CreateCharacterDataAnimations(Frame frame, GameEntityData characterData) { }

	// RVA: 0x72B890 Offset: 0x729E90 VA: 0x18072B890
	public CharacterViewerAnimationData CreateDelay(int framesAmount) { }

	// RVA: 0x72BA20 Offset: 0x72A020 VA: 0x18072BA20
	public CharacterViewerCharacterData CreateNewCharacterData() { }

	// RVA: 0x72BBF0 Offset: 0x72A1F0 VA: 0x18072BBF0
	public void DeleteCharacterData(HashString characterID) { }

	// RVA: 0x72CB50 Offset: 0x72B150 VA: 0x18072CB50
	public string GetCharacterFilepath(HashString characterID) { }

	// RVA: 0x72DBB0 Offset: 0x72C1B0 VA: 0x18072DBB0
	public void SaveCharacterData() { }

	// RVA: 0x72FA80 Offset: 0x72E080 VA: 0x18072FA80
	public void SetDataForSave(HashString codename) { }

	// RVA: 0x72DDE0 Offset: 0x72C3E0 VA: 0x18072DDE0
	public void PlayAnimation(CharacterViewerAnimationData animationData, bool inmediateChange = True) { }

	// RVA: 0x72F550 Offset: 0x72DB50 VA: 0x18072F550
	public void PlayState() { }

	// RVA: 0x72FC20 Offset: 0x72E220 VA: 0x18072FC20
	public void SetLoops() { }

	// RVA: 0x72BB40 Offset: 0x72A140 VA: 0x18072BB40
	public void DelayAnimation(CharacterViewerAnimationData animationData) { }

	// RVA: 0x7316C0 Offset: 0x72FCC0 VA: 0x1807316C0
	public void StopStateAnimation() { }

	// RVA: 0x730A70 Offset: 0x72F070 VA: 0x180730A70 Slot: 5
	public virtual void SpawnCharacter(HashString characterID, int costume = 0) { }

	// RVA: 0x730D20 Offset: 0x72F320 VA: 0x180730D20
	public void SpawnInstigator() { }

	// RVA: 0x72BDF0 Offset: 0x72A3F0 VA: 0x18072BDF0
	public void DespawnEntity() { }

	// RVA: 0x72F8A0 Offset: 0x72DEA0 VA: 0x18072F8A0
	public void SaveInstigatorReference() { }

	// RVA: 0x730DD0 Offset: 0x72F3D0 VA: 0x180730DD0
	public void StartFramebyFrame() { }

	// RVA: 0x731630 Offset: 0x72FC30 VA: 0x180731630
	public void StopFramebyFrame() { }

	// RVA: 0x72A700 Offset: 0x728D00 VA: 0x18072A700
	public void AdvanceFramebyFrame() { }

	// RVA: 0x72C220 Offset: 0x72A820 VA: 0x18072C220
	public int GetAnimationProgress() { }

	// RVA: 0x72C210 Offset: 0x72A810 VA: 0x18072C210
	public int GetAnimationDuration() { }

	// RVA: 0x72FC40 Offset: 0x72E240 VA: 0x18072FC40
	public void SetStartDamage() { }

	// RVA: 0x72FCF0 Offset: 0x72E2F0 VA: 0x18072FCF0
	public void SetStartFallSpeed() { }

	// RVA: 0x72F820 Offset: 0x72DE20 VA: 0x18072F820
	public void ResetGrab() { }

	// RVA: 0x72A780 Offset: 0x728D80 VA: 0x18072A780
	public void AnimationAttack() { }

	// RVA: 0x72C810 Offset: 0x72AE10 VA: 0x18072C810
	public HashString GetAttackDirectionHash(int index) { }

	// RVA: 0x72C9B0 Offset: 0x72AFB0 VA: 0x18072C9B0
	public int GetAttackDirectionIndex(HashString attackHash) { }

	// RVA: 0x72CC50 Offset: 0x72B250 VA: 0x18072CC50
	public InputFlag GetInputFlag(ControllerKey key) { }

	// RVA: 0x72CD70 Offset: 0x72B370 VA: 0x18072CD70
	public ControllerKey GetInputKey(InputFlag input) { }

	// RVA: 0x72E8C0 Offset: 0x72CEC0 VA: 0x18072E8C0
	public void PlayInput(int frame) { }

	// RVA: 0x7303C0 Offset: 0x72E9C0 VA: 0x1807303C0
	public List<CharacterViewerAnimationData> SortAnimations(List<CharacterViewerAnimationData> animationList) { }

	// RVA: 0x72DBB0 Offset: 0x72C1B0 VA: 0x18072DBB0
	private void OnDestroy() { }

	// RVA: 0x72DBB0 Offset: 0x72C1B0 VA: 0x18072DBB0
	private void OnApplicationQuit() { }

	// RVA: 0x72DBF0 Offset: 0x72C1F0 VA: 0x18072DBF0
	private void OnExtraSettingsCall(int frame) { }

	// RVA: 0x72A820 Offset: 0x728E20 VA: 0x18072A820
	private void AnimationExtraSettingsRestart() { }

	// RVA: 0x7318E0 Offset: 0x72FEE0 VA: 0x1807318E0
	private void ToggleActiveGeneralExtraSetting(bool active) { }

	// RVA: 0x7318A0 Offset: 0x72FEA0 VA: 0x1807318A0
	private void ToggleActiveCPUExtraSetting(bool active) { }

	// RVA: 0x72F7F0 Offset: 0x72DDF0 VA: 0x18072F7F0
	private void ResetExtraSetting(CharacterViewerAnimationEditor editor, bool isCPU) { }

	// RVA: 0x7318E0 Offset: 0x72FEE0 VA: 0x1807318E0
	public void ToggleActiveGeneralExtraSettingsCall(bool active) { }

	// RVA: 0x7318A0 Offset: 0x72FEA0 VA: 0x1807318A0
	public void ToggleActiveCPUExtraSettingsCall(bool active) { }

	// RVA: 0x72F7F0 Offset: 0x72DDF0 VA: 0x18072F7F0
	public void ResetExtraSettingsCall(CharacterViewerAnimationEditor editor, bool isCPU) { }

	// RVA: 0x731A20 Offset: 0x730020 VA: 0x180731A20
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x731920 Offset: 0x72FF20 VA: 0x180731920
	private bool <LoadCharacterData>b__74_0(CharacterViewerCharacterData data) { }
}
