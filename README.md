<!-- PROJECT SHIELDS -->

[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]
[![MIT License][license-shield]][license-url]
[![LinkedIn][linkedin-shield]][linkedin-url]

[contributors-shield]: https://img.shields.io/github/contributors/vinaykarora/BlazorCleanArchitecture.svg?style=flat-square
[contributors-url]: https://github.com/vinaykarora/BlazorCleanArchitecture/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/vinaykarora/BlazorCleanArchitecture?style=flat-square
[forks-url]: https://github.com/vinaykarora/BlazorCleanArchitecture/network/members
[stars-shield]: https://img.shields.io/github/stars/vinaykarora/BlazorCleanArchitecture.svg?style=flat-square
[stars-url]: https://img.shields.io/github/stars/vinaykarora/BlazorCleanArchitecture?style=flat-square
[issues-shield]: https://img.shields.io/github/issues/vinaykarora/BlazorCleanArchitecture?style=flat-square
[issues-url]: https://github.com/vinaykarora/BlazorCleanArchitecture/issues
[license-shield]: https://img.shields.io/github/license/vinaykarora/BlazorCleanArchitecture?style=flat-square
[license-url]: https://github.com/vinaykarora/BlazorCleanArchitecture/blob/master/LICENSE
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=flat-square&logo=linkedin&colorB=555
[linkedin-url]: https://www.linkedin.com/in/vinaykarora/

<!-- PROJECT LOGO -->
<br />
<p align="center">
  <a href="https://github.com/vinaykarora/BlazorCleanArchitecture">
  </a>
  <h3 align="center">Blazor - Clean Architecture Template</h3>
  <p align="center">
    Open Sourced Solution Template For Blazor Web-Assembly 5.0 built with MudBlazor Components
    <br />
    <a href="https://vinayaroratech.com/blog/blazor-hero-quick-start-guide/"><strong>Read the Documentation »</strong></a>
    <br />
    <br />
    <a href="https://github.com/vinaykarora/BlazorCleanArchitecture/issues">Report Bug</a>
    ·
    <a href="https://github.com/vinaykarora/BlazorCleanArchitecture/issues">Request Feature</a>
    .
    <a href="https://github.com/vinaykarora/BlazorCleanArchitecture/issues">Request Documentation</a>
  </p>
</p>

## About The Project :zap:

This is a Clean Architecture Solution Template for Blazor Webassembly 5.0 built with MudBlazor Components.

### Tech Stack :muscle:

* Blazor WebAssembly 5.0 - ASP.NET Core Hosted Model
* ASP.NET Core 5
* [Entity Framework Core 5](https://docs.microsoft.com/en-us/ef/core/)
* [MediatR](https://github.com/jbogard/MediatR)
* [AutoMapper](https://automapper.org/)
* [FluentValidation](https://fluentvalidation.net/)
* [NUnit](https://nunit.org/), [FluentAssertions](https://fluentassertions.com/), [Moq](https://github.com/moq) & [Respawn](https://github.com/jbogard/Respawn)
* [Docker](https://www.docker.com/)

# Blazor v2.1

- minor bug fixes
- UI improvements
- validation messages fixed
- fluent validation support

# Getting Started 🦸

> **Important**
> If you are already using Blazor Hero v1.x, make sure that you drop your existing database and re-update your database using the CLI as there are couple of new migrations added that may clash with your existing schema. Also, install the latest version of Blazor.

The easiest way to get started with Blazor Hero is to install the [NuGet package](https://www.nuget.org/packages/VA.Blazor.CleanArchitecture/) and run `dotnet new VA.Blazor.CleanArchitecture`:

1. Install the latest [.NET 5 SDK](https://dotnet.microsoft.com/download/dotnet/5.0)
2. Install the latest DOTNET & EF CLI Tools by using this command `dotnet tool install --global dotnet-ef`
3. Install the latest version of Visual Studio IDE 2019 (v16.8 and above) 🚀
4. Open up Command Prompt and run `dotnet new --install VA.Blazor.CleanArchitecture` to install the project template
5. Create a folder for your solution and cd into it (the template will use it as project name)
6. Run `dotnet new VA.Blazor.CleanArchitecture` to create a new Solution with all the Awesomeness 🕶️ of Blazor 🦸

## Overview

### Domain

This will contain all entities, enums, exceptions, interfaces, types and logic specific to the domain layer.

### Application

This layer contains all application logic. It is dependent on the domain layer, but has no dependencies on any other layer or project. This layer defines interfaces that are implemented by outside layers. For example, if the application need to access a notification service, a new interface would be added to application and an implementation would be created within infrastructure.

### Infrastructure

This layer contains classes for accessing external resources such as file systems, web services, smtp, and so on. These classes should be based on interfaces defined within the application layer.

### WebUI

This layer is a single page application based on Angular 10 and ASP.NET Core 5. This layer depends on both the Application and Infrastructure layers, however, the dependency on Infrastructure is only to support dependency injection. Therefore only *Startup.cs* should reference Infrastructure.

## Support

If you are having problems, please let us know by [raising a new issue](https://github.com/vinaykarora/payment-processor/issues/new/choose).

## License

This project is licensed with the [MIT license](LICENSE).

## Contributing

Contributions are what make the open-source community such an amazing place to be learn, inspire, and create. Any contributions you make are **greatly appreciated**.

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## Contact

### Vinay Arora

- Blogs at [vinayaroratech.com](https://www.vinayaroratech.com)
- Facebook - [Vinay Arora](https://www.facebook.com/vinayaroratech/)
- Twitter - [Vinay Arora](https://twitter.com/vinaroar)
- Linkedin - [Vinay Arora](https://www.linkedin.com/in/vinuarora/)

<a href="https://www.buymeacoffee.com/vinayarora" target="_blank"></a>
