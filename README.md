FNAFPorting - Automation of the FNAF Porting Process
------------------------------------------

#### Powered by [Avalonia UI](https://avaloniaui.net/) and [CUE4Parse](https://github.com/FabianFG/CUE4Parse)

[![Discord](https://discord.com/api/guilds/866821077769781249/widget.png?style=shield)](https://discord.gg/X7dzY6TUzw)
[![Blender](https://img.shields.io/badge/Blender-4.2+-blue?logo=blender&logoColor=white&color=orange)](https://www.blender.org/download/)
[![Unreal](https://img.shields.io/badge/Unreal-5.4+-blue?logo=unreal-engine&logoColor=white&color=white)](https://www.unrealengine.com/en-US/download)
[![Release](https://img.shields.io/github/release/TyBurger3D/Fnaf-Porting)]()
[![Downloads](https://img.shields.io/github/downloads/TyBurger3D/Fnaf-Porting/total?color=green)]()
***

![RivalsPorting_Preview](https://github.com/user-attachments/assets/b484bd1a-785b-4d83-ba35-93065888aafb)

## Add to Portle
Add the following URL in the Repositories tab of Portle
```
https://raw.githubusercontent.com/TyBurger3D/Fnaf-Porting/refs/heads/FNAFPorting/Repository.json
```

## Building FNAFPorting

To build FNAFPorting from source, first clone the repository and all of its submodules.

```
git clone -b FNAFPorting https://github.com/TyBurger3D/Fnaf-Porting --recursive
```

Then open the project directory in a terminal window and publish

```
dotnet publish FortnitePorting -c Release --no-self-contained -r win-x64 -o "./Release" -p:PublishSingleFile=true -p:DebugType=None -p:DebugSymbols=false -p:IncludeNativeLibrariesForSelfExtract=true
```
