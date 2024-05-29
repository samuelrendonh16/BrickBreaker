# Descripción del juego de rompe bloques en C#

## Clase Form1

La clase `Form1` es la clase principal del juego de rompe bloques. Esta clase hereda de la clase `Form` de Windows Forms y es la que contiene la lógica principal del juego.

### Variables:

- `speed_left`: Entero que representa la velocidad horizontal de la bola.
- `speed_top`: Entero que representa la velocidad vertical de la bola.
- `points`: Entero que almacena la puntuación del jugador.
- `bricks`: Lista de `PictureBox` que almacena los bloques del juego.

### Métodos:

- `InitializeGame()`: Inicializa el juego configurando el intervalo del temporizador, ocultando el cursor, configurando el tamaño de la ventana y colocando la raqueta y la bola en su posición inicial. También inicializa los bloques.
- `CreateBricks()`: Crea los bloques estáticos en el formulario y los agrega a la lista `bricks`.
- `timer1_Tick()`: Método que maneja el evento Tick del temporizador. Mueve la raqueta y la bola, y verifica las colisiones con la raqueta, las paredes, los bloques y la parte inferior del formulario.
- `CheckBrickCollision(PictureBox brick)`: Verifica la colisión de la bola con un bloque específico y, en caso de colisión, oculta el bloque y actualiza la puntuación.
- `Form1_KeyDown()`: Maneja el evento KeyDown del formulario para detectar cuando se presionan las teclas Esc y F1 para salir del juego o reiniciarlo.
- Otros métodos: `playground_PreviewKeyDown`, `Form1_Load`, `brick2_Click` y `playground_Paint` son métodos generados automáticamente que no tienen ninguna funcionalidad adicional en este juego.

## Variables y Controles:

- `speed_left`, `speed_top`: Representan la velocidad de la bola.
- `points`: Etiqueta que muestra la puntuación del jugador.
- `GameOver_lbl`: Etiqueta que muestra un mensaje de game over cuando se pierde el juego.
- `Racket`: PictureBox que representa la raqueta del jugador.
- `ball`: PictureBox que representa la bola del juego.
- `brick`, `brick1`, ..., `brick9`: PictureBox que representan los bloques del juego.

## Descripción General del Juego

El juego de rompe bloques consiste en una bola que rebota contra una raqueta controlada por el jugador y contra bloques estáticos dispuestos en la parte superior de la ventana. El objetivo del juego es destruir todos los bloques golpeándolos con la bola, mientras se evita que la bola toque la parte inferior de la ventana con la raqueta. Cada vez que la bola golpea un bloque, el jugador gana puntos, y el juego termina cuando la bola toca la parte inferior de la ventana.
