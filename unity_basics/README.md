# Unity

Motor de desarrollo de videojuegos.

## Templates

Permiten iniciar un tipo de juego (2D, 3D, etc.) con el editor configurado para el tipo de juego que se quiere crear.

## Editor

- Assets: Recursos del juego (scripts, texturas, archivos de audio)
- Packages: Paquetes integrados en el proyecto
- ProjectSettings: Configuraciones de las distintas partes del proyecto (fisicas, capas, etiquetas y configuraciones de tiempo)

### Distribucion del editor

#### Project

Gestiona los assets y los packages del proyecto

#### Hierarchy

Muestra las instancias de la escena actual

#### Inspector

Muestra informacion detallada de los GameObjects

- **Tag**: Permite definir una etiqueta con la que se pueda identificar el GameObject.

#### Escena

Representacion visual del juego

#### Vista de juego

Representa la vista del juego desde la perspectiva del usuario

## GameObjects

- Son la parte mas basica de un juego
- Necesitan que se le añadan componentes, con las funciones que se vayan a realizar (desplazamiento, colision, etc.)
- El componente `transform` es el unico que esta presente por defecto en todos los GameObjects, ya que por defecto define su posicion y orientacion en la escena
- Los componentes de los GameObjects son scripts

## Escena

- Area de contenido del juego
- La escena ya incluye por defecto el GameObject camara, el cual permite visualizar la escena
- La escena varia si el juego es en `2D` o en `3D`
    - Camara ortografica: 2D
    - Camara perspectiva: 3D

### Pixels per unit

Unidad de medida utilizada en Unity, por defecto el tamaño de cada cuadrado en la escena es del 100 pixeles.

## Sprites

Los sprites son imagenes de 2 dimensiones que pueden ser incluidas en el juego.

### Bitmap

Representacion de una imagen en la tarjeta grafica. Contiene todos los pixeles que definen una imagen con un ancho y alto determinados.

Cada pixel de la imagen es pintado de un color y dependiendo de los bits, cada pixel se puede pintar de distintos colores.
- Si es de un bit, solo podra pintarse de blanco o negro.
- Si es de 4 bits de 16 colores.

> Las imagenes en el juego se denominan texturas.

### Filter mode

- Bilinear: Se añade un sombreado a la textura para mejorar su visualizacion.
- Point (no filter): Se muestran los pixeles de la textura.

### Sprite mode

- Single: El sprite (imagen) cargada contiene una unica textura.
- Multiple: La imagen contiene multiples texturas.

Cuando se cargan sprites (imagenes) que contienen multiples texturas, se realiza una unica carga en memoria de dicha imagen, posteriormente desde el `sprite editor` es posible:
- Dividir la imagen en las multiples texturas que esta contiene.
- Asignar el valor del `pivot` y de `pixels per unit` para cada textura especifica.

### Sprite renderer

Componente que permite visualizar los GameObject en la escena.

- Draw mode: La opcion `Tiled` permite que una sprite se ubique en una cuadricula.
    - Size: Tamaño del sprite repetido en la escena.

## Time.deltaTime

Valor que indica el tiempo que ha pasado desde el frame anterior. Se puede acceder en el codigo al Delta time mediante `Time.deltaTime`

## Fisicas

### Componentes

#### RigidBody

Permite especificarle a Unity que el GameObject es un cuerpo rigido y le pueden afectar las fuerzas, como por ejemplo la gravedad.
- Body Type
    - Dynamic: Al GameObject le afecta la gravedad.
    - Static: Objectos rigidos a los cuales no les afecta la gravedad.

#### Collider

Especifica la fisica de colision de un GameObject.

Dependiendo de la forma del objeto se puede definir un collider especifico.
- BoxCollider
- CircleCollider
- CapsuleCollider

La opcion `isTrigger` permite detectar la colision de un GameObject sin ser este un objeto solido (Usualmente utilizado para la deteccion de colisiones en ciertas partes de un GameObject principal).

La deteccion de eventos de los objetos marcados con la opcion `isTrigger` se realiza mediante `onTrigger<event>`, donde `<event>` puede ser Enter, Stay o Exit.

##### Material fisico

El material fisico (friccion y rebote) se puede asignar al componente de colision, modificando la fisica de movimiento de los diferentes GameObjects.

- Layers de colision: Permiten especificar mediante una matriz que objetos colisionan con otros (En el `inspector` desde la opcion layer, es posible asignar a un objeto un layer de colision especifico).

La edicion de la matriz de colision se realiza desde:

> Edit -> Project Settings -> Physics 2D -> Layer Collision Matrix