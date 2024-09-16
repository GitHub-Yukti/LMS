FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /src
COPY ["src/LMS.Web.Host/LMS.Web.Host.csproj", "src/LMS.Web.Host/"]
COPY ["src/LMS.Web.Core/LMS.Web.Core.csproj", "src/LMS.Web.Core/"]
COPY ["src/LMS.Application/LMS.Application.csproj", "src/LMS.Application/"]
COPY ["src/LMS.Core/LMS.Core.csproj", "src/LMS.Core/"]
COPY ["src/LMS.EntityFrameworkCore/LMS.EntityFrameworkCore.csproj", "src/LMS.EntityFrameworkCore/"]
WORKDIR "/src/src/LMS.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/LMS.Web.Host", "src/LMS.Web.Host"]
COPY ["src/LMS.Web.Core", "src/LMS.Web.Core"]
COPY ["src/LMS.Application", "src/LMS.Application"]
COPY ["src/LMS.Core", "src/LMS.Core"]
COPY ["src/LMS.EntityFrameworkCore", "src/LMS.EntityFrameworkCore"]
WORKDIR "/src/src/LMS.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:8.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "LMS.Web.Host.dll"]
