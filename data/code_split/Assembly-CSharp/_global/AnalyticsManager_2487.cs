// Namespace: 
public class AnalyticsManager : MonoBehaviour // TypeDefIndex: 2487
{
	// Fields
	private bool initialized; // 0x20
	private bool analyticsEngineInitialized; // 0x21
	public AnalyticEngine AnalyticEngine; // 0x28
	public bool RunInEditor; // 0x30

	// Methods

	// RVA: 0x6265B0 Offset: 0x624BB0 VA: 0x1806265B0
	public void Initialize() { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940
	public void ForceInitialize() { }

	// RVA: -1 Offset: -1
	public void SendEvent<T>(AnalyticEvent eventType, T data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940
	|-AnalyticsManager.SendEvent<AnalyticsGameModePlayedData>
	|-AnalyticsManager.SendEvent<AnalyticsStageSelectedData>
	|-AnalyticsManager.SendEvent<object>
	|-AnalyticsManager.SendEvent<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void AnalyticsEvents<T>(AnalyticEvent eventType, T data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9E63B0 Offset: 0x9E49B0 VA: 0x1809E63B0
	|-AnalyticsManager.AnalyticsEvents<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x4F3DE0 Offset: 0x4F23E0 VA: 0x1804F3DE0
	public void .ctor() { }
}
