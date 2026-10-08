# Calculadora de Descontos

Projeto criado para exemplificar o uso de testes unitários parametrizados no **xUnit** utilizando o ecossistema .NET.

## Diferença entre `[Fact]` e `[Theory]`

- **`[Fact]`**: Utilizado para testes simples e pontuais que testam um único cenário fixo sem necessidade de parâmetros.
- **`[Theory]`**: Utilizado para testes parametrizados que validam um mesmo fluxo de código com múltiplos conjuntos de dados passados através de atributos `[InlineData(...)]`.

## Como Executar os Testes

Para executar a suíte de testes unitários no terminal, utilize o comando:

```bash
dotnet test
