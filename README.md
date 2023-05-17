# Aula-2-Dominando-o-Sistema-REP
Jornada .NET 9.0

O que é sistema R.E.P?
- Recursos Básicos
	. Variáveis e tipos de dados
		> Variáveis podem armazenar valores de um tipo especificado
		> Existes duas categorias de tipos de dados em C#
			. Tipos de Valor: Cada variável tem sua própria cópia de dados, e uma operação que afete uma variável não afeta a outra.
			. Exemplos: short, int, long, float, double, decimal, bool, enum
			(Entre float, double e decimal, vai depender daa necessidade de precisão, memória e performace)
			. Tipos de Referência: Armazenam referências a seus objetos. Nele, duas variáveis podem referenciar o mesmo objeto, e operações em uma variável afetam o objeto referenciado por elas.
			. Exemplos: string, classe, interface, matriz

	. Estruturas de Condição
		> Permitem executar um bloco de códgo baseado no valor de expressões, que podem ser true ou false(valor booleano)
			.if > else if > else
			. switch

	. Estruturas de Repetição
		> Permitem executar um bloco de código múltiplas vezes. São amplamente utilizadas e diversos cenários, como percorrer uma lista ou matriz e realizar uma ação específica
			.for (inicializador; condição; iterador)
			. while
			.do..while
			.foreach

- Estrutura de Dados
	. Matrizes e Listas
		> Matrizes: Estrutura dedados tipada, com especificaçãao de tamanho em sua inicialização, com acesso por índice
		> Listas: Estrutura de dados tipada, com tamanho dinâmico, com algumas operações específicas adicionais
			. LINQ: Language-Integrated Query, é uma sintaxe de consultas em coleções .NET estendo suas capacidades
				> Busca: Silgle, First, Where, Any
				> Ordenação: OrderBy, OrderByDescending
				> Aritméticos: Sum, Min, Max, Count
				
	. Dicionários: Estrutura de dados Tipada, que permite armazenamento de pares chave-valor. Ela permite operações eficientes de inserção, remoção e busca através de chaves unicas (cenários "de-para")
		

- Programação Orientada a Objetos: Paradigma da programação que contém caracteristicas e comportamentos
	> Caracteristicas geralmente são chamados de atributos ou propriedades
	> Comportamentos geralmente são chamados de métodos ou funções
	
	. Abstração
		> Esconder detalhes de implementação através daa criação de classes e métodos para armazenarem comportamentos
		> Exemplo: Máquina de Café
		
	. Herança
		> Permitir reusabilidade de informações e comportamentos de objetos
		> Exemplo: Pessoa, que pode ter informações e comportamentos a serem herdados por outras classes, como Funcionário e Prestador de Serviço
		
	. Polimorfismo
		> Permiti a execução de métodos de classes base por classes derivadas, onde cada uma pode especificar comportamentos específicos para esses métodos.
		> Exemplo: Similar ao de herança, onde um método da classe base Pessoa pode ter diferentes implementações nas classes derivadas
		
	. Encapsulamento
		> Controlara visibilidade de elementos de uma classe através de modificadores de acesso
		> Modificadores de Acesso:
			. public: livre acesso, 
			. protected: dentro da classe, classe derivada, 
			. internal: dentro da classe, classe derivada e não derivada de mesmo assembly, 
			. protected internal: dentro da classe, classe derivada de mesmo assembly e não-derivada de mesmo assembly, classes derivadas de outros assemblies,
			. private: somente dentro da classe, 
			. private protected: dentro da classe e classe derivada de mesmo assembly

			OBS.: Classe selada: Restringir Herança (Impede que outras classes herdem dela)

      Configs Vs Code
      dotnet new Console - Cria uma aplicação 
      dotnet new list - mostra a lista de projetos que podem ser criados
