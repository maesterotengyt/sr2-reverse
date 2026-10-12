// Namespace: 
[RequireComponent(typeof(SplineContainer))]
[ExecuteInEditMode]
[Serializable]
public class DynamicStageElementVisualizer : MonoBehaviour // TypeDefIndex: 3531
{
	// Fields
	public List<TrajectorySegments> SequenceTrajectory; // 0x20
	public SplineContainer SplineCurve; // 0x28
	[Header("Data")]
	public string AnimationName; // 0x30
	public TransformKeyFramesDataAsset TransformKeyFramesData; // 0x38
	[HideInInspector]
	public bool PreviewMovement; // 0x40
	[HideInInspector]
	public float SliderPreviousValue; // 0x44
	public bool ClosedLoop; // 0x48
	public bool UseTangentRotation; // 0x49
	public List<Vector3> TagPositionList; // 0x50

	// Methods

	// RVA: 0x5E5210 Offset: 0x5E3810 VA: 0x1805E5210
	private void Start() { }

	// RVA: 0x5E51C0 Offset: 0x5E37C0 VA: 0x1805E51C0
	private void OnEnable() { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940
	private void OnDestroy() { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940
	private void OnDisable() { }

	// RVA: 0x5E4A20 Offset: 0x5E3020 VA: 0x1805E4A20
	public void ExtractTrayectory() { }

	// RVA: 0x5E43C0 Offset: 0x5E29C0 VA: 0x1805E43C0
	public bool CheckIfTrajectoryChanged(Spline spline, int i) { }

	// RVA: 0x5E5010 Offset: 0x5E3610 VA: 0x1805E5010
	private TrajectorySegments GetSegment(int currentframe) { }

	// RVA: 0x5E4FA0 Offset: 0x5E35A0 VA: 0x1805E4FA0
	private float GetCurvePercentage(int curveIndex) { }

	// RVA: 0x5E4680 Offset: 0x5E2C80 VA: 0x1805E4680
	public AnimationCurve DuplicateAnimationCurve(AnimationCurve original) { }

	// RVA: 0x5E47F0 Offset: 0x5E2DF0 VA: 0x1805E47F0
	public void EvaluateTransformKeyFrames(int frame) { }

	// RVA: 0x5E5280 Offset: 0x5E3880 VA: 0x1805E5280
	public void .ctor() { }
}
