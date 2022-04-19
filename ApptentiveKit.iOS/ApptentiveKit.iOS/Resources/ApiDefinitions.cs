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

		// -(void)registerWithKey:(NSString * _Nonnull)key signature:(NSString * _Nonnull)signature completion:(void (^ _Nullable)(BOOL))completion;
		[Export("registerWithKey:signature:completion:")]
		void RegisterWithKey(string key, string signature, [NullAllowed] Action<bool> completion);

		// @property (nonatomic, strong) SWIFT_DEPRECATED_MSG("This feature is not implemented.") TermsAndConditions * surveyTermsAndConditions __attribute__((deprecated("This feature is not implemented.")));
		[Export("surveyTermsAndConditions", ArgumentSemantic.Strong)]
		TermsAndConditions SurveyTermsAndConditions { get; set; }

		// -(void)engage:(NSString * _Nonnull)event fromViewController:(UIViewController * _Nullable)viewController;
		[Export("engage:fromViewController:")]
		void Engage(string @event, [NullAllowed] UIViewController viewController);

		// -(void)engage:(NSString * _Nonnull)event fromViewController:(UIViewController * _Nullable)viewController completion:(void (^ _Nullable)(BOOL))completion;
		[Export("engage:fromViewController:completion:")]
		void Engage(string @event, [NullAllowed] UIViewController viewController, [NullAllowed] Action<bool> completion);

		// -(void)engage:(NSString * _Nonnull)event withCustomData:(NSDictionary * _Nullable)customData fromViewController:(UIViewController * _Nullable)viewController;
		[Export("engage:withCustomData:fromViewController:")]
		void Engage(string @event, [NullAllowed] NSDictionary customData, [NullAllowed] UIViewController viewController);

		// -(void)engage:(NSString * _Nonnull)event withCustomData:(NSDictionary * _Nullable)customData fromViewController:(UIViewController * _Nullable)viewController completion:(void (^ _Nullable)(BOOL))completion;
		[Export("engage:withCustomData:fromViewController:completion:")]
		void Engage(string @event, [NullAllowed] NSDictionary customData, [NullAllowed] UIViewController viewController, [NullAllowed] Action<bool> completion);

		// -(void)engage:(NSString * _Nonnull)event withCustomData:(NSDictionary * _Nullable)customData withExtendedData:(NSArray<NSDictionary *> * _Nullable)extendedData fromViewController:(UIViewController * _Nullable)viewController __attribute__((deprecated("Event extended data are no longer supported. Event will be engaged without extended data.")));
		[Export("engage:withCustomData:withExtendedData:fromViewController:")]
		void Engage(string @event, [NullAllowed] NSDictionary customData, [NullAllowed] NSDictionary[] extendedData, [NullAllowed] UIViewController viewController);

		// -(void)engage:(NSString * _Nonnull)event withCustomData:(NSDictionary * _Nullable)customData withExtendedData:(NSArray<NSDictionary *> * _Nullable)extendedData fromViewController:(UIViewController * _Nullable)viewController completion:(void (^ _Nullable)(BOOL))completion __attribute__((deprecated("Event extended data are no longer supported. Event will be engaged without extended data.")));
		[Export("engage:withCustomData:withExtendedData:fromViewController:completion:")]
		void Engage(string @event, [NullAllowed] NSDictionary customData, [NullAllowed] NSDictionary[] extendedData, [NullAllowed] UIViewController viewController, [NullAllowed] Action<bool> completion);

		// -(void)queryCanShowInteractionForEvent:(NSString * _Nonnull)event completion:(void (^ _Nonnull)(BOOL))completion;
		[Export("queryCanShowInteractionForEvent:completion:")]
		void QueryCanShowInteractionForEvent(string @event, Action<bool> completion);

		// -(void)presentMessageCenterFromViewController:(UIViewController * _Nullable)viewController completion:(void (^ _Nullable)(BOOL))completion;
		[Export("presentMessageCenterFromViewController:completion:")]
		void PresentMessageCenterFromViewController([NullAllowed] UIViewController viewController, [NullAllowed] Action<bool> completion);

		// -(void)presentMessageCenterFromViewController:(UIViewController * _Nullable)viewController withCustomData:(NSDictionary * _Nullable)customData;
		[Export("presentMessageCenterFromViewController:withCustomData:")]
		void PresentMessageCenterFromViewController([NullAllowed] UIViewController viewController, [NullAllowed] NSDictionary customData);

		// -(void)presentMessageCenterFromViewController:(UIViewController * _Nullable)viewController withCustomData:(NSDictionary * _Nullable)customData completion:(void (^ _Nullable)(BOOL))completion;
		[Export("presentMessageCenterFromViewController:withCustomData:completion:")]
		void PresentMessageCenterFromViewController([NullAllowed] UIViewController viewController, [NullAllowed] NSDictionary customData, [NullAllowed] Action<bool> completion);

		// -(void)dismissMessageCenterWithAnimated:(BOOL)animated completion:(void (^ _Nullable)(void))completion __attribute__((deprecated("This feature is not implemented and this method will always result in false.")));
		[Export("dismissMessageCenterWithAnimated:completion:")]
		void DismissMessageCenterWithAnimated(bool animated, [NullAllowed] Action completion);

		// -(void)setRemoteNotifcationDeviceToken:(NSData * _Nonnull)tokenData;
		[Export("setRemoteNotifcationDeviceToken:")]
		void SetRemoteNotifcationDeviceToken(NSData tokenData);

		// -(BOOL)didReceiveRemoteNotification:(NSDictionary * _Nonnull)userInfo fetchCompletionHandler:(void (^ _Nonnull)(UIBackgroundFetchResult))completionHandler __attribute__((warn_unused_result("")));
		[Export("didReceiveRemoteNotification:fetchCompletionHandler:")]
		bool DidReceiveRemoteNotification(NSDictionary userInfo, Action<UIBackgroundFetchResult> completionHandler);

		// -(BOOL)didReceveUserNotificationResponse:(UNNotificationResponse * _Nonnull)response withCompletionHandler:(void (^ _Nonnull)(void))completionHandler __attribute__((warn_unused_result("")));
		[Export("didReceveUserNotificationResponse:withCompletionHandler:")]
		bool DidReceveUserNotificationResponse(UNNotificationResponse response, Action completionHandler);

		// -(BOOL)willPresent:(UNNotification * _Nonnull)notification withCompletionHandler:(void (^ _Nonnull)(UNNotificationPresentationOptions))completionHandler __attribute__((warn_unused_result("")));
		[Export("willPresent:withCompletionHandler:")]
		bool WillPresent(UNNotification notification, Action<UNNotificationPresentationOptions> completionHandler);

		// -(void)userNotificationCenter:(UNUserNotificationCenter * _Nonnull)center willPresentNotification:(UNNotification * _Nonnull)notification withCompletionHandler:(void (^ _Nonnull)(UNNotificationPresentationOptions))completionHandler;
		[Export("userNotificationCenter:willPresentNotification:withCompletionHandler:")]
		void UserNotificationCenter(UNUserNotificationCenter center, UNNotification notification, Action<UNNotificationPresentationOptions> completionHandler);

		// -(void)userNotificationCenter:(UNUserNotificationCenter * _Nonnull)center didReceiveNotificationResponse:(UNNotificationResponse * _Nonnull)response withCompletionHandler:(void (^ _Nonnull)(void))completionHandler;
		[Export("userNotificationCenter:didReceiveNotificationResponse:withCompletionHandler:")]
		void UserNotificationCenter(UNUserNotificationCenter center, UNNotificationResponse response, Action completionHandler);

		// -(void)removeCustomPersonDataWithKey:(NSString * _Nonnull)key;
		[Export("removeCustomPersonDataWithKey:")]
		void RemoveCustomPersonDataWithKey(string key);

		// -(void)removeCustomDeviceDataWithKey:(NSString * _Nonnull)key;
		[Export("removeCustomDeviceDataWithKey:")]
		void RemoveCustomDeviceDataWithKey(string key);

		// -(void)addCustomDeviceDataString:(NSString * _Nonnull)string withKey:(NSString * _Nonnull)key;
		[Export("addCustomDeviceDataString:withKey:")]
		void AddCustomDeviceDataString(string @string, string key);

		// -(void)addCustomDeviceDataNumber:(NSNumber * _Nonnull)number withKey:(NSString * _Nonnull)key;
		[Export("addCustomDeviceDataNumber:withKey:")]
		void AddCustomDeviceDataNumber(NSNumber number, string key);

		// -(void)addCustomDeviceDataBool:(BOOL)boolValue withKey:(NSString * _Nonnull)key;
		[Export("addCustomDeviceDataBool:withKey:")]
		void AddCustomDeviceDataBool(bool boolValue, string key);

		// -(void)addCustomPersonDataString:(NSString * _Nonnull)string withKey:(NSString * _Nonnull)key;
		[Export("addCustomPersonDataString:withKey:")]
		void AddCustomPersonDataString(string @string, string key);

		// -(void)addCustomPersonDataNumber:(NSNumber * _Nonnull)number withKey:(NSString * _Nonnull)key;
		[Export("addCustomPersonDataNumber:withKey:")]
		void AddCustomPersonDataNumber(NSNumber number, string key);

		// -(void)addCustomPersonDataBool:(BOOL)boolValue withKey:(NSString * _Nonnull)key;
		[Export("addCustomPersonDataBool:withKey:")]
		void AddCustomPersonDataBool(bool boolValue, string key);

		// @property (nonatomic) enum ApptentiveLogLevel logLevel;
		[Export("logLevel", ArgumentSemantic.Assign)]
		ApptentiveLogLevel LogLevel { get; set; }
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
	}

	// @interface TermsAndConditions : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13ApptentiveKit18TermsAndConditions")]
	[DisableDefaultCtor]
	interface TermsAndConditions
	{
	}
}
