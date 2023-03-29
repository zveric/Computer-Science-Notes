- A key [[Purpose of the operating system]] is to manage memory making sure that there is enough left to run programs
- Memory is finite and like any finite resource memory needs to be managed
- Memory is split up into segments
## Segmentation
- The operating system sets aside memory for the process to use, which is called 'segmentation’. 
- Segmentation is a way of partitioning memory.  Segments are variable sizes based on contents and are logical divisions which hold complete sections of programs. 
- The memory segment given to the process is further divided into several sections - the 'stack segment', 'data segment', 'code segment' and 'free memory'.
## Paging 
- There is a second type of memory management task called paging, which is designed to handle virtual memory. 
- A page is a fixed sized physical division of memory. 
- Each page resides next to each other (contiguous).
- The memory manager gives each page a number and records its location in a table, called a 'page table'. 
- When RAM is getting full, the memory manager can determine the least-used page.
- This page is then copied down into virtual memory. 
