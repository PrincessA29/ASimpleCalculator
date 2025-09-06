# Simple Calculator

A console-based calculator application built with C# (.NET 9.0) that performs basic arithmetic operations.

## 📋 Table of Contents
- [Overview](#overview)
- [Features](#features)
- [Requirements](#requirements)
- [Installation](#installation)
- [Usage](#usage)
- [Design Architecture](#design-architecture)
- [Code Structure](#code-structure)
- [Error Handling](#error-handling)
- [Examples](#examples)
- [Future Enhancements](#future-enhancements)
- [Contributing](#contributing)

## 🎯 Overview

This Simple Calculator is a console application designed to demonstrate fundamental C# programming concepts including:
- User input handling
- Type casting and conversion
- Arithmetic operations
- Control structures (switch statements, if-else)
- Exception handling
- String validation

## ✨ Features

### Core Functionality
- ➕ **Addition** - Add two integers
- ➖ **Subtraction** - Subtract two integers  
- ✖️ **Multiplication** - Multiply two integers
- ➗ **Division** - Divide two integers (with decimal results)

### User Experience
- 🧹 **Screen Clearing** - Automatically clears console on startup
- 📝 **Input Validation** - Validates user input for numbers and operations
- ⚠️ **Error Handling** - Comprehensive error messages for invalid inputs
- 🔢 **Multiple Result Formats** - Shows both decimal and integer results where applicable
- 🛡️ **Division by Zero Protection** - Prevents crashes from division by zero

## 🔧 Requirements

### Software Dependencies
- **.NET 9.0 SDK** or later
- **Visual Studio Code** (recommended) with C# extensions
- **Windows**, **macOS**, or **Linux** operating system

### Development Environment Setup
1. Install [.NET 9.0 SDK](https://dotnet.microsoft.com/download)
2. Install [Visual Studio Code](https://code.visualstudio.com/)
3. Install C# Dev Kit extension in VS Code

## 🚀 Installation

### Clone/Download Project
```bash
# Create project directory
mkdir SimpleCalculator
cd SimpleCalculator

# Initialize .NET console project
dotnet new console -f net9.0

# Replace Program.cs with calculator code
```

### Build Project
```bash
# Restore dependencies
dotnet restore

# Build the project
dotnet build

# Run the application
dotnet run
```

## 💻 Usage

### Running the Calculator
```bash
dotnet run
```

### Interactive Flow
1. **Launch** - Application clears screen and displays welcome message
2. **First Number** - Enter any integer when prompted
3. **Second Number** - Enter any integer when prompted
4. **Operation Selection** - Choose from `+`, `-`, `*`, or `/`
5. **Results** - View calculated results in multiple formats
6. **Exit** - Press any key to close the application

### Input Examples
```
Enter the first number: 15
Enter the second number: 4
Enter your choice (+, -, *, /): /
```

## 🏗️ Design Architecture

### Application Flow
```
┌─────────────────┐
│   Application   │
│      Start      │
└─────────┬───────┘
          │
          ▼
┌─────────────────┐
│  Clear Screen   │
│ Display Welcome │
└─────────┬───────┘
          │
          ▼
┌─────────────────┐
│  Get First      │
│    Number       │
└─────────┬───────┘
          │
          ▼
┌─────────────────┐
│  Get Second     │
│    Number       │
└─────────┬───────┘
          │
          ▼
┌─────────────────┐
│  Get Operation  │
│    Choice       │
└─────────┬───────┘
          │
          ▼
┌─────────────────┐
│   Perform       │
│  Calculation    │
└─────────┬───────┘
          │
          ▼
┌─────────────────┐
│  Display        │
│   Results       │
└─────────┬───────┘
          │
          ▼
┌─────────────────┐
│   Wait for      │
│   User Exit     │
└─────────────────┘
```

### Class Structure
```
SimpleCalculator (Namespace)
└── Program (Class)
    └── Main(string[] args) (Static Method)
        ├── Input Validation Methods
        ├── Type Conversion Logic
        ├── Arithmetic Operations
        └── Error Handling
```

## 📁 Code Structure

### Project Files
```
SimpleCalculator/
├── Program.cs              # Main application logic
├── SimpleCalculator.csproj # Project configuration
├── README.md              # Project documentation
├── bin/                   # Compiled binaries
│   └── Debug/
│       └── net9.0/
└── obj/                   # Build artifacts
    └── Debug/
        └── net9.0/
```

### Key Code Components

#### 1. Input Handling
```csharp
string? input1 = Console.ReadLine();
if (string.IsNullOrWhiteSpace(input1))
{
    Console.WriteLine("Error: Please enter a valid number!");
    return;
}
int number1 = Convert.ToInt32(input1);
```

#### 2. Operation Selection
```csharp
switch (operation)
{
    case "+":
        result = number1 + number2;
        break;
    // ... other cases
}
```

#### 3. Error Management
```csharp
try
{
    // Main logic
}
catch (FormatException)
{
    Console.WriteLine("Error: Please enter valid numbers only!");
}
catch (OverflowException)
{
    Console.WriteLine("Error: Number is too large!");
}
```

## ⚠️ Error Handling

### Input Validation Errors
| Error Type | Trigger | Response |
|------------|---------|----------|
| **Null Input** | Empty or whitespace input | "Please enter a valid number!" |
| **Format Error** | Non-numeric input | "Please enter valid numbers only!" |
| **Overflow** | Number too large/small | "Number is too large or too small!" |
| **Division by Zero** | Dividing by 0 | "Cannot divide by zero!" |
| **Invalid Operation** | Wrong operator | "Invalid operation! Use +, -, *, /" |

### Exception Handling Strategy
- **Graceful Degradation** - Application continues running after non-fatal errors
- **User-Friendly Messages** - Clear, actionable error descriptions
- **Input Sanitization** - Validates all user inputs before processing
- **Safe Exit** - Always provides option to exit cleanly

## 📊 Examples

### Successful Calculations
```
=== Simple Calculator ===

Enter the first number: 25
Enter the second number: 7

Choose an operation:
+ for Addition
- for Subtraction
* for Multiplication
/ for Division
Enter your choice (+, -, *, /): +

Result: 25 + 7 = 32
Result as integer: 32

Press any key to exit...
```

### Division Example
```
Enter the first number: 22
Enter the second number: 7
Enter your choice (+, -, *, /): /

Result: 22 / 7 = 3.14

Press any key to exit...
```

### Error Example
```
Enter the first number: abc
Error: Please enter valid numbers only!

Press any key to exit...
```

## 🚀 Future Enhancements

### Planned Features
- [ ] **Continuous Operation** - Allow multiple calculations without restart
- [ ] **Memory Functions** - Store and recall previous results
- [ ] **Advanced Operations** - Square root, power, modulus
- [ ] **History Log** - Track calculation history
- [ ] **Decimal Input** - Support for floating-point numbers
- [ ] **Expression Parser** - Handle complete mathematical expressions
- [ ] **GUI Version** - Windows Forms or WPF interface
- [ ] **Unit Tests** - Comprehensive test coverage

### Code Improvements
- [ ] **Modular Design** - Separate classes for different operations
- [ ] **Configuration** - External settings file
- [ ] **Logging** - File-based operation logging
- [ ] **Input Parsing** - More robust input validation
- [ ] **Internationalization** - Multi-language support

## 🤝 Contributing

### Development Guidelines
1. **Code Style** - Follow C# naming conventions
2. **Error Handling** - Always include appropriate exception handling
3. **Documentation** - Comment complex logic thoroughly
4. **Testing** - Test all input scenarios before committing

### Contribution Process
1. Fork the repository
2. Create a feature branch (`git checkout -b feature/new-feature`)
3. Make your changes with appropriate tests
4. Commit your changes (`git commit -am 'Add new feature'`)
5. Push to the branch (`git push origin feature/new-feature`)
6. Create a Pull Request

## 📄 License

This project is licensed under the MIT License - see the LICENSE file for details.

## 👥 Authors

- **Princess Joeby** - Initial development and design

## 🙏 Acknowledgments

- Microsoft .NET Documentation
- C# Programming Community
- Visual Studio Code Extensions Team

---

*Built with ❤️ using C# and .NET 9.0*
