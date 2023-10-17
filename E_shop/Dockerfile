FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY "E_shop.csproj" .
RUN dotnet restore "E_shop.csproj"
COPY . .
RUN dotnet build . -c Release -o /app/build

RUN apt-get install curl

FROM build AS publish
RUN dotnet publish "E_shop.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

ENV ConnectionStrings__ProductsContext Server=eshop-mssql-service
ENV ConnectionStrings__ProductsContext Database=AuthDB
ENV ConnectionStrings__ProductsContext User=sa
ENV ConnectionStrings__ProductsContext Password=Sushant@123; 

ENV ASPNETCORE_ENVIRONMENT Development
ENTRYPOINT ["dotnet", "E_shop.dll"]

