# Blazor State Management Documentation

## 📌 Introduction (English)
This project demonstrates state management in Blazor using a global state approach, allowing components to share data without direct parameter passing.

### 🛠️ How It Works?
State is managed through classes derived from `BaseState`, which implements an `OnChange` event to notify components about updates.

### 📄 Implemented States
- **CounterNumericState:** Manages a numeric counter with increment and decrement functionality.
- **GenericState:** Stores a dynamic ID for shared state management.

### 🏗️ Architecture
State instances are registered as `Scoped` in `Program.cs`, ensuring that the state is maintained within the same session.

### 📌 Conclusion
This approach simplifies component communication, making the code more modular and scalable.

---

## 📌 Introducción (Español)
Este proyecto demuestra la gestión de estado en Blazor utilizando un enfoque global, permitiendo a los componentes compartir datos sin necesidad de pasar parámetros directamente.

### 🛠️ ¿Cómo funciona?
El estado se maneja a través de clases derivadas de `BaseState`, que implementa un evento `OnChange` para notificar a los componentes sobre actualizaciones.

### 📄 Estados Implementados
- **CounterNumericState:** Administra un contador numérico con funcionalidad de incremento y decremento.
- **GenericState:** Almacena un ID dinámico para la gestión de estado compartido.

### 🏗️ Arquitectura
Las instancias de estado se registran como `Scoped` en `Program.cs`, asegurando que el estado se mantenga dentro de la misma sesión.

### 📌 Conclusión
Este enfoque simplifica la comunicación entre componentes, haciendo el código más modular y escalable.

---

## 📌 Introdução (Português)
Este projeto demonstra o gerenciamento de estado no Blazor usando uma abordagem global, permitindo que os componentes compartilhem dados sem a necessidade de passar parâmetros diretamente.

### 🛠️ Como funciona?
O estado é gerenciado por meio de classes derivadas de `BaseState`, que implementam um evento `OnChange` para notificar os componentes sobre atualizações.

### 📄 Estados Implementados
- **CounterNumericState:** Gerencia um contador numérico com funcionalidade de incremento e decremento.
- **GenericState:** Armazena um ID dinâmico para gerenciamento de estado compartilhado.

### 🏗️ Arquitetura
As instâncias de estado são registradas como `Scoped` no `Program.cs`, garantindo que o estado seja mantido dentro da mesma sessão.

### 📌 Conclusão
Essa abordagem simplifica a comunicação entre componentes, tornando o código mais modular e escalável.