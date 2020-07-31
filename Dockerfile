FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build

WORKDIR /app

WORKDIR /src
# copy csproj and restore as distinct layers
COPY *.sln ./
COPY MyMath/*.csproj ./MyMath/
COPY MyMathTests/*.csproj ./MyMathTests/
COPY MyMath.API/*.csproj ./MyMath.API/

RUN dotnet restore

COPY . .

WORKDIR /src/MyMath
RUN dotnet build -c Release -o /app

WORKDIR /src/MyMath.API
RUN dotnet build -c Release -o /app

FROM build AS publish
RUN dotnet publish -c Release -o /app

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS runtime
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "MyMath.API.dll"]