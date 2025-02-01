# OpenCaptcha

![banner](docs/logo.png)

[![codecov](https://codecov.io/gh/ashtonav/opencaptcha/graph/badge.svg?token=ZD0L2LC2U0)](https://codecov.io/gh/ashtonav/opencaptcha)
[![.NET](https://github.com/ashtonav/opencaptcha/actions/workflows/dotnet.yml/badge.svg)](https://github.com/ashtonav/opencaptcha/actions/workflows/dotnet.yml)
[![license](https://img.shields.io/github/license/ashtonav/opencaptcha.svg)](LICENSE)

OpenCaptcha is an open-source, free, public API that generates captcha images.

OpenCaptcha's API is available at api.opencaptcha.io, and its documentation is available at opencaptcha.io.

## Table of Contents

- [Examples](#examples)
- [Usage](#usage)
- [Installation](#installation)
  - [Getting started](#gettingstarted) 
  - [Running tests](#runningtests)  
- [Acknowledgements](#acknowledgements)
- [Contributing](#contributing)
- [License](#license)

## Examples

Example 1: Generated captcha images are randomly distorted.

![banner](docs/captcha_examples.gif)

Example 2: Generated captcha images can have text in many languages.

![banner](docs/captcha_example_multilingual.gif)

## Usage

- API is available at api.opencaptcha.io, no need for  API limits, API keys.
- Comprehensive documentation is available at opencaptcha.io.

You can use OpenCaptcha for free (without any API limits, API keys etc) at api.opencaptcha.io. Alternatively, OpenCaptcha can be self-hosted on Windows Docker containers.

CURL:
```bash
curl -X 'POST' \
'https://api.opencaptcha.io/captcha' \
-H 'Content-Type: application/json' \
-d '{ "text": "hello" }'
```

JavaScript
```js
fetch("https://api.opencaptcha.io/captcha", {
  method: "POST",
  headers: { "Content-Type": "application/json" },
  body: JSON.stringify({ text: "Hello World" })
})
  .then(response => response.blob())
  .then(blob => {
    // For browser usage, you can create an image element:
    const imageUrl = URL.createObjectURL(blob);
    const imgElement = document.createElement("img");
    imgElement.src = imageUrl;
    document.body.appendChild(imgElement);
  })
  .catch(error => console.error("Error:", error));

```

Python
```python
import requests

url = "https://api.opencaptcha.io/captcha"
data = {"text": "Hello World"}
response = requests.post(url, json=data)

if response.status_code == 200:
    with open("captcha.png", "wb") as f:
        f.write(response.content)
    print("Captcha saved as captcha.png")
else:
    print("Error:", response.status_code, response.text)
```

You've made a captcha that says "hello". Need further details or want to explore more? Take a look at our complete API documentation on api.opencaptcha.io.

## Installation

The API is available for free at api.opencaptcha.io.

However, if you want to get it working on your local environment, keep reading.

### How to run in Visual Studio

#### Requirements:
- Visual Studio 2022
    - with `ASP.NET and web development` installed from Visual Studio Installer
- .NET 8 SDK
- Windows Operating System

#### How to run:

1. Open the solution in Visual Studio 2022.
2. Build and launch the Captcha.WebApi project.
3. API can be accessed at localhost:5280.

#### How to test:
1. Open the solution in Visual Studio 2022.
2. Run tests in test explorer.

### How to run in Docker containers

#### Requirements:
- Windows Operating System
- Docker using Windows Containers

[//]: # (TODO: Add info here)

## Acknowledgements

A significant portion of this project, especially captcha generation code, is based on work originally published on February 9, 2004, by [BrainJar](https://www.codeproject.com/Articles/5947/CAPTCHA-Image).

## Contributing

Pull requests are accepted.

## License

[MIT](https://choosealicense.com/licenses/mit/)
