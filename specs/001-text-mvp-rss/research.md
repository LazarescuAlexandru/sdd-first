# Research: MVP RSS Reader

## Findings

### Blazor WebAssembly State Management
- For simple MVP with in-memory data, use dependency injection with singleton services
- No need for complex state management libraries like Fluxor for this scope
- HttpClient for API communication is built-in and sufficient

### ASP.NET Core Web API Best Practices
- Use minimal APIs or controllers for simple endpoints
- In-memory storage with ConcurrentBag or List is adequate for MVP
- Basic CORS configuration needed for Blazor WASM

### Testing Approaches
- xUnit for backend unit tests
- bUnit for Blazor component testing
- Integration tests can use WebApplicationFactory

## Decisions

**Decision**: Use in-memory List<Subscription> for storage  
**Rationale**: Meets MVP requirement for session-based storage, simplest implementation  
**Alternatives considered**: Local storage (too complex for MVP), database (overkill for non-persistent MVP)

**Decision**: Separate backend and frontend projects  
**Rationale**: Clean architecture separation, easier testing, follows constitution maintainable architecture principle  
**Alternatives considered**: Single Blazor Server project (less separation), API in same project (tighter coupling)

**Decision**: Basic URL validation only (non-empty, non-whitespace)  
**Rationale**: MVP assumes valid URLs, keeps simple per constitution performance and simplicity principle  
**Alternatives considered**: Full URL validation (adds complexity), no validation (risky but acceptable for demo)