
// receber a entrada do usuario

using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

Console.WriteLine("Escreva na um numero romano e descubra sua versao decimal :");
string Romano;
int conta = 0;

Romano = Console.ReadLine();

// validando a entrada que o usuario colocou !
while(conta == 0)
{ 
    for(int i = 0; i < Romano.Length; i++)
    {  
        if(Romano[i] is not ('I' or 'V' or 'X' or 'L' or 'C' or 'D' or 'M'))
        {   
            Console.WriteLine("Entrada invaldia. Digite denovo !");
            Romano = Console.ReadLine();
            i = 0;
        }

    }

    conta = 1;
}

// exibir as informacoes 

Console.Write($"O numero que digitou foi esse : {Romano}\nE em inteiro esse numer e : ");

Solution resposta = new();

int convertido = resposta.RomanToInt(Romano);

Console.Write($" ==> {convertido}  <===");


// ===============================================================================
//                              DIVISORIA 
// ===============================================================================

public class Solution 
{
    public int RomanToInt(string s)
    {   
        // variaveis para gerenciar a logica 

        int contador = 0;                   // parar o while
        int numero_convertido = 0;          // onde ira ser guardado o n convertido
        int[] guardar = new int[s.Length];  // vetor p/ salvar cada algarismo 


        // convertendo as Letras -> Numeros e guardando em casas de um vetor
        while(contador == 0)
        {
            for(int i = s.Length -1 ; i >= 0; i--)
            {    
                
                if(s[i] == 'I')
                {
                    guardar[i] = 1;
                }
                
                if(s[i] == 'V' )
                {
                    if( i > 0 && s[i-1] == 'I')
                    {
                        guardar[i] = 4;
                        i--;
                    }
                    else
                    {
                    guardar[i] = 5;   
                    }
                }
                
                if(s[i] == 'X' )
                {
                    if( i > 0 && s[i-1] == 'I')
                    {
                        guardar[i] = 9;
                        i--;
                    }else
                    {
                    guardar[i] = 10; 
                    }
                }
                
                if(s[i] == 'L' )
                {
                    if( i > 0 && s[i-1] == 'X')
                    {
                        guardar[i] = 40;
                        i--;
                    }else
                    {
                    guardar[i] = 50;                    
                    }
                }
                
                if(s[i] == 'C' )
                {
                    if( i > 0 && s[i-1] == 'X')
                    {
                        guardar[i] = 90;
                        i--;
                    }else
                    {
                    guardar[i] = 100; 
                    }
                }
                
                if(s[i] == 'D' )
                {
                    if( i > 0 && s[i-1] == 'C')
                    {
                        guardar[i] = 400;
                        i--;
                    }else
                    {
                    guardar[i] = 500; 
                    }
                }
                
                if(s[i] == 'M' )
                {
                    if( i > 0 && s[i-1] == 'C')
                    {
                        guardar[i] = 900;
                        i--;
                    }else
                    {
                    guardar[i] = 1000; 
                    }
                }


            }

            contador = 1;
        }


        // transferindo os valores do vetor para a variavel

        for(int i = 0; i < s.Length; i++)
        {
            numero_convertido =  numero_convertido + guardar[i];

        }

        return numero_convertido;

    }

        
}

