# 🧪 Level 4 – Mixed Model (CPU + I/O)

Welcome to **ConcurrencyLab – Level 4**.

This level represents the **most realistic and powerful concurrency model in .NET**:
**parallel CPU work combined with asynchronous I/O**.

This is how **modern high-performance backends, pipelines and services** are built.

Your goal is not to write clever code,  
but to **observe how CPU threads and async continuations interact**.

---

## 🎯 Level goal

Learn how to:

- Combine **CPU-bound parallelism** with **async I/O**
- Understand how `Parallel`, `Task`, and `async/await` coexist
- Avoid blocking while maximizing throughput
- Reason about real-world concurrent pipelines

---

## 🔬 Exercises

➡️ **[Go to Level 4 Exercises](../Exercises.md#level-4--mixed-model-cpu--io)**

Complete all missions before moving to the next level.

---

## 🧠 Mental model

| Concept            | Role in the system                          |
|--------------------|----------------------------------------------|
| `Thread`           | Executes CPU instructions                   |
| `ThreadPool`       | Reuses worker threads                       |
| `Parallel`         | Runs CPU-bound work in parallel             |
| `Task`             | Represents logical work                     |
| `async / await`    | Releases threads during I/O                 |
| `Task.WhenAll`     | Coordinates multiple tasks                  |

> **Tasks are not threads.**  
> **CPU work consumes threads.**  
> **I/O work frees threads.**

Correctly mixing them is the key to scalability.

---

## 📦 Missions

### 🟢 Mission 1 – Sequential Mixed

> What happens when async I/O is executed sequentially?

What it demonstrates:
- Sequential async flow
- No parallel CPU work
- Thread may change after each `await`

Expected behavior:
- Predictable order
- No blocking
- ThreadId may vary

---

### 🟢 Mission 2 – Parallel CPU + Async I/O

> What happens when parallel CPU work contains async I/O?

What it demonstrates:
- Real CPU parallelism
- Async I/O inside parallel execution
- Thread reuse and continuation switching

Expected behavior:
- Multiple ThreadIds
- Interleaved output
- Non-deterministic order

---

### 🟢 Mission 3 – Task.WhenAll Mixed

> How do CPU-bound and I/O-bound tasks coordinate?

What it demonstrates:
- Mixing `Task.Run` (CPU) with async methods (I/O)
- Coordinating multiple tasks
- Efficient waiting without blocking

Expected behavior:
- Near-simultaneous start
- Independent completion
- Continuation only after all tasks finish

---

### 🟢 Mission 4 – Realistic Pipeline

> How does a real concurrent pipeline behave?

What it demonstrates:
- Processing multiple items
- Parallel CPU stages
- Async I/O per item
- High throughput without blocking

Expected behavior:
- Many ThreadId changes
- Unpredictable order
- Stable, scalable execution

---

## 👀 What to observe in console

- **ThreadId** changes after `await`
- CPU work runs on multiple threads
- I/O does not block threads
- Output order is **not deterministic** (and should not be)

| Mission | Concurrency model              |
|--------:|--------------------------------|
| 1       | Sequential async I/O           |
| 2       | Parallel CPU + async I/O       |
| 3       | Task.WhenAll coordination      |
| 4       | Real-world CPU + I/O pipeline  |

---

## ⚠️ Common mistakes

- ❌ Blocking with `.Result` or `.Wait()`
- ❌ Using `Task.Run` for I/O
- ❌ Assuming a Task belongs to a thread
- ❌ Expecting ordered output in parallel systems

---

## 🧠 Final questions

After completing all missions:

- Why is combining CPU-bound and I/O-bound work more efficient than handling them separately?
- Why should CPU-bound work use `Parallel` or `Task.Run`, but I/O should not?
- Why does `await` allow better scalability when mixed with parallel CPU work?
- Why is output order unpredictable in realistic concurrent pipelines?

If you can answer these, you understand **how high-performance .NET systems are built**.

---

## 🧩 Mental model takeaway

> **CPU work needs threads.**  
> **I/O work needs async.**  
> **Tasks represent work, not execution.**  
> **The ThreadPool orchestrates everything.**

Mixing these correctly unlocks maximum throughput.

---

## 🏁 What you learned in Level 4

You now understand:

- How to combine **parallel CPU work** with **async I/O**
- Why modern .NET services scale without blocking threads
- How real-world data pipelines are structured
- Why mixed models are powerful — and dangerous if misunderstood

---

## 🚀 End of ConcurrencyLab

You now have a **correct mental model** of:

- Threads vs Tasks
- Concurrency vs Parallelism
- Async vs Blocking
- CPU-bound vs I/O-bound work

You are ready to reason about performance, scalability,  
and concurrency trade-offs in real .NET systems.
