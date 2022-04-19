using ObjCRuntime;

namespace ApptentiveKit.iOS
{
	[Native]
	public enum ApptentiveAuthenticationFailureReason : long
	{
		Unknown = 0,
		InvalidAlgorithm = 1,
		MalformedToken = 2,
		InvalidToken = 3,
		MissingSubClaim = 4,
		MismatchedSubClaim = 5,
		InvalidSubClaim = 6,
		ExpiredToken = 7,
		RevokedToken = 8,
		MissingAppKey = 9,
		MissingAppSignature = 10,
		InvalidKeySignaturePair = 11
	}

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

	[Native]
	public enum ApptentivePushProvider : long
	{
		Apptentive = 0,
		UrbanAirship = 1,
		AmazonSNS = 2,
		Parse = 3
	}
}
