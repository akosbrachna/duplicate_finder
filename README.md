# duplicate_finder

This is a simple duplicate file finder. It takes 5 x 200 byte samples from both files and compare the content to each other. 

The first simpler method makes a byte by byte comparison looking for exact match. The second one makes a statistical comparison, 
it checks the occurences of the bytes and the distances from each other in the sample.
