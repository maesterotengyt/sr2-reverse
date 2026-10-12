// Namespace: 
public class StellarGameMode : StellarMonoBehaviour // TypeDefIndex: 3362
{
	// Fields
	[HideInInspector]
	public HashString GameModeID; // 0x20
	public StellarGameModeHUD[] GameModeHUDs; // 0x30
	public HashString DefaultCameraID; // 0x38

	// Methods

	// RVA: 0x5BFD00 Offset: 0x5BE300 VA: 0x1805BFD00 Slot: 4
	public virtual void Init() { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 5
	public virtual void Clear() { }

	// RVA: 0x5BFDE0 Offset: 0x5BE3E0 VA: 0x1805BFDE0 Slot: 6
	public virtual void Reload() { }

	// RVA: 0x5BFEC0 Offset: 0x5BE4C0 VA: 0x1805BFEC0
	public void .ctor() { }
}
