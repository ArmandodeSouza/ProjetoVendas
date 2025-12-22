Decisões técnicas

	Linguagem: C#
	Plataforma: VisualStudio 2022 .NET 9.0
	Interface gráfica: Windows Forms (WinForms)
	Banco de dados: PostgreSQL
	Acesso a dados via Npgsql
	Uso do padrão Repository para abstração da persistência
	Uso de Services para orquestração dos casos de uso
	Aplicação de Factories para criação de entidades com regras específicas
	Injeção de dependência para desacoplamento entre camadas
	Relatórios implementados com RDLC / ReportViewer

Estratégia de regras de negócio

	O projeto adota duas abordagens complementares para regras de negócio, conforme a complexidade de cada entidade:

Cliente

	A entidade Cliente foi implementada utilizando Repository, Service e Infrastructure, sendo que:
	As regras de negócio e validações ficam concentradas no Service
	A entidade mantém um modelo mais simples
	O Service atua como camada de proteção antes da persistência

Produto

	A entidade Produto foi implementada utilizando Repository, Service, Infrastructure e Factory, sendo que:
	As regras de negócio (validação de preço, estoque, etc.) ficam dentro da própria entidade
	A Factory é responsável por garantir que o Produto só seja criado em estado válido
	O Service atua apenas como orquestrador, sem conter regras de negócio

	Essa decisão foi tomada para demonstrar diferentes estratégias de modelagem, respeitando o princípio de que regras essenciais devem proteger o domínio.

Como configurar o banco de dados

	Instalar o PostgreSQL
	Criar o banco de dados
	SQL salvo na pasta Docs
	Criar as tabelas necessárias conforme o script SQL fornecido no projeto
	Ajustar a string de conexão na camada de infraestrutura

Exemplo:

	Host=localhost;Port=5432;Database=sistema_vendas;Username=postgres;Password=senha

Como executar o projeto
	
	Abrir a solução no Visual Studio.
	Definir o projeto UI (WinForms) como projeto inicial.
	Verificar a string de conexão com o banco de dados.
	Executar o projeto pressionando F5.

Versão do PostgreSQL utilizada

	PostgreSQL 18

Observações relevantes

	O projeto aplica boas práticas de arquitetura e organização de código.
	As decisões sobre onde posicionar regras de negócio foram feitas de forma consciente e justificada.
	O uso de Factory no Produto garante integridade do domínio desde a criação da entidade.
	A separação entre UI, Application, Domain e Infrastructure facilita manutenção e evolução.
	O sistema foi desenvolvido com foco acadêmico, utilizando padrões amplamente aplicados no mercado.
