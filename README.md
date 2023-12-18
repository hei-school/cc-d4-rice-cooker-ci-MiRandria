# Rice Cooker Application

## Overview

This is a simple rice cooker application written in C#. It provides basic functionalities for cooking rice, including monitoring for overheating during the cooking process and ensuring the quality of the rice meets specified criteria.

## Functionalities:

- **Cook Rice (`CuireRiz`):**
  - Initiates the rice cooking process.
  - Monitors for overheating during the cooking process.
  - Ensures the quality of the rice meets specified criteria.
  - Example: `cuiseur.CuireRiz`

- **Keep Warm (`MaintienChaud`):**
  - Maintains the cooked rice warm for a specified duration.
  - Example: `cuiseur.MaintienChaud`

## Linter for C#
https://github.com/hei-school/cc-d4-rice-cooker-ci-MiRandria/blob/feature/C%23/stylecop.json
For linting C# code, you can use a linter such as StyleCop.Analyzers. Here's how you can set it up:

1. Add the StyleCop.Analyzers NuGet package to your project. You can do this using the Package Manager Console:

    ```bash
    Install-Package StyleCop.Analyzers
    ```

    Or using the .NET CLI:

    ```bash
    dotnet add package StyleCop.Analyzers
    ```
2. Run StyleCop.Analyzers during the build process using the following command:

    ```bash
    dotnet build
    ```

4. Or use a code editor extension that supports StyleCop.

## Unit Testing

For unit testing in C#, you can use the built-in MSTest, NUnit, or xUnit. Here's a basic example using MSTest:
   . Run the tests using the following command:

    ```bash
    dotnet test
    ```

Feel free to adjust these instructions based on your specific project structure and preferences.
