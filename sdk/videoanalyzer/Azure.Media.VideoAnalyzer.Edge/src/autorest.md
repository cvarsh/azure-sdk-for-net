# Generated code configuration

Run `dotnet build /t:GenerateCode` to generate code.

```yaml
directive:
- from: swagger-document
  where: $.definitions.*
  transform: >
    $["x-csharp-usage"] = "model,input,output";
    $["x-csharp-formats"] = "json";

require: https://github.com/Azure/azure-rest-api-specs/blob/4c6dd07c6fd7648cdab45db99663b0f77f695ee7/specification/videoanalyzer/data-plane/readme.md
generation1-convenience-client: true
payload-flattening-threshold: 2
license-header: MICROSOFT_MIT_NO_VERSION
clear-output-folder: true
use-internal-constructors: true
use-datetimeoffset: true
```

