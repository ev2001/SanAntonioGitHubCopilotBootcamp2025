# UrlListApp

UrlListApp is an ASP.NET Core web application included in the San Antonio GitHub Copilot Bootcamp 2025 workspace. It demonstrates how to build minimal API endpoints and a simple web UI using C# and .NET 9.

## Features

- **Weather Forecast Endpoints**
  - `/weatherforecast`: Returns a 5-day random weather forecast.
  - `/weatherforecast/{city}`: Returns a 5-day random weather forecast for a specified city.
- **Greeting Endpoint**
  - `/greet`: Returns a welcome message for the bootcamp.
- **Rain Prediction Endpoint**
  - `/willitrain`: Randomly tells you if it will rain or not.
- **MVC Pages**
  - Razor Pages for home, privacy, and error handling.
  - Bootstrap-based layout and static assets in `wwwroot/`.

## How to Run

1. **Prerequisites:**
   - [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) is required (already included in this dev container).

2. **Build and Run the Project:**
   ```bash
   dotnet run --project UrlListApp/UrlListApp.csproj
   ```
   The app will be available at `https://localhost:5001` (or the port shown in the terminal).

3. **Explore the App:**
   - Visit the root URL in your browser to see the web UI.
   - Use API tools (like Postman or curl) to access the endpoints:
     - `GET /weatherforecast`
     - `GET /weatherforecast/{city}`
     - `GET /greet`
     - `GET /willitrain`

4. **OpenAPI/Swagger UI:**
   - In development mode, OpenAPI documentation is available at `/openapi`.

## Project Structure

- `UrlListApp/Program.cs`: Main entry point and endpoint definitions.
- `UrlListApp/Pages/`: Razor Pages for the web UI.
- `UrlListApp/wwwroot/`: Static files (CSS, JS, images, libraries).
- `UrlListApp/Properties/`: Launch settings and configuration.

## Notes
- All weather data and rain predictions are randomly generated for demonstration purposes.
- This project is intended for educational use at the bootcamp.

---

Enjoy building with minimal APIs, Razor Pages, and GitHub Copilot!

## Further Learning/Resources
* For students - [GitHub Student Developer Pack](https://education.github.com/pack)
* [Bibliotech](https://bexarbibliotech.org/) - free access to Udemy and more if you have a Bexar county address
* [GitHub Copilot Chat cheat sheet](https://docs.github.com/en/copilot/using-github-copilot/copilot-chat/github-copilot-chat-cheat-sheet)
* [Copilot Chat cookbook](https://docs.github.com/en/copilot/copilot-chat-cookbook)
* [Microsoft Learn - GitHub Copilot Bootcamp](https://learn.microsoft.com/en-us/collections/p0w1cj0p7eeg53) (search Microsoft Learn for other topics, too!)

## Sponsors

Thank you to our sponsors, as well as UTSA for hosting!

* [San Antonio .NET User Group](https://www.meetup.com/sadnug/)
* [Lean TECHniques](https://leantechniques.com/)
* [ACM San Antonio](https://www.meetup.com/acm-sa/)
