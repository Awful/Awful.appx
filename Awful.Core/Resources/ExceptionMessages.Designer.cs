﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Awful.Core.Resources {
    using System;
    using System.Reflection;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class ExceptionMessages {
        
        private static System.Resources.ResourceManager resourceMan;
        
        private static System.Globalization.CultureInfo resourceCulture;
        
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ExceptionMessages() {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public static System.Resources.ResourceManager ResourceManager {
            get {
                if (object.Equals(null, resourceMan)) {
                    System.Resources.ResourceManager temp = new System.Resources.ResourceManager("Awful.Core.Resources.ExceptionMessages", typeof(ExceptionMessages).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public static System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        public static string ForumSelectorMissing {
            get {
                return ResourceManager.GetString("ForumSelectorMissing", resourceCulture);
            }
        }
        
        public static string ForumTableMissing {
            get {
                return ResourceManager.GetString("ForumTableMissing", resourceCulture);
            }
        }
        
        public static string PaywallThreadHit {
            get {
                return ResourceManager.GetString("PaywallThreadHit", resourceCulture);
            }
        }
        
        public static string PostIdMissing {
            get {
                return ResourceManager.GetString("PostIdMissing", resourceCulture);
            }
        }
        
        public static string ThreadAndPostIdMissing {
            get {
                return ResourceManager.GetString("ThreadAndPostIdMissing", resourceCulture);
            }
        }
        
        public static string ThreadIdMissing {
            get {
                return ResourceManager.GetString("ThreadIdMissing", resourceCulture);
            }
        }
        
        public static string ThreadListMissing {
            get {
                return ResourceManager.GetString("ThreadListMissing", resourceCulture);
            }
        }
        
        public static string UserAuthenticationError {
            get {
                return ResourceManager.GetString("UserAuthenticationError", resourceCulture);
            }
        }
        
        public static string AwfulClientError {
            get {
                return ResourceManager.GetString("AwfulClientError", resourceCulture);
            }
        }
    }
}
