- Every location in memory has a unique address.
- There are many ways to access this data. These are called memory address modes
- Memory includes the internal registers of the CPU, and cache as well as external RAM

## Immediate Addressing
- The data that is going to be used is hard-coded into the instruction.
- This is the fastest type of addressing as the main memory isn't needed.
- Example: y = x + 2
- Useful for constants

## Direct Addressing 
- The code references the individual memory address required.
- This means that if the data moves from the memory address hard-coded into the code the code will break
- It isn't a good idea to use direct addressing on a computer that is being used to run multiple programs however it is well suited for computers running a single program

## Indirect Addressing 
- The addresses are stored in a lookup table 
- The operand acts as a pointer telling the CPU where to find the data
- It isn't confined by the size of the operand
- Allows values to be moved

## Indexed Addressing
- An index is added to the base address in the lookup table.