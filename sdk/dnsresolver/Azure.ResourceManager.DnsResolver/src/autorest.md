# Generated code configuration

Run `dotnet build /t:GenerateCode` to generate code.

``` yaml

azure-arm: true
require: https://github.com/Azure/azure-rest-api-specs/blob/9c07017e27a27ac282cb6ad189ba5b6010dabc82/specification/dnsresolver/resource-manager/readme.md
library-name: dnsresolver
namespace: Azure.ResourceManager.DnsResolver
output-folder: $(this-folder)/Generated
clear-output-folder: true
skip-csproj: true
modelerfour:
  flatten-payloads: false

format-by-name-rules:
  'tenantId': 'uuid'
  'etag': 'etag'
  'location': 'azure-location'
  '*Uri': 'Uri'
  '*Uris': 'Uri'

rename-rules:
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
