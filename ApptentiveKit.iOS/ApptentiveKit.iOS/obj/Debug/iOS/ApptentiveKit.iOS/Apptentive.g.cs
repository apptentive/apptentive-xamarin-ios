//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected
#pragma warning disable 414
using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Diagnostics.CodeAnalysis;
using UIKit;
using GLKit;
using Metal;
using CoreML;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
#nullable enable
#if !NET
using NativeHandle = System.IntPtr;
#endif
namespace ApptentiveKit.iOS {
	[Register("_TtC13ApptentiveKit10Apptentive", true)]
	public unsafe partial class Apptentive : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("_TtC13ApptentiveKit10Apptentive");
		public override IntPtr ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected Apptentive (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal Apptentive (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("addCustomDeviceDataBool:withKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddCustomDeviceDataBool (bool boolValue, string key)
		{
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_bool_IntPtr (this.Handle, Selector.GetHandle ("addCustomDeviceDataBool:withKey:"), boolValue, nskey);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_bool_IntPtr (this.SuperHandle, Selector.GetHandle ("addCustomDeviceDataBool:withKey:"), boolValue, nskey);
			}
			CFString.ReleaseNative (nskey);
		}
		[Export ("addCustomDeviceDataNumber:withKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddCustomDeviceDataNumber (NSNumber number, string key)
		{
			var number__handle__ = number!.GetNonNullHandle (nameof (number));
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("addCustomDeviceDataNumber:withKey:"), number__handle__, nskey);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("addCustomDeviceDataNumber:withKey:"), number__handle__, nskey);
			}
			CFString.ReleaseNative (nskey);
		}
		[Export ("addCustomDeviceDataString:withKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddCustomDeviceDataString (string @string, string key)
		{
			if (@string is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (@string));
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nsstring = CFString.CreateNative (@string);
			var nskey = CFString.CreateNative (key);
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("addCustomDeviceDataString:withKey:"), nsstring, nskey);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("addCustomDeviceDataString:withKey:"), nsstring, nskey);
			}
			CFString.ReleaseNative (nsstring);
			CFString.ReleaseNative (nskey);
		}
		[Export ("addCustomPersonDataBool:withKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddCustomPersonDataBool (bool boolValue, string key)
		{
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_bool_IntPtr (this.Handle, Selector.GetHandle ("addCustomPersonDataBool:withKey:"), boolValue, nskey);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_bool_IntPtr (this.SuperHandle, Selector.GetHandle ("addCustomPersonDataBool:withKey:"), boolValue, nskey);
			}
			CFString.ReleaseNative (nskey);
		}
		[Export ("addCustomPersonDataNumber:withKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddCustomPersonDataNumber (NSNumber number, string key)
		{
			var number__handle__ = number!.GetNonNullHandle (nameof (number));
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("addCustomPersonDataNumber:withKey:"), number__handle__, nskey);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("addCustomPersonDataNumber:withKey:"), number__handle__, nskey);
			}
			CFString.ReleaseNative (nskey);
		}
		[Export ("addCustomPersonDataString:withKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddCustomPersonDataString (string @string, string key)
		{
			if (@string is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (@string));
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nsstring = CFString.CreateNative (@string);
			var nskey = CFString.CreateNative (key);
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("addCustomPersonDataString:withKey:"), nsstring, nskey);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("addCustomPersonDataString:withKey:"), nsstring, nskey);
			}
			CFString.ReleaseNative (nsstring);
			CFString.ReleaseNative (nskey);
		}
		[Export ("didReceiveRemoteNotification:fetchCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool DidReceiveRemoteNotification (NSDictionary userInfo, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<global::UIKit.UIBackgroundFetchResult> completionHandler)
		{
			var userInfo__handle__ = userInfo!.GetNonNullHandle (nameof (userInfo));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			BlockLiteral *block_ptr_completionHandler;
			BlockLiteral block_completionHandler;
			block_completionHandler = new BlockLiteral ();
			block_ptr_completionHandler = &block_completionHandler;
			block_completionHandler.SetupBlockUnsafe (Trampolines.SDActionArity1V0.Handler, completionHandler);
			bool ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinitions.Messaging.bool_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("didReceiveRemoteNotification:fetchCompletionHandler:"), userInfo__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				ret = global::ApiDefinitions.Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("didReceiveRemoteNotification:fetchCompletionHandler:"), userInfo__handle__, (IntPtr) block_ptr_completionHandler);
			}
			block_ptr_completionHandler->CleanupBlock ();
			return ret!;
		}
		[Export ("didReceveUserNotificationResponse:withCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool DidReceveUserNotificationResponse (global::UserNotifications.UNNotificationResponse response, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completionHandler)
		{
			var response__handle__ = response!.GetNonNullHandle (nameof (response));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			BlockLiteral *block_ptr_completionHandler;
			BlockLiteral block_completionHandler;
			block_completionHandler = new BlockLiteral ();
			block_ptr_completionHandler = &block_completionHandler;
			block_completionHandler.SetupBlockUnsafe (Trampolines.SDAction.Handler, completionHandler);
			bool ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinitions.Messaging.bool_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("didReceveUserNotificationResponse:withCompletionHandler:"), response__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				ret = global::ApiDefinitions.Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("didReceveUserNotificationResponse:withCompletionHandler:"), response__handle__, (IntPtr) block_ptr_completionHandler);
			}
			block_ptr_completionHandler->CleanupBlock ();
			return ret!;
		}
		[Export ("dismissMessageCenterWithAnimated:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DismissMessageCenterWithAnimated (bool animated, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action? completion)
		{
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			if (completion is null){
				block_ptr_completion = null;
			} else {
				block_completion = new BlockLiteral ();
				block_ptr_completion = &block_completion;
				block_completion.SetupBlockUnsafe (Trampolines.SDAction.Handler, completion);
			}
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_bool_IntPtr (this.Handle, Selector.GetHandle ("dismissMessageCenterWithAnimated:completion:"), animated, (IntPtr) block_ptr_completion);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_bool_IntPtr (this.SuperHandle, Selector.GetHandle ("dismissMessageCenterWithAnimated:completion:"), animated, (IntPtr) block_ptr_completion);
			}
			if (block_ptr_completion != null)
				block_ptr_completion->CleanupBlock ();
		}
		[Export ("engage:fromViewController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Engage (string @event, global::UIKit.UIViewController? viewController)
		{
			if (@event is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (@event));
			var viewController__handle__ = viewController.GetHandle ();
			var nsevent = CFString.CreateNative (@event);
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("engage:fromViewController:"), nsevent, viewController__handle__);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("engage:fromViewController:"), nsevent, viewController__handle__);
			}
			CFString.ReleaseNative (nsevent);
		}
		[Export ("engage:fromViewController:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void Engage (string @event, global::UIKit.UIViewController? viewController, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V1))]global::System.Action<bool>? completion)
		{
			if (@event is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (@event));
			var viewController__handle__ = viewController.GetHandle ();
			var nsevent = CFString.CreateNative (@event);
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			if (completion is null){
				block_ptr_completion = null;
			} else {
				block_completion = new BlockLiteral ();
				block_ptr_completion = &block_completion;
				block_completion.SetupBlockUnsafe (Trampolines.SDActionArity1V1.Handler, completion);
			}
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("engage:fromViewController:completion:"), nsevent, viewController__handle__, (IntPtr) block_ptr_completion);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("engage:fromViewController:completion:"), nsevent, viewController__handle__, (IntPtr) block_ptr_completion);
			}
			CFString.ReleaseNative (nsevent);
			if (block_ptr_completion != null)
				block_ptr_completion->CleanupBlock ();
		}
		[Export ("engage:withCustomData:fromViewController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Engage (string @event, NSDictionary? customData, global::UIKit.UIViewController? viewController)
		{
			if (@event is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (@event));
			var customData__handle__ = customData.GetHandle ();
			var viewController__handle__ = viewController.GetHandle ();
			var nsevent = CFString.CreateNative (@event);
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("engage:withCustomData:fromViewController:"), nsevent, customData__handle__, viewController__handle__);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("engage:withCustomData:fromViewController:"), nsevent, customData__handle__, viewController__handle__);
			}
			CFString.ReleaseNative (nsevent);
		}
		[Export ("engage:withCustomData:fromViewController:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void Engage (string @event, NSDictionary? customData, global::UIKit.UIViewController? viewController, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V1))]global::System.Action<bool>? completion)
		{
			if (@event is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (@event));
			var customData__handle__ = customData.GetHandle ();
			var viewController__handle__ = viewController.GetHandle ();
			var nsevent = CFString.CreateNative (@event);
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			if (completion is null){
				block_ptr_completion = null;
			} else {
				block_completion = new BlockLiteral ();
				block_ptr_completion = &block_completion;
				block_completion.SetupBlockUnsafe (Trampolines.SDActionArity1V1.Handler, completion);
			}
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("engage:withCustomData:fromViewController:completion:"), nsevent, customData__handle__, viewController__handle__, (IntPtr) block_ptr_completion);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("engage:withCustomData:fromViewController:completion:"), nsevent, customData__handle__, viewController__handle__, (IntPtr) block_ptr_completion);
			}
			CFString.ReleaseNative (nsevent);
			if (block_ptr_completion != null)
				block_ptr_completion->CleanupBlock ();
		}
		[Export ("engage:withCustomData:withExtendedData:fromViewController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Engage (string @event, NSDictionary? customData, NSDictionary[]? extendedData, global::UIKit.UIViewController? viewController)
		{
			if (@event is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (@event));
			var customData__handle__ = customData.GetHandle ();
			var viewController__handle__ = viewController.GetHandle ();
			var nsevent = CFString.CreateNative (@event);
			var nsa_extendedData = extendedData is null ? null : NSArray.FromNSObjects (extendedData);
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("engage:withCustomData:withExtendedData:fromViewController:"), nsevent, customData__handle__, nsa_extendedData.GetHandle (), viewController__handle__);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("engage:withCustomData:withExtendedData:fromViewController:"), nsevent, customData__handle__, nsa_extendedData.GetHandle (), viewController__handle__);
			}
			CFString.ReleaseNative (nsevent);
			if (nsa_extendedData != null)
				nsa_extendedData.Dispose ();
		}
		[Export ("engage:withCustomData:withExtendedData:fromViewController:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void Engage (string @event, NSDictionary? customData, NSDictionary[]? extendedData, global::UIKit.UIViewController? viewController, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V1))]global::System.Action<bool>? completion)
		{
			if (@event is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (@event));
			var customData__handle__ = customData.GetHandle ();
			var viewController__handle__ = viewController.GetHandle ();
			var nsevent = CFString.CreateNative (@event);
			var nsa_extendedData = extendedData is null ? null : NSArray.FromNSObjects (extendedData);
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			if (completion is null){
				block_ptr_completion = null;
			} else {
				block_completion = new BlockLiteral ();
				block_ptr_completion = &block_completion;
				block_completion.SetupBlockUnsafe (Trampolines.SDActionArity1V1.Handler, completion);
			}
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("engage:withCustomData:withExtendedData:fromViewController:completion:"), nsevent, customData__handle__, nsa_extendedData.GetHandle (), viewController__handle__, (IntPtr) block_ptr_completion);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("engage:withCustomData:withExtendedData:fromViewController:completion:"), nsevent, customData__handle__, nsa_extendedData.GetHandle (), viewController__handle__, (IntPtr) block_ptr_completion);
			}
			CFString.ReleaseNative (nsevent);
			if (nsa_extendedData != null)
				nsa_extendedData.Dispose ();
			if (block_ptr_completion != null)
				block_ptr_completion->CleanupBlock ();
		}
		[Export ("presentMessageCenterFromViewController:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void PresentMessageCenterFromViewController (global::UIKit.UIViewController? viewController, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V1))]global::System.Action<bool>? completion)
		{
			var viewController__handle__ = viewController.GetHandle ();
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			if (completion is null){
				block_ptr_completion = null;
			} else {
				block_completion = new BlockLiteral ();
				block_ptr_completion = &block_completion;
				block_completion.SetupBlockUnsafe (Trampolines.SDActionArity1V1.Handler, completion);
			}
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("presentMessageCenterFromViewController:completion:"), viewController__handle__, (IntPtr) block_ptr_completion);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("presentMessageCenterFromViewController:completion:"), viewController__handle__, (IntPtr) block_ptr_completion);
			}
			if (block_ptr_completion != null)
				block_ptr_completion->CleanupBlock ();
		}
		[Export ("presentMessageCenterFromViewController:withCustomData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PresentMessageCenterFromViewController (global::UIKit.UIViewController? viewController, NSDictionary? customData)
		{
			var viewController__handle__ = viewController.GetHandle ();
			var customData__handle__ = customData.GetHandle ();
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("presentMessageCenterFromViewController:withCustomData:"), viewController__handle__, customData__handle__);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("presentMessageCenterFromViewController:withCustomData:"), viewController__handle__, customData__handle__);
			}
		}
		[Export ("presentMessageCenterFromViewController:withCustomData:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void PresentMessageCenterFromViewController (global::UIKit.UIViewController? viewController, NSDictionary? customData, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V1))]global::System.Action<bool>? completion)
		{
			var viewController__handle__ = viewController.GetHandle ();
			var customData__handle__ = customData.GetHandle ();
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			if (completion is null){
				block_ptr_completion = null;
			} else {
				block_completion = new BlockLiteral ();
				block_ptr_completion = &block_completion;
				block_completion.SetupBlockUnsafe (Trampolines.SDActionArity1V1.Handler, completion);
			}
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("presentMessageCenterFromViewController:withCustomData:completion:"), viewController__handle__, customData__handle__, (IntPtr) block_ptr_completion);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("presentMessageCenterFromViewController:withCustomData:completion:"), viewController__handle__, customData__handle__, (IntPtr) block_ptr_completion);
			}
			if (block_ptr_completion != null)
				block_ptr_completion->CleanupBlock ();
		}
		[Export ("queryCanShowInteractionForEvent:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void QueryCanShowInteractionForEvent (string @event, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V1))]global::System.Action<bool> completion)
		{
			if (@event is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (@event));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			var nsevent = CFString.CreateNative (@event);
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlockUnsafe (Trampolines.SDActionArity1V1.Handler, completion);
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("queryCanShowInteractionForEvent:completion:"), nsevent, (IntPtr) block_ptr_completion);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("queryCanShowInteractionForEvent:completion:"), nsevent, (IntPtr) block_ptr_completion);
			}
			CFString.ReleaseNative (nsevent);
			block_ptr_completion->CleanupBlock ();
		}
		[Export ("registerWithKey:signature:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RegisterWithKey (string key, string signature, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V1))]global::System.Action<bool>? completion)
		{
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			if (signature is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (signature));
			var nskey = CFString.CreateNative (key);
			var nssignature = CFString.CreateNative (signature);
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			if (completion is null){
				block_ptr_completion = null;
			} else {
				block_completion = new BlockLiteral ();
				block_ptr_completion = &block_completion;
				block_completion.SetupBlockUnsafe (Trampolines.SDActionArity1V1.Handler, completion);
			}
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("registerWithKey:signature:completion:"), nskey, nssignature, (IntPtr) block_ptr_completion);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("registerWithKey:signature:completion:"), nskey, nssignature, (IntPtr) block_ptr_completion);
			}
			CFString.ReleaseNative (nskey);
			CFString.ReleaseNative (nssignature);
			if (block_ptr_completion != null)
				block_ptr_completion->CleanupBlock ();
		}
		[Export ("removeCustomDeviceDataWithKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveCustomDeviceDataWithKey (string key)
		{
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("removeCustomDeviceDataWithKey:"), nskey);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("removeCustomDeviceDataWithKey:"), nskey);
			}
			CFString.ReleaseNative (nskey);
		}
		[Export ("removeCustomPersonDataWithKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveCustomPersonDataWithKey (string key)
		{
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("removeCustomPersonDataWithKey:"), nskey);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("removeCustomPersonDataWithKey:"), nskey);
			}
			CFString.ReleaseNative (nskey);
		}
		[Export ("sendAttachmentData:mimeType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SendAttachmentData (NSData fileData, string mediaType)
		{
			var fileData__handle__ = fileData!.GetNonNullHandle (nameof (fileData));
			if (mediaType is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (mediaType));
			var nsmediaType = CFString.CreateNative (mediaType);
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("sendAttachmentData:mimeType:"), fileData__handle__, nsmediaType);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("sendAttachmentData:mimeType:"), fileData__handle__, nsmediaType);
			}
			CFString.ReleaseNative (nsmediaType);
		}
		[Export ("sendAttachmentImage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SendAttachmentImage (global::UIKit.UIImage image)
		{
			var image__handle__ = image!.GetNonNullHandle (nameof (image));
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("sendAttachmentImage:"), image__handle__);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("sendAttachmentImage:"), image__handle__);
			}
		}
		[Export ("sendAttachmentText:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SendAttachmentText (string text)
		{
			if (text is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (text));
			var nstext = CFString.CreateNative (text);
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("sendAttachmentText:"), nstext);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("sendAttachmentText:"), nstext);
			}
			CFString.ReleaseNative (nstext);
		}
		[Export ("setRemoteNotifcationDeviceToken:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetRemoteNotifcationDeviceToken (NSData tokenData)
		{
			var tokenData__handle__ = tokenData!.GetNonNullHandle (nameof (tokenData));
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setRemoteNotifcationDeviceToken:"), tokenData__handle__);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setRemoteNotifcationDeviceToken:"), tokenData__handle__);
			}
		}
		[Export ("userNotificationCenter:willPresentNotification:withCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void UserNotificationCenter (global::UserNotifications.UNUserNotificationCenter center, global::UserNotifications.UNNotification notification, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V2))]global::System.Action<global::UserNotifications.UNNotificationPresentationOptions> completionHandler)
		{
			var center__handle__ = center!.GetNonNullHandle (nameof (center));
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			BlockLiteral *block_ptr_completionHandler;
			BlockLiteral block_completionHandler;
			block_completionHandler = new BlockLiteral ();
			block_ptr_completionHandler = &block_completionHandler;
			block_completionHandler.SetupBlockUnsafe (Trampolines.SDActionArity1V2.Handler, completionHandler);
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("userNotificationCenter:willPresentNotification:withCompletionHandler:"), center__handle__, notification__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("userNotificationCenter:willPresentNotification:withCompletionHandler:"), center__handle__, notification__handle__, (IntPtr) block_ptr_completionHandler);
			}
			block_ptr_completionHandler->CleanupBlock ();
		}
		[Export ("userNotificationCenter:didReceiveNotificationResponse:withCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void UserNotificationCenter (global::UserNotifications.UNUserNotificationCenter center, global::UserNotifications.UNNotificationResponse response, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completionHandler)
		{
			var center__handle__ = center!.GetNonNullHandle (nameof (center));
			var response__handle__ = response!.GetNonNullHandle (nameof (response));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			BlockLiteral *block_ptr_completionHandler;
			BlockLiteral block_completionHandler;
			block_completionHandler = new BlockLiteral ();
			block_ptr_completionHandler = &block_completionHandler;
			block_completionHandler.SetupBlockUnsafe (Trampolines.SDAction.Handler, completionHandler);
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("userNotificationCenter:didReceiveNotificationResponse:withCompletionHandler:"), center__handle__, response__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("userNotificationCenter:didReceiveNotificationResponse:withCompletionHandler:"), center__handle__, response__handle__, (IntPtr) block_ptr_completionHandler);
			}
			block_ptr_completionHandler->CleanupBlock ();
		}
		[Export ("willPresent:withCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool WillPresent (global::UserNotifications.UNNotification notification, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V2))]global::System.Action<global::UserNotifications.UNNotificationPresentationOptions> completionHandler)
		{
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			BlockLiteral *block_ptr_completionHandler;
			BlockLiteral block_completionHandler;
			block_completionHandler = new BlockLiteral ();
			block_ptr_completionHandler = &block_completionHandler;
			block_completionHandler.SetupBlockUnsafe (Trampolines.SDActionArity1V2.Handler, completionHandler);
			bool ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinitions.Messaging.bool_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("willPresent:withCompletionHandler:"), notification__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				ret = global::ApiDefinitions.Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("willPresent:withCompletionHandler:"), notification__handle__, (IntPtr) block_ptr_completionHandler);
			}
			block_ptr_completionHandler->CleanupBlock ();
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? DistributionName {
			[Export ("distributionName")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("distributionName")))!;
				} else {
					return CFString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("distributionName")))!;
				}
			}
			[Export ("setDistributionName:")]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDistributionName:"), nsvalue);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDistributionName:"), nsvalue);
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? DistributionVersion {
			[Export ("distributionVersion")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("distributionVersion")))!;
				} else {
					return CFString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("distributionVersion")))!;
				}
			}
			[Export ("setDistributionVersion:")]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDistributionVersion:"), nsvalue);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDistributionVersion:"), nsvalue);
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual ApptentiveLogLevel LogLevel {
			[Export ("logLevel", ArgumentSemantic.UnsafeUnretained)]
			get {
				ApptentiveLogLevel ret;
				if (IsDirectBinding) {
					ret = (ApptentiveKit.iOS.ApptentiveLogLevel) (ulong) global::ApiDefinitions.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("logLevel"));
				} else {
					ret = (ApptentiveKit.iOS.ApptentiveLogLevel) (ulong) global::ApiDefinitions.Messaging.UIntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("logLevel"));
				}
				return ret!;
			}
			[Export ("setLogLevel:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("setLogLevel:"), (UIntPtr) (ulong) value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_UIntPtr (this.SuperHandle, Selector.GetHandle ("setLogLevel:"), (UIntPtr) (ulong) value);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? MParticleID {
			[Export ("mParticleID")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("mParticleID")))!;
				} else {
					return CFString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("mParticleID")))!;
				}
			}
			[Export ("setMParticleID:")]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setMParticleID:"), nsvalue);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setMParticleID:"), nsvalue);
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? PersonEmailAddress {
			[Export ("personEmailAddress")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("personEmailAddress")))!;
				} else {
					return CFString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("personEmailAddress")))!;
				}
			}
			[Export ("setPersonEmailAddress:")]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setPersonEmailAddress:"), nsvalue);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setPersonEmailAddress:"), nsvalue);
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? PersonName {
			[Export ("personName")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("personName")))!;
				} else {
					return CFString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("personName")))!;
				}
			}
			[Export ("setPersonName:")]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setPersonName:"), nsvalue);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setPersonName:"), nsvalue);
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static Apptentive Shared {
			[Export ("shared", ArgumentSemantic.Retain)]
			get {
				Apptentive? ret;
				ret =  Runtime.GetNSObject<Apptentive> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("shared")))!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual TermsAndConditions SurveyTermsAndConditions {
			[Export ("surveyTermsAndConditions", ArgumentSemantic.Retain)]
			get {
				TermsAndConditions? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<TermsAndConditions> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("surveyTermsAndConditions")))!;
				} else {
					ret =  Runtime.GetNSObject<TermsAndConditions> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("surveyTermsAndConditions")))!;
				}
				return ret!;
			}
			[Export ("setSurveyTermsAndConditions:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSurveyTermsAndConditions:"), value__handle__);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setSurveyTermsAndConditions:"), value__handle__);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint UnreadMessageCount {
			[Export ("unreadMessageCount")]
			get {
				if (IsDirectBinding) {
					return (nint) global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("unreadMessageCount"));
				} else {
					return (nint) global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("unreadMessageCount"));
				}
			}
			[Export ("setUnreadMessageCount:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setUnreadMessageCount:"), (IntPtr) value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setUnreadMessageCount:"), (IntPtr) value);
				}
			}
		}
	} /* class Apptentive */
}
