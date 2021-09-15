# KTest

Set tests for new Booking.com filters options(Spa and Star Rating) and based on Selenium, C # and Visual Studio.


Some useful tips.
1. Install Nuget Packages: 
    * Selenium.WebDriver
    * NUnit
    * NUnit3TestAdapter
    * DotNetSeleniumExtras.WaitHelpers
    ----------
    
    In my case, WebDriver didn't want to work, so I needed to install chromedriver.exe manually from https://chromedriver.chromium.org/downloads.
    After unpacking and moving to the location of our choice on the PC/laptop, copy the path in 
    * public void SetupTest ()
2. Start testing.

    * Starting the test takes us to Booking.com, where the first step is to Manage the cookie preferences popup window.
    * Then enter the city (Limerick) we are looking for using the SendKeys () method.
    * Selecting a date in DatePicker is a small challenge, but I decided to use the simplest method by specifying class = calendar__date 
      and date-date required in this test (One night stay and 3 months from today`s date).  
    * The required section Number of People: 2 adults Room: 1 Room are automatically allocated by Booking.com, so go to the search by clicking on the "Search" button.
      Of course, we can use the Assert() methods here to be sure :).
    * The filter page is a bit more complicated because it has hidden attributes, and we can only see some of them. 
    * Sauna filter option. I noticed a certain repetition on the site, so I followed the easiest filtering method by "Sauna". 
      Filtering by accessibility "Spa" is always visible, and after clicking on this option, we always get access to the "Sauna" filter. 
      So the trick is to use the first one and then remove the "Spa" option, leaving you with only "Sauna" filtering.
    * 5 Stars filter option. 
      In this case, the solution is simple as this filter is available by default.
      
      
   Most of the methods I used was on the XPath () and CssSelector ().
