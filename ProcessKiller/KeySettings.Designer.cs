﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProcessKiller {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed partial class KeySettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static KeySettings defaultInstance = ((KeySettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new KeySettings())));
        
        public static KeySettings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("119")]
        public int ProcessKillerKey {
            get {
                return ((int)(this["ProcessKillerKey"]));
            }
            set {
                this["ProcessKillerKey"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("116")]
        public int CountDownKey {
            get {
                return ((int)(this["CountDownKey"]));
            }
            set {
                this["CountDownKey"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string GameDicPath {
            get {
                return ((string)(this["GameDicPath"]));
            }
            set {
                this["GameDicPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string ServerName {
            get {
                return ((string)(this["ServerName"]));
            }
            set {
                this["ServerName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool IsFirstTimeClickOnStartButton {
            get {
                return ((bool)(this["IsFirstTimeClickOnStartButton"]));
            }
            set {
                this["IsFirstTimeClickOnStartButton"] = value;
            }
        }
    }
}