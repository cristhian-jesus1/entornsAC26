public class Operaciones
{
    public int Suma(int numero1,int numero2)
    {
        int totalSuma = numero1 + numero2;
        return totalSuma;
    }

    public int Resta(int numero1, int numero2)
    {
        int totalResta = numero1 -  numero2;
        return totalResta;
    }

    public int Multiplicacion(int numero1, int numero2)
    {
        int totalMultiplicacion = numero1 * numero2;
        return totalMultiplicacion;
    }

    
    public int Division(int numero1,int numero2)
    {
        
       if (numero2 == 0)
       {
         return 0;
       }
        else
        {
            int totalDivision = numero1 / numero2;
            return totalDivision;
        }
    }

    public bool NumeroParImpar(int numero)
    {
        if (numero %2==0)
        {
            
            return true;
        }
        else
        {
            return false;
        }
    }
}