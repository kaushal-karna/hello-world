<!-- markdownlint-disable MD020 -->
# About Hello C#

## Purpose

Hello C# is a small console application designed as a practical learning space for C#. Instead of placing every lesson in one long file, the project keeps each topic in a focused example that can be run from a single command-line launcher.

It is intended for beginners who want to read real, working C# code and experiment with one concept at a time.

## What you can learn

The project currently includes examples for:

- Variables, basic data types, arithmetic, and string interpolation
- Conditions and loops
- Creating and calling methods
- Common string operations
- Lists and collection basics
- Classes, properties, and encapsulation
- Handling invalid input safely with `TryParse`

The complete list of topics and their source files is available in [docs/TOPICS.md](docs/TOPICS.md).

## How it works

`Program.cs` is the application entry point. It contains a list of topic names and connects each name to the matching example's `Run()` method.

For example, this command starts the strings example:

```bash
dotnet run -- strings
```

The launcher also supports the following commands:

```bash
# Show every available topic
dotnet run -- --list

# Run every example in sequence
dotnet run -- --all
```

## Project structure

```text
Hello/
├── Examples/       # One small class per learning topic
├── Models/         # Supporting classes used by examples
├── docs/           # Topic index and project documentation
├── Program.cs      # Console launcher
├── detailed.md     # Longer C# notes and explanations
├── README.md       # Quick-start project guide
└── Hello.csproj    # .NET project configuration
```

## Running the project

1. Install the .NET SDK compatible with the version specified in `Hello.csproj`.
2. Open a terminal in the project directory.
3. Run `dotnet run -- --list` to see the available examples.
4. Run a topic, such as `dotnet run -- basics`.

## Adding a new example

To add another topic:

1. Create a new class in `Examples/` with a public static `Run()` method.
2. Add its topic name and `Run()` method to the `Topics` dictionary in `Program.cs`.
3. Add the topic to [docs/TOPICS.md](docs/TOPICS.md).
4. Build the project with `dotnet build`.

Keeping examples short, deterministic, and focused makes the project easier to navigate and learn from.

## License

This project is available under the [MIT License](LICENSE).
