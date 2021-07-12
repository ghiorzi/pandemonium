# generate data
dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=cobertura
# generate report
dotnet tool run reportgenerator "-reports:./coverage.cobertura.xml" "-targetdir:coveragereport" -reporttypes:Html
# open report

open ./coveragereport/index.htm