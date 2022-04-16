# AppTemplate - JAIS app

| App           | AppTemplate   |
| ------------- |:-------------:|
| **Author**    | name          |
| **Version**   | 0.1.0         |

<br />

## Description

>  Insert a detailed description of the application here.

## Structure

 * [src](./src)
   * [AppTemplate](./src/AppTemplate)
   <br />The main app, that gets packaged
   * [AppTemplate.Test](./src/AppTemplate.Test)
   <br />Only a project used to run the app as a desktop app on macOS, Windows or Linux for development purposes. Independent of JAIS.
 * [AppInfo.json](./AppInfo.json)
 <br />Contains information about the app.

## Package

```bash
jais package --version 0.1.0
```