# Tasks: MVP RSS Reader

**Input**: Design documents from `/specs/001-text-mvp-rss/`
**Prerequisites**: plan.md (required), spec.md (required for user stories), research.md, data-model.md, contracts/

**Tests**: The examples below include test tasks. Tests are OPTIONAL - only include them if explicitly requested in the feature specification.

**Organization**: Tasks are grouped by user story to enable independent implementation and testing of each story.

## Format: `[ID] [P?] [Story] Description`

- **[P]**: Can run in parallel (different files, no dependencies)
- **[Story]**: Which user story this task belongs to (e.g., US1, US2, US3)
- Include exact file paths in descriptions

## Path Conventions

- **Single project**: `src/`, `tests/` at repository root
- **Web app**: `backend/src/`, `frontend/src/`
- **Mobile**: `api/src/`, `ios/src/` or `android/src/`
- Paths shown below assume single project - adjust based on plan.md structure

<!-- 
  ============================================================================
  IMPORTANT: The tasks below are SAMPLE TASKS for illustration purposes only.
  
  The /speckit.tasks command MUST replace these with actual tasks based on:
  - User stories from spec.md (with their priorities P1, P2, P3...)
  - Feature requirements from plan.md
  - Entities from data-model.md
  - Endpoints from contracts/
  
  Tasks MUST be organized by user story so each story can be:
  - Implemented independently
  - Tested independently
  - Delivered as an MVP increment
  
  DO NOT keep these sample tasks in the generated tasks.md file.
  ============================================================================
-->

## Phase 1: Setup (Shared Infrastructure)

**Purpose**: Project initialization and basic structure

- [ ] T001 Create backend ASP.NET Core Web API project in backend/src/
- [ ] T002 Create frontend Blazor WebAssembly project in frontend/src/
- [ ] T003 [P] Configure CORS in backend for Blazor WASM development
- [ ] T004 [P] Add Swagger/OpenAPI documentation to backend API

---

## Phase 2: Foundational (Blocking Prerequisites)

**Purpose**: Core infrastructure that MUST be complete before ANY user story can be implemented

**⚠️ CRITICAL**: No user story work can begin until this phase is complete

- [ ] T005 Create Subscription model in backend/src/Models/Subscription.cs
- [ ] T006 Create ISubscriptionService interface in backend/src/Services/ISubscriptionService.cs
- [ ] T007 Implement SubscriptionService with in-memory storage in backend/src/Services/SubscriptionService.cs
- [ ] T008 Register services in backend Program.cs with dependency injection

**Checkpoint**: Foundation ready - user story implementation can now begin in parallel

---

## Phase 3: User Story 1 - Add Feed Subscription (Priority: P1) 🎯 MVP

**Goal**: Allow users to add RSS/Atom feed subscriptions by entering URLs

**Independent Test**: Can add a subscription URL and verify it gets stored (API returns success)

### Implementation for User Story 1

- [ ] T009 Create SubscriptionsController in backend/src/Controllers/SubscriptionsController.cs with POST endpoint
- [ ] T010 [P] Create SubscriptionService in frontend/src/Services/SubscriptionService.cs for API calls
- [ ] T011 [P] Create AddSubscription component in frontend/src/Components/AddSubscription.razor
- [ ] T012 Update Index page in frontend/src/Pages/Index.razor to include AddSubscription component

**Checkpoint**: At this point, User Story 1 should be fully functional and testable independently

---

## Phase 4: User Story 2 - Display Subscription List (Priority: P2)

**Goal**: Display the current list of feed subscriptions in the UI

**Independent Test**: Can view the list of added subscriptions (requires US1 working)

### Implementation for User Story 2

- [ ] T013 Add GET endpoint to SubscriptionsController for retrieving subscriptions
- [ ] T014 [P] Update SubscriptionService to include get subscriptions method
- [ ] T015 [P] Create SubscriptionList component in frontend/src/Components/SubscriptionList.razor
- [ ] T016 Update Index page to include SubscriptionList component and refresh after adding

**Checkpoint**: Full MVP functionality complete - users can add and view subscriptions

---

## Final Phase: Polish & Cross-Cutting Concerns

**Purpose**: Final cleanup and cross-cutting concerns

- [ ] T017 Add basic error handling for API calls in frontend
- [ ] T018 Add loading states to UI components
- [ ] T019 Update quickstart.md with any final setup instructions
- [ ] T020 Test end-to-end functionality across browser refresh

---

## Dependencies

User Story 1 (Add Subscription) has no dependencies and can be implemented first.

User Story 2 (Display List) depends on User Story 1 being complete.

**Dependency Graph**:
```
US1 (Add Subscription) → US2 (Display List)
```

## Parallel Execution Examples

**Per User Story**:
- **US1**: Tasks T009-T012 can be implemented in parallel (API + frontend)
- **US2**: Tasks T013-T016 can be implemented in parallel after US1 complete

**Full Project**: Setup tasks T001-T004 can run in parallel, foundational T005-T008 in parallel, then user stories.

## Implementation Strategy

**MVP First**: Implement User Story 1 first for minimal viable functionality. Users can add subscriptions even without seeing the list initially (though list display is quick to add).

**Incremental Delivery**: Each user story delivers independent value. US1 provides core subscription management, US2 enhances with visibility.

**Testing Strategy**: Manual testing for MVP - verify API endpoints work and UI interactions succeed. Automated tests can be added post-MVP.