# ---- Build stage ----
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /MvcProducts

# Copy sln and csproj files
COPY *.sln ./
COPY MvcProducts/*.csproj ./MvcProducts/

# Restore NuGet packages
RUN dotnet restore

# Copy rest of the code
COPY . . 

# Publish the MVC app
RUN dotnet publish MvcProducts/MvcProducts.csproj -c Release -o /app/out

# ---- Runtime stage ----
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/out ./

ENV ASPNETCORE_URLS=http://+:10000
EXPOSE 10000

ENTRYPOINT ["dotnet", "MvcProducts.dll"]
