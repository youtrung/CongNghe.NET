﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLNhaSach.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
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
        public string TaiKhoan {
            get {
                return ((string)(this["TaiKhoan"]));
            }
            set {
                this["TaiKhoan"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string MatKhau {
            get {
                return ((string)(this["MatKhau"]));
            }
            set {
                this["MatKhau"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=.\\SQLEXPRESS;Initial Catalog=C:\\USERS\\DELL\\DESKTOP\\QLNS\\QLNHASACH\\QLN" +
            "HASACH\\QLNHASACH\\QLNS.MDF;Integrated Security=True")]
        public string C__USERS_DELL_DESKTOP_QLNS_QLNHASACH_QLNHASACH_QLNHASACH_QLNS_MDFConnectionString {
            get {
                return ((string)(this["C__USERS_DELL_DESKTOP_QLNS_QLNHASACH_QLNHASACH_QLNHASACH_QLNS_MDFConnectionString" +
                    ""]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=.;Initial Catalog=QuanLyBanSach;Integrated Security=True")]
        public string QuanLyBanSachConnectionString {
            get {
                return ((string)(this["QuanLyBanSachConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=DESKTOP-5URLHEN\\SQLEXPRESS;Initial Catalog=QuanLyQuanCafe;Integrated " +
            "Security=True")]
        public string QuanLyQuanCafeConnectionString {
            get {
                return ((string)(this["QuanLyQuanCafeConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=.;Initial Catalog=QLNHASACH;Integrated Security=True")]
        public string QLNHASACHConnectionString {
            get {
                return ((string)(this["QLNHASACHConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=DESKTOP-VOAB2UJ\\SQLEXPRESS;Initial Catalog=QLNHASACH;Integrated Secur" +
            "ity=True")]
        public string QLNHASACHConnectionString1 {
            get {
                return ((string)(this["QLNHASACHConnectionString1"]));
            }
        }
    }
}
