Azureoid
========

Azureoid is a management client for Android. It's an alternative to the management portal that renders better on mobile android devices. 

*Requirements*
* Xamarin Studio for Android
* Active Azure Subscription 

*How to setup*
1. Fork or clone the repository
2. Open the project on your local machine, it will show a missing file in /Assets/Azure.Publishssettings this is the file that has your connection information from azure. It's excluded from source control on .gitignore for security purposes
3. Add your own file to the assets folder in order to connect to your azure subscription. You can get this file here: https://windows.azure.com/download/publishprofile.aspx

That's it!! That will make API calls work to the azure management service. 

P.S. The .publishsettings thing is temporary in order to start testing. The first thing we're doing is removing it from the Assets folder and reading everything from the certificate store. 
