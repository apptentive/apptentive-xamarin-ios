using System;
using ApptentiveKit;
using Foundation;
using ObjCRuntime;
using UIKit;
using UserNotifications;

namespace ApptentiveKit.iOS
{
	// @interface Apptentive : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13ApptentiveKit10Apptentive")]
	[DisableDefaultCtor]
	interface Apptentive
	{
		// @property (readonly, nonatomic, strong, class) Apptentive * _Nonnull shared;
		[Static]
		[Export ("shared", ArgumentSemantic.Strong)]
		Apptentive Shared { get; }

		// @property (copy, nonatomic) NSString * _Nullable personName;
		[NullAllowed, Export ("personName")]
		string PersonName { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable personEmailAddress;
		[NullAllowed, Export ("personEmailAddress")]
		string PersonEmailAddress { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable mParticleID;
		[NullAllowed, Export ("mParticleID")]
		string MParticleID { get; set; }

		// @property (nonatomic) NSInteger unreadMessageCount;
		[Export ("unreadMessageCount")]
		nint UnreadMessageCount { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable distributionName;
		[NullAllowed, Export ("distributionName")]
		string DistributionName { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable distributionVersion;
		[NullAllowed, Export ("distributionVersion")]
		string DistributionVersion { get; set; }

		// -(void)sendAttachmentText:(NSString * _Nonnull)text;
		[Export ("sendAttachmentText:")]
		void SendAttachmentText (string text);

		// -(void)sendAttachmentImage:(UIImage * _Nonnull)image;
		[Export ("sendAttachmentImage:")]
		void SendAttachmentImage (UIImage image);

		// -(void)sendAttachmentData:(NSData * _Nonnull)fileData mimeType:(NSString * _Nonnull)mediaType;
		[Export ("sendAttachmentData:mimeType:")]
		void SendAttachmentData (NSData fileData, string mediaType);
	}

	// @interface ApptentiveKit_Swift_277 (Apptentive) <UNUserNotificationCenterDelegate>
	[Category]
	[BaseType (typeof(Apptentive))]
	interface Apptentive_ApptentiveKit_Swift_277 : IUNUserNotificationCenterDelegate
	{
		// -(void)setRemoteNotifcationDeviceToken:(NSData * _Nonnull)tokenData;
		[Export ("setRemoteNotifcationDeviceToken:")]
		void SetRemoteNotifcationDeviceToken (NSData tokenData);

		// -(BOOL)didReceiveRemoteNotification:(NSDictionary * _Nonnull)userInfo fetchCompletionHandler:(void (^ _Nonnull)(UIBackgroundFetchResult))completionHandler __attribute__((warn_unused_result("")));
		[Export ("didReceiveRemoteNotification:fetchCompletionHandler:")]
		bool DidReceiveRemoteNotification (NSDictionary userInfo, Action<UIBackgroundFetchResult> completionHandler);

		// -(BOOL)didReceveUserNotificationResponse:(UNNotificationResponse * _Nonnull)response withCompletionHandler:(void (^ _Nonnull)(void))completionHandler __attribute__((warn_unused_result("")));
		[Export ("didReceveUserNotificationResponse:withCompletionHandler:")]
		bool DidReceveUserNotificationResponse (UNNotificationResponse response, Action completionHandler);

		// -(BOOL)willPresent:(UNNotification * _Nonnull)notification withCompletionHandler:(void (^ _Nonnull)(UNNotificationPresentationOptions))completionHandler __attribute__((warn_unused_result("")));
		[Export ("willPresent:withCompletionHandler:")]
		bool WillPresent (UNNotification notification, Action<UNNotificationPresentationOptions> completionHandler);

		// -(void)userNotificationCenter:(UNUserNotificationCenter * _Nonnull)center willPresentNotification:(UNNotification * _Nonnull)notification withCompletionHandler:(void (^ _Nonnull)(UNNotificationPresentationOptions))completionHandler;
		[Export ("userNotificationCenter:willPresentNotification:withCompletionHandler:")]
		void UserNotificationCenter (UNUserNotificationCenter center, UNNotification notification, Action<UNNotificationPresentationOptions> completionHandler);

		// -(void)userNotificationCenter:(UNUserNotificationCenter * _Nonnull)center didReceiveNotificationResponse:(UNNotificationResponse * _Nonnull)response withCompletionHandler:(void (^ _Nonnull)(void))completionHandler;
		[Export ("userNotificationCenter:didReceiveNotificationResponse:withCompletionHandler:")]
		void UserNotificationCenter (UNUserNotificationCenter center, UNNotificationResponse response, Action completionHandler);
	}

	// @interface ApptentiveKit_Swift_349 (Apptentive)
	[Category]
	[BaseType (typeof(Apptentive))]
	interface Apptentive_ApptentiveKit_Swift_349
	{
		// +(void)registerWithConfiguration:(ApptentiveConfiguration * _Nonnull)configuration __attribute__((deprecated("Use the 'register(with:completion:)' method on the 'shared' instance instead.")));
		[Static]
		[Export ("registerWithConfiguration:")]
		void RegisterWithConfiguration (ApptentiveConfiguration configuration);

		// -(void)registerWithKey:(NSString * _Nonnull)key signature:(NSString * _Nonnull)signature completion:(void (^ _Nullable)(BOOL))completion;
		[Export ("registerWithKey:signature:completion:")]
		void RegisterWithKey (string key, string signature, [NullAllowed] Action<bool> completion);

		// +(Apptentive * _Nonnull)sharedConnection __attribute__((warn_unused_result(""))) __attribute__((deprecated("Use the 'shared' static property instead.")));
		[Static]
		[Export ("sharedConnection")]
		[Verify (MethodToProperty)]
		Apptentive SharedConnection { get; }

		// @property (copy, nonatomic) SWIFT_DEPRECATED_MSG("This property is ignored. SKStoreReviewController will be used for all ratings.") NSString * appID __attribute__((deprecated("This property is ignored. SKStoreReviewController will be used for all ratings.")));
		[Export ("appID")]
		string AppID { get; set; }

		// @property (nonatomic) BOOL showInfoButton __attribute__((deprecated("This property is ignored. The info button no longer exists.")));
		[Export ("showInfoButton")]
		bool ShowInfoButton { get; set; }

		// @property (nonatomic, strong) SWIFT_DEPRECATED_MSG("This feature is not implemented.") TermsAndConditions * surveyTermsAndConditions __attribute__((deprecated("This feature is not implemented.")));
		[Export ("surveyTermsAndConditions", ArgumentSemantic.Strong)]
		TermsAndConditions SurveyTermsAndConditions { get; set; }

		// @property (readonly, copy, nonatomic) SWIFT_DEPRECATED_MSG("This property is not available for reading.") NSString * apptentiveKey __attribute__((deprecated("This property is not available for reading.")));
		[Export ("apptentiveKey")]
		string ApptentiveKey { get; }

		// @property (readonly, copy, nonatomic) SWIFT_DEPRECATED_MSG("This property is not available for reading.") NSString * apptentiveSignature __attribute__((deprecated("This property is not available for reading.")));
		[Export ("apptentiveSignature")]
		string ApptentiveSignature { get; }

		// -(void)engage:(NSString * _Nonnull)event fromViewController:(UIViewController * _Nullable)viewController;
		[Export ("engage:fromViewController:")]
		void Engage (string @event, [NullAllowed] UIViewController viewController);

		// -(void)engage:(NSString * _Nonnull)event fromViewController:(UIViewController * _Nullable)viewController completion:(void (^ _Nullable)(BOOL))completion;
		[Export ("engage:fromViewController:completion:")]
		void Engage (string @event, [NullAllowed] UIViewController viewController, [NullAllowed] Action<bool> completion);

		// -(void)engage:(NSString * _Nonnull)event withCustomData:(NSDictionary * _Nullable)customData fromViewController:(UIViewController * _Nullable)viewController;
		[Export ("engage:withCustomData:fromViewController:")]
		void Engage (string @event, [NullAllowed] NSDictionary customData, [NullAllowed] UIViewController viewController);

		// -(void)engage:(NSString * _Nonnull)event withCustomData:(NSDictionary * _Nullable)customData fromViewController:(UIViewController * _Nullable)viewController completion:(void (^ _Nullable)(BOOL))completion;
		[Export ("engage:withCustomData:fromViewController:completion:")]
		void Engage (string @event, [NullAllowed] NSDictionary customData, [NullAllowed] UIViewController viewController, [NullAllowed] Action<bool> completion);

		// -(void)engage:(NSString * _Nonnull)event withCustomData:(NSDictionary * _Nullable)customData withExtendedData:(NSArray<NSDictionary *> * _Nullable)extendedData fromViewController:(UIViewController * _Nullable)viewController __attribute__((deprecated("Event extended data are no longer supported. Event will be engaged without extended data.")));
		[Export ("engage:withCustomData:withExtendedData:fromViewController:")]
		void Engage (string @event, [NullAllowed] NSDictionary customData, [NullAllowed] NSDictionary[] extendedData, [NullAllowed] UIViewController viewController);

		// -(void)engage:(NSString * _Nonnull)event withCustomData:(NSDictionary * _Nullable)customData withExtendedData:(NSArray<NSDictionary *> * _Nullable)extendedData fromViewController:(UIViewController * _Nullable)viewController completion:(void (^ _Nullable)(BOOL))completion __attribute__((deprecated("Event extended data are no longer supported. Event will be engaged without extended data.")));
		[Export ("engage:withCustomData:withExtendedData:fromViewController:completion:")]
		void Engage (string @event, [NullAllowed] NSDictionary customData, [NullAllowed] NSDictionary[] extendedData, [NullAllowed] UIViewController viewController, [NullAllowed] Action<bool> completion);

		// -(void)queryCanShowInteractionForEvent:(NSString * _Nonnull)event completion:(void (^ _Nonnull)(BOOL))completion;
		[Export ("queryCanShowInteractionForEvent:completion:")]
		void QueryCanShowInteractionForEvent (string @event, Action<bool> completion);

		// +(NSDictionary * _Nonnull)extendedDataDate:(NSDate * _Nonnull)date __attribute__((warn_unused_result(""))) __attribute__((deprecated("Extended event data are no longer supported.")));
		[Static]
		[Export ("extendedDataDate:")]
		NSDictionary ExtendedDataDate (NSDate date);

		// +(NSDictionary * _Nonnull)extendedDataLocationForLatitude:(double)latitude longitude:(double)longitude __attribute__((warn_unused_result(""))) __attribute__((deprecated("Extended event data are no longer supported.")));
		[Static]
		[Export ("extendedDataLocationForLatitude:longitude:")]
		NSDictionary ExtendedDataLocationForLatitude (double latitude, double longitude);

		// +(NSDictionary * _Nonnull)extendedDataCommerceWithTransactionID:(NSString * _Nullable)transactionID affiliation:(NSString * _Nullable)affiliation revenue:(NSNumber * _Nullable)revenue shipping:(NSNumber * _Nullable)shipping tax:(NSNumber * _Nullable)tax currency:(NSString * _Nullable)currency commerceItems:(NSArray<NSDictionary *> * _Nullable)commerceItems __attribute__((warn_unused_result(""))) __attribute__((deprecated("Extended event data are no longer supported.")));
		[Static]
		[Export ("extendedDataCommerceWithTransactionID:affiliation:revenue:shipping:tax:currency:commerceItems:")]
		NSDictionary ExtendedDataCommerceWithTransactionID ([NullAllowed] string transactionID, [NullAllowed] string affiliation, [NullAllowed] NSNumber revenue, [NullAllowed] NSNumber shipping, [NullAllowed] NSNumber tax, [NullAllowed] string currency, [NullAllowed] NSDictionary[] commerceItems);

		// +(NSDictionary * _Nonnull)extendedDataCommerceItemWithItemID:(NSString * _Nullable)itemID name:(NSString * _Nullable)name category:(NSString * _Nullable)category price:(NSNumber * _Nullable)price quantity:(NSNumber * _Nullable)quantity currency:(NSString * _Nullable)currency __attribute__((warn_unused_result(""))) __attribute__((deprecated("Extended event data are no longer supported.")));
		[Static]
		[Export ("extendedDataCommerceItemWithItemID:name:category:price:quantity:currency:")]
		NSDictionary ExtendedDataCommerceItemWithItemID ([NullAllowed] string itemID, [NullAllowed] string name, [NullAllowed] string category, [NullAllowed] NSNumber price, [NullAllowed] NSNumber quantity, [NullAllowed] string currency);

		// -(void)queryCanShowMessageCenterWithCompletion:(void (^ _Nonnull)(BOOL))completion __attribute__((deprecated("This feature is not implemented and will always result in false.")));
		[Export ("queryCanShowMessageCenterWithCompletion:")]
		void QueryCanShowMessageCenterWithCompletion (Action<bool> completion);

		// -(void)presentMessageCenterFromViewController:(UIViewController * _Nullable)viewController completion:(void (^ _Nullable)(BOOL))completion;
		[Export ("presentMessageCenterFromViewController:completion:")]
		void PresentMessageCenterFromViewController ([NullAllowed] UIViewController viewController, [NullAllowed] Action<bool> completion);

		// -(void)presentMessageCenterFromViewController:(UIViewController * _Nullable)viewController withCustomData:(NSDictionary * _Nullable)customData;
		[Export ("presentMessageCenterFromViewController:withCustomData:")]
		void PresentMessageCenterFromViewController ([NullAllowed] UIViewController viewController, [NullAllowed] NSDictionary customData);

		// -(void)presentMessageCenterFromViewController:(UIViewController * _Nullable)viewController withCustomData:(NSDictionary * _Nullable)customData completion:(void (^ _Nullable)(BOOL))completion;
		[Export ("presentMessageCenterFromViewController:withCustomData:completion:")]
		void PresentMessageCenterFromViewController ([NullAllowed] UIViewController viewController, [NullAllowed] NSDictionary customData, [NullAllowed] Action<bool> completion);

		// -(void)dismissMessageCenterWithAnimated:(BOOL)animated completion:(void (^ _Nullable)(void))completion __attribute__((deprecated("This feature is not implemented and this method will always result in false.")));
		[Export ("dismissMessageCenterWithAnimated:completion:")]
		void DismissMessageCenterWithAnimated (bool animated, [NullAllowed] Action completion);

		// -(UIView * _Nonnull)unreadMessageCountAccessoryViewWithApptentiveHeart:(BOOL)apptentiveHeart __attribute__((warn_unused_result(""))) __attribute__((deprecated("This feature is not implemented and this property will return an empty view.")));
		[Export ("unreadMessageCountAccessoryViewWithApptentiveHeart:")]
		UIView UnreadMessageCountAccessoryViewWithApptentiveHeart (bool apptentiveHeart);

		// -(void)openAppStore __attribute__((deprecated("This method is no longer implemented and will trigger an assertion failure.")));
		[Export ("openAppStore")]
		void OpenAppStore ();

		// -(void)setPushProvider:(enum ApptentivePushProvider)pushProvider deviceToken:(NSData * _Nonnull)deviceToken __attribute__((deprecated("Use the 'setRemoteNotificationToken()' method instead.")));
		[Export ("setPushProvider:deviceToken:")]
		void SetPushProvider (ApptentivePushProvider pushProvider, NSData deviceToken);

		// -(BOOL)didReceveUserNotificationResponse:(UNNotificationResponse * _Nonnull)response from:(UIViewController * _Nullable)_ withCompletionHandler:(void (^ _Nonnull)(void))completionHandler __attribute__((warn_unused_result(""))) __attribute__((deprecated("This method is deprecated in favor of didReceveUserNotificationResponse(_:from:withCompletionHandler:).")));
		[Export ("didReceveUserNotificationResponse:from:withCompletionHandler:")]
		bool DidReceveUserNotificationResponse (UNNotificationResponse response, [NullAllowed] UIViewController _, Action completionHandler);

		// @property (copy, nonatomic) SWIFT_DEPRECATED_MSG("Advertising identifier collection is not implemented.") NSUUID * advertisingIdentifier __attribute__((deprecated("Advertising identifier collection is not implemented.")));
		[Export ("advertisingIdentifier", ArgumentSemantic.Copy)]
		NSUUID AdvertisingIdentifier { get; set; }

		// @property (copy, nonatomic) SWIFT_DEPRECATED_MSG("mParticleId has been renamed to mParticleID.") NSString * mParticleId __attribute__((deprecated("mParticleId has been renamed to mParticleID.")));
		[Export ("mParticleId")]
		string MParticleId { get; set; }

		// -(void)removeCustomPersonDataWithKey:(NSString * _Nonnull)key;
		[Export ("removeCustomPersonDataWithKey:")]
		void RemoveCustomPersonDataWithKey (string key);

		// -(void)removeCustomDeviceDataWithKey:(NSString * _Nonnull)key;
		[Export ("removeCustomDeviceDataWithKey:")]
		void RemoveCustomDeviceDataWithKey (string key);

		// -(void)addCustomDeviceDataString:(NSString * _Nonnull)string withKey:(NSString * _Nonnull)key;
		[Export ("addCustomDeviceDataString:withKey:")]
		void AddCustomDeviceDataString (string @string, string key);

		// -(void)addCustomDeviceDataNumber:(NSNumber * _Nonnull)number withKey:(NSString * _Nonnull)key;
		[Export ("addCustomDeviceDataNumber:withKey:")]
		void AddCustomDeviceDataNumber (NSNumber number, string key);

		// -(void)addCustomDeviceDataBool:(BOOL)boolValue withKey:(NSString * _Nonnull)key;
		[Export ("addCustomDeviceDataBool:withKey:")]
		void AddCustomDeviceDataBool (bool boolValue, string key);

		// -(void)addCustomPersonDataString:(NSString * _Nonnull)string withKey:(NSString * _Nonnull)key;
		[Export ("addCustomPersonDataString:withKey:")]
		void AddCustomPersonDataString (string @string, string key);

		// -(void)addCustomPersonDataNumber:(NSNumber * _Nonnull)number withKey:(NSString * _Nonnull)key;
		[Export ("addCustomPersonDataNumber:withKey:")]
		void AddCustomPersonDataNumber (NSNumber number, string key);

		// -(void)addCustomPersonDataBool:(BOOL)boolValue withKey:(NSString * _Nonnull)key;
		[Export ("addCustomPersonDataBool:withKey:")]
		void AddCustomPersonDataBool (bool boolValue, string key);

		// @property (nonatomic) SWIFT_DEPRECATED_MSG("Set style overrides defined in UIKit+Apptentive.swift extensions.") id styleSheet __attribute__((deprecated("Set style overrides defined in UIKit+Apptentive.swift extensions.")));
		[Export ("styleSheet", ArgumentSemantic.Assign)]
		NSObject StyleSheet { get; set; }

		// -(void)checkSDKConfiguration __attribute__((deprecated("This method is not currently implemented and will trigger an assertion failure.")));
		[Export ("checkSDKConfiguration")]
		void CheckSDKConfiguration ();

		// -(void)logInWithToken:(NSString * _Nonnull)token completion:(void (^ _Nonnull)(BOOL, NSError * _Nonnull))completion __attribute__((deprecated("This method is not currently implemented and will trigger an assertion failure.")));
		[Export ("logInWithToken:completion:")]
		void LogInWithToken (string token, Action<bool, NSError> completion);

		// -(void)logOut __attribute__((deprecated("This method is not currently implemented and will trigger an assertion failure.")));
		[Export ("logOut")]
		void LogOut ();

		// @property (copy, nonatomic) SWIFT_DEPRECATED_MSG("Multiple users on the same device is not currently supported.") void (^)(enum ApptentiveAuthenticationFailureReason, NSString * _Nonnull) authenticationFailureCallback __attribute__((deprecated("Multiple users on the same device is not currently supported.")));
		[Export ("authenticationFailureCallback", ArgumentSemantic.Copy)]
		Action<ApptentiveAuthenticationFailureReason, NSString> AuthenticationFailureCallback { get; set; }

		// @property (copy, nonatomic) SWIFT_DEPRECATED_MSG("This feature is no longer supported.") BOOL (^)(NSString * _Nonnull, NSDictionary * _Nullable) preInteractionCallback __attribute__((deprecated("This feature is no longer supported.")));
		[Export ("preInteractionCallback", ArgumentSemantic.Copy)]
		Func<NSString, NSDictionary, bool> PreInteractionCallback { get; set; }

		// -(void)updateToken:(NSString * _Nonnull)token completion:(void (^ _Nullable)(BOOL))completion __attribute__((deprecated("This method is not currently implemented and will trigger an assertion failure.")));
		[Export ("updateToken:completion:")]
		void UpdateToken (string token, [NullAllowed] Action<bool> completion);

		// @property (nonatomic) enum ApptentiveLogLevel logLevel;
		[Export ("logLevel", ArgumentSemantic.Assign)]
		ApptentiveLogLevel LogLevel { get; set; }
	}

	// @interface ApptentiveConfiguration : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13ApptentiveKit23ApptentiveConfiguration")]
	[DisableDefaultCtor]
	interface ApptentiveConfiguration
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull apptentiveKey;
		[Export ("apptentiveKey")]
		string ApptentiveKey { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull apptentiveSignature;
		[Export ("apptentiveSignature")]
		string ApptentiveSignature { get; }

		// @property (nonatomic) enum ApptentiveLogLevel logLevel;
		[Export ("logLevel", ArgumentSemantic.Assign)]
		ApptentiveLogLevel LogLevel { get; set; }

		// @property (nonatomic) BOOL shouldSanitizeLogMessages __attribute__((deprecated("This property is ignored. Log messages will be redacted unless the app has a debugger attached.")));
		[Export ("shouldSanitizeLogMessages")]
		bool ShouldSanitizeLogMessages { get; set; }

		// @property (copy, nonatomic) SWIFT_DEPRECATED_MSG("This property is ignored. Use the designated initializer for 'Apptentive' to set this.") NSURL * baseURL __attribute__((deprecated("This property is ignored. Use the designated initializer for 'Apptentive' to set this.")));
		[Export ("baseURL", ArgumentSemantic.Copy)]
		NSURL BaseURL { get; set; }

		// @property (copy, nonatomic) SWIFT_DEPRECATED_MSG("This property may take effect after the initial app information has been sent to the API.") NSString * distributionName __attribute__((deprecated("This property may take effect after the initial app information has been sent to the API.")));
		[Export ("distributionName")]
		string DistributionName { get; set; }

		// @property (copy, nonatomic) SWIFT_DEPRECATED_MSG("This property may take effect after the initial app information has been sent to the API.") NSString * distributionVersion __attribute__((deprecated("This property may take effect after the initial app information has been sent to the API.")));
		[Export ("distributionVersion")]
		string DistributionVersion { get; set; }

		// @property (copy, nonatomic) SWIFT_DEPRECATED_MSG("This property is ignored. An 'SKStoreReviewController' will be used for all ratings.") NSString * appID __attribute__((deprecated("This property is ignored. An 'SKStoreReviewController' will be used for all ratings.")));
		[Export ("appID")]
		string AppID { get; set; }

		// @property (nonatomic) BOOL showInfoButton __attribute__((deprecated("This property is ignored. The info button no longer exists.")));
		[Export ("showInfoButton")]
		bool ShowInfoButton { get; set; }

		// @property (nonatomic, strong) SWIFT_DEPRECATED_MSG("This feature is currently not implemented.") TermsAndConditions * surveyTermsAndConditions __attribute__((deprecated("This feature is currently not implemented.")));
		[Export ("surveyTermsAndConditions", ArgumentSemantic.Strong)]
		TermsAndConditions SurveyTermsAndConditions { get; set; }

		// +(ApptentiveConfiguration * _Nonnull)configurationWithApptentiveKey:(NSString * _Nonnull)key apptentiveSignature:(NSString * _Nonnull)signature __attribute__((warn_unused_result("")));
		[Static]
		[Export ("configurationWithApptentiveKey:apptentiveSignature:")]
		ApptentiveConfiguration ConfigurationWithApptentiveKey (string key, string signature);
	}

	// @interface ApptentiveNavigationController : UINavigationController
	[BaseType (typeof(UINavigationController), Name = "_TtC13ApptentiveKit30ApptentiveNavigationController")]
	interface ApptentiveNavigationController
	{
		// @property (readonly, nonatomic) UIStatusBarStyle preferredStatusBarStyle;
		[Export ("preferredStatusBarStyle")]
		UIStatusBarStyle PreferredStatusBarStyle { get; }

		// -(instancetype _Nonnull)initWithNavigationBarClass:(Class _Nullable)navigationBarClass toolbarClass:(Class _Nullable)toolbarClass __attribute__((objc_designated_initializer)) __attribute__((availability(ios, introduced=5.0)));
		[iOS (5,0)]
		[Export ("initWithNavigationBarClass:toolbarClass:")]
		[DesignatedInitializer]
		IntPtr Constructor ([NullAllowed] Class navigationBarClass, [NullAllowed] Class toolbarClass);

		// -(instancetype _Nonnull)initWithRootViewController:(UIViewController * _Nonnull)rootViewController __attribute__((objc_designated_initializer));
		[Export ("initWithRootViewController:")]
		[DesignatedInitializer]
		IntPtr Constructor (UIViewController rootViewController);

		// -(instancetype _Nonnull)initWithNibName:(NSString * _Nullable)nibNameOrNil bundle:(NSBundle * _Nullable)nibBundleOrNil __attribute__((objc_designated_initializer));
		[Export ("initWithNibName:bundle:")]
		[DesignatedInitializer]
		IntPtr Constructor ([NullAllowed] string nibNameOrNil, [NullAllowed] NSBundle nibBundleOrNil);

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		[Export ("initWithCoder:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSCoder aDecoder);
	}

	// @interface TermsAndConditions : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13ApptentiveKit18TermsAndConditions")]
	[DisableDefaultCtor]
	interface TermsAndConditions
	{
	}
}
