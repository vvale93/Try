<Query Kind="Program" />


public class Usuario 
{
	public string Login { get; set; }
	public string Password { get; set; }
	public DateTime UltimoLogin { get; set; }
	public int IntentosErroneos { get; set; }
	
	//	si queremos que TODOS los usuarios que se creen tengan un mismo valor inicial
	//	de IntentosErroneos...tengo que hacerlo en el ctor de Usuario
  //
	//public Usuario()
	//{
	//	IntentosErroneos = 4;
	//}
}

public class Seguridad
{
	public string ErrorInfo { get; set; }
	
	private List<Usuario> Usuarios { get; set; }
	
	//	
	private string _uid;
	
	public Usuario Login(string uid, string pwd)
	{
		ErrorInfo = null;
		
		//	verificar que el usuario existe
		_uid = uid;
		Usuario user = Usuarios.Find(BuscarUsuarioValido);

		//	validar que la pass sea correcta
		if (user?.Password == pwd)
		{
			if (user.IntentosErroneos > 3)
			{
				ErrorInfo = "Bloqueado por intentos excesivos";
				return null;
			}
			return user;
		}
		ErrorInfo = "Credenciales invalidas";	
		return null;
	}
	
	private bool BuscarUsuarioValido(Usuario u)
	{
		if (u.Login == _uid)
			return true;
			
		return false;
	}
	
	//	Una alternativa que podemos usar
	//	Inconveniente: hay un acoplamiento fuerte entre Usuario y la clase
	//		que utiliza Login() ya que necesita instanciar Usuario con new
	//
	//	public bool Login(Usuario user, string passwd)
	
	//	constructor
	//
	public Seguridad()
	{
		Usuarios = new List<Usuario>() {
	  	new Usuario() { Login = "hsimpson", Password = "12345" },
	  	new Usuario() { Login = "mburns", Password = "12345" },
	  	new Usuario() { Login = "msimpson", Password = "12345" },
	  	new Usuario() { Login = "mbouvier", Password = "12345" },
	  	new Usuario() { Login = "nflanders", Password = "12345" },
			new Usuario() { Login = "bsimpson", Password = "123456", IntentosErroneos = 3 }
		};
	}
}

int Ordenar(Usuario u1, Usuario u2)
{
	//	multiplicar por -1 para ordenar de manera descendente
	return u1.Login.CompareTo(u2.Login);
}

void Main()
{
	Seguridad seg = new Seguridad();
/*
	//	Para probar la funcion Ordenar dentro de Sort
	
	seg.Usuarios.Dump();
	seg.Usuarios.Sort(Ordenar);
	seg.Usuarios.Dump();
*/	

	Usuario user = seg.Login("bsimpson", "123456");
	
	if (user == null)
		Console.WriteLine(seg.ErrorInfo);
	else	
		user.Dump();
}





/*
		Usuarios = new List<Usuario>() {
	  new Usuario() { Login = "hsimpson", Password = "12345" },
	  new Usuario() { Login = "mburns", Password = "12345" },
	  new Usuario() { Login = "msimpson", Password = "12345" },
	  new Usuario() { Login = "mbouvier", Password = "12345" },
	  new Usuario() { Login = "nflanders", Password = "12345" }
	};
*/