# Test Task for Software Developers

## Objective

Modernize a small .NET Framework application to dotnet 9, ensuring compatibility with C++ interop, manual loading of the C++ library, and
containerization. Optionally, expose the simple operation via a Web API.

## Requirements

 1. Create a simple .NET Framework application using C# that includes:
- A basic UI with a button and a text box, 
- A C++ class library that    performs a simple operation (e.g., string manipulation or       mathematical calculation), 
- Implement C++ interop to call the C++     class library from the C# application;
 2. Migrate the .NET Framework application to dotnet 9, following best practices for modernization:
- Update the project file format (e.g., from .csproj to .NET SDK-style projects),
- Replace any deprecated APIs with their newer equivalents,
- Ensure the application uses the latest C# language features where appropriate;
3. Manually load the C++ library instead of using DllImport:
- Use the manual loading to load the C++ library (do not use DllImport);
4. Expose the simple operation via a Web API:
- Create a dotnet 9 Web API project and reference the modernized application,
- Implement a controller with a route that calls the simple operation from the C++ library,
- Ensure the Web API can be accessed and executed correctly;
5. Containerize the application using Docker:
- Create a Dockerfile to define the container image,
- Choose an appropriate base image for the dotnet 9 application (Debian 12 is strongly recommended),
- Configure the container to run the application correctly.

Ensure the application still functions correctly after modernization, that the C++ interop continues to work as expected, and that the containerized
application runs
successfully.
Provide a brief documentation on the steps you took during the modernization process, including any challenges faced and the solutions you implemented
to
overcome them.

## Deliverables

 1. The original .NET Framework application source code; 
 2. C++ library source code; 
 3. The updated dotnet 9 application source code with C++ interop; 
 4. The Dockerfile and any necessary configuration files for containerization; 
 5. Documentation detailing the modernization process.

Candidates are expected to cover the source code by unit tests, regression tests, e2e tests, load tests, and fuzzing tests. It is prohibited to use Visual
Studio based project and solution configurations
