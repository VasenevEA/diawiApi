# diawi Api

.Net Standart 2.0 library for [diawi](https://www.diawi.com/)'s API

[![Nuget](https://img.shields.io/nuget/v/diawi.api)](https://www.nuget.org/packages/diawi.api/) ![](https://img.shields.io/nuget/dt/diawi.api)

## Install

```sh
Install-Package diawi.api -Version 1.0.0
```

## Example

Simply replace the diawi 'token' variable with your token string and replace the 'file' variable with the full path of your application.
``` c#
using DiawiApi;
using DiawiApi.Models;


var fileStream = new FileStream(file, FileMode.Open);
var result = await api.Upload(token, new StreamPart(stream, stream.Name, "")); 

var status = await api.GetStatus(token, result.JobKey);

```
