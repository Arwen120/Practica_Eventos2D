# Práctica: Eventos en Unity 2D

## 1. Objetivo

El objetivo de esta práctica es experimentar con las diferentes modalidades de uso de eventos para enviar mensajes entre los objetos de una escena en Unity.

Se trabajan los eventos de la interfaz de usuario (UI), los eventos del sistema y los eventos personalizados mediante C# (delegados y patrón observador).

## 2. Mecánicas implementadas

### Interfaz de usuario (UI)

- Botón para activar y desactivar el modo sigilo, reduciendo la velocidad del jugador.
- Contador de monedas que aumenta al recoger objetos.
- Barra de vida que disminuye al tocar una trampa.
- Botón para desplazarse progresivamente hasta el escondite.

### Eventos personalizados de C#

Se ha implementado un evento personalizado que se activa cuando el jugador recoge un cristal especial.

Al activarse el evento, dos objetos reaccionan simultáneamente:

- **Objeto perseguidor:** comienza a desplazarse suavemente hacia