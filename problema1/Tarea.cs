namespace Tareas{

    public class Tarea { //Estructura de datos, como lo que se utiliza en C
        private int tareaID;
        private string? descripcion;
        private int duracion;
        public int TareaID { get => tareaID; set => tareaID = value; }
        public string? Descripcion { get => descripcion; set => descripcion = value; }
        public int Duracion { get => duracion; set => duracion = value; }
    }

}