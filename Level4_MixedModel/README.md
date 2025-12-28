# 🧪 Level 4 – Mixed Model (Parallel + Async) (ConcurrencyLab)

En este nivel combinamos **CPU paralela** con **I/O asíncrono**, mostrando el modelo más escalable y potente de .NET.

---

## 🎯 Objetivo del nivel

Aprender a:

- Mezclar **CPU-bound paralelo** con **I/O-bound asíncrono**
- Observar la interacción entre hilos físicos y continuaciones de `await`
- Escalar de forma eficiente sin bloquear hilos
- Coordinar múltiples tareas con `Task.WhenAll` o `Parallel.ForEachAsync`

---

## 🧠 Modelo mental

| Concepto          | Rol en el sistema                         |
|-------------------|-------------------------------------------|
| `Task`            | Representa trabajo en curso o futuro      |
| `ThreadPool`      | Reutiliza hilos físicos                   |
| `Parallel`        | Ejecuta CPU-bound en múltiples hilos      |
| `async/await`     | Libera hilos durante I/O                  |
| `Task.WhenAll`    | Coordina varias tareas concurrentes       |

> **Una Task no es un hilo.**  
> Mezclamos CPU + I/O para máxima escalabilidad.

---

## 📦 Misiones del nivel

### 🟢 Mission 1 – Sequential Mixed

- Secuencia de operaciones I/O simuladas
- Observa el cambio de `ThreadId` tras `await`
- **Key**: `await TrabajoAsync(...)`

---

### 🟢 Mission 2 – Parallel CPU + Async I/O

- Paralelismo real de CPU con `Parallel.ForEachAsync`
- I/O simulado dentro del ciclo
- **Key**: mezcla de bucle CPU y `await Task.Delay(...)`

---

### 🟢 Mission 3 – Task.WhenAll Mixed

- Combina `Task.Run` para CPU y `async` para I/O
- Coordinación de 4 tareas con `Task.WhenAll`
- Observa inicio casi simultáneo y finalización no determinista

---

### 🟢 Mission 4 – Realistic Pipeline

- Procesamiento de múltiples elementos
- CPU paralelo + I/O simulado por elemento
- Modelo cercano a pipelines de datos reales
- Observa cambios de hilo y orden de salida no determinista

---

## 👀 Qué observar en consola

- `ThreadId` cambia tras `await` (I/O)
- CPU paralelo usa hilos distintos
- Orden de salida puede no ser secuencial → normal

| Misión | Tipo de concurrencia                  |
|--------|--------------------------------------|
| 1      | Secuencial I/O con await              |
| 2      | CPU + I/O paralelo                    |
| 3      | Task.WhenAll coordinación CPU + I/O  |
| 4      | Pipeline real CPU + I/O               |

---

## ⚠️ Errores comunes

- ❌ Bloquear con `.Result` o `.Wait()`
- ❌ Usar `Task.Run` innecesariamente para I/O
- ❌ Pensar que Task = hilo físico

---

## 🧩 Regla de oro

> Threads ejecutan. Tasks representan trabajo.  
> El ThreadPool decide cómo y cuándo ejecutar.  
> Mezclar CPU + I/O correctamente permite **máxima escalabilidad**.

---

## 🏁 Al terminar este nivel

Sabes:

- Cómo mezclar **CPU-bound** y **I/O-bound** sin bloquear hilos
- Por qué `Parallel + async/await` es potente
- Cómo escalar servicios de alto rendimiento en .NET

