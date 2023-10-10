# Assignment 1 - Sock Catalog Web Application
Author: Arya Patel
Student ID: 0823713
Project Start Date: 5th October 2023

## Project Overview
This project is Assignment 1, which involves creating a robust MVC web application for a sock catalog. The assignment's primary objectives include reviewing socks as the selected product, developing a fictional company, and implementing a sock catalog with CRUD (Create, Read, Update, Delete) operations.

## Project Steps

 **Create README (Project Initialization)**
- Start Date: 5th October 2023
- 09:00 AM: The project was initiated by creating the README, serving as the project's initial and foundational document.
  
 **(took a bit of a break)*
  
 **Get Started**
- Start Date: 5th October 2023
- 10:00 AM: Initiated the project by setting up the development environment, including Visual Studio 2019 which was already provided by our proffessor.

- 10:30 AM: Created a new project and initialized the project's structure, defining the basic project layout. But I did all this in my macbook which was my biggest mistake as it doesn't support ASP.NET Core 3.1.


       *(Went to the collage src lab as they have windows that supports ASP.NET Core 3.1. by 11 
         AM )*
 
**Add a Controller**
- 11:00 AM: Started again and this time in the windows desktop where I faced a challenge which was really small I forgot to comment the port which i did after realizitation. Created the sock controller, a crucial component that handles requests and responses related to sock products. This controller will facilitate interactions with the sock catalog.
  
**Add a View**
- 12:30 PM: Developed initial views for the application to render HTML for user interactions. These views lay the foundation for displaying sock information to users. This was the moment I realized that I can update the table the way i want and its functional. 

**Add a Model**
- 14:00 PM: Defined the sock model class. This model specifies the structure and attributes of a sock, including its name, price, ratings, id, title, release date, etc. It serves as the data structure for sock products. 

**Work with a Database**
- 15:30 PM: Configured and set up a database for the project, allowing for the storage and management of sock products. The sock model data was mapped to this database to ensure data persistence.

**Controller Actions and Views**
- 6th October 2023
  - 09:00 AM: Implemented controller actions for listing socks, viewing individual sock details, and potentially adding, updating, or deleting socks. These actions enable various user interactions.

**Add Search**
- 10:30 AM: Enhanced the user experience by implementing search functionality, enabling users to find specific socks based on criteria such as name or price. Search functionality improves the catalog's usability.

**Add a New Field**
- 11:45 AM: Extended the attributes of sock products by adding a new field. This could include specifying sock material, size, color, or any other attribute that enriches the product information.

**Add Validation**
- 13:00 PM: Implemented data validation to ensure that user inputs are accurate and conform to predefined rules. Validation helps maintain data integrity and the quality of sock product information.

**Examine Details and Delete**
- 14:30 PM: Implemented functionality to allow users to view detailed information about sock products and the ability to remove socks from the catalog. This step completes the CRUD operations for sock products.

**CSS Customization**
- 15:30 PM: Played with CSS to enhance the visual design of all application pages, creating a more appealing user experience.

**Deployment to Azure and Issue Resolution**
- **Deployment to Azure:** Successfully deployed the application to Azure, making it accessible online. All pages are visible to users.
- **Issue with Table Display:** An error occurred while processing requests in the deployed Azure environment. The error message received is as follows:
An error occurred while processing your request.
Request ID: |128127ee-4e00f2e6c198b066.
Development Mode
Swapping to Development environment will display more detailed information about the error
that occurred.
The Development environment shouldn't be enabled for deployed applications. It can result
in displaying sensitive information from
exceptions to end users. For local debugging, enable the Development environment by
setting the ASPNETCORE_ENVIRONMENT environment
variable to Development and restarting the app.

Resolved Errors (In Between Development)

Error 1: During the development process, encountered an issue related to data validation. The error was resolved by revisiting the validation rules and updating them to match the intended criteria.
Error 2: Another challenge was faced while configuring the database, specifically related to database migrations. This issue was resolved by reapplying the database migrations and ensuring the schema was up to date.
Project Description
The "Arya's Socks" project is an ASP.NET Core 3.1 web application that offers a comprehensive catalog of socks. It features a user-friendly interface, secure authentication, and a sock catalog with the ability to add, edit, and remove socks. The project also provides an 'About Us' page to introduce the fictional company, Arya's Socks.

Conclusion
This assignment has been an insightful journey into web application development. It involved reviewing and featuring socks, creating a fictional company, implementing a feature-rich sock catalog, and enhancing the visual design with CSS customization. The development process was well-documented, and the application was submitted as per the assignment guidelines.
