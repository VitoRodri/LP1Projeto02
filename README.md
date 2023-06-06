# LP1Projeto02 - TragicTheReckoning


## Autoria:

Samuel Carvalho (a22201379): Escreveu o relatório final, fez o flowchart e modificou alguns dos comentários em XML nos scripts.

Vitória Rodrigues (a22204356): Programou o código para o jogo.

Link do repositório Git: https://github.com/VitoRodri/LP1Projeto02.git

## Arquitetura do Projeto:

O projeto tem uma classe program que inicia o Turn, o Controller, a View e o método Run do Controller. Depois temos a classe View e a interface IView com métodos para mostrar texto e ler o que o jogador escrever na linha de comandos. Temos a classe Controller com o método Run(), que junta os métodos do Turn e da View. Na classe Turn inicializa 2 players e tem dois métodos, um para a fase de Feitiços e um para a fase de Ataque. A classe Player guarda o HP e o MP de um player assim como o seu deck e as suas cartas na mão. Temos a enum CardNames que contém os nomes das cartas. Temos a classe CardDeck que adiciona as 20 cartas ao à deck e baralha as mesmas. Finalmente temos a classe card que guarda o Custo, o AP e o DP de cada carta, dependendo do nome da mesma. 

                     
## Diagrama UML:
      
![Diagrama_UML](https://github.com/VitoRodri/LP1Projeto02/assets/115217659/e5b3ace5-9750-4405-b6ca-7fb039e1bf13)

## Referências 

Neste projeto a única referência usada foi .Net API do c#. 
