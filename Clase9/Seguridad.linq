<Query Kind="Program">
  <Reference Relative="Datos.dll">D:\DESARROLLO\CURSO_EMPLEARTEC\src_git\Clase9\Datos.dll</Reference>
  <Reference Relative="Newtonsoft.Json.dll">D:\DESARROLLO\CURSO_EMPLEARTEC\src_git\Clase9\Newtonsoft.Json.dll</Reference>
  <Namespace>Datos</Namespace>
</Query>

void Main()
{
  Database db = new Database();
  
  //  db.Provincias.Dump();
  db.TiposContacto.Dump();
}


public class Database
{
  private List<Persona> _personas ;
  private List<Usuario> _usuarios;
  private List<Empleado> _empleados;
  private List<TipoContacto> _tiposContacto;
  
  public List<Persona> Personas 
  { 
    get  
    {
      return _personas;
    }
  }
  
  //  agregar el resto...
  
  public List<Provincia> Provincias { get { return Datos.Info.Provincias; } }

  public List<Localidad> Localidades { get { return Datos.Info.Localidades; }}
  
  public List<TipoContacto> TiposContacto  { get { return _tiposContacto; } }
  
  public Database()
  {
    _tiposContacto = new List<TipoContacto>() 
    {
      new TipoContacto() { IDTipoContacto = 1, Descripcion = "Cuenta de twitter" },
      new TipoContacto() { IDTipoContacto = 2, Descripcion = "Correo Electronico", 
                           RegExp = @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$" },
      new TipoContacto() { IDTipoContacto = 3, Descripcion = "Telefono Fijo Particular",
                            RegExp= "tel_fijo" },
      new TipoContacto() { IDTipoContacto = 4, Descripcion = "Telefono Fijo Laboral", 
                            RegExp= "tel_fijo" },
      new TipoContacto() { IDTipoContacto = 5, Descripcion = "Telefono Movil Particular",
                            RegExp = "tel_movil" },
      new TipoContacto() { IDTipoContacto = 6, Descripcion = "Cuenta de Facebook" }
    };
    
    _personas = new List<Persona>() 
    {
      //  agregar personas
    };
    
    _empleados = new List<Empleado>() 
    {
      //  agregar Empleados
    };
    
    _usuarios = new List<Usuario>() 
    {
      //  agregar usuarios
    };
  }
}

public class Persona {}

public class Empleado {}

public class Usuario {}

public enum Sexo
{
  Femenino,
  Masculino,
  NoInformado,
  Indefinido
}

public class TipoContacto
{
  public int IDTipoContacto { get; set; }

  /// <summary>
  /// Por ejemplo: Movil Particular, Movil Empresa, Domicilio, Trabajo, Correo Electronico, etc... 
  /// </summary>
  public string Descripcion { get; set; }

  /// <summary>
  /// 
  /// </summary>
  public string RegExp { get; set; }
}



