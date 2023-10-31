# IA_Parcial_2_Tello_2023
 

Todo el código fuente del parcial deberá estar alojado en un repositorio GIT público, de lo contrario no se corregirá el parcial y la calificación será 0 (cero).

Condición mínima de aprobación:

La simulación cuenta con una grilla de tamaño variable (mínimo 100x100), dos grupos de la misma cantidad de integrantes de tamaño variable (siempre menor o igual al ancho de la grilla) y una cantidad de comida repartida por el mapa igual a la cantidad de agentes en la grilla al inicio de la simulación.

La configuración de la red neuronal de cada grupo puede ser diferente.

Los agentes de un grupo comienzan la simulación alineados de izquierda a derecha en la fila inferior de la grilla.

Los agentes del otro grupo comienzan la simulación alineados de derecha a izquierda en la fila superior de la grilla.

La simulación se ejecuta por turnos. En un torno todos los agentes de ambos grupos se mueven una casilla.

Cada turno, cada uno de los agentes puede moverse una casilla en las cuatro direcciones cardinales, o quedarse quieto.

En caso de que un agente se salga de la grilla horizontalmente, aparecerá en el otro extremo. Esto no funciona verticalmente, en caso de que un agente decida exceder los límites verticales de la grilla no se moverá.

La generación termina tras una cantidad de turnos variable.

Los agentes deben comer la comida que está repartida por el mapa (se considera comer haber terminado el turno en la casilla donde estaba la comida).

En caso de que dos agentes de equipos diferentes lleguen a una celda con comida al mismo tiempo, los agentes deberán decidir entre una de las siguientes opciones, sin saber que decisión tomara el otro agente:

 A - Quedarse en la celda

 B - Huir a la celda de la que provenían

En caso de que ambos se hayan quedado en la celda, aleatoriamente uno morirá, el agente que esté en la celda al final del turno habrá comido.

En caso de que termine la generación y un agente no haya comido nada morirá, en caso de que haya comido solo una unidad sobrevivirá a la generación siguiente y en caso de que haya comido dos o más se reproducirá.

Los agentes que hayan comido más tienen mayor fitness.

Un grupo solo se puede reproducir si hay al menos dos agentes que puedan hacerlo.

Al momento de reproducirse se generarán tantos agentes igual a la cantidad de agentes que se estén reproduciendo.

Indistintamente de cómo haya sido la performance de un agente, no puede vivir por más de tres generaciones, pero si alcanza a reproducirse por última vez.

El genoma de todos los agentes debe poder serializarse y des-serializarse para reanudar el entrenamiento posteriormente.

Al terminar una generación, la comida que haya quedado sin comer en la grilla desaparece y aparece nueva en posiciones aleatorias, siempre siendo la cantidad igual a la cantidad de agentes con la que empezó la simulación. NO CON LA CANTIDAD DE AGENTES QUE HAY EN LA GENERACIÓN ACTUAL.

Examen completo:

En caso de que dos agentes del mismo equipo lleguen a una celda con comida al mismo tiempo, deberán decidir entre ellos quien la comerá, o que ninguno de ellos la coma. El agente que no come se desplaza a una casilla adyacente. En caso de que ambos decidan comer, contará como media comida.

En caso de que uno de los grupos se extinga, el grupo superviviente creará una población nueva cruzando sus agentes aleatoriamente (sin utilizar el fitness) y con un ratio de mutación superior al normal. La nueva generación creada cuenta con la misma cantidad de agentes que la generación superviviente y pasan a ocupar el puesto del grupo extinto.

En caso de que dos agentes de equipos diferentes se encuentren en una celda que no contengan comida, ambos podrán optar por:

 A - Quedarse en la celda

 B - Huir a la celda de la que provenían

En caso de que ambos se queden, uno de ellos morirá con una probabilidad del 50/50.

En caso de que uno huya y el otro no, el agente que huye tiene un 75% de probabilidades de morir.

En caso de que ambos huyan, no pasara nada

Forma de entrega:

La entrega será el repositorio en sí, pero además debe haber varios archivos que contengan el genoma de los agentes en distintos puntos del entrenamiento para poder ver rápidamente el avance del mismo. Mínimo 5.

La entrega deberá estar acompañada de una defensa oral del código el día del examen.

El readme del repositorio debe contener su nombre completo e indicar textualmente que "Este repositorio es la entrega del segundo parcial de la materia Inteligencia Artificial dictada en Image Campus de la Tecnicatura superior en Desarrollo de Videojuegos del año 2023"

Cosas a tener en cuenta:

El examen es largo, y los tiempos que van a necesitar para entrenar las redes neuronales van a ser más. Les recomiendo hacer la serialización de genomas lo antes posible para poder entrenar a sus agentes todo el tiempo que puedan, si incluso implementan una especie de "auto-save" cada un cierto número de generaciones mejor para estar cubiertos ante cualquier imprevisto mas que mejor, pero no es obligatorio.

Pueden usar la información que quieran para pasar como input a la red neuronal, elijan sabiamente. Sepan que mientras más datos pasen más costo computacional va a tener su entrenamiento, pero esto va a requerir bastante más que cuatro inputs.

No se extrañen si toma MUCHAS generaciones en ver progresos significativos, es un comportamiento relativamente complejo el buscado.

Si entrenan a sus agentes con una versión compilada del proyecto el entrenamiento será más rápido al no estar vinculado a cuestiones de Degub/Editor.

Es decisión de ustedes si quieren hacer que el entrenamiento sea por etapas o no, o si quieren tener algoritmos para puntuar el fitness de cada equipo diferentes.