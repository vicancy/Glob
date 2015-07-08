# Glob in CSharp

**Glob**[1] patterns specify sets of fienames with [wildcard characters](http://en.wikipedia.org/wiki/Wildcard_characters).

This is a glob implementataion in CSharp. It heavily dependents on the `Glob` class defined in [Glob.cs](https://github.com/IronLanguages/main/blob/master/Languages/Ruby/Ruby/Builtins/Glob.cs), which is the Glob implemenation of Ruby programming language for .NET Framework.

## Usage
```csharp
var results = Glob.GetMatches(input, 0);
```

## Rules
1. `*` Matches 0 or more characters of the file name or directory name.
2. `?` Matches any single character of the file name or directory name.
3. `**` Recursively matches all the current and descendant directories.
4. `{}` Allows for a comma-separated list of **OR** expressions.
5. `[...]` Matches a range of characters, similar to a RegExp range.

##Samples
**Folder Structure**

```
|-- AAA.txt
|-- ABB.txt
|-- ABC.txt
|-- DDD
     |-- AAA.txt
	 |-- BBB.txt

```

**Result**

Pattern             |  Result
--------------------|--------------------------
`AAA.txt`           | *AAA.txt*
`A*.txt`            | *AAA.txt*, *ABB.txt*, *ABC.txt*
`AB?.txt`           | *ABB.txt*, *ABC.txt*
`*`                 | *AAA.txt*, *ABB.txt*, *ABC.txt*, *DDD*
`**`                | *AAA.txt*, *ABB.txt*, *ABC.txt*, *DDD*
`**/*`              | Returns all the files and directories recursively
`**/`               | *DDD/*
`**/{AAA,BBB}*`     | *AAA.txt*, *DDD/AAA.txt*, *DDD/BBB.txt*




[1]: http://en.wikipedia.org/wiki/Glob_(programming)