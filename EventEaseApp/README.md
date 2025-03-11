# EventEase App

EventEase is an event management application designed to help users create, manage, and participate in events seamlessly. This application provides a user-friendly interface for both event organizers and attendees.

## Features

- **Event Creation**: Users can create new events with details such as date, time, location, and description.
- **Event Management**: Organizers can manage their events, including editing and deleting events.
- **Event Details**: Attendees can view detailed information about specific events, including RSVP options and ticket purchasing.
- **Responsive Design**: The application is designed to work on various devices, ensuring a smooth user experience.

## Project Structure

The project is organized into the following main directories:

- **src**: Contains the source code for the application.
  - **Components**: Reusable Blazor components.
  - **Pages**: Different pages of the application, including the main landing page and event details.
  - **Services**: Contains services for managing event data.
  - **App.razor**: Sets up routing for the application.
  - **MainLayout.razor**: Defines the main layout for the application.
  - **Program.cs**: Entry point of the application.

- **wwwroot**: Contains static files such as CSS and JavaScript.
  - **css**: Styles for the application.
  - **js**: Client-side JavaScript functionality.

- **appsettings.json**: Configuration settings for the application.

- **EventEaseApp.csproj**: Project file specifying dependencies and build settings.

## Getting Started

To get started with the EventEase app, follow these steps:

1. Clone the repository:
   ```
   git clone <repository-url>
   ```

2. Navigate to the project directory:
   ```
   cd EventEaseApp
   ```

3. Restore the project dependencies:
   ```
   dotnet restore
   ```

4. Run the application:
   ```
   dotnet run
   ```

5. Open your browser and navigate to `http://localhost:5000` to view the application.

## Contributing

Contributions are welcome! If you have suggestions for improvements or new features, please open an issue or submit a pull request.

## License

This project is licensed under the MIT License. See the LICENSE file for more details.