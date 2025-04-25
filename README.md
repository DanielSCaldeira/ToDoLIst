# ToDoList - Sua Lista de Tarefas Inteligente

Um aplicativo web completo para gerenciar suas tarefas de forma eficiente. Desenvolvido com .Net Core 5 no backend e Reactjs no frontend, oferecendo uma experiência de usuário fluida e responsiva.

## Tecnologias Utilizadas

Este projeto foi construído utilizando as seguintes tecnologias principais:

**Backend (API .Net Core 5):**

* **.Net Core 5:** Framework moderno e robusto para construir aplicações web.
* **PostgreSQL:** Banco de dados relacional potente e confiável para armazenar seus dados.
* **Entity Framework Core (Code First Migration):** ORM para facilitar a interação com o banco de dados através de código.

**Frontend (Reactjs):**

* **Reactjs:** Biblioteca JavaScript popular para construir interfaces de usuário dinâmicas e interativas.

## Pré-requisitos

Antes de começar, certifique-se de ter as seguintes ferramentas instaladas em sua máquina:

* **.Net Core 5 SDK:** Para compilar e executar o backend. Você pode baixá-lo em [https://dotnet.microsoft.com/download/dotnet/5.0](https://dotnet.microsoft.com/download/dotnet/5.0).
* **PostgreSQL:** O sistema de gerenciamento de banco de dados. Você pode instalá-lo seguindo as instruções em [https://www.postgresql.org/download/](https://www.postgresql.org/download/).
* **Node.js e npm (ou yarn):** Para executar e gerenciar as dependências do frontend React. Você pode baixá-los em [https://nodejs.org/](https://nodejs.org/).

## Configuração e Execução

Siga estas etapas para configurar e executar o projeto em seu ambiente local:

### Backend (API .Net Core 5)

1.  **Navegue até o diretório da API:**
    ```bash
    cd ToDoList.API
    ```

2.  **Aplicar as Migrações do Banco de Dados:**
    * **Adicionar uma nova migração (se necessário):**
        ```bash
        dotnet ef migrations add Init -p ../ToDoList.Repository -s . -c ApplicationDbContext
        ```
        *(Observação: `-p` especifica o projeto de repositório, `-s` o projeto de inicialização e `-c` o contexto do banco de dados.)*

    * **Visualizar os scripts SQL gerados pela migração (opcional):**
        ```bash
        dotnet ef migrations script -c ApplicationDbContext -p ../ToDoList.Repository -s .
        ```

    * **Atualizar o banco de dados:**
        ```bash
        dotnet ef database update -c ApplicationDbContext -p ../ToDoList.Repository -s .
        ```

3.  **Executar a API:**
    ```bash
    dotnet run
    ```

    A API estará disponível em alguma porta local (geralmente `http://localhost:5000` ou `http://localhost:5001`). Consulte a saída do console para a URL exata.

### Frontend (Reactjs)

1.  **Navegue até o diretório do frontend:**
    ```bash
    cd ToDoList
    ```

2.  **Instalar as dependências:**
    Se você usa `npm`:
    ```bash
    npm install
    ```
    Ou se você usa `yarn`:
    ```bash
    yarn install
    ```

3.  **Iniciar a aplicação React:**
    Se você usa `npm`:
    ```bash
    npm start
    ```
    Ou se você usa `yarn`:
    ```bash
    yarn start
    ```

    A aplicação frontend será aberta em seu navegador (geralmente em `http://localhost:3000`).

## Próximos Passos e Contribuições

Sinta-se à vontade para explorar o código, reportar problemas (issues) e enviar suas sugestões e pull requests. Este projeto é um ótimo ponto de partida para aprender sobre o desenvolvimento full-stack com .Net Core e React!
