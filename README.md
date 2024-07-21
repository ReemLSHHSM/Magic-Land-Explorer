### Magic Land Explorer

## Introduction
Magic Land Explorer is a console application that allows users to explore various destinations within Magic Land, including rides, shows, and dining options. The application reads data from a JSON file, processes it using LINQ queries, and provides an interactive interface for users to query and view the data.

## Features
- Load and parse JSON data about destinations.
- Perform LINQ queries to filter and sort destinations.
- Display results interactively via the console.
- Use delegates to handle user interactions and display information.
- Handle invalid user inputs and missing data gracefully.


## How It Works

- **Reading JSON Data**: 
    csharp
    string json = File.ReadAllText("data/MagicLandData.json");
    List<Category> categories = JsonConvert.DeserializeObject<List<Category>>(json);
    
- **LINQ Queries**: Used to filter and sort the data.
- **Delegates**: Handle user interactions and display information.

## Error Handling

- Ensures proper handling of invalid user inputs.
- Provides meaningful error messages and prompts for re-input.

## Requirements

- .NET Core
- Newtonsoft.Json
