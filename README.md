## Instrucciones de juego

### PC

Usa el ratón para moverte por los menús, utiliza las flechas WASD para moverte por el escenario y el ratón para apuntar. Pulsa clic izquierdo para disparar a los enemigos.

### MÓVIL

Para moverte por los menús utiliza la entrada táctil. Para mover al personaje se usa el joystick izquierdo que aparece en pantalla al iniciar el nivel y el derecho para apuntar y disparar a los enemigos.

## SUT!  - Documento de Diseño


## 1. Introducción

Este es el documento de diseño de SUT, un videojuego web desarrollado en *Unity* como práctica de la asignatura  *Juegos para web y redes sociales* del Grado de Diseño y Desarrollo de Videojuegos de la *Universidad Rey Juan Carlos*. 

Puedes jugar a SUT haciendo click en este enlace https://grupo9web.github.io/SUT_Final/

Puedes acceder a nuestra web mediante este enlace https://grupo9web.github.io/WebHulioEntertainment/

Consulta nuestro repositorio en GitHub: https://github.com/grupo9web/SUT_Final/

Prueba nuestro juego en Facebook: https://www.facebook.com/instantgames/288884565164065/


### 1.1 Concepto del juego

SUT es un videojuego 3D de género survival shooter. Nuestro personaje tendrá que repeler a base de disparos las hordas de enemigos que se acercarán para acabar con él.

### 1.2 Características principales. 

El juego se basa en los siguientes principios: 

* **Mecánica sencilla**: la mecánica del juego es muy simple. El jugador tendrá que defenderse de las hordas de enemigos que quieran acabar con él. El número de enemigos y su salud/daño irá aumentando con cada ronda.

* **Juego infinito**: El número de enemigos será ilimitado e irá aumentando a medida que el jugador acabe con ellos. Estamos contemplando la posibilidad de incluir ciertos enemigos más poderosos en cada ronda, que aparezcan de forma más solitaria o acompañados de un número pequeño de enemigos “básicos”. El objetivo del juego será aguantar lo máximo posible.

* **Dificultad progresiva**: Puesto que el juego es infinito, el objetivo del jugador será aguantar el máximo número posible de hordas y su puntuación se verá afectada por el número de enemigos con los que consiga acabar. La dificultad irá aumentando conforme el jugador acabe con ellos, aumentando la frecuencia de aparición de enemigos. Estamos pensando que aparezcan enemigos más fuertes cada cierto tiempo, a modo de “bosses”, que infligirán más daño y tendrán más vida que los normales.


### 1.3 Género

*SUT* será un juego de survival shooter con vista isométrica, en el cual el objetivo será aguantar el máximo número de hordas enemigas a base de disparos.




### 1.4 Propósito y público objetivo

El propósito de SUT es que los jugadores pasen un rato entretenido y frenético matando hordas de enemigos soviéticos, poniéndose en el armazón de un robot de combate armado hasta los dientes.

*SUT* está orientado a jugadores mayores de 13 años debido al contenido violento del mismo, ya sean jugadores hardcore, los que perseguirán conseguir la mayor puntuación posible, o jugadores casual, cuyo principal objetivo será obtener momentos de ocio de forma esporádica.


## 2. Mecánicas del juego

La mecánica principal del juego es defenderse de diferentes hordas de enemigos a base de disparos. El jugador tendrá una vista isométrica, que le permitirá controlar la llegada de enemigos para ir acabando con ellos. La frecuencia de aparición de enemigos irá aumentando para que al jugador le cueste más acabar con ellos. Es posible que se incluyan ciertos enemigos más poderosos que atacarán de forma más solitaria o acompañados de un número pequeño de enemigos de menor dificultad, como si fueran jefes de cada horda.

### 2.1 Cámara

El juego será en 3D con una cámara de vista isométrica. Estará centrada en el personaje y dotará al jugador de una vista periférica alrededor del mismo para controlar la llegada de enemigos y será similar a la que se muestra en la siguiente imagen:

![Error en carga de Ejemplo cámara](https://i.imgur.com/ncpIkYE.png)


#### 2.1.2 Periféricos y controles

El jugador para moverse por los menús utilizará el ratón en PC y entrada táctil en dispositivos móviles. Para jugar utilizará las teclas WASD en PC y en dispositivos móviles se incluirá por un lado un joystick a la izquierda de la pantalla para mover el personaje y otro joystick en la parte derecha con el que controlar la orientación del personaje y disparar.

### 2.2 Puntuación

La puntuación de la partida se basará en el número de enemigos que el usuario consiga eliminar. La puntuación que obtendrá el jugador con la muerte de cada enemigo irá aumentando a raíz que el juego y su dificultad avance. Se sumará un bonus a la puntuación cuando el jugador consiga acabar con un “boss”. 



### 2.3 Guardar/Cargar

Se guardará el récord de puntuación de la sesión actual. No se podrá guardar de forma persistente el resultado de las partidas.
### 2.4 Interacción entre elementos
La interacción principal será entre el personaje y las hordas de enemigos. El jugador tendrá que acabar con todos ellos a medida que estos se acercan al personaje. En un principio, también se baraja la idea de incluir ciertos objetos por el escenario como _“power ups”_ que le den ciertas ventajas al personaje como aumento de daño, balas por segundo, etc. El número de enemigos aumentará con cada horda y es posible que se incluyan ciertos enemigos que ataquen en solitario pero que su vida y daño sean mucho mayores.

## 2.5 Personajes

### 2.5.1 Jugador

![Error en carga de Hulius](https://i.imgur.com/Y7RoLoZ.png)


-   **Nombre del Personaje**: _Hulius_.
-   **Descripción:** _Hulius_ es mezcla entre entidad virtual y mente humana, creada con fines militares hace décadas. Dotado de un armazón infranqueable de oro blanco que tiene como objetivo proteger todos los multiplexores que conforman su cuerpo.
-   **Concepto:**  Desde hace miles de años, en _Hulio_ se lleva en secreto el desarrollo de una droga que permite expandir los límites de la mente, pudiendo crear el soldado perfecto. Recientemente, los investigadores de _Hulio_ llegaron a la última fase del desarrollo y para completarla necesitaban la enzima dX. Esta solo se encontraba en único lugar en el mundo, por ello los más altos cargos de _Hulio_ decidieron mandar a su mejor soldado a por ella, su destino era Auschwitz, Alemania.
-   **Encuentro:**  Es el personaje que controlaremos, no habrá un encuentro específico.
-   **Armas:**  _Hulius_ empuña un rifle de asalto D56, capaz de hacer añicos cualquier cosa que toque.

### 2.5.2 Enemigos

![Error en carga de Enemigo 1](https://i.imgur.com/ZBI8W9S.png)


-   **Nombre del Personaje:**  Enemigo 1
-   **Descripción:**  Soldados especializados en las armas de largo alcance, son letales a larga distancia.
-   **Encuentro:**  A lo largo del desarrollo del juego irán apareciendo de manera esporádica.
-   **Armas:**  Empuña un rifle de largo alcance, capaz de aniquilar cualquier enemigo a más de 1000 metros de distancia.

![Error en carga de Enemigo 2](https://i.imgur.com/LHGnC0M.png)


-   **Nombre del Personaje:**  Enemigo 2
-   **Descripción:**  Soldados de élite que han recibido un entrenamiento especializado en el combate cuerpo a cuerpo.
-   **Encuentro:**  A lo largo del desarrollo del juego irán apareciendo de manera esporádica.
-   **Armas:**  Empuñan el conocido rifle AK-47, con una cadencia de disparo impresionante, capaz de disparar más de 600 disparos por minuto.


![Error en carga de Enemigo 3](https://i.imgur.com/5BL2g3G.png)


-   **Nombre del Personaje:**  Enemigo 3
-   **Descripción:**  Soldados desconocidos a los que se les ha retirado la identidad debido a las atrocidades cometidas en el pasado.
-   **Encuentro:**  A lo largo del desarrollo del juego irán apareciendo de manera esporádica.
-   **Armas:** Hacen añicos a sus enemigos empleando un lanzallamas.



## 3. Interfaz

En esta sección se explicará la interfaz de *SUT*, detallando el __flujo de actividades__ que desarrollará el mismo, junto con una previsualización de las ideas de las __pantallas__ que compondrán el videojuego.

  
 
### 3.1 Diagrama de flujo

El siguiente diagrama de flujo describe los estados en los que se puede encontrar nuestro juego *SUT* y las posibles transiciones entre los mismos según las acciones del usuario.

![Error en carga de Diagrama de Flujo](https://i.imgur.com/g5exu8O.png)

A continuación se muestra también un diagrama de estados adicional que describe las posibilidades y situaciones que pueden suceder durante el estado de **Juego**:

![Error en carga de Diagrama de Flujo, Juego](https://i.imgur.com/Tdu9log.png)


### 3.2 Menú de Inicio

![Error en carga de Menu de Inicio](https://i.imgur.com/C1MxTXM.png)


 **1. Nueva Partida**: se inicia una partida nueva desde cero, sin pasar por un menú de selección de dificultad previamente, ya que aumentará progresivamente.
 **2. Contáctanos**: da acceso a la información pertinente sobre nuestro equipo de desarrollo.


### 3.3 Nivel


**SUT** contará únicamente con un solo nivel, ya que la dificultad del juego se irá incrementando progresivamente, aumentando la frecuencia de aparición de los enemigos. El objetivo del juego será aguantar las hordas de enemigos que intenten matar al personaje controlado por el usuario, __Hulius__.

Los enemigos seguirán al jugador e intentarán golpearle y acabar con él, mientras que este se defenderá a base de disparos.

Desde el nivel de juego se podrá acceder al **Menú de Pausa**, y se podrá reanudar la partida en el momento que el usuario quiera, siempre que esté abierto este menú.


### 3.4 Menú de Opciones

Se implementará una aplicación multilingüe, de modo que en esta pantalla se podrá cambiar de idioma, así como inhabilitar el sonido del juego.

![Error en carga de Menu Opciones](https://i.imgur.com/f8IjcMk.png)

 **1. Idioma**: permite el cambio de los textos del juego entre español o inglés.
 **2. Sonido**:  activa o desactiva el sonido del juego.
 

### 3.5 Contáctanos

Si en el menú principal el jugador pulsa sobre el botón __Contáctanos__, se abrirá la pantalla de *Créditos*, que será algo similar a este boceto:

![Error en carga de Créditos](https://i.imgur.com/QVZvW9f.png)


### 3.6 Pantalla de Juego

A continuación mostramos una simulación que representa cómo sería el nivel de juego:

![Error en carga de Nivel](https://i.imgur.com/tSxu5KU.png)


 **1. Jugador**: personaje controlado por el usuario.
 **2. Enemigo**: individuo que intentará atacar al jugador.
 **3. Pausa**: permite al usuario acceder al menú de pausa.
 **4. GUI**: esta GUI mostrará información relevante al usuario, como la vida restante.

Como se ha descrito anteriormente, el juego no dispone de un menú de selección de dificultad dado que esta se incrementará de manera progresiva a medida que derrote a los enemigos.

### 3.7 Game Over

Cuando el jugador es golpeado 3 veces por los enemigos acaba la partida, dejando paso a una nueva pantalla, **Game Over**. En esta se muestra la puntuación que ha conseguido el jugador y la opción de volver. Quedaría algo similar a la siguiente imagen:

![Error en carga de Game Over](https://i.imgur.com/GYbyspW.png)


## 4. Arte y Música

Los modelos empleados en este juego están descargados de la Asset Store de Unity y son gratuitos, al igual que el escenario.

*SUT* se trata de un videojuego en el que el jugador va a estar en constante tensión debido a que los enemigos aparecen sin parar y su misión será acabar con ellos, de modo que la banda sonora que acompañará al gameplay será acorde a esto mismo y será original. El género está por especificar, pero tenemos claro que será de acción y creará nerviosismo en cierto modo.

Por último mostramos un par de ejemplos de concept art del videojuego:

![Error en carga de Concept 1](https://i.imgur.com/qhDihZP.png)
![Error en carga de Concept 2](https://i.imgur.com/re5RBFT.png)



