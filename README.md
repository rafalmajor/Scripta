# Scripta
A small note-taking application

# Planned project sturcture
Scripta/\
│── src/\
│   ├── Scripta.Domain/         <div align="right"># Warstwa domeny (Core)</div>\
│   │   ├── Entities/           # Encje (Note.cs)\
│   │   ├── ValueObjects/       # Obiekty wartościowe (opcjonalnie)\
│   │   ├── Aggregates/         # Agregaty (opcjonalnie)\
│   │   ├── Repositories/       # Interfejsy repozytoriów\
│   │   ├── Services/           # Logika domenowa\
│   │   ├── Exceptions/         # Wyjątki domenowe\
│   │   ├── Events/             # Zdarzenia domenowe\
│   │   ├── Interfaces/         # Interfejsy do zewnętrznych zależności\
│   ├── Scripta.Application/    # Warstwa aplikacyjna (Use Cases)\
│   │   ├── DTOs/               # Data Transfer Objects\
│   │   ├── Services/           # Serwisy aplikacyjne (CQRS, Use Cases)\
│   │   ├── Commands/           # Komendy (CQRS)\
│   │   ├── Queries/            # Zapytania (CQRS)\
│   │   ├── Interfaces/         # Interfejsy do infrastruktury\
│   ├── Scripta.Infrastructure/ # Warstwa infrastruktury (Persistence, API, Services)\
│   │   ├── Persistence/        # Implementacje repozytoriów (EF Core)\
│   │   ├── Config/             # Konfiguracja (DbContext, Identity)\
│   │   ├── Logging/            # Logowanie\
│   │   ├── Services/           # Zewnętrzne API, e-mail\
│   ├── Scripta.API/            # ASP.NET Core API\
│   │   ├── Controllers/        # Kontrolery Web API\
│   │   ├── Middlewares/        # Middleware np. do obsługi błędów\
│   │   ├── Configurations/     # DI, Swagger\
│   ├── Scripta.UI.WPF/         # Aplikacja WPF (MVVM)\
│   ├── Scripta.UI.Blazor/      # Aplikacja Blazor\
│── tests/                      # Testy jednostkowe i integracyjne\
│   ├── Scripta.Tests/          # Testy logiki domenowej\
│   ├── Scripta.Application.Tests/  # Testy aplikacji\
│   ├── Scripta.Infrastructure.Tests/ # Testy infrastruktury\
│── README.md                  # Dokumentacja\
│── Scripta.sln                # Plik rozwiązania (.sln)\


