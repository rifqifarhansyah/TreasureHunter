# Tubes2_dicarryVieridanZaki
<h2 align="center">
📱 BFS and DFS for Solving Maze Treasure Hunt Problems 📱<br/>
</h2>
<hr>

## Table of Contents
1. [General Info](#general-information)
2. [Creator Info](#creator-information)
3. [Features](#features)
4. [Technologies Used](#technologies-used)
5. [Setup](#setup)
6. [Usage](#usage)
7. [Video Capture](#videocapture)
8. [Screenshots](#screenshots)
9. [Structure](#structure)
10. [Project Status](#project-status)
11. [Room for Improvement](#room-for-improvement)
12. [Acknowledgements](#acknowledgements)
13. [Contact](#contact)

<a name="general-information"></a>

## General Information
A simple program that write in C# language to implement BFS and DFS algorithm for solving maze treasure hunt problems. This project was written in C# programming language using Visual Studio and Windows Presentation Foundation (WPF) for the GUI. Treasure Hunter App will read the input from a text file and then display the result in the GUI. The program will also display the number of nodes that have been visited and the number of nodes that have been expanded. Besides that, this project also has a feature to display the execution time of the program. This project made for fulfilling Tubes 2 of IF2211 - Strategi Algoritma course at ITB 2022/2023.

<a name="creator-information"></a>

## Creator Information

| Nama                        | NIM      | E-Mail                      |
| --------------------------- | -------- | --------------------------- |
| Vieri Fajar Firdaus         | 13521099 | 13521099@std.stei.itb.ac.id |
| Muhammad Zaki Amanullah     | 13521146 | 13521146@std.stei.itb.ac.id |
| Mohammad Rifqi Farhansyah   | 13521166 | 13521166@std.stei.itb.ac.id |

<a name="features"></a>

## Features
- Read `input` from a text file (via file explorer or textfield)
- User can choose `the algorithm` to be used (BFS or DFS)
- There is a additional feature to display the `TSP` solution of the problem
- Customize the `search speed` of the algorithm
- Show the `maze` in the GUI
- Visualize the `path` from the start to the end
- Display the `route`, `number of nodes visited`, `number of nodes expanded`, and `execution time` in the GUI

<a name="technologies-used"></a>

## Technologies Used
- Microsoft Visual Studio 2022 - version 17.4.3
- Microsoft .NET Framework - version 4.8.04084
- C# Tools - version 4.4.0

> Note: The version of the libraries above is the version that we used in this project. You can use the latest version of the libraries.

<a name="setup"></a>

## Setup
1. Download the latest version of Microsoft Visual Studio 2022 [here](https://visualstudio.microsoft.com/downloads/)
2. Download the latest version of Microsoft .NET Framework [here](https://dotnet.microsoft.com/download/dotnet-framework)
3. Download the latest version of C# Tools [here](https://marketplace.visualstudio.com/items?itemName=ms-vscode.csharp)
4. Install all the tools above
5. Clone this repository to your local directory by using this command in your terminal
```bash
git clone https://github.com/rifqifarhansyah/Tubes2_dicarryVieridanZaki.git
```

<a name="usage"></a>

## Usage
1. Open the project in Visual Studio
2. To open to the project, you can use the following steps:
    - Click `File` in the top left corner
    - Click `Open` > `Project/Solution`
    - Navigate to the directory where you clone this repository
    - Go to `Tubes2_dicarryVieridanZaki/src/TreasureHunterApp` folder
    - Click `TreasureHunterApp.cspoj`
3. After the project is opened, you can run the program by clicking the `Start` button in the top center of the screen


<a name="videocapture"></a>

## Video Capture
<nl>

![Treasure Hunt Gif](https://github.com/rifqifarhansyah/Tubes2_dicarryVieridanZaki/blob/main/img/TreasureHunter.gif?raw=true)

<a name="screenshots"></a>

## Screenshots
<p>
  <img src="/img/SS1.png/">
  <p>Figure 1. Config File (*txt)</p>
  <nl>
  <img src="/img/SS2.png/">
  <p>Figure 2. Initial Appearance of the Program</p>
  <nl>
  <img src="/img/SS3.png/">
  <p>Figure 3. Result</p>
  <nl>
</p>

<a name="structure"></a>

## Structure
```bash
│   .gitignore
│   README.md
│
├───.vs
│   │   slnx.sqlite
│   │   tasks.vs.json
│   │   VSWorkspaceState.json
│   │
│   ├───Tubes2_13521099
│   │   ├───FileContentIndex
│   │   │       1f6478ed-6d4c-41fc-8310-5fee686d57d6.vsidx
│   │   │       ac8a0297-178a-4a4d-a8d1-07438962f32a.vsidx
│   │   │       e43822dc-b10f-4363-b8c2-785d1c86a63c.vsidx
│   │   │       e6333f6e-1a45-47ad-901e-a8e062fddfcc.vsidx
│   │   │       read.lock
│   │   │
│   │   └───v17
│   │       │   .wsuo
│   │       │
│   │       └───TestStore
│   │           └───0
│   │                   000.testlog
│   │                   testlog.manifest
│   │
│   └───Tubes2_dicarryVieridanZaki
│       ├───config
│       │       applicationhost.config
│       │
│       ├───FileContentIndex
│       │   │   4b29f879-a239-43be-9a68-07ac62d0e9b4.vsidx
│       │   │   889e720c-070c-427e-990c-c9f72a560e0c.vsidx
│       │   │   c1c03b34-790f-4f39-8c9f-62fa4479e509.vsidx
│       │   │   d1b3419b-27f8-456f-b4ab-dc96299f3e8a.vsidx
│       │   │   read.lock
│       │   │
│       │   └───merges
│       └───v17
├───bin
│       try.exe
│
├───doc
│       dicarryVieridanZaki.pdf
│       Tubes2-Stima-2023_230302_144558.pdf
│
├───img
│       icons8-treasure-chest-80.png
│       KrustyKrab.png
│       SS1.png
│       SS2.png
│       SS3.png
│       Treasure.png
│       TreasureHunter.gif
│
├───src
│   └───TreasureHunterApp
│       │   App.config
│       │   App.xaml
│       │   App.xaml.cs
│       │   BackendDebugger.cs
│       │   BFS.cs
│       │   ColorExtension.cs
│       │   DFS.cs
│       │   icons8-treasure-chest-80.png
│       │   KrustyKrab.png
│       │   MainWindow.xaml
│       │   MainWindow.xaml.cs
│       │   Maze.cs
│       │   microsoft.windowsapicodepack-shell.1.1.0.nupkg
│       │   Node.cs
│       │   SolidColorBrushComparer.cs
│       │   TreasureHunterApp.csproj
│       │   TreasureHunterApp.sln
│       │   treasurehuntericon.png
│       │
│       ├───.vs
│       │   └───TreasureHunterApp
│       │       ├───FileContentIndex
│       │       │   │   3bb406fe-d952-4fed-aa2c-3b9259ff21c5.vsidx
│       │       │   │   7b7c6e4d-2511-4009-879c-e5e758aac6fb.vsidx
│       │       │   │   ea878ab6-94b1-4c06-92a6-cec77e62db26.vsidx
│       │       │   │   read.lock
│       │       │   │
│       │       │   └───merges
│       │       └───v17
│       ├───bin
│       │   ├───Debug
│       │   │       TreasureHunterApp.exe
│       │   │       TreasureHunterApp.exe.config
│       │   │       TreasureHunterApp.pdb
│       │   │
│       │   └───Release
│       ├───obj
│       │   ├───Debug
│       │   │   │   .NETFramework,Version=v4.7.2.AssemblyAttributes.cs
│       │   │   │   App.g.cs
│       │   │   │   App.g.i.cs
│       │   │   │   DesignTimeResolveAssemblyReferences.cache
│       │   │   │   DesignTimeResolveAssemblyReferencesInput.cache
│       │   │   │   MainWindow.baml
│       │   │   │   MainWindow.g.cs
│       │   │   │   MainWindow.g.i.cs
│       │   │   │   TreasureHunterApp.csproj.AssemblyReference.cache
│       │   │   │   TreasureHunterApp.csproj.CoreCompileInputs.cache
│       │   │   │   TreasureHunterApp.csproj.FileListAbsolute.txt
│       │   │   │   TreasureHunterApp.csproj.GenerateResource.cache
│       │   │   │   TreasureHunterApp.csproj.SuggestedBindingRedirects.cache
│       │   │   │   TreasureHunterApp.exe
│       │   │   │   TreasureHunterApp.g.resources
│       │   │   │   TreasureHunterApp.pdb
│       │   │   │   TreasureHunterApp.Properties.Resources.resources
│       │   │   │   TreasureHunterApp_Content.g.i.cs
│       │   │   │   TreasureHunterApp_MarkupCompile.cache
│       │   │   │   TreasureHunterApp_MarkupCompile.i.cache
│       │   │   │   TreasureHunterApp_MarkupCompile.lref
│       │   │   │
│       │   │   └───TempPE
│       │   │           Properties.Resources.Designer.cs.dll
│       │   │
│       │   └───Release
│       │           .NETFramework,Version=v4.7.2.AssemblyAttributes.cs
│       │           App.g.cs
│       │           MainWindow.g.cs
│       │           TreasureHunterApp.csproj.AssemblyReference.cache
│       │           TreasureHunterApp_MarkupCompile.cache
│       │           TreasureHunterApp_MarkupCompile.lref
│       │
│       └───Properties
│               AssemblyInfo.cs
│               Resources.Designer.cs
│               Resources.resx
│               Settings.Designer.cs
│               Settings.settings
│
└───test
        test.txt
        test1.txt
        test10.txt
        test11.txt
        test12.txt
        test2.txt
        test4.txt
        test5.txt
        test6.txt
        test7.txt
        test8.txt
        test9.txt
```

<a name="project-status">

## Project Status
Project is: _complete_

<a name="room-for-improvement">

## Room for Improvement
Room for Improvement:
- Improve the effectiveness of the BFS and DFS algorithm implementation
- Add more features

<a name="acknowledgements">

## Acknowledgements
- Thanks To Allah SWT

<a name="contact"></a>

## Contact
<h4 align="center">
  Contact Us : dicarryVieridanZaki<br/>
  2023
</h4>
<hr>
