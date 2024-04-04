# Description
In the previous section we learnt about a file reading method called `File.ReadAllText`. While it is a synchronous method for reading a file, there is an asynchronous alternative as well - It is called `File.ReadAllTextAsync`.

There is an attached file in the task description, this is the file we want to read.  The base code contains a program which reads the file synchronously.

Currently the output of the program is:
```
Started Program
Started Reading File
Ended Reading File
<< ASYNC CHECK >>
Ended Program
```

Notice how `<<ASYNC CHECK>>` is only printed after the file is fully read. We want it to print while the file is being read.

**Your task** is to modify the code and make the program **asynchronously read the file**. If the `<< ASYNC CHECK >>` message prints between `Started Reading File` and `Ended Reading File` messages, then it means you have successfully implemented an asynchronous solution:
```
Started Program
Started Reading File
<< ASYNC CHECK >>
Ended Reading File
Ended Program
```

### Hints
> Hint 1: Use the `async` keyword to convert the `ReadFile` method into an asynchronous method;

> Hint 2: The return value of the `ReadFile` method will follow the `Task<T>` syntax where T will represent the datatype of the return value - In this case the return datatype is `string`;

> Hint 3: We need to `await` the execution of the `File.ReadAllTextAsync` method inside the `ReadFile` method;

> Hint 4: We also need to make the main method asynchronous;

> Hint 5: Before ending the program, we need to make sure the file reading task is fully performed. For that we can again use the `await` keyword;
