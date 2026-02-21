# Construtores em C#

## O que é um Construtor?

Um **construtor** é um método especial de uma classe que é automaticamente executado quando uma nova instância (objeto) da classe é criada. Ele tem o mesmo nome da classe e não possui tipo de retorno (nem mesmo `void`).

### Principais Características dos Construtores

1. **Nome idêntico à classe**: O construtor sempre tem o mesmo nome da classe.
2. **Sem tipo de retorno**: Construtores não retornam valores, nem mesmo `void`.
3. **Execução automática**: São chamados automaticamente quando usamos a palavra-chave `new`.
4. **Múltiplos construtores**: Uma classe pode ter vários construtores com diferentes parâmetros (sobrecarga).

### Para que Serve um Construtor?

Os construtores servem para:

1. **Inicializar o estado do objeto**: Definir valores iniciais para as propriedades e campos.
2. **Garantir consistência**: Assegurar que um objeto seja criado em um estado válido.
3. **Executar lógica de inicialização**: Realizar operações necessárias antes que o objeto seja usado.
4. **Validar dados**: Verificar se os valores fornecidos são válidos antes de criar o objeto.

### Exemplo de Construtor Tradicional

```csharp
public class Titular
{
    public string NomeDoTitular { get; set; }
    public string Sobrenome { get; set; }
    public string CPF { get; set; }
    public string Endereco { get; set; }

    // Construtor tradicional
    public Titular(string nomeDoTitular, string sobrenome, string cpf, string endereco)
    {
        NomeDoTitular = nomeDoTitular;
        Sobrenome = sobrenome;
        CPF = cpf;
        Endereco = endereco;
    }
}
```

**Uso:**
```csharp
var titular = new Titular("João", "Silva", "123.456.789-00", "Rua A, 123");
// O construtor é chamado automaticamente e inicializa todas as propriedades
```

### Tipos de Construtores

#### 1. Construtor Padrão (Default Constructor)
Se você não definir nenhum construtor, o C# cria automaticamente um construtor sem parâmetros:

```csharp
public class Pessoa
{
    public string Nome { get; set; }
    // Construtor padrão é criado automaticamente
}

var pessoa = new Pessoa(); // Funciona sem definir construtor
```

#### 2. Construtor Parametrizado
Aceita parâmetros para inicializar o objeto:

```csharp
public class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
}
```

#### 3. Construtor de Cópia

Cria um novo objeto baseado em um objeto existente:

```csharp
public class Pessoa
{
    public string Nome { get; set; }
    
    public Pessoa(Pessoa outraPessoa)
    {
        Nome = outraPessoa.Nome;
    }
}
```

#### 4. Construtor Estático

Inicializa membros estáticos da classe:

```csharp
public class Configuracao
{
    public static string Ambiente { get; set; }
    
    static Configuracao()
    {
        Ambiente = "Produção";
    }
}
```

---

## O que é um Construtor Primário?

**Construtores Primários** foram introduzidos no C# 12 como uma forma mais concisa de declarar construtores. Eles permitem definir parâmetros diretamente na declaração da classe, eliminando a necessidade de código boilerplate.

### Sintaxe do Construtor Primário

```csharp
public class Titular(string nomeDoTitular, string sobrenome, string cpf, string endereco)
{
    // Os parâmetros estão disponíveis em toda a classe
    public string NomeCompleto => $"{nomeDoTitular} {sobrenome}";
    public string CPF { get; } = cpf;
    public string Endereco { get; set; } = endereco;
}
```

### Principais Características dos Construtores Primários

1. **Sintaxe compacta**: Os parâmetros são declarados diretamente após o nome da classe.
2. **Escopo amplo**: Os parâmetros do construtor primário estão disponíveis em toda a classe.
3. **Menos código**: Elimina a necessidade de declarar campos privados e atribuições explícitas.
4. **Imutabilidade facilitada**: Os parâmetros podem ser usados diretamente sem criar propriedades.

### Comparação: Construtor Tradicional vs Construtor Primário

#### Construtor Tradicional (Antes do C# 12)
```csharp
public class ContaBancaria
{
    public string Titular { get; }
    public decimal Saldo { get; private set; }
    public int Numero { get; }

    public ContaBancaria(string titular, decimal saldoInicial, int numero)
    {
        Titular = titular;
        Saldo = saldoInicial;
        Numero = numero;
    }

    public void Depositar(decimal valor)
    {
        Saldo += valor;
    }
}
```

#### Construtor Primário (C# 12+)
```csharp
public class ContaBancaria(string titular, decimal saldoInicial, int numero)
{
    public string Titular { get; } = titular;
    public decimal Saldo { get; private set; } = saldoInicial;
    public int Numero { get; } = numero;

    public void Depositar(decimal valor)
    {
        Saldo += valor;
    }
}
```

### Quando Usar Construtores Primários?

**Use Construtores Primários quando:**
- A classe tem poucos parâmetros de inicialização
- Você quer código mais conciso
- Os parâmetros são usados principalmente para inicializar propriedades
- Você está trabalhando com C# 12 ou superior

**Use Construtores Tradicionais quando:**
- Você precisa de lógica complexa de validação
- Há necessidade de múltiplos construtores sobrecarregados
- A inicialização envolve operações complexas
- Você precisa compatibilidade com versões anteriores do C#

### Exemplo Completo com Construtores Primários

```csharp
// Usando construtor primário
public class Produto(string nome, decimal preco, int estoque)
{
    public string Nome { get; } = nome;
    public decimal Preco { get; private set; } = preco;
    public int Estoque { get; private set; } = estoque;
    
    // Validação no corpo da classe
    public bool Validar() => !string.IsNullOrEmpty(Nome) && Preco > 0;
    
    // Métodos podem usar os parâmetros do construtor primário
    public string ObterDescricao() => $"{nome} - R$ {Preco:F2}";
    
    public void AtualizarPreco(decimal novoPreco)
    {
        if (novoPreco > 0)
            Preco = novoPreco;
    }
}
```

**Uso:**
```csharp
var produto = new Produto("Notebook", 3500.00m, 10);
Console.WriteLine(produto.ObterDescricao()); // Notebook - R$ 3500.00
```

### Construtores Primários em Records

Os **records** já usavam uma sintaxe similar antes do C# 12:

```csharp
// Record com construtor primário (C# 9+)
public record Pessoa(string Nome, int Idade);

// Equivalente a:
public record Pessoa
{
    public string Nome { get; init; }
    public int Idade { get; init; }
    
    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
}
```

---

## Boas Práticas com Construtores

1. **Valide os parâmetros**: Sempre verifique se os valores recebidos são válidos.
   ```csharp
   public Titular(string nome, string cpf)
   {
       if (string.IsNullOrWhiteSpace(nome))
           throw new ArgumentException("Nome não pode ser vazio");
       
       Nome = nome;
       CPF = cpf;
   }
   ```

2. **Mantenha construtores simples**: Evite lógica complexa; use métodos auxiliares se necessário.

3. **Use sobrecarga com sabedoria**: Crie construtores adicionais apenas quando necessário.
   ```csharp
   public class Conta
   {
       public Conta(string titular) : this(titular, 0) { }
       
       public Conta(string titular, decimal saldoInicial)
       {
           Titular = titular;
           Saldo = saldoInicial;
       }
   }
   ```

4. **Prefira imutabilidade**: Use propriedades somente leitura quando possível.
   ```csharp
   public class Pessoa(string nome)
   {
       public string Nome { get; } = nome; // Somente leitura
   }
   ```

5. **Documente construtores complexos**: Use comentários XML para explicar parâmetros.
   ```csharp
   /// <summary>
   /// Cria uma nova conta bancária
   /// </summary>
   /// <param name="titular">Nome do titular da conta</param>
   /// <param name="saldoInicial">Saldo inicial (deve ser >= 0)</param>
   public ContaBancaria(string titular, decimal saldoInicial)
   {
       // ...
   }
   ```

---

## Resumo

- **Construtores** são métodos especiais que inicializam objetos quando criados.
- **Construtores Primários** (C# 12+) oferecem uma sintaxe mais concisa para casos simples.
- Ambos garantem que objetos sejam criados em um estado consistente e válido.
- A escolha entre tradicional e primário depende da complexidade e requisitos do código.
- Use construtores para estabelecer invariantes e garantir a integridade dos dados.
