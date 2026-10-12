// Namespace: 
private struct Scene3D.TaskManagementData // TypeDefIndex: 11856
{
	// Fields
	private const int CollisionSolverHjgsTasksCount = 5;
	private const int CollisionSolverGsTasksCount = 1;
	private const int JointsVelSolverIterationTasksCount = 1;
	private const int JointPosSolverIterationTasksCount = 3;
	private TaskDelegateHandle _taskCreateEntries; // 0x0
	private TaskDelegateHandle _taskCreateEntriesMapping; // 0x4
	private TaskDelegateHandle _taskIntegrateForcesFirstHalf; // 0x8
	private TaskDelegateHandle _taskBroadPhaseEntryPreStep; // 0xC
	private TaskDelegateHandle _taskBroadPhaseQueryPreStep; // 0x10
	private TaskDelegateHandle _taskBroadPhase; // 0x14
	private TaskDelegateHandle _taskNarrowPhase; // 0x18
	private TaskDelegateHandle _taskNarrowPhaseMeshes; // 0x1C
	private TaskDelegateHandle _taskSortCcdManifolds; // 0x20
	private TaskDelegateHandle _taskCcdCallbacks; // 0x24
	private TaskDelegateHandle _taskCallbacks; // 0x28
	private TaskDelegateHandle _taskCallbacksUpdateEntries; // 0x2C
	private TaskDelegateHandle _taskCallbacksUpdateManifolds; // 0x30
	private TaskDelegateHandle _taskBuildIslands; // 0x34
	private TaskDelegateHandle _taskBuildJointIslands; // 0x38
	private TaskDelegateHandle _taskIntegrateFirstToi; // 0x3C
	private TaskDelegateHandle _taskCollisionSolverInitLegacyGS; // 0x40
	private TaskDelegateHandle _taskVelocitySolverLegacyGS; // 0x44
	private TaskDelegateHandle _taskCollisionSolverCacheManifolds; // 0x48
	private TaskDelegateHandle _taskCollisionSolverInit; // 0x4C
	private TaskDelegateHandle _taskCollisionSolverCompute; // 0x50
	private TaskDelegateHandle _taskCollisionSolverAggregateMesh; // 0x54
	private TaskDelegateHandle _taskCollisionSolverAggregate; // 0x58
	private TaskDelegateHandle _taskJointsCacheEntries; // 0x5C
	private TaskDelegateHandle _taskJointVelocitySolverInit; // 0x60
	private TaskDelegateHandle _taskJointVelocitySolverCompute; // 0x64
	private TaskDelegateHandle _taskVelocitySolverAggregate; // 0x68
	private TaskDelegateHandle _taskVelocitySolverApply; // 0x6C
	private TaskDelegateHandle _taskIntegrateVelocity; // 0x70
	private TaskDelegateHandle _taskPenetrationCorrection; // 0x74
	private TaskDelegateHandle _taskPosSolverCompute; // 0x78
	private TaskDelegateHandle _taskPosSolverAggregate; // 0x7C
	private TaskDelegateHandle _taskPosSolverApply; // 0x80
	private TaskDelegateHandle _taskSleepDetectionEntries; // 0x84
	private TaskDelegateHandle _taskSleepDetectionIslands; // 0x88
	private TaskDelegateHandle _taskQueryResolve; // 0x8C
	private TaskDelegateHandle _taskEmptyBarrier; // 0x90
	internal AtomicInt IndexerForcesFirstHalf; // 0x94
	internal AtomicInt IndexerEntryPreBuckets; // 0x98
	internal AtomicInt IndexerQueryPreBuckets; // 0x9C
	internal AtomicInt IndexerPostCallbacksUpdateEntries; // 0xA0
	internal AtomicInt IndexerPostCallbacksUpdateManifolds; // 0xA4
	internal AtomicInt IndexerJointVelocitySolverInit; // 0xA8
	internal AtomicInt IndexerIntegrateFirstToi; // 0xAC
	internal AtomicInt IndexerInitCollisionSolver; // 0xB0
	internal AtomicInt IndexerIntegrateVelocity; // 0xB4
	internal AtomicInt IndexerSleepDetection; // 0xB8
	private AtomicInt* _indexerVelocitySolverTasks; // 0xC0
	private int _indexerVelocitySolverTasksCapacity; // 0xC8
	private AtomicInt* _indexerPositionSolverTasks; // 0xD0
	private int _indexerPositionSolverTasksCapacity; // 0xD8

	// Methods

	// RVA: 0x2267220 Offset: 0x2265820 VA: 0x182267220
	internal void Allocate(Native.Allocator allocator, PhysicsCommon.Config config) { }

	// RVA: 0x2267320 Offset: 0x2265920 VA: 0x182267320
	internal void Dispose(Native.Allocator allocator) { }

	// RVA: 0x2267470 Offset: 0x2265A70 VA: 0x182267470
	private int GetSolverTypeTaskCount(PhysicsCommon.ConstraintsSolverType solverType) { }

	// RVA: 0x2267520 Offset: 0x2265B20 VA: 0x182267520
	internal void RegisterCallbacks(TaskContext context) { }

	// RVA: 0x2268200 Offset: 0x2266800 VA: 0x182268200
	internal void Reset() { }

	// RVA: 0x22689F0 Offset: 0x2266FF0 VA: 0x1822689F0
	internal TaskHandle ScheduleTasks(FrameContext context, TaskHandle taskHandle) { }

	// RVA: 0x2268780 Offset: 0x2266D80 VA: 0x182268780
	private void ScheduleSolverTasksLGS(FrameContext context, Scene3D* scene, TaskHandle updateManifolds, TaskHandle firstToi, TaskHandle buildIslands, TaskHandle buildJointIslands, TaskHandle jointVelSolverInit, ref TaskHandle lastSolverTask) { }

	// RVA: 0x2268350 Offset: 0x2266950 VA: 0x182268350
	private void ScheduleSolverTasksHJGS(FrameContext context, Scene3D* scene, TaskHandle updateManifolds, TaskHandle firstToi, TaskHandle buildIslands, TaskHandle buildJointIslands, TaskHandle jointVelSolverInit, ref TaskHandle lastSolverTask) { }

	// RVA: 0x2203B90 Offset: 0x2202190 VA: 0x182203B90
	private void EnsureVelocitySolverIndexerCapacity(Native.Allocator allocator, int capacity) { }

	// RVA: 0x22673C0 Offset: 0x22659C0 VA: 0x1822673C0
	private void EnsurePositionSolverIndexerCapacity(Native.Allocator allocator, int capacity) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940
	private static void Task_EmptyBarrier(FrameThreadSafe frame, int start, int count, void* arg) { }
}
