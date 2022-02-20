


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
## About The Project

<img width="100%" src="https://user-images.githubusercontent.com/61355143/154838306-2d636074-bce8-4ec0-af82-b5be84ab9456.jpg">
<img width="100%" src="https://user-images.githubusercontent.com/61355143/154835967-c598eb19-5189-4a7e-92bd-2052383d9ae9.gif">
<img width="100%" src="https://user-images.githubusercontent.com/61355143/154835677-d3a1204c-4a72-46f6-b2a2-ef383a9cc7de.gif">



Here's why:
Blazor is an exciting new part of .NET Core (.NET 5) designed for building rich web user interfaces in C#. This course will help developers transition from building basic sample apps to implementing more real world concepts, design patterns, and features.

* You should implement DRY principles to the rest of your life :smile:

For years JavaScript frameworks have dominated the front end/client side development! But things are about to change with Blazor!

- How do you scale an existing application? 
- How do you architect a mid-large scale project?
- How to correctly process payments?
- Add changes to reflect the changes made
- How to efficiently understand Blazor and use it in real world projects?

help developers transition from building basic sample apps to implementing more real world concepts, design patterns, and features.



### Built With

This section should list any major frameworks/libraries used to bootstrap your project. Leave any add-ons/plugins for the acknowledgements section. Here are a few examples.

* [Blazor](https://dotnet.microsoft.com/en-us/apps/aspnet/web-apps/blazor)
* [Asp.Net Core API](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-6.0&tabs=visual-studio)
* [MSSql](https://www.microsoft.com/en-us/sql-server/sql-server-2019)
* [MVC](https://docs.microsoft.com/en-us/aspnet/core/mvc/overview?view=aspnetcore-6.0)

### Technologies and Methods

- Real world application using Blazor Web Assembly
- Manage admin features using Blazor Server
- Build .NET 5 API from scratch
- Consume .NET 5 API using Blazor WASM
- Authentication & Authorization in Blazor Server and WASM
- Integrate Stripe Payments in Blazor WASM
- Repository Pattern and Dependency Injection
- Deploying .NET API, Blazor WASM & Server to Azure

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
  
* dotnet Villagenix.Client.csproj
  ```sh
  <PackageReference Include="Blazored.LocalStorage" Version="3.0.0" />
  <PackageReference Include="Microsoft.AspNetCore.Components.Authorization" Version="5.0.14" />
  <PackageReference Include="Microsoft.AspNetCore.Components.WebAssembly" Version="5.0.0" />
  <PackageReference Include="Microsoft.AspNetCore.Components.WebAssembly.DevServer" Version="5.0.0" />
  <PackageReference Include="Newtonsoft.Json" Version="13.0.1" />
  <PackageReference Include="System.Net.Http.Json" Version="5.0.0" />
  ```
  
* dotnet Villagenix.Server.csproj
  ```sh
  <PackageReference Include="AutoMapper" Version="10.1.1" />
  <PackageReference Include="AutoMapper.Extensions.Microsoft.DependencyInjection" Version="8.1.0" />
  <PackageReference Include="Blazored.TextEditor" Version="1.0.3" />
  <PackageReference Include="Microsoft.AspNetCore.Identity" Version="2.2.0" />
  <PackageReference Include="Microsoft.AspNetCore.Identity.EntityFrameworkCore" Version="6.0.2" />
  <PackageReference Include="Microsoft.AspNetCore.Identity.UI" Version="6.0.2" />
  <PackageReference Include="Microsoft.EntityFrameworkCore" Version="6.0.2" />
  <PackageReference Include="Microsoft.EntityFrameworkCore.Design" Version="6.0.2">
  <PrivateAssets>all</PrivateAssets>
  <IncludeAssets>runtime; build; native; contentfiles; analyzers; buildtransitive</IncludeAssets>
  </PackageReference>
  <PackageReference Include="Microsoft.EntityFrameworkCore.SqlServer" Version="6.0.2" />
  <PackageReference Include="Microsoft.EntityFrameworkCore.Tools" Version="6.0.2">
  <PrivateAssets>all</PrivateAssets>
  <IncludeAssets>runtime; build; native; contentfiles; analyzers; buildtransitive</IncludeAssets>
  </PackageReference>
  <PackageReference Include="Microsoft.VisualStudio.Web.CodeGeneration.Design" Version="6.0.2" />
  ```


### Installation

_Below is an example of how you can instruct your audience on installing and setting up your app. This template doesn't rely on any external dependencies or services._


1. Clone the repo
   ```sh
   https://github.com/BerkayKulak/Blazor-Villagenix.git
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

To clone and run this application, you'll need [Git](https://git-scm.com) and [Node.js](https://nodejs.org/en/download/) (which comes with [npm](http://npmjs.com)) installed on your computer. From your command line:

```bash
# Go into the repository API
$ cd \Villagenix\Villagenix.API

# Run the app
$ dotnet run
$ dotnet run --project ./projects/proj1/proj1.csproj

# Go into the repository Server
$ cd \Villagenix\Villagenix.Server

# Run the app
$ dotnet run
$ dotnet run --project ./projects/proj1/proj1.csproj

# Go into the repository Client
$ cd \Villagenix\Villagenix.Client

# Run the app
$ dotnet run
$ dotnet run --project ./projects/proj1/proj1.csproj
```

<p align="right">(<a href="#top">back to top</a>)</p>



<!-- ROADMAP -->
## Bug / Feature Request

If you find a bug (the website couldn't handle the query and / or gave undesired results), kindly open an issue [here](https://github.com/BerkayKulak/Blazor-Villagenix/issues/new) by including your search query and the expected result.

If you'd like to request a new function, feel free to do so by opening an issue [here](https://github.com/BerkayKulak/Blazor-Villagenix/issues/new). Please include sample queries and their corresponding results.

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

Project Link:   (https://github.com/BerkayKulak/Blazor-Villagenix)

<p align="right">(<a href="#top">back to top</a>)</p>





