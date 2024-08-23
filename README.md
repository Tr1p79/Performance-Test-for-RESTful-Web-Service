# PerformanceTestService

## Overview

This project demonstrates how to perform end-to-end performance testing on a RESTful web service using C# and BenchmarkDotNet.

### Components

1. **PerformanceTestService**: A simple ASP.NET Core Web API that responds with a basic message.
2. **PerformanceTestClient**: A console application that uses BenchmarkDotNet to measure the performance of the web service.

## How to Run

### 1. Setting Up the Web Service

- Open the `PerformanceTestService` project in Visual Studio.
- Run the project (`Ctrl + F5`). The web service will start and should be accessible at `http://localhost:{port}/api/test`. 

### 2. Running the Performance Test

- Open the `PerformanceTestClient` project in Visual Studio.
- Change the port in `Program.cs` on line `11` to match the port of the `PerformanceTestService`.
- Run the project (`Ctrl + F5`). BenchmarkDotNet will execute and generate a performance report.

### 3. Viewing the Report

- After running the performance test, BenchmarkDotNet will generate reports in the `BenchmarkDotNet.Artifacts` folder.
- Open the `.html` report for detailed metrics and analysis.

## Project Structure

- **/PerformanceTestService**: Contains the ASP.NET Core Web API project.
- **/PerformanceTestClient**: Contains the console application for performance testing.

## Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) (version 6.0 or later)
- [Visual Studio 2022](https://visualstudio.microsoft.com/downloads/)
- BenchmarkDotNet (included in the client project)

