﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MoneyBin2.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.DateTime ExportacaoUltimaData {
            get {
                return ((global::System.DateTime)(this["ExportacaoUltimaData"]));
            }
            set {
                this["ExportacaoUltimaData"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int BalanceUltimaConta {
            get {
                return ((int)(this["BalanceUltimaConta"]));
            }
            set {
                this["BalanceUltimaConta"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool MainBarraFerramentasVisivel {
            get {
                return ((bool)(this["MainBarraFerramentasVisivel"]));
            }
            set {
                this["MainBarraFerramentasVisivel"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool MainBarraFerramentasImagem {
            get {
                return ((bool)(this["MainBarraFerramentasImagem"]));
            }
            set {
                this["MainBarraFerramentasImagem"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool MainBackgroundRodizio {
            get {
                return ((bool)(this["MainBackgroundRodizio"]));
            }
            set {
                this["MainBackgroundRodizio"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool MainBackgroundVisivel {
            get {
                return ((bool)(this["MainBackgroundVisivel"]));
            }
            set {
                this["MainBackgroundVisivel"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("D:\\Users\\Nelson Frick\\SkyDrive\\Documents\\Financeiro\\Pagamentos")]
        public string CalendarioPastaPagamentos {
            get {
                return ((string)(this["CalendarioPastaPagamentos"]));
            }
            set {
                this["CalendarioPastaPagamentos"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int BalanceContaPadrao {
            get {
                return ((int)(this["BalanceContaPadrao"]));
            }
            set {
                this["BalanceContaPadrao"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool BalanceUsarContaPadrao {
            get {
                return ((bool)(this["BalanceUsarContaPadrao"]));
            }
            set {
                this["BalanceUsarContaPadrao"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public int InvestimentosUltimaConta {
            get {
                return ((int)(this["InvestimentosUltimaConta"]));
            }
            set {
                this["InvestimentosUltimaConta"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("D:\\Users\\Nelson Frick\\SkyDrive\\Documents\\Financeiro\\Extratos")]
        public string InvestimentosBalancePath {
            get {
                return ((string)(this["InvestimentosBalancePath"]));
            }
            set {
                this["InvestimentosBalancePath"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.WebServiceUrl)]
        [global::System.Configuration.DefaultSettingValueAttribute("http://tyger-i7:80/ReportServer/ReportService2005.asmx")]
        public string MoneyBin2_RepServiceNF_ReportingService2005 {
            get {
                return ((string)(this["MoneyBin2_RepServiceNF_ReportingService2005"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int InvestimentosContaPadrao {
            get {
                return ((int)(this["InvestimentosContaPadrao"]));
            }
            set {
                this["InvestimentosContaPadrao"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool InvestimentosUsarContaPadrao {
            get {
                return ((bool)(this["InvestimentosUsarContaPadrao"]));
            }
            set {
                this["InvestimentosUsarContaPadrao"] = value;
            }
        }
    }
}
