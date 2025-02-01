# OpenCaptcha

![banner](docs/logo.png)

[![codecov](https://codecov.io/gh/ashtonav/opencaptcha/graph/badge.svg?token=ZD0L2LC2U0)](https://codecov.io/gh/ashtonav/opencaptcha)
[![.NET](https://github.com/ashtonav/opencaptcha/actions/workflows/dotnet.yml/badge.svg)](https://github.com/ashtonav/opencaptcha/actions/workflows/dotnet.yml)
[![license](https://img.shields.io/github/license/ashtonav/opencaptcha.svg)](LICENSE)

OpenCaptcha is a free, public API that generates captcha images.

Below are examples of captcha images generated by OpenCaptcha.
![banner](docs/captcha_examples.gif)

[//]: # (TODO: Add examples of multi-ligual images here)

- **Free and Unrestricted**: No cost, no API limits, no API key needed.
- **Multi-Language Support**: Generates captchas in several languages, such as Mandarin, Arabic, Spanish, and more.
- **Customizable**: Adjust captcha difficulty and size as needed.

OpenCaptcha is available for free at api.opencaptcha.io, alternatively you can host it yourself.

## Table of Contents

- [Install](#install)
- [Usage](#usage)
- [Contributing](#contributing)
- [License](#license)

## Install

The API is available for free at api.opencaptcha.io.

However, if you want to get it working on your local environment, keep reading.


### Getting started

Development requirements are the following:
- Visual Studio 2022
    - with `ASP.NET and web development` installed from Visual Studio Installer
- .NET 8 SDK
- Windows Operating System

To run the API:
1. Open the solution in Visual Studio 2022.
2. Build and launch the Captcha.WebApi project.
3. API can be accessed at:
    - localhost:5280

### Running tests

To run unit functional tests, you need to run WebApi project and then run the functional tests.

1. Build the solution
2. Open Terminal
3. Navigate to the path `/src/Captcha.WebApi`
4. Run command: `dotnet run`
5. Open Visual Studio (or any other test runner) and run the functional tests.

## Usage

## Acknowledgements

A significant portion of this project, especially captcha generation code, is based on work originally published on February 9, 2004, by [BrainJar](https://www.codeproject.com/Articles/5947/CAPTCHA-Image).

## Contributing

Pull requests are accepted.

## License

[MIT](https://choosealicense.com/licenses/mit/)
