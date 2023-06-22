# .NET App With ASPNET Core and Angular from scratch Notes

Documentation/study notes on going through the <a href="https://www.udemy.com/course/build-an-app-with-aspnet-core-and-angular-from-scratch/" target="blank">Udemy, Build an app with ASPNET Core and Angular from scratch</a> course. These notes are to help myself to solidify everything i learned.

## Section 1 - Setup

For this course i will be using:
 - .NET SDK ver7.0.200 - backend, API
 - Angular - SPA, user interface
 - Entity Framework - Database queries
 - HTML5
 - Bootstrap
 - CSS
 - TypeScript
 - C#

## Section 2 - Implementation of basic API functionalities
- Getting to know the basics of using dotnet command line interface
- Entity Framework Features:
   * Querying
     - Allows us to query database using linked queries.
   * Change Tracking
     - Keeps track of changes made in our entities which need to be submitted to the DB.
   * Saving
     - Allows us to save the DB and EF will execute insert, update and delete commands to the DB.
   * Concurrency
     - Protect overwriting changes made by another user.
   * Transactions
     - Provides automatic transaction management whilst querying or saving data.
   * Caching
     - Includes first level caching, repeated querying will return data from the cache instead of hitting the DB
   * Built-in conventions
     - Follows conventions and includes a set of default rules which automatically configure EF schema or the model that we use to create our DB.
   * Configurations
     - Provides ways to configure our entities so that we can override the conventions optionally.
   * Migrations
     - Gives us an ability to create a DB schema so that when we start our application, we can automatically generate our DB in our database server.
