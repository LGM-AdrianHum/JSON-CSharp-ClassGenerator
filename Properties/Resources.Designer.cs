﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Xamasoft.JsonClassGenerator.UI.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Xamasoft.JsonClassGenerator.UI.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Unable to generate the code: .
        /// </summary>
        internal static string CantGenerateCode {
            get {
                return ResourceManager.GetString("CantGenerateCode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please select a folder where to save the generated files..
        /// </summary>
        internal static string FrmCSharpClassGeneration_btnBrowse_Click_Please_select_a_folder_where_to_save_the_generated_files_ {
            get {
                return ResourceManager.GetString("FrmCSharpClassGeneration_btnBrowse_Click_Please_select_a_folder_where_to_save_the" +
                        "_generated_files_", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please insert some sample JSON..
        /// </summary>
        internal static string GiveJsonSample {
            get {
                return ResourceManager.GetString("GiveJsonSample", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap help {
            get {
                object obj = ResourceManager.GetObject("help", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap logo {
            get {
                object obj = ResourceManager.GetObject("logo", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please specify a main class name..
        /// </summary>
        internal static string SpecifyMainClass {
            get {
                return ResourceManager.GetString("SpecifyMainClass", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please specify a namespace..
        /// </summary>
        internal static string SpecifyNamespace {
            get {
                return ResourceManager.GetString("SpecifyNamespace", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please specify an output directory..
        /// </summary>
        internal static string SpecifyOutputDirectory {
            get {
                return ResourceManager.GetString("SpecifyOutputDirectory", resourceCulture);
            }
        }
    }
}
