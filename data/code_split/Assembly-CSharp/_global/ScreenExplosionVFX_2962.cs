// Namespace: 
public class ScreenExplosionVFX : SRMonoBehaviour // TypeDefIndex: 2962
{
	// Fields
	public Transform DefaultStartingVFX; // 0x20
	public float DelayBetweenExplosion; // 0x28
	private Transform[] transforms; // 0x30
	private Coroutine explosionChainCoroutine; // 0x38
	private Coroutine rightChainCoroutine; // 0x40
	private Coroutine leftChainCoroutine; // 0x48

	// Methods

	// RVA: 0x77D930 Offset: 0x77BF30 VA: 0x18077D930
	private void Awake() { }

	// RVA: 0x77DD70 Offset: 0x77C370 VA: 0x18077DD70
	public void TriggerScreenExplosionsChain() { }

	// RVA: 0x77DF20 Offset: 0x77C520 VA: 0x18077DF20
	public void TriggerScreenExplosionsChain(Vector2 playerKnockoutPosition) { }

	// RVA: 0x77DB50 Offset: 0x77C150 VA: 0x18077DB50
	private int GetClosestVFXIndex(Vector2 knockoutPosition) { }

	[IteratorStateMachine(typeof(ScreenExplosionVFX.<ExplosionsChainCoroutine>d__10))]
	// RVA: 0x77DAD0 Offset: 0x77C0D0 VA: 0x18077DAD0
	private IEnumerator ExplosionsChainCoroutine(int startingVFXIndex) { }

	[IteratorStateMachine(typeof(ScreenExplosionVFX.<ScreenExplosionsChainDirection>d__11))]
	// RVA: 0x77DCF0 Offset: 0x77C2F0 VA: 0x18077DCF0
	private IEnumerator ScreenExplosionsChainDirection(int startIndex, int step, int targetIndex) { }

	// RVA: 0x77D6D0 Offset: 0x77BCD0 VA: 0x18077D6D0
	private void ActivateVFXAtIndex(int index) { }

	// RVA: 0x77DC90 Offset: 0x77C290 VA: 0x18077DC90
	private void OnDestroy() { }

	// RVA: 0x77E0D0 Offset: 0x77C6D0 VA: 0x18077E0D0
	public void .ctor() { }
}
