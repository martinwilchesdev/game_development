// Operadores relacionales

// Mayor que        >
// Menor que        <
// Igual que        ==
// Distinto de      !=
// Menor o igual    <=
// Mayor o igual    >=

int life = 10;

// Las estructuras condicionales permiten ejecutar un bloque de codigo a partir de la evaluacion de una expresion
if (life > 0) {
    // Si la expresion evaluada es true, se ejecuta este bloque de codigo
    Console.WriteLine("Estoy vivo");
} else {
    // En caso contrario, se ejecuta el bloque else
    Console.WriteLine("Estoy muerto");
}

// Operadores logicos

// AND      &&
// OR       ||
// NOT      !

int level = 20;
bool llave = true;

// Los operadores logicos permiten evaluar expresiones mas complejas
if (level >= 20 && llave) {
    Console.WriteLine("Has llegado al final del juego");
}

// La estructura switch permite definir estructuras condicionales complejas de forma organizada
int condicion = 2;

// Se ejecuta el caso que coincida con la condicion definida
switch(condicion) {
    case 1:
        Console.WriteLine("Ataque basico");
        break; // Cada caso finaliza con la palabra clave break, lo cual finaliza la ejecucion de la estructura condicional
    case 2:
        Console.WriteLine("Ataque medio");
        break;
    default: // Si no se cumple la condicion, se ejecuta el bloque definido por defecto
        Console.WriteLine("El ataque no es valido");
        break;
}