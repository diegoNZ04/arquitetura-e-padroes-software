
namespace design_patterns_console.UML.Examples;

public class UmaClasse
{
   private string _nome;
   public string _sobrenome;
   protected int _idade;

   public UmaClasse(string nome, string sobrenome, int idade)
   {
      _nome = nome;
      _sobrenome = sobrenome;
      _idade = idade;
   }

   public string GetNome()
   {
      return _nome;
   }

   public int GetIdade()
   {
      return _idade;
   }

   public string SetNome(string nome)
   {
      _nome = nome;
      return _nome;
   }

   public int SetIdade(int idade)
   {
      _idade = idade;
      return _idade;
   }
}
