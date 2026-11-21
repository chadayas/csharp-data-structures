# C# quick start

C# is the language; the .NET SDK supplies the compiler, CLI, and runtime.
Installed: **.NET SDK 10.0.404 (10 LTS)** in `~/.dotnet`, on your Bash PATH.

## Create your first project

```bash
cd ~/documents/projects/c_sharp
dotnet --version
dotnet new console -n HelloCSharp --framework net10.0
cd HelloCSharp
dotnet run              # Builds and runs: Hello, World!
```

Edit `Program.cs`, then run again. The template needs no explicit `Main` method.
`HelloCSharp.csproj` holds project settings, dependencies, and target framework.
`bin/` and `obj/` are generated output; do not edit or commit them.

## Everyday commands

```bash
dotnet build            # Compile without running
dotnet run              # Compile and run
dotnet run -- arg1      # Pass arguments to your program (available as args)
dotnet watch run        # Reload/restart on edits; Ctrl-C to stop
dotnet restore          # Fetch dependencies; build/run do this automatically
dotnet test             # Run tests in a test project or solution containing one
dotnet build -c Release # Optimized build
```

Run these inside your project directory. Add dependencies with
`dotnet add package PACKAGE_NAME`, replacing the name with a real NuGet package.

## Shell setup and next steps

New Bash terminals load the SDK automatically. For an already-open terminal:
```bash
export DOTNET_ROOT="$HOME/.dotnet"
export PATH="$DOTNET_ROOT:$PATH"
```

For work repos, follow their `global.json` SDK and `.csproj` target framework.
This user-local SDK is not updated by apt; use the [official installer](https://learn.microsoft.com/en-us/dotnet/core/install/linux-scripted-manual) for updates.

Learn: variables/loops → methods/classes → collections/LINQ → async/await.
[Microsoft C# tutorials](https://learn.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/tutorials/)
