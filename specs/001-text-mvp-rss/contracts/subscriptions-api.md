# API Contract: Subscription Management

**Base URL**: `https://localhost:5001/api` (development)

## Endpoints

### GET /subscriptions
Retrieve all subscriptions.

**Response**: 200 OK
```json
[
  {
    "url": "https://example.com/feed.xml"
  }
]
```

### POST /subscriptions
Add a new subscription.

**Request Body**:
```json
{
  "url": "https://example.com/feed.xml"
}
```

**Response**: 201 Created
```json
{
  "url": "https://example.com/feed.xml"
}
```

**Error Responses**:
- 400 Bad Request: Invalid URL (empty/whitespace)
- 409 Conflict: URL already exists (future extension)

## Data Types

### Subscription
```json
{
  "url": "string"
}
```

## Notes
- MVP uses simple JSON contracts
- No authentication required
- CORS enabled for Blazor WASM development
- Future extensions may add pagination, filtering, deletion