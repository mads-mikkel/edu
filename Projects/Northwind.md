# Norhtwind
In this project, you will design a .NET Blazor website integrated with a .NET REST API to manage order processing and customer data using the Northwind example database. The system displays customer details, order summaries, and product information in an engaging and user-friendly interface. API endpoints control data retrieval and manipulation, ensuring a clear separation between front-end presentation and back-end logic. Users will be able to search, filter, and navigate orders seamlessly to monitor order tracking and inventory status. This case provides practical experience with RESTful services and modern web development, highlighting the integration of business logic and interactive design.

## 1. Description of the User
The primary user is a customer service representative at a small business. They have moderate technical proficiency and routinely access and update order and customer information from the Northwind database. They require a streamlined, intuitive interface to quickly search orders, verify customer details, and stay on top of inventory. Their daily tasks demand efficiency and clarity, ensuring they can provide prompt, accurate responses to customer inquiries.

## 2. User Story
"As a customer service agent, I want to effortlessly search through and view detailed customer orders so that I can quickly resolve inquiries and ensure up-to-date information is available for decision-making."

## 3. Use Case
**Title:** View and Manage Customer Orders

- **Actor:** Customer Service Representative  
- **Preconditions:** The user is authenticated and the Northwind database is accessible.  
- **Main Flow:**  
  1. The user logs into the Blazor website.  
  2. They navigate to the 'Orders' section via the top navigation bar.  
  3. The user inputs search criteria (such as customer name or order ID) into a search bar.  
  4. A list of matching orders appears in a table format.  
  5. The user selects an order to view detailed information including customer data, product details, and order status.  
- **Postconditions:** The user can review order details and, if needed, flag issues or update records via the API.

## 4. Requrements
#### Functional Requirements
- Develop a .NET REST API to fetch and update customer, order, and product data from the Northwind database.  
- Implement search and filter functionalities for the orders interface.  
- Ensure secure authentication and authorization for data access.

#### Non-Functional Requirements
- Provide a responsive and user-friendly UI in Blazor.  
- Achieve quick page loads and minimal latency in API responses.  
- Ensure compatibility across modern browsers and accessibility standards.
---

## 5. Layout & Visual Suggestions
#### Layout
- Use a clean, minimalistic design with a top navigation bar that includes menu items for "Orders," "Customers," "Products," and a dedicated search field.  
- The main content area should display a table with expandable rows: each row representing an order that, when clicked, reveals detailed information in a card-style panel.  
- Optionally, include a sidebar for filtering options and quick links to common actions (e.g., recent orders).

#### Colors & Fonts
- **Color Palette:** Consider a calming, trustworthy palette. For example, use varying shades of blue for primary actions and headers, white or very light grey for backgrounds, and subtle accents (like light green for confirmations and soft red for errors).  
- **Typography:** Choose a modern, legible sans-serif font (such as Segoe UI, Lato, or Roboto) to maintain a clean look. Ensure sufficient contrast for readability in compliance with accessibility standards.