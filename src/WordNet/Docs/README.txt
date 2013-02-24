*********************************************
*                                           *
*  WordNet 3.0 API in C#                    *
*  Date:  August 20, 2009                   *
*  Author:  Matt Gerber (gerberm2@msu.edu)  *
*                                           *
*********************************************


LICENSE

Free. Do whatever you want with it.


WARNING

This API will modify the index.* files that are distributed
with WordNet. These files will be re-sorted for use by the .NET
runtime, whose string sort order differs from that of the Java
runtime. As a result, the Java (and other) APIs/applications might not
function correctly when used with the re-sorted index.* files. You
should create multiple copies of the WordNet data (one for each
runtime) to avoid such problems.


COMPILATION

1) The WordNet API depends on some libraries that are distributed
   separately. To get them, perform a Subversion checkout from the
   following URL:

   https://ptl.sys.virginia.edu/msg8u/NLP/Libraries/Public

2) Right-click on the WordNet project, select "Properties", and go to
   "Build". Change "Output path" to the Public directory that was
   checked out in the previous step. Check the box next to "XML
   documentation file".

3) Right-click on the WordNet project and select "Build".


FAQ

1) Which version of the WordNet data should I use?
   
   This software is designed for version 3.0 of the WordNet data
   distribution. The Windows tools (e.g., browser) that come with
   WordNet are only compatible with version 2.1 of the data. Don't let
   this confuse you:  you still need to download version 3.0 of the
   data in order to use this software. Here's a link:

     http://wordnetcode.princeton.edu/3.0/WNdb-3.0.tar.gz
   
   The index.* and data.* files should be unzipped to the directory
   that is passed to the WordNetEngine constructor.


BUGS REPORTS

Send to gerber.matthew@gmail.com
