## A procedural language :
- A procedural computer language is one that allows the programmer to set out, step by step, what the computer needs to do and how to do it. 
- is an imperative language, meaning that it gives orders or instructions.
- is sequential, meaning that instructions carried out one after another. These steps form the program flow.
- Has statements in blocks called procedures & functions. These statements are completed in a specific order.


## Procedures and Functions
- Programs are written to perform specific tasks, but it is often useful to break a task down into smaller parts, and consider each separately. 
- Each of these smaller parts can be handled by separate blocks of code within the same program.
- These blocks are called procedures or functions, and each procedure is given a unique identifier. 
- As the program runs, it will use these identifiers to call (run) the procedure or function as required

### Procedures
- Don't return a value
- Performs an operation on arguments/parameter.

### Functions
- A function is a section of code named by an identifier.
- It is called as part of an expression (in the main program) 
- It returns a single value when called  which replaces the function call in the main program. 
- A function takes one or more inputs which are called "arguments" (sometimes known as parameters).

### Passing Parameters
#### By value:
- Local copy of data is used then discarded, so value of original data is unchanged 

#### By reference:
- Actual memory location of data is used so changes can be made to the actual value of data 	

## Reserved Words
- Reserved words are words that cannot be used as an identifier (i.e. the name of a variable, function or label) because they have a special meaning to the compiler.
- They are also known as keywords, which are a subset of reserved words.

## File Handling
- Some computer languages combine the 'Open' and 'Create' function so if the file does not exist, it is created.
- Files can be opened in different access modes. 
### Each mode allows different tasks to be performed on the open file: 
- Read only - allows the file to be read but not modified
- Write only - opens the file for writing into
- Read-Write (update) - opens the file for both read and write. It may also create the file if it did not exist
- Append - opens the file for adding to only. Existing data cannot be deleted