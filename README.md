# ST10474260_POEPART1 
# Cybersecurity Awareness ChatBot (C# Console App)

## Project Overview
The **Cybersecurity Awareness ChatBot** is a simple console-based application developed in C#.  
Its purpose is to educate users about basic cybersecurity practices such as:

- Password safety 
- Phishing awareness   
- Safe browsing   

The chatbot uses a **menu-driven interface** instead of free-text parsing, making it structured, user-friendly, and suitable for learning environments.

---

## Features

- Console-based user interface  
- ASCII art logo display  
- Typing effect for responses  
- Menu-driven interaction (no `.Contains()` used)  
- User input and personalization  
- Optional audio greeting support  
- Continuous interaction loop until exit  

## How It Works

1. The program starts and displays a logo.
2. The user is prompted to enter their name.
3. A menu of cybersecurity topics is displayed.
4. The user selects an option (1–6).
5. The chatbot responds with relevant information.
6. The program continues until the user chooses **Exit**.

---

## Concepts Used

- Classes and Objects (OOP)
- Methods and Properties
- Switch Statements
- Loops (`while`)
- Input Validation
- Console Styling (`ConsoleColor`)
- Basic Exception Handling

---

## How to Run the Program

### Requirements:
- Visual Studio or any C# IDE  
- .NET SDK installed  

### Steps:
1. Open the project in Visual Studio  
2. Add all `.cs` files to the project  
3. Build the solution  
4. Run the program 

---

## Optional Audio Feature

To enable the greeting sound:

1. Add a `.wav` file (e.g., `greeting.wav`) to your project folder  
2. Uncomment the following lines in `AudioPlayer.cs`:

```csharp
SoundPlayer player = new SoundPlayer("greeting.wav");
player.Play();

##
![The Screenshot below shows how the users input will be executed/shown to them.] 
(<img width="1103" height="570" alt="Screenshot 2026-04-13 140324" src="https://github.com/user-attachments/assets/8381edd3-b573-4e20-94b9-9ac668e79c52" />)



