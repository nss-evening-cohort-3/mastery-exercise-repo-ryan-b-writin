# Databases and Repository Pattern Quiz

## Purpose
The goal of this exercise is to assess the student's ability to properly modify and pre-existing Solution to fit it into the proper specifications.


## Rules

- Find and add the needed classes/files to implement a fully unit tested Repository.
- Unit Test and Implement the `NameGenerator` class.
- Create a migration for the `Student` model.
- Use your seed method to populate the database with students.
- Fully implement the Razor View for the supplied `Student` controller using the Specifications below.


## Specifications

- Implement & Unit Test the `NameGenerator` class. This class should generate a random FirstName, LastName, Major combination. Use this class when creating Students.
- `/Student` - This view should display a simple **HTML table** of all students in your database exposing **all** of the properties for the Student model. Your **HTML table** should have headers and be centered on the page.


### What's Included

1. RepoQuiz (MVC Web Application project)
2. RepoQuiz.Tests (Unit Test project)
3. Entity Framework is installed in both projects.
4. Moq is installed in the RepoQuiz.Tests project.
5. A .gitignore :simple_smile:


