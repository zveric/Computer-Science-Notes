#[[File Access Methods]]

- Random access is a term used to describe a computer's ability to immediately locate and retrieve data from a storage device
- This method is often contrasted with [[sequential access]] as they are totally different
- In random access, a fixed sized file is usually created, which is large enough to hold all the expected records.
- A hash algorithm is used on a key field to allocate an address in the file this calculates a disk address of a record based on its key field.
- The algorithm **must** produce the same address every time a key is used so that data doesn't get lost.
- If too simple a hashing algorithm is used, several records could hash to the same address.
- This is called a collision and a method of handling clashes needs to be incorporated