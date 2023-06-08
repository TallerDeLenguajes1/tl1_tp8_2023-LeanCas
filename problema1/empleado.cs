
namespace Empleados
{

    using Tareas;
    public class Empleado {  

        private string? nombre;

        private List<Tarea> tareas;

        public List<Tarea> Tareas { get => tareas; set => tareas = value; }
        public string? Nombre { get => nombre; set => nombre = value; }

        public Empleado (string nom){

            Nombre = nom;

            Tareas = new List<Tarea>();

        }
        public void crearTarea(Tarea t) {

            tareas.Add(t);

        }

        public void mostrarTarea(int i){

            Console.WriteLine($"El empleado {nombre} debe hacer la tarea {tareas[i]} que se trata de");

        }

    }

}