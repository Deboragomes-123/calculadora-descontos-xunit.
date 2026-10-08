using CalculadoraDescontos.App;
using Xunit;

namespace CalculadoraDescontos.Tests;

public class DescontoServiceTests
{
    private readonly DescontoService _service = new DescontoService();

    [Theory]
    [InlineData(2, "BRONZE")]
    [InlineData(7, "PRATA")]
    [InlineData(15, "OURO")]
    public void ObterCategoriaCliente_DeveRetornarCategoriaCorreta(int totalCompras, string categoriaEsperada)
    {
        string resultado = _service.ObterCategoriaCliente(totalCompras);
        Assert.Equal(categoriaEsperada, resultado);
    }

    [Theory]
    [InlineData(100, 10, 90)]
    [InlineData(200, 20, 160)]
    [InlineData(50, 0, 50)]
    public void CalcularDescontoPorPercentual_DeveCalcularValorFinalCorreto(int valorOriginal, int percentual, int valorEsperado)
    {
        int resultado = _service.CalcularDescontoPorPercentual(valorOriginal, percentual);
        Assert.Equal(valorEsperado, resultado);
    }

    [Theory]
    [InlineData(20, false, true)]
    [InlineData(16, true, true)]
    [InlineData(17, false, false)]
    public void EValidoParaCupom_DeveValidarElegibilidadeCorretamente(int idade, bool primeiraCompra, bool resultadoEsperado)
    {
        bool resultado = _service.EValidoParaCupom(idade, primeiraCompra);
        Assert.Equal(resultadoEsperado, resultado);
    }
}
