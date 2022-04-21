# Generated code configuration

Run `dotnet build /t:GenerateCode` to generate code.

``` yaml
tag: release_1_1_preview.1
require:
    -  https://github.com/Azure/azure-rest-api-specs/blob/bc30c81584620e45889d10e7c60b8d78230b4dd5/specification/cognitiveservices/data-plane/AnomalyDetector/readme.md
namespace: Azure.AI.AnomalyDetector
generation1-convenience-client: true
public-clients: true
security:
  - AADToken
  - AzureKey
security-header-name: Ocp-Apim-Subscription-Key
security-scopes: https://cognitiveservices.azure.com/.default
```

### Make Endpoint type as Uri

``` yaml
directive:
  from: swagger-document
  where: $.parameters.Endpoint
  transform: $.format = "url"
```
