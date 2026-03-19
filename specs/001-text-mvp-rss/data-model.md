# Data Model: MVP RSS Reader

## Entities

### Subscription
Represents a user's RSS/Atom feed subscription.

**Attributes:**
- `Url` (string): The RSS/Atom feed URL. Required, non-empty.

**Validation Rules:**
- URL must not be null or empty
- URL must not be whitespace only

**Relationships:**
- None (single entity for MVP)

**Notes:**
- No additional attributes needed for MVP (title, description, etc. deferred)
- In-memory storage means no database constraints
- Future extensions may add feed metadata, read status, etc.