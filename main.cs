using System;

class MainClass {
  public static void Main (string[] args) {
    AlmacenEmpleados<Director> empleados = new AlmacenEmpleados<Director>(3);
    empleados.agregar(new Director(4500));
    empleados.agregar(new Director(3500));
    empleados.agregar(new Director(5500));
    AlmacenEmpleados<Secretaria> empleados_secretaria = new AlmacenEmpleados<Secretaria>(2);
    empleados_secretaria.agregar(new Secretaria(2000));
    empleados_secretaria.agregar(new Secretaria(1500));
    AlmacenEmpleados<Electricista> empleados_electricista = new AlmacenEmpleados<Electricista>(2);
    empleados_electricista.agregar(new Electricista(1500));
    empleados_electricista.agregar(new Electricista(1500));
    AlmacenEmpleados<Estudiante> empleados_estudiantes = new AlmacenEmpleados<Estudiante>(2);
    empleados_estudiantes.agregar(new Estudiante(300));
    empleados_estudiantes.agregar(new Estudiante(600));

  }
}

interface iEmpleados{
  double getSalario();
}

class Estudiante:iEmpleados{
  private double edad;
  private double salario;

  public Estudiante(double edad){
    this.edad = edad;
  }  
  public double getEdad(){
    return edad;
  }
    public double getSalario(){
    return salario;
  }
}

//clase generica
class AlmacenEmpleados<T> where T:iEmpleados{
  private int i = 0;
  private T[] datosEmpleados;

  public AlmacenEmpleados(int z){
    datosEmpleados = new T[z];
  }

  public void agregar(T obj){
    datosEmpleados[i] = obj;
    i++;
  }
  public T getEmpleado(int i){
    return datosEmpleados[i];
  }
}

class Director:iEmpleados{
  private double salario;

  public Director(double salario){
      this.salario = salario;
  }
  public double getSalario(){
    return salario;
  }
}
class Secretaria:iEmpleados{
  private double salario;
  
  public Secretaria(double salario){
      this.salario = salario;
  }
    public double getSalario(){
    return salario;
  }
}
class Electricista:iEmpleados{
  private double salario;
  
  public Electricista(double salario){
      this.salario = salario;
  }
    public double getSalario(){
    return salario;
  }
}