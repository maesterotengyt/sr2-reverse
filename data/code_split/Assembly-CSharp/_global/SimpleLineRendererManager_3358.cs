// Namespace: 
public class SimpleLineRendererManager : MonoBehaviour // TypeDefIndex: 3358
{
	// Fields
	public GameObject VisualsGameObject; // 0x20
	public Transform PointA; // 0x28
	public Transform PointB; // 0x30
	public LineRenderer LineRenderer; // 0x38
	public float InterpolationSpeed; // 0x40
	[Header("Snap joints")]
	public Transform PointAOverride; // 0x48
	public Transform PointBOverride; // 0x50
	protected bool visible; // 0x58
	protected Vector3[] lastKnownPositions; // 0x60
	protected Vector3[] currentPositions; // 0x68
	protected SimpleLineEndRotationMode rotationMode; // 0x70

	// Methods

	// RVA: 0x5BD2E0 Offset: 0x5BB8E0 VA: 0x1805BD2E0
	private void LateUpdate() { }

	// RVA: 0x5BD300 Offset: 0x5BB900 VA: 0x1805BD300 Slot: 4
	protected virtual void OnUpdate() { }

	// RVA: 0x5BD910 Offset: 0x5BBF10 VA: 0x1805BD910 Slot: 5
	public virtual void UpdateVisuals(SimpleLineRenderer* simpleLineRenderer) { }

	// RVA: 0x5BD7B0 Offset: 0x5BBDB0 VA: 0x1805BD7B0
	public void UpdateEndRotation(Transform endPoint, Transform otherEnd, SimpleLineEndRotationMode rotationMode) { }

	// RVA: 0x5BDBC0 Offset: 0x5BC1C0 VA: 0x1805BDBC0
	public void .ctor() { }
}
