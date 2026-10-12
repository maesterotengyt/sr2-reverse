// Namespace: 
public class QuantumCallbackHandler_UnityCallbacks : IDisposable // TypeDefIndex: 2372
{
	// Fields
	private Coroutine _coroutine; // 0x10
	private Map _currentMap; // 0x18
	private bool _currentSceneNeedsCleanup; // 0x20
	private readonly CallbackUnitySceneLoadBegin _callbackUnitySceneLoadBegin; // 0x28
	private readonly CallbackUnitySceneLoadDone _callbackUnitySceneLoadDone; // 0x30
	private readonly CallbackUnitySceneUnloadBegin _callbackUnitySceneUnloadBegin; // 0x38
	private readonly CallbackUnitySceneUnloadDone _callbackUnitySceneUnloadDone; // 0x40

	// Methods

	// RVA: 0x528900 Offset: 0x526F00 VA: 0x180528900
	public void .ctor(QuantumGame game) { }

	// RVA: 0x528280 Offset: 0x526880 VA: 0x180528280
	public static IDisposable Initialize() { }

	// RVA: 0x528170 Offset: 0x526770 VA: 0x180528170 Slot: 4
	public void Dispose() { }

	// RVA: -1 Offset: -1
	private static void PublishCallback<T>(T callback, string sceneName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC1B960 Offset: 0xC19F60 VA: 0x180C1B960
	|-QuantumCallbackHandler_UnityCallbacks.PublishCallback<object>
	*/

	[IteratorStateMachine(typeof(QuantumCallbackHandler_UnityCallbacks.<SwitchScene>d__11))]
	// RVA: 0x528440 Offset: 0x526A40 VA: 0x180528440
	private IEnumerator SwitchScene(string previousSceneName, string newSceneName, bool unloadFirst) { }

	[IteratorStateMachine(typeof(QuantumCallbackHandler_UnityCallbacks.<LoadScene>d__12))]
	// RVA: 0x5283B0 Offset: 0x5269B0 VA: 0x1805283B0
	private IEnumerator LoadScene(string sceneName) { }

	[IteratorStateMachine(typeof(QuantumCallbackHandler_UnityCallbacks.<UnloadScene>d__13))]
	// RVA: 0x5284E0 Offset: 0x526AE0 VA: 0x1805284E0
	private IEnumerator UnloadScene(string sceneName) { }

	// RVA: 0x528570 Offset: 0x526B70 VA: 0x180528570
	private void UpdateLoading(QuantumGame game) { }

	[Conditional("QUANTUM_UNITY_CALLBACKS_VERBOSE_LOG")]
	// RVA: 0x528820 Offset: 0x526E20 VA: 0x180528820
	private static void VerboseLog(string msg) { }
}
