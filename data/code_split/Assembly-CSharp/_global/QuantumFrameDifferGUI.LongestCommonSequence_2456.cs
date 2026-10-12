// Namespace: 
private class QuantumFrameDifferGUI.LongestCommonSequence // TypeDefIndex: 2456
{
	// Fields
	private ushort[,] m_c; // 0x10
	private const int MaxSlice = 5000;

	// Methods

	// RVA: 0x4FA6F0 Offset: 0x4F8CF0 VA: 0x1804FA6F0
	public void .ctor() { }

	// RVA: -1 Offset: -1
	public void Diff<T>(T[] x, T[] y, IEqualityComparer<T> comparer, List<QuantumFrameDifferGUI.LongestCommonSequence.DiffChunk> result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCE61B0 Offset: 0xCE47B0 VA: 0x180CE61B0
	|-QuantumFrameDifferGUI.LongestCommonSequence.Diff<object>
	|
	|-RVA: 0xCE5B10 Offset: 0xCE4110 VA: 0x180CE5B10
	|-QuantumFrameDifferGUI.LongestCommonSequence.Diff<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x5205A0 Offset: 0x51EBA0 VA: 0x1805205A0
	private void AllocateMatrix(int x, int y) { }

	// RVA: -1 Offset: -1
	private static void FillMatrix<T>(ushort[,] c, ArraySegment<T> x, ArraySegment<T> y, IEqualityComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCE7620 Offset: 0xCE5C20 VA: 0x180CE7620
	|-QuantumFrameDifferGUI.LongestCommonSequence.FillMatrix<object>
	|
	|-RVA: 0xCE71C0 Offset: 0xCE57C0 VA: 0x180CE71C0
	|-QuantumFrameDifferGUI.LongestCommonSequence.FillMatrix<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private static void FillDiff<T>(ushort[,] c, ArraySegment<T> x, ArraySegment<T> y, IEqualityComparer<T> comparer, List<QuantumFrameDifferGUI.LongestCommonSequence.DiffChunk> result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCE6D60 Offset: 0xCE5360 VA: 0x180CE6D60
	|-QuantumFrameDifferGUI.LongestCommonSequence.FillDiff<object>
	|
	|-RVA: 0xCE66F0 Offset: 0xCE4CF0 VA: 0x180CE66F0
	|-QuantumFrameDifferGUI.LongestCommonSequence.FillDiff<__Il2CppFullySharedGenericType>
	*/
}
