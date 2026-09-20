
// exibir o vetor que foi colocado 
Console.Write("O Vetor usada no problema e --> ");
int[] vetorTest = {12,2,6,9,3};
int casas = vetorTest.Length;
for(int i = 0; i < casas ;i++) 
{
    int numero = vetorTest[i];
    Console.Write($"|{numero}");
}


// exibicao do programa  
Console.Write("\nVer se num[x] + num[y] == target !\nColoque o TARGET :");
int Target;
int.TryParse(Console.ReadLine(),out Target);




// chamada do metodo da solucao
Solution minhaSolucao = new();
int[] Resposta = minhaSolucao.TwoSum(vetorTest,Target);


// exibindo resposta 
for(int i = 0; i < 2 ;i++) 
{
    int numero = Resposta[i];
    Console.Write($"|{numero}");
}




public class Solution 
{
    // metodo TWO SUM
    public int[] TwoSum(int[] nums, int target) 
    {

        int[] resposta = new int[2];
        int rodar = nums.Length;
        for(int i = 0; i < rodar ; i++)
        {
            int somador1 = nums[i];
            for(int j = i + 1; j < rodar; j++)
            {

                int somador2 = nums[j];
                int soma;
                soma = somador1 + somador2;

                if(soma == target)
                {
                    resposta[0] = i;
                    resposta[1] = j;
                    return resposta;
                }

            } // for interno 

        } // for externo 

            int[] Naoachado = {-1,-1};
            return Naoachado;

    } // metodo 

} // class Solution



