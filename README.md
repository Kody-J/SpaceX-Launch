# SpaceX-Launch
ASP.Net MVC Web App Utilizing SpaceX API -- https://github.com/r-spacex/SpaceX-API -- to display SpaceX Launch Details 


To run this Application please clone this repository and open the solution file (SpaceX-Launch.sln) in Visual Studio. 
Then use the IIS Express to launch the application in a web browser of your choice. 

SpaceX API provides a JSon Array of all past and future SpaceX Rocket lunch details. 

I harnessed the Newtonsoft.Json NuGet Package to access and minipulate the JSon Array and display the data accordingly to the home page. 

Core logic is contained in the Controllers\HomeController.cs GetLaunchJSon and Index functions. 

Overall this was a simple POC aimed at connecting to a web API, collecting data, and minipulating the data to display to the user. 

As a first iteration the features are simple:
  1) Introduce the user to the application with a simple and frindly home screen.
  2) Using a table display the data
    . Each row of data on the table is orderd in Descending fashion based on the Launch Date
    . Launch times were converted from UTC and displayed in CDT/CST (utilizing the .Net DateTime TimeZoneInfo.ConvertTimeFromUtc logic)
    . Rocket Names are displayed for each rocket launch
    . Launch Success status is displayed as either 'TRUE', 'FALSE', or 'TBT' for To Be Determined
    . If the lauch contained a payload, the payload mass is displayed in Kilograms
    . Payloads are then Ranked based on their mass with 1 representing the largest

Future Iterations:
  1) Add pagination for the table and allow the user to choose how many Launches to display on each page
  2) Add a Search feature to lookup a Specific Launch
  3) Create a more interactive UI to allow the user to select any launch which has a lunch video and pull up that video in with a new        browser window
  4) Add additional Styling to improve the UI and incease quality of the user experience

