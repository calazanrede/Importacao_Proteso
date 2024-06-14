#INSTRUÇÕES# 
Para executar, pegue o arquivo 'bkp-desafio_tec21' presente na pasta e restaure.
Trocar a String de conexão na LINHA 21 no Program.cs para a conexão do banco de dados que está sendo utilizado.

Explicação: 
Foi feita uma solução simplificada utilizando um banco de dados teste em SQLServer Express (versão gratuita) e comandos SQL simples pelo sistema.
Também foi desenvolvida uma interface um pouco intuitiva e interativa para facilitar os testes.

Constatações:
Como não foi claramente espeficiado. Foi levado em consideração que:

- Cada título possuí apenas 1 credor, 1 apresentante e 1 devedor.

- Todas as informações do título precisam estar devidamente preenchidas para sua importação.

- No XML apresentado, vem o atributo protocolo, porém pela descrição do desafio era para ser criado pelo banco de dados,
será criado uma coluna 'protocolo_arquivo' apenas para importação desse elemento, porém o protocolo será construído como orientado
no desafio não utilizando esse citado mais acima.

- Para os documentos tanto de Credor/Devedor/Apresentante foi considerado CPF ou CNPJ.
