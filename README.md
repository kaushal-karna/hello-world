# Hello C#

A compact, runnable C# learning project. It turns common language concepts into small, focused examples you can read, run, and change.

## What's included

- Clear examples for C# fundamentals, control flow, methods, strings, collections, object-oriented programming, and safe input handling.
- A single command-line launcher for discovering and running examples.
- A [topic index](docs/TOPICS.md) that links each concept to its source file.
- Additional explanatory notes in [detailed.md](detailed.md).

## Requirements

- [.NET 10 SDK](https://dotnet.microsoft.com/download) or a compatible SDK for the target framework in `Hello.csproj`.

## Quick start

```bash
git clone <your-repository-url>
cd Hello
dotnet run -- --list
```

Run one topic:

```bash
dotnet run -- strings
```

Run every example:

```bash
dotnet run -- --all
```

## Project layout

```text
Hello/
├── Examples/       # Small, focused runnable topic examples
├── Models/         # Supporting domain classes used by examples
├── docs/           # Topic index and project documentation
├── Program.cs      # Console launcher and topic selection
├── detailed.md     # Extended C# learning notes
└── Hello.csproj    # .NET project configuration
```

## Learning path

Start with **Basics**, then continue through **Control flow**, **Methods**, **Strings**, and **Collections**. Finish with **OOP** and **Exception handling**. The complete order and source-file links are in the [Topics Index](docs/TOPICS.md).

## Contributing

New examples should live in `Examples/`, keep their output deterministic, and expose a `Run()` method. Add the topic to `Program.cs` and `docs/TOPICS.md` so it is easy to discover.

## License

Distributed under the terms in [LICENSE](LICENSE).
