﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProcessKiller.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ProcessKiller.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 正在关闭此进程....
        /// </summary>
        internal static string MainForm_button_click_KillingProcessMessage {
            get {
                return ResourceManager.GetString("MainForm_button_click_KillingProcessMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 点我切换至该窗口或按F4掉线.
        /// </summary>
        internal static string MainForm_InitializeButtons_ClickToKillProcessMessage {
            get {
                return ResourceManager.GetString("MainForm_InitializeButtons_ClickToKillProcessMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 南方电信一区 柒才 flyingeek@live.com.
        /// </summary>
        internal static string MainForm_InitializeCopyRightLabel_CopyrightMessage {
            get {
                return ResourceManager.GetString("MainForm_InitializeCopyRightLabel_CopyrightMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 未发现龙之谷进程，列表将在游戏启动后自动更新，无须重启本程序。.
        /// </summary>
        internal static string MainForm_InitializeDefaultTextLabel_DefaultTextLabelMessage {
            get {
                return ResourceManager.GetString("MainForm_InitializeDefaultTextLabel_DefaultTextLabelMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 当前版本: 1.1.0.
        /// </summary>
        internal static string MainForm_InitializeVersionLabel_Version {
            get {
                return ResourceManager.GetString("MainForm_InitializeVersionLabel_Version", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 请右键以管理员身份打开此程序.
        /// </summary>
        internal static string Program_ShowAdminErrorDialogBox_AdminPrivilegeMessage {
            get {
                return ResourceManager.GetString("Program_ShowAdminErrorDialogBox_AdminPrivilegeMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 龙之谷掉线器.
        /// </summary>
        internal static string Program_ShowAdminErrorDialogBox_ApplicationName {
            get {
                return ResourceManager.GetString("Program_ShowAdminErrorDialogBox_ApplicationName", resourceCulture);
            }
        }
    }
}
