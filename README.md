This project was created to consume the api at this repository:
https://github.com/ErikMogensenDK/Testamente

The Blazor application is only done as a brief proof of concept of how API-consumption through the APIClient (found in the Services folder), which was automatically generated using NSwag and is briefly used within the CreatePersonComponent (found in the Components folder).
The API is used in the familytree.razor file, where it is used within the CreatePerson component.
The state of the familytree.razor file is handled through an pageState Enum, and the html is rendered through the use of a series of nested components to display a list of created people, and people found through search in the API.

It is NOT supposed to be a model of a working/finished blazor application - it should be thought of as the finish-line of the SOLID-API it interacts with.
