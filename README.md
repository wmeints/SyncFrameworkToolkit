Sync Framework Toolkit for Mobile Devices
====================
This repository contains the sources needed to build a mobile version of the sync framework toolkit.
It supports Android, iOS and Windows Phone 8 using the Xamarin.Android and the Xamarin.iOS products from Xamarin.

The original version of this toolkit was built by Microsoft and can be found here: [http://code.msdn.microsoft.com/wpapps/Sync-Framework-Toolkit-4dc10f0e](http://code.msdn.microsoft.com/wpapps/Sync-Framework-Toolkit-4dc10f0e)

Required sync framework tools
---------------
Important before you start using these tools. Make sure you download the appropriate sync framework installables.
If you're running a x64 edition of Windows on your machine, you need to use the x64 version of the sync framework providers. For x86 editions of Windows, you need to install the x86 versions. 

You can find the download for the sync framework providers here:[http://www.microsoft.com/en-us/download/details.aspx?id=19502](http://www.microsoft.com/en-us/download/details.aspx?id=19502)

**Please note!** You can use these only as redistributables on production environments. If you're going to run the sync framework bits on your development machine, you will need the sync framework SDK. Which you can find here: [http://www.microsoft.com/en-us/download/details.aspx?id=23217](http://www.microsoft.com/en-us/download/details.aspx?id=23217)

Quickstart
---------------
If you have an existing database that you want to sync to a mobile device, you can do so by following these steps:

#### Generate a new sync config file

1. Compile the sources and launch the syncsvcutilui.exe program
2. Select the option to create a new sync configuration file
3. Configure which database you want to sync and what schema and tables you want synchronized.
4. Save the generated config somewhere safe. (Beware, do not include spaces in the path)
5. Close the application

#### Provision the database

1. Start the syncsvcutilui.exe program
2. Select the option to provision a database for sync operations
3. Select the database you generated the sync config for and provision it
4. Close the application

#### Generate server-side code

1. Start the syncsvcutilui.exe program
2. Select the option to generate code
3. Select the option to generate server code
4. Select the config on which to base the code
5. Select the output location for the code generator
6. Finish and close the wizard
7. Include the generated sources in a regular ASP.NET application
8. Modify the code to match the configuration of your database connectionstring

#### Generate client-side code

1. Start the syncsvcutilui.exe program
2. Select the option to generate code
3. Select the option to generate server code
4. Select the config on which to base the code
5. Select the output location for the code generator
6. Finish and close the wizard
7. Include the sources in your mobile application project (Xamarin.iOS, Xamarin.Android or Windows Phone)

Important to know
-----------------
Make sure the webserver that hosts the sync service code is running in the appropriate process architecture. If you are using the x64 provider (i.e. running Windows x64) you should be running the worker process in IIS in x64 mode.

This means that you cannot run the sync service inside the development web server or the x86 edition of IIS express.