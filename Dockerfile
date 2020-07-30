FROM mcr.microsoft.com/dotnet/core/sdk:2.1 AS build
WORKDIR /app

# copy csproj and restore as distinct layers
COPY *.sln .
COPY MyMath/*.* ./MyMath/
COPY MyMathTests/*.* ./MyMathTests/
COPY MyMath.API/*.* ./MyMath.API/
RUN dotnet restore

# copy everything else and build app
RUN dotnet publish -c Release -o publish

FROM mcr.microsoft.com/dotnet/core/aspnet:2.1 AS runtime
WORKDIR /app
COPY --from=build /app/publish ./
ENTRYPOINT ["dotnet", "MyMath.API.dll"]