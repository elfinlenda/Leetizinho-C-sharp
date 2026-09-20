
using Microsoft.VisualBasic;

// pedindo o numero do usuario e guardadndo

Console.Write("Digite um numero para verificar se e palindromo:");
int numero_digitado;
int.TryParse(Console.ReadLine(),out numero_digitado); 
Console.Write($"\nNUMERO DIGITADO : {numero_digitado}\n");

// chamando a classe de solucao

Solution resposta = new();
bool resultado = resposta.IsPalindrome(numero_digitado);
Console.WriteLine($"Retorno do metodo de solucao -> {resultado} <-");  // Retorno/Resposta


// ===============================================================================
//                              DIVISORIA 
// ===============================================================================

public class Solution
{
   // metodo descobrir se e palindromo 
   public bool IsPalindrome(int x)
   {

        int Original = x;
        int numero_Invertido = 0;

        if(x < 0)
        {
            return false;
        }
        else
        {
            while( x > 0)
            {
                int ultimodigito = 0;
                ultimodigito =  x  % 10;
                numero_Invertido = (numero_Invertido * 10) + ultimodigito;
                x = x / 10;
            }

            return numero_Invertido == Original;
 
        }

   }

}