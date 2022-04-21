using System;
using ApptentiveKit.iOS;
namespace ApptentiveKit.iOS
{
    public class ApptentiveConfiguration
    {
        readonly String key;
        readonly String signature;

        public ApptentiveConfiguration(string apptentiveKey, string apptentiveSignature)
        {
            key = apptentiveKey;
            signature = apptentiveSignature;
        }
        public void Register() {
            Apptentive.Shared.Register(key, signature, (registered) => System.Console.WriteLine("Registered"));
            Apptentive.Shared.DistributionName = "Xamarin";
            Apptentive.Shared.DistributionVersion = GetType().Assembly.GetName().Version.ToString(3);
        }
    }
}
