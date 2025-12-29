# SharpShowcase

Hi there! 👋

I built **SharpShowcase** to demonstrate some of the cool things you can do with a clean, modular Console Application in .NET 9.0.

Since I'm currently looking for an IT job, I created this project as a personal playground to test out popular libraries like **Serilog** and **Humanizer**, while focusing on writing high-quality, maintainable code. It's safe to say this is not your average "Hello World" app—it features structured logging, an interactive menu system, and a solid architecture.

I hope you enjoy exploring the code as much as I enjoyed writing it!

## 🚀 What's Inside?

The application is an interactive CLI that lets you play with different demos:
-   **ASCII Art**: Generate cool banners using `Figgle`.
-   **Humanizer Playground**: See how to turn data into human-readable strings (like "2 hours ago" or "1st", "2nd").
-   **Structured Logging**: Verify how logs are captured in the console and rolling file logs.

## 🛠️ Tech Stack & Libraries

I used **.NET 9.0** and **C# 12** to build this. Here are the key libraries I integrated:

-   **`Figgle.Fonts`**: For those awesome ASCII banners.
-   **`Humanizer`**: To make data friendly for humans.
-   **`Serilog`**: For professional-grade logging to Console and Files.

## 📂 How I Structured It

I wanted to keep the code organized, so I split things up:
-   **`Configuration/`**: Keeps the setup logic (like Logging) separate from the app logic.
-   **`Demos/`**: Each feature has its own dedicated file (e.g., `FiggleDemo.cs`), so it's easy to read and extend.
-   **`Menu/`**: Handled the user interaction loop so the app doesn't just exit after one action.
-   **`Program.cs`**: The entry point is super clean—it just sets up logging and starts the menu.

## 🏁 Give It a Spin

If you have [.NET 9.0 SDK](https://dotnet.microsoft.com/download/dotnet/9.0) installed, you can run this right away:

1.  **Clone the repo**:
    ```bash
    git clone https://github.com/voldemorthack01/SAD.git
    ```
2.  **Go to the folder**:
    ```bash
    cd SAD
    ```
3.  **Run it**:
    ```bash
    dotnet run
    ```
    *(Note: You might still see the folder named "SAD" because that was the original codename, but the heart of the project is now SharpShowcase!)*

---
*Built with ❤️ (and C#) by a passionate developer ready for their next challenge.*