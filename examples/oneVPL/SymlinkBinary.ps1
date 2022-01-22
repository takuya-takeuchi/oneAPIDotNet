#***************************************
#Arguments
#%1: Build Configuration (Release/Debug)
#%2: Build Directory (build_xxx_yyy_zzz_x64)
#***************************************
Param
(
   [Parameter(
   Mandatory=$True,
   Position = 1
   )][string]
   $Configuration,

   [Parameter(
   Mandatory=$True,
   Position = 2
   )][string]
   $Directory
)

$dotnetAppDirectoryName = "net6.0"
$oneAPIVersion = "2021.2.2"

# build path
$oneVPLRoot = $PSScriptRoot
$ExamplesRoot = Split-Path $oneVPLRoot -Parent
$oneAPIDotNetRoot = Split-Path $ExamplesRoot -Parent
$SrcRoot = Join-Path $oneAPIDotNetRoot src
$oneAPIDotNetNativeRoot = Join-Path $SrcRoot oneAPIDotNet.Native
$BuildDir = Join-Path $oneAPIDotNetNativeRoot $Directory
$oneAPIDotNetNativeBuildDir = Join-Path $BuildDir $Configuration

$projects = Get-ChildItem ${ExamplesRoot} -Recurse -Filter *.csproj
foreach ($SrcPath in $projects)
{
   $SrcPath = Split-Path -Parent $SrcPath   
   Write-Host "Project: ${SrcPath}" -ForegroundColor Blue
   $AppDir = Join-Path $SrcPath bin |
             Join-Path -child $Configuration |
             Join-Path -child $dotnetAppDirectoryName
   New-Item $AppDir -Force -ItemType Directory | Out-Null

   # check path
   if (!(Test-Path $oneAPIDotNetNativeBuildDir))
   {
      Write-Host "[Error] '$oneAPIDotNetNativeBuildDir' does not exist" -ForegroundColor Red
      exit
   }

   # create symlink
   $oneAPIDotNetNativeLibraries =
   @(
      "oneAPIDotNetNative.dll"
   )
   $oneAPIDotNetNativeDebugSymbols =
   @(
      "oneAPIDotNetNative.pdb"
   )
   $vplLibraryDirectory = Join-Path $env:ONEAPI_ROOT vpl | Join-Path -ChildPath $oneAPIVersion
   $vplLibraries =
   @(
   )

   if ($global:IsWindows)
   {
      if ($Directory.EndsWith("x64"))
      {
         $vplLibraryDirectory = Join-Path $vplLibraryDirectory bin
         $platformLibraries =
         @(
            "libmfx.dll",
            "libvpl.dll",
            "libvplswref64.dll",
            "libwinpthread-1.dll"
         )
      }
      elseif ($Directory.EndsWith("x86"))
      {
         $vplLibraryDirectory = Join-Path $vplLibraryDirectory bin32
         $platformLibraries =
         @(
            "libvpl.dll",
            "libvplswref32.dll",
            "libwinpthread-1.dll"
         )
      }
   }
   elseif ($global:IsMacOS)
   {
      
   }
   elseif ($global:IsLinux)
   {

   }

   foreach ($binary in $platformLibraries)
   {
      $vplLibraries += (Split-Path -Leaf $binary)
   }

   # create symlink
   function create-symlink($Targets, $SrcDir, $DstDir)
   {
      foreach ($Target in $Targets)
      {
         $src = Join-Path $SrcDir $Target
         $dst = Join-Path $DstDir $Target

         if (!(Test-Path $src))
         {
            Write-Host "[Error] '$src' does not exist" -ForegroundColor Red
            exit
         }

         if (Test-Path $dst)
         {
            Remove-Item $dst
         }

         New-Item -Path "${DstDir}" -Value "${src}" -Name "${Target}" -ItemType SymbolicLink | Out-Null
      }
   }

   create-symlink $vplLibraries                   $vplLibraryDirectory        $AppDir
   create-symlink $oneAPIDotNetNativeLibraries    $oneAPIDotNetNativeBuildDir $AppDir
   if ($Configuration -eq "Debug")
   {
      create-symlink $oneAPIDotNetNativeDebugSymbols $oneAPIDotNetNativeBuildDir $AppDir
   }
}