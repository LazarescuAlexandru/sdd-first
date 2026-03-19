# Quick Start: MVP RSS Reader

## Prerequisites
- .NET 8 SDK installed
- Visual Studio 2022 or VS Code with C# extension

## Setup

1. **Clone and checkout branch**:
   ```bash
   git checkout 001-text-mvp-rss
   ```

2. **Build backend**:
   ```bash
   cd backend
   dotnet build
   ```

3. **Build frontend**:
   ```bash
   cd frontend
   dotnet build
   ```

## Running the Application

1. **Start backend API** (in terminal 1):
   ```bash
   cd backend/src
   dotnet run
   ```
   Backend runs on https://localhost:5001

2. **Start frontend** (in terminal 2):
   ```bash
   cd frontend/src
   dotnet run
   ```
   Frontend runs on https://localhost:5000

3. **Open browser**: Navigate to https://localhost:5000

## Testing MVP Functionality

1. Enter a feed URL (e.g., `https://devblogs.microsoft.com/dotnet/feed/`)
2. Click "Add Subscription"
3. Verify the URL appears in the subscription list

## Development Notes

- Backend API is available at https://localhost:5001/swagger for testing
- Data is stored in memory only (lost on restart)
- No feed validation or fetching in MVP
- Use browser developer tools to inspect network requests