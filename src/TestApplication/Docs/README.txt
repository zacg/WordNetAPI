*********************************************
*                                           *
*  WordNet 3.0 API in C#                    *
*  Date:  August 20, 2009                   *
*  Author:  Matt Gerber (gerberm2@msu.edu)  *
*                                           *
*********************************************


LICENSE

Free. Do whatever you want with it.


COMPILATION

1) Compile the WordNet project as described in README.txt in the
   WordNet project.

2) Right-click on the TestApplication project, select "Properties",
   and go to "Reference Paths". Add the Public folder that was checked
   out when building the WordNet project.

3) Right-click on the TestApplication project and select "Build".


MACHINE-SPECIFIC PATHS

The test application must know where to find the WordNet data
distribution. This path can be found the in the main form's
constructor. Change as necessary.


FAQ

1) I'm trying to compile the test application and I'm getting an error
   about a missing DLL named LAIR.ResourceAPIs.WordNet.dll. Where do I
   get this DLL?

   You didn't follow the instructions!  :)  See item (1) under
   COMPILATION above. It says to first build the WordNet project. The
   DLL is created when you build the WordNet project.


BUGS REPORTS

Send to gerber.matthew@gmail.com
