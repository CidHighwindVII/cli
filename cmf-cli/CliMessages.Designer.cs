﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cmf.CLI {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class CliMessages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal CliMessages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Cmf.CLI.CliMessages", typeof(CliMessages).Assembly);
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
        ///   Looks up a localized string similar to Get Package {0}.{1}....
        /// </summary>
        internal static string GetPackage {
            get {
                return ResourceManager.GetString("GetPackage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Missing mandatory option {0}.
        /// </summary>
        internal static string MissingMandatoryOption {
            get {
                return ResourceManager.GetString("MissingMandatoryOption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Missing mandatory properties: {0}.
        /// </summary>
        internal static string MissingMandatoryProperties {
            get {
                return ResourceManager.GetString("MissingMandatoryProperties", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Missing mandatory property {0}.
        /// </summary>
        internal static string MissingMandatoryProperty {
            get {
                return ResourceManager.GetString("MissingMandatoryProperty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This is not a root package.
        /// </summary>
        internal static string NotARootPackage {
            get {
                return ResourceManager.GetString("NotARootPackage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Package {0}.{1} has no test packages.
        /// </summary>
        internal static string PackageHasNoTestPackages {
            get {
                return ResourceManager.GetString("PackageHasNoTestPackages", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Some packages were not found: {0}.
        /// </summary>
        internal static string SomePackagesNotFound {
            get {
                return ResourceManager.GetString("SomePackagesNotFound", resourceCulture);
            }
        }
    }
}
