// Las clases permiten encapsular la logica (propiedades y metodos) de un objeto
class Program
{
    // Propiedades de la clase
    public int vida;
    public float ataque;
    public string nombre;

    // El metodo constructor se ejecuta cada vez que se instancia un nuevo objeto de la clase
    public Program()
    {
        vida = 0;
        ataque = 0;
        nombre = "Unknown";
    }

    static void Main(string[] args)
    {
        // Instanciando un nuevo objeto de la clase
        Program personaje = new Program();

        // Desde la instancia se asginan valores a las propiedades de la clase
        personaje.vida = 100;
        personaje.ataque = 11.2f;
        personaje.nombre = "Kasper";

        Console.WriteLine($"Nombre: {personaje.nombre}, Vida: {personaje.vida}, Ataque: {personaje.ataque}");
    }
}
