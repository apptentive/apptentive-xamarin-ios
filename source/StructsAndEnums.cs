using ObjCRuntime;

namespace ApptentiveKit.iOS
{
	// We currently need this because the Swift log level property isn't
	// exportable as Objective-C
	[Native]
	public enum ApptentiveLogLevel : ulong
	{
		Undefined = 0,
		Crit = 1,
		Error = 2,
		Warn = 3,
		Info = 4,
		Debug = 5,
		Verbose = 6
	}
}
