FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
EXPOSE 5129
ENV ASPNETCORE_URLS=http://+:5129;
COPY . .
WORKDIR /src
COPY ["MireaCore/MireaCore.csproj", "MireaCore/"]
RUN dotnet restore "MireaCore/MireaCore.csproj"
COPY . .
WORKDIR "/src/MireaCore/"
RUN dotnet publish "MireaCore.csproj" -c Release -o /app/publish /p:UseAppHost=false 
WORKDIR /app/publish
COPY . .
ENTRYPOINT ["dotnet", "MireaCore.dll"]
