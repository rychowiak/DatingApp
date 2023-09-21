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

  Entity Framework Features:
   * <strong>Querying</strong> - Allows us to query database using linked queries.
   * <strong>Change Tracking</strong> - Keeps track of changes made in our entities which need to be submitted to the DB.
   * <strong>Saving</strong> - Allows us to save the DB and EF will execute insert, update and delete commands to the DB.
   * <strong>Concurrency</strong> - Protect overwriting changes made by another user.
   * <strong>Transactions</strong> - Provides automatic transaction management whilst querying or saving data.
   * <strong>Caching</strong> - Includes first level caching, repeated querying will return data from the cache instead of hitting the DB
   * <strong>Built-in conventions</strong> - Follows conventions and includes a set of default rules which automatically configure EF schema or the model that we use to create our DB.
   * <strong>Configurations</strong> - Provides ways to configure our entities so that we can override the conventions optionally.
   * <strong>Migrations</strong> - Gives us an ability to create a DB schema so that when we start our application, we can automatically generate our DB in our database server.

## Section 2 - Implementation of basic API functionalities
- Getting to know the basics of using dotnet command line interface
- Adding Entity Framework to the project

## Section 3 - Implementation of walking skeleton
- Getting familiar with Angular CLI (How to create new Angular app)
- Understanding of the Angular bootstrap process
- Using the angular HTTP Client Service
- Running Angular app over HTTPS
- How to add packages using NPM
