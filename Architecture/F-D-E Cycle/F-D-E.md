### Fetch

1. The value within the PC is copied to the MAR.
2. The data/instruction from the address is transferred to the MDR
3. If its an instruction it is copied to the CIR
4. The PC is incremented

### Decode

1. The contents of the CIR are sent to the CU
2. It decodes the instruction
   - EG: Load data into ACC
3. If needed the instruction to be used is stored in appropriate registers

### Execute

1. The CU and/or the ALU carry out the instruction stored in the CIR

[A much better description](https://www.futurelearn.com/info/courses/how-computers-work/0/steps/49284)
[Another good description](https://isaaccomputerscience.org/concepts/sys_arch_processor?examBoard=all&stage=all&topic=architecture)