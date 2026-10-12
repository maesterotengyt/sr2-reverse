// Namespace: 
public class StellarCharacterManager : StellarMonoBehaviour // TypeDefIndex: 3359
{
	// Fields
	public EntityView CharacterEntity; // 0x20
	public StellarCharacterData Data; // 0x28
	public FootstepSFXEventDefinition[] FootstepSFXEvents; // 0x1A8
	protected bool loaded; // 0x1B0
	private bool activated; // 0x1B1

	// Methods

	// RVA: 0x5BE340 Offset: 0x5BC940 VA: 0x1805BE340 Slot: 4
	public virtual void OnInstantiated(Frame frame) { }

	// RVA: 0x5BE0C0 Offset: 0x5BC6C0 VA: 0x1805BE0C0
	public void OnCharacterLoaded(EventOnCharacterLoaded callback) { }

	// RVA: 0x5BDD80 Offset: 0x5BC380 VA: 0x1805BDD80
	private void OnCharacterActivation(EventOnCharacterActivation callback) { }

	// RVA: 0x5BDFC0 Offset: 0x5BC5C0 VA: 0x1805BDFC0
	private void OnCharacterDeactivation(EventOnCharacterDeactivation callback) { }

	// RVA: 0x5BEAB0 Offset: 0x5BD0B0 VA: 0x1805BEAB0 Slot: 5
	protected virtual void OnPlayCharacterFootstepSFX(EventPlayCharacterFootstepSFX callback) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 6
	public virtual void OnUpdate(Frame frame, GameEntity* gameEntity) { }

	// RVA: 0x5BDD30 Offset: 0x5BC330 VA: 0x1805BDD30
	public GameEntityManager GetGameEntityManager() { }

	// RVA: 0x5BEDA0 Offset: 0x5BD3A0 VA: 0x1805BEDA0
	public bool TryGetFootstepSFXEventDefinition(int id, out FootstepSFXEventDefinition footSFXEvent) { }

	// RVA: 0x5BEE80 Offset: 0x5BD480 VA: 0x1805BEE80
	public void .ctor() { }
}
