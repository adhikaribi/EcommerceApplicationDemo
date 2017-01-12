# EcommerceApplicationDemo
This is a demo Ecommerce APP Using MVC and Unity IoC
------
Architecture : Onion Architectecture (Concentration towards Entities)
Fron End : Razor, Html, CSS, JQuery
Back End : ASP.MVC C#
Database : In-Memory (Integration with ADO.Net entity model is ready but has not been implmented yet)

Tools : VS 2015

Additional Libraries : Unity Ioc from Microsoft and card.js for validating credit card info

Improvements Left : 1) Modifying the MVC Contollers with Web API Contollers
                    2) Integrating Entity Framework for backend manipulation
                    3) Implementing user based Session to store Shopping Cart Data per user basis 
                    (Store may be on Session or encrypted Cookies or table on database iteslf)
                    4) Integrating Inventory and Checking / Updating the stock after purchase

Current Modules : 1) View All Categories of products
                  2) Search for products on the main page itself. Three letters must be typed for searching and click on search icon.
                     e.g. type "fan" and click search icon
                     For now to return back we need to click outside of textbox (simple logic is left implementing here)
                  3) Click on image to view individual product. Add any product to cart with add to cart button
                  4) Update the product Info
                  5) View Cart to see cart items, delete the item in-case not needed
                  6) Click Checkout and Proceed, enter credit card info. Validation done using nice and powerful card.js

This is just a demo sample with more focus on logics and coding practices. Things are still more advanced on real world application,
so consider it for just an insight.

Thank You -----
                  
                     
                    


