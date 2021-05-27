#### [cmf](index.md 'index')
## Cmf.Common.Cli.Commands Namespace
### Classes
<a name='Cmf_Common_Cli_Commands_BaseCommand'></a>
## BaseCommand Class
```csharp
public abstract class BaseCommand
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; BaseCommand  

Derived  
&#8627; [BuildCommand](Cmf_Common_Cli_Commands.md#Cmf_Common_Cli_Commands_BuildCommand 'Cmf.Common.Cli.Commands.BuildCommand')  
&#8627; [BumpCommand](Cmf_Common_Cli_Commands.md#Cmf_Common_Cli_Commands_BumpCommand 'Cmf.Common.Cli.Commands.BumpCommand')  
&#8627; [BumpCommandIoTCustomization](Cmf_Common_Cli_Commands.md#Cmf_Common_Cli_Commands_BumpCommandIoTCustomization 'Cmf.Common.Cli.Commands.BumpCommandIoTCustomization')  
&#8627; [HelpCommand](Cmf_Common_Cli_Commands.md#Cmf_Common_Cli_Commands_HelpCommand 'Cmf.Common.Cli.Commands.HelpCommand')  
&#8627; [LocalCommand](Cmf_Common_Cli_Commands.md#Cmf_Common_Cli_Commands_LocalCommand 'Cmf.Common.Cli.Commands.LocalCommand')  
&#8627; [PackCommand](Cmf_Common_Cli_Commands.md#Cmf_Common_Cli_Commands_PackCommand 'Cmf.Common.Cli.Commands.PackCommand')  
&#8627; [PluginCommand](Cmf_Common_Cli_Commands.md#Cmf_Common_Cli_Commands_PluginCommand 'Cmf.Common.Cli.Commands.PluginCommand')  
&#8627; [PowershellCommand](Cmf_Common_Cli_Commands.md#Cmf_Common_Cli_Commands_PowershellCommand 'Cmf.Common.Cli.Commands.PowershellCommand')  
### Methods
<a name='Cmf_Common_Cli_Commands_BaseCommand_AddChildCommands(System_CommandLine_Command)'></a>
## BaseCommand.AddChildCommands(Command) Method
Register all available commands, identified using the CmfCommand attribute.  
```csharp
public static void AddChildCommands(System.CommandLine.Command command);
```
#### Parameters
<a name='Cmf_Common_Cli_Commands_BaseCommand_AddChildCommands(System_CommandLine_Command)_command'></a>
`command` [System.CommandLine.Command](https://docs.microsoft.com/en-us/dotnet/api/System.CommandLine.Command 'System.CommandLine.Command')  
Command to which commands will be added
  
  
<a name='Cmf_Common_Cli_Commands_BaseCommand_AddPluginCommands(System_CommandLine_Command)'></a>
## BaseCommand.AddPluginCommands(Command) Method
Adds the plugin commands.  
```csharp
public static void AddPluginCommands(System.CommandLine.Command command);
```
#### Parameters
<a name='Cmf_Common_Cli_Commands_BaseCommand_AddPluginCommands(System_CommandLine_Command)_command'></a>
`command` [System.CommandLine.Command](https://docs.microsoft.com/en-us/dotnet/api/System.CommandLine.Command 'System.CommandLine.Command')  
The command.
  
  
<a name='Cmf_Common_Cli_Commands_BaseCommand_Configure(System_CommandLine_Command)'></a>
## BaseCommand.Configure(Command) Method
Configure command  
```csharp
public abstract void Configure(System.CommandLine.Command cmd);
```
#### Parameters
<a name='Cmf_Common_Cli_Commands_BaseCommand_Configure(System_CommandLine_Command)_cmd'></a>
`cmd` [System.CommandLine.Command](https://docs.microsoft.com/en-us/dotnet/api/System.CommandLine.Command 'System.CommandLine.Command')  
  
  
<a name='Cmf_Common_Cli_Commands_BaseCommand_FindChildCommands(System_Type_System_Collections_Generic_List_System_Type_)'></a>
## BaseCommand.FindChildCommands(Type, List&lt;Type&gt;) Method
Finds the child commands.  
```csharp
private static System.CommandLine.Command FindChildCommands(System.Type cmd, System.Collections.Generic.List<System.Type> commandTypes);
```
#### Parameters
<a name='Cmf_Common_Cli_Commands_BaseCommand_FindChildCommands(System_Type_System_Collections_Generic_List_System_Type_)_cmd'></a>
`cmd` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')  
The command.
  
<a name='Cmf_Common_Cli_Commands_BaseCommand_FindChildCommands(System_Type_System_Collections_Generic_List_System_Type_)_commandTypes'></a>
`commandTypes` [System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')  
The command types.
  
#### Returns
[System.CommandLine.Command](https://docs.microsoft.com/en-us/dotnet/api/System.CommandLine.Command 'System.CommandLine.Command')  
  
  
<a name='Cmf_Common_Cli_Commands_BuildCommand'></a>
## BuildCommand Class
```csharp
public class BuildCommand : Cmf.Common.Cli.Commands.BaseCommand
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [BaseCommand](Cmf_Common_Cli_Commands.md#Cmf_Common_Cli_Commands_BaseCommand 'Cmf.Common.Cli.Commands.BaseCommand') &#129106; BuildCommand  
### Methods
<a name='Cmf_Common_Cli_Commands_BuildCommand_Configure(System_CommandLine_Command)'></a>
## BuildCommand.Configure(Command) Method
Configure command  
```csharp
public override void Configure(System.CommandLine.Command cmd);
```
#### Parameters
<a name='Cmf_Common_Cli_Commands_BuildCommand_Configure(System_CommandLine_Command)_cmd'></a>
`cmd` [System.CommandLine.Command](https://docs.microsoft.com/en-us/dotnet/api/System.CommandLine.Command 'System.CommandLine.Command')  
  
  
<a name='Cmf_Common_Cli_Commands_BuildCommand_Execute(System_IO_DirectoryInfo)'></a>
## BuildCommand.Execute(DirectoryInfo) Method
Executes the specified package path.  
```csharp
public static void Execute(System.IO.DirectoryInfo packagePath);
```
#### Parameters
<a name='Cmf_Common_Cli_Commands_BuildCommand_Execute(System_IO_DirectoryInfo)_packagePath'></a>
`packagePath` [System.IO.DirectoryInfo](https://docs.microsoft.com/en-us/dotnet/api/System.IO.DirectoryInfo 'System.IO.DirectoryInfo')  
The package path.
  
  
#### See Also
- [BaseCommand](Cmf_Common_Cli_Commands.md#Cmf_Common_Cli_Commands_BaseCommand 'Cmf.Common.Cli.Commands.BaseCommand')
  
<a name='Cmf_Common_Cli_Commands_BumpCommand'></a>
## BumpCommand Class
```csharp
public class BumpCommand : Cmf.Common.Cli.Commands.BaseCommand
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [BaseCommand](Cmf_Common_Cli_Commands.md#Cmf_Common_Cli_Commands_BaseCommand 'Cmf.Common.Cli.Commands.BaseCommand') &#129106; BumpCommand  

Derived  
&#8627; [BumpCommandIoTConfiguration](Cmf_Common_Cli_Commands.md#Cmf_Common_Cli_Commands_BumpCommandIoTConfiguration 'Cmf.Common.Cli.Commands.BumpCommandIoTConfiguration')  
### Methods
<a name='Cmf_Common_Cli_Commands_BumpCommand_Configure(System_CommandLine_Command)'></a>
## BumpCommand.Configure(Command) Method
Configure command  
```csharp
public override void Configure(System.CommandLine.Command cmd);
```
#### Parameters
<a name='Cmf_Common_Cli_Commands_BumpCommand_Configure(System_CommandLine_Command)_cmd'></a>
`cmd` [System.CommandLine.Command](https://docs.microsoft.com/en-us/dotnet/api/System.CommandLine.Command 'System.CommandLine.Command')  
  
  
<a name='Cmf_Common_Cli_Commands_BumpCommand_Execute(Cmf_Common_Cli_Objects_CmfPackage_string_string_string_bool)'></a>
## BumpCommand.Execute(CmfPackage, string, string, string, bool) Method
Executes the specified CMF package.  
```csharp
public void Execute(Cmf.Common.Cli.Objects.CmfPackage cmfPackage, string version, string buildNr, string root, bool all);
```
#### Parameters
<a name='Cmf_Common_Cli_Commands_BumpCommand_Execute(Cmf_Common_Cli_Objects_CmfPackage_string_string_string_bool)_cmfPackage'></a>
`cmfPackage` [CmfPackage](Cmf_Common_Cli_Objects.md#Cmf_Common_Cli_Objects_CmfPackage 'Cmf.Common.Cli.Objects.CmfPackage')  
The CMF package.
  
<a name='Cmf_Common_Cli_Commands_BumpCommand_Execute(Cmf_Common_Cli_Objects_CmfPackage_string_string_string_bool)_version'></a>
`version` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The version.
  
<a name='Cmf_Common_Cli_Commands_BumpCommand_Execute(Cmf_Common_Cli_Objects_CmfPackage_string_string_string_bool)_buildNr'></a>
`buildNr` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The version for build Nr.
  
<a name='Cmf_Common_Cli_Commands_BumpCommand_Execute(Cmf_Common_Cli_Objects_CmfPackage_string_string_string_bool)_root'></a>
`root` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The root.
  
<a name='Cmf_Common_Cli_Commands_BumpCommand_Execute(Cmf_Common_Cli_Objects_CmfPackage_string_string_string_bool)_all'></a>
`all` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
if set to `true` [all].
  
#### Exceptions
[CliException](Cmf_Common_Cli_Utilities.md#Cmf_Common_Cli_Utilities_CliException 'Cmf.Common.Cli.Utilities.CliException')  
  
<a name='Cmf_Common_Cli_Commands_BumpCommand_Execute(System_IO_DirectoryInfo_string_string_string_bool)'></a>
## BumpCommand.Execute(DirectoryInfo, string, string, string, bool) Method
Executes the specified package path.  
```csharp
public void Execute(System.IO.DirectoryInfo packagePath, string version, string buildNr, string root, bool all);
```
#### Parameters
<a name='Cmf_Common_Cli_Commands_BumpCommand_Execute(System_IO_DirectoryInfo_string_string_string_bool)_packagePath'></a>
`packagePath` [System.IO.DirectoryInfo](https://docs.microsoft.com/en-us/dotnet/api/System.IO.DirectoryInfo 'System.IO.DirectoryInfo')  
The package path.
  
<a name='Cmf_Common_Cli_Commands_BumpCommand_Execute(System_IO_DirectoryInfo_string_string_string_bool)_version'></a>
`version` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The version.
  
<a name='Cmf_Common_Cli_Commands_BumpCommand_Execute(System_IO_DirectoryInfo_string_string_string_bool)_buildNr'></a>
`buildNr` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The version for build Nr.
  
<a name='Cmf_Common_Cli_Commands_BumpCommand_Execute(System_IO_DirectoryInfo_string_string_string_bool)_root'></a>
`root` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The root.
  
<a name='Cmf_Common_Cli_Commands_BumpCommand_Execute(System_IO_DirectoryInfo_string_string_string_bool)_all'></a>
`all` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
if set to `true` [all].
  
#### Exceptions
[CliException](Cmf_Common_Cli_Utilities.md#Cmf_Common_Cli_Utilities_CliException 'Cmf.Common.Cli.Utilities.CliException')  
[CliException](Cmf_Common_Cli_Utilities.md#Cmf_Common_Cli_Utilities_CliException 'Cmf.Common.Cli.Utilities.CliException')  
  
#### See Also
- [BaseCommand](Cmf_Common_Cli_Commands.md#Cmf_Common_Cli_Commands_BaseCommand 'Cmf.Common.Cli.Commands.BaseCommand')
  
<a name='Cmf_Common_Cli_Commands_BumpCommandIoTConfiguration'></a>
## BumpCommandIoTConfiguration Class
```csharp
public class BumpCommandIoTConfiguration : Cmf.Common.Cli.Commands.BumpCommand
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [BaseCommand](Cmf_Common_Cli_Commands.md#Cmf_Common_Cli_Commands_BaseCommand 'Cmf.Common.Cli.Commands.BaseCommand') &#129106; [BumpCommand](Cmf_Common_Cli_Commands.md#Cmf_Common_Cli_Commands_BumpCommand 'Cmf.Common.Cli.Commands.BumpCommand') &#129106; BumpCommandIoTConfiguration  
### Methods
<a name='Cmf_Common_Cli_Commands_BumpCommandIoTConfiguration_Configure(System_CommandLine_Command)'></a>
## BumpCommandIoTConfiguration.Configure(Command) Method
Configure command  
```csharp
public override void Configure(System.CommandLine.Command cmd);
```
#### Parameters
<a name='Cmf_Common_Cli_Commands_BumpCommandIoTConfiguration_Configure(System_CommandLine_Command)_cmd'></a>
`cmd` [System.CommandLine.Command](https://docs.microsoft.com/en-us/dotnet/api/System.CommandLine.Command 'System.CommandLine.Command')  
  
  
<a name='Cmf_Common_Cli_Commands_BumpCommandIoTConfiguration_Execute(System_IO_DirectoryInfo_string_string_bool_bool_string_string_string_string_bool_bool)'></a>
## BumpCommandIoTConfiguration.Execute(DirectoryInfo, string, string, bool, bool, string, string, string, string, bool, bool) Method
Executes the specified package directory.  
```csharp
public static void Execute(System.IO.DirectoryInfo packageDirectory, string version, string buildNr, bool isToBumpMasterdata, bool isToBumpIoT, string packageNames, string root, string group, string workflowName, bool isToTag, bool onlyMdCustomization);
```
#### Parameters
<a name='Cmf_Common_Cli_Commands_BumpCommandIoTConfiguration_Execute(System_IO_DirectoryInfo_string_string_bool_bool_string_string_string_string_bool_bool)_packageDirectory'></a>
`packageDirectory` [System.IO.DirectoryInfo](https://docs.microsoft.com/en-us/dotnet/api/System.IO.DirectoryInfo 'System.IO.DirectoryInfo')  
The package directory.
  
<a name='Cmf_Common_Cli_Commands_BumpCommandIoTConfiguration_Execute(System_IO_DirectoryInfo_string_string_bool_bool_string_string_string_string_bool_bool)_version'></a>
`version` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The version.
  
<a name='Cmf_Common_Cli_Commands_BumpCommandIoTConfiguration_Execute(System_IO_DirectoryInfo_string_string_bool_bool_string_string_string_string_bool_bool)_buildNr'></a>
`buildNr` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
  
<a name='Cmf_Common_Cli_Commands_BumpCommandIoTConfiguration_Execute(System_IO_DirectoryInfo_string_string_bool_bool_string_string_string_string_bool_bool)_isToBumpMasterdata'></a>
`isToBumpMasterdata` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
if set to `true` [is to bump masterdata].
  
<a name='Cmf_Common_Cli_Commands_BumpCommandIoTConfiguration_Execute(System_IO_DirectoryInfo_string_string_bool_bool_string_string_string_string_bool_bool)_isToBumpIoT'></a>
`isToBumpIoT` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
if set to `true` [is to bump io t].
  
<a name='Cmf_Common_Cli_Commands_BumpCommandIoTConfiguration_Execute(System_IO_DirectoryInfo_string_string_bool_bool_string_string_string_string_bool_bool)_packageNames'></a>
`packageNames` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The package names.
  
<a name='Cmf_Common_Cli_Commands_BumpCommandIoTConfiguration_Execute(System_IO_DirectoryInfo_string_string_bool_bool_string_string_string_string_bool_bool)_root'></a>
`root` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The root.
  
<a name='Cmf_Common_Cli_Commands_BumpCommandIoTConfiguration_Execute(System_IO_DirectoryInfo_string_string_bool_bool_string_string_string_string_bool_bool)_group'></a>
`group` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The group.
  
<a name='Cmf_Common_Cli_Commands_BumpCommandIoTConfiguration_Execute(System_IO_DirectoryInfo_string_string_bool_bool_string_string_string_string_bool_bool)_workflowName'></a>
`workflowName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Name of the workflow.
  
<a name='Cmf_Common_Cli_Commands_BumpCommandIoTConfiguration_Execute(System_IO_DirectoryInfo_string_string_bool_bool_string_string_string_string_bool_bool)_isToTag'></a>
`isToTag` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
if set to `true` [is to tag].
  
<a name='Cmf_Common_Cli_Commands_BumpCommandIoTConfiguration_Execute(System_IO_DirectoryInfo_string_string_bool_bool_string_string_string_string_bool_bool)_onlyMdCustomization'></a>
`onlyMdCustomization` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
if set to `true` [only md customization].
  
  
#### See Also
- [BumpCommand](Cmf_Common_Cli_Commands.md#Cmf_Common_Cli_Commands_BumpCommand 'Cmf.Common.Cli.Commands.BumpCommand')
- [BaseCommand](Cmf_Common_Cli_Commands.md#Cmf_Common_Cli_Commands_BaseCommand 'Cmf.Common.Cli.Commands.BaseCommand')
  
<a name='Cmf_Common_Cli_Commands_BumpCommandIoTCustomization'></a>
## BumpCommandIoTCustomization Class
```csharp
public class BumpCommandIoTCustomization : Cmf.Common.Cli.Commands.BaseCommand
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [BaseCommand](Cmf_Common_Cli_Commands.md#Cmf_Common_Cli_Commands_BaseCommand 'Cmf.Common.Cli.Commands.BaseCommand') &#129106; BumpCommandIoTCustomization  
### Methods
<a name='Cmf_Common_Cli_Commands_BumpCommandIoTCustomization_Configure(System_CommandLine_Command)'></a>
## BumpCommandIoTCustomization.Configure(Command) Method
Configure command  
```csharp
public override void Configure(System.CommandLine.Command cmd);
```
#### Parameters
<a name='Cmf_Common_Cli_Commands_BumpCommandIoTCustomization_Configure(System_CommandLine_Command)_cmd'></a>
`cmd` [System.CommandLine.Command](https://docs.microsoft.com/en-us/dotnet/api/System.CommandLine.Command 'System.CommandLine.Command')  
  
  
<a name='Cmf_Common_Cli_Commands_BumpCommandIoTCustomization_Execute(Cmf_Common_Cli_Objects_CmfPackage_string_string_string_bool)'></a>
## BumpCommandIoTCustomization.Execute(CmfPackage, string, string, string, bool) Method
Executes the BumpIoTCustomPackages for specified CMF package.  
```csharp
public static void Execute(Cmf.Common.Cli.Objects.CmfPackage cmfPackage, string version, string buildNr, string packageNames, bool isToTag);
```
#### Parameters
<a name='Cmf_Common_Cli_Commands_BumpCommandIoTCustomization_Execute(Cmf_Common_Cli_Objects_CmfPackage_string_string_string_bool)_cmfPackage'></a>
`cmfPackage` [CmfPackage](Cmf_Common_Cli_Objects.md#Cmf_Common_Cli_Objects_CmfPackage 'Cmf.Common.Cli.Objects.CmfPackage')  
The CMF package.
  
<a name='Cmf_Common_Cli_Commands_BumpCommandIoTCustomization_Execute(Cmf_Common_Cli_Objects_CmfPackage_string_string_string_bool)_version'></a>
`version` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The version.
  
<a name='Cmf_Common_Cli_Commands_BumpCommandIoTCustomization_Execute(Cmf_Common_Cli_Objects_CmfPackage_string_string_string_bool)_buildNr'></a>
`buildNr` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
  
<a name='Cmf_Common_Cli_Commands_BumpCommandIoTCustomization_Execute(Cmf_Common_Cli_Objects_CmfPackage_string_string_string_bool)_packageNames'></a>
`packageNames` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The package names.
  
<a name='Cmf_Common_Cli_Commands_BumpCommandIoTCustomization_Execute(Cmf_Common_Cli_Objects_CmfPackage_string_string_string_bool)_isToTag'></a>
`isToTag` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
if set to `true` [is to tag].
  
#### Exceptions
[CliException](Cmf_Common_Cli_Utilities.md#Cmf_Common_Cli_Utilities_CliException 'Cmf.Common.Cli.Utilities.CliException')  
  
<a name='Cmf_Common_Cli_Commands_BumpCommandIoTCustomization_Execute(System_IO_DirectoryInfo_string_string_string_bool)'></a>
## BumpCommandIoTCustomization.Execute(DirectoryInfo, string, string, string, bool) Method
Executes the specified package path.  
```csharp
public static void Execute(System.IO.DirectoryInfo packagePath, string version, string buildNr, string packageNames, bool isToTag);
```
#### Parameters
<a name='Cmf_Common_Cli_Commands_BumpCommandIoTCustomization_Execute(System_IO_DirectoryInfo_string_string_string_bool)_packagePath'></a>
`packagePath` [System.IO.DirectoryInfo](https://docs.microsoft.com/en-us/dotnet/api/System.IO.DirectoryInfo 'System.IO.DirectoryInfo')  
The package path.
  
<a name='Cmf_Common_Cli_Commands_BumpCommandIoTCustomization_Execute(System_IO_DirectoryInfo_string_string_string_bool)_version'></a>
`version` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The version.
  
<a name='Cmf_Common_Cli_Commands_BumpCommandIoTCustomization_Execute(System_IO_DirectoryInfo_string_string_string_bool)_buildNr'></a>
`buildNr` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
  
<a name='Cmf_Common_Cli_Commands_BumpCommandIoTCustomization_Execute(System_IO_DirectoryInfo_string_string_string_bool)_packageNames'></a>
`packageNames` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The package names.
  
<a name='Cmf_Common_Cli_Commands_BumpCommandIoTCustomization_Execute(System_IO_DirectoryInfo_string_string_string_bool)_isToTag'></a>
`isToTag` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
if set to `true` [is to tag].
  
#### Exceptions
[CliException](Cmf_Common_Cli_Utilities.md#Cmf_Common_Cli_Utilities_CliException 'Cmf.Common.Cli.Utilities.CliException')  
[CliException](Cmf_Common_Cli_Utilities.md#Cmf_Common_Cli_Utilities_CliException 'Cmf.Common.Cli.Utilities.CliException')  
  
#### See Also
- [BaseCommand](Cmf_Common_Cli_Commands.md#Cmf_Common_Cli_Commands_BaseCommand 'Cmf.Common.Cli.Commands.BaseCommand')
  
<a name='Cmf_Common_Cli_Commands_GenerateBasedOnTemplatesCommand'></a>
## GenerateBasedOnTemplatesCommand Class
```csharp
public class GenerateBasedOnTemplatesCommand : Cmf.Common.Cli.Commands.PowershellCommand
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [BaseCommand](Cmf_Common_Cli_Commands.md#Cmf_Common_Cli_Commands_BaseCommand 'Cmf.Common.Cli.Commands.BaseCommand') &#129106; [PowershellCommand](Cmf_Common_Cli_Commands.md#Cmf_Common_Cli_Commands_PowershellCommand 'Cmf.Common.Cli.Commands.PowershellCommand') &#129106; GenerateBasedOnTemplatesCommand  
### Methods
<a name='Cmf_Common_Cli_Commands_GenerateBasedOnTemplatesCommand_Configure(System_CommandLine_Command)'></a>
## GenerateBasedOnTemplatesCommand.Configure(Command) Method
Configure command  
```csharp
public override void Configure(System.CommandLine.Command cmd);
```
#### Parameters
<a name='Cmf_Common_Cli_Commands_GenerateBasedOnTemplatesCommand_Configure(System_CommandLine_Command)_cmd'></a>
`cmd` [System.CommandLine.Command](https://docs.microsoft.com/en-us/dotnet/api/System.CommandLine.Command 'System.CommandLine.Command')  
  
  
<a name='Cmf_Common_Cli_Commands_GenerateBasedOnTemplatesCommand_Execute()'></a>
## GenerateBasedOnTemplatesCommand.Execute() Method
Executes this instance.  
```csharp
public void Execute();
```
  
<a name='Cmf_Common_Cli_Commands_GenerateBasedOnTemplatesCommand_GetPowershellScript()'></a>
## GenerateBasedOnTemplatesCommand.GetPowershellScript() Method
Gets the powershell script.  
```csharp
protected override string GetPowershellScript();
```
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
  
#### See Also
- [PowershellCommand](Cmf_Common_Cli_Commands.md#Cmf_Common_Cli_Commands_PowershellCommand 'Cmf.Common.Cli.Commands.PowershellCommand')
  
<a name='Cmf_Common_Cli_Commands_GenerateLBOsCommand'></a>
## GenerateLBOsCommand Class
```csharp
public class GenerateLBOsCommand : Cmf.Common.Cli.Commands.PowershellCommand
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [BaseCommand](Cmf_Common_Cli_Commands.md#Cmf_Common_Cli_Commands_BaseCommand 'Cmf.Common.Cli.Commands.BaseCommand') &#129106; [PowershellCommand](Cmf_Common_Cli_Commands.md#Cmf_Common_Cli_Commands_PowershellCommand 'Cmf.Common.Cli.Commands.PowershellCommand') &#129106; GenerateLBOsCommand  
### Methods
<a name='Cmf_Common_Cli_Commands_GenerateLBOsCommand_Configure(System_CommandLine_Command)'></a>
## GenerateLBOsCommand.Configure(Command) Method
Configure command  
```csharp
public override void Configure(System.CommandLine.Command cmd);
```
#### Parameters
<a name='Cmf_Common_Cli_Commands_GenerateLBOsCommand_Configure(System_CommandLine_Command)_cmd'></a>
`cmd` [System.CommandLine.Command](https://docs.microsoft.com/en-us/dotnet/api/System.CommandLine.Command 'System.CommandLine.Command')  
  
  
<a name='Cmf_Common_Cli_Commands_GenerateLBOsCommand_Execute()'></a>
## GenerateLBOsCommand.Execute() Method
Executes this instance.  
```csharp
public void Execute();
```
  
<a name='Cmf_Common_Cli_Commands_GenerateLBOsCommand_GetPowershellScript()'></a>
## GenerateLBOsCommand.GetPowershellScript() Method
Gets the powershell script.  
```csharp
protected override string GetPowershellScript();
```
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
  
#### See Also
- [PowershellCommand](Cmf_Common_Cli_Commands.md#Cmf_Common_Cli_Commands_PowershellCommand 'Cmf.Common.Cli.Commands.PowershellCommand')
  
<a name='Cmf_Common_Cli_Commands_GenerateMenuItemsCommand'></a>
## GenerateMenuItemsCommand Class
```csharp
public class GenerateMenuItemsCommand : Cmf.Common.Cli.Commands.PowershellCommand
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [BaseCommand](Cmf_Common_Cli_Commands.md#Cmf_Common_Cli_Commands_BaseCommand 'Cmf.Common.Cli.Commands.BaseCommand') &#129106; [PowershellCommand](Cmf_Common_Cli_Commands.md#Cmf_Common_Cli_Commands_PowershellCommand 'Cmf.Common.Cli.Commands.PowershellCommand') &#129106; GenerateMenuItemsCommand  
### Methods
<a name='Cmf_Common_Cli_Commands_GenerateMenuItemsCommand_Configure(System_CommandLine_Command)'></a>
## GenerateMenuItemsCommand.Configure(Command) Method
Configure command  
```csharp
public override void Configure(System.CommandLine.Command cmd);
```
#### Parameters
<a name='Cmf_Common_Cli_Commands_GenerateMenuItemsCommand_Configure(System_CommandLine_Command)_cmd'></a>
`cmd` [System.CommandLine.Command](https://docs.microsoft.com/en-us/dotnet/api/System.CommandLine.Command 'System.CommandLine.Command')  
  
  
<a name='Cmf_Common_Cli_Commands_GenerateMenuItemsCommand_Execute()'></a>
## GenerateMenuItemsCommand.Execute() Method
Executes this instance.  
```csharp
public void Execute();
```
  
<a name='Cmf_Common_Cli_Commands_GenerateMenuItemsCommand_GetPowershellScript()'></a>
## GenerateMenuItemsCommand.GetPowershellScript() Method
Gets the powershell script.  
```csharp
protected override string GetPowershellScript();
```
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
  
#### See Also
- [PowershellCommand](Cmf_Common_Cli_Commands.md#Cmf_Common_Cli_Commands_PowershellCommand 'Cmf.Common.Cli.Commands.PowershellCommand')
  
<a name='Cmf_Common_Cli_Commands_GetLocalEnvironmentCommand'></a>
## GetLocalEnvironmentCommand Class
```csharp
public class GetLocalEnvironmentCommand : Cmf.Common.Cli.Commands.PowershellCommand
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [BaseCommand](Cmf_Common_Cli_Commands.md#Cmf_Common_Cli_Commands_BaseCommand 'Cmf.Common.Cli.Commands.BaseCommand') &#129106; [PowershellCommand](Cmf_Common_Cli_Commands.md#Cmf_Common_Cli_Commands_PowershellCommand 'Cmf.Common.Cli.Commands.PowershellCommand') &#129106; GetLocalEnvironmentCommand  
### Methods
<a name='Cmf_Common_Cli_Commands_GetLocalEnvironmentCommand_Configure(System_CommandLine_Command)'></a>
## GetLocalEnvironmentCommand.Configure(Command) Method
Configure command  
```csharp
public override void Configure(System.CommandLine.Command cmd);
```
#### Parameters
<a name='Cmf_Common_Cli_Commands_GetLocalEnvironmentCommand_Configure(System_CommandLine_Command)_cmd'></a>
`cmd` [System.CommandLine.Command](https://docs.microsoft.com/en-us/dotnet/api/System.CommandLine.Command 'System.CommandLine.Command')  
  
  
<a name='Cmf_Common_Cli_Commands_GetLocalEnvironmentCommand_Execute(System_IO_DirectoryInfo)'></a>
## GetLocalEnvironmentCommand.Execute(DirectoryInfo) Method
Executes the specified target.  
```csharp
public void Execute(System.IO.DirectoryInfo target);
```
#### Parameters
<a name='Cmf_Common_Cli_Commands_GetLocalEnvironmentCommand_Execute(System_IO_DirectoryInfo)_target'></a>
`target` [System.IO.DirectoryInfo](https://docs.microsoft.com/en-us/dotnet/api/System.IO.DirectoryInfo 'System.IO.DirectoryInfo')  
The target.
  
  
<a name='Cmf_Common_Cli_Commands_GetLocalEnvironmentCommand_GetPowershellScript()'></a>
## GetLocalEnvironmentCommand.GetPowershellScript() Method
Gets the powershell script.  
```csharp
protected override string GetPowershellScript();
```
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
  
#### See Also
- [PowershellCommand](Cmf_Common_Cli_Commands.md#Cmf_Common_Cli_Commands_PowershellCommand 'Cmf.Common.Cli.Commands.PowershellCommand')
  
<a name='Cmf_Common_Cli_Commands_HelpCommand'></a>
## HelpCommand Class
```csharp
public class HelpCommand : Cmf.Common.Cli.Commands.BaseCommand
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [BaseCommand](Cmf_Common_Cli_Commands.md#Cmf_Common_Cli_Commands_BaseCommand 'Cmf.Common.Cli.Commands.BaseCommand') &#129106; HelpCommand  
### Methods
<a name='Cmf_Common_Cli_Commands_HelpCommand_Configure(System_CommandLine_Command)'></a>
## HelpCommand.Configure(Command) Method
Configure command  
```csharp
public override void Configure(System.CommandLine.Command cmd);
```
#### Parameters
<a name='Cmf_Common_Cli_Commands_HelpCommand_Configure(System_CommandLine_Command)_cmd'></a>
`cmd` [System.CommandLine.Command](https://docs.microsoft.com/en-us/dotnet/api/System.CommandLine.Command 'System.CommandLine.Command')  
  
  
#### See Also
- [BaseCommand](Cmf_Common_Cli_Commands.md#Cmf_Common_Cli_Commands_BaseCommand 'Cmf.Common.Cli.Commands.BaseCommand')
  
<a name='Cmf_Common_Cli_Commands_LocalCommand'></a>
## LocalCommand Class
```csharp
public class LocalCommand : Cmf.Common.Cli.Commands.BaseCommand
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [BaseCommand](Cmf_Common_Cli_Commands.md#Cmf_Common_Cli_Commands_BaseCommand 'Cmf.Common.Cli.Commands.BaseCommand') &#129106; LocalCommand  
### Methods
<a name='Cmf_Common_Cli_Commands_LocalCommand_Configure(System_CommandLine_Command)'></a>
## LocalCommand.Configure(Command) Method
Configure command  
```csharp
public override void Configure(System.CommandLine.Command cmd);
```
#### Parameters
<a name='Cmf_Common_Cli_Commands_LocalCommand_Configure(System_CommandLine_Command)_cmd'></a>
`cmd` [System.CommandLine.Command](https://docs.microsoft.com/en-us/dotnet/api/System.CommandLine.Command 'System.CommandLine.Command')  
  
  
#### See Also
- [BaseCommand](Cmf_Common_Cli_Commands.md#Cmf_Common_Cli_Commands_BaseCommand 'Cmf.Common.Cli.Commands.BaseCommand')
  
<a name='Cmf_Common_Cli_Commands_PackCommand'></a>
## PackCommand Class
```csharp
public class PackCommand : Cmf.Common.Cli.Commands.BaseCommand
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [BaseCommand](Cmf_Common_Cli_Commands.md#Cmf_Common_Cli_Commands_BaseCommand 'Cmf.Common.Cli.Commands.BaseCommand') &#129106; PackCommand  
### Methods
<a name='Cmf_Common_Cli_Commands_PackCommand_Configure(System_CommandLine_Command)'></a>
## PackCommand.Configure(Command) Method
Configure command  
```csharp
public override void Configure(System.CommandLine.Command cmd);
```
#### Parameters
<a name='Cmf_Common_Cli_Commands_PackCommand_Configure(System_CommandLine_Command)_cmd'></a>
`cmd` [System.CommandLine.Command](https://docs.microsoft.com/en-us/dotnet/api/System.CommandLine.Command 'System.CommandLine.Command')  
  
  
<a name='Cmf_Common_Cli_Commands_PackCommand_Execute(Cmf_Common_Cli_Objects_CmfPackage_System_IO_DirectoryInfo_System_Uri_Cmf_Common_Cli_Objects_CmfPackageCollection_bool_bool)'></a>
## PackCommand.Execute(CmfPackage, DirectoryInfo, Uri, CmfPackageCollection, bool, bool) Method
Executes the specified CMF package.  
```csharp
public void Execute(Cmf.Common.Cli.Objects.CmfPackage cmfPackage, System.IO.DirectoryInfo outputDir, System.Uri repoUri, Cmf.Common.Cli.Objects.CmfPackageCollection loadedPackages, bool force, bool skipDependencies);
```
#### Parameters
<a name='Cmf_Common_Cli_Commands_PackCommand_Execute(Cmf_Common_Cli_Objects_CmfPackage_System_IO_DirectoryInfo_System_Uri_Cmf_Common_Cli_Objects_CmfPackageCollection_bool_bool)_cmfPackage'></a>
`cmfPackage` [CmfPackage](Cmf_Common_Cli_Objects.md#Cmf_Common_Cli_Objects_CmfPackage 'Cmf.Common.Cli.Objects.CmfPackage')  
The CMF package.
  
<a name='Cmf_Common_Cli_Commands_PackCommand_Execute(Cmf_Common_Cli_Objects_CmfPackage_System_IO_DirectoryInfo_System_Uri_Cmf_Common_Cli_Objects_CmfPackageCollection_bool_bool)_outputDir'></a>
`outputDir` [System.IO.DirectoryInfo](https://docs.microsoft.com/en-us/dotnet/api/System.IO.DirectoryInfo 'System.IO.DirectoryInfo')  
The output dir.
  
<a name='Cmf_Common_Cli_Commands_PackCommand_Execute(Cmf_Common_Cli_Objects_CmfPackage_System_IO_DirectoryInfo_System_Uri_Cmf_Common_Cli_Objects_CmfPackageCollection_bool_bool)_repoUri'></a>
`repoUri` [System.Uri](https://docs.microsoft.com/en-us/dotnet/api/System.Uri 'System.Uri')  
The repo URI.
  
<a name='Cmf_Common_Cli_Commands_PackCommand_Execute(Cmf_Common_Cli_Objects_CmfPackage_System_IO_DirectoryInfo_System_Uri_Cmf_Common_Cli_Objects_CmfPackageCollection_bool_bool)_loadedPackages'></a>
`loadedPackages` [CmfPackageCollection](Cmf_Common_Cli_Objects.md#Cmf_Common_Cli_Objects_CmfPackageCollection 'Cmf.Common.Cli.Objects.CmfPackageCollection')  
The loaded packages.
  
<a name='Cmf_Common_Cli_Commands_PackCommand_Execute(Cmf_Common_Cli_Objects_CmfPackage_System_IO_DirectoryInfo_System_Uri_Cmf_Common_Cli_Objects_CmfPackageCollection_bool_bool)_force'></a>
`force` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
if set to `true` [force].
  
<a name='Cmf_Common_Cli_Commands_PackCommand_Execute(Cmf_Common_Cli_Objects_CmfPackage_System_IO_DirectoryInfo_System_Uri_Cmf_Common_Cli_Objects_CmfPackageCollection_bool_bool)_skipDependencies'></a>
`skipDependencies` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
  
#### Exceptions
[CmfPackageCollection](Cmf_Common_Cli_Objects.md#Cmf_Common_Cli_Objects_CmfPackageCollection 'Cmf.Common.Cli.Objects.CmfPackageCollection')  
  
<a name='Cmf_Common_Cli_Commands_PackCommand_Execute(System_IO_DirectoryInfo_System_IO_DirectoryInfo_string_bool_bool)'></a>
## PackCommand.Execute(DirectoryInfo, DirectoryInfo, string, bool, bool) Method
Executes the specified working dir.  
```csharp
public void Execute(System.IO.DirectoryInfo workingDir, System.IO.DirectoryInfo outputDir, string repo, bool force, bool skipDependencies);
```
#### Parameters
<a name='Cmf_Common_Cli_Commands_PackCommand_Execute(System_IO_DirectoryInfo_System_IO_DirectoryInfo_string_bool_bool)_workingDir'></a>
`workingDir` [System.IO.DirectoryInfo](https://docs.microsoft.com/en-us/dotnet/api/System.IO.DirectoryInfo 'System.IO.DirectoryInfo')  
The working dir.
  
<a name='Cmf_Common_Cli_Commands_PackCommand_Execute(System_IO_DirectoryInfo_System_IO_DirectoryInfo_string_bool_bool)_outputDir'></a>
`outputDir` [System.IO.DirectoryInfo](https://docs.microsoft.com/en-us/dotnet/api/System.IO.DirectoryInfo 'System.IO.DirectoryInfo')  
The output dir.
  
<a name='Cmf_Common_Cli_Commands_PackCommand_Execute(System_IO_DirectoryInfo_System_IO_DirectoryInfo_string_bool_bool)_repo'></a>
`repo` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The repo.
  
<a name='Cmf_Common_Cli_Commands_PackCommand_Execute(System_IO_DirectoryInfo_System_IO_DirectoryInfo_string_bool_bool)_force'></a>
`force` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
if set to `true` [force].
  
<a name='Cmf_Common_Cli_Commands_PackCommand_Execute(System_IO_DirectoryInfo_System_IO_DirectoryInfo_string_bool_bool)_skipDependencies'></a>
`skipDependencies` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
  
  
<a name='Cmf_Common_Cli_Commands_PackCommand_GetOutputDir(Cmf_Common_Cli_Objects_CmfPackage_System_IO_DirectoryInfo_bool)'></a>
## PackCommand.GetOutputDir(CmfPackage, DirectoryInfo, bool) Method
Gets the output dir.  
```csharp
private static System.IO.DirectoryInfo GetOutputDir(Cmf.Common.Cli.Objects.CmfPackage cmfPackage, System.IO.DirectoryInfo outputDir, bool force);
```
#### Parameters
<a name='Cmf_Common_Cli_Commands_PackCommand_GetOutputDir(Cmf_Common_Cli_Objects_CmfPackage_System_IO_DirectoryInfo_bool)_cmfPackage'></a>
`cmfPackage` [CmfPackage](Cmf_Common_Cli_Objects.md#Cmf_Common_Cli_Objects_CmfPackage 'Cmf.Common.Cli.Objects.CmfPackage')  
The CMF package.
  
<a name='Cmf_Common_Cli_Commands_PackCommand_GetOutputDir(Cmf_Common_Cli_Objects_CmfPackage_System_IO_DirectoryInfo_bool)_outputDir'></a>
`outputDir` [System.IO.DirectoryInfo](https://docs.microsoft.com/en-us/dotnet/api/System.IO.DirectoryInfo 'System.IO.DirectoryInfo')  
The output dir.
  
<a name='Cmf_Common_Cli_Commands_PackCommand_GetOutputDir(Cmf_Common_Cli_Objects_CmfPackage_System_IO_DirectoryInfo_bool)_force'></a>
`force` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
if set to `true` [force].
  
#### Returns
[System.IO.DirectoryInfo](https://docs.microsoft.com/en-us/dotnet/api/System.IO.DirectoryInfo 'System.IO.DirectoryInfo')  
  
<a name='Cmf_Common_Cli_Commands_PackCommand_GetPackageOutputDir(Cmf_Common_Cli_Objects_CmfPackage_System_IO_DirectoryInfo)'></a>
## PackCommand.GetPackageOutputDir(CmfPackage, DirectoryInfo) Method
Gets the package output dir.  
```csharp
private static System.IO.DirectoryInfo GetPackageOutputDir(Cmf.Common.Cli.Objects.CmfPackage cmfPackage, System.IO.DirectoryInfo packageDirectory);
```
#### Parameters
<a name='Cmf_Common_Cli_Commands_PackCommand_GetPackageOutputDir(Cmf_Common_Cli_Objects_CmfPackage_System_IO_DirectoryInfo)_cmfPackage'></a>
`cmfPackage` [CmfPackage](Cmf_Common_Cli_Objects.md#Cmf_Common_Cli_Objects_CmfPackage 'Cmf.Common.Cli.Objects.CmfPackage')  
The CMF package.
  
<a name='Cmf_Common_Cli_Commands_PackCommand_GetPackageOutputDir(Cmf_Common_Cli_Objects_CmfPackage_System_IO_DirectoryInfo)_packageDirectory'></a>
`packageDirectory` [System.IO.DirectoryInfo](https://docs.microsoft.com/en-us/dotnet/api/System.IO.DirectoryInfo 'System.IO.DirectoryInfo')  
The package directory.
  
#### Returns
[System.IO.DirectoryInfo](https://docs.microsoft.com/en-us/dotnet/api/System.IO.DirectoryInfo 'System.IO.DirectoryInfo')  
  
#### See Also
- [BaseCommand](Cmf_Common_Cli_Commands.md#Cmf_Common_Cli_Commands_BaseCommand 'Cmf.Common.Cli.Commands.BaseCommand')
  
<a name='Cmf_Common_Cli_Commands_PluginCommand'></a>
## PluginCommand Class
```csharp
public class PluginCommand : Cmf.Common.Cli.Commands.BaseCommand
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [BaseCommand](Cmf_Common_Cli_Commands.md#Cmf_Common_Cli_Commands_BaseCommand 'Cmf.Common.Cli.Commands.BaseCommand') &#129106; PluginCommand  
### Constructors
<a name='Cmf_Common_Cli_Commands_PluginCommand_PluginCommand(string_string)'></a>
## PluginCommand.PluginCommand(string, string) Constructor
Initializes a new instance of the [PluginCommand](Cmf_Common_Cli_Commands.md#Cmf_Common_Cli_Commands_PluginCommand 'Cmf.Common.Cli.Commands.PluginCommand') class.  
```csharp
public PluginCommand(string commandName, string commandPath);
```
#### Parameters
<a name='Cmf_Common_Cli_Commands_PluginCommand_PluginCommand(string_string)_commandName'></a>
`commandName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Name of the command.
  
<a name='Cmf_Common_Cli_Commands_PluginCommand_PluginCommand(string_string)_commandPath'></a>
`commandPath` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The command path.
  
  
### Fields
<a name='Cmf_Common_Cli_Commands_PluginCommand_commandName'></a>
## PluginCommand.commandName Field
The command name  
```csharp
private readonly string commandName;
```
#### Field Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')
  
<a name='Cmf_Common_Cli_Commands_PluginCommand_commandPath'></a>
## PluginCommand.commandPath Field
The command path  
```csharp
private readonly string commandPath;
```
#### Field Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')
  
### Methods
<a name='Cmf_Common_Cli_Commands_PluginCommand_Configure(System_CommandLine_Command)'></a>
## PluginCommand.Configure(Command) Method
Configure command  
```csharp
public override void Configure(System.CommandLine.Command cmd);
```
#### Parameters
<a name='Cmf_Common_Cli_Commands_PluginCommand_Configure(System_CommandLine_Command)_cmd'></a>
`cmd` [System.CommandLine.Command](https://docs.microsoft.com/en-us/dotnet/api/System.CommandLine.Command 'System.CommandLine.Command')  
  
  
<a name='Cmf_Common_Cli_Commands_PluginCommand_Execute(System_Collections_Generic_IReadOnlyCollection_string_)'></a>
## PluginCommand.Execute(IReadOnlyCollection&lt;string&gt;) Method
Executes the plugin with the supplied parameters  
```csharp
public void Execute(System.Collections.Generic.IReadOnlyCollection<string> args);
```
#### Parameters
<a name='Cmf_Common_Cli_Commands_PluginCommand_Execute(System_Collections_Generic_IReadOnlyCollection_string_)_args'></a>
`args` [System.Collections.Generic.IReadOnlyCollection&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyCollection-1 'System.Collections.Generic.IReadOnlyCollection`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyCollection-1 'System.Collections.Generic.IReadOnlyCollection`1')  
The arguments.
  
  
#### See Also
- [BaseCommand](Cmf_Common_Cli_Commands.md#Cmf_Common_Cli_Commands_BaseCommand 'Cmf.Common.Cli.Commands.BaseCommand')
  
<a name='Cmf_Common_Cli_Commands_PowershellCommand'></a>
## PowershellCommand Class
```csharp
public abstract class PowershellCommand : Cmf.Common.Cli.Commands.BaseCommand
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [BaseCommand](Cmf_Common_Cli_Commands.md#Cmf_Common_Cli_Commands_BaseCommand 'Cmf.Common.Cli.Commands.BaseCommand') &#129106; PowershellCommand  

Derived  
&#8627; [GenerateBasedOnTemplatesCommand](Cmf_Common_Cli_Commands.md#Cmf_Common_Cli_Commands_GenerateBasedOnTemplatesCommand 'Cmf.Common.Cli.Commands.GenerateBasedOnTemplatesCommand')  
&#8627; [GenerateLBOsCommand](Cmf_Common_Cli_Commands.md#Cmf_Common_Cli_Commands_GenerateLBOsCommand 'Cmf.Common.Cli.Commands.GenerateLBOsCommand')  
&#8627; [GenerateMenuItemsCommand](Cmf_Common_Cli_Commands.md#Cmf_Common_Cli_Commands_GenerateMenuItemsCommand 'Cmf.Common.Cli.Commands.GenerateMenuItemsCommand')  
&#8627; [GetLocalEnvironmentCommand](Cmf_Common_Cli_Commands.md#Cmf_Common_Cli_Commands_GetLocalEnvironmentCommand 'Cmf.Common.Cli.Commands.GetLocalEnvironmentCommand')  
### Methods
<a name='Cmf_Common_Cli_Commands_PowershellCommand_ExecutePwshScriptAsync(System_Collections_IDictionary_string_string)'></a>
## PowershellCommand.ExecutePwshScriptAsync(IDictionary, string, string) Method
Executes the PWSH script asynchronously.  
```csharp
protected System.Threading.Tasks.Task<System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>> ExecutePwshScriptAsync(System.Collections.IDictionary parameters=null, string script=null, string hostname=null);
```
#### Parameters
<a name='Cmf_Common_Cli_Commands_PowershellCommand_ExecutePwshScriptAsync(System_Collections_IDictionary_string_string)_parameters'></a>
`parameters` [System.Collections.IDictionary](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IDictionary 'System.Collections.IDictionary')  
The parameters.
  
<a name='Cmf_Common_Cli_Commands_PowershellCommand_ExecutePwshScriptAsync(System_Collections_IDictionary_string_string)_script'></a>
`script` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The script.
  
<a name='Cmf_Common_Cli_Commands_PowershellCommand_ExecutePwshScriptAsync(System_Collections_IDictionary_string_string)_hostname'></a>
`hostname` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The hostname.
  
#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Management.Automation.PSDataCollection&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Management.Automation.PSDataCollection-1 'System.Management.Automation.PSDataCollection`1')[System.Management.Automation.PSObject](https://docs.microsoft.com/en-us/dotnet/api/System.Management.Automation.PSObject 'System.Management.Automation.PSObject')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Management.Automation.PSDataCollection-1 'System.Management.Automation.PSDataCollection`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
  
<a name='Cmf_Common_Cli_Commands_PowershellCommand_ExecutePwshScriptSync(System_Collections_IDictionary_string_string)'></a>
## PowershellCommand.ExecutePwshScriptSync(IDictionary, string, string) Method
Executes the PWSH script synchronously.  
```csharp
protected System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject> ExecutePwshScriptSync(System.Collections.IDictionary parameters=null, string script=null, string hostname=null);
```
#### Parameters
<a name='Cmf_Common_Cli_Commands_PowershellCommand_ExecutePwshScriptSync(System_Collections_IDictionary_string_string)_parameters'></a>
`parameters` [System.Collections.IDictionary](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IDictionary 'System.Collections.IDictionary')  
The parameters.
  
<a name='Cmf_Common_Cli_Commands_PowershellCommand_ExecutePwshScriptSync(System_Collections_IDictionary_string_string)_script'></a>
`script` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The script.
  
<a name='Cmf_Common_Cli_Commands_PowershellCommand_ExecutePwshScriptSync(System_Collections_IDictionary_string_string)_hostname'></a>
`hostname` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The hostname.
  
#### Returns
[System.Management.Automation.PSDataCollection&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Management.Automation.PSDataCollection-1 'System.Management.Automation.PSDataCollection`1')[System.Management.Automation.PSObject](https://docs.microsoft.com/en-us/dotnet/api/System.Management.Automation.PSObject 'System.Management.Automation.PSObject')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Management.Automation.PSDataCollection-1 'System.Management.Automation.PSDataCollection`1')  
  
<a name='Cmf_Common_Cli_Commands_PowershellCommand_GetPowershellScript()'></a>
## PowershellCommand.GetPowershellScript() Method
Gets the powershell script.  
```csharp
protected abstract string GetPowershellScript();
```
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
  
<a name='Cmf_Common_Cli_Commands_PowershellCommand_GetRunspace(string)'></a>
## PowershellCommand.GetRunspace(string) Method
Gets the a remote pwsh runspace.  
```csharp
protected static System.Management.Automation.Runspaces.Runspace GetRunspace(string hostname);
```
#### Parameters
<a name='Cmf_Common_Cli_Commands_PowershellCommand_GetRunspace(string)_hostname'></a>
`hostname` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The hostname.
  
#### Returns
[System.Management.Automation.Runspaces.Runspace](https://docs.microsoft.com/en-us/dotnet/api/System.Management.Automation.Runspaces.Runspace 'System.Management.Automation.Runspaces.Runspace')  
  
#### See Also
- [BaseCommand](Cmf_Common_Cli_Commands.md#Cmf_Common_Cli_Commands_BaseCommand 'Cmf.Common.Cli.Commands.BaseCommand')
  