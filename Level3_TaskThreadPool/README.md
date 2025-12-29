# Level 3 – Task + ThreadPool Concurrency (Missions)

Welcome to **ConcurrencyLab – Level 3**.

In this level you will explore **real-world concurrency as used in modern .NET backends**:
**multiple Tasks executed by the ThreadPool**.

You no longer control threads directly.  
You delegate execution to the runtime.

Your goal is to understand **how work is scheduled**, not to force execution order.

---

## 🧪 Rules

- Do NOT create threads manually
- Avoid blocking (`.Wait()`, `.Result`)
- Use `Task.Run` only for CPU-bound work
- Observe thread reuse and scheduling behavior

---

## 🔬 Exercises

➡️ **[Go to Level 3 Exercises](../Exercises.md#level-3--task--threadpool-concurrency)**

Complete all missions before moving to the next level.

---

## 🎯 Missions

### Mission 1 – Task.Run (CPU-bound)
> What happens when CPU-heavy work is offloaded to the ThreadPool?

Expected behavior:
- Real parallelism
- Multiple physical threads
- Work executed by the ThreadPool
- No guaranteed order

Key idea:
- `Task.Run` schedules CPU-bound work

---

### Mission 2 – Multiple Concurrent Tasks
> What happens when several tasks run at the same time?

Expected behavior:
- Tasks start almost simultaneously
- No task is bound to a specific thread
- Completion order is unpredictable

Key idea:
- A `Task` represents work, not execution

---

### Mission 3 – Async I/O Concurrency
> How does async I/O behave under concurrency?

Expected behavior:
- No threads blocked during I/O
- Thread may change after `await`
- High scalability

Key idea:
- `async/await` frees threads during I/O waits

---

### Mission 4 – Task.WhenAll
> How do we coordinate multiple concurrent tasks?

Expected behavior:
- All tasks run concurrently
- Execution continues only after all complete
- Any exception fails the whole batch

Key idea:
- `Task.WhenAll` synchronizes without blocking

---

## 👀 What to observe in console

- **ThreadId:** `Environment.CurrentManagedThreadId`
- Thread reuse across tasks
- Thread switches after `await`
- Non-deterministic output order

---

## ▶️ How to run

In `Program.cs` you can switch missions:

```csharp
// await Mission1_TaskRunCpuBound.Run();
// await Mission2_MultipleConcurrentTasks.Run();
// await Mission3_AsyncIoConcurrency.Run();
// await Mission4_TaskWhenAll.Run();
```

Uncomment the mission you want to execute.

## 🧠 Final questions

After completing all missions:

- Why doesn’t a `Task` belong to a specific thread?
- Why is `Task.Run` wrong for I/O?
- How does the `ThreadPool` improve scalability?
- Why is blocking harmful in concurrent systems?

Being able to answer these means you understand **backend concurrency in .NET**.

---

## 🧩 Mental model takeaway

> **Threads execute.**  
> **Tasks represent work.**  
> **The ThreadPool decides when and where execution happens.**

---

## 🏁 What you learned in Level 3

You now understand:

- Why `Task` scales better than `Thread`
- How modern .NET servers handle concurrency
- How CPU-bound and I/O-bound work differ
- Why `async` is essential for backend systems

---

➡️ **Next level: Level 4 – Mixed Model (CPU + I/O)**  
Here everything comes together.
