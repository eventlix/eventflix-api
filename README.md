# eventflix-backend

Unit Tests

```
dotnet test tests/Eventflix.Domain.Tests
```

Integration Tests

```
newman run tests/Eventflix.Integration.Tests/eventflix-api.postman_collection.json -e tests/Eventflix.Integration.Tests/environments/local.postman_environment.json --insecure
```


