# DataAnalysis - Dynamically compile and run code using .NET Core 3.0

# Javascript Side

`npm install`

`npm install jquery`
`npm install chart.js`
`npm install jsgrid`

[Vue tutorial](https://www.tutorialspoint.com/vuejs/vuejs_routing.htm)
[Vue SPA tutorial](https://www.adcisolutions.com/knowledge/how-build-single-page-application-spa-vuejs?utm_source=adci-website&utm_campaign=improve-your-vuejs&utm_content=improve-your-vuejs-link-spa-vuejs) 
[Vue SPA Github](https://github.com/DChuchin/vue-spa-tutorial/tree/step-5)

# C# Side

[Net Core 3](https://docs.microsoft.com/it-it/dotnet/core/whats-new/dotnet-core-3-0)  
[Net Core 3 StringClass realtime compiler](https://laurentkempe.com/2019/02/18/dynamically-compile-and-run-code-using-dotNET-Core-3.0/)

[Scriban](https://github.com/lunet-io/scriban)  
[Scriban render json](https://stackoverflow.com/questions/60389949/render-scriban-template-from-json-data)

[NLog](https://nlog-project.org/)  
[NLog Setup](https://github.com/NLog/NLog/wiki/Getting-started-with-ASP.NET-Core-3)  
[NLog Config](https://nlog-project.org/config/)
[NLog with class library](https://stackoverflow.com/questions/52953158/how-to-log-nlog-calls-from-a-class-library-in-my-asp-net-core-mvc-app)

In un futuro lontano magari per fare i fighi metteremo sentry ad ora non è banale  
[NLog with Sentry](https://github.com/getsentry/sentry-dotnet)  
[NLog with Sentry](https://github.com/getsentry/sentry-dotnet/tree/main/samples/Sentry.Samples.NLog)  
[NLog with Sentry](https://docs.sentry.io/platforms/dotnet/guides/aspnetcore/)

[DI NetCore](https://www.tutorialsteacher.com/core/dependency-injection-in-aspnet-core)  
[DI Built-in container](https://www.tutorialsteacher.com/core/internals-of-builtin-ioc-container-in-aspnet-core)  
Il container di netCore fa cagare ma dobbiamo tenerlo finchè non si capisce come sostituirlo con AutoFAC

[DI NetCore for logging in external library (console)](https://xfischer.github.io/logging-dotnet-core/)  
[DI NetCore for logging in external library (console)](https://github.com/xfischer/CoreLoggingTests)  
[DI NetCore for logging in external library (ASP)](https://www.iaspnetcore.com/blog/5a5f97570b5daa1f58fa62bc/how-to-logging-in-class-libraries-with-aspnet-core)  
L'ultimo link è quello fondamentale per impostare il log per le dll esterne.  
Baraccone tirato su per non passare esplicitamente il logger alla libreria esterna ma attraverso la DI.

[JWT Auth](https://jasonwatmore.com/post/2019/10/11/aspnet-core-3-jwt-authentication-tutorial-with-example-api#app-settings-cs)

# Utilities

[Code Maid](https://marketplace.visualstudio.com/items?itemName=SteveCadwallader.CodeMaid)

# Notes

Per far girare correttamente i test impostare RealtimeCompiler\Sources\DynamicProgram.cs come Properties > Build Action - Embedded Resource / Copy always
