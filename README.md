# WayPaths-Career-Assessment

## Description

This project automates the assessment of students' career traits and skills using Microsoft Forms, Azure SQL Database, C#, and Microsoft Power Automate.

Students start by filling out a Career Assessment form on Microsoft Forms. The responses are stored in an Azure SQL Database. A C# .NET backend application retrieves this data, calculates various trait and skill scores, and identifies the top 3 traits and skills for each student. These results are then updated in the database.

To ensure efficiency, Microsoft Power Automate triggers the backend processing each time a new form submission occurs, automating the entire workflow. It also sends a personalized email to the student with their assessment results, offering insights into their strengths and potential career paths.

This project creates a seamless, automated system for analyzing and reporting career potential, integrating cloud services and modern automation tools for a scalable and reliable solution.

## Data Collection:

The process begins with a student filling out a Career Assessment form on Microsoft Forms. The form collects various inputs related to the student's preferences, strengths, and career interests.
