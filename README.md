# 🧪 ConcurrencyLab

ConcurrencyLab is an experimental playground to understand  
**concurrency, asynchrony and parallelism in C# (.NET)**.

This repository is not a tutorial.
It is a **laboratory**.

You will:
- run experiments
- observe runtime behavior
- build a correct mental model
- understand *why* things behave the way they do

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

Understanding this separation is the key goal of this lab.

---

## 💡 Conceptos básicos de Threads y Tasks

### **Thread**
- Unit of execution managed by the **operating system**.  
- Ideal for **long CPU-bound operations** or true parallelism.
- Provides direct control over the thread lifecycle, but is heavier to manage.

### **Task**
- Represents an **asynchronous or concurrent operation**, managed by the **.NET ThreadPool**.  
- Ideal for **I/O operations**, such as files, databases, or API calls.  
- Handles **exceptions more easily** and allows **thread reuse**.  
- Integrates naturally with **async/await**, making the code cleaner and more maintainable.

### **Quick Comparison**

| Concept | Typical Use | Management | Advantage | Disadvantage |
|--------|-------------|------------|-----------|--------------|
| Thread | Long-running / CPU-bound operations | OS | Full control over parallelism | Heavyweight, complex exception handling |
| Task | I/O, files, databases | ThreadPool | Easy exception handling, thread reuse | Less control over physical threads |

---

## 📦 Levels overview

### Level 1 – Async concurrency (single logical thread)

- Logical concurrency
- No real parallelism
- One flow of execution
- Continuations may resume on different threads

Typical use cases:
- UI applications
- Event loops
- I/O-bound workflows

---

### Level 2 – CPU parallelism (Parallel)

- Real parallelism
- Multiple OS threads
- Blocking work by design

Typical use cases:
- Heavy computations
- Image processing
- Encryption / compression

---

### Level 3 – Task + ThreadPool concurrency

- Tasks not bound to a specific thread
- ThreadPool reuse
- Scalable backend model

Typical use cases:
- Web servers
- APIs
- Background services

---

### Level 4 – Mixed model (CPU + I/O)

- Parallel CPU work
- Async I/O
- High throughput without blocking

Typical use cases:
- Data pipelines
- Batch processing
- High-performance services

---

## 📊 Summary table

| Level | Threads | Async | Parallel | Typical case |
|------:|--------:|:-----:|:--------:|--------------|
| 1     | 1 logic | ✔️    | ❌       | UI / I/O     |
| 2     | many    | ❌    | ✔️       | CPU-bound    |
| 3     | many    | ✔️    | ❌       | Backend      |
| 4     | many    | ✔️    | ✔️       | CPU + I/O    |

---

## 🎯 Bonus: why this lab exists

Most confusion around concurrency comes from mixing concepts:
- threads vs tasks
- async vs parallel
- concurrency vs parallelism

This lab separates them **on purpose** so you can observe each one in isolation.
