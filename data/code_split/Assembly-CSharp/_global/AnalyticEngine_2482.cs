// Namespace: 
public abstract class AnalyticEngine : MonoBehaviour // TypeDefIndex: 2482
{
	// Methods

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 4
	public virtual void Init() { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 5
	public virtual void StartMatchCharactersEvent(AnalyticEvent eventID, List<string> data) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 6
	public virtual void StageSelectedEvent(AnalyticEvent eventID, AnalyticsStageSelectedData data) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 7
	public virtual void GameModePlayedEvent(AnalyticEvent eventID, AnalyticsGameModePlayedData data) { }

	// RVA: 0x4F6BD0 Offset: 0x4F51D0 VA: 0x1804F6BD0 Slot: 8
	public virtual bool ServerAvailable() { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940 Slot: 9
	public virtual void SaveAnalyticsData() { }

	// RVA: 0x4F3DE0 Offset: 0x4F23E0 VA: 0x1804F3DE0
	protected void .ctor() { }
}
