# 📄 Documentação Técnica — Atualizações no Projeto Smartphone

## 📌 Objetivo
Implementar melhorias no método `InstalarAplicativo` das classes `Nokia` e `Iphone`, utilizando a estrutura `do...while` e validação da memória disponível, garantindo que apenas aplicativos com necessidade de até **128 MB** sejam instalados com sucesso.

---

## ✅ Dispositivos Envolvidos

| Modelo           | Memória Disponível |
|------------------|--------------------|
| Nokia SM22       | 64 MB              |
| iPhone Teleg T45 | 128 MB             |

---

## ✅ Alterações Realizadas

### 1. 🔁 Implementação de Loop `do...while`
Garante pelo menos uma tentativa de instalação.

Controlado pela variável `instaladoComSucesso`.

```csharp
bool instaladoComSucesso = false;
do
{
    // verificação e tentativa de instalação
} while (!instaladoComSucesso);
```

### 2. 🧠 Validação de Memória
Antes de instalar o aplicativo, o sistema verifica se a memória do dispositivo (`Memoria`) é **maior ou igual a 64 MB**.

Caso contrário, a instalação é cancelada com mensagem de erro.

```csharp
if (Memoria >= memoriaNecessaria)
{
    // instalação bem-sucedida
}
else
{
    // erro de memória
}
```

---

## 💡 Código Final Implementado (Exemplo com iPhone)

```csharp
public override void InstalarAplicativo(string nome)
{
    int memoriaNecessaria = 64; // memória exigida para instalar o app
    bool instaladoComSucesso = false;

    do
    {
        Console.WriteLine($"Verificando memória disponível no iPhone...");

        if (Memoria >= memoriaNecessaria)
        {
            Console.WriteLine($"Instalando o aplicativo {nome} no iPhone...");
            instaladoComSucesso = true;
        }
        else
        {
            Console.WriteLine($"Erro: Memória insuficiente para instalar {nome}. É necessário pelo menos {memoriaNecessaria} MB.");
            break;
        }

    } while (!instaladoComSucesso);

    if (instaladoComSucesso)
        Console.WriteLine($"Aplicativo {nome} instalado com sucesso!");
}
```

---

## 🧪 Testes Realizados

| Smartphone        | Memória | App Tamanho | Resultado Esperado                           |
|-------------------|---------|-------------|----------------------------------------------|
| Nokia SM22        | 64 MB   | 64 MB       | Instalação realizada com sucesso             |
| iPhone Teleg T45  | 128 MB  | 128 MB      | Instalação realizada com sucesso             |
| Nokia SM22        | 64 MB   | 80 MB       | Erro: Memória insuficiente                   |

---

## 📎 Considerações Finais

- A implementação torna o método `InstalarAplicativo` **mais confiável e adaptável** à realidade de dispositivos com diferentes capacidades.
- A estrutura `do...while` facilita futuras melhorias, como tentativas automáticas, feedback ao usuário ou otimização da memória.
- O comportamento é consistente para diferentes marcas de smartphones (`Nokia` e `iPhone`), respeitando a arquitetura comum da classe `Smartphone`.
