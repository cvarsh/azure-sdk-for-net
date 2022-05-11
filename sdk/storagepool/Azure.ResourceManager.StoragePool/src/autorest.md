# Generated code configuration

Run `dotnet build /t:GenerateCode` to generate code.

``` yaml

azure-arm: true
csharp: true
library-name: StoragePool
namespace: Azure.ResourceManager.StoragePool
require: https://github.com/Azure/azure-rest-api-specs/blob/e1f482ee1873ca7c545c7ddf0fd7a7beeb4a597c/specification/storagepool/resource-manager/readme.md
tag: package-2021-08-01
output-folder: Generated/
clear-output-folder: true
modelerfour:
  flatten-payloads: false
rename-rules:
  CPU: Cpu
  CPUs: Cpus
  Os: OS
  Ip: IP
  Ips: IPs
  ID: Id
  IDs: Ids
  VM: Vm
  VMs: Vms
  Vmos: VmOS
  VMScaleSet: VmScaleSet
  DNS: Dns
  VPN: Vpn
  NAT: Nat
  WAN: Wan
  Ipv4: IPv4
  Ipv6: IPv6
  Ipsec: IPsec
  SSO: Sso
  URI: Uri
directive:
  - rename-model:
      from: Configuration
      to: ProductConfiguration
  - from: swagger-document
    where: "$.definitions.DiskPool.properties.sku"
    transform: >
      $["x-ms-client-flatten"] = false;
```
