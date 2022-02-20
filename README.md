


<!-- TABLE OF CONTENTS -->
<details>
  <summary>Table of Contents</summary>
  <ol>
    <li>
      <a href="#about-the-project">About The Project</a>
      <ul>
        <li><a href="#built-with">Built With</a></li>
      </ul>
    </li>
    <li>
      <a href="#getting-started">Getting Started</a>
      <ul>
        <li><a href="#prerequisites">Prerequisites</a></li>
        <li><a href="#installation">Installation</a></li>
      </ul>
    </li>
    <li><a href="#usage">Usage</a></li>
    <li><a href="#roadmap">Roadmap</a></li>
    <li><a href="#contributing">Contributing</a></li>
    <li><a href="#license">License</a></li>
    <li><a href="#contact">Contact</a></li>
    <li><a href="#acknowledgments">Acknowledgments</a></li>
  </ol>
</details>



<!-- ABOUT THE PROJECT -->
## Architecture
<img width="100%" src="https://user-images.githubusercontent.com/61355143/154838306-2d636074-bce8-4ec0-af82-b5be84ab9456.jpg">

## Process
<img width="100%" src="https://user-images.githubusercontent.com/61355143/154838413-7dda1514-0f16-4122-83da-dd18fedb41ff.gif">


Here's why:
Each of these layers should be Single Responsibility to avoid tight coupling and to support Separation of Concern. (Note that tiers and layers are used interchangeably but there is slight difference. Layer is known to be logical separation, where tier is actually physical separation. This is where some layers could be hosted in different physical locations due to independence of layers.)

## DATA ACCESS / REPOSITORY LAYER
This layer handles database interaction of the application, and only location where database related queries are done. Here queries might vary according to underlying database, but these inner queries are not exposed. Functions related to CRUD are exposed publicly from this layer, where application can execute these methods. Then data access layer would connect to database, execute required query and return results to other layers, and thereby keeping other layers abstract from database integration. Typically data access layer is added as repositories.

<img height= "400px" width="100%" src="https://user-images.githubusercontent.com/61355143/154839109-2f1c9324-e2c2-4658-9b27-29757383bb8a.png">

## CORE LAYER
Development of Domain Logic with abstraction. Interfaces drives business requirements with light implementation. The Core project is the center of the Clean Architecture design, and all other project dependencies should point toward it.

<img height= "400px" width="100%" src="https://user-images.githubusercontent.com/61355143/154839267-54a6982c-cc5b-4c0a-88f5-49f1c722f70c.png">


## BUSINESS / SERVICE LOGIC LAYER
This layer should handle all domain specific logic of the application, thereby complete logic is in a central location to be managed easily. Data access layer’s atomic CRUD methods can be used to make meaningful business scenarios, and these business logic layer is typically added as services.

<img height= "400px" width="100%" src="https://user-images.githubusercontent.com/61355143/154839144-1774ceeb-7040-4027-af08-42b15d5a5a02.png">

## API LAYER
An API layer(software library) is nothing more than an aggregated proxy of all of your service offerings. Graphic user interfaces provides user interaction, and behind it API handles actions in abstraction mode. For example, your Email client. Soon after writing draft, the moment when you are about to send; APIs will have an information about this SEND request from you and will do abstract operations such as validation sender mail id, attachment etc,.
In other layman words, API layer is a bridge between your client and application. Bridge which carries data from/to application/client. With this mechanism, will have consistent security along with data transfer.

<img height= "500px" width="100%" src="https://user-images.githubusercontent.com/61355143/154839741-17a152e5-7323-41a2-8c93-b83f72cb8093.png">

## PRESENTATION / UI LAYER
This layer is entry point for external interaction with the application. As an example it could either be REST endpoints if its ASP.NET Web API or HTML pages if its ASP.NET MVC application. Here it is expected to be without any business logic, but rather directly forward the request to business logic layer. Some simple operations such as request validation can be done here. Typically presentation layer is added as controllers.

<img height= "500px" width="100%" src="https://user-images.githubusercontent.com/61355143/154839186-d8045bda-1f05-41d3-b52a-bafd0027e9c6.png">

## You will be able to get answers to the following questions

- How to build an application with N-layer architecture ?
- How is the Core layer built?
- How is the Data layer built?
- How is the Service layer built?
- How is Generic Repository implemented in multi-layer architecture?
- What is AutoFac? how is it used ? How is it implemented in the project?
- What is FluentValidation? how is it used ? How is it implemented in the project?
- How is UnitOfWork implemented in a multi-layer architecture?
- How are migration operations performed?
- How is error management handled globally?
- How to avoid code repeats in Action Methods?
- How is the AutoMapper library used in multi-layer architecture?
- How to use Entity Framework with Multilayer Architecture?
- How is global error management handled?
- How do we return a single response model in our API applications? what are the benefits ?


### Built With

This section should list any major frameworks/libraries used to bootstrap your project. Leave any add-ons/plugins for the acknowledgements section. Here are a few examples.

* [Asp.Net Core API](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-6.0&tabs=visual-studio)
* [MSSql](https://www.microsoft.com/en-us/sql-server/sql-server-2019)
* [MVC](https://docs.microsoft.com/en-us/aspnet/core/mvc/overview?view=aspnetcore-6.0)

### Technologies and Methods

- N-layer architecture
- Manage admin features using Blazor Server
- Generic Repository
- AutoFac 
- FluentValidation 
- UnitOfWork 
- Migration
- Global Error Management
- Action Methods
- AutoMapper
- Entity Framework Core 6.0
- Dependency Injection
- In Memory Caching


<p align="right">(<a href="#top">back to top</a>)</p>



<!-- GETTING STARTED -->
## Getting Started

This is an example of how you may give instructions on setting up your project locally.
To get a local copy up and running follow these simple example steps.

### Prerequisites

This is an example of how to list things you need to use the software and how to install them.
* dotnet Villagenix.API.csproj
  ```sh
  <PackageReference Include="AutoMapper" Version="10.1.1" />
  <PackageReference Include="AutoMapper.Extensions.Microsoft.DependencyInjection" Version="8.1.0" />
  <PackageReference Include="Mailjet.Api" Version="1.2.3" />
  <PackageReference Include="Microsoft.AspNetCore.Authentication.JwtBearer" Version="6.0.2" />
  <PackageReference Include="Microsoft.AspNetCore.Identity.UI" Version="5.0.0" />
  <PackageReference Include="Microsoft.AspNetCore.Mvc.NewtonsoftJson" Version="6.0.2" />
  <PackageReference Include="Microsoft.EntityFrameworkCore.Design" Version="6.0.2">
  ```
  
* dotnet NLayerArchitecture.Repository.csproj
  ```sh
  <PackageReference Include="Microsoft.EntityFrameworkCore" Version="6.0.2" />
  <PackageReference Include="Microsoft.EntityFrameworkCore.SqlServer" Version="6.0.2" />
  <PackageReference Include="Microsoft.EntityFrameworkCore.Tools" Version="6.0.2">
  <PrivateAssets>all</PrivateAssets>
  <IncludeAssets>runtime; build; native; contentfiles; analyzers; buildtransitive</IncludeAssets>
  </PackageReference>
  ```
  
* dotnet NLayerArchitecture.Core.csproj
  ```sh
  <TargetFramework>net6.0</TargetFramework>
  <ImplicitUsings>enable</ImplicitUsings>
  <Nullable>disable</Nullable>
  ```
* dotnet NLayerArchitecture.Service.csproj
  ```sh
  <PackageReference Include="AutoMapper.Extensions.Microsoft.DependencyInjection" Version="11.0.0" />
  <PackageReference Include="FluentValidation.AspNetCore" Version="10.3.6" />
  <Nullable>disable</Nullable>
  ```
  
* dotnet NLayerArchitecture.Service.csproj
  ```sh
   <PackageReference Include="Autofac.Extensions.DependencyInjection" Version="7.2.0" />
   <PackageReference Include="FluentValidation.AspNetCore" Version="10.3.6" />
   <PackageReference Include="Microsoft.VisualStudio.Web.CodeGeneration.Design" Version="6.0.2" />
  ```
  
* dotnet NLayerArhitecture.Caching.csproj
  ```sh
   <TargetFramework>net6.0</TargetFramework>
   <ImplicitUsings>enable</ImplicitUsings>
   <Nullable>disable</Nullable>
  ```

### Installation

_Below is an example of how you can instruct your audience on installing and setting up your app. This template doesn't rely on any external dependencies or services._


1. Clone the repo
   ```sh
   https://github.com/BerkayKulak/NLayerArchitecture.git
   ```
2. Update Nuget packages
   ```sh
   dotnet tool update <PACKAGE_ID> -g|--global
   ```
3. Add Migration
   ```js
   dotnet ef migrations add InitialCreate
   ```
4. Update Database
   ```js
   dotnet ef database update
   ```

<p align="right">(<a href="#top">back to top</a>)</p>



<!-- USAGE EXAMPLES -->
## Usage


```bash
# Go into the repository API
$ cd \NLayerArchitecture\NLayerArchitecture.API

# Run the app
$ dotnet run
$ dotnet run --project ./projects/proj1/proj1.csproj

```

<p align="right">(<a href="#top">back to top</a>)</p>


## appsettings.json
```
{
  "ConnectionStrings": {
    "SqlConnection": "Data Source=[<LOCAL DB>];Initial Catalog=[<YOUR DB NAME>][;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
  },
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*"
}

```

## launchSettings.json
```
{
  "$schema": "https://json.schemastore.org/launchsettings.json",
  "iisSettings": {
    "windowsAuthentication": false,
    "anonymousAuthentication": true,
    "iisExpress": {
      "applicationUrl": "http://localhost:15112",
      "sslPort": 44321
    }
  },
  "profiles": {
    "NLayerArchitecture.API": {
      "commandName": "Project",
      "dotnetRunMessages": true,
      "launchBrowser": true,
      "launchUrl": "swagger",
      "applicationUrl": "https://localhost:7065;http://localhost:5065",
      "environmentVariables": {
        "ASPNETCORE_ENVIRONMENT": "Development"
      }
    },
    "IIS Express": {
      "commandName": "IISExpress",
      "launchBrowser": true,
      "launchUrl": "swagger",
      "environmentVariables": {
        "ASPNETCORE_ENVIRONMENT": "Development"
      }
    }
  }
}


```


<!-- ROADMAP -->
## Bug / Feature Request

If you find a bug (the website couldn't handle the query and / or gave undesired results), kindly open an issue [here](https://github.com/BerkayKulak/NLayerArchitecture/issues/new) by including your search query and the expected result.

If you'd like to request a new function, feel free to do so by opening an issue [here](https://github.com/BerkayKulak/NLayerArchitecture/issues/new). Please include sample queries and their corresponding results.

<p align="right">(<a href="#top">back to top</a>)</p>



<!-- CONTRIBUTING -->
## Contributing

Contributions are what make the open source community such an amazing place to learn, inspire, and create. Any contributions you make are **greatly appreciated**.

If you have a suggestion that would make this better, please fork the repo and create a pull request. You can also simply open an issue with the tag "enhancement".
Don't forget to give the project a star! Thanks again!

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

<p align="right">(<a href="#top">back to top</a>)</p>



<!-- LICENSE -->
## License

Distributed under the MIT License. See `LICENSE.txt` for more information.

<p align="right">(<a href="#top">back to top</a>)</p>



<!-- CONTACT -->
## Contact

Berkay Kulak - (https://www.linkedin.com/in/berkay-kulak-3442311b1/) - kulakberkay15@gmail.com

Project Link:   (https://github.com/BerkayKulak/NLayerArchitecture)

<p align="right">(<a href="#top">back to top</a>)</p>





