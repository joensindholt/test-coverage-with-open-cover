# .NET Core Code Coverage With Open Cover

A boilerplate/example project on using OpenCover to do test coverage reports for .NET Core projects (using csproj)

## Getting started

- Clone the repo
- Execute the `run-tests-with-coverage.sh`
- A Html Coerage Report can now be found at `./coverage-results/report`. You could serve the `./coverage-results/report/index.html` file using any lite web server like eg. [https://www.npmjs.com/package/serve](https://www.npmjs.com/package/serve)

## Gotchas

Remember to put `<DebugType>full</DebugType>` or something equivalent in your **.csproj** file if you want to replicate the setup in your own project. I have not tested other debug types, but having nothing in the **.csproj** file will make the test discovery fail.