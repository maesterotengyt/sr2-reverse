// Namespace: 
public struct GameEntityEditorWorkspaces // TypeDefIndex: 3320
{
	// Fields
	public List<GameEntityEditorWorkspaceData> Workspaces; // 0x0

	// Methods

	// RVA: 0x5B54D0 Offset: 0x5B3AD0 VA: 0x1805B54D0
	public static GameEntityEditorWorkspaces Default() { }

	// RVA: 0x5B5300 Offset: 0x5B3900 VA: 0x1805B5300
	public bool CreateNewWorkspace(string workspaceName) { }

	// RVA: 0x5B5550 Offset: 0x5B3B50 VA: 0x1805B5550
	public bool DeleteWorkspace(string workspaceName) { }

	// RVA: 0x5B5210 Offset: 0x5B3810 VA: 0x1805B5210
	public bool AddEntityToWorkspace(string workspaceName, string entityName) { }

	// RVA: 0x5B5750 Offset: 0x5B3D50 VA: 0x1805B5750
	public bool RemoveEntityFromWorkspace(string workspaceName, string entityName) { }

	// RVA: 0x5B5630 Offset: 0x5B3C30 VA: 0x1805B5630
	public List<string> GetWorkspaceEntities(string workspaceName) { }
}
