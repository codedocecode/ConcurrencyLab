# Level 2 – CPU Parallelism (Missions)

Welcome to Level 2.

In this level you will explore **real parallelism** using multiple physical threads.
All work here is **CPU-bound** and intentionally blocking.

This level focuses on **Parallel**, not on async/await.

---

## 🧪 Rules

- Do NOT use `async / await`
- Do NOT use `Task.Delay`
- Do NOT simulate I/O
- Use CPU-intensive work only

---

## 🔬 Exercises

➡️ **[Go to Level 2 Exercises](../Exercises.md#level-2--cpu-parallelism-parallel)**

Complete all missions before moving to the next level.

---

## 🎯 Missions

### Mission 1 – Sequential CPU
> What happens when CPU-bound work runs sequentially?

Expected:
- One thread at a time
- Slow execution
- Predictable order

---

### Mission 2 – Parallel.For
> What happens when CPU-bound work runs in parallel?

Expected:
- Multiple threads
- Faster execution (on multi-core CPUs)
- Unpredictable order

---

### Mission 3 – Parallel.ForEach
> Same as Parallel.For, but with collections.

Expected:
- Parallel execution
- Thread reuse
- No guaranteed order

---

### Mission 4 – Parallel vs Sequential
> Compare execution time between sequential and parallel code.

Expected:
- Parallel version completes faster
- CPU usage increases
- Order is sacrificed for throughput

---

## 👀 What to observe in console

- ThreadId: multiple values appear immediately
- Order of execution is NOT guaranteed
- CPU usage increases significantly

---

## 🧠 Final question

- Why is this **parallelism**, not just concurrency?
- Why does async not help here?
- When should you NOT use Parallel?
