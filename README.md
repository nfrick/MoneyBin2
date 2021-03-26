# MoneyBin2
Aplicação para controle de finanças pessoais e investimentos

## Ferramentas e frameworks
- Visual Studio -  C#
- SQL Server
- SSMS
- SQL Server Reporting Services
- Report Builder
- Nuget packages
  - CSVHelper
  - Entity Framework
  - EPPlus
  - Newtonsoft.Json
  - Ooki.Dialogs
  - SharpZipLib
  - SQLKata
  - Syncfusion
  - Toxy
  
## Compenentes
### MoneyBin
Aplicação para controle de extrato bancário, pagamentos e investimentos (ações, fundos e LCA), capaz de gerenciar diversas contas em diferentes bancos.

<h4>Extratos Bancários</h4>

1. Leitura de extratos bancários em formatos CSV, TXT e PDF.
2. Classificação dos movimentos do extrato em categorias para classificação e análise.
3. A classificação é feita automaticamente no momento da leitura do extrato, utilizando regex para comparar históricos com tabela de categorias.
4. Pesquisa de itens nos extratos por valor, histórico, data, etc.
5. Exportação para CSV, XML, JSON e Excel.
6. Relatórios e análises diversas pelo SQL Server Reporting Services.

<h4>Pagamentos</h4>

1. Agendamento de pagamentos mensais baseando-se em tabela de pagamentos.
2. Leitura de comprovantes de agendamento em formato TXT ou PDF.
3. Comparação entre agenda de pagamentos e extratos bancários para identificar agendamentos.

<h4>Investimentos</h4>

1. Controle de investimentos em ações, com registro de compras e vendas.
2. Acompanhamento de histórico de cotações.
3. Controle de investimentos em fundos de ações e LCA.

### Cotações
Cotações de ações obtidas da API MarketStack.

### Rentabilidade
Leitura de rentabilidades de fundos de ações CEF e Banco do Brasil para planilha.
Futuramente a funcionalidade da planilha (comparação de rentabilidades, gráficos, etc.) será portada para dentro do sistema.

### DataLayer
Todas as business classes.

### Weekend Analysis
Análise de comportamento de ações na véspera de finais de semana.
