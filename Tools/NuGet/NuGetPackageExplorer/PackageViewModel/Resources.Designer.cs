﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.431
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PackageExplorerViewModel {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("PackageExplorerViewModel.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Are you sure you want to delete &apos;{0}&apos;?.
        /// </summary>
        internal static string ConfirmToDeleteContent {
            get {
                return ResourceManager.GetString("ConfirmToDeleteContent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Do you want to place the file &apos;{0}&apos; into &apos;{1}&apos; folder?.
        /// </summary>
        internal static string ConfirmToMoveFileIntoFolder {
            get {
                return ResourceManager.GetString("ConfirmToMoveFileIntoFolder", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Do you want to replace the existing file?.
        /// </summary>
        internal static string ConfirmToReplaceExsitingFile {
            get {
                return ResourceManager.GetString("ConfirmToReplaceExsitingFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Do you want to replace existing file &apos;{0}&apos; on disk?.
        /// </summary>
        internal static string ConfirmToReplaceFile {
            get {
                return ResourceManager.GetString("ConfirmToReplaceFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to NuGet Package Explorer.
        /// </summary>
        internal static string Dialog_Title {
            get {
                return ResourceManager.GetString("Dialog_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The operation cannot be completed because the edit form has some invalid input..
        /// </summary>
        internal static string EditFormHasInvalidInput {
            get {
                return ResourceManager.GetString("EditFormHasInvalidInput", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This package has been exported successfully..
        /// </summary>
        internal static string ExportPackageSuccess {
            get {
                return ResourceManager.GetString("ExportPackageSuccess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The new file has the same name as another folder..
        /// </summary>
        internal static string FileNameConflictWithExistingDirectory {
            get {
                return ResourceManager.GetString("FileNameConflictWithExistingDirectory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Network connection is not detected..
        /// </summary>
        internal static string NoNetworkConnection {
            get {
                return ResourceManager.GetString("NoNetworkConnection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Opening this file can potentially harm your computer. Do you want to continue?.
        /// </summary>
        internal static string OpenExecutableScriptWarning {
            get {
                return ResourceManager.GetString("OpenExecutableScriptWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There are no contents or dependencies in the package..
        /// </summary>
        internal static string PackageHasNoFile {
            get {
                return ResourceManager.GetString("PackageHasNoFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The file &apos;{0}&apos; was either renamed or deleted from its physical location. It will now be removed from the package..
        /// </summary>
        internal static string PhysicalFileMissing {
            get {
                return ResourceManager.GetString("PhysicalFileMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There is another file or folder with the same name..
        /// </summary>
        internal static string RenameCausesNameCollison {
            get {
                return ResourceManager.GetString("RenameCausesNameCollison", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to *** The format of this file is not supported. ***.
        /// </summary>
        internal static string UnsupportedFormatMessage {
            get {
                return ResourceManager.GetString("UnsupportedFormatMessage", resourceCulture);
            }
        }
    }
}
