// Namespace: 
[DisallowMultipleComponent]
public class EntityView : MonoBehaviour, IQuantumPrefabNestedAssetHost // TypeDefIndex: 3409
{
	// Fields
	public AssetGuid AssetGuid; // 0x20
	public EntityRef EntityRef; // 0x28
	[FormerlySerializedAs("CreateBehaviour")]
	public EntityViewBindBehaviour BindBehaviour; // 0x30
	public GameEntityManager GameEntityManager; // 0x38
	[Tooltip("If enabled the EntityViewUpdater will not destroy (or disable, in case of map entities) this instance, and you are responsible for removing it from the game world yourself.

You will still receive the OnEntityDestroyed callback.")]
	[FormerlySerializedAs("ManualDestroy")]
	[FormerlySerializedAs("ManualDiposal")]
	public bool ManualDisposal; // 0x40
	[Tooltip("If enabled automatically sets the name of the spawned EntityView gameobject to be EntityRef.ToString()")]
	public bool GameObjectNameIsEntityRef; // 0x41
	[Header("Prediction Error Correction")]
	[Tooltip("A factor with dimension of 1/s (Hz) that works as a lower limit for how much of the accumulated prediction error is corrected every frame. This factor affects both the position and the rotation correction. Suggested values are greater than zero and smaller than ErrorCorrectionRateMax.

E.g.: ErrorCorrectionRateMin = 3, rendering delta time = (1/60)s: at least 5% (3 * 1/60) of the accumulated error will be corrected on this rendered frame. 

This threshold might not be respected if the resultant correction magnitude is below the ErrorPositionMinCorrection or above the ErrorPositionTeleportDistance, for the position error, or above the ErrorRotationTeleportDistance, for the rotation error.")]
	public float ErrorCorrectionRateMin; // 0x44
	[Tooltip("A factor with dimension of 1/s (Hz) that works as a upper limit for how much of the accumulated prediction error is corrected every frame. This factor affects both the position and the rotation correction. Suggested values are greater than ErrorCorrectionRateMin and smaller than half of a target rendering rate.

E.g.: ErrorCorrectionRateMax = 15, rendering delta time = (1/60)s: at maximum 25% (15 * 1/60) of the accumulated error will be corrected on this rendered frame. 

This threshold might not be respected if the resultant correction magnitude is below the ErrorPositionMinCorrection or above the ErrorPositionTeleportDistance, for the position error, or above the ErrorRotationTeleportDistance, for the rotation error.")]
	public float ErrorCorrectionRateMax; // 0x48
	[Tooltip("The reference for the magnitude of the accumulated position error, in meters, at which the position error will be corrected at the ErrorCorrectionRateMin. Suggested values are greater than ErrorPositionMinCorrection and smaller than ErrorPositionBlendEnd.

In other words, if the magnitude of the accumulated error is equal to or smaller than this threshold, it will be corrected at the ErrorCorrectionRateMin. If, instead, the magnitude is between this threshold and ErrorPositionBlendEnd,the error is corrected at a rate between ErrorCorrectionRateMin and ErrorCorrectionRateMax, proportionally. If it is equal to or greater than ErrorPositionBlendEnd, it will be corrected at the ErrorCorrectionRateMax.

Note: as the factor is expressed in distance units (meters), it might need to be scaled proportionally to the overall scale of objects in the scene and speeds at which they move, which are factors that affect the expected magnitude of prediction errors.")]
	public float ErrorPositionBlendStart; // 0x4C
	[Tooltip("The reference for the magnitude of the accumulated position error, in meters, at which the position error will be corrected at the ErrorCorrectionRateMax. Suggested values are greater than ErrorPositionBlendStart and smaller than ErrorPositionTeleportDistance.

In other words, if the magnitude of the accumulated error is equal to or greater than this threshold, it will be corrected at the ErrorCorrectionRateMax. If, instead, the magnitude is between ErrorPositionBlendStart and this threshold, the error is corrected at a rate between ErrorCorrectionRateMin and ErrorCorrectionRateMax, proportionally. If it is equal to or smaller than ErrorPositionBlendStart, it will be corrected at the ErrorCorrectionRateMin.

Note: as the factor is expressed in distance units (meters), it might need to be scaled proportionally to the overall scale of objects in the scene and speeds at which they move, which are factors that affect the expected magnitude of prediction errors.")]
	public float ErrorPositionBlendEnd; // 0x50
	[Tooltip("The reference for the magnitude of the accumulated rotation error, in radians, at which the rotation error will be corrected at the ErrorCorrectionRateMin. Suggested values are smaller than ErrorRotationBlendEnd.

In other words, if the magnitude of the accumulated error is equal to or smaller than this threshold, it will be corrected at the ErrorCorrectionRateMin. If, instead, the magnitude is between this threshold and ErrorRotationBlendEnd, the error is corrected at a rate between ErrorCorrectionRateMin and ErrorCorrectionRateMax, proportionally. If it is equal to or greater than ErrorRotationBlendEnd, it will be corrected at the ErrorCorrectionRateMax.")]
	public float ErrorRotationBlendStart; // 0x54
	[Tooltip("The reference for the magnitude of the accumulated rotation error, in radians, at which the rotation error will be corrected at the ErrorCorrectionRateMax. Suggested values are greater than ErrorRotationBlendStart and smaller than ErrorRotationTeleportDistance.

In other words, if the magnitude of the accumulated error is equal to or greater than this threshold, it will be corrected at the ErrorCorrectionRateMax. If, instead, the magnitude is between ErrorRotationBlendStart and this threshold, the error is corrected at a rate between ErrorCorrectionRateMin and ErrorCorrectionRateMax, proportionally. If it is equal to or smaller than ErrorRotationBlendStart, it will be corrected at the ErrorCorrectionRateMin.")]
	public float ErrorRotationBlendEnd; // 0x58
	[Tooltip("The value, in meters, that represents the minimum magnitude of the accumulated position error that will be corrected in a single frame, until it is fully corrected.

This setting has priority over the resultant correction rate, i.e. the restriction will be respected even if it makes the effective correction rate be different than the one computed according to the min/max rates and start/end blend values. Suggested values are greater than zero and smaller than ErrorPositionBlendStart.

Note: as the factor is expressed in distance units (meters), it might need to be scaled proportionally to the overall scale of objects in the scene and speeds at which they move, which are factors that affect the expected magnitude of prediction errors.")]
	public float ErrorPositionMinCorrection; // 0x5C
	[Tooltip("The value, in meters, that represents the magnitude of the accumulated position error above which the error will be instantaneously corrected, effectively teleporting the rendered object to its correct position. Suggested values are greater than ErrorPositionBlendEnd.

This setting has priority over the resultant correction rate, i.e. the restriction will be respected even if it makes the effective correction rate be different than the one computed according to the min/max rates and start/end blend values.

Note: as the factor is expressed in distance units (meters), it might need to be scaled proportionally to the overall scale of objects in the scene and speeds at which they move, which are factors that affect the expected magnitude of prediction errors.")]
	public float ErrorPositionTeleportDistance; // 0x60
	[Tooltip("The value, in radians, that represents the magnitude of the accumulated rotation error above which the error will be instantaneously corrected, effectively teleporting the rendered object to its correct orientation. Suggested values are greater than ErrorRotationBlendEnd.

This setting has priority over the resultant correction rate, i.e. the restriction will be respected even if it makes the effective correction rate be different than the one computed according to the min/max rates and start/end blend values.")]
	public float ErrorRotationTeleportDistance; // 0x64
	[Header("Events")]
	public EntityView.EntityUnityEvent OnEntityInstantiated; // 0x68
	public EntityView.EntityUnityEvent OnEntityDestroyed; // 0x70
	private FP _lastPredictedVerticalPosition2D; // 0x78
	private FPVector2 _lastPredictedPosition2D; // 0x80
	private FPVector3 _lastPredictedPosition3D; // 0x90
	private FP _lastPredictedRotation2D; // 0xA8
	private FPQuaternion _lastPredictedRotation3D; // 0xB0
	private Vector3 _errorVisualVector; // 0xD0
	private Quaternion _errorVisualQuaternion; // 0xDC

	// Properties
	[Obsolete("Use ManualDisposal")]
	public bool ManualDiposal { get; }
	private Type IQuantumPrefabNestedAssetHost.NestedAssetType { get; }
	private Type IQuantumPrefabNestedAssetHost.SplitAssetType { get; }

	// Methods

	// RVA: 0x5CC0D0 Offset: 0x5CA6D0 VA: 0x1805CC0D0
	public bool get_ManualDiposal() { }

	// RVA: 0x5CA1B0 Offset: 0x5C87B0 VA: 0x1805CA1B0 Slot: 4
	private Type IQuantumPrefabNestedAssetHost.get_NestedAssetType() { }

	// RVA: 0x5CA200 Offset: 0x5C8800 VA: 0x1805CA200 Slot: 5
	private Type IQuantumPrefabNestedAssetHost.get_SplitAssetType() { }

	// RVA: 0x5CA250 Offset: 0x5C8850 VA: 0x1805CA250
	public void OnInstantiated() { }

	// RVA: 0x5CA2E0 Offset: 0x5C88E0 VA: 0x1805CA2E0
	public void UpdateFromEntityTransformOverride(QuantumGame game, bool useClockAliasingInterpolation, bool useErrorCorrectionInterpolation) { }

	// RVA: 0x5CB280 Offset: 0x5C9880 VA: 0x1805CB280
	public void UpdateFromTransform3D(QuantumGame game, bool useClockAliasingInterpolation, bool useErrorCorrectionInterpolation) { }

	// RVA: 0x5CAAD0 Offset: 0x5C90D0 VA: 0x1805CAAD0
	public void UpdateFromTransform2D(QuantumGame game, bool useClockAliasingInterpolation, bool useErrorCorrectionInterpolation) { }

	// RVA: 0x5CBC80 Offset: 0x5CA280 VA: 0x1805CBC80
	private void UpdateRenderPosition(ref EntityView.UpdatePostionParameter param) { }

	// RVA: 0x5C9FC0 Offset: 0x5C85C0 VA: 0x1805C9FC0 Slot: 6
	protected virtual void ApplyTransform(ref EntityView.UpdatePostionParameter param) { }

	// RVA: 0x5CBA50 Offset: 0x5CA050 VA: 0x1805CBA50
	private void UpdateMinPositionCorrection(float positionCorrectionMultiplier, Vector3 positionCorrectionAmount) { }

	// RVA: 0x5CC080 Offset: 0x5CA680 VA: 0x1805CC080
	public void .ctor() { }
}
