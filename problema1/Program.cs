using Tareas;
using Empleados;

Empleado empleadoNum1 = new Empleado("Javier");

for(int i=0;i<5;i++){

    Tarea nuevaTarea = new Tarea();

    nuevaTarea.TareaID = i;

    nuevaTarea.Descripcion = Console.ReadLine();

    nuevaTarea.Duracion = 10;

    empleadoNum1.crearTarea(nuevaTarea);

}

for(int i=0;i<5;i++){

    empleadoNum1.mostrarTarea(i);

}
 

