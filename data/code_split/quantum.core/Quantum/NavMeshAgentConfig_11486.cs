// Namespace: Quantum
[Serializable]
public class NavMeshAgentConfig : AssetObject, IBuiltInAssetObject // TypeDefIndex: 11486
{
	// Fields
	public const long DEFAULT_ID = 2;
	[Tooltip("The tick interval in which the agent is updated with. The entity index will influence the exact tick the update will happen for each individual entity.
1 = every tick,
2 = every other tick, ..
For performance reasons different agents will update at different times although they have the same UpdateInterval.")]
	public int UpdateInterval; // 0x20
	[Header("Path Finding")]
	[Tooltip("The quality of the A* heuristic function (Fast = Manhattan Distance, Good = Euclidean Distance). Best is currently not used.")]
	public Navigation.PathQuality PathQuality; // 0x24
	[Tooltip("The number of waypoints stored on the agent. Default is 6.
The first waypoint is generated at the position of the agent. The last waypoint is only used during the re-pathing transition as soon as the one before the last waypoint is reached.
The value is clamped to a minimum of 3 and a maximum of Navigation.Constants.MaxWaypoints")]
	public byte CachedWaypointCount; // 0x25
	[Tooltip("The agent automatically performs path finding again when not having reaching the current waypoint in the given time frame (sec). Set to 0 to disable.")]
	public FP MaxRepathTimeout; // 0x28
	[Tooltip("This option makes sure that unnecessary waypoints (mostly due to region edges in the proximity) are removed when they are applied to the agent component.")]
	public bool LineOfSightFunneling; // 0x30
	[Tooltip("This setting will make the agent perform a line cast each tick to skip unnecessary waypoints.")]
	public bool DynamicLineOfSight; // 0x31
	[Tooltip("This is similar to the DynamicLineOfSight option but only triggers when the agent is in a certain range of the waypoint. Disabled when set to 0.")]
	public FP DynamicLineOfSightWaypointRange; // 0x38
	[Tooltip("When an agent destination is selected that is outside the navmesh and if this option is enabled the target position will automatically tried to be corrected and moved to the inside of the navmesh.")]
	public bool AutomaticTargetCorrection; // 0x40
	[DrawIf("AutomaticTargetCorrection", 1, 0, 3)]
	[Tooltip(" When setting a target off the navmesh this value defines the radius that is searched to find a valid position.
0 = only at the target position
1 = all cells in radius direction around the target position
Careful: Searching too many cells can greatly impact the performance.
If the search fails or the offline generated fallback triangle is used.")]
	public FP AutomaticTargetCorrectionRadius; // 0x48
	[Tooltip("When using agent rotation speed the agent sometimes will struggle to detect if a waypoint is reached. Use this value to create an perpendicular testing axis in front of the waypoint.")]
	public bool EnableWaypointDetectionAxis; // 0x50
	[DrawIf("EnableWaypointDetectionAxis", 1, 0, 3)]
	public FP WaypointDetectionAxisExtend; // 0x58
	[DrawIf("EnableWaypointDetectionAxis", 1, 0, 3)]
	public FP WaypointDetectionAxisOffset; // 0x60
	[Tooltip("Only required when no steering agent is used. The value used to detect if the agent has reached a waypoint in the beginning of the tick. Set this value to agent max speed * delta time.")]
	public FP DefaultWaypointDetectionDistance; // 0x68
	[Header("Steering")]
	[Tooltip("Select how velocity is applied to the agents component.")]
	public Navigation.MovementType MovementType; // 0x70
	[DrawIf("MovementType", 1, 0, 3)]
	[Tooltip("Only valid when the agents uses 3D transforms. This defines how it's y-position is calculated. Navmesh is default but it has drawbacks because the navmesh geometry might be too simplified and custom tailored.
For 3D physics the ground has be created by Quantum colliders.")]
	public Navigation.VerticalPositioningType VerticalPositioning; // 0x71
	[Tooltip("The maximum speed of the agent. The value can be changed during run-time via the agent component.
The value is cached on the NavMeshSteeringAgent.")]
	public FP Speed; // 0x78
	[Tooltip("The angular speed of the agent (in Radian/sec).
Set to 0 to disable agent rotation.
Set to 200 or more to make its rotation instant-like.")]
	public FP AngularSpeed; // 0x80
	[Tooltip("The acceleration of the agent. The value can be changed during run-time via the agent component.
The value is cached on the NavMeshSteeringAgent.")]
	public FP Acceleration; // 0x88
	[Tooltip("The stopping distance of the agent when approaching the target position.
The value is cached on the NavMeshPathfinderAgent")]
	public FP StoppingDistance; // 0x90
	[Tooltip("If active the agent will start breaking when approaching the target.")]
	public bool AutoBraking; // 0x98
	[DrawIf("AutoBraking", 1, 0, 3)]
	[Tooltip("The distance from the target when the agents starts to brake.")]
	public FP AutoBrakingDistance; // 0xA0
	[DrawIf("MovementType", 1, 0, 3)]
	[Tooltip("The setting makes sure that agents are pushed out of invalid navmesh areas similar to what happens when MovementType.DynamicBody is selected and static colliders push the collider out.")]
	public bool ClampAgentToNavmesh; // 0xA8
	[DrawIf("MovementType", 1, 0, 3)]
	[DrawIf("ClampAgentToNavmesh", 1, 0, 3)]
	[Tooltip("This is a percentage how much the agent is corrected each tick.")]
	public FP ClampAgentToNavmeshCorrection; // 0xB0
	[Header("Avoidance")]
	[Tooltip("Select what type of avoidance procedures are applied to the agent. None will disable the active avoidance but other will still be able to avoid the agent. Remove AvoidanceAgent component to completely disable avoidance.")]
	public Navigation.AvoidanceType AvoidanceType; // 0xB8
	[DrawIf("AvoidanceType", 0, 5, 3)]
	[Tooltip("Fast: legacy avoidance
Good = reasonable number of candidates are calculated with the best cost-benefit ratio
Best = maximum number of collision free candidates are generated")]
	public Navigation.AvoidanceQuality AvoidanceQuality; // 0xB9
	[Tooltip("Agent avoidance priority.
Most important = 0.
Least important = 99.
Default = 50.
The value is cached on the NavMeshAvoidanceAgent.")]
	public byte Priority; // 0xBA
	[Tooltip("Radius used for avoidance calculation.")]
	public FP AvoidanceRadius; // 0xC0
	[Layer]
	[Tooltip("Mark agent with a layer.
The value is cached on the NavMeshAvoidanceAgent.")]
	public int AvoidanceLayer; // 0xC8
	[Tooltip("Other agents that are not in this mask are ignored.
The value is cached on the NavMeshAvoidanceAgent.")]
	public LayerMask AvoidanceMask; // 0xCC
	[DrawIf("AvoidanceType", 2, 0, 3)]
	[Tooltip("Depending on the quality and number of agents that are influencing each other this value needs to be increased to maintain smooth avoidance.")]
	public int MaxAvoidanceCandidates; // 0xD0
	[DrawIf("AvoidanceType", 0, 1, 3)]
	[Tooltip("Activate this to reduce the agent avoidance when getting close to waypoints. Use this only if you have kinematic agents to mitigate agents going off the navmesh. An alternative to this is still under development. 
Try 'dynamic line of sight' when using physic bodies to mitigate stuck agents on waypoints.")]
	public bool ReduceAvoidanceAtWaypoints; // 0xD4
	[DrawIf("AvoidanceType", 0, 1, 3)]
	[DrawIf("ReduceAvoidanceAtWaypoints", 1, 0, 3)]
	[Tooltip("This value is multiplied with the agent radius and represents the distance in which the avoidance influence is reduced quadratically.")]
	public FP ReduceAvoidanceFactor; // 0xD8
	[Tooltip("This option enables velocity candidates that decrease the agents speed, to make the avoidance maneuvers a bit more natural.")]
	public bool AvoidanceCanReduceSpeed; // 0xE0
	[Header("Debug")]
	[Tooltip("Show agent waypoints and velocity.")]
	public bool ShowDebugSteering; // 0xE1
	[Tooltip("Show avoidance information of velocity obstacles and candidates.")]
	public bool ShowDebugAvoidance; // 0xE2
	internal long StoppingDistanceSqrRaw; // 0xE8
	internal long AutoBrakingDistanceSqrRaw; // 0xF0

	// Methods

	// RVA: 0x21D4420 Offset: 0x21D2A20 VA: 0x1821D4420 Slot: 6
	private void Quantum.IBuiltInAssetObject.Dispatch(IAssetObjectVisitor visitor) { }

	// RVA: 0x21D4310 Offset: 0x21D2910 VA: 0x1821D4310 Slot: 4
	public override void Loaded(IResourceManager assets, Native.Allocator allocator) { }

	// RVA: 0x21D44E0 Offset: 0x21D2AE0 VA: 0x1821D44E0
	public void .ctor() { }
}
