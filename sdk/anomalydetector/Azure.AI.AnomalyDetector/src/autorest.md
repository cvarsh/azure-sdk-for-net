# Generated code configuration

Run `dotnet build /t:GenerateCode` to generate code.

``` yaml
tag: release_1_1_preview.1
require:
    -  https://github.com/Azure/azure-rest-api-specs/blob/091211ae139df31cdc858360f19743134487991a/specification/cognitiveservices/data-plane/AnomalyDetector/readme.md
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
