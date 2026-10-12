// Namespace: BrainFailProductions.PolyFew
public static class SystemServices // TypeDefIndex: 4069
{
	// Fields
	public static SystemServices.RegexPatterns regexPatterns; // 0x0

	// Methods

	// RVA: 0x6B1FC0 Offset: 0x6B05C0 VA: 0x1806B1FC0
	private static void SetPatterns() { }

	[IteratorStateMachine(typeof(SystemServices.<UnityAsyncGETRequest>d__3))]
	// RVA: 0x6B2180 Offset: 0x6B0780 VA: 0x1806B2180
	public static IEnumerator UnityAsyncGETRequest(string encodedUrl, Action<string, long> callback, Nullable<int> timeout, Dictionary<string, string> headers) { }

	// RVA: 0x6B22D0 Offset: 0x6B08D0 VA: 0x1806B22D0
	public static void UnityBlockingGETRequest(string encodedUrl, Action<string, long> callback, Nullable<int> timeout, Dictionary<string, string> headers) { }

	// RVA: 0x6B2620 Offset: 0x6B0C20 VA: 0x1806B2620
	public static void UnityBlockingPOSTRequest(string baseUrl, Action<string, long> callback, byte[] data, Nullable<int> timeout, Dictionary<string, string> headers) { }

	[IteratorStateMachine(typeof(SystemServices.<UnityAsyncPOSTRequest>d__6))]
	// RVA: 0x6B2220 Offset: 0x6B0820 VA: 0x1806B2220
	public static IEnumerator UnityAsyncPOSTRequest(string baseUrl, Action<string, long> callback, byte[] data, Nullable<int> timeout, Dictionary<string, string> headers) { }

	[AsyncStateMachine(typeof(SystemServices.<SendHTTPRequestAsync>d__7))]
	// RVA: 0x6B1460 Offset: 0x6AFA60 VA: 0x1806B1460
	public static Task SendHTTPRequestAsync(string baseUrl, SystemServices.HTTPMethod requestMethod, Action<string, Nullable<HttpStatusCode>> callback, Dictionary<string, string> requestParameters, byte[] postData, string contentType, Nullable<int> timeout, Dictionary<string, string> header) { }

	// RVA: 0x6B15B0 Offset: 0x6AFBB0 VA: 0x1806B15B0
	public static void SendHTTPRequestBlocking(string baseUrl, SystemServices.HTTPMethod requestMethod, Action<string, Nullable<HttpStatusCode>> callback, Dictionary<string, string> requestParameters, byte[] postData, string contentType, Nullable<int> timeout, Dictionary<string, string> header) { }

	[AsyncStateMachine(typeof(SystemServices.<AsyncResourceDownload>d__9))]
	// RVA: 0x6B0900 Offset: 0x6AEF00 VA: 0x1806B0900
	public static Task AsyncResourceDownload(string resourceUrl, Action<byte[], string, Nullable<HttpStatusCode>> callback, Nullable<int> timeout) { }

	[AsyncStateMachine(typeof(SystemServices.<AsyncReachabilityCheck>d__10))]
	// RVA: 0x6B0810 Offset: 0x6AEE10 VA: 0x1806B0810
	public static Task AsyncReachabilityCheck(string testUrl, Action<bool> callback) { }

	// RVA: 0x6B0A10 Offset: 0x6AF010 VA: 0x1806B0A10
	public static void BlockingReachabilityCheck(string url, Action<bool> callback) { }

	// RVA: 0x6B0DE0 Offset: 0x6AF3E0 VA: 0x1806B0DE0
	public static SystemServices.MessagePatternPair ParseResponseMessage(string message) { }

	// RVA: 0x6B0DC0 Offset: 0x6AF3C0 VA: 0x1806B0DC0
	public static bool IsSuccessStatusCode(long statusCode) { }

	// RVA: 0x6B0B40 Offset: 0x6AF140 VA: 0x1806B0B40
	public static string GetQueryStringFromKeyValues(Dictionary<string, string> parameters) { }

	[AsyncStateMachine(typeof(SystemServices.<RunDelayedCommand>d__17))]
	// RVA: 0x6B1370 Offset: 0x6AF970 VA: 0x1806B1370
	public static Task RunDelayedCommand(float secs, Action command) { }

	// RVA: 0x6B1140 Offset: 0x6AF740 VA: 0x1806B1140
	public static byte[] ReadAllBytes(Stream source) { }

	[AsyncStateMachine(typeof(SystemServices.<WriteTextureAsync>d__19))]
	// RVA: 0x6B2B00 Offset: 0x6B1100 VA: 0x1806B2B00
	public static Task WriteTextureAsync(Texture2D texture, SystemServices.ImageFormat format, string fileName, string path, Action<string> callback) { }

	[AsyncStateMachine(typeof(SystemServices.<WriteBytesAsync>d__20))]
	// RVA: 0x6B29E0 Offset: 0x6B0FE0 VA: 0x1806B29E0
	public static Task WriteBytesAsync(byte[] data, string fullPath, Action<string> callback) { }
}
