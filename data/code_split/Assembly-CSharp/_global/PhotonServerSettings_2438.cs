// Namespace: 
[CreateAssetMenu(menuName = "Quantum/Configurations/PhotonServerSettings", order = -999)]
[Serializable]
public class PhotonServerSettings : ScriptableObject // TypeDefIndex: 2438
{
	// Fields
	private static PhotonServerSettings _instance; // 0x0
	public AppSettings AppSettings; // 0x18
	public int PlayerTtlInSeconds; // 0x20
	public int EmptyRoomTtlInSeconds; // 0x24

	// Properties
	public static PhotonServerSettings Instance { get; }
	public bool CanRejoin { get; }

	// Methods

	// RVA: 0x526BF0 Offset: 0x5251F0 VA: 0x180526BF0
	public static PhotonServerSettings get_Instance() { }

	// RVA: 0x526BE0 Offset: 0x5251E0 VA: 0x180526BE0
	public bool get_CanRejoin() { }

	// RVA: 0x526AC0 Offset: 0x5250C0 VA: 0x180526AC0
	public static AppSettings CloneAppSettings(AppSettings appSettings) { }

	// RVA: 0x503080 Offset: 0x501680 VA: 0x180503080
	public void .ctor() { }
}
