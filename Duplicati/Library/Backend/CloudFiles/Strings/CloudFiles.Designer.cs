﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4952
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Duplicati.Library.Backend.Strings {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class CloudFiles {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal CloudFiles() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Duplicati.Library.Backend.Strings.CloudFiles", typeof(CloudFiles).Assembly);
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
        ///   Looks up a localized string similar to Supports connections to the CloudFiles backend. Allowed formats are &quot;cloudfiles://api.mosso.com/container/folder&quot; or &quot;cloudfiles://username:password@api.mosso.com/container/folder&quot;.
        ///The shorter format &quot;cloudfiles://container/folder&quot; may be used as long as  the container name is a legal hostname, eg. a container name with no spaces..
        /// </summary>
        internal static string Description {
            get {
                return ResourceManager.GetString("Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The password used to connect to the server. This may also be supplied as the environment variable &quot;FTP_PASSWORD&quot;..
        /// </summary>
        internal static string DescriptionFTPPasswordLong {
            get {
                return ResourceManager.GetString("DescriptionFTPPasswordLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Supplies the password used to connect to the server.
        /// </summary>
        internal static string DescriptionFTPPasswordShort {
            get {
                return ResourceManager.GetString("DescriptionFTPPasswordShort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The username used to connect to the server. This may also be supplied as the environment variable &quot;FTP_USERNAME&quot;..
        /// </summary>
        internal static string DescriptionFTPUsernameLong {
            get {
                return ResourceManager.GetString("DescriptionFTPUsernameLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Supplies the username used to connect to the server.
        /// </summary>
        internal static string DescriptionFTPUsernameShort {
            get {
                return ResourceManager.GetString("DescriptionFTPUsernameShort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Supplies the API Access Key used to authenticate with CloudFiles..
        /// </summary>
        internal static string DescriptionPasswordLong {
            get {
                return ResourceManager.GetString("DescriptionPasswordLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Supplies the access key used to connect to the server.
        /// </summary>
        internal static string DescriptionPasswordShort {
            get {
                return ResourceManager.GetString("DescriptionPasswordShort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Supplies the username used to authenticate with CloudFiles..
        /// </summary>
        internal static string DescriptionUsernameLong {
            get {
                return ResourceManager.GetString("DescriptionUsernameLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Supplies the username used to authenticate with CloudFiles.
        /// </summary>
        internal static string DescriptionUsernameShort {
            get {
                return ResourceManager.GetString("DescriptionUsernameShort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CloudFiles.
        /// </summary>
        internal static string DisplayName {
            get {
                return ResourceManager.GetString("DisplayName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to MD5 Hash (ETag) verification failed.
        /// </summary>
        internal static string ETagVerificationError {
            get {
                return ResourceManager.GetString("ETagVerificationError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to delete file.
        /// </summary>
        internal static string FileDeleteError {
            get {
                return ResourceManager.GetString("FileDeleteError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to upload file.
        /// </summary>
        internal static string FileUploadError {
            get {
                return ResourceManager.GetString("FileUploadError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No CloudFiles API Access Key given.
        /// </summary>
        internal static string NoAPIKeyError {
            get {
                return ResourceManager.GetString("NoAPIKeyError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No CloudFiles userID given.
        /// </summary>
        internal static string NoUserIDError {
            get {
                return ResourceManager.GetString("NoUserIDError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unexpected CloudFiles response, perhaps the API has changed?.
        /// </summary>
        internal static string UnexpectedResponseError {
            get {
                return ResourceManager.GetString("UnexpectedResponseError", resourceCulture);
            }
        }
    }
}
