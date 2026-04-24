# Projeto Amazônia 2 - Inversão de Controle (IoC) e Callbacks

Este projeto é uma **continuação e evolução** do exercício anterior de monitoramento da Amazônia. O objetivo desta nova versão é aplicar os conceitos de **Inversão de Controle (IoC)** e **Callbacks** dentro do padrão de projeto Observer, conforme as orientações do Professor Fabio Fagundes Silveira.

## O que mudou nesta versão?
Na versão anterior, focamos em como o padrão Observer funciona. Agora, o foco é entender a **arquitetura** por trás dele: como a gente inverte o controle do sistema para que ele fique mais flexível e fácil de manter.

## Explicação dos Conceitos Aplicados:

### 1. Inversão de Controle (IoC)
Tradicionalmente, a gente imagina que a Universidade deveria "vigiar" a PCD. Aqui, fizemos o contrário: a PCD (Subject) é quem chama a Universidade (Observer). 
- **O Subject manda no QUANDO:** Ele decide o momento de avisar (quando os sensores mudam).
- **O Observer manda no O QUÊ:** A universidade decide o que fazer com os dados (imprimir, salvar ou analisar).
Isso prova que o controle foi invertido, tirando a responsabilidade da PCD de saber o que fazer com a informação.

### 2. O que o Subject (PCD) fez e por quê?
A classe `PCD` apenas gerencia a lista de interessados e dispara as notificações. 
- **O que ela fez?** Notificou a mudança de Temperatura, PH e Umidade.
- **Por quê?** Porque ela não deve ter "regras de negócio". Ela apenas entrega os dados. Isso mantém o **baixo acoplamento**, permitindo que a PCD funcione com qualquer universidade sem precisar mudar o código dela.

### 3. O que o Observer (Universidade) fez?
O comportamento da universidade **depende do requisito**. Nesta versão, ela recebe o PH, a Temperatura e a Umidade e imprime no console, mas ela é livre para mudar essa lógica sem afetar o sensor.

### 4. Mecanismo de Callback
O método `Atualizar()` na nossa interface funciona como um **Callback**. A universidade "se registra" na PCD e deixa esse método como um "telefone para contato". Quando algo acontece, a PCD "chama de volta" (callback) a universidade através desse método.

## Estrutura dos Arquivos:
- **IObserver.cs**: O contrato/interface que define o Callback e permite a IoC.
- **PCD.cs**: O Sujeito que dispara o evento de medição (agora com PH incluído).
- **Universidade.cs**: O Observador que reage ao Callback conforme seu requisito.
- **Program.cs**: Onde a mágica acontece e a Inversão de Controle é configurada.

## Como rodar o código:
O repositório contém o arquivo de projeto (`.csproj`). Para executar, basta digitar no terminal:

```bash
dotnet run
