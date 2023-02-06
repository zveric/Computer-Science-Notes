- Compression is the process of reducing the size of a data file while keeping most or all of the original information
- Most types of data can be compressed
- **Compression ratio = original data size / compressed data size**

## Reasons for compression
- Less storage space needed
- Faster Downloads/Uploads
- Smaller file attachments for email
- Coping with slow streaming links

## Lossy
- Lossy compression is destructive meaning that data is lost during compression. 
- This means that when the file is uncompressed it wont be identical to the original file.
- This is used mostly for human facing applications.

## Lossless
- Lossless compression means that data is compressed but no data is lost.
- The original file is identical to an uncompressed version of the compressed file.
- Lossless compression can take up more space as potentially unnecessary data is still stored.

### Run-Length Encoding
- When multiple consecutive pieces of data are identical RLE can losslessly reduce the file size as a string of identical data is stored as a single piece of data.
![[Pasted image 20230206115213.png]]

### Dictionary based compression
- Common consecutive characters can be stored in a dictionary allowing data to be reduced in size.
- This works well if words are regularly repeated