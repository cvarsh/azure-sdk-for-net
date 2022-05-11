# Generated code configuration

Run `dotnet build /t:GenerateCode` to generate code.

``` yaml

azure-arm: true
csharp: true
library-name: IotCentral
namespace: Azure.ResourceManager.IotCentral
require: https://github.com/Azure/azure-rest-api-specs/blob/e1f482ee1873ca7c545c7ddf0fd7a7beeb4a597c/specification/iotcentral/resource-manager/readme.md
output-folder: Generated/
clear-output-folder: true
skip-csproj: true
 

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
      from: App
      to: IotCentralApp
```
