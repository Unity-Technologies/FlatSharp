dotnet stryker --mutate "['!*UnionTypes.cs']" --excluded-mutations "['checked', 'string']" --project-file=FlatSharp.Runtime.csproj