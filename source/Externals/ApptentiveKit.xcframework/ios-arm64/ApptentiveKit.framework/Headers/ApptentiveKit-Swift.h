// Generated by Apple Swift version 5.6 (swiftlang-5.6.0.323.62 clang-1316.0.20.8)
#ifndef APPTENTIVEKIT_SWIFT_H
#define APPTENTIVEKIT_SWIFT_H
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Wgcc-compat"

#if !defined(__has_include)
# define __has_include(x) 0
#endif
#if !defined(__has_attribute)
# define __has_attribute(x) 0
#endif
#if !defined(__has_feature)
# define __has_feature(x) 0
#endif
#if !defined(__has_warning)
# define __has_warning(x) 0
#endif

#if __has_include(<swift/objc-prologue.h>)
# include <swift/objc-prologue.h>
#endif

#pragma clang diagnostic ignored "-Wauto-import"
#include <Foundation/Foundation.h>
#include <stdint.h>
#include <stddef.h>
#include <stdbool.h>

#if !defined(SWIFT_TYPEDEFS)
# define SWIFT_TYPEDEFS 1
# if __has_include(<uchar.h>)
#  include <uchar.h>
# elif !defined(__cplusplus)
typedef uint_least16_t char16_t;
typedef uint_least32_t char32_t;
# endif
typedef float swift_float2  __attribute__((__ext_vector_type__(2)));
typedef float swift_float3  __attribute__((__ext_vector_type__(3)));
typedef float swift_float4  __attribute__((__ext_vector_type__(4)));
typedef double swift_double2  __attribute__((__ext_vector_type__(2)));
typedef double swift_double3  __attribute__((__ext_vector_type__(3)));
typedef double swift_double4  __attribute__((__ext_vector_type__(4)));
typedef int swift_int2  __attribute__((__ext_vector_type__(2)));
typedef int swift_int3  __attribute__((__ext_vector_type__(3)));
typedef int swift_int4  __attribute__((__ext_vector_type__(4)));
typedef unsigned int swift_uint2  __attribute__((__ext_vector_type__(2)));
typedef unsigned int swift_uint3  __attribute__((__ext_vector_type__(3)));
typedef unsigned int swift_uint4  __attribute__((__ext_vector_type__(4)));
#endif

#if !defined(SWIFT_PASTE)
# define SWIFT_PASTE_HELPER(x, y) x##y
# define SWIFT_PASTE(x, y) SWIFT_PASTE_HELPER(x, y)
#endif
#if !defined(SWIFT_METATYPE)
# define SWIFT_METATYPE(X) Class
#endif
#if !defined(SWIFT_CLASS_PROPERTY)
# if __has_feature(objc_class_property)
#  define SWIFT_CLASS_PROPERTY(...) __VA_ARGS__
# else
#  define SWIFT_CLASS_PROPERTY(...)
# endif
#endif

#if __has_attribute(objc_runtime_name)
# define SWIFT_RUNTIME_NAME(X) __attribute__((objc_runtime_name(X)))
#else
# define SWIFT_RUNTIME_NAME(X)
#endif
#if __has_attribute(swift_name)
# define SWIFT_COMPILE_NAME(X) __attribute__((swift_name(X)))
#else
# define SWIFT_COMPILE_NAME(X)
#endif
#if __has_attribute(objc_method_family)
# define SWIFT_METHOD_FAMILY(X) __attribute__((objc_method_family(X)))
#else
# define SWIFT_METHOD_FAMILY(X)
#endif
#if __has_attribute(noescape)
# define SWIFT_NOESCAPE __attribute__((noescape))
#else
# define SWIFT_NOESCAPE
#endif
#if __has_attribute(ns_consumed)
# define SWIFT_RELEASES_ARGUMENT __attribute__((ns_consumed))
#else
# define SWIFT_RELEASES_ARGUMENT
#endif
#if __has_attribute(warn_unused_result)
# define SWIFT_WARN_UNUSED_RESULT __attribute__((warn_unused_result))
#else
# define SWIFT_WARN_UNUSED_RESULT
#endif
#if __has_attribute(noreturn)
# define SWIFT_NORETURN __attribute__((noreturn))
#else
# define SWIFT_NORETURN
#endif
#if !defined(SWIFT_CLASS_EXTRA)
# define SWIFT_CLASS_EXTRA
#endif
#if !defined(SWIFT_PROTOCOL_EXTRA)
# define SWIFT_PROTOCOL_EXTRA
#endif
#if !defined(SWIFT_ENUM_EXTRA)
# define SWIFT_ENUM_EXTRA
#endif
#if !defined(SWIFT_CLASS)
# if __has_attribute(objc_subclassing_restricted)
#  define SWIFT_CLASS(SWIFT_NAME) SWIFT_RUNTIME_NAME(SWIFT_NAME) __attribute__((objc_subclassing_restricted)) SWIFT_CLASS_EXTRA
#  define SWIFT_CLASS_NAMED(SWIFT_NAME) __attribute__((objc_subclassing_restricted)) SWIFT_COMPILE_NAME(SWIFT_NAME) SWIFT_CLASS_EXTRA
# else
#  define SWIFT_CLASS(SWIFT_NAME) SWIFT_RUNTIME_NAME(SWIFT_NAME) SWIFT_CLASS_EXTRA
#  define SWIFT_CLASS_NAMED(SWIFT_NAME) SWIFT_COMPILE_NAME(SWIFT_NAME) SWIFT_CLASS_EXTRA
# endif
#endif
#if !defined(SWIFT_RESILIENT_CLASS)
# if __has_attribute(objc_class_stub)
#  define SWIFT_RESILIENT_CLASS(SWIFT_NAME) SWIFT_CLASS(SWIFT_NAME) __attribute__((objc_class_stub))
#  define SWIFT_RESILIENT_CLASS_NAMED(SWIFT_NAME) __attribute__((objc_class_stub)) SWIFT_CLASS_NAMED(SWIFT_NAME)
# else
#  define SWIFT_RESILIENT_CLASS(SWIFT_NAME) SWIFT_CLASS(SWIFT_NAME)
#  define SWIFT_RESILIENT_CLASS_NAMED(SWIFT_NAME) SWIFT_CLASS_NAMED(SWIFT_NAME)
# endif
#endif

#if !defined(SWIFT_PROTOCOL)
# define SWIFT_PROTOCOL(SWIFT_NAME) SWIFT_RUNTIME_NAME(SWIFT_NAME) SWIFT_PROTOCOL_EXTRA
# define SWIFT_PROTOCOL_NAMED(SWIFT_NAME) SWIFT_COMPILE_NAME(SWIFT_NAME) SWIFT_PROTOCOL_EXTRA
#endif

#if !defined(SWIFT_EXTENSION)
# define SWIFT_EXTENSION(M) SWIFT_PASTE(M##_Swift_, __LINE__)
#endif

#if !defined(OBJC_DESIGNATED_INITIALIZER)
# if __has_attribute(objc_designated_initializer)
#  define OBJC_DESIGNATED_INITIALIZER __attribute__((objc_designated_initializer))
# else
#  define OBJC_DESIGNATED_INITIALIZER
# endif
#endif
#if !defined(SWIFT_ENUM_ATTR)
# if defined(__has_attribute) && __has_attribute(enum_extensibility)
#  define SWIFT_ENUM_ATTR(_extensibility) __attribute__((enum_extensibility(_extensibility)))
# else
#  define SWIFT_ENUM_ATTR(_extensibility)
# endif
#endif
#if !defined(SWIFT_ENUM)
# define SWIFT_ENUM(_type, _name, _extensibility) enum _name : _type _name; enum SWIFT_ENUM_ATTR(_extensibility) SWIFT_ENUM_EXTRA _name : _type
# if __has_feature(generalized_swift_name)
#  define SWIFT_ENUM_NAMED(_type, _name, SWIFT_NAME, _extensibility) enum _name : _type _name SWIFT_COMPILE_NAME(SWIFT_NAME); enum SWIFT_COMPILE_NAME(SWIFT_NAME) SWIFT_ENUM_ATTR(_extensibility) SWIFT_ENUM_EXTRA _name : _type
# else
#  define SWIFT_ENUM_NAMED(_type, _name, SWIFT_NAME, _extensibility) SWIFT_ENUM(_type, _name, _extensibility)
# endif
#endif
#if !defined(SWIFT_UNAVAILABLE)
# define SWIFT_UNAVAILABLE __attribute__((unavailable))
#endif
#if !defined(SWIFT_UNAVAILABLE_MSG)
# define SWIFT_UNAVAILABLE_MSG(msg) __attribute__((unavailable(msg)))
#endif
#if !defined(SWIFT_AVAILABILITY)
# define SWIFT_AVAILABILITY(plat, ...) __attribute__((availability(plat, __VA_ARGS__)))
#endif
#if !defined(SWIFT_WEAK_IMPORT)
# define SWIFT_WEAK_IMPORT __attribute__((weak_import))
#endif
#if !defined(SWIFT_DEPRECATED)
# define SWIFT_DEPRECATED __attribute__((deprecated))
#endif
#if !defined(SWIFT_DEPRECATED_MSG)
# define SWIFT_DEPRECATED_MSG(...) __attribute__((deprecated(__VA_ARGS__)))
#endif
#if __has_feature(attribute_diagnose_if_objc)
# define SWIFT_DEPRECATED_OBJC(Msg) __attribute__((diagnose_if(1, Msg, "warning")))
#else
# define SWIFT_DEPRECATED_OBJC(Msg) SWIFT_DEPRECATED_MSG(Msg)
#endif
#if !defined(IBSegueAction)
# define IBSegueAction
#endif
#if !defined(SWIFT_EXTERN)
# if defined(__cplusplus)
#  define SWIFT_EXTERN extern "C"
# else
#  define SWIFT_EXTERN extern
# endif
#endif
#if __has_feature(modules)
#if __has_warning("-Watimport-in-framework-header")
#pragma clang diagnostic ignored "-Watimport-in-framework-header"
#endif
@import Foundation;
@import ObjectiveC;
@import UIKit;
@import UserNotifications;
#endif

#pragma clang diagnostic ignored "-Wproperty-attribute-mismatch"
#pragma clang diagnostic ignored "-Wduplicate-method-arg"
#if __has_warning("-Wpragma-clang-attribute")
# pragma clang diagnostic ignored "-Wpragma-clang-attribute"
#endif
#pragma clang diagnostic ignored "-Wunknown-pragmas"
#pragma clang diagnostic ignored "-Wnullability"

#if __has_attribute(external_source_symbol)
# pragma push_macro("any")
# undef any
# pragma clang attribute push(__attribute__((external_source_symbol(language="Swift", defined_in="ApptentiveKit",generated_declaration))), apply_to=any(function,enum,objc_interface,objc_category,objc_protocol))
# pragma pop_macro("any")
#endif

@class NSString;
@class UIImage;
@class NSData;

/// The main interface to the Apptentive SDK.
SWIFT_CLASS("_TtC13ApptentiveKit10Apptentive")
@interface Apptentive : NSObject
/// The shared instance of the Apptentive SDK.
/// This object is created lazily upon access.
SWIFT_CLASS_PROPERTY(@property (nonatomic, class, readonly, strong) Apptentive * _Nonnull shared;)
+ (Apptentive * _Nonnull)shared SWIFT_WARN_UNUSED_RESULT;
/// The name of the person using the app, if available.
@property (nonatomic, copy) NSString * _Nullable personName;
/// The email address of the person using the app, if available.
@property (nonatomic, copy) NSString * _Nullable personEmailAddress;
/// The string used by the mParticle integration to identify the current user.
@property (nonatomic, copy) NSString * _Nullable mParticleID;
/// The number of unread messages in message center.
@property (nonatomic) NSInteger unreadMessageCount;
/// The name of the distribution method for this SDK instance (not for app use).
/// This property is used to track the relative popularity of various methods of
/// integrating this SDK, for example “React Native” or “CocoaPods”.
/// This property is not intended to be set by apps using the SDK, but
/// should be set by projects that re-package the SDK for distribution
/// as part of e.g. a cross-platform app framework.
@property (nonatomic, copy) NSString * _Nullable distributionName;
/// The version of the distribution for this SDK instance (not for app use).
/// This property is used to track the version of any projects
/// that re-package the SDK as part of e.g. a cross-platform app-
/// development framework.
/// This property is not intended to be set by apps using the SDK.
@property (nonatomic, copy) NSString * _Nullable distributionVersion;
/// Sends the specified text as a hidden message to the app’s dashboard.
/// \param text The text to send in the body of the message.
///
- (void)sendAttachmentText:(NSString * _Nonnull)text;
/// Sends the specified image (encoded as a JPEG at 95% quality) attached to a hidden message to the app’s dashboard.
/// \param image The image to encode and send.
///
- (void)sendAttachmentImage:(UIImage * _Nonnull)image;
/// Sends the specified data attached to a hidden message to the app’s dashboard.
/// \param fileData The contents of the file.
///
/// \param mediaType The media type for the file.
///
- (void)sendAttachmentData:(NSData * _Nonnull)fileData mimeType:(NSString * _Nonnull)mediaType;
- (nonnull instancetype)init SWIFT_UNAVAILABLE;
+ (nonnull instancetype)new SWIFT_UNAVAILABLE_MSG("-init is unavailable");
@end



@class UNNotificationResponse;
@class UNNotification;
@class UNUserNotificationCenter;

@interface Apptentive (SWIFT_EXTENSION(ApptentiveKit)) <UNUserNotificationCenterDelegate>
/// Sets the remote notification device token to the specified value.
/// \param tokenData The remote notification device token passed into <code>application(_:didRegisterForRemoteNotificationsWithDeviceToken:)</code>.
///
- (void)setRemoteNotificationDeviceToken:(NSData * _Nonnull)tokenData;
- (void)setRemoteNotifcationDeviceToken:(NSData * _Nonnull)tokenData SWIFT_DEPRECATED_MSG("Use the (correctly-spelled) 'setRemoteNotificationDeviceToken(_:)' method instead.");
/// Should be called in response to the application delegate receiving a remote notification.
/// note:
/// If the return value is <code>false</code>, the caller is responsible for calling the fetch completion handler.
/// \param userInfo The <code>userInfo</code> parameter passed to <code>application(_:didReceiveRemoteNotification:)</code>.
///
/// \param completionHandler The <code>fetchCompletionHandler</code> parameter passed to <code>application(_:didReceiveRemoteNotification:)</code>.
///
///
/// returns:
/// <code>true</code> if the notification was handled by the Apptentive SDK, <code>false</code> if not.
- (BOOL)didReceiveRemoteNotification:(NSDictionary * _Nonnull)userInfo fetchCompletionHandler:(void (^ _Nonnull)(UIBackgroundFetchResult))completionHandler SWIFT_WARN_UNUSED_RESULT;
/// Called when a user responds to a user notification.
/// Apps may set their <code>Apptentive</code> instance as the delegate of the current <code>UNUserNotificationCenter</code>.
/// If another object assumes this role, it should call this method in <code>userNotificationCenter(_:didReceive:withCompletionHandler:)</code>.
/// note:
/// If this method returns <code>false</code>, the caller is responsible for calling the completion handler.
/// \param response The <code>response</code> parameter passed to <code>userNotificationCenter(_:didReceive:withCompletionHandler:)</code>.
///
/// \param completionHandler The <code>completionHandler</code> parameter passed to <code>userNotificationCenter(_:didReceive:withCompletionHandler:)</code>.
///
///
/// returns:
/// <code>true</code> if the notification was handled by the Apptentive SDK, <code>false</code> if not.
- (BOOL)didReceveUserNotificationResponse:(UNNotificationResponse * _Nonnull)response withCompletionHandler:(void (^ _Nonnull)(void))completionHandler SWIFT_WARN_UNUSED_RESULT;
/// Called when a user notification will be displayed.
/// Apps may set their <code>Apptentive</code> instance as the delegate of the current <code>UNUserNotificationCenter</code>.
/// If another object assumes this role, it should call this method in <code>userNotificationCenter(_:willPresent:notification:completionHandler:)</code>.
/// note:
/// If this method returns <code>false</code>, the caller is responsible for calling the completion handler.
/// \param notification The <code>response</code> parameter passed to <code>userNotificationCenter(_:willPresent:notification:withCompletionHandler:)</code>.
///
/// \param completionHandler The <code>completionHandler</code> parameter passed to <code>userNotificationCenter(_:willPresent:notification:withCompletionHandler:)</code>.
///
///
/// returns:
/// <code>true</code> if the notification was handled by the Apptentive SDK, <code>false</code> if not.
- (BOOL)willPresent:(UNNotification * _Nonnull)notification withCompletionHandler:(void (^ _Nonnull)(UNNotificationPresentationOptions))completionHandler SWIFT_WARN_UNUSED_RESULT;
/// Passes the arguments received by the delegate method to the appropriate Apptentive method.
/// \param center The user notification center.
///
/// \param notification The user notification.
///
/// \param completionHandler The completion handler to call.
///
- (void)userNotificationCenter:(UNUserNotificationCenter * _Nonnull)center willPresentNotification:(UNNotification * _Nonnull)notification withCompletionHandler:(void (^ _Nonnull)(UNNotificationPresentationOptions))completionHandler;
/// Passes the arguments received by the delegate method to the appropriate Apptentive method.
/// \param center The user notification center.
///
/// \param response The user notification response.
///
/// \param completionHandler The completion handler to call.
///
- (void)userNotificationCenter:(UNUserNotificationCenter * _Nonnull)center didReceiveNotificationResponse:(UNNotificationResponse * _Nonnull)response withCompletionHandler:(void (^ _Nonnull)(void))completionHandler;
@end


@class ApptentiveConfiguration;
@class TermsAndConditions;
@class UIViewController;
@class NSDate;
@class NSNumber;
@class UIView;
enum ApptentivePushProvider : NSInteger;
@class NSUUID;
enum ApptentiveAuthenticationFailureReason : NSInteger;
enum ApptentiveLogLevel : NSUInteger;

@interface Apptentive (SWIFT_EXTENSION(ApptentiveKit))
+ (void)registerWithConfiguration:(ApptentiveConfiguration * _Nonnull)configuration SWIFT_DEPRECATED_MSG("Use the 'register(with:completion:)' method on the 'shared' instance instead.");
- (void)registerWithConfiguration:(ApptentiveConfiguration * _Nonnull)configuration completion:(void (^ _Nullable)(BOOL))completion;
+ (Apptentive * _Nonnull)sharedConnection SWIFT_WARN_UNUSED_RESULT SWIFT_DEPRECATED_MSG("Use the 'shared' static property instead.");
@property (nonatomic, copy) NSString * _Nullable appID SWIFT_DEPRECATED_MSG("This property is ignored. SKStoreReviewController will be used for all ratings.");
@property (nonatomic) BOOL showInfoButton SWIFT_DEPRECATED_MSG("This property is ignored. The info button no longer exists.");
@property (nonatomic, strong) TermsAndConditions * _Nullable surveyTermsAndConditions SWIFT_DEPRECATED_MSG("This feature is not implemented.");
@property (nonatomic, readonly, copy) NSString * _Nonnull apptentiveKey SWIFT_DEPRECATED_MSG("This property is not available for reading.");
@property (nonatomic, readonly, copy) NSString * _Nonnull apptentiveSignature SWIFT_DEPRECATED_MSG("This property is not available for reading.");
- (void)engage:(NSString * _Nonnull)event fromViewController:(UIViewController * _Nullable)viewController;
- (void)engage:(NSString * _Nonnull)event fromViewController:(UIViewController * _Nullable)viewController completion:(void (^ _Nullable)(BOOL))completion;
- (void)engage:(NSString * _Nonnull)event withCustomData:(NSDictionary * _Nullable)customData fromViewController:(UIViewController * _Nullable)viewController;
- (void)engage:(NSString * _Nonnull)event withCustomData:(NSDictionary * _Nullable)customData fromViewController:(UIViewController * _Nullable)viewController completion:(void (^ _Nullable)(BOOL))completion;
- (void)engage:(NSString * _Nonnull)event withCustomData:(NSDictionary * _Nullable)customData withExtendedData:(NSArray<NSDictionary *> * _Nullable)extendedData fromViewController:(UIViewController * _Nullable)viewController SWIFT_DEPRECATED_MSG("Event extended data are no longer supported. Event will be engaged without extended data.");
- (void)engage:(NSString * _Nonnull)event withCustomData:(NSDictionary * _Nullable)customData withExtendedData:(NSArray<NSDictionary *> * _Nullable)extendedData fromViewController:(UIViewController * _Nullable)viewController completion:(void (^ _Nullable)(BOOL))completion SWIFT_DEPRECATED_MSG("Event extended data are no longer supported. Event will be engaged without extended data.");
- (void)queryCanShowInteractionForEvent:(NSString * _Nonnull)event completion:(void (^ _Nonnull)(BOOL))completion;
+ (NSDictionary * _Nonnull)extendedDataDate:(NSDate * _Nonnull)date SWIFT_WARN_UNUSED_RESULT SWIFT_DEPRECATED_MSG("Extended event data are no longer supported.");
+ (NSDictionary * _Nonnull)extendedDataLocationForLatitude:(double)latitude longitude:(double)longitude SWIFT_WARN_UNUSED_RESULT SWIFT_DEPRECATED_MSG("Extended event data are no longer supported.");
+ (NSDictionary * _Nonnull)extendedDataCommerceWithTransactionID:(NSString * _Nullable)transactionID affiliation:(NSString * _Nullable)affiliation revenue:(NSNumber * _Nullable)revenue shipping:(NSNumber * _Nullable)shipping tax:(NSNumber * _Nullable)tax currency:(NSString * _Nullable)currency commerceItems:(NSArray<NSDictionary *> * _Nullable)commerceItems SWIFT_WARN_UNUSED_RESULT SWIFT_DEPRECATED_MSG("Extended event data are no longer supported.");
+ (NSDictionary * _Nonnull)extendedDataCommerceItemWithItemID:(NSString * _Nullable)itemID name:(NSString * _Nullable)name category:(NSString * _Nullable)category price:(NSNumber * _Nullable)price quantity:(NSNumber * _Nullable)quantity currency:(NSString * _Nullable)currency SWIFT_WARN_UNUSED_RESULT SWIFT_DEPRECATED_MSG("Extended event data are no longer supported.");
- (void)queryCanShowMessageCenterWithCompletion:(void (^ _Nonnull)(BOOL))completion SWIFT_DEPRECATED_MSG("This feature is not implemented and will always result in false.");
- (void)presentMessageCenterFromViewController:(UIViewController * _Nullable)viewController completion:(void (^ _Nullable)(BOOL))completion;
- (void)presentMessageCenterFromViewController:(UIViewController * _Nullable)viewController withCustomData:(NSDictionary * _Nullable)customData;
- (void)presentMessageCenterFromViewController:(UIViewController * _Nullable)viewController withCustomData:(NSDictionary * _Nullable)customData completion:(void (^ _Nullable)(BOOL))completion;
- (void)dismissMessageCenterWithAnimated:(BOOL)animated completion:(void (^ _Nullable)(void))completion SWIFT_DEPRECATED_MSG("This feature is not implemented and this method will always result in false.");
- (UIView * _Nonnull)unreadMessageCountAccessoryViewWithApptentiveHeart:(BOOL)apptentiveHeart SWIFT_WARN_UNUSED_RESULT SWIFT_DEPRECATED_MSG("This feature is not implemented and this property will return an empty view.");
- (void)openAppStore SWIFT_DEPRECATED_MSG("This method is no longer implemented and will trigger an assertion failure.");
- (void)setPushProvider:(enum ApptentivePushProvider)pushProvider deviceToken:(NSData * _Nonnull)deviceToken SWIFT_DEPRECATED_MSG("Use the 'setRemoteNotificationToken()' method instead.");
- (BOOL)didReceveUserNotificationResponse:(UNNotificationResponse * _Nonnull)response from:(UIViewController * _Nullable)_ withCompletionHandler:(void (^ _Nonnull)(void))completionHandler SWIFT_WARN_UNUSED_RESULT SWIFT_DEPRECATED_MSG("This method is deprecated in favor of didReceveUserNotificationResponse(_:from:withCompletionHandler:).");
@property (nonatomic, copy) NSUUID * _Nullable advertisingIdentifier SWIFT_DEPRECATED_MSG("Advertising identifier collection is not implemented.");
@property (nonatomic, copy) NSString * _Nullable mParticleId SWIFT_DEPRECATED_MSG("mParticleId has been renamed to mParticleID.");
- (void)removeCustomPersonDataWithKey:(NSString * _Nonnull)key;
- (void)removeCustomDeviceDataWithKey:(NSString * _Nonnull)key;
- (void)addCustomDeviceDataString:(NSString * _Nonnull)string withKey:(NSString * _Nonnull)key;
- (void)addCustomDeviceDataNumber:(NSNumber * _Nonnull)number withKey:(NSString * _Nonnull)key;
- (void)addCustomDeviceDataBool:(BOOL)boolValue withKey:(NSString * _Nonnull)key;
- (void)addCustomPersonDataString:(NSString * _Nonnull)string withKey:(NSString * _Nonnull)key;
- (void)addCustomPersonDataNumber:(NSNumber * _Nonnull)number withKey:(NSString * _Nonnull)key;
- (void)addCustomPersonDataBool:(BOOL)boolValue withKey:(NSString * _Nonnull)key;
@property (nonatomic) id _Nullable styleSheet SWIFT_DEPRECATED_MSG("Set style overrides defined in UIKit+Apptentive.swift extensions.");
- (void)checkSDKConfiguration SWIFT_DEPRECATED_MSG("This method is not currently implemented and will trigger an assertion failure.");
- (void)logInWithToken:(NSString * _Nonnull)token completion:(void (^ _Nonnull)(BOOL, NSError * _Nonnull))completion SWIFT_DEPRECATED_MSG("This method is not currently implemented and will trigger an assertion failure.");
- (void)logOut SWIFT_DEPRECATED_MSG("This method is not currently implemented and will trigger an assertion failure.");
@property (nonatomic, copy) void (^ _Nullable authenticationFailureCallback)(enum ApptentiveAuthenticationFailureReason, NSString * _Nonnull) SWIFT_DEPRECATED_MSG("Multiple users on the same device is not currently supported.");
@property (nonatomic, copy) BOOL (^ _Nullable preInteractionCallback)(NSString * _Nonnull, NSDictionary * _Nullable) SWIFT_DEPRECATED_MSG("This feature is no longer supported.");
- (void)updateToken:(NSString * _Nonnull)token completion:(void (^ _Nullable)(BOOL))completion SWIFT_DEPRECATED_MSG("This method is not currently implemented and will trigger an assertion failure.");
@property (nonatomic) enum ApptentiveLogLevel logLevel;
@end

typedef SWIFT_ENUM(NSInteger, ApptentiveAuthenticationFailureReason, open) {
/// An unknown authentication failure.
  ApptentiveAuthenticationFailureReasonUnknown = 0,
/// An invalid JWT algorithm was used.
  ApptentiveAuthenticationFailureReasonInvalidAlgorithm = 1,
/// A malformed JWT was encountered.
  ApptentiveAuthenticationFailureReasonMalformedToken = 2,
/// An invalid JWT was encountered.
  ApptentiveAuthenticationFailureReasonInvalidToken = 3,
/// A required subclaim was missing.
  ApptentiveAuthenticationFailureReasonMissingSubClaim = 4,
/// A subclaim didn’t match the logged-in session.
  ApptentiveAuthenticationFailureReasonMismatchedSubClaim = 5,
/// An invalid subclaim was encountered.
  ApptentiveAuthenticationFailureReasonInvalidSubClaim = 6,
/// The JWT expired.
  ApptentiveAuthenticationFailureReasonExpiredToken = 7,
/// The JWT was revoked.
  ApptentiveAuthenticationFailureReasonRevokedToken = 8,
/// The Apptentive App Key was missing.
  ApptentiveAuthenticationFailureReasonMissingAppKey = 9,
/// The Apptentive App Signature was missing
  ApptentiveAuthenticationFailureReasonMissingAppSignature = 10,
/// In invalid combination of an Apptentive App Key and an Apptentive App Signature was found.
  ApptentiveAuthenticationFailureReasonInvalidKeySignaturePair = 11,
};

@class NSURL;

SWIFT_CLASS("_TtC13ApptentiveKit23ApptentiveConfiguration")
@interface ApptentiveConfiguration : NSObject
/// The Apptentive App Key, obtained from your Apptentive dashboard.
@property (nonatomic, readonly, copy) NSString * _Nonnull apptentiveKey;
/// The Apptentive App Signature, obtained from your Apptentive dashboard.
@property (nonatomic, readonly, copy) NSString * _Nonnull apptentiveSignature;
/// The granularity of log messages to show.
@property (nonatomic) enum ApptentiveLogLevel logLevel;
/// If set, redacts potentially-sensitive information such as user data and credentials from logging.
@property (nonatomic) BOOL shouldSanitizeLogMessages;
/// The server URL to use for API calls. Should only be used for testing.
@property (nonatomic, copy) NSURL * _Nullable baseURL SWIFT_DEPRECATED_MSG("This property is ignored. Use the designated initializer for 'Apptentive' to set this.");
/// The name of the distribution that includes the Apptentive SDK. For example “Cordova”.
@property (nonatomic, copy) NSString * _Nullable distributionName;
/// The version of the distribution that includes the Apptentive SDK.
@property (nonatomic, copy) NSString * _Nullable distributionVersion;
/// The iTunes store app ID of the app (used for Apptentive rating prompt).
@property (nonatomic, copy) NSString * _Nullable appID SWIFT_DEPRECATED_MSG("This property is ignored. An 'SKStoreReviewController' will be used for all ratings.");
/// If set, shows a button in Surveys and Message Center that presents information about Apptentive including a link to our privacy policy.
@property (nonatomic) BOOL showInfoButton SWIFT_DEPRECATED_MSG("This property is ignored. The info button no longer exists.");
/// If set, will show a link to terms and conditions in the bottom bar in Surveys.
@property (nonatomic, strong) TermsAndConditions * _Nullable surveyTermsAndConditions SWIFT_DEPRECATED_MSG("This property is ignored. Configure survey terms and conditions in the Apptentive Dashboard.");
- (nullable instancetype)initWithApptentiveKey:(NSString * _Nonnull)apptentiveKey apptentiveSignature:(NSString * _Nonnull)apptentiveSignature OBJC_DESIGNATED_INITIALIZER;
/// Returns an instance of the <code>ApptentiveConfiguration</code> class initialized with the specified parameters.
/// \param key The Apptentive App Key, obtained from your Apptentive dashboard.
///
/// \param signature The Apptentive App Signature, obtained from your Apptentive dashboard.
///
///
/// returns:
/// A configuration object initalized with the key and signature.
+ (ApptentiveConfiguration * _Nonnull)configurationWithApptentiveKey:(NSString * _Nonnull)key apptentiveSignature:(NSString * _Nonnull)signature SWIFT_WARN_UNUSED_RESULT;
- (nonnull instancetype)init SWIFT_UNAVAILABLE;
+ (nonnull instancetype)new SWIFT_UNAVAILABLE_MSG("-init is unavailable");
@end

typedef SWIFT_ENUM(NSUInteger, ApptentiveLogLevel, open) {
/// Undefined.
  ApptentiveLogLevelUndefined = 0,
/// Critical failure log messages.
  ApptentiveLogLevelCrit = 1,
/// Error log messages.
  ApptentiveLogLevelError = 2,
/// Warning log messages.
  ApptentiveLogLevelWarn = 3,
/// Informational log messages.
  ApptentiveLogLevelInfo = 4,
/// Log messages that are potentially useful for debugging.
  ApptentiveLogLevelDebug = 5,
/// All possible log messages enabled.
  ApptentiveLogLevelVerbose = 6,
};

@class NSBundle;
@class NSCoder;

/// <code>UINavigationController</code> subclass intended primarily to facilitate scoping <code>UIAppearance</code> rules to Apptentive UI.
SWIFT_CLASS("_TtC13ApptentiveKit30ApptentiveNavigationController")
@interface ApptentiveNavigationController : UINavigationController
@property (nonatomic, readonly) UIStatusBarStyle preferredStatusBarStyle;
- (nonnull instancetype)initWithNavigationBarClass:(Class _Nullable)navigationBarClass toolbarClass:(Class _Nullable)toolbarClass OBJC_DESIGNATED_INITIALIZER SWIFT_AVAILABILITY(ios,introduced=5.0);
- (nonnull instancetype)initWithRootViewController:(UIViewController * _Nonnull)rootViewController OBJC_DESIGNATED_INITIALIZER;
- (nonnull instancetype)initWithNibName:(NSString * _Nullable)nibNameOrNil bundle:(NSBundle * _Nullable)nibBundleOrNil OBJC_DESIGNATED_INITIALIZER;
- (nullable instancetype)initWithCoder:(NSCoder * _Nonnull)aDecoder OBJC_DESIGNATED_INITIALIZER;
@end

typedef SWIFT_ENUM(NSInteger, ApptentivePushProvider, open) {
/// Specifies the Apptentive push provider.
  ApptentivePushProviderApptentive = 0,
/// Specifies the Urban Airship push provider.
  ApptentivePushProviderUrbanAirship = 1,
/// Specifies the Amazon Simple Notification Service push provider.
  ApptentivePushProviderAmazonSNS = 2,
/// Specifies the Parse push provider.
  ApptentivePushProviderParse = 3,
};



SWIFT_CLASS("_TtC13ApptentiveKit18TermsAndConditions")
@interface TermsAndConditions : NSObject
- (nonnull instancetype)init SWIFT_UNAVAILABLE;
+ (nonnull instancetype)new SWIFT_UNAVAILABLE_MSG("-init is unavailable");
@end












#if __has_attribute(external_source_symbol)
# pragma clang attribute pop
#endif
#pragma clang diagnostic pop
#endif
