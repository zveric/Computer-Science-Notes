- Scheduling is the process that computers use to create a feeling of multi-tasking
- This is done by a piece of software called a **scheduler**

## Round Robin
- Each process are given equal amounts of processor time
### Advantages
- Simple to implement
### Disadvantages
- Inefficient as it doesn't take into the priority of a process
- It doesn't consider the length of processes

## First Come First Served
- First process gets processor time first
### Advantages
- Easy to implement
### Disadvantage
- Doesn't take into account length or priority

## Shortest Job First
- The quickest job is executed first
### Advantages
- It ensures the maximum number of jobs can be completed
- It minimises the average time to complete a job

### Disadvantages
- Doesn't take priority's of a job
- If a long job is almost complete it might be interrupted
- The scheduler can only estimate how long a job will take

## Shortest Time Remaining
- The shortest job is executed first
### Advantages
- It ensures the maximum number of jobs can be completed
- It minimises the average time to complete a job
- Long jobs are less likely to be left behind
### Disadvantages
- Doesn't take priority's of a job
- If a long job is almost complete it might be interrupted
- The scheduler can only estimate how long a job will take

## Multi-Level Feedback Queues
- Contains multiple queues with multiple different prioritises
- Every job is given a priority by the scheduler when it arrives and is sorted into the relevant queue. 
- The queues themselves are sorted by one of the previously discussed algorithms. 
- The high priority queue is completed first, and then each of the lower level queues in turn.
- The scheduler is able to re-prioritise jobs at any time, moving them into the queue appropriate for their new priority. 
- It may do this based on new information, or simply because a low priority job has been waiting for too long already.
### Advantages 
- Makes sophisticated use of process priority.
- It ensures that higher priority processes run on time.
### Disadvantages
- Complex to implement.
- Not very efficient if all jobs have similar priority.
- Low priority jobs may take an extremely long time to complete if the queue algorithm doesn't compensate for wait-time, especially if new high-priority jobs keep arriving.


