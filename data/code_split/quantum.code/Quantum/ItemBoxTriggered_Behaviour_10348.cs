// Namespace: Quantum
[Serializable]
public class ItemBoxTriggered_Behaviour : StateBehaviour // TypeDefIndex: 10348
{
	// Fields
	public ItemBoxTriggered_Behaviour.GameModeItemBlacklist[] GameModeBlacklists; // 0x60
	public ItemBoxTriggered_Behaviour.ItemWeightInfo[] FirstPlayerProbabilities; // 0x68
	public ItemBoxTriggered_Behaviour.ItemWeightInfo[] SecondPlayerProbabilities; // 0x70
	public ItemBoxTriggered_Behaviour.ItemWeightInfo[] ThirdPlayerProbabilities; // 0x78
	public ItemBoxTriggered_Behaviour.ItemWeightInfo[] FourthPlayerProbabilities; // 0x80

	// Methods

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 7
	protected override void OnEnter(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x218FFE0 Offset: 0x218E5E0 VA: 0x18218FFE0 Slot: 8
	protected override void OnExecute(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 10
	protected override void OnExit(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 9
	protected override void OnUpdate(Frame frame, CachedEntityData stateMachineOwner, CachedEntityData targetEntityData, int currentFrame) { }

	// RVA: 0x218FBF0 Offset: 0x218E1F0 VA: 0x18218FBF0
	private ItemBoxTriggered_Behaviour.SingleItemWeightInfo[] GenerateSingleItemWeightArray(HashSet<int> blacklist, int totalPlayers, ItemBoxTriggered_Behaviour.ItemWeightInfo[] originalArray) { }

	// RVA: 0x2190480 Offset: 0x218EA80 VA: 0x182190480
	private int PickRandomItem(Frame frame, int totalPlayers, int rank) { }

	// RVA: 0x218FEA0 Offset: 0x218E4A0 VA: 0x18218FEA0
	private HashSet<int> GetBlacklistByGameMode(HashString gameModeID) { }

	// RVA: 0x21906C0 Offset: 0x218ECC0 VA: 0x1821906C0
	public void .ctor() { }
}
