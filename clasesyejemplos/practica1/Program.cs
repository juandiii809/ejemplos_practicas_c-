Console.WriteLine("Hello, World!");

Personas persona = new Personas() { id = 1, altura = 1.73m, cedula = 1212323, nombre = "juan" };
List<Libros> libro = new List<Libros>();
Libros libro1 = new Libros() { nombre = "el mito de sisifo", editorial = "penguin" };
libro.Add(libro1);
foreach (var i in libro)
{
    Console.WriteLine(i.nombre);
    Console.WriteLine(i.editorial);
    
}
public class Personas
{
    public int id;
    public string? nombre;
    public int cedula;
    public decimal altura;
}

public class Estudiantes : Personas
{
    public int carnet;
}

public class Libros
{
    public string? nombre;
    public string? editorial;
}