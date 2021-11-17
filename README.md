# Eventflix API

Responsible API for provisioning the endpoints of the main Eventflix application.
Project of registration, management and consultation of events of various types of
stablishments.

## Getting Started

These instructions will give you a copy of the project up and running on
your local machine for development and testing purposes. See deployment
for notes on deploying the project on a live system.

### Prerequisites

Requirements for the software and other tools to build, test and push

- [.NET 6](https://dotnet.microsoft.com/download/dotnet/6.0) - Stack language of application
- [Docker](https://www.docker.com) - To run application
- [Visual Studio Code](https://code.visualstudio.com) - Sugestion of code editor
- [Visual Studio](https://visualstudio.microsoft.com) - Sugestion of specialized IDE for .NET
- [Newman](https://www.npmjs.com/package/newman) - For running integration tests
- [ReportGenerator](https://danielpalme.github.io/ReportGenerator) - For generate code coverage report

### Installing

A step by step series of examples that tell you how to get a development
environment running

Step 1: Clone the repository

```bash
git clone git@github.com:eventlix/eventflix-api.git
```

Step 2: Build and restore dependencies of project

```bash
dotnet build
```

### Running Application

You can run the application locally with the **.NET** or with **Docker**

#### Running with .NET

You can run application with the command:

```bash
dotnet run --project src/Eventflix.Api
```

You can check if application is running accessing via browser the url: `https://localhost:7193` or `http://localhost:5193`

#### Running with Docker

To run the application via docker use the commands below.

```bash
# Build application docker image
docker build -t eventflix-api .

# Run the application image:
docker run --rm -it -p 8000:80 eventflix-api
```

You can check if application is running accessing via browser the url: `http://localhost:8000`

## Running Tests

This project have three different types of test: **Unit Test**, **Integration Tests** and **Load Tests**.

### Running Unit Tests

For run unit test, simply execute command

```bash
dotnet test tests/Eventflix.Domain.Tests
```

You can run the unit tests and generate coverage report too

```bash
# Installing reportgenerator
dotnet tool install --global dotnet-reportgenerator-globaltool

# Runing Unit Tests with code coverage
dotnet test tests/Eventflix.Domain.Tests --verbosity minimal --logger:"html;LogFileName=tests-results.html" --collect:"XPlat Code Coverage"

# Generating reports
cd tests/Eventflix.Domain.Tests
cd $(ls -d */|head -n 1)
reportgenerator "-reports:coverage.cobertura.xml" "-targetdir:coveragereport" -reporttypes:Html
```

### Running Integration Tests

TODO: Complete Running Integration Tests Readme

```bash
newman run tests/Eventflix.Integration.Tests/eventflix-api.postman_collection.json -e tests/Eventflix.Integration.Tests/environments/local.postman_environment.json --insecure
```

### Running Load Tests

TODO: Complete Running Load Tests Readme

## Deployment

TODO: Complete Deployment Readme

## Contributors

<a href="https://github.com/eventlix/eventflix-api/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=eventlix/eventflix-api" />
</a>

## License

This project is licensed under the [Apache License Version 2.0](LICENSE)

## Acknowledgments

Some Patterns and Development Methodologies used in this project:

- [CQRS Pattern](https://github.com/tfsantosbr/dotnet-cqrs-pattern)
- [Notification Pattern](https://github.com/tfsantosbr/dotnet-notification-pattern)
- Mediator Pattern
- Aggregation Pattern
- Rest API
- Repository Pattern
- Domain Driven Design
- Hexagonal Architecture

Article and Documentation References:

- [Cobertura de Testes com Coverlet](https://renatogroffe.medium.com/net-5-cobertura-de-testes-com-coverlet-7cbec2f052d9)
- [Coverlet Documentação](https://github.com/coverlet-coverage/coverlet)
- [Postman Dynamic Variables](https://learning.postman.com/docs/writing-scripts/script-references/variables-list/)
- [Running collections on the command line with Newman](https://learning.postman.com/docs/running-collections/using-newman-cli/command-line-integration-with-newman/)
- [Automatizando testes de APIs REST com Postman + Newman](https://renatogroffe.medium.com/automatizando-testes-de-apis-rest-com-postman-newman-a90f0d90df09)
