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