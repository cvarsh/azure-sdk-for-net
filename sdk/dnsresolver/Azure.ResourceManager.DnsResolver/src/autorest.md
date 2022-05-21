# Generated code configuration

Run `dotnet build /t:GenerateCode` to generate code.

``` yaml

azure-arm: true
require: https://github.com/Azure/azure-rest-api-specs/blob/94ba9b2435d6549385bf5daa59e1cada9671efbb/specification/dnsresolver/resource-manager/readme.md
library-name: dnsresolver
namespace: Azure.ResourceManager.DnsResolver
clear-output-folder: true
skip-csproj: true
output-folder: Generated/

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
