********************************************************************
**                                                                **
**                  IBM-PC Installation of DISLIN                 **
**                                                                **
**  Contents:  1.)  Introduction                                  **
**             2.)  Installation of DISLIN                        **
**             3.)  Getting DISLIN Support                        **
**                                                                **
**  Date   :   15.03.2022                                         **
**  Version:   11.5 / Windows .NET, C#.NET, VC++.NET, VBC.NET,    **
**                                                       64-bit   ** 
**  Author :   Helmut Michels                                     **
**             Dislin Software                                    **
**             Am Hachweg 10                                      **
**             37083 Göttingen, Germany                           **
**  Email  :   michels@dislin.de                                  **
********************************************************************

1.)  Introduction

     This file describes the installation of the .NET distribution
     of the data plotting software DISLIN. The .NET distribution of
     DISLIN can be used from the .NET compilers C#, Visual C++ and
     Visual Basic, and may be from other .NET compilers.

     The DISLIN .NET distribution is based on a unmanaged DLL 
     (dislnc.dll) and a managed DLL (disnet.dll) that contains wrapper
     routines for the unmanaged DLL. The managed DLL disnet.dll must
     be linked (referenced) with the user code while dislnc.dll must
     be situated in a directory that is included in the PATH environ-
     ment. If you distribute a DISLIN .NET program, the both DLLs 
     dislnc.dll and disnet.dll must be distributed with your program. 
     

2.)  Installation of DISLIN

     The .NET dsitribution of DISLIN is contained in the zipped file
     dl_11_cs.zip.  A utility for unpacking the DISLIN files is 
     available from the same location where you have downloaded 
     dl_11_cs.zip, or from the DISLIN CD-ROM. 

     To install DISLIN, make the following steps:

  a) Create a temporary directory and copy the files dl_11_cs.zip
     and unzip.exe to it:

     for example:   md  c:\temp
                    cd  c:\temp
                    copy e:\dislin\windows\unzip.exe    *.*
                    copy e:\dislin\windows\dl_11_cs.zip *.*

  b) Extract the DISLIN files with the command:

                 unzip  -o dl_11_cs.zip

  c) Run the setup program with the command

                  setup

     -  Choose OK

     -  Give the Installation Directory where  DISLIN  should be in-
        stalled. The default directory is C:\DISLIN.

  d) Reconfigure the System

     Set the DISLIN environment variable to c:\dislin and include
     c:\dislin\win in your path. If you have installed DISLIN in a
     different directory, you have to use that directory for the 
     environment variables above.

     The environment variables can be set or modified with the Control
     Panel 
    
     (see Control Panel -> System -> Advanced -> Environment
      Variables).
   
  e) Now you can compile and run the example programs in the
     DISLIN subdirectories examples\cs, examples\vb and examples\cpp
     with the commands

     for c# in the subdirectory examples\cs:

          copy c:\dislin\disnet.dll
          csc curve.cs -r:disnet.dll
          curve

     for Visual Basic in the subdirectory examples\vb:

          copy c:\dislin\disnet.dll
          vbc curve.vb -r:disnet.dll
          curve

     for Visual C++ in the subdirectory examples\cpp:

          copy c:\dislin\disnet.dll
          cl /clr curve.cpp
          curve

    Notes: - The managed DLL disnet.dll should normally be situated in the
             same directory as the .NET program that uses disnet.dll.

           - The library disnet.dll pass float variables to Dislin. There
             is also a version for double parameters with the name
             disnet_d.dll.   

3.)  Getting DISLIN Support

     The DISLIN distributions can be used freely without any restriction.
     Access to the source code is availabe via a support contract from the
     site www.dislin.de.

