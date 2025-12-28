# 🧪 Level 3 – Task + ThreadPool (ConcurrencyLab)

En este nivel entramos en el **modelo real usado por backends modernos en .NET**:
**concurrencia multihilo basada en `Task` y `ThreadPool`**.

Aquí **ya no controlamos hilos directamente**.  
Delegamos esa responsabilidad al runtime.

---

## 🎯 Objetivo del nivel

Aprender a:

- Entender `Task` como **unidad lógica de trabajo**
- Ver cómo el **ThreadPool gestiona los hilos físicos**
- Diferenciar claramente:
  - CPU-bound (`Task.Run`)
  - I/O-bound (`async / await`)
- Componer trabajo concurrente con `Task.WhenAll`

---

## 🧠 Modelo mental

| Concepto       | Rol en el sistema                         |
|----------------|--------------------------------------------|
| `Task`         | Representa trabajo en curso o futuro       |
| `ThreadPool`   | Reutiliza hilos para ejecutar tareas       |
| `Task.Run`     | Encola trabajo CPU-bound en el ThreadPool  |
| `async/await`  | Libera hilos durante I/O                   |
| `WhenAll`      | Sincroniza múltiples tareas                |

> **Una Task no es un hilo.**  
> Es una abstracción sobre *trabajo*, no sobre *ejecución*.

---

## 📦 Misiones del nivel

### 🟢 Mission 1 – Task.Run (CPU-bound)

📌 **Qué demuestra**
- Trabajo CPU intensivo
- Uso explícito del ThreadPool
- Ejecución en varios hilos físicos

📌 **Clave**
```csharp
Task.Run(() => TrabajoCPU());
```
## 📌 Observa

- Distintos `ThreadId`
- Paralelismo real

---

## 🟢 Mission 2 – Multiple concurrent Tasks

### 📌 Qué demuestra

- Varias tareas concurrentes
- Ninguna ligada a un hilo fijo
- Coordinación con `Task.WhenAll`

### 📌 Clave

- `Task` representa trabajo, no ejecución física

```csharp
await Task.WhenAll(t1, t2, t3);
```

### 📌 Observa

- Inicio casi simultáneo
- Finalización en distinto orden

---

## 🟢 Mission 3 – Async I/O concurrency

### 📌 Qué demuestra

- Concurrencia sin bloqueo
- Liberación de hilos durante I/O
- Alta escalabilidad

### 📌 Clave

```csharp
await Task.Delay(...)
```

- `async/await` libera el hilo mientras espera I/O

### 📌 Observa

- El `ThreadId` puede cambiar tras el `await`
- No hay hilos bloqueados esperando

---

## 🟢 Mission 4 – Task.WhenAll behavior

### 📌 Qué demuestra

- Sincronización de múltiples tareas
- Espera eficiente
- Manejo limpio de errores (conceptualmente)

### 📌 Clave

```csharp
await Task.WhenAll(t1, t2);
```

- `Task.WhenAll` coordina sin bloquear

### 📌 Observa

- El flujo continúa solo cuando todas finalizan
- Modelo ideal para backend y APIs

---

## 👀 Qué observar en consola

- `ThreadId`: `Environment.CurrentManagedThreadId`
- Cambios de hilo tras `await`
- Orden de salida **no determinista** (esperado)

---

## 📊 Resumen por misión

| Misión | Tipo de concurrencia          |
|------:|-------------------------------|
| 1     | Paralelismo real (CPU)        |
| 2     | Concurrencia multihilo        |
| 3     | Concurrencia I/O              |
| 4     | Coordinación de tareas        |

---

## ⚠️ Errores comunes

- ❌ Usar `Task.Run` para I/O
- ❌ Pensar que una `Task` = un hilo
- ❌ Bloquear con `.Result` o `.Wait()`

---

## 🧩 Regla de oro

> **Threads ejecutan. Tasks representan trabajo.**  
> El `ThreadPool` decide cómo y cuándo ejecutar.

---

## 🏁 Al terminar este nivel

Sabes:

- Por qué `Task` es preferible a `Thread`
- Cómo escalan los servidores .NET
- Por qué `async/await` es clave en backend

👉 El siguiente paso es combinar CPU + I/O de forma eficiente.

➡️ **Level 4 – Mixed Model (Parallel + Async)**  
Aquí se junta todo.
