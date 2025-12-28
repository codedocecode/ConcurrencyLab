# 🧪 ConcurrencyLab

ConcurrencyLab is an experimental playground to understand  
**concurrency, asynchrony and parallelism in C# (.NET)**.

This repository is not a tutorial.
It is a **laboratory** for experimenting, observing runtime behavior, and building a solid mental model.

You will:
- run experiments
- observe runtime behavior
- understand *why* things behave the way they do
- learn best practices for concurrency and parallelism

---

## 🧠 Core mental model

| Concept              | What it manages                     |
|----------------------|-------------------------------------|
| `Thread`             | OS-level execution unit             |
| `Task`               | Logical unit of work + state        |
| `async / await`      | Non-blocking waiting (I/O)          |
| `ThreadPool`         | Reusable worker threads             |
| `Parallel`           | CPU-bound parallel execution        |

> **Async does not create threads.  
> Parallel does not wait for I/O.**  
> Understanding this separation is the key goal of this lab.

---

## 💡 Quick Concepts: Threads vs Tasks

### Thread
- Unit of execution managed by the **OS**  
- Ideal for **long CPU-bound operations** or true parallelism  
- Full control but heavier and complex exception handling

### Task
- Represents an **asynchronous or concurrent operation**, managed by **ThreadPool**  
- Ideal for **I/O operations** (files, DB, APIs)  
- Easier exception handling and thread reuse  
- Integrates naturally with `async/await`

### Comparison

| Concept | Typical Use | Management | Advantage | Disadvantage |
|--------|-------------|------------|-----------|--------------|
| Thread | Long-running / CPU-bound | OS | Full control | Heavyweight, complex |
| Task   | I/O, async workflows | ThreadPool | Exception handling, reuse | Less control over physical threads |

---

## 📦 Levels Overview

### Level 1 – Async concurrency (Single logical thread)
- Logical concurrency, no real parallelism  
- One flow of execution, continuations may resume on different threads  

**Missions:**
1. `Mission1_SequentialAwait` – sequential await  
2. `Mission2_LogicalConcurrency` – multiple async calls with delayed await  
3. `Mission3_DelayedAwait` – call async but await later  
4. `Mission4_WhenAll` – coordinate multiple tasks with `Task.WhenAll`

**Typical use cases:** UI apps, Event loops, I/O-bound workflows

---

### Level 2 – CPU parallelism (Parallel)
- Real parallelism with multiple OS threads  
- Blocking work by design  

**Missions:**
1. `Mission1_SequentialCPU` – Sequential CPU-bound work  
2. `Mission2_ParallelFor` – Parallel.For loop  
3. `Mission3_ParallelForEach` – Parallel.ForEach on collections  
4. `Mission4_ParallelVsSequential` – Compare parallel vs sequential execution  

**Typical use cases:** Heavy computation, image processing, compression

---

### Level 3 – Task + ThreadPool concurrency
- Tasks not bound to a specific thread  
- ThreadPool reuse for scalability  

**Missions:**
1. `Mission1_TaskRunCPU`  
2. `Mission2_MultipleTasks`  
3. `Mission3_AsyncIOConcurrency`  
4. `Mission4_TaskWhenAll`  

**Typical use cases:** Web servers, APIs, background services

---

### Level 4 – Mixed model (CPU + I/O)
- Parallel CPU work  
- Async I/O operations  
- High throughput without blocking  

**Missions:**
1. `Mission1_SequentialMixed`  
2. `Mission2_ParallelCPU_AsyncIO`  
3. `Mission3_TaskWhenAllMixed`  
4. `Mission4_RealisticPipeline`  

**Typical use cases:** Data pipelines, batch processing, high-performance services

---

## 📊 Summary Table

| Level | Threads | Async | Parallel | Missions Count | Typical Case |
|------:|--------:|:-----:|:--------:|:--------------|--------------|
| 1     | 1 logic | ✔️    | ❌       | 4             | UI / I/O     |
| 2     | many    | ❌    | ✔️       | 2             | CPU-bound    |
| 3     | many    | ✔️    | ❌       | 4             | Backend      |
| 4     | many    | ✔️    | ✔️       | 4             | CPU + I/O    |

---

## 🏁 Lab Rules

- Observe `ThreadId` using `Environment.CurrentManagedThreadId`  
- Never block async code with `.Result` or `.Wait()`  
- Use `Task` for I/O, `Thread` for long CPU-bound tasks only if needed  
- Use `Parallel` for CPU parallelism  
- Bonus challenges: exception handling, deadlocks, task coordination  

---

## 🎯 Bonus Section

The lab intentionally separates concepts:

- Threads vs Tasks  
- Async vs Parallel  
- Concurrency vs Parallelism  

So you can **see each behavior in isolation** and then combine them in Level 4.

---

## ▶️ How to run

From the root of the repository:

```bash
dotnet run --project Level1_AsyncConcurrency
dotnet run --project Level2_ParallelCPU
dotnet run --project Level3_TaskThreadPool
dotnet run --project Level4_MixedModel
```

Each level contains missions as static async Task Run() methods that you can call from Program.cs to experiment interactively.

## 👀 Observations

- ThreadId may change after await
- CPU parallelism uses multiple threads
- Order of completion can be non-deterministic → expected
- Using Task.WhenAll ensures coordination without blocking

---