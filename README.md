# WayPaths-Career-Assessment

## Description

This project automates the assessment of students' career traits and skills using Microsoft Forms, Azure SQL Database, C#, and Microsoft Power Automate.

Students start by filling out a Career Assessment form on Microsoft Forms. The responses are stored in an Azure SQL Database. A C# .NET backend application retrieves this data, calculates various trait and skill scores, and identifies the top 3 traits and skills for each student. These results are then updated in the database.

To ensure efficiency, Microsoft Power Automate triggers the backend processing each time a new form submission occurs, automating the entire workflow. It also sends a personalized email to the student with their assessment results, offering insights into their strengths and potential career paths.

This project creates a seamless, automated system for analyzing and reporting career potential, integrating cloud services and modern automation tools for a scalable and reliable solution.

## Data Collection:

The process begins with a student filling out a Career Assessment form on Microsoft Forms. The form collects various inputs related to the student's preferences, strengths, and career interests.

![‎Form ‎1](https://github.com/user-attachments/assets/02c95aa5-6363-418d-8f06-da15beb1039e)


## Data Storage:

Once the form is submitted, the collected data is automatically stored in an Azure SQL Database. The database is designed to securely store and manage the assessment data for subsequent processing.

<img width="1512" alt="Screenshot 2024-08-10 at 8 34 32 PM" src="https://github.com/user-attachments/assets/185bcadd-0d11-49c2-bbda-d50c60c7b4a9">


## Backend Processing:

The backend of the system is implemented using C# with the .NET framework. This backend application connects to the Azure SQL Database, retrieves the latest assessment data, and calculates various trait and skill scores for the individual based on their responses. The scoring logic is designed to identify key traits (e.g., creativity, leadership) and essential skills (e.g., problem-solving, communication).


## Top Traits and Skills Identification:

After calculating the scores, the system identifies the top 3 traits and the top 3 skills for the student. These results are then updated in the Azure SQL Database, providing a structured record of the student's strengths.

## Automation with Microsoft Power Automate:

The entire process is automated using Microsoft Power Automate. Power Automate is configured to trigger the backend processing code each time a new form submission is received. This ensures that the data processing happens automatically, without the need for manual intervention.

Additionally, Power Automate is used to send out a personalized email to the student after their assessment is processed. The email contains the results of their assessment, including their top traits and skills, helping them understand their strengths and potential career paths.

## Project Benefits:

This system provides a seamless and automated experience for students, offering them instant insights into their career potential. The use of cloud-based technologies ensures scalability, security, and reliability, making it a robust solution for educational institutions.

This project showcases the integration of Microsoft Forms, Azure SQL Database, C# .NET backend, and Microsoft Power Automate to create a comprehensive and automated career assessment system.
