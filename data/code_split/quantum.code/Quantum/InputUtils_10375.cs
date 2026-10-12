// Namespace: Quantum
[Serializable]
public class InputUtils // TypeDefIndex: 10375
{
	// Methods

	// RVA: 0x218EF50 Offset: 0x218D550 VA: 0x18218EF50
	private static bool CheckJump(Frame frame, EntityRef entity, GameplayInputSettingsData gameplayInputSettingsData, SpeedRunnersSettingsData speedRunnersSettingsData, InputTransition inputTransition, InputBuffer* inputBuffer, bool grounded, bool invertX) { }

	// RVA: 0x218ECD0 Offset: 0x218D2D0 VA: 0x18218ECD0
	private static bool CheckHook(Frame frame, EntityRef entity, GameplayInputSettingsData gameplayInputSettingsData, SpeedRunnersSettingsData speedRunnersSettingsData, InputTransition inputTransition, InputBuffer* inputBuffer, bool grounded, bool invertX) { }

	// RVA: 0x218F0F0 Offset: 0x218D6F0 VA: 0x18218F0F0
	private static bool CheckSlide(Frame frame, EntityRef entity, GameplayInputSettingsData gameplayInputSettingsData, SpeedRunnersSettingsData speedRunnersSettingsData, InputTransition inputTransition, InputBuffer* inputBuffer, bool grounded, bool invertX) { }

	// RVA: 0x218F2F0 Offset: 0x218D8F0 VA: 0x18218F2F0
	public static void EvaluateDefault(Frame frame, GameplayInputSettingsData gameplayInputSettingsData, InputCheck_Behaviour inputCheckData, EntityRef entity, bool grounded = True) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940
	public static void EvaluateEntityThrow(Frame frame, GameplayInputSettingsData gameplayInputSettingsData, DetectEntityThrow_Behaviour entityThrowBehaviour, EntityRef entity, Grab* grab, EntityRef grabbedEntity, bool grounded) { }

	// RVA: 0x218F580 Offset: 0x218DB80 VA: 0x18218F580
	private static void OnEvaluateDefault(Frame frame, GameplayInputSettingsData gameplayInputSettingsData, InputCheck_Behaviour inputCheckData, EntityRef entity, bool grounded = True) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940
	private static void OnEvaluateEntityThrow(Frame frame, GameplayInputSettingsData gameplayInputSettingsData, DetectEntityThrow_Behaviour entityThrowBehaviour, EntityRef entity, Grab* grab, EntityRef grabbedEntity, bool grounded) { }

	// RVA: 0x218FBD0 Offset: 0x218E1D0 VA: 0x18218FBD0
	public static bool ShouldInvertDirection(GameEntity* gameEntity) { }

	// RVA: 0x218F310 Offset: 0x218D910 VA: 0x18218F310
	private static void EvaluateInputAction(Frame frame, EntityRef entity, InputAction action, ExecuteGroupEvent executeGroupEvent, ChangeStateEvent changeStateEvent, bool forceTurn = False) { }

	// RVA: 0x4FA6F0 Offset: 0x4F8CF0 VA: 0x1804FA6F0
	public void .ctor() { }
}
