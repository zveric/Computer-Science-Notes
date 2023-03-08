### Fetch

1. The value within the PC is copied to the MAR.
2. The data/instruction from the address is transferred to the MDR
3. If its an instruction it is copied to the CIR
4. The PC is incremented

### Decode

1. The contents of the CIR are sent to the CU
2. It decodes the instruction
   - EG: Load data into ALU
3. If needed the instruction to be used is stored in appropriate registers

### Execute

1. The CU and/or the ALU carry out the instruction stored in the CIR

[A much better description](https://www.futurelearn.com/info/courses/how-computers-work/0/steps/49284)

[Another good description](https://isaaccomputerscience.org/concepts/sys_arch_processor?examBoard=all&stage=all&topic=architecture)


## Describe the FDE cycle mentioning buses [4 Marks]
The FDE cycle is the method that the cpu uses to complete tasks. I has three main stages: Fetch, Decode and Execute.

During the fetch stage the CPU acquires the necessary information from memory. The Program counter register within the CPU contains the memory address of the next instruction to be fetched. This value is copied into the Memory address register before being sent down the address bus to memory. The data at this address in memory is sent back along the data bus to the Memory Data Register. The data in the MDR is then copied to the Current instruction register. The PC is then incremented.

The next cycle int the FDE cycle is the decode stage. During this stage the data in the CIR is decoded. This process includes spitting the operand from the opcode to determine what type of instruction is to be completed and is anymore information is needed.

The execute stage involves the execution of the instruction. The process of this differs depending on what the instruction is. For an arithmetic instruction the calculation is completed by the ALU and the result is stored in the Accumulator.


