
namespace Empleados
{

    using Tareas;
    public class Empleado {  

        private string? nombre;

        private List<Tarea> tareas;

        public List<Tarea> Tareas { get => tareas; set => tareas = value; }
        public string? Nombre { get => nombre; set => nombre = value; }

        public Empleado (string? nombre){

            string? Nombre = nombre;

            Tareas = new List<Tarea>();

        }
        void crearTarea(Tarea t) {

            tareas.Add(t);

        }

    }

}