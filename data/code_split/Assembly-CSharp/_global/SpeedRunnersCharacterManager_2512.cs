// Namespace: 
public class SpeedRunnersCharacterManager : StellarCharacterManager // TypeDefIndex: 2512
{
	// Fields
	[Header("Points")]
	public GameObject ScaleObject; // 0x1B8
	public CharacterReferencePoint CenterReferencePoint; // 0x1C0
	public Transform CharacterIndicatorPoint; // 0x1C8
	[Header("Basic Character")]
	public Animator BasicCharacterAnimator; // 0x1D0
	public GameObject BasicCharacter; // 0x1D8
	public SpeedRunnersCharacterTrailManager TrailManager; // 0x1E0
	public Vector3 LastDirection; // 0x1E8
	public Transform RootTransform; // 0x1F8
	public StellarUIAnimator RoundWinnerFlagAnimator; // 0x200
	public ItemBubbleHUD ItemBubbleIndicator; // 0x208
	public CharacterOutlineManager OutlineManager; // 0x210
	[Header("Data")]
	public SpeedRunnersCharacterVOData VOData; // 0x218
	public Vector3 LastPosition; // 0x220
	private bool isTrailActive; // 0x22C
	private Transform rotationPivotTransform; // 0x230
	private Transform rotationOffsetTransform; // 0x238
	private float playerHeight; // 0x240
	private string spawnCharacterOperationID; // 0x248

	// Properties
	protected SaveManager saveManager { get; }
	protected UIManager uiManager { get; }
	protected OnlineManager onlineManager { get; }
	protected SimulationManager simulationManager { get; }
	private FileLoadingManager fileLoadingManager { get; }
	protected GameStateManager gameStateManager { get; }

	// Methods

	// RVA: 0x638370 Offset: 0x636970 VA: 0x180638370
	protected SaveManager get_saveManager() { }

	// RVA: 0x638410 Offset: 0x636A10 VA: 0x180638410
	protected UIManager get_uiManager() { }

	// RVA: 0x638320 Offset: 0x636920 VA: 0x180638320
	protected OnlineManager get_onlineManager() { }

	// RVA: 0x6383C0 Offset: 0x6369C0 VA: 0x1806383C0
	protected SimulationManager get_simulationManager() { }

	// RVA: 0x638280 Offset: 0x636880 VA: 0x180638280
	private FileLoadingManager get_fileLoadingManager() { }

	// RVA: 0x6382D0 Offset: 0x6368D0 VA: 0x1806382D0
	protected GameStateManager get_gameStateManager() { }

	// RVA: 0x636DE0 Offset: 0x6353E0 VA: 0x180636DE0
	private void Awake() { }

	// RVA: 0x637570 Offset: 0x635B70 VA: 0x180637570 Slot: 4
	public override void OnInstantiated(Frame frame) { }

	// RVA: 0x637F80 Offset: 0x636580 VA: 0x180637F80
	private void OnVOEventNotified(EventNotifyVOCharacterEvent callback) { }

	// RVA: 0x638080 Offset: 0x636680 VA: 0x180638080
	public void SpawnBasicCharacter(int characterID) { }

	// RVA: 0x636E90 Offset: 0x635490 VA: 0x180636E90
	private void CharacterInstanced(string operationID, GameObject characterGameObject, Animator characterAnimator) { }

	// RVA: 0x637DD0 Offset: 0x6363D0 VA: 0x180637DD0 Slot: 6
	public override void OnUpdate(Frame frame, GameEntity* gameEntity) { }

	// RVA: 0x637020 Offset: 0x635620 VA: 0x180637020
	private void OnDestroy() { }

	// RVA: 0x638270 Offset: 0x636870 VA: 0x180638270
	public void .ctor() { }
}
