# Generated code configuration

Run `dotnet msbuild /t:GenerateCode` to generate code.

``` yaml

azure-arm: true
title: communication
namespace: Azure.ResourceManager.Communication
require: https://github.com/Azure/azure-rest-api-specs/blob/cd3bae20cb3d8b2125e98dffc46f24c5eaba729a/specification/communication/resource-manager/readme.md
tag: package-2021-10-01-preview
output-folder: $(this-folder)/Generated
clear-output-folder: true
skip-csproj: true
modelerfour:
  flatten-payloads: false

override-operation-name:
  CommunicationServices_CheckNameAvailability: CheckCommunicationNameAvailability

format-by-name-rules:
  'tenantId': 'uuid'
  'etag': 'etag'
  'location': 'azure-location'
  '*Uri': 'Uri'
  '*Uris': 'Uri'

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
  SPF: Spf

directive:
  - rename-model:
      from: DomainResource
      to: CommunicationDomainResource
  - rename-model:
      from: VerificationParameter
      to: VerificationContent
  - from: types.json
    where: $.definitions
    transform: >
      $.CheckNameAvailabilityRequest["x-ms-client-name"] = "CheckNameAvailabilityRequestBody";
      $.CheckNameAvailabilityResponse["x-ms-client-name"] = "CommunicationServiceNameAvailabilityResult";
  - from: CommunicationServices.json
    where: $.definitions
    transform: >
      $.NameAvailabilityParameters["x-ms-client-name"] = "CommunicationServiceNameAvailabilityContent"; 
      $.TaggedResource["x-ms-client-name"] = "AcceptTags";          
```
