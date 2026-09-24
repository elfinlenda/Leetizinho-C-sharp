using System.Net;

// ===============================================================================
//                              INICIO
// ===============================================================================

Console.Write("vetor dado --> ");
string[] palavras = {"porco", "porco", "porco"};

for(int i = 0 ; i < palavras.Length; i++)
{
    Console.Write($"|{palavras[i]}|");
}

Console.WriteLine("\n");


Solution solucao = new();
string volta;
volta = solucao.LongestCommonPrefix(palavras);

Console.WriteLine($"Prefixo de maior tamanho:\n ===>  {volta}  <===");

// ===============================================================================
//                              DIVISORIA 
// ===============================================================================


public class Solution { 

    // metodo que encontra o prefixo "mais longo" em comum das strings
    public string LongestCommonPrefix(string[] strs)
    {   

        string retornar = ""; // a string de retorno da funcao

        // for encadeado para andar no vetor e nos argumentos do vetor
        for(int i = 0; i < strs[0].Length; i++)
        {
            char letraatual = strs[0][i]; // a letra que esta fixada no momento da primeira palavra

            for(int j = 0; j < strs.Length; j++)
            {  
                // caso o tamanho da palavra seja = i, entra pois nao tem sentido percorrer mais
                // ou a letra que estou comparando agora seja diferente da equivalente a primeira palavra
                if(i == strs[j].Length || strs[j][i] != letraatual )
                {
                    char[] letra = new char[i]; // vetor char com tamanho de ate onde parou a leitura
                    for(int d = 0; d < i; d++)  // for para pegar as letras da palavra e passar para o vet char
                    {
                       letra[d] = strs[0][d];  
                    }

                    return retornar = new string(letra); // passando o vetor para uma string 
                     
                }
                
            }
                  
            
        }

        return retornar = strs[0]; // caso passe em tudo retorne qualquer palavra


    }

}
