// Namespace: 
public class TournamentPlayerSlot : SRMonoBehaviour // TypeDefIndex: 3194
{
	// Fields
	public Image Background; // 0x20
	public Image PlayerIcon; // 0x28
	public UIEffect IconUIEffect; // 0x30
	public GameObject DefeatVFX; // 0x38
	public GameObject Highlight; // 0x40
	public GameObject DefeatedIcon; // 0x48
	public Sprite EmptySprite; // 0x50
	public Sprite LoadingSprite; // 0x58
	private bool defeatedAnimationPlayed; // 0x60
	private TournamentPlayerState iconState; // 0x64

	// Methods

	// RVA: 0x5919B0 Offset: 0x58FFB0 VA: 0x1805919B0
	public void SetIcon(TournamentPlayer player, TournamentPhaseData phaseData) { }

	// RVA: 0x591D00 Offset: 0x590300 VA: 0x180591D00
	public void SetNPC(NPCData npcData, TournamentPhaseData phaseData) { }

	// RVA: 0x591C40 Offset: 0x590240 VA: 0x180591C40
	public void SetNPCKnockout(TournamentPhaseData phaseData) { }

	// RVA: 0x591960 Offset: 0x58FF60 VA: 0x180591960
	private void SetIconUIEffect(bool currentPhase) { }

	// RVA: 0x5918D0 Offset: 0x58FED0 VA: 0x1805918D0
	public void Clear() { }

	// RVA: 0x53A8F0 Offset: 0x538EF0 VA: 0x18053A8F0
	public void .ctor() { }
}
