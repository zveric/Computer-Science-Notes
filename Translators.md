- Programs written in ((6527c0cc-cf5d-49f4-9f0b-ef4ed1f15e88)) Languages are written inderpendent of the CPU [[Architecture]]
- To convert high level languages into machine code a translator is used.
- Depending on the implementation of the programming language either a ((6527c258-1d86-434f-9d4e-ea75756acc2a)) or a ((6527c25d-a4fb-4965-a641-422d62199ee7))
- ## Compiler
  id:: 6527c258-1d86-434f-9d4e-ea75756acc2a
	- Compilers translate code into a form that can be executed. However, **the compiler does not execute the code**.
	  Compilers produce executable code in a form that cannot be read by a 
	  human or readily reverse-engineered (i.e. converted back into source 
	  code). Most commercial software applications are distributed as compiled
	  code so that the source code is protected. This is advantageous to 
	  commercial developers who make money from their code.
	- The compiler takes the source code as its set of instructions, which 
	  it then puts through a series of processes to produce executable code. A
	  compiler carries out the following processes, which are detailed in the
	  [stages of compilation](https://isaaccomputerscience.org/concepts/sys_trans_stages) page:
		- Lexical analysis
		- Syntax analysis
		- Semantic analysis
		- Code generation
		- Optimisation
	- Any compilation errors are reported at the end of the compilation 
	  process. This is a disadvantage for large programs, as errors may be 
	  interlinked. If any errors are found, the program will need to be 
	  rectified and then compiled again; this process is repeated until the 
	  program is free from errors.
	- When the program has successfully compiled, the executable file will 
	  not need to be translated again (unless the source code is changed). 
	  This results in faster running times, as no further translation is 
	  required, and it's a particular advantage for programs where performance
	  is critical, e.g. fast-moving games.
	- Another advantage of using a compiler is that the user does not need a
	  translator (i.e. interpreter) to be installed on their computer (as 
	  they will never need to translate the program themselves).
- ## Interperator
  id:: 6527c25d-a4fb-4965-a641-422d62199ee7