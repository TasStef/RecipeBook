# Recipe Book

- [X] Create an ASP.NET Core Blazor application using the Blazor Web App project template (“blazor” in the CLI)
- [ ] Implement a Home/Overview page where you show your best recipes. Maybe use Bootstrap cards to style the content and only show the title, category, and provide a link to the detail page.
- [X] Implement a detail page where you can show images, provide instruction on how to cook the meal, categories and so on.
- [ ] Implement the data loading inside a service class and register it with the dependency injection system. Inject an instance in the Razor component and utilize lifecycle methods to load the data.
- [ ] Use the QuickGrid component to render the ingredients of a recipe.
- [ ] Implement a rating component and add it to the recipe details page. Let the user select a rating between 1 and 5 stars. Save the information in a service and load it when the user navigates away and back to the recipe. It’s okay if the information is gone when the application is restarted (non-persistent storage).
- [ ] Add a form that allows the user to add their own recipes. They don’t need to provide images/photos, but they should be able to fill all the information your recipe model requires. Make sure to validate the user input.
- [ ] Try to use all four rendering modes. Find a use case where you can use static server-side rendering and stream rendering. Most of the pages will required interactivity, and you can choose from Blazor Server interactivity and Blazor WebAssembly interactivity.
- [ ] Experiment with Blazor Server and Blazor WebAssembly interactivity. Either implement a few components with WebAssembly, or build two different applications and compare how it feels to develop and use the application.
- [ ] Identify other features that you can implement to showcase your Blazor knowledge. Be creative. For example, experiment with layout pages, and templated components.
