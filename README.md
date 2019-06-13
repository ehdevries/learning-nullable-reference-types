## Overview

This is a simple console application to demonstrate Nullable Reference Types, a new feature in .NET Core 3 and C# 8 (both of which are in public preview at the time of writing).
There is an [accompanying blog post](http://www.bravolt.com/blog/nullable-reference-types/) that walks through the code and discusses the feature in more detail.

The Nullable Reference Types feature, when enabled, allows you to indicate which reference type variables should be allowed to be null.
It then provides some helpful compiler warnings to ensure you're avoiding null where it shouldn't occur and responsibly checking for null where it might occur.
The goal is to help you write safer, more expressive code with fewer of those pesky `NullReferenceException`s we all know and love.

This demo app pretends to retrieve a record from a data store that represents a person, then counts the total number of letters in the person's name and prints the name and letter count to the console.
It's the garden-variety nullability example, since a lot of times we don't know someone's middle name.
Making the middle name nullable opens up the risk of dereferencing a null value and ending up with a `NullReferenceException`.
Nullable Reference Types can help us avoid this.

## Setup

This app was created with the following:

- [.NET Core SDK 3.0](https://dotnet.microsoft.com/download/dotnet-core/3.0) (preview 3 or later)
- [Visual Studio Code](https://code.visualstudio.com/)
- [The C# extension for VS Code](https://marketplace.visualstudio.com/items?itemName=ms-vscode.csharp)

Note that all of these tools are available cross-platform (Windows, Mac, and Linux).

Also note that, because .NET Core 3 and C# 8 are still in preview, the feature may change before it becomes generally available.

## Run

Using the .NET Core CLI (installed with the .NET Core SDK), you can build and run the app by navigating to the project directory and invoking `dotnet build` and `dotnet run`.

If you're using the preview release like I did and you're not seeing the compiler warnings you expect, try invoking `dotnet clean` followed by `dotnet build`.

## Learn

The commits in this repository are intended to help you learn how to take advantage of the Nullable Reference Types feature.

Checking out each commit in order will walk you through the process of creating the app, introducing some bugs that can lead to `NullReferenceException`s, enabling the Nullable Reference Types feature, and utilizing the compiler warnings it provides to find and fix the bugs.
However, checking out commits by hash is a bit cumbersome, so for convenience, there are tags indicating sequential steps that you can check out instead.

I recommend you check out each tag in order (`step-1`, `step-2`, etc.).
At each step, try to build and run the app to see what happens (`dotnet build` and `dotnet run`).
Then inspect what has changed (`git log --oneline -p`).
And, of course, tinker to your heart's content.

For further reference (pun intended), these are some helpful articles:

- *[Introducing Nullable Reference Types in C#](https://devblogs.microsoft.com/dotnet/nullable-reference-types-in-csharp/)* by Mads Torgerson
- Microsoft's [official guide](https://docs.microsoft.com/en-us/dotnet/csharp/nullable-references) to Nullable Reference Types
- Microsoft's [official tutorial](https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/nullable-reference-types) on Nullable Reference Types
