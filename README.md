# TDD-ImmutableStack

Implementation of an Immutable Stack to learn TDD using C#.

The testing framework that will be used is MSTest.

Immutable stacks cannot change its state so when method try to change them a new copy is returned.

# Stack Behavior

- Pop: An item can be popped off the stack.
- Last In First Out (LIFO) Stack.
- An empty stack doesn’t cause failure (throwing an exception).
- Null values cannot be pushed into the stack.

## Prerequisites

| **Programming Language** | **Testing Framework** | **Code editor**    | **Runtime** |
| ------------------------ | --------------------- | ------------------ | ----------- |
| C#                       | MSTest                | Visual Studio Code | .NET Core   |

## Creating The Project using a bash script

- Give execution permissions to create_project_TDD.sh in case it does not have them:

`chmod +x create_project_TDD.sh`

- Simply execute the bash script giving it as a parameter the name of the Project:

`./create_project_TDD.sh ImmutableStack`

**NOTE:** The script will check whether dotnet is installed and in case it is not, it will install it (only available for LINUX/MACOSX computers).

## Creating The Project From Scratch

- Go to the directory where you want your project to be and run:

`dotnet new sln -o TDD-ImmutableStack`

- Go to that newly created directory

`cd TDD-ImmutableStack`

- Create a new class lib:

`dotnet new classlib -o ImmutableStack.Library`

**NOTE:** The dotnet new classlib command creates a new class library project in the ImmutableStack.Library folder. The new class library will contain the code to be tested.

- Rename the file Class1.cs to ImmutableStackService.cs

`mv ./ImmutableStack.Library/Class1.cs ./ImmutableStack.Library/ImmutableStackService.cs`

- Run the following command to add the class library project to the solution:

`dotnet sln add ./ImmutableStack.Library/ImmutableStack.Library.csproj`

- Create the ImmutableStack.Tests project by running the following command:

`dotnet new mstest -o ImmutableStack.Tests`

- Rename the file UnitTest1.cs to ImmutableStackTests.cs

`mv ./ImmutableStack.Tests/UnitTest1.cs ./ImmutableStack.Tests/ImmutableStackTests.cs`

- Add the test project to the solution file by running the following command:

`dotnet sln add ./ImmutableStack.Tests/ImmutableStack.Tests.csproj`

- Add the ImmutableStackService class library as a dependency to the ImmutableStack.Tests project:

`dotnet add ./ImmutableStack.Tests/ImmutableStack.Tests.csproj reference ./ImmutableStack.Library/ImmutableStack.Library.csproj`

## Running the tests

- To run the tests, we will use a tool called dotnetWatcher. In order for it to work properly run:

`dotnet watch -p ./ImmutableStack.Tests/ test`

**NOTE:** The dotnet Watcher allows us to watch our code and rerun all our tests anytime a code file is changed and saved.
