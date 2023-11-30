# DevXCatalog
This WinForms application built using DevExpress aims to provide a comprehensive product catalog browsing experience. Users can explore various products, product categories, view their details, and access specific product specifications.

## Table of Contents
- [Built With](#built-with)
- [Features](#features)
- [Usage](#usage)
- [Usage Examples](#usage-examples)
- [Data Model](#data-model)

### Built With
- [Microsoft Visual Studio](https://visualstudio.microsoft.com/)
- [C#](https://learn.microsoft.com/en-us/dotnet/csharp/)
- [DevExpress](https://www.devexpress.com/)
- Microsoft SQL Database

### Features
- Main Screen: Welcoming users with a friendly message and an image.
- Catalog Module: Accessible via the top menu bar's "Catalog" button.
- Catalog Upper Grid: Displays a list of products sold by the company with:
  - Ability to filter the list using multiple parameters such as product name, price range, category, etc.
  - Ability to sort the product list based on various criteria.
- Catalog Lower Grid: Displays detailed information on a selected product from the upper, each product category has its own set of specifications.

### Usage
- Upon launching, the welcome screen appears with the main menu.
- Click on the "Catalog" button to access the product catalog module.
- Utilize the upper grid to explore the product list, filter data, and sort items.
- Selecting a product will load its detailed specifications in the lower grid.

#### Usage Examples
Main screen
![image](https://github.com/vkitori/DevXCatalog/assets/47561823/9516b26b-2f96-4cbb-9b1f-367bd6a38177)

Filtered and sorted list of products
![image](https://github.com/vkitori/DevXCatalog/assets/47561823/abd8a282-151d-4f0e-ba33-e781dfbf31b9)

Product detail for category "Elektoronika"
![image](https://github.com/vkitori/DevXCatalog/assets/47561823/f993b57a-7ce4-49e4-b83a-719e988b1091)

Product detail for category "Knihy"
![image](https://github.com/vkitori/DevXCatalog/assets/47561823/77718f7c-c56b-416f-963c-43800951478a)

### Data model
This schema provide posibility to use category-specific specifications, meaning each category can have its own set of specifications defined in the CategorySpecification table. 
![Blank diagram (1)](https://github.com/vkitori/DevXCatalog/assets/47561823/b5a64f97-4994-47d7-9821-ed3d3804f7ae)

Relationships:
- Products_Categories: Each product is associated with a specific category.
- CategorySpecification_Categories: Each category is associated with a specific CategorySpecification.
- Products_ProductSpecification: associates products with these specifications.
- ProductSpecification_CategorySpecification: links the specifications of a product to the category-specific specifications defined in the CategorySpecification table.

#### Data views
![image](https://github.com/vkitori/DevXCatalog/assets/47561823/c8aa3e44-40fd-43bf-99fa-a93c3e905d1c)
