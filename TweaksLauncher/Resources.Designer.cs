﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TweaksLauncher {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("TweaksLauncher.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to using TweaksLauncher;
        ///
        /////namespace
        ///
        ///public class Main : IMod
        ///{
        ///    // Register hooks and events in this function
        ///    public static void Initialize(ModInstance mod)
        ///    {
        ///        ModLogger.Log(&quot;Hello World!&quot;);
        ///    }
        ///}.
        /// </summary>
        internal static string Main_cs {
            get {
                return ResourceManager.GetString("Main.cs", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;Project Sdk=&quot;Microsoft.NET.Sdk&quot;&gt;
        ///
        ///    &lt;PropertyGroup&gt;
        ///        &lt;TargetFramework&gt;net8.0&lt;/TargetFramework&gt;
        ///        &lt;ImplicitUsings&gt;enable&lt;/ImplicitUsings&gt;
        ///        &lt;AllowUnsafeBlocks&gt;true&lt;/AllowUnsafeBlocks&gt;
        ///    &lt;/PropertyGroup&gt;
        ///
        ///    &lt;ItemGroup&gt;
        ///        &lt;Reference Include=&quot;TweaksLauncher.Mod&quot; HintPath=&quot;../../../TweaksLauncher.Mod.dll&quot; Private=&quot;False&quot; /&gt;
        ///        &lt;Reference Include=&quot;Il2CppInterop.Runtime&quot; HintPath=&quot;../../../Il2CppInterop.Runtime.dll&quot; Private=&quot;False&quot; /&gt;
        ///        &lt;Reference Include=&quot;0Har [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Project_csproj {
            get {
                return ResourceManager.GetString("Project.csproj", resourceCulture);
            }
        }
    }
}
