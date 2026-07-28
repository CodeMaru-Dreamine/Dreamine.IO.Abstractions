# Dreamine.IO.Abstractions

[![CI](https://github.com/CodeMaru-Dreamine/Dreamine.IO.Abstractions/actions/workflows/ci.yml/badge.svg?branch=main)](https://github.com/CodeMaru-Dreamine/Dreamine.IO.Abstractions/actions/workflows/ci.yml?query=branch%3Amain) [![Quality Gate](https://sonarcloud.io/api/project_badges/measure?project=CodeMaru-Dreamine_Dreamine.IO.Abstractions&metric=alert_status&branch=main)](https://sonarcloud.io/summary/new_code?id=CodeMaru-Dreamine_Dreamine.IO.Abstractions&branch=main) [![Security Rating](https://sonarcloud.io/api/project_badges/measure?project=CodeMaru-Dreamine_Dreamine.IO.Abstractions&metric=security_rating&branch=main)](https://sonarcloud.io/summary/new_code?id=CodeMaru-Dreamine_Dreamine.IO.Abstractions&branch=main) [![Coverage](https://sonarcloud.io/api/project_badges/measure?project=CodeMaru-Dreamine_Dreamine.IO.Abstractions&metric=coverage&branch=main)](https://sonarcloud.io/summary/new_code?id=CodeMaru-Dreamine_Dreamine.IO.Abstractions&branch=main)<br>
[![License: MIT](https://img.shields.io/badge/license-MIT-blue.svg)](./LICENSE) ![.NET](https://img.shields.io/badge/.NET-8-512BD4.svg?logo=dotnet&logoColor=white) [![NuGet](https://img.shields.io/nuget/v/Dreamine.IO.Abstractions.svg)](https://www.nuget.org/packages/Dreamine.IO.Abstractions) [![NuGet Downloads](https://img.shields.io/nuget/dt/Dreamine.IO.Abstractions.svg)](https://www.nuget.org/packages/Dreamine.IO.Abstractions)<br>
[![Docs](https://img.shields.io/badge/%F0%9F%93%96%20Docs-dreamine.kr-49B2FF.svg)](https://dreamine.kr/libraries?lang=en) [![Guide](https://img.shields.io/badge/%F0%9F%93%98%20Guide-dreamine.kr-49B2FF.svg)](https://dreamine.kr/guide?lang=en) [![Playground](https://img.shields.io/badge/%F0%9F%8E%AE%20Playground-dreamine.kr-49B2FF.svg)](https://dreamine.kr/playground?lang=en) [![Book](https://img.shields.io/badge/%F0%9F%93%96%20Book-Practical%20MVVM%20Architecture-000000.svg)](https://bookk.co.kr/bookStore/69c0f1b41461ec1ae849a0f6)

[Korean documentation](./README_KO.md)

Vendor-neutral industrial I/O contracts for the Dreamine IO package family.

This package defines common interfaces and models for digital input, digital output, analog input, and analog output workflows. It intentionally does not reference Ajin, Comizoa, Fastech, or any other vendor runtime DLL.

## Purpose

`Dreamine.IO.Abstractions` is the lowest-level contract layer for I/O integrations. Applications, samples, simulators, and concrete adapters can share these contracts without pulling vendor-licensed binaries into the MIT package.

```text
Application / Sample
        ↓
Dreamine.IO.Abstractions
        ↑
Vendor Adapters / Simulators
```

## Included Contracts

- I/O controller abstraction
- Digital input and output channel abstractions
- Multi-point digital input and output read contracts
- Analog input and output channel abstractions
- Common I/O connection state
- Digital and analog point models
- Common I/O result models
- Provider-neutral connection options

## Current Notes

- Digital inputs support single-point and multi-point reads.
- Digital outputs support single-point reads, multi-point reads, single-point writes, and multi-point writes.
- Point numbering is zero-based. For example, channel `0` is `DI00` or `DO00`.
- Contact type handling such as A-contact/B-contact, debounce, on-delay, and off-delay is not implemented yet. These should be added as vendor-neutral conditioning wrappers above the raw I/O channel contracts.

## Design Rules

- Keep this package vendor-neutral.
- Do not reference Ajin AXT, Comizoa, Fastech, or other vendor runtime assemblies.
- Do not copy vendor SDK source files or binaries into this package.
- Put concrete vendor adapters in separate packages such as `Dreamine.IO.Ajin`, `Dreamine.IO.Comizoa`, or `Dreamine.IO.Fastech`.
- Require users to install vendor software and hold the proper vendor license for runtime adapters.

## Vendor Runtime Policy

This package does not include vendor runtime DLLs. The `IoProvider` enum identifies provider families only; it does not imply that any vendor runtime is redistributed by Dreamine.

## License

MIT License.
