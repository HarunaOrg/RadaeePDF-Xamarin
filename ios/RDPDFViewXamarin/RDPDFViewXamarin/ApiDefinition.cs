using System;
using AVFoundation;
using CloudKit;
using CoreAnimation;
using CoreData;
using CoreFoundation;
using CoreGraphics;
using CoreImage;
using CoreVideo;
using FileProvider;
using Foundation;
using IOSurface;
using ImageIO;
using Intents;
using LinkPresentation;
using Metal;
using ObjCRuntime;
using OpenGLES;
using Security;
using UIKit;
using UserNotifications;

namespace RadaeeLib
{
	// @interface RDVLocker : NSObject
	[BaseType (typeof(NSObject))]
	interface RDVLocker
	{
		// -(void)lock;
		[Export ("lock")]
		void Lock ();

		// -(void)unlock;
		[Export ("unlock")]
		void Unlock ();
	}

	// @interface RDVEvent : NSObject
	[BaseType (typeof(NSObject))]
	interface RDVEvent
	{
		// -(void)reset;
		[Export ("reset")]
		void Reset ();

		// -(void)notify;
		[Export ("notify")]
		void Notify ();

		// -(void)wait;
		[Export ("wait")]
		void Wait ();
	}

	// @interface RDVGlobal : NSObject
	[BaseType (typeof(NSObject))]
	interface RDVGlobal
	{
		// @property (nonatomic, strong) NSString * text;
		[Export ("text", ArgumentSemantic.Strong)]
		string Text { get; set; }

		// @property (nonatomic, strong) NSMutableString * g_pdf_name;
		[Export ("g_pdf_name", ArgumentSemantic.Strong)]
		NSMutableString G_pdf_name { get; set; }

		// @property (nonatomic, strong) NSMutableString * g_pdf_path;
		[Export ("g_pdf_path", ArgumentSemantic.Strong)]
		NSMutableString G_pdf_path { get; set; }

		// @property (nonatomic, strong) NSString * g_author;
		[Export ("g_author", ArgumentSemantic.Strong)]
		string G_author { get; set; }

		// @property (nonatomic, strong) NSString * g_sign_pad_descr;
		[Export ("g_sign_pad_descr", ArgumentSemantic.Strong)]
		string G_sign_pad_descr { get; set; }

		// @property (nonatomic) uint g_rect_color;
		[Export ("g_rect_color")]
		uint G_rect_color { get; set; }

		// @property (nonatomic) uint g_line_color;
		[Export ("g_line_color")]
		uint G_line_color { get; set; }

		// @property (nonatomic) uint g_ink_color;
		[Export ("g_ink_color")]
		uint G_ink_color { get; set; }

		// @property (nonatomic) uint g_sel_color;
		[Export ("g_sel_color")]
		uint G_sel_color { get; set; }

		// @property (nonatomic) uint g_oval_color;
		[Export ("g_oval_color")]
		uint G_oval_color { get; set; }

		// @property (nonatomic) uint g_rect_annot_fill_color;
		[Export ("g_rect_annot_fill_color")]
		uint G_rect_annot_fill_color { get; set; }

		// @property (nonatomic) uint g_ellipse_annot_fill_color;
		[Export ("g_ellipse_annot_fill_color")]
		uint G_ellipse_annot_fill_color { get; set; }

		// @property (nonatomic) uint g_line_annot_fill_color;
		[Export ("g_line_annot_fill_color")]
		uint G_line_annot_fill_color { get; set; }

		// @property (nonatomic) uint g_annot_highlight_clr;
		[Export ("g_annot_highlight_clr")]
		uint G_annot_highlight_clr { get; set; }

		// @property (nonatomic) uint g_annot_underline_clr;
		[Export ("g_annot_underline_clr")]
		uint G_annot_underline_clr { get; set; }

		// @property (nonatomic) uint g_annot_strikeout_clr;
		[Export ("g_annot_strikeout_clr")]
		uint G_annot_strikeout_clr { get; set; }

		// @property (nonatomic) uint g_annot_squiggly_clr;
		[Export ("g_annot_squiggly_clr")]
		uint G_annot_squiggly_clr { get; set; }

		// @property (nonatomic) uint g_annot_transparency;
		[Export ("g_annot_transparency")]
		uint G_annot_transparency { get; set; }

		// @property (nonatomic) uint g_find_primary_color;
		[Export ("g_find_primary_color")]
		uint G_find_primary_color { get; set; }

		// @property (nonatomic) uint g_readerview_bg_color;
		[Export ("g_readerview_bg_color")]
		uint G_readerview_bg_color { get; set; }

		// @property (nonatomic) uint g_thumbview_bg_color;
		[Export ("g_thumbview_bg_color")]
		uint G_thumbview_bg_color { get; set; }

		// @property (nonatomic) float g_ink_width;
		[Export ("g_ink_width")]
		float G_ink_width { get; set; }

		// @property (nonatomic) float g_rect_width;
		[Export ("g_rect_width")]
		float G_rect_width { get; set; }

		// @property (nonatomic) float g_line_width;
		[Export ("g_line_width")]
		float G_line_width { get; set; }

		// @property (nonatomic) float g_oval_width;
		[Export ("g_oval_width")]
		float G_oval_width { get; set; }

		// @property (nonatomic) float g_swipe_speed;
		[Export ("g_swipe_speed")]
		float G_swipe_speed { get; set; }

		// @property (nonatomic) float g_swipe_distance;
		[Export ("g_swipe_distance")]
		float G_swipe_distance { get; set; }

		// @property (nonatomic) float g_tap_zoom_level;
		[Export ("g_tap_zoom_level")]
		float G_tap_zoom_level { get; set; }

		// @property (nonatomic) float g_layout_zoom_level;
		[Export ("g_layout_zoom_level")]
		float G_layout_zoom_level { get; set; }

		// @property (nonatomic) float g_zoom_step;
		[Export ("g_zoom_step")]
		float G_zoom_step { get; set; }

		// @property (nonatomic) _Bool g_case_sensitive;
		[Export ("g_case_sensitive")]
		bool G_case_sensitive { get; set; }

		// @property (nonatomic) _Bool g_match_whole_word;
		[Export ("g_match_whole_word")]
		bool G_match_whole_word { get; set; }

		// @property (nonatomic) _Bool g_sel_right;
		[Export ("g_sel_right")]
		bool G_sel_right { get; set; }

		// @property (nonatomic) _Bool g_screen_awake;
		[Export ("g_screen_awake")]
		bool G_screen_awake { get; set; }

		// @property (nonatomic) _Bool g_save_doc;
		[Export ("g_save_doc")]
		bool G_save_doc { get; set; }

		// @property (nonatomic) _Bool g_static_scale;
		[Export ("g_static_scale")]
		bool G_static_scale { get; set; }

		// @property (nonatomic) _Bool g_paging_enabled;
		[Export ("g_paging_enabled")]
		bool G_paging_enabled { get; set; }

		// @property (nonatomic) _Bool g_double_page_enabled;
		[Export ("g_double_page_enabled")]
		bool G_double_page_enabled { get; set; }

		// @property (nonatomic) _Bool g_curl_enabled;
		[Export ("g_curl_enabled")]
		bool G_curl_enabled { get; set; }

		// @property (nonatomic) _Bool g_cover_page_enabled;
		[Export ("g_cover_page_enabled")]
		bool G_cover_page_enabled { get; set; }

		// @property (nonatomic) _Bool g_fit_signature_to_field;
		[Export ("g_fit_signature_to_field")]
		bool G_fit_signature_to_field { get; set; }

		// @property (nonatomic) _Bool g_execute_annot_JS;
		[Export ("g_execute_annot_JS")]
		bool G_execute_annot_JS { get; set; }

		// @property (nonatomic) _Bool g_dark_mode;
		[Export ("g_dark_mode")]
		bool G_dark_mode { get; set; }

		// @property (nonatomic) _Bool g_annot_lock;
		[Export ("g_annot_lock")]
		bool G_annot_lock { get; set; }

		// @property (nonatomic) _Bool g_annot_readonly;
		[Export ("g_annot_readonly")]
		bool G_annot_readonly { get; set; }

		// @property (nonatomic) _Bool g_auto_launch_link;
		[Export ("g_auto_launch_link")]
		bool G_auto_launch_link { get; set; }

		// @property (nonatomic) _Bool g_highlight_annotation;
		[Export ("g_highlight_annotation")]
		bool G_highlight_annotation { get; set; }

		// @property (nonatomic) _Bool g_enable_graphical_signature;
		[Export ("g_enable_graphical_signature")]
		bool G_enable_graphical_signature { get; set; }

		// @property (nonatomic) int g_render_quality;
		[Export ("g_render_quality")]
		int G_render_quality { get; set; }

		// @property (nonatomic) int g_render_mode;
		[Export ("g_render_mode")]
		int G_render_mode { get; set; }

		// @property (nonatomic) int g_navigation_mode;
		[Export ("g_navigation_mode")]
		int G_navigation_mode { get; set; }

		// @property (nonatomic) int g_line_annot_style1;
		[Export ("g_line_annot_style1")]
		int G_line_annot_style1 { get; set; }

		// @property (nonatomic) int g_line_annot_style2;
		[Export ("g_line_annot_style2")]
		int G_line_annot_style2 { get; set; }

		// @property (nonatomic) int g_thumbview_height;
		[Export ("g_thumbview_height")]
		int G_thumbview_height { get; set; }

		// +(RDVGlobal *)sharedInstance;
		[Static]
		[Export ("sharedInstance")]
		
		RDVGlobal SharedInstance { get; }

		// +(void)Init;
		[Static]
		[Export ("Init")]
		void Init ();

		// -(void)setup;
		[Export ("setup")]
		void Setup ();
	}


	// @interface RDMetaDataViewController : UIViewController
	[BaseType (typeof(UIViewController))]
	interface RDMetaDataViewController
	{
		// @property (nonatomic) BOOL autoSave;
		[Export ("autoSave")]
		bool AutoSave { get; set; }

		// @property (nonatomic, strong) UITextField * titleTextField __attribute__((iboutlet));
		[Export ("titleTextField", ArgumentSemantic.Strong)]
		UITextField TitleTextField { get; set; }

		// @property (nonatomic, strong) UITextField * authorTextField __attribute__((iboutlet));
		[Export ("authorTextField", ArgumentSemantic.Strong)]
		UITextField AuthorTextField { get; set; }

		// @property (nonatomic, strong) UITextField * subjectTextField __attribute__((iboutlet));
		[Export ("subjectTextField", ArgumentSemantic.Strong)]
		UITextField SubjectTextField { get; set; }

		// @property (nonatomic, strong) UITextView * keyWordsTextView __attribute__((iboutlet));
		[Export ("keyWordsTextView", ArgumentSemantic.Strong)]
		UITextView KeyWordsTextView { get; set; }

		// -(void)dismissView:(id)sender __attribute__((ibaction));
		[Export ("dismissView:")]
		void DismissView (NSObject sender);
	}

	// @interface UILElement : UIView
	[BaseType (typeof(UIView))]
	interface UILElement
	{
		// -(id _Nonnull)initWithFrame:(CGRect)frame;
		[Export ("initWithFrame:")]
		IntPtr Constructor (CGRect frame);
	}

	// @interface UIColorBtn : UILElement
	[BaseType (typeof(UILElement))]
	interface UIColorBtn
	{
		// -(id)initWithFrame:(CGRect)frame;
		[Export ("initWithFrame:")]
		IntPtr Constructor (CGRect frame);

		// -(void)setColor:(unsigned int)color :(Boolean)has_enable :(UIViewController *)vc;
		[Export ("setColor:::")]
		void SetColor (uint color, byte has_enable, UIViewController vc);

		// -(void)setColor:(unsigned int)color :(Boolean)has_enable;
		[Export ("setColor::")]
		void SetColor (uint color, byte has_enable);

		// -(void)showViews;
		[Export ("showViews")]
		void ShowViews ();

		// -(int)color;
		[Export ("color")]
		
		int Color { get; }
	}

	// @interface UILShadowView : UIView
	[BaseType (typeof(UIView))]
	interface UILShadowView
	{
		// -(id _Nonnull)initWithFrame:(CGRect)frame;
		[Export ("initWithFrame:")]
		IntPtr Constructor (CGRect frame);

		// @property (nonatomic, strong) UIView * _Nonnull buttonView __attribute__((iboutlet));
		[Export ("buttonView", ArgumentSemantic.Strong)]
		UIView ButtonView { get; set; }

		// @property (nonatomic, strong) UIButton * _Nonnull okButton __attribute__((iboutlet));
		[Export ("okButton", ArgumentSemantic.Strong)]
		UIButton OkButton { get; set; }

		// @property (nonatomic, strong) UIButton * _Nonnull cancelButton __attribute__((iboutlet));
		[Export ("cancelButton", ArgumentSemantic.Strong)]
		UIButton CancelButton { get; set; }
	}

	// @interface DlgAnnotPropMarkup : UILShadowView
	[BaseType(typeof(UILShadowView))]
	interface DlgAnnotPropMarkup
	{
		// -(id)initWithFrame:(CGRect)frame;
		[Export ("initWithFrame:")]
		IntPtr Constructor (CGRect frame);

		// -(void)updateAnnot;
		[Export ("updateAnnot")]
		void UpdateAnnot ();

		// -(void)OnAlpha:(id)sender __attribute__((ibaction));
		[Export ("OnAlpha:")]
		void OnAlpha (NSObject sender);

		// -(void)OnLocked:(id)sender __attribute__((ibaction));
		[Export ("OnLocked:")]
		void OnLocked (NSObject sender);
	}

	// typedef void (^func_icon)(int);
	delegate void func_icon (int arg0);

	// @interface UIIconBtn : UIImageView
	[BaseType (typeof(UIImageView))]
	interface UIIconBtn
	{

		// -(id)initWithFrame:(CGRect)frame;
		[Export ("initWithFrame:")]
		IntPtr Constructor (CGRect frame);

		// -(int)icon;
		[Export ("icon")]
		
		int Icon { get; }
	}

	// @interface DlgAnnotPropIcon : UILShadowView
	[BaseType(typeof(UILShadowView))]
	interface DlgAnnotPropIcon
	{
		// -(void)OnAlphaChanged:(id)sender __attribute__((ibaction));
		[Export ("OnAlphaChanged:")]
		void OnAlphaChanged (NSObject sender);

		// -(void)OnLock:(id)sender __attribute__((ibaction));
		[Export ("OnLock:")]
		void OnLock (NSObject sender);

		// -(void)updateAnnot;
		[Export ("updateAnnot")]
		void UpdateAnnot ();
	}

	// @interface PDFPopupBG : UIView
	[BaseType (typeof(UIView))]
	interface PDFPopupBG
	{
		// -(id)init:(UIView *)child :(id)notifier :(SEL)dismiss;
		[Export ("init:::")]
		IntPtr Constructor (UIView child, NSObject notifier, Selector dismiss);
	}

	// typedef void (^func_pop_dismiss)();
	delegate void func_pop_dismiss ();

	// @interface PDFPopupCtrl : UIViewController
	[BaseType (typeof(UIViewController))]
	interface PDFPopupCtrl
	{
		// -(id)init:(UIView *)view;
		[Export ("init:")]
		IntPtr Constructor (UIView view);

		// -(void)setDismiss:(func_pop_dismiss)dismiss;
		[Export ("setDismiss:")]
		void SetDismiss (func_pop_dismiss dismiss);

		// -(void)dismiss;
		[Export ("dismiss")]
		void Dismiss ();
	}

	// typedef void (^func_lstyle)(const CGFloat *, int);
	delegate void func_lstyle (nfloat arg0, int arg1);

	// @interface UILStyleView : UIView
	[BaseType (typeof(UIView))]
	interface UILStyleView
	{
		// -(id)init:(CGRect)frame :(func_lstyle)callback;
		[Export ("init::")]
		IntPtr Constructor (CGRect frame, func_lstyle callback);

		// -(void)setDash:(const CGFloat *)dash :(int)dash_cnt;
		[Export ("setDash::")]
		void SetDash (nfloat dash, int dash_cnt);
	}

	// @interface UILStyleBtn : UILElement
	[BaseType (typeof(UILElement))]
	interface UILStyleBtn
	{
		// -(void)setDash:(const CGFloat *)dash :(int)dash_cnt :(UIViewController *)vc;
		[Export ("setDash:::")]
		void SetDash (nfloat dash, int dash_cnt, UIViewController vc);

		// -(const CGFloat *)dash;
		[Export ("dash")]
		
		nfloat Dash { get; }

		// -(int)dashCnt;
		[Export ("dashCnt")]
		
		int DashCnt { get; }
	}

	// @interface DlgAnnotPropComm : UILShadowView
	[BaseType(typeof(UILShadowView))]
	interface DlgAnnotPropComm
	{
		// -(id)initWithFrame:(CGRect)frame;
		[Export ("initWithFrame:")]
		IntPtr Constructor (CGRect frame);

		// -(void)hasFill:(BOOL)has;
		[Export ("hasFill:")]
		void HasFill (bool has);

		// -(void)updateAnnot;
		[Export ("updateAnnot")]
		void UpdateAnnot ();

		// -(void)OnAlphaChanged:(id)sender __attribute__((ibaction));
		[Export ("OnAlphaChanged:")]
		void OnAlphaChanged (NSObject sender);

		// -(void)OnLock:(id)sender __attribute__((ibaction));
		[Export ("OnLock:")]
		void OnLock (NSObject sender);
	}

	// typedef void (^func_lhead)(int);
	delegate void func_lhead (int arg0);

	// @interface UILHeadView : UIView
	[BaseType (typeof(UIView))]
	interface UILHeadView
	{
		// -(id)init:(CGRect)frame :(func_lhead)callback;
		[Export ("init::")]
		IntPtr Constructor (CGRect frame, func_lhead callback);

		// -(void)setStyle:(int)style;
		[Export ("setStyle:")]
		void SetStyle (int style);
	}

	// @interface UILHeadBtn : UILElement
	[BaseType (typeof(UILElement))]
	interface UILHeadBtn
	{
		// -(id)initWithFrame:(CGRect)frame;
		[Export ("initWithFrame:")]
		IntPtr Constructor (CGRect frame);

		// -(void)setStyle:(int)style :(UIViewController *)vc;
		[Export ("setStyle::")]
		void SetStyle (int style, UIViewController vc);

		// -(int)style;
		[Export ("style")]
		
		int Style { get; }
	}

	// @interface DlgAnnotPropLine : UILShadowView
	[BaseType(typeof(UILShadowView))]
	interface DlgAnnotPropLine
	{
		// -(id)initWithFrame:(CGRect)frame;
		[Export ("initWithFrame:")]
		IntPtr Constructor (CGRect frame);

		// -(void)updateAnnot;
		[Export ("updateAnnot")]
		void UpdateAnnot ();

		// -(void)OnAlphaChanged:(id)sender __attribute__((ibaction));
		[Export ("OnAlphaChanged:")]
		void OnAlphaChanged (NSObject sender);

		// -(void)OnLock:(id)sender __attribute__((ibaction));
		[Export ("OnLock:")]
		void OnLock (NSObject sender);
	}

	// @protocol RadaeePDFPluginDelegate
	[BaseType(typeof(NSObject))]
	[Model]
	interface RadaeePDFPluginDelegate
	{
		// @required -(void)willShowReader;
		[Abstract]
		[Export ("willShowReader")]
		void WillShowReader ();

		// @required -(void)didShowReader;
		[Abstract]
		[Export ("didShowReader")]
		void DidShowReader ();

		// @required -(void)willCloseReader;
		[Abstract]
		[Export ("willCloseReader")]
		void WillCloseReader ();

		// @required -(void)didCloseReader;
		[Abstract]
		[Export ("didCloseReader")]
		void DidCloseReader ();

		// @required -(void)didChangePage:(int)page;
		[Abstract]
		[Export ("didChangePage:")]
		void DidChangePage (int page);

		// @required -(void)didSearchTerm:(NSString *)term found:(BOOL)found;
		[Abstract]
		[Export ("didSearchTerm:found:")]
		void DidSearchTerm (string term, bool found);

		// @required -(void)didTapOnPage:(int)page atPoint:(CGPoint)point;
		[Abstract]
		[Export ("didTapOnPage:atPoint:")]
		void DidTapOnPage (int page, CGPoint point);

		// @required -(void)didDoubleTapOnPage:(int)page atPoint:(CGPoint)point;
		[Abstract]
		[Export ("didDoubleTapOnPage:atPoint:")]
		void DidDoubleTapOnPage (int page, CGPoint point);

		// @required -(void)didLongPressOnPage:(int)page atPoint:(CGPoint)point;
		[Abstract]
		[Export ("didLongPressOnPage:atPoint:")]
		void DidLongPressOnPage (int page, CGPoint point);

		// @required -(void)didTapOnAnnotationOfType:(int)type atPage:(int)page atPoint:(CGPoint)point;
		[Abstract]
		[Export ("didTapOnAnnotationOfType:atPage:atPoint:")]
		void DidTapOnAnnotationOfType (int type, int page, CGPoint point);

		// @required -(void)onAnnotExported:(NSString *)path;
		[Abstract]
		[Export ("onAnnotExported:")]
		void OnAnnotExported (string path);
	}

	// @interface RadaeePDFPlugin : NSObject
	[BaseType (typeof(NSObject))]
	interface RadaeePDFPlugin
	{
		// @property (nonatomic, strong) NSString * lastOpenedPath;
		[Export ("lastOpenedPath", ArgumentSemantic.Strong)]
		string LastOpenedPath { get; set; }

		// @property (nonatomic, strong) UIImage * viewModeImage;
		[Export ("viewModeImage", ArgumentSemantic.Strong)]
		UIImage ViewModeImage { get; set; }

		// @property (nonatomic, strong) UIImage * searchImage;
		[Export ("searchImage", ArgumentSemantic.Strong)]
		UIImage SearchImage { get; set; }

		// @property (nonatomic, strong) UIImage * bookmarkImage;
		[Export ("bookmarkImage", ArgumentSemantic.Strong)]
		UIImage BookmarkImage { get; set; }

		// @property (nonatomic, strong) UIImage * outlineImage;
		[Export ("outlineImage", ArgumentSemantic.Strong)]
		UIImage OutlineImage { get; set; }

		// @property (nonatomic, strong) UIImage * lineImage;
		[Export ("lineImage", ArgumentSemantic.Strong)]
		UIImage LineImage { get; set; }

		// @property (nonatomic, strong) UIImage * rectImage;
		[Export ("rectImage", ArgumentSemantic.Strong)]
		UIImage RectImage { get; set; }

		// @property (nonatomic, strong) UIImage * ellipseImage;
		[Export ("ellipseImage", ArgumentSemantic.Strong)]
		UIImage EllipseImage { get; set; }

		// @property (nonatomic, strong) UIImage * printImage;
		[Export ("printImage", ArgumentSemantic.Strong)]
		UIImage PrintImage { get; set; }

		// @property (nonatomic, strong) UIImage * gridImage;
		[Export ("gridImage", ArgumentSemantic.Strong)]
		UIImage GridImage { get; set; }

		// @property (nonatomic, strong) UIImage * deleteImage;
		[Export ("deleteImage", ArgumentSemantic.Strong)]
		UIImage DeleteImage { get; set; }

		// @property (nonatomic, strong) UIImage * doneImage;
		[Export ("doneImage", ArgumentSemantic.Strong)]
		UIImage DoneImage { get; set; }

		// @property (nonatomic, strong) UIImage * removeImage;
		[Export ("removeImage", ArgumentSemantic.Strong)]
		UIImage RemoveImage { get; set; }

		// @property (nonatomic, strong) UIImage * exportImage;
		[Export ("exportImage", ArgumentSemantic.Strong)]
		UIImage ExportImage { get; set; }

		// @property (nonatomic, strong) UIImage * prevImage;
		[Export ("prevImage", ArgumentSemantic.Strong)]
		UIImage PrevImage { get; set; }

		// @property (nonatomic, strong) UIImage * nextImage;
		[Export ("nextImage", ArgumentSemantic.Strong)]
		UIImage NextImage { get; set; }

		// +(RadaeePDFPlugin *)pluginInit;
		[Static]
		[Export ("pluginInit")]
		
		RadaeePDFPlugin PluginInit { get; }

		// -(id)show:(NSString *)file withPassword:(NSString *)password;
		[Export ("show:withPassword:")]
		NSObject Show (string file, string password);

		// -(id)show:(NSString *)file atPage:(int)page withPassword:(NSString *)password readOnly:(BOOL)readOnly autoSave:(BOOL)autoSave;
		[Export ("show:atPage:withPassword:readOnly:autoSave:")]
		NSObject Show (string file, int page, string password, bool readOnly, bool autoSave);

		// -(id)show:(NSString *)file atPage:(int)page withPassword:(NSString *)password readOnly:(BOOL)readOnly autoSave:(BOOL)autoSave author:(NSString *)author;
		[Export ("show:atPage:withPassword:readOnly:autoSave:author:")]
		NSObject Show (string file, int page, string password, bool readOnly, bool autoSave, string author);

		// -(void)activateLicenseWithBundleId:(NSString *)bundleId company:(NSString *)company email:(NSString *)email key:(NSString *)key licenseType:(int)type;
		[Export ("activateLicenseWithBundleId:company:email:key:licenseType:")]
		void ActivateLicenseWithBundleId (string bundleId, string company, string email, string key, int type);

		// -(id)openFromAssets:(NSString *)file withPassword:(NSString *)password;
		[Export ("openFromAssets:withPassword:")]
		NSObject OpenFromAssets (string file, string password);

		// -(id)openFromAssets:(NSString *)file atPage:(int)page withPassword:(NSString *)password readOnly:(BOOL)readOnly autoSave:(BOOL)autoSave;
		[Export ("openFromAssets:atPage:withPassword:readOnly:autoSave:")]
		NSObject OpenFromAssets (string file, int page, string password, bool readOnly, bool autoSave);

		// -(id)openFromAssets:(NSString *)file atPage:(int)page withPassword:(NSString *)password readOnly:(BOOL)readOnly autoSave:(BOOL)autoSave author:(NSString *)author;
		[Export ("openFromAssets:atPage:withPassword:readOnly:autoSave:author:")]
		NSObject OpenFromAssets (string file, int page, string password, bool readOnly, bool autoSave, string author);

		// -(id)openFromPath:(NSString *)path withPassword:(NSString *)password;
		[Export ("openFromPath:withPassword:")]
		NSObject OpenFromPath (string path, string password);

		// -(id)openFromPath:(NSString *)file atPage:(int)page withPassword:(NSString *)password readOnly:(BOOL)readOnly autoSave:(BOOL)autoSave author:(NSString *)author;
		[Export ("openFromPath:atPage:withPassword:readOnly:autoSave:author:")]
		NSObject OpenFromPath (string file, int page, string password, bool readOnly, bool autoSave, string author);

		// -(id)openFromMem:(NSData *)data withPassword:(NSString *)password;
		[Export ("openFromMem:withPassword:")]
		NSObject OpenFromMem (NSData data, string password);

		// -(NSString *)fileState;
		[Export ("fileState")]
		
		string FileState { get; }

		// -(int)getPageNumber;
		[Export ("getPageNumber")]
		
		int PageNumber { get; }

		// -(int)getPageCount;
		[Export ("getPageCount")]
		
		int PageCount { get; }

		// -(void)setThumbnailBGColor:(int)color;
		[Export ("setThumbnailBGColor:")]
		void SetThumbnailBGColor (int color);

		// -(void)setThumbGridBGColor:(int)color;
		[Export ("setThumbGridBGColor:")]
		void SetThumbGridBGColor (int color);

		// -(void)setReaderBGColor:(int)color;
		[Export ("setReaderBGColor:")]
		void SetReaderBGColor (int color);

		// -(void)setThumbGridElementHeight:(float)height;
		[Export ("setThumbGridElementHeight:")]
		void SetThumbGridElementHeight (float height);

		// -(void)setThumbGridGap:(float)gap;
		[Export ("setThumbGridGap:")]
		void SetThumbGridGap (float gap);

		// -(void)setThumbGridViewMode:(int)mode;
		[Export ("setThumbGridViewMode:")]
		void SetThumbGridViewMode (int mode);

		// -(void)setTitleBGColor:(int)color;
		[Export ("setTitleBGColor:")]
		void SetTitleBGColor (int color);

		// -(void)setIconsBGColor:(int)color;
		[Export ("setIconsBGColor:")]
		void SetIconsBGColor (int color);

		// -(void)setThumbHeight:(float)height;
		[Export ("setThumbHeight:")]
		void SetThumbHeight (float height);

		// -(void)setFirstPageCover:(BOOL)cover;
		[Export ("setFirstPageCover:")]
		void SetFirstPageCover (bool cover);

		// -(void)setDoubleTapZoomMode:(int)mode;
		[Export ("setDoubleTapZoomMode:")]
		void SetDoubleTapZoomMode (int mode);

		// -(void)setImmersive:(BOOL)immersive;
		[Export ("setImmersive:")]
		void SetImmersive (bool immersive);

		// -(BOOL)setReaderViewMode:(int)mode;
		[Export ("setReaderViewMode:")]
		bool SetReaderViewMode (int mode);

		// -(void)setToolbarEnabled:(BOOL)enabled;
		[Export ("setToolbarEnabled:")]
		void SetToolbarEnabled (bool enabled);

		// -(NSString *)extractTextFromPage:(int)pageNum;
		[Export ("extractTextFromPage:")]
		string ExtractTextFromPage (int pageNum);

		// -(BOOL)encryptDocAs:(NSString *)path userPwd:(NSString *)userPwd ownerPwd:(NSString *)ownerPwd permission:(int)permission method:(int)method idString:(NSString *)idString;
		[Export ("encryptDocAs:userPwd:ownerPwd:permission:method:idString:")]
		bool EncryptDocAs (string path, string userPwd, string ownerPwd, int permission, int method, string idString);

		// -(BOOL)addAnnotAttachment:(NSString *)path;
		[Export ("addAnnotAttachment:")]
		bool AddAnnotAttachment (string path);

		// -(BOOL)renderAnnotToFile:(int)index atPage:(int)pageno savePath:(NSString *)path size:(CGSize)size;
		[Export ("renderAnnotToFile:atPage:savePath:size:")]
		bool RenderAnnotToFile (int index, int pageno, string path, CGSize size);

		// -(BOOL)flatAnnots;
		[Export ("flatAnnots")]
		
		bool FlatAnnots { get; }

		// -(BOOL)flatAnnotAtPage:(int)pageno;
		[Export ("flatAnnotAtPage:")]
		bool FlatAnnotAtPage (int pageno);

		// -(BOOL)saveDocumentToPath:(NSString *)path;
		[Export ("saveDocumentToPath:")]
		bool SaveDocumentToPath (string path);

		// -(NSString *)getJSONFormFields;
		[Export ("getJSONFormFields")]
		
		string JSONFormFields { get; }

		// -(NSString *)getJSONFormFieldsAtPage:(int)page;
		[Export ("getJSONFormFieldsAtPage:")]
		string GetJSONFormFieldsAtPage (int page);

		// -(NSString *)setFormFieldWithJSON:(NSString *)json;
		[Export ("setFormFieldWithJSON:")]
		string SetFormFieldWithJSON (string json);

		// +(NSMutableArray *)loadBookmarkForPdf:(NSString *)pdfName withPath:(BOOL)withPath;
		[Static]
		[Export ("loadBookmarkForPdf:withPath:")]
		NSMutableArray LoadBookmarkForPdf (string pdfName, bool withPath);

		// +(NSString *)addToBookmarks:(NSString *)pdfPath page:(int)page label:(NSString *)label;
		[Static]
		[Export ("addToBookmarks:page:label:")]
		string AddToBookmarks (string pdfPath, int page, string label);

		// +(void)removeBookmark:(int)page pdfPath:(NSString *)pdfPath;
		[Static]
		[Export ("removeBookmark:pdfPath:")]
		void RemoveBookmark (int page, string pdfPath);

		// +(NSString *)getBookmarks:(NSString *)pdfPath;
		[Static]
		[Export ("getBookmarks:")]
		string GetBookmarks (string pdfPath);

		// -(void)setPagingEnabled:(BOOL)enabled;
		[Export ("setPagingEnabled:")]
		void SetPagingEnabled (bool enabled);

		// -(void)setDoublePageEnabled:(BOOL)enabled;
		[Export ("setDoublePageEnabled:")]
		void SetDoublePageEnabled (bool enabled);

		// -(void)toggleThumbSeekBar:(int)mode;
		[Export ("toggleThumbSeekBar:")]
		void ToggleThumbSeekBar (int mode);

		// -(void)setColor:(int)color forFeature:(int)feature;
		[Export ("setColor:forFeature:")]
		void SetColor (int color, int feature);

		// -(void)setDelegate:(id)myDelegate;
		[Export ("setDelegate:")]
		void SetDelegate (NSObject myDelegate);

		// -(void)refreshCurrentPage;
		[Export ("refreshCurrentPage")]
		void RefreshCurrentPage ();

		// -(id)getGlobal;
		[Export ("getGlobal")]
		
		NSObject Global { get; }
	}

	// @interface RDToolbar : UIToolbar
	[BaseType(typeof(UIToolbar))]
	[Protocol]
	interface RDToolbar
	{
		// @property (nonatomic, weak) UIView * _Nullable shadow __attribute__((iboutlet));
		[NullAllowed, Export("shadow", ArgumentSemantic.Weak)]
		UIView Shadow { get; set; }
	}

	// @interface RDPDFCanvas : UIView
	[BaseType(typeof(UIView))]
	interface RDPDFCanvas
	{
	}

	// @interface RDPDFView : UIView
	[BaseType(typeof(UIView))]
	interface RDPDFView
	{
	}

	// @interface RDPDFThumb : RDPDFView
	[BaseType(typeof(RDPDFView))]
	interface RDPDFThumb
	{
	}

	// @interface SearchResultViewController : UIViewController <UITableViewDataSource, UITableViewDelegate>
	[BaseType(typeof(UIViewController))]
	interface SearchResultViewController : IUITableViewDataSource, IUITableViewDelegate
	{

		// @property (nonatomic, strong) UITableView * tableView __attribute__((iboutlet));
		[Export("tableView", ArgumentSemantic.Strong)]
		UITableView TableView { get; set; }

		// -(void)dismissView:(id)sender __attribute__((ibaction));
		[Export("dismissView:")]
		void DismissView(NSObject sender);
	}

	// @interface RDPopupTextViewController : UIViewController
	[BaseType(typeof(UIViewController))]
	interface RDPopupTextViewController
	{
		// @property (nonatomic, strong) UITextField * subjectTextField __attribute__((iboutlet));
		[Export("subjectTextField", ArgumentSemantic.Strong)]
		UITextField SubjectTextField { get; set; }

		// @property (nonatomic, strong) UITextView * textView __attribute__((iboutlet));
		[Export("textView", ArgumentSemantic.Strong)]
		UITextView TextView { get; set; }

		// @property (nonatomic, strong) UIButton * dismissButton __attribute__((iboutlet));
		[Export("dismissButton", ArgumentSemantic.Strong)]
		UIButton DismissButton { get; set; }

		// -(void)dismissView:(id)sender __attribute__((ibaction));
		[Export("dismissView:")]
		void DismissView(NSObject sender);
	}

	// @interface RDTreeViewController : UIViewController <UITableViewDataSource, UITableViewDelegate>
	[BaseType(typeof(UIViewController))]
	interface RDTreeViewController : IUITableViewDataSource, IUITableViewDelegate
	{

		// @property (nonatomic, strong) UITableView * _Nonnull tableView __attribute__((iboutlet));
		[Export("tableView", ArgumentSemantic.Strong)]
		UITableView TableView { get; set; }

		// -(void)dismissView:(id _Nonnull)sender __attribute__((ibaction));
		[Export("dismissView:")]
		void DismissView(NSObject sender);
	}

	// @interface PDFReaderCtrl : UIViewController
	[BaseType(typeof(UIViewController))]
	interface PDFReaderCtrl
	{
		// __weak IBOutlet RDPDFView *mView;
		[Export("mView", ArgumentSemantic.Strong)]
		RDPDFView MView { get; set; }

		//__weak IBOutlet RDPDFThumb* mThumb;
		[Export("mThumb", ArgumentSemantic.Strong)]
		RDPDFThumb MThumb { get; set; }

		//__weak IBOutlet UIView* mSliderView;
		[Export("mSliderView", ArgumentSemantic.Strong)]
		UIView MSliderView { get; set; }

		//__weak IBOutlet UISlider* mSlider;
		[Export("mSlider", ArgumentSemantic.Strong)]
		UISlider MSlider { get; set; }

		//__weak IBOutlet UILabel* mSliderLabel;
		[Export("mSliderLabel", ArgumentSemantic.Strong)]
		UILabel MSliderLabel { get; set; }

		//__weak IBOutlet UIToolbar* mBarNoneTop;
		[Export("mBarNoneTop", ArgumentSemantic.Strong)]
		UIToolbar MBarNoneTop { get; set; }

		//__weak IBOutlet RDToolbar* mBarNoneBottom;
		[Export("mBarNoneBottom", ArgumentSemantic.Strong)]
		RDToolbar MBarNoneBottom { get; set; }

		//__weak IBOutlet UIBarButtonItem* mBarThumbButton;
		[Export("mBarThumbButton", ArgumentSemantic.Strong)]
		UIBarButtonItem MBarThumbButton { get; set; }

		//__weak IBOutlet RDToolbar* mBarAnnot;
		[Export("mBarAnnot", ArgumentSemantic.Strong)]
		RDToolbar MBarAnnot { get; set; }

		//__weak IBOutlet UIBarButtonItem* mBarAnnotColorButton;
		[Export("mBarAnnotColorButton", ArgumentSemantic.Strong)]
		UIBarButtonItem MBarAnnotColorButton { get; set; }

		//__weak IBOutlet UIBarButtonItem* mBarAnnotDoneButton;
		[Export("mBarAnnotDoneButton", ArgumentSemantic.Strong)]
		UIBarButtonItem MBarAnnotDoneButton { get; set; }

		//__weak IBOutlet UIToolbar* mBarSearchTop;
		[Export("mBarSearchTop", ArgumentSemantic.Strong)]
		UIToolbar MBarSearchTop { get; set; }

		//__weak IBOutlet RDToolbar* mBarSearchBottom;
		[Export("mBarSearchBottom", ArgumentSemantic.Strong)]
		RDToolbar MBarSearchBottom { get; set; }

		//__weak IBOutlet UIBarButtonItem* mBarSearchResults;
		[Export("mBarSearchResults", ArgumentSemantic.Strong)]
		UIBarButtonItem MBarSearchResults { get; set; }

		//__weak IBOutlet UITextField* mSearchText;
		[Export("mSearchText", ArgumentSemantic.Strong)]
		UITextField MSearchText { get; set; }

		//__weak IBOutlet UIButton* mSearchWhole;
		[Export("mSearchWhole", ArgumentSemantic.Strong)]
		UIButton MSearchWhole { get; set; }

		//__weak IBOutlet UIButton* mSearchCase;
		[Export("mSearchCase", ArgumentSemantic.Strong)]
		UIButton MSearchCase { get; set; }

		//__weak IBOutlet UIBarButtonItem* fileName;
		[Export("fileName", ArgumentSemantic.Strong)]
		UIBarButtonItem FileName { get; set; }

		//__weak IBOutlet UIBarButtonItem* mBtnBack;
		[Export("mBtnBack", ArgumentSemantic.Strong)]
		UIBarButtonItem MBtnBack { get; set; }

		//__weak IBOutlet UIBarButtonItem* mBtnCancel;
		[Export("mBtnCancel", ArgumentSemantic.Strong)]
		UIBarButtonItem MBtnCancel { get; set; }

		//__weak IBOutlet UIBarButtonItem* mBtnDone;
		[Export("mBtnDone", ArgumentSemantic.Strong)]
		UIBarButtonItem MBtnDone { get; set; }

		//__weak IBOutlet UIBarButtonItem* mBtnPrev;
		[Export("mBtnPrev", ArgumentSemantic.Strong)]
		UIBarButtonItem MBtnPrev { get; set; }

		//__weak IBOutlet UIBarButtonItem* mBtnNext;
		[Export("mBtnNext", ArgumentSemantic.Strong)]
		UIBarButtonItem MBtnNext { get; set; }

		// @property (nonatomic, strong) UIImage * closeImage;
		[Export("closeImage", ArgumentSemantic.Strong)]
		UIImage CloseImage { get; set; }

		// @property (nonatomic, strong) UIImage * viewModeImage;
		[Export("viewModeImage", ArgumentSemantic.Strong)]
		UIImage ViewModeImage { get; set; }

		// @property (nonatomic, strong) UIImage * searchImage;
		[Export("searchImage", ArgumentSemantic.Strong)]
		UIImage SearchImage { get; set; }

		// @property (nonatomic, strong) UIImage * bookmarkImage;
		[Export("bookmarkImage", ArgumentSemantic.Strong)]
		UIImage BookmarkImage { get; set; }

		// @property (nonatomic, strong) UIImage * addBookmarkImage;
		[Export("addBookmarkImage", ArgumentSemantic.Strong)]
		UIImage AddBookmarkImage { get; set; }

		// @property (nonatomic, strong) UIImage * outlineImage;
		[Export("outlineImage", ArgumentSemantic.Strong)]
		UIImage OutlineImage { get; set; }

		// @property (nonatomic, strong) UIImage * lineImage;
		[Export("lineImage", ArgumentSemantic.Strong)]
		UIImage LineImage { get; set; }

		// @property (nonatomic, strong) UIImage * rowImage;
		[Export("rowImage", ArgumentSemantic.Strong)]
		UIImage RowImage { get; set; }

		// @property (nonatomic, strong) UIImage * rectImage;
		[Export("rectImage", ArgumentSemantic.Strong)]
		UIImage RectImage { get; set; }

		// @property (nonatomic, strong) UIImage * ellipseImage;
		[Export("ellipseImage", ArgumentSemantic.Strong)]
		UIImage EllipseImage { get; set; }

		// @property (nonatomic, strong) UIImage * bitmapImage;
		[Export("bitmapImage", ArgumentSemantic.Strong)]
		UIImage BitmapImage { get; set; }

		// @property (nonatomic, strong) UIImage * noteImage;
		[Export("noteImage", ArgumentSemantic.Strong)]
		UIImage NoteImage { get; set; }

		// @property (nonatomic, strong) UIImage * signatureImage;
		[Export("signatureImage", ArgumentSemantic.Strong)]
		UIImage SignatureImage { get; set; }

		// @property (nonatomic, strong) UIImage * printImage;
		[Export("printImage", ArgumentSemantic.Strong)]
		UIImage PrintImage { get; set; }

		// @property (nonatomic, strong) UIImage * shareImage;
		[Export("shareImage", ArgumentSemantic.Strong)]
		UIImage ShareImage { get; set; }

		// @property (nonatomic, strong) UIImage * gridImage;
		[Export("gridImage", ArgumentSemantic.Strong)]
		UIImage GridImage { get; set; }

		// @property (nonatomic, strong) UIImage * deleteImage;
		[Export("deleteImage", ArgumentSemantic.Strong)]
		UIImage DeleteImage { get; set; }

		// @property (nonatomic, strong) UIImage * doneImage;
		[Export("doneImage", ArgumentSemantic.Strong)]
		UIImage DoneImage { get; set; }

		// @property (nonatomic, strong) UIImage * removeImage;
		[Export("removeImage", ArgumentSemantic.Strong)]
		UIImage RemoveImage { get; set; }

		// @property (nonatomic, strong) UIImage * prevImage;
		[Export("prevImage", ArgumentSemantic.Strong)]
		UIImage PrevImage { get; set; }

		// @property (nonatomic, strong) UIImage * nextImage;
		[Export("nextImage", ArgumentSemantic.Strong)]
		UIImage NextImage { get; set; }

		// @property (nonatomic, strong) UIImage * undoImage;
		[Export("undoImage", ArgumentSemantic.Strong)]
		UIImage UndoImage { get; set; }

		// @property (nonatomic, strong) UIImage * redoImage;
		[Export("redoImage", ArgumentSemantic.Strong)]
		UIImage RedoImage { get; set; }

		// @property (nonatomic, strong) UIImage * performImage;
		[Export("performImage", ArgumentSemantic.Strong)]
		UIImage PerformImage { get; set; }

		// @property (nonatomic, strong) UIImage * moreImage;
		[Export("moreImage", ArgumentSemantic.Strong)]
		UIImage MoreImage { get; set; }

		// @property (nonatomic, strong) UIImage * drawImage;
		[Export("drawImage", ArgumentSemantic.Strong)]
		UIImage DrawImage { get; set; }

		// @property (nonatomic, strong) UIImage * selectImage;
		[Export("selectImage", ArgumentSemantic.Strong)]
		UIImage SelectImage { get; set; }

		// @property (nonatomic, strong) UIImage * saveImage;
		[Export("saveImage", ArgumentSemantic.Strong)]
		UIImage SaveImage { get; set; }

		// @property (nonatomic, strong) UIImage * metaImage;
		[Export("metaImage", ArgumentSemantic.Strong)]
		UIImage MetaImage { get; set; }

		// @property (nonatomic) BOOL hideSearchImage;
		[Export("hideSearchImage")]
		bool HideSearchImage { get; set; }

		// @property (nonatomic) BOOL hideDrawImage;
		[Export("hideDrawImage")]
		bool HideDrawImage { get; set; }

		// @property (nonatomic) BOOL hideSelImage;
		[Export("hideSelImage")]
		bool HideSelImage { get; set; }

		// @property (nonatomic) BOOL hideUndoImage;
		[Export("hideUndoImage")]
		bool HideUndoImage { get; set; }

		// @property (nonatomic) BOOL hideRedoImage;
		[Export("hideRedoImage")]
		bool HideRedoImage { get; set; }

		// @property (nonatomic) BOOL hideMoreImage;
		[Export("hideMoreImage")]
		bool HideMoreImage { get; set; }

		// @property (nonatomic) BOOL hideGridImage;
		[Export("hideGridImage")]
		bool HideGridImage { get; set; }

		// -(void)back_pressed:(id)sender __attribute__((ibaction));
		[Export("back_pressed:")]
		void Back_pressed(NSObject sender);

		// -(void)mode_pressed:(id)sender __attribute__((ibaction));
		[Export("mode_pressed:")]
		void Mode_pressed(NSObject sender);

		// -(void)thumb_pressed:(id)sender __attribute__((ibaction));
		[Export("thumb_pressed:")]
		void Thumb_pressed(NSObject sender);

		// -(void)tool_pressed:(id)sender __attribute__((ibaction));
		[Export("tool_pressed:")]
		void Tool_pressed(NSObject sender);

		// -(void)annot_pressed:(id)sender __attribute__((ibaction));
		[Export("annot_pressed:")]
		void Annot_pressed(NSObject sender);

		// -(void)search_pressed:(id)sender __attribute__((ibaction));
		[Export("search_pressed:")]
		void Search_pressed(NSObject sender);

		// -(void)annot_ok:(id)sender __attribute__((ibaction));
		[Export("annot_ok:")]
		void Annot_ok(NSObject sender);

		// -(void)annot_cancel:(id)sender __attribute__((ibaction));
		[Export("annot_cancel:")]
		void Annot_cancel(NSObject sender);

		// -(void)annot_color:(id)sender __attribute__((ibaction));
		[Export("annot_color:")]
		void Annot_color(NSObject sender);

		// -(void)search_cancel:(id)sender __attribute__((ibaction));
		[Export("search_cancel:")]
		void Search_cancel(NSObject sender);

		// -(void)search_backward:(id)sender __attribute__((ibaction));
		[Export("search_backward:")]
		void Search_backward(NSObject sender);

		// -(void)search_forward:(id)sender __attribute__((ibaction));
		[Export("search_forward:")]
		void Search_forward(NSObject sender);
	}

}
