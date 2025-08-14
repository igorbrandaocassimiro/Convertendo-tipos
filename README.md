# 📘 Conversão Explícita e Truncamento em C#

Este repositório contém uma atividade simples em **C#** para praticar o conceito de **conversão explícita entre tipos numéricos** e entender o funcionamento do **truncamento**.

---

## 📌 Descrição
Nesta atividade:
- Utilizamos **conversão explícita** para transformar um valor de um tipo numérico para outro.
- Usamos o comando `(int)pesoContainer` para realizar o **truncamento**, que **descarta a parte decimal** de um número sem arredondar.
- O truncamento mantém apenas a parte inteira, ignorando tudo que vem após a vírgula.

---

## 🧠 Exemplo prático
```csharp
float pesoContainer = 1250.75f;
int pesoInteiro = (int)pesoContainer;

Console.WriteLine(pesoInteiro); // Saída: 1250
