// Namespace: 
public class AudioMatchEvents : SRMonoBehaviour // TypeDefIndex: 2502
{
	// Fields
	public static readonly HashString GeneralCategoryID; // 0x0
	public static AudioMatchEvents.OnMatchBanksLoaded MatchBanksLoaded; // 0x10
	private List<AssetReference> matchBanks; // 0x20
	private List<string> banksLoading; // 0x28
	private bool loadingBank; // 0x30
	private const float cameraXRange = 8;

	// Methods

	// RVA: 0x627BB0 Offset: 0x6261B0 VA: 0x180627BB0
	public void Initialize() { }

	// RVA: 0x627DC0 Offset: 0x6263C0 VA: 0x180627DC0
	public void LoadMatchBanks(List<CharacterToPreload> matchCharacters) { }

	// RVA: 0x6289F0 Offset: 0x626FF0 VA: 0x1806289F0
	private void PreloadBank(AssetReference AudioBank, string bankID) { }

	// RVA: 0x6279C0 Offset: 0x625FC0 VA: 0x1806279C0
	private void AudioBankLoaded(string bankID) { }

	// RVA: 0x628F50 Offset: 0x627550 VA: 0x180628F50
	public void UnloadMatchBanks() { }

	// RVA: 0x628600 Offset: 0x626C00 VA: 0x180628600
	private void PlaySFX(EventPlaySFX callback) { }

	// RVA: 0x628BB0 Offset: 0x6271B0 VA: 0x180628BB0
	public void SetEventVolume(EventSetEventVolume callback) { }

	// RVA: 0x628D10 Offset: 0x627310 VA: 0x180628D10
	public void SetInstanceVolume(EventSetInstanceVolume callback) { }

	// RVA: 0x628DD0 Offset: 0x6273D0 VA: 0x180628DD0
	private void StopSFX(EventStopSFX callback) { }

	// RVA: 0x627920 Offset: 0x625F20 VA: 0x180627920
	private Vector3 AdjustSoundCameraPosition(Vector3 position) { }

	// RVA: 0x629040 Offset: 0x627640 VA: 0x180629040
	public void .ctor() { }

	// RVA: 0x628FC0 Offset: 0x6275C0 VA: 0x180628FC0
	private static void .cctor() { }
}
