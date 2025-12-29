# Level 1 – Async Concurrency (Missions)

Welcome to **ConcurrencyLab – Level 1**.

In this level you will explore **async/await without real parallelism**.  
There is only **one logical flow of execution**, but continuations may run on different physical threads.

Your goal is **not** to memorize syntax, but to **observe runtime behavior** and build a correct mental model.

---

## 🧪 Rules

- Do NOT use `Task.Run`
- Do NOT use `Parallel`
- Do NOT create threads manually
- Focus on `ThreadId` and execution order

---

## 🔬 Exercises

➡️ **[Go to Level 1 Exercises](../Exercises.md#level-1--async-concurrency-single-logical-thread)**

Complete all missions before moving to the next level.

---

## 🎯 Missions

### Mission 1 – Sequential Await
> What happens when you await everything immediately?

Expected behavior:
- Sequential execution
- No overlap
- Thread may change after each `await`

---

### Mission 2 – Logical Concurrency
> Start multiple tasks before awaiting them.

Expected behavior:
- Tasks overlap in time
- Still no real parallelism
- Execution order may differ from code order

---

### Mission 3 – Delayed Await
> Await some tasks later, after starting others.

Expected behavior:
- Interleaved execution
- Better I/O utilization
- Continuations may occur on different threads

---

### Mission 4 – Task.WhenAll
> Await multiple tasks together using `Task.WhenAll`.

Expected behavior:
- All tasks run concurrently (logical concurrency)
- Continuations resume independently
- Output order is NOT guaranteed
- Any exception fails the whole batch

---

## 👀 What to observe in console

- **ThreadId:** each message shows `Environment.CurrentManagedThreadId`.
- **Mission 1:** sequential await, one logical thread, thread may change after each await.
- **Mission 2-3:** tasks overlap, logical concurrency, still no parallelism.
- **Mission 4:** all tasks start together, continuations independent, no guaranteed order.

---

## ▶️ How to run

In `Program.cs` you can switch missions:

```csharp
await Mission1_SequentialAwait.Run();
// await Mission2_LogicalConcurrency.Run();
// await Mission3_DelayedAwait.Run();
// await Mission4_WhenAll.Run();
```

Uncomment the mission you want to execute.

---

## 🧠 Final question

After completing all missions:

- Why do we say “single logical thread” even if multiple ThreadIds appear?

- How does await control execution order?

- What’s the difference between logical concurrency and parallelism?

Reflecting on these questions is the main goal of Level 1.