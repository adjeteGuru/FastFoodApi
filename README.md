# FastFoodApi is a web Api design for Take Away Kebab Shop to processing an Order made by a Customer
In this project, I am building a full REST API using .NET Core 3.1.
I am implemtenting a Web Api using MVC, REST, the Repository Pattern, 
Dependency Injection, Entity Framework, Data Transfer Objects, (DTOs),
AutoMapper to provide 6 API endpoints that will allow a user to Create, Read, Update and Delete resources.

How to test:
PATCH: API
in the format of Json:  
e.g: here indicate the 'path' that need change as follow--> tel value change to "undefined"
[
     {
        
        "op": "replace",
        "path": "/tel",
        "value": "undefined"       
    }
 ] 
 
 POST: API
 in the format of Json:
 e.g: here fill properties with their values as follow
 {
    "fullName": "John Smith",
    "tel": "01155597812",
    "houseNo": "185",
    "street": "woodfield road",
    "postcode": "NG86HW",
    "city": "nottingham"
}

 PUT: API
 in the format of Json:
 e.g: here the Tel No has changed as follow
{
        "id": 3,
        "fullName": "John Smith",
        "tel": "01155888888",
        "houseNo": "185",
        "street": "woodfield road",
        "postcode": "NG86HW",
        "city": "Nottingham"
   }
   
For DELETE and GET, all you need is to enter the id then execute the Send
e.g: https://localhost:44355/api/Customer/2

