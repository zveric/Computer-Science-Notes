- Concurrency means an application is making progress on more than one task at the same time

## Benefits
- Users can interact while other apps are running in the background (Reactive programming)
- Long running task wont stop short ones (Availability of services)
- Multi core systems
- A task requiring preconditions to proceed can be suspended and easily resumed later

## Disadvantages
- Memory can be used by multiple threads, causing memory mutations
- Tasks can suspend and wait on each other indefinitely known as deadlock
- Threads can be resource intensive