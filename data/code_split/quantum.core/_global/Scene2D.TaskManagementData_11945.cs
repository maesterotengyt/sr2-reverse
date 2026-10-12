// Namespace: 
private struct Scene2D.TaskManagementData // TypeDefIndex: 11945
{
	// Fields
	private const int CollisionSolverHjgsTasksCount = 3;
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
	private TaskDelegateHandle _taskSortCcdManifolds; // 0x1C
	private TaskDelegateHandle _taskCcdCallbacks; // 0x20
	private TaskDelegateHandle _taskCallbacks; // 0x24
	private TaskDelegateHandle _taskCallbacksUpdateEntries; // 0x28
	private TaskDelegateHandle _taskCallbacksUpdateManifolds; // 0x2C
	private TaskDelegateHandle _taskBuildIslands; // 0x30
	private TaskDelegateHandle _taskBuildJointIslands; // 0x34
	private TaskDelegateHandle _taskIntegrateFirstToi; // 0x38
	private TaskDelegateHandle _taskVelocitySolverLegacyGS; // 0x3C
	private TaskDelegateHandle _taskCollisionSolverCacheManifolds; // 0x40
	private TaskDelegateHandle _taskCollisionSolverInit; // 0x44
	private TaskDelegateHandle _taskCollisionSolverCompute; // 0x48
	private TaskDelegateHandle _taskJointsCacheEntries; // 0x4C
	private TaskDelegateHandle _taskJointVelocitySolverInit; // 0x50
	private TaskDelegateHandle _taskJointVelocitySolverCompute; // 0x54
	private TaskDelegateHandle _taskVelocitySolverAggregate; // 0x58
	private TaskDelegateHandle _taskVelocitySolverApply; // 0x5C
	private TaskDelegateHandle _taskIntegrateVelocity; // 0x60
	private TaskDelegateHandle _taskPenetrationCorrection; // 0x64
	private TaskDelegateHandle _taskPosSolverCompute; // 0x68
	private TaskDelegateHandle _taskPosSolverAggregate; // 0x6C
	private TaskDelegateHandle _taskPosSolverApply; // 0x70
	private TaskDelegateHandle _taskSleepDetectionEntries; // 0x74
	private TaskDelegateHandle _taskSleepDetectionIslands; // 0x78
	private TaskDelegateHandle _taskQueryResolve; // 0x7C
	private TaskDelegateHandle _taskEmptyBarrier; // 0x80
	internal AtomicInt IndexerForcesFirstHalf; // 0x84
	internal AtomicInt IndexerEntryPreBuckets; // 0x88
	internal AtomicInt IndexerQueryPreBuckets; // 0x8C
	internal AtomicInt IndexerPostCallbacksUpdateEntries; // 0x90
	internal AtomicInt IndexerPostCallbacksUpdateManifolds; // 0x94
	internal AtomicInt IndexerJointVelocitySolverInit; // 0x98
	internal AtomicInt IndexerIntegrateFirstToi; // 0x9C
	internal AtomicInt IndexerInitCollisionSolver; // 0xA0
	internal AtomicInt IndexerIntegrateVelocity; // 0xA4
	internal AtomicInt IndexerSleepDetection; // 0xA8
	private AtomicInt* _indexerVelocitySolverTasks; // 0xB0
	private int _indexerVelocitySolverTasksCapacity; // 0xB8
	private AtomicInt* _indexerPositionSolverTasks; // 0xC0
	private int _indexerPositionSolverTasksCapacity; // 0xC8

	// Methods

	// RVA: 0x22039F0 Offset: 0x2201FF0 VA: 0x1822039F0
	internal void Allocate(Native.Allocator allocator, PhysicsCommon.Config config) { }

	// RVA: 0x2203AF0 Offset: 0x22020F0 VA: 0x182203AF0
	internal void Dispose(Native.Allocator allocator) { }

	// RVA: 0x2203CF0 Offset: 0x22022F0 VA: 0x182203CF0
	private int GetSolverTypeTaskCount(PhysicsCommon.ConstraintsSolverType solverType) { }

	// RVA: 0x2203DA0 Offset: 0x22023A0 VA: 0x182203DA0
	internal void RegisterCallbacks(TaskContext context) { }

	// RVA: 0x2204920 Offset: 0x2202F20 VA: 0x182204920
	internal void Reset() { }

	// RVA: 0x2205050 Offset: 0x2203650 VA: 0x182205050
	internal TaskHandle ScheduleTasks(FrameContext context, TaskHandle taskHandle) { }

	// RVA: 0x2204DE0 Offset: 0x22033E0 VA: 0x182204DE0
	private void ScheduleSolverTasksLegacyGS(FrameContext context, Scene2D* scene, TaskHandle updateManifolds, TaskHandle firstToi, TaskHandle buildIslands, TaskHandle buildJointIslands, TaskHandle jointVelSolverInit, ref TaskHandle lastSolverTask) { }

	// RVA: 0x2204A70 Offset: 0x2203070 VA: 0x182204A70
	private void ScheduleSolverTasksHJGS(FrameContext context, Scene2D* scene, TaskHandle updateManifolds, TaskHandle firstToi, TaskHandle buildIslands, TaskHandle buildJointIslands, TaskHandle jointVelSolverInit, ref TaskHandle lastSolverTask) { }

	// RVA: 0x2203C40 Offset: 0x2202240 VA: 0x182203C40
	private void EnsureVelocitySolverIndexerCapacity(Native.Allocator allocator, int capacity) { }

	// RVA: 0x2203B90 Offset: 0x2202190 VA: 0x182203B90
	private void EnsurePositionSolverIndexerCapacity(Native.Allocator allocator, int capacity) { }

	// RVA: 0x4F3940 Offset: 0x4F1F40 VA: 0x1804F3940
	private static void Task_EmptyBarrier(FrameThreadSafe frame, int start, int count, void* arg) { }
}
