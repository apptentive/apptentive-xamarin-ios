using System;
using ObjCRuntime;

namespace ApptentiveSDK.iOS
{
    [Native]
    public enum ApptentiveLogLevel : ulong
    {
        Crit = 0,
        Error = 1,
        Warn = 2,
        Info = 3,
        Debug = 4,
        Verbose = 5
    }
}
