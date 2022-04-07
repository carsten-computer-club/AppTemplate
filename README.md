# Jais App Template

Templates to use when creating an application for the JAIS system.

# Installation

## Add GitHub registry

Add the GitHub package registry to your NuGet config.

`~/.nuget/NuGet/NuGet.Config`

```xml
<?xml version="1.0" encoding="utf-8"?>
<configuration>
  <packageSources>
    <add key="nuget.org" value="https://api.nuget.org/v3/index.json" protocolVersion="3" />
    <add key="github" value="https://nuget.pkg.github.com/carsten-computer-club/index.json" />
  </packageSources>

  <packageSourceCredentials>
      <github>
        <add key="Username" value="USERNAME" />
        <add key="ClearTextPassword" value="PAT_TOKEN" />
      </github>
    </packageSourceCredentials>
</configuration>
```

For more information check [this documentation](https://docs.github.com/en/packages/working-with-a-github-packages-registry/working-with-the-nuget-registry#authenticating-with-a-personal-access-token)

## Install the template

```bash
dotnet new --install Jais.App.Templates
```


# Start a new project

```bash
dotnet new jaisapp -n <app-name>
```