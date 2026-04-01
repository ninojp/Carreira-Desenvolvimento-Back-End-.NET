# Formas de Declarar Strings em C#

## 1. **String Interpolation** - `$""`

Permite **interpolar** (inserir) expressões C# diretamente dentro da string usando `{}`.

```csharp
string nome = "Maria";
int idade = 25;

// String interpolation
string mensagem = $"Olá, {nome}! Você tem {idade} anos.";
// Resultado: "Olá, Maria! Você tem 25 anos."

// Pode usar expressões complexas
string info = $"Próximo ano você terá {idade + 1} anos.";
```

**Para que serve:**
- Concatenar valores de forma mais legível que `+` ou `string.Format()`
- Executar expressões dentro da string
- Formatar valores: `$"{preco:C2}"` (moeda), `$"{data:dd/MM/yyyy}"` (data)

---

## 2. **Verbatim String** - `@""`

Trata a string **literalmente**, ignorando caracteres de escape (como `\n`, `\t`).

```csharp
// Sem @"" - precisa escapar barras invertidas
string caminho1 = "C:\\Usuarios\\Documentos\\arquivo.txt";

// Com @"" - não precisa escapar
string caminho2 = @"C:\Usuarios\Documentos\arquivo.txt";

// Multi-linha
string sql = @"SELECT *
FROM Usuarios
WHERE Nome = 'João'";

// Para incluir aspas duplas, use duas aspas duplas
string texto = @"Ele disse: ""Olá!""";
```

**Para que serve:**
- Caminhos de arquivo (Windows)
- Expressões regulares (evitar escape excessivo)
- Strings multi-linha
- SQL queries que ocupam várias linhas

---

## 3. **Combinação** - `@$""` ou `$@""`

Combina **verbatim** e **interpolation** (ambas as formas são válidas).

```csharp
string pasta = "Documentos";
string arquivo = "relatorio.pdf";

// Verbatim + Interpolation
string caminho = $@"C:\Usuarios\{pasta}\{arquivo}";
// ou
string caminho2 = @$"C:\Usuarios\{pasta}\{arquivo}";
```

---

## 4. **Raw String Literals** - `"""` (C# 11+)

Introduzido no **C# 11** (.NET 7+), permite strings com múltiplas linhas sem escape, usando **três ou mais aspas duplas**.

```csharp
// Raw string literal
string json = """
{
    "nome": "João",
    "idade": 30,
    "ativo": true
}
""";

// Com interpolação (adicione $)
string nome = "Maria";
string jsonInterpolado = $"""
{
    "nome": "{nome}",
    "idade": 25
}
""";

// Para incluir aspas duplas, basta usar normalmente
string texto = """
Ele disse: "Olá, mundo!"
""";

// Se precisar de """ na string, use mais aspas no delimitador
string codigo = """"
O delimitador é """
"""";
```

**Para que serve:**
- JSON, XML, HTML embutidos no código
- Strings complexas sem necessidade de escape
- Mantém indentação e formatação exata
- Melhor que `@""` para multi-linha com aspas

---

## **Resumo Comparativo**

| Sintaxe | Nome | Interpolação | Verbatim | Multi-linha | Versão C# |
|---------|------|--------------|----------|-------------|-----------|
| `""`    | String normal | ❌ | ❌ | ❌ | Todas |
| `$""`   | Interpolated | ✅ | ❌ | ❌ | C# 6+ |
| `@""`   | Verbatim | ❌ | ✅ | ✅ | C# 2+ |
| `$@""` ou `@$""` | Verbatim + Interpolated | ✅ | ✅ | ✅ | C# 6+ |
| `""""""` | Raw string | ❌ | ✅ | ✅ | C# 11+ |
| `$""""""` | Raw + Interpolated | ✅ | ✅ | ✅ | C# 11+ |

---

## **Quando Usar Cada Uma**

- **`""`**: Strings simples, curtas
- **`$""`**: Concatenação com variáveis/expressões
- **`@""`**: Caminhos de arquivos, regex, SQL
- **`$@""`**: Caminhos com variáveis
- **`""""""` ou `$"""""""`**: JSON/XML/HTML, documentação, templates complexos (C# 11+)
