# 🧪 ConcurrencyLab – Exercises & Challenges

This notebook guides you **mission by mission** to experiment and learn  
**concurrency, asynchrony, and parallelism in C# (.NET)**.  
Always **predict the outcome before running** and take notes of your observations.

---

## 🏆 Completion status

- [ ] Level 1 completed
- [ ] Level 2 completed
- [ ] Level 3 completed
- [ ] Level 4 completed

> A level is considered completed only when all missions are understood, not just executed.

---

## **Level 1 – Async concurrency (single logical thread)**

- [ ] Mission 1 – SequentialAwait
- [ ] Mission 2 – LogicalConcurrency
- [ ] Mission 3 – DelayedAwait
- [ ] Mission 4 – WhenAll

### Mission 1 – SequentialAwait
- Run the mission as-is and note `ThreadId` before and after each `await`.
- **Challenge:** Add another call `await OperacionAsync("File", 700)` and predict execution order.
- **Question:** Do you see any real parallelism?
- **Observations:**  
  (Write your notes here)

### Mission 2 – LogicalConcurrency
- Start multiple tasks without awaiting immediately (`Task t1 = OperacionAsync(...); Task t2 = OperacionAsync(...);`).
- **Challenge:** Interleave `await t1` after another await and predict `ThreadId`.
- **Question:** When is a new physical thread created?
- **Observations:**  
  (Write your notes here)

### Mission 3 – DelayedAwait
- Modify delays and observe how completion order changes.
- **Challenge:** Add `Console.WriteLine` before and after each await with `DateTime.Now`.
- **Question:** What represents the main logical thread? What represent the physical threads?
- **Observations:**  
  (Write your notes here)

### Mission 4 – WhenAll
- Run multiple tasks with `Task.WhenAll`.
- **Challenge:** Add a Task that throws an exception and catch it using `try/catch`.
- **Question:** How does this differ from sequential `await` usage?
- **Observations:**  
  (Write your notes here)

---

## **Level 2 – CPU parallelism (Parallel)**

- [ ] Mission 1 – Sequential CPU
- [ ] Mission 2 – Parallel.For
- [ ] Mission 3 – Parallel.ForEach
- [ ] Mission 4 – Parallel vs Sequential

### Mission 1 – Sequential CPU
- Run CPU-bound work sequentially and measure time using `Stopwatch`.
- **Question:** What happens if you increase iterations or complexity?
- **Observations:**  
  (Write your notes here)

### Mission 2 – Parallel.For
- Observe multiple `ThreadId`s in execution.
- **Challenge:** Increase iterations and predict how many threads will be used.
- **Question:** Is the output order deterministic?
- **Observations:**  
  (Write your notes here)

### Mission 3 – Parallel.ForEach
- Apply parallel operations over a collection.
- **Challenge:** Introduce `Task.Delay` inside the loop.
- **Question:** How does this affect parallelism?
- **Observations:**  
  (Write your notes here)

### Mission 4 – Parallel vs Sequential
- Compare execution time between sequential and parallel code.
- **Challenge:** Mix CPU-bound code and async I/O.
- **Question:** What differences do you notice in CPU usage and execution order?
- **Observations:**  
  (Write your notes here)

---

## **Level 3 – Task + ThreadPool**

- [ ] Mission 1 – TaskRunCPU
- [ ] Mission 2 – MultipleConcurrentTasks
- [ ] Mission 3 – AsyncIOConcurrency
- [ ] Mission 4 – TaskWhenAllBehavior

### Mission 1 – TaskRunCPU
- Observe how ThreadPool assigns threads for CPU-bound tasks.
- **Question:** Are new threads created or reused?
- **Observations:**  
  (Write your notes here)

### Mission 2 – MultipleConcurrentTasks
- Run multiple concurrent tasks and observe completion order.
- **Challenge:** Combine with `await Task.WhenAll(...)` and measure timings.
- **Observations:**  
  (Write your notes here)

### Mission 3 – AsyncIOConcurrency
- Simulate I/O operations using `Task.Delay`.
- **Question:** Which threads are freed during I/O?
- **Observations:**  
  (Write your notes here)

### Mission 4 – TaskWhenAllBehavior
- Coordinate multiple tasks using `Task.WhenAll`.
- **Challenge:** Add CPU + I/O tasks and observe behavior.
- **Observations:**  
  (Write your notes here)

---

## **Level 4 – Mixed model (CPU + I/O)**

- [ ] Mission 1 – Sequential Mixed
- [ ] Mission 2 – ParallelCPU_AsyncIO
- [ ] Mission 3 – TaskWhenAllMixed
- [ ] Mission 4 – RealisticPipeline

### Mission 1 – Sequential Mixed
- Execute CPU + I/O sequentially.
- Observe `ThreadId` and timings.
- **Observations:**  
  (Write your notes here)

### Mission 2 – ParallelCPU_AsyncIO
- Run CPU-bound work with `Parallel.For` and await I/O inside.
- **Challenge:** Add more items to process and observe thread usage.
- **Observations:**  
  (Write your notes here)

### Mission 3 – TaskWhenAllMixed
- Coordinate mixed tasks using `Task.WhenAll`.
- **Question:** What thread patterns do you notice during the flow?
- **Observations:**  
  (Write your notes here)

### Mission 4 – RealisticPipeline
- Simulate a real data pipeline combining CPU + I/O.
- **Challenge:** Introduce random delays and measure throughput.
- **Question:** How does mixing operations affect efficiency?
- **Observations:**  
  (Write your notes here)

---

## **Lab Challenge – Bonus**

- After each mission, write **one line about what you learned**.
- Predict results **before executing**, then observe and document differences.
- Goal: Build **your own solid mental model of concurrency and parallelism in C#**.
