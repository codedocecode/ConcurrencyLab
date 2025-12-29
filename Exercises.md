# 🧪 ConcurrencyLab – Exercises & Challenges

Este cuaderno te guía misión por misión para experimentar y aprender **concurrencia, asincronía y paralelismo en C# (.NET)**.  
Recuerda siempre **predecir el resultado antes de ejecutar** y anotar tus observaciones.

---

## 🏆 Completion status

- Level 1 completed: ⬜
- Level 2 completed: ⬜
- Level 3 completed: ⬜
- Level 4 completed: ⬜

> A level is completed only when all missions are understood, not just executed.

---

## **Level 1 – Async concurrency (single logical thread)**

- [ ] Mission 1 – SequentialAwait
- [ ] Mission 2 – LogicalConcurrency
- [ ] Mission 3 – DelayedAwait
- [ ] Mission 4 – WhenAll

### Mission 1 – SequentialAwait
- Ejecuta la misión tal cual y anota los `ThreadId` antes y después de cada `await`.
- **Reto:** Añade otra llamada `await OperacionAsync("Archivo", 700)` y predice el orden de ejecución.
- **Pregunta:** ¿Se observa algún paralelismo real?
- **Observaciones:**  
  (Escribe aquí tus anotaciones)

---

### Mission 2 – LogicalConcurrency
- Ejecuta varias tareas sin esperar inmediatamente (`Task t1 = OperacionAsync(...); Task t2 = OperacionAsync(...);`).
- **Reto:** Intercala un `await t1` después de otro `await` y predice los `ThreadId`.
- **Pregunta:** ¿Cuándo se crea un nuevo hilo físico?
- **Observaciones:**  
  (Escribe aquí tus anotaciones)

---

### Mission 3 – DelayedAwait
- Modifica los delays y observa cómo cambia el orden de finalización.
- **Reto:** Añade `Console.WriteLine` antes y después de cada `await` con `DateTime.Now`.
- **Pregunta:** ¿Qué representa el hilo lógico principal? ¿Qué representan los hilos físicos?
- **Observaciones:**  
  (Escribe aquí tus anotaciones)

---

### Mission 4 – WhenAll
- Ejecuta varias tareas con `Task.WhenAll`.
- **Reto:** Añade una Task con excepción y captura el error con `try/catch`.
- **Pregunta:** ¿Qué diferencias observas con usar `await` secuencialmente?
- **Observaciones:**  
  (Escribe aquí tus anotaciones)

---

## **Level 2 – CPU parallelism (Parallel)**

- [ ] Mission 1 – Sequential CPU
- [ ] Mission 2 – Parallel.For
- [ ] Mission 3 – Parallel.ForEach
- [ ] Mission 4 – Parallel vs Sequential

### Mission 1 – Sequential CPU
- Ejecuta CPU-bound secuencial y mide tiempo con `Stopwatch`.
- **Pregunta:** ¿Qué pasa si aumentas iteraciones o complejidad?
- **Observaciones:**  
  (Escribe aquí tus anotaciones)

### Mission 2 – Parallel.For
- Observa varios `ThreadId` en ejecución.
- **Reto:** Incrementa iteraciones y predice cuántos threads se usarán.
- **Pregunta:** ¿El orden de salida es determinista?
- **Observaciones:**  
  (Escribe aquí tus anotaciones)

### Mission 3 – Parallel.ForEach
- Aplica operaciones paralelas sobre una colección.
- **Reto:** Introduce `Task.Delay` dentro del loop.
- **Pregunta:** ¿Cómo afecta esto al paralelismo?
- **Observaciones:**  
  (Escribe aquí tus anotaciones)

### Mission 4 – Parallel vs Sequential
- Compara tiempos de ejecución entre secuencial y paralelo.
- **Reto:** Mezcla código CPU-bound y async I/O.
- **Pregunta:** ¿Qué diferencias observas en uso de CPU y orden de ejecución?
- **Observaciones:**  
  (Escribe aquí tus anotaciones)

---

## **Level 3 – Task + ThreadPool**

- [ ] Mission 1 – TaskRunCPU
- [ ] Mission 2 – MultipleConcurrentTasks
- [ ] Mission 3 – AsyncIOConcurrency
- [ ] Mission 4 – TaskWhenAllBehavior

### Mission 1 – TaskRunCPU
- Observa cómo ThreadPool asigna threads para CPU-bound tasks.
- **Pregunta:** ¿Se crean threads nuevos o se reutilizan?
- **Observaciones:**  
  (Escribe aquí tus anotaciones)

### Mission 2 – MultipleConcurrentTasks
- Ejecuta varias tareas concurrentes y observa el orden de finalización.
- **Reto:** Combina `await Task.WhenAll(...)` y mide tiempos.
- **Observaciones:**  
  (Escribe aquí tus anotaciones)

### Mission 3 – AsyncIOConcurrency
- Simula operaciones I/O con `Task.Delay`.
- **Pregunta:** ¿Qué hilos quedan libres durante I/O?
- **Observaciones:**  
  (Escribe aquí tus anotaciones)

### Mission 4 – TaskWhenAllBehavior
- Coordina múltiples tareas con `Task.WhenAll`.
- **Reto:** Añade tareas CPU + I/O y observa el comportamiento.
- **Observaciones:**  
  (Escribe aquí tus anotaciones)

---

## **Level 4 – Mixed model (CPU + I/O)**

- [ ] Mission 1 – Sequential Mixed
- [ ] Mission 2 – ParallelCPU_AsyncIO
- [ ] Mission 3 – TaskWhenAllMixed
- [ ] Mission 4 – RealisticPipeline

### Mission 1 – Sequential Mixed
- Ejecuta CPU + I/O secuencialmente.
- Observa `ThreadId` y tiempos.
- **Observaciones:**  
  (Escribe aquí tus anotaciones)

### Mission 2 – ParallelCPU_AsyncIO
- Ejecuta CPU-bound con `Parallel.For` y await I/O.
- **Reto:** Añade más items a procesar y observa el número de hilos.
- **Observaciones:**  
  (Escribe aquí tus anotaciones)

### Mission 3 – TaskWhenAllMixed
- Coordina varias tareas mixtas con `Task.WhenAll`.
- **Pregunta:** ¿Qué patrón de hilos se observa durante el flujo?
- **Observaciones:**  
  (Escribe aquí tus anotaciones)

### Mission 4 – RealisticPipeline
- Simula un pipeline real de datos combinando CPU + I/O.
- **Reto:** Introduce delays aleatorios y mide throughput.
- **Pregunta:** ¿Cómo afecta a la eficiencia la mezcla de operaciones?
- **Observaciones:**  
  (Escribe aquí tus anotaciones)

---

## **Lab Challenge – Bonus**

- Cada vez que completes una misión, escribe **una línea sobre lo que aprendiste**.
- Intenta predecir resultados **antes de ejecutar**, luego observa y documenta diferencias.
- Objetivo: construir **tu propio modelo mental sólido de concurrencia y paralelismo en C#**.
