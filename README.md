# Inventory Management System

A console-based inventory management application built in C# to 
simulate real-world stock tracking for a small business or store.

## Features
- Add new inventory items with initial stock quantity
- View all items with current stock levels
- Sell items with automatic stock validation (prevents overselling)
- Restock existing items
- Low-stock alerts for items falling below a defined threshold

## Tech Stack
- C# (.NET)
- Console Application
- In-memory data storage using `Dictionary<string, int>`

## What I Learned
This project was built to practice core C# fundamentals:
loops, switch-case menus, methods, and dictionary-based data handling,
along with input validation and edge-case handling (e.g. preventing 
negative stock).

## How to Run
1. Clone the repository
2. Open the project in Visual Studio / VS Code
3. Run `dotnet run` or launch via the IDE
