// Los arreglos permiten definir una variable multidimensional
int[] array = { 2, 4, 5, 6 };

// Generalmente los arraglos pueden ser recorridos mediante el ciclo for
for (int i = 0; i < array.Length; i++) {
    Console.WriteLine(array[i]); // Cada elemento del arreglo es accedido mediante su indice, el cual inicia desde
}

// Los elementos de un arreglo tambien pueden ser accedidos desde fuera de un ciclo
Console.WriteLine(array[1]); // Se accede al elemento ubicado en la posicion 1