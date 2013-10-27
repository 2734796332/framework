﻿using System;
using System.Reflection;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("Beat detection sample application")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Accord.NET")]
[assembly: AssemblyProduct("Accord.NET Framework")]
[assembly: AssemblyCopyright("Copyright © César Souza, 2009-2013")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

[assembly: AssemblyDescription(
@"A simple beat detector which listens to the default input device and tries to detect peaks in the audio signal. It is a statistics based beat detector in the sense it searches local energy peaks which may contain a beat. 

The application also demonstrates the usage of the Metronome class of the framework, which allows one to detect the current tempo by 'tapping' the metronome.")]



// This sets the default COM visibility of types in the assembly to invisible.
// If you need to expose a type to COM, use [ComVisible(true)] on that type.
[assembly: ComVisible(false)]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
[assembly: AssemblyVersion("1.0.0.0")]