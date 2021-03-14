# JMFWebAppDemo
Web API hospedada no Serviço de Aplicativos Azure, com acesso de consulta a base de dados do SQL Server hospedado em Máquina Virtual do Azure:
https://jmfwebapi2021.azurewebsites.net/

Documentação da API:
https://jmfwebapi2021.azurewebsites.net/Help

Jogadores com mais vitórias no total:
https://jmfwebapi2021.azurewebsites.net/API/TopWinners

Jogadores com mais jogos no total:
https://jmfwebapi2021.azurewebsites.net/API/TopPlayers

Jogadores com mais vitórias na semana:
https://jmfwebapi2021.azurewebsites.net/API/WeekWinners

Jogadores com mais jogos na semana:
https://jmfwebapi2021.azurewebsites.net/API/WeekPlayers

Passando um número de 1 a 3 em qualquer uma dessas chamadas, apenas o jogador nessa colocação é retornado.
Por exemplo:
https://jmfwebapi2021.azurewebsites.net/API/WeekWinners/2
Traz o segundo jogador com mais vitórias na semana.

Esta API apenas faz consultas. Uma outra API realiza inserções, atualizações e remoções da base de dados:
https://github.com/JimKirk95/JMFWebAppUpdtDemo

Solução desenvolvida no Microsoft Visual Studio Community 2019, Versão 16.9.1
Projeto Projeto baseado no modelo "Aplicativo Web ASP.NET (.NET Framework)" com C#
Hospedado na conta gratuita do Azure. O SQL Server deve funcionar até 10 de abril de 2021.
