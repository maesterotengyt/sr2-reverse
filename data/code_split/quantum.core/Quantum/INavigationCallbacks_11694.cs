// Namespace: Quantum
public interface INavigationCallbacks // TypeDefIndex: 11694
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnWaypointReached(EntityRef entity, FPVector3 waypoint, Navigation.WaypointFlag waypointFlags, ref bool resetAgent);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnSearchFailed(EntityRef entity, ref bool resetAgent);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnMoveAgent(EntityRef entity, FPVector2 desiredDirection);
}
