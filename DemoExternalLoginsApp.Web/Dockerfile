FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 49969
EXPOSE 44355

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY DemoExternalLoginsApp.Web/DemoExternalLoginsApp.Web.csproj DemoExternalLoginsApp.Web/
RUN dotnet restore DemoExternalLoginsApp.Web/DemoExternalLoginsApp.Web.csproj
COPY . .
WORKDIR /src/DemoExternalLoginsApp.Web
RUN dotnet build DemoExternalLoginsApp.Web.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish DemoExternalLoginsApp.Web.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "DemoExternalLoginsApp.Web.dll"]
