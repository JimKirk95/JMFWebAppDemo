<p align="center">
  <a href="http://gg.gg/jpwork">
    <img src="https://drive.google.com/uc?export=view&id=1e59cCO6e4Uu1oeO0YFUYwV58rVM_ABMQ" alt="jpwork"/>
  </a>
</p>
<h1 align="center"> 🌎 JMFWebAppDemo 🌎</h1>

## Web API desenvolvida em C# 📝 com acesso de consulta a SQL Server 🗃️
Uma versão está hospedada no Serviço de Aplicativos Azure 🌍, com acesso a uma base de dados SQL Server 🗃️ hospedada em Máquina Virtual do Azure 🌏: https://jmfwebapi2021.azurewebsites.net/

Documentação da API: https://jmfwebapi2021.azurewebsites.net/Help

---

## Chamadas `GET` da API:
Jogadores com mais vitórias no total 🥇🥈🥉 ([experimente aqui](https://jmfwebapi2021.azurewebsites.net/API/TopWinners "GET TopWinners")):
```
https://jmfwebapi2021.azurewebsites.net/API/TopWinners
```
Jogadores com mais jogos no total ([experimente aqui](https://jmfwebapi2021.azurewebsites.net/API/TopPlayers "GET TopPlayers")): 
```
https://jmfwebapi2021.azurewebsites.net/API/TopPlayers
```
Jogadores com mais vitórias na semana 🥇🥈🥉 ([experimente aqui](https://jmfwebapi2021.azurewebsites.net/API/WeekWinners "GET WeekWinners")):
```
https://jmfwebapi2021.azurewebsites.net/API/WeekWinners
```
Jogadores com mais jogos na semana ([experimente aqui](https://jmfwebapi2021.azurewebsites.net/API/WeekPlayers "GET WeekPlayers")):
```
https://jmfwebapi2021.azurewebsites.net/API/WeekPlayers
```
Passando um número de 1 a 3 em qualquer uma dessas chamadas, apenas o jogador nessa colocação é retornado.
Por exemplo ([experimente aqui](https://jmfwebapi2021.azurewebsites.net/API/WeekWinners/2 "GET 2nd WeekWinner")):
```
https://jmfwebapi2021.azurewebsites.net/API/WeekWinners/2
```
Traz o segundo jogador 🥈 com mais vitórias na semana.

---
Esta API apenas faz consultas. Uma outra API realiza inserções, atualizações e remoções da base de dados:

https://github.com/JimKirk95/JMFWebAppUpdtDemo

- 👀 Solução desenvolvida no Microsoft Visual Studio Community 2019, Versão 16.9.1
- 👀 Projeto baseado no modelo "Aplicativo Web ASP.NET (.NET Framework)" com C#
- 👀 Hospedado na conta gratuita do Azure. O SQL Server deve funcionar até 10 de abril de 2021.

---
## 📝 Licença [MIT](./LICENSE).
