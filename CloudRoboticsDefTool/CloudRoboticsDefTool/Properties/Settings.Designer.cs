﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.42000
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace CloudRoboticsDefTool.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string Microsoft_IoTHub_ConnectionString {
            get {
                return ((string)(this["Microsoft_IoTHub_ConnectionString"]));
            }
            set {
                this["Microsoft_IoTHub_ConnectionString"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string Microsoft_SqlDb_ConnectionString {
            get {
                return ((string)(this["Microsoft_SqlDb_ConnectionString"]));
            }
            set {
                this["Microsoft_SqlDb_ConnectionString"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string Microsoft_QStorage_ConnectionString {
            get {
                return ((string)(this["Microsoft_QStorage_ConnectionString"]));
            }
            set {
                this["Microsoft_QStorage_ConnectionString"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string Microsoft_SqlDb_EncPassphrase {
            get {
                return ((string)(this["Microsoft_SqlDb_EncPassphrase"]));
            }
            set {
                this["Microsoft_SqlDb_EncPassphrase"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string CloudRoboticsFx_TraceStorageAccount {
            get {
                return ((string)(this["CloudRoboticsFx_TraceStorageAccount"]));
            }
            set {
                this["CloudRoboticsFx_TraceStorageAccount"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string CloudRoboticsFx_TraceStorageKey {
            get {
                return ((string)(this["CloudRoboticsFx_TraceStorageKey"]));
            }
            set {
                this["CloudRoboticsFx_TraceStorageKey"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string CloudRoboticsFx_TraceTableName {
            get {
                return ((string)(this["CloudRoboticsFx_TraceTableName"]));
            }
            set {
                this["CloudRoboticsFx_TraceTableName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string CloudRobotics_JsonMessages {
            get {
                return ((string)(this["CloudRobotics_JsonMessages"]));
            }
            set {
                this["CloudRobotics_JsonMessages"] = value;
            }
        }
    }
}
