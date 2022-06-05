//3.Dado um limite inferior e superior, calcule a soma de todos os números pares contidos
//nesse intervalo. 


int totpositivo=0;



for (int i = 0; i <= 20; i++)
{
    if(i % 2 == 0)
    {
        totpositivo = totpositivo + i;
        Console.WriteLine(i + " valor atual é " + totpositivo);
    }
    
   

}

