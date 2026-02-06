using Xunit;

public class OperacionesTest
{
    private Operaciones op = new Operaciones();
    [Fact]
    public void TestSuma()
    {
        // Given

        int numero1 = 2;
        int numero2 = 3;

        // When
        int totalSuma = op.Suma(numero1, numero2);

        // Then
        Assert.Equal(5, totalSuma);           
        Assert.NotEqual(6, totalSuma);        
        Assert.True(totalSuma > 0);           
    }

    [Fact]
    public void TestResta()
    {
        // Given
        int numero1 = 5;
        int numero2 = 2;

        // When
        int totalResta = op.Resta(numero1, numero2);

        // Then
        Assert.Equal(3, totalResta);           
        Assert.NotEqual(2, totalResta);        
        Assert.True(totalResta > 0);           
    }

    [Fact]
    public void TestMultiplicacion()
    {
        // Given
        int numero1 = 2;
        int numero2 = 2;

        // When
        int totalMultiplicacion = op.Multiplicacion(numero1, numero2);

        // Then
        Assert.Equal(4, totalMultiplicacion);
        Assert.NotEqual(5, totalMultiplicacion);
        Assert.True(totalMultiplicacion > 0);
    }
    [Fact]
    public void TestDivision()
    {
        // Given
        int numero1 = 6;
        int numero2 = 2;

        // When
        int totalDivision = op.Division(numero1, numero2);

        // Then
        Assert.Equal(3, totalDivision);
        Assert.NotEqual(2, totalDivision);
        Assert.True(totalDivision > 0);
    }
    [Fact]
    public void NumeroParImpar()
    {
        // Given
        int numeroPar = 2;
        int numeroImpar = 3;


        // Then
        Assert.True(op.NumeroParImpar(numeroPar));
        Assert.False(op.NumeroParImpar(numeroImpar));
       
    }

}
 
