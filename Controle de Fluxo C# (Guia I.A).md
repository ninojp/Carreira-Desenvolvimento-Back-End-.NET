# Instruções de Controle de Fluxo em C#

## 🔴 BREAK
O `break` **interrompe completamente** a execução do laço (loop) atual e sai dele imediatamente.

**Quando usar:**
- Quando você encontrou o que procurava e não precisa continuar
- Para sair de um loop baseado em uma condição específica
- Para economizar processamento evitando iterações desnecessárias

**Exemplo do código:**
```csharp
// Procura "Ana" e quando encontra, SAI do loop
if (nome.Equals("Ana"))
{
    Console.WriteLine($"Da lista o nome digitado foi: {funcionarios[i]}.");
    break; // PARA AQUI! Não continua o loop
}
```

---

## 🟡 CONTINUE
O `continue` **pula a iteração atual** e vai para a próxima iteração do loop.

**Quando usar:**
- Quando você quer ignorar certos itens mas continuar processando os demais
- Para filtrar elementos sem sair do loop
- Para evitar código aninhado (ifs dentro de ifs)

**Exemplo do código:**
```csharp
// Pula funcionários com salário > 5000 e continua o loop
if (intSalario > 5000)
{
    continue; // PULA esta pessoa e vai para a próxima
}
Console.WriteLine($"Salários abaixo de R$5000,00: {funcionarios[i]}.");
```

---

## 📋 OUTROS COMANDOS SIMILARES

### 1. **GOTO** (⚠️ Evite usar!)
Salta para um label específico no código.
```csharp
for (int i = 0; i < 10; i++)
{
    if (i == 5) goto fim;
    Console.WriteLine(i);
}
fim:
Console.WriteLine("Pulou para aqui!");
```
**Por que evitar:** Torna o código difícil de ler e manter ("código espaguete").

### 2. **RETURN**
Sai do método atual completamente (não só do loop).
```csharp
public bool ProcurarFuncionario(string nome)
{
    foreach (var func in funcionarios)
    {
        if (func.Contains(nome))
            return true; // SAI DO MÉTODO INTEIRO
    }
    return false;
}
```

### 3. **THROW**
Lança uma exceção, interrompendo o fluxo normal.
```csharp
for (int i = 0; i < lista.Count; i++)
{
    if (lista[i] == null)
        throw new Exception("Erro!"); // PARA TUDO
}
```

### 4. **YIELD BREAK** (para iteradores)
Finaliza uma sequência em métodos com `yield return`.
```csharp
public IEnumerable<int> GerarNumeros()
{
    for (int i = 0; i < 100; i++)
    {
        if (i > 10) yield break; // Para de gerar
        yield return i;
    }
}
```

---

## 🎯 COMPARAÇÃO PRÁTICA

```csharp
// BREAK - Para completamente
for (int i = 1; i <= 5; i++)
{
    if (i == 3) break;
    Console.WriteLine(i);
}
// Resultado: 1, 2

// CONTINUE - Pula só o 3
for (int i = 1; i <= 5; i++)
{
    if (i == 3) continue;
    Console.WriteLine(i);
}
// Resultado: 1, 2, 4, 5

// RETURN - Sai do método
public void Exemplo()
{
    for (int i = 1; i <= 5; i++)
    {
        if (i == 3) return;
        Console.WriteLine(i);
    }
    Console.WriteLine("Isso não será executado");
}
// Resultado: 1, 2
```

---

## 💡 DICAS DE BOAS PRÁTICAS

1. **Use `break` quando:** encontrou o que procurava
2. **Use `continue` quando:** quer filtrar/pular itens
3. **Evite `goto`:** sempre há uma alternativa melhor
4. **Prefira `return`:** para validações no início de métodos
5. **Loops aninhados:** `break` só sai do loop atual, não de todos

```csharp
// break só sai do loop interno!
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        if (j == 1) break; // Sai só do for de j
        Console.WriteLine($"i={i}, j={j}");
    }
}
```

---

## 📚 CATEGORIA

Esses comandos fazem parte da categoria **"Jump Statements"** (Instruções de Salto) em C#. Eles alteram o fluxo normal de execução do programa!

### Lista Completa de Jump Statements em C#:
- `break` - Sai do loop ou switch atual
- `continue` - Pula para a próxima iteração do loop
- `goto` - Salta para um label específico
- `return` - Retorna do método atual
- `throw` - Lança uma exceção
- `yield break` - Finaliza um iterador

---

## 🎓 RESUMO

| Comando | O que faz | Quando usar |
|---------|-----------|-------------|
| `break` | Sai do loop completamente | Quando encontrou o que procurava |
| `continue` | Pula para próxima iteração | Quando quer ignorar alguns itens |
| `return` | Sai do método inteiro | Para retornar um valor ou finalizar método |
| `goto` | Salta para um label | ⚠️ Evitar sempre que possível |
| `throw` | Lança uma exceção | Para tratar erros |
| `yield break` | Finaliza iterador | Em métodos que retornam IEnumerable |

---

**Dica Final:** Prefira sempre a solução mais simples e legível. Na maioria dos casos, `break` e `continue` são suficientes! 🚀
