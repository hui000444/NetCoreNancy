FROM microsoft/dotnet:latest
# RUN dotnet restore

# COPY src/BankAPI/bin/Debug/netcoreapp1.0/publish/ /root/
# EXPOSE 5000/tcp
# ENTRYPOINT dotnet /root/testapp.dll

WORKDIR /dotnetapp

# copy project.json and restore as distinct layers
# COPY global.json .

# copy and build everything else
COPY . .

# RUN cd src/BankAPI
RUN dotnet restore
# COPY src/BankAPI/bin/Debug/netcoreapp1.0/publish/ /root/
# EXPOSE 5000/tcp
# ENTRYPOINT dotnet /root/testapp.dll

EXPOSE 5000/tcp
ENV ASPNETCORE_URLS http://*:5000

ENTRYPOINT ["dotnet", "run"]