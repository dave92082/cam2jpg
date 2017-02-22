# cam2jpg

Older Casio Digital cameras stored images in a proprietary .CAM format which is simply a JPG file with a custom header in front of the JFIF signature.

After finding an old disk with several pictures from my old QV100 camera I decided to put this tool together to see if they were worth keeping. The application will simply seek through the CAM file and once it hits the correct header, will write the remaining bytes to a new JPG file.