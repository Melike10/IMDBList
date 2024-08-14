
# IMDB Movie List Console Application Patika Dev Week 5 Pratik

This project is a simple C# console application that allows users to create a list of movies with their respective IMDB ratings. The application enables users to enter movie names and ratings, store them in a list, and then filter and display specific subsets of the list based on certain criteria.

## Features

### 1. **Movie Class:**
   - **Properties:**
     - `Name`: Stores the name of the movie.
     - `ImdbPuan`: Stores the IMDB rating of the movie.
   - **Constructor:**
     - Initializes the `Name` and `ImdbPuan` properties with the values provided by the user.

### 2. **Main Program:**
   - **Add Movies to List:**
     - Users can input multiple movies with their IMDB ratings.
     - The program validates the IMDB rating to ensure it is between 0 and 10.
   - **Display All Movies:**
     - The program prints all the movies entered by the user, displaying their names and ratings.
   - **Filter Movies by Rating:**
     - The program filters and displays movies with IMDB ratings between 4 and 9.
   - **Filter Movies by Name:**
     - The program filters and displays movies whose names start with the letter 'A' or 'a'.

## How to Run

- Compile and run the code in a C# compatible environment or IDE like Visual Studio.
- Follow the on-screen prompts to enter movie names and their IMDB ratings.
- The program will display the full list of movies, followed by filtered lists based on the specified criteria.

## Technologies Used

- C#
- .NET Core Console Application




