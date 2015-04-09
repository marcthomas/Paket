﻿namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("Paket.Core")>]
[<assembly: AssemblyProductAttribute("Paket")>]
[<assembly: AssemblyCompanyAttribute("Paket team")>]
[<assembly: AssemblyDescriptionAttribute("A package dependency manager for .NET with support for NuGet packages and GitHub repositories.")>]
[<assembly: AssemblyVersionAttribute("0.40.0")>]
[<assembly: AssemblyFileVersionAttribute("0.40.0")>]
[<assembly: AssemblyInformationalVersionAttribute("0.40.0")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "0.40.0"
