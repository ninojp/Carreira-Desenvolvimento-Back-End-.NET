# Modificadores de Acesso em C#

## **1. `private` (padrão para membros)**
- **Onde usar**: Campos, métodos, propriedades dentro de uma classe
- **Para que usar**: Ocultar detalhes de implementação; apenas a própria classe acessa

```csharp
public class Exemplo
{
    private string senhaSecreta = "123"; // Só esta classe acessa
    private void MetodoInterno() { } // Só esta classe acessa
}
```

---

## **2. `public`**
- **Onde usar**: Classes, métodos, propriedades que precisam ser acessíveis de qualquer lugar
- **Para que usar**: Expor funcionalidades para todo o projeto e outros assemblies

```csharp
public class MinhaClasse // Qualquer assembly pode usar
{
    public void MetodoPublico() { } // Qualquer código pode chamar
}
```

---

## **3. `internal` (padrão para classes)**
- **Onde usar**: Classes, métodos que devem ser acessíveis apenas no mesmo projeto/assembly
- **Para que usar**: Compartilhar dentro do projeto, mas ocultar de outros projetos

```csharp
internal class AulaPratica2 // Só este assembly acessa
{
    internal void MetodoInterno() { } // Só este assembly acessa
}
```

---

## **4. `protected`**
- **Onde usar**: Membros que devem ser acessíveis em classes derivadas (herança)
- **Para que usar**: Permitir extensão por herança

```csharp
public class Base
{
    protected string dadoHerdado; // Classes filhas podem acessar
}

public class Derivada : Base
{
    public void Usar() 
    { 
        dadoHerdado = "ok"; // Funciona!
    }
}
```

---

## **5. `protected internal`**
- **Onde usar**: Acessível em classes derivadas OU no mesmo assembly
- **Para que usar**: Combinar `protected` + `internal`

```csharp
public class Base
{
    protected internal string dado; // Derivadas OU mesmo assembly
}
```

---

## **6. `private protected`**
- **Onde usar**: Acessível em classes derivadas E no mesmo assembly
- **Para que usar**: Mais restritivo que `protected internal`

```csharp
public class Base
{
    private protected string dado; // Derivadas E mesmo assembly
}
```

---

## **Exemplo Prático no Projeto**

```csharp
internal class AulaPratica2 // Só o projeto "PraticandoIfElse" acessa
{
    public void Calculadora() { } // Qualquer código que tenha acesso à classe pode chamar
    
    // Se fosse assim:
    private void MetodoAuxiliar() { } // Só a classe AulaPratica2 poderia chamar
}
```

---

## **Regra de Ouro**
- ✅ **Use `private` por padrão** e exponha apenas o necessário
- ✅ **Use `public`** apenas para APIs/interfaces que outros devem usar
- ✅ **Use `internal`** para classes auxiliares do projeto
- ✅ **Use `protected`** quando planejar herança

---

## **Princípio do Menor Privilégio**
**Sempre comece com o acesso mais restrito possível!**

Isso aumenta a segurança e facilita a manutenção do código.

---

## **Tabela Resumo**

| Modificador | Mesma Classe | Mesmo Assembly | Classe Derivada | Outro Assembly |
|-------------|--------------|----------------|-----------------|----------------|
| `private` | ✅ | ❌ | ❌ | ❌ |
| `internal` | ✅ | ✅ | ❌ | ❌ |
| `protected` | ✅ | ❌ | ✅ | ❌ |
| `protected internal` | ✅ | ✅ | ✅ | ❌ |
| `private protected` | ✅ | ✅ (somente derivadas) | ✅ (no mesmo assembly) | ❌ |
| `public` | ✅ | ✅ | ✅ | ✅ |
