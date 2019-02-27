FROM microsoft/dotnet:2.2-sdk

WORKDIR /app
COPY *.csproj .
RUN dotnet restore

COPY . .

RUN dotnet publish -c Release -o out

ENV PORT 8080
EXPOSE $PORT

CMD ["dotnet", "out/twilio-csharp.dll"]
