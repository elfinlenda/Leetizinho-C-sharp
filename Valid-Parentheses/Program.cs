// ===============================================================================
//                              INICIO
// ===============================================================================



Solution resolver = new();


Console.WriteLine($"{resolver.IsValid("([])")}");



// ===============================================================================
//                              DIVISORIA 
// ===============================================================================


// () {} []  
// o ultimo a ser aberto deve ser o primeiro  ser fechado
// 
public class Solution {
    public bool IsValid(string s) {

        Stack<char> pilha_abre_fecha = new Stack<char>(); // estrutura pronta de pilha do C#

        for(int i = 0; i < s.Length ; i++) // for para empilhar
        {
            if(s[i] is '(' or '{' or '[') // empilhar caso nao seja um que fecha
            {
                pilha_abre_fecha.Push(s[i]); // empilhar
               
            }
            else // quando os ({[ comecam a fechar
            {  
                if (pilha_abre_fecha.Count == 0) // primeiro se nao haver nada para remover aqui, ja retorna false
                {
                    return false;
                }

                if(s[i] == ')')
                {
                    if('(' == pilha_abre_fecha.Peek() ) // se o topo da pilha for o equivalente 
                    {
                        pilha_abre_fecha.Pop();  // remove o que esta no topo
                    }
                }
                if(s[i] == '}')
                {
                    if('{' == pilha_abre_fecha.Peek() )// se o topo da pilha for o equivalente 
                    {
                        pilha_abre_fecha.Pop(); // remove o que esta no topo                   
                    }
                }
                if(s[i] == ']')
                {
                    if( '[' == pilha_abre_fecha.Peek())// se o topo da pilha for o equivalente 
                    {
                        pilha_abre_fecha.Pop();// remove o que esta no topo
                    }
                }
                 
            }

        }

        if(pilha_abre_fecha.Count == 0)
        {
            return true;
        }else
        {
            return false;
        }

    }
}

// ()[][]{}

