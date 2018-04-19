# PDXbnb

#### _By Kaila Goff, Maggie Summers, Hannah Lee & Stephanie Faber_

## Description

_A website used to track Carmen Sandiego's travels in the form of a blog. You can add new Locations, Experiences, and People. All of these have relationships with each other, so you can see, for instance, who was there during a certain experience in a certain location.

## Database Relationships
	_`The Database schema is a series of one-to-may relations`_
		Locations have many possible experiences.
		Experiences have many possible people.
	_`Future implementation of many-to-many relations is planned for version 2.0.`_

##  Current Features
  * Can add and edit Locations, Experiences, and People.

## Installation

  1. _`$ git clone https://github.com/kailagoff/PDXbnb` _

  2. _`$ cd TravelBlog`_

  3.  _Open the solution in VS 2017_

  4. _Open MAMP, set Apache port to 8888, set MySQL port to 8889, start up servers_

  5. _`$ dotnet ef database update`_

  6. _Run the app in VS 2017_


#### Development server

Open solution in Visual Studio 2017, restore NuGet files in the app or use the command $dotnet restore using command prompt while in the project directory. Run MAMP with Apache port settings at 8888 and the MySQL port settings at 8889. Finally, you can run the app in VS 2017. It should open a new window for the application.

## Known Bugs

_No known bugs at this time._

## Support and contact details

  _To suggest changes, submit a pull request in the GitHub repository._

## Technologies Used

  * HTML
  * CSS
  * C#/.Net
  * Razor
  * SQL
  * Visual Studio 2017

_Dev Dependencies_
  * Bootstrap 3.3.7

### License

  *MIT License*

Copyright (c) 2018 **Ian Goodrich and Stephanie Faber**