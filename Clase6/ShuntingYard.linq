<Query Kind="Program" />

public class Operador
{
  private enum TipoOperacion
  {
    Suma, 
    Resta,
    Multiplicacion,
    Division
  }
  
  private int Precedencia { get; set; }

  private TipoOperacion Operacion { get; set; }
  
  //  Cuanto mas alta es la precedencia, el operador "separa menos" o sea que tiene mas prioridad en la
  //  evaluacion
  //  Las operaciones como la suma y la resta son las ultimas que se evaluan, por lo tanto tendran
  //  la precedencia menor
  //  PRECEDENCIA MENOR ==> MAYOR PRIORIDAD
  //
  public bool PrecedeA(Operador otro)
  {
    //  IMPLEMENTAR
    return false;
  }
  
  public double Calcular(double op1, double op2)
  {
    //  IMPLEMENTAR
    return default(double);
  }
  
  public override string ToString()
  {
    return Operacion.ToString();
  }

  public static bool TryParse(string token, out Operador result)
  {
    result = new Operador();
    
    switch (token.Trim())
    {
      case "+":
        result.Precedencia = 1;
        result.Operacion = TipoOperacion.Suma;
        break;

      case "-":
        result.Precedencia = 1;
        result.Operacion = TipoOperacion.Resta;
        break;

      case "*":
        result.Precedencia = 2;
        result.Operacion = TipoOperacion.Multiplicacion;
        break;

      case "/":
        result.Precedencia = 2;
        result.Operacion = TipoOperacion.Division;
        break;
        
      default:
        result = null;
        return false;
    }
    return true;
  }
}

void Main()
{
  //string expresion = "   1 + 2 *  3 - 10 / 4  ";  //  resultado: 4.5
  //  string expresion = "3 * 5 / 10 + 4 * 20";  //  resultado: 81.5
  string expresion = "3 + 4 * 2 / 5 -20";  //  resultado: 4.6

  try
  {
    string[] tokens = expresion.SplitExpression();
    tokens.Dump();

    //  Implementa el algoritmo shunting-yard para evaluar una expresion con dos stacks
    //
    foreach (string token in tokens)
    {
      //
    }
  }
  catch (Exception ex)
  {
    Console.WriteLine(ex.Message);
  }
}


/*

    HELPER PARA CONVERTIR UNA EXPRESION EN TOKENS DE MIEMBROS Y OPERADORES
    
    M_1  op1  M_2   op2  M_3    op3   M_4
    
    No considera parentesis ni numeros decimales

*/

public static class Extensiones
{
  //  permite partir una expresion en sus tokens, sin importar si tiene o no espacios de separacion
  //  si hay un error de sintaxis se lanza una excepcion
  //
  public static string[] SplitExpression(this string src)
  {
    State estado = State.EsperaDigito;
    string operadores = "+-*/";
    List<string> result = new List<string>();
    List<char> buffer = new List<char>();

    for (int idx = 0; idx < src.Length; idx++)
    {
      char c = src[idx];
      
      switch (estado)
      {
        case State.EsperaDigito:
          //  si es espacio saltar...
          //  si es digito, DigitoEnCurso y seguimos
          //  cualquier otra cosa: ERROR
          //
          if (operadores.IndexOf(c) < 0)
          {
            if (!Char.IsWhiteSpace(c))
            {
              if (Char.IsDigit(c))
              {
                estado = State.DigitoEnCurso;
                buffer.Add(c);
              }
              else
                throw new ExpressionException("Caracter invalido en la expresion", src, idx);
            }
          }
          else
            throw new ExpressionException("Se esperaba un digito", src, idx); //  si es operador ERROR
          break;
          
        case State.DigitoEnCurso:
          //  si es espacio, termina digito y esperar operador
          //  si es operador, termina digito, termina operador y espera digito
          //  si es digito, seguir
          //  cualquier otra cosa: ERROR
          //
          if (Char.IsWhiteSpace(c))
          {
            result.Add(new String(buffer.ToArray()));
            buffer.Clear();

            estado = State.EsperaOperador;
          }
          else
          {
            if (operadores.IndexOf(c) >= 0)
            {
              result.Add(new String(buffer.ToArray()));
              buffer.Clear();
              result.Add(new String(c, 1));
              
              estado = State.EsperaDigito;
            }
            else
            {
              if (Char.IsDigit(c))
                buffer.Add(c);
              else
                throw new ExpressionException("Caracter invalido, se esperaba un digito o un operador", 
                  src, idx);
            }
          }
          break;
          
        case State.EsperaOperador:
          //  si es espacio saltar
          //  si es operador, termina operador y espera digito
          if (!Char.IsWhiteSpace(c))
          {
            if (operadores.IndexOf(c) >= 0)
            {
              buffer.Clear();
              result.Add(new String(c, 1));

              estado = State.EsperaDigito;
            }
            else
              throw new ExpressionException("Se esperaba un operador o el fin de la expresion...", src, idx);
              //  si es digito o cualquier otro caracter, ERROR
          }
          break;
      }
    }
    //  Llegado el final de la expresion...si el estado es 
    //  - EsperaDigito ==> error porque debo haber terminado con un operador
    //  - EsperaOperador ==> ok y no hay mas nada que agregar
    //  - DigitoEnCurso ==> ok y hay que agregar lo que tengo en el buffer
    if (estado == State.EsperaDigito)
      throw new ExpressionException("Parece que falta un operando en la expresion", src, src.Length);
    if (estado == State.DigitoEnCurso)
    {
      result.Add(new String(buffer.ToArray()));
      buffer.Clear();
    }
    return result.ToArray();
  }
  
  private enum State
  {
    EsperaOperador,
    EsperaDigito,
    DigitoEnCurso
  }
}

public class ExpressionException : ApplicationException
{ 
  private int _pos;
  private string _origen;
  
  public ExpressionException(string msg, string origen, int pos) : base(msg)
  {
    _pos = pos;
    _origen = origen;
  }

  public override string Message
  {
    get 
    {
      StringBuilder sb = new StringBuilder(_origen);
      
      sb.AppendLine();
      sb.AppendFormat("{0}^-- {1} posicion {2}", 
        new string(' ', _pos), base.Message, _pos);
      
      return sb.ToString();
    }
  }
}