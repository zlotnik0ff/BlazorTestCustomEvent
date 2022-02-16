using Microsoft.AspNetCore.Components;

namespace BlazorApp1;

[EventHandler("onpastemultimedia", typeof(PasteMultimediaEventArgs), enableStopPropagation: true, enablePreventDefault: true)]
public static class CustomEventHandlers
{
	
}

public class PasteMultimediaEventArgs : EventArgs
{
	//public IEnumerable<ValueTuple<bool, string>> PastedMultimedia { get; set; }
	public bool IsMultimedia { get; set; }
	public string Data { get; set; }
}