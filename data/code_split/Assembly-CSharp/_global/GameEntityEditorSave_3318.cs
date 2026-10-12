// Namespace: 
public class GameEntityEditorSave // TypeDefIndex: 3318
{
	// Fields
	private static string gameEntityEditorSavePath; // 0x0
	private static string workspacesSavePath; // 0x8
	private GameEntityEditorSaveData Data; // 0x10
	private GameEntityEditorWorkspaces WorkspacesData; // 0x20

	// Properties
	public PreviewElementsMask StatePreviewVisibleElements { get; set; }
	public string CurrentWorkspace { get; set; }

	// Methods

	// RVA: 0x502900 Offset: 0x500F00 VA: 0x180502900
	public PreviewElementsMask get_StatePreviewVisibleElements() { }

	// RVA: 0x520750 Offset: 0x51ED50 VA: 0x180520750
	public void set_StatePreviewVisibleElements(PreviewElementsMask value) { }

	// RVA: 0x4FA3A0 Offset: 0x4F89A0 VA: 0x1804FA3A0
	public string get_CurrentWorkspace() { }

	// RVA: 0x5B5080 Offset: 0x5B3680 VA: 0x1805B5080
	public void set_CurrentWorkspace(string value) { }

	// RVA: 0x5B5060 Offset: 0x5B3660 VA: 0x1805B5060
	public void .ctor() { }

	// RVA: 0x5B4CA0 Offset: 0x5B32A0 VA: 0x1805B4CA0
	public void SaveAll() { }

	// RVA: 0x5B4DE0 Offset: 0x5B33E0 VA: 0x1805B4DE0
	public void SaveData() { }

	// RVA: 0x5B4E90 Offset: 0x5B3490 VA: 0x1805B4E90
	public void SaveWorkspaces() { }

	// RVA: 0x5B4A40 Offset: 0x5B3040 VA: 0x1805B4A40
	public void LoadData() { }

	// RVA: 0x5B47A0 Offset: 0x5B2DA0 VA: 0x1805B47A0
	public List<string> GetWorkspaces() { }

	// RVA: 0x5B4650 Offset: 0x5B2C50 VA: 0x1805B4650
	public bool CreateNewWorkspace(string workspaceName) { }

	// RVA: 0x5B46F0 Offset: 0x5B2CF0 VA: 0x1805B46F0
	public bool DeleteWorkspace(string workspaceName) { }

	// RVA: 0x5B4640 Offset: 0x5B2C40 VA: 0x1805B4640
	public bool AddEntityToWorkspace(string workspaceName, string entityName) { }

	// RVA: 0x5B4C90 Offset: 0x5B3290 VA: 0x1805B4C90
	public bool RemoveEntityFromWorkspace(string workspaceName, string entityName) { }

	// RVA: 0x5B4790 Offset: 0x5B2D90 VA: 0x1805B4790
	public List<string> GetWorkspaceEntities(string workspaceName) { }

	// RVA: 0x5B4F30 Offset: 0x5B3530 VA: 0x1805B4F30
	private static void .cctor() { }
}
