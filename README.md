<p align="center">
  <a href="http://gg.gg/jpwork">
    <img src="https://drive.google.com/uc?export=view&id=1e59cCO6e4Uu1oeO0YFUYwV58rVM_ABMQ">
  </a>
</p>
<h1 align="center">JMFWebAppDemo</h1>
<!---🗃️🌍 🌎🌎 📝 🗃️  🌏
<img src="https://simpleicons.org/icons/csharp.svg" width="20px;" />
---> 

## Web API desenvolvida em C# com acesso de consulta a SQL Server 
Uma versão está hospedada no Serviço de Aplicativos Azure, com acesso a uma base de dados SQL Server hospedada em Máquina Virtual do Azure: https://jmfwebapi2021.azurewebsites.net/

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

<!---
## Autor
<a href="http://gg.gg/jpwork">
 <img src="https://drive.google.com/uc?export=view&id=17_6ZWPP0DJx4fiLnO4EiWNFaNRaB2Abp" width="100px;" alt=""/>
 <br />
 <sub><b>Jackson Matsuura</b></sub></a>
 <br />
---> 
## Autor [![Github Badge](https://img.shields.io/badge/-Github/JimKirk95-000?style=flat-square&logo=Github&logoColor=white&link=https://github.com/JimKirk95)](https://github.com/JimKirk95) [![Linkedin Badge](https://img.shields.io/badge/-LinkedIn/jacksonmatsuura-blue?style=flat-square&logo=Linkedin&logoColor=white&link=https://www.linkedin.com/in/jacksonmatsuura/)](https://www.linkedin.com/in/jacksonmatsuura/) [![Gmail Badge](https://img.shields.io/badge/-jackson.matsuura@Gmail-c14438?style=flat-square&logo=Gmail&logoColor=white&link=mailto:seu_emjackson.matsuura@gmail.comail)](mailto:jackson.matsuura@gmail.com)
<!---
[![Whatsapp Badge](https://img.shields.io/badge/-Whatsapp-4CA143?style=flat-square&labelColor=4CA143&logo=whatsapp&logoColor=white&link=https://api.whatsapp.com/send?phone=seu_telefone_55+12+981082413&text=Hello!)](https://api.whatsapp.com/send?phone=seu_telefone_55+12+981082413&text=Hello!)
--->

---
## 📝 Licença [MIT](./LICENSE).
