This is my own blog website source code built with ASP.NET Core. Not a perfect blogging engine but a fair number of .NET Core services have been used to make it work.

## Source Code
Following are some characteristics of this source code.

- Built with ASP.NET Core 1.0.* LTS and VS 2017
- Blog posts are categorized according their nature via MVC controllers
- Every blog post has a different MVC view
- Uses Google Captcha V2 and MailKit for *Contact Me* page.
- Uses *Angular*, *jQuery*, *Animate.css*, *Bootstrap*, and *Font-Awesome* frameworks
- To configure your own Google V2 Captcha: Go to the `MailService.cs` in the `Services` folder and in the `VerifyAsync()` method, add your V2 Captcha private key that you got from your Google account.
- Uses Disqus Blog Site using ASP.NET Core ViewComponents in the `ViewComponents` folder.
- Uses Bundler & Minifier for CSS\JS builds.

## Docker Image
I usually deploy the application with a Docker Image. I built with `Dockerfile` for project located in the directory:

*Publish => netcoreapp1.0 => publish*

The Docker image exposes port 80 by default. You don't have explicitly expose the port from the container with `EXPOSE` command in the Dockerfile. 

If you want to deploy your own fork, make modifications, test and run `dotnet publish`, then in the publish directory run `docker build -t <image-name> .` to build the Docker image.

A live example of the project is running currently [here](http://www.kjanshair.com/).

## How to run the project ?

If you are using Visual Studio, simply open the solution at the root and run the project.

If you want to run the project via `dotnet` CLI, then at the project's root directory:

- Install Bower packages by running `bower install` command.
- Restore CoreFx packages by running `dotnet restore` command.
- Run `dotnet run` command to build and run the project and browse `localhost:5000` to see the project up and running.