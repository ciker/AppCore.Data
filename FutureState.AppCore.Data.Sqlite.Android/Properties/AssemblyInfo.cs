using System.Reflection;
using System.Runtime.InteropServices;
using Android;
using Android.App;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.

[assembly: AssemblyTitle("FutureState.AppCore.Data.Sqlite.Android")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("FutureState.AppCore.Data.Sqlite.Android")]
[assembly: AssemblyCopyright("Copyright �  2013")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: ComVisible(false)]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("0.1.1")]

[assembly: AssemblyVersion("0.1.1")]
[assembly: AssemblyFileVersion("0.1.1.1")]

// Add some common permissions, these can be removed if not needed

[assembly: UsesPermission(Manifest.Permission.Internet)]
[assembly: UsesPermission(Manifest.Permission.WriteExternalStorage)]
