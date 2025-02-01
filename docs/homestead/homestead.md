# Homestead Management System
These exercises will guide you through the process of creating a simple system. You must have basic experience with:
- HTML and CSS
- C# (variables, if-else, loops, arrays/list and methods)
- Object Oriented C# (classes, objects, encapsulatioin, aggregation)
- git/GitHub for version control [OPTIONAL]

This document is structed as a guide. This means that each step will be explained with a purpose, learning objectives, and learning checks at the end of each section.

We will use versioning, starting with version 0.1, incrementing to version 0.2 and so on, and ending with version 1.0 for the first production ready release. For each version we will detail the requirements. And after version 1.0 we will continue to develop new features, and modify the system towards best practice, as we go:

|Version|Key features|
|-------|------------|
| 0.1 | Log in
| 0.2 | Basic livestock management
| 0.3 | Basic vegitable management
| 1.0 | Basic management |

These version are meant to get you started, and are not meant to teach you all of the best practices - but they will come later.



## Introduction to the business domain

> **📘 Fact:** A business domain is the main area a business works in. It includes the important activities and knowledge needed for that field.

But first, you need some knowledge about the business domain: A homestead is a place where people live and grow their own food. It usually includes a house, garden, and animals like chickens or cows. Homesteaders try to be self-sufficient, meaning they produce most of what they need themselves.

## Why a homestead needs a management system
Managing a homestead involves many tasks, like keeping track of plants, animals, and tools. A Homestead Management System can help by:

- Organizing Information: Keeping all important details in one place.

- Improving Efficiency: Automating routine tasks and reminders.

- Helping with Decisions: Providing data to make better choices about crops and animals.

- Supporting Sustainability: Monitoring resource use to be more eco-friendly.

- Facilitating Communication: Helping family members or workers stay coordinated.

By using this system, homesteaders can work more efficiently and sustainably.

> **💡 Tip:** If you want to know more about homesteading, go online and search "homesteading" or chat with AI an assistant.

## Getting started
We are almost ready to start the development of version 0.1, but first we need some infrastructure. This includes setting up a local database (LocalDB), an Integrated Development Environment (IDE) like Visual Studio/VS Code, and version control with Git/GitHub. These tools will help us manage our code, track changes, and test our features effectively.

### Exercise 01 [OPTIONAL]: Create a Github repository and clone it to your computer
> **Purpose**: The purpose of this exercise is to familiarize you with the process of creating and managing a GitHub repository. By the end of this exercise, you will have a local repository connected to a remote GitHub repository, which will help you manage your code and track changes.


First, use your existing Github user account to create a Github repository. We will clone this in a moment. You can use the setup as depicted here:

![Create Github repository](./github-create-repo.png)

> **❗ Important:** Remember to set the .gitignore template to **VisualStudio**. This ensures that only code files are pushed to GitHub, and unnecessary binary files are excluded.

The next step is to clone the repository to your computer. This can be done in several ways, either from an ide like VS Code or Visual Studio, or from the command line. Here are step by step guides to each of these ways:

#### Cloning from Visual Studio Code
1. Open Visual Studio Code.
2. Open the Command Palette (Ctrl+Shift+P).
3. Type Git: Clone and select it.
4. Enter the repository URL: https://github.com/username/homestead.git.
5. Choose a local folder where you want to clone the repository.
6. Wait for the cloning process to complete.

#### Cloning from Visual Studio
1. Open Visual Studio.
2. Go to File > Clone Repository.
3. Enter the repository URL: https://github.com/username/homestead.git.
4. Choose a local folder where you want to clone the repository.
5. Click Clone and wait for the process to complete.

#### Cloning from the Command Line
1. Open your terminal.
2. Navigate to the folder where you want to clone the repository using the cd command.
3. Run the following command:
`git clone https://github.com/username/homestead.git`
4. Wait for the cloning process to complete.

You should now have created a **local** git repository, this is connected to the **remote** Github repository. You can verify this by looking around the user interface in either VS Code or Visual Studio, or in the terminal by running `git remote -v`.

#### Learning checks:
1. You have created a GitHub repository and set the .gitignore template to VisualStudio.
2. You have successfully cloned the repository using one of the methods described.
3. You have verified that the local repository is connected to the remote GitHub repository.

Toy are now ready to proceed to creating the database.

### Exercise 02: Creating the database
> **Purpose**: To create a reusable SQL script that can be run over and over again, as the database is modified.

It turns out, that it is quite handy to have a script that deletes the entire database, if it exists, and then creates it all over again, with the modified changes:

```SQL
-- Drop the database if it exists
DROP DATABASE IF EXISTS HomesteadDB;
GO

-- Create the database
CREATE DATABASE HomesteadDB;
GO

-- Use the database
USE HomesteadDB;
GO
```

First, create your own .sql file, and add SQL code for creating a table that holds users. This means data for their usernames and passwords.

Your script can be executed in either SSMS, VS Code, Visual Studio or even from the command line. Choose one approach, but feel free to try them all.

#### Learning resources
Go to [W3Schools | SQL](https://www.w3schools.com/sql/) and learn how to create tables - you find the link to SQL Create Tables in the left side under 'SQL Database'.

#### Troubleshooting
* Can't figure out how to run a SQL script? Go online, and search "how to run a SQl script in SSMS". 
* Can't connect to `(localdb)\mssqllocaldb`? The **localdb** is part of the Visual Studio workload called Data Science and Processing. You install it via the Visual Studio Installer application.

#### Learning checks
1. You have created a .sql file with the provided script to drop and create the database.
2. You have added SQL code to create a table for users, including columns for usernames and passwords. Also, data for at least two users.
3. You can run the script multiple times without errors, and it successfully recreates the database and the Users table each time.

### 
