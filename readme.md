# .NET Core Code Coverage With Open Cover

A boilerplate/example project on using OpenCover to do test coverage reports for .NET Core projects (using csproj)

## Getting started

- Clone the repo
- Go to `test/TestCoverageWithOpenCover.Tests/`
- Execute `dotnet restore` to get the tools
- To back to the project root directory 
- Execute the `run-tests-with-coverage.sh`
- A Html coverage report can now be found at `./coverage-results/report`. You could serve the `./coverage-results/report/index.html` file using any lite web server like eg. [https://www.npmjs.com/package/serve](https://www.npmjs.com/package/serve)

When doing the `run-test...` step you should see the following in the output. If not...something is really wrong.

```
Committing...
Visited Classes 1 of 1 (100)
Visited Methods 1 of 1 (100)
Visited Points 8 of 8 (100)
Visited Branches 1 of 1 (100)

==== Alternative Results (includes all methods including those without corresponding source) ====
Alternative Visited Classes 1 of 1 (100)
Alternative Visited Methods 2 of 2 (100)
```

## Gotchas

Remember to put `<DebugType>full</DebugType>` or something equivalent in your **.csproj** file if you want to replicate the setup in your own project. I have not tested other debug types, but having nothing in the **.csproj** file will make the test discovery fail.