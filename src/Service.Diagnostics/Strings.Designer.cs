﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.AspNetCore.Diagnostics.Identity.Service {
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
    internal class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.AspNetCore.Diagnostics.Identity.Service.Strings", typeof(Strings).Assembly);
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
        ///   Looks up a localized string similar to Developer certificate.
        /// </summary>
        internal static string CertificateErrorPage_Title {
            get {
                return ResourceManager.GetString("CertificateErrorPage_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Create certificate.
        /// </summary>
        internal static string CreateCertificate {
            get {
                return ResourceManager.GetString("CreateCertificate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Done.
        /// </summary>
        internal static string CreateCertificateDone {
            get {
                return ResourceManager.GetString("CreateCertificateDone", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Certificate creation failed..
        /// </summary>
        internal static string CreateCertificateFailed {
            get {
                return ResourceManager.GetString("CreateCertificateFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Certificate creation succeeded. Try refreshing the page..
        /// </summary>
        internal static string CreateCertificateRefresh {
            get {
                return ResourceManager.GetString("CreateCertificateRefresh", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Creating developer certificate....
        /// </summary>
        internal static string CreateCertificateRunning {
            get {
                return ResourceManager.GetString("CreateCertificateRunning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Identity requires a certificate to sign tokens. You can create a developer certificate by clicking the Create Certificate button to generate a developer certificate for you automatically. This will create a self-signed certificate with subject IdentityService.Development and will add it to your current user personal store.
        ///    Alternatively, you can create this certificate manually with the instructions given in the following link:
        ///    .
        /// </summary>
        internal static string ManualCertificateGenerationInfo {
            get {
                return ResourceManager.GetString("ManualCertificateGenerationInfo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to https://go.microsoft.com/fwlink/?linkid=848037.
        /// </summary>
        internal static string ManualCertificateGenerationInfoLink {
            get {
                return ResourceManager.GetString("ManualCertificateGenerationInfoLink", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The developer certificate is missing or invalid.
        /// </summary>
        internal static string MissingOrInvalidCertificate {
            get {
                return ResourceManager.GetString("MissingOrInvalidCertificate", resourceCulture);
            }
        }
    }
}
