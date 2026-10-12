// Namespace: 
private sealed class GA_MiniJSON.Parser : IDisposable // TypeDefIndex: 3793
{
	// Fields
	private const string WORD_BREAK = "{}[],:\"";
	private StringReader json; // 0x10

	// Properties
	private char PeekChar { get; }
	private char NextChar { get; }
	private string NextWord { get; }
	private GA_MiniJSON.Parser.TOKEN NextToken { get; }

	// Methods

	// RVA: 0x665150 Offset: 0x663750 VA: 0x180665150
	public static bool IsWordBreak(char c) { }

	// RVA: 0x665CA0 Offset: 0x6642A0 VA: 0x180665CA0
	private void .ctor(string jsonString) { }

	// RVA: 0x665B50 Offset: 0x664150 VA: 0x180665B50
	public static object Parse(string jsonString) { }

	// RVA: 0x665030 Offset: 0x663630 VA: 0x180665030 Slot: 4
	public void Dispose() { }

	// RVA: 0x6656C0 Offset: 0x663CC0 VA: 0x1806656C0
	private Dictionary<string, object> ParseObject() { }

	// RVA: 0x6651D0 Offset: 0x6637D0 VA: 0x1806651D0
	private List<object> ParseArray() { }

	// RVA: 0x665B20 Offset: 0x664120 VA: 0x180665B20
	private object ParseValue() { }

	// RVA: 0x6652B0 Offset: 0x6638B0 VA: 0x1806652B0
	private object ParseByToken(GA_MiniJSON.Parser.TOKEN token) { }

	// RVA: 0x665810 Offset: 0x663E10 VA: 0x180665810
	private string ParseString() { }

	// RVA: 0x665620 Offset: 0x663C20 VA: 0x180665620
	private object ParseNumber() { }

	// RVA: 0x665070 Offset: 0x663670 VA: 0x180665070
	private void EatWhitespace() { }

	// RVA: 0x666280 Offset: 0x664880 VA: 0x180666280
	private char get_PeekChar() { }

	// RVA: 0x665D20 Offset: 0x664320 VA: 0x180665D20
	private char get_NextChar() { }

	// RVA: 0x6660B0 Offset: 0x6646B0 VA: 0x1806660B0
	private string get_NextWord() { }

	// RVA: 0x665D90 Offset: 0x664390 VA: 0x180665D90
	private GA_MiniJSON.Parser.TOKEN get_NextToken() { }
}
