# Native Toast Plugin

A Unity package for displaying native Toast notifications on Android and iOS.

## Features
- Native Android Toast
- Native iOS Alerts
- Editor fallback (Debug.Log)
- Simple static API

## Installation

### Via Unity Package Manager
1. Open `Window → Package Manager`
2. Click `+` → `Add package from git URL`
3. Enter: `https://github.com/yourusername/unity-native-toast-package.git`

## Usage
```csharp
using CleverTap.NativeToast;

public class Example : MonoBehaviour
{
    void Start()
    {
        NativeToast.Show("Hello from Toast!");
    }
}
```

## Architecture

**Pattern**: Strategy Pattern with Platform Abstraction

- `IToastPlatform` - Interface for platform implementations
- `NativeToast` - Static entry point
- `AndroidToast` - Android implementation using Android Java
- `IOSToast` - iOS implementation using native calls
- `DummyToast` - Editor fallback

## Requirements
- Unity 2021.3 or higher
- Android: API Level 23+
- iOS: iOS 11.0+

## Testing
- Unit tests included in `Tests/` folder
- Run via Unity Test Runner

## License
MIT License