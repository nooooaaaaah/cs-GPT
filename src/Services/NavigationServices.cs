// using Clippy.Interfaces;
// using Clippy.Views;

// namespace Clippy.Services
// {
//     public class NavigationService : INavigationService
//     {
//         // Other code and members in the NavigationService class

//         public void GoBack()
//         {
//             // Implementation for navigating back
//             // Example:
//             Application.Current.MainPage.Navigation.PopAsync();
//         }

//         public void NavigateTo(string pageName, object parameter)
//         {
//             Page page;

//             // Instantiate the desired page based on the pageName
//             switch (pageName)
//             {
//                 case "ChatPage":
//                     page = new ChatPage();
//                     break;
//                 // case "HomePage":
//                 //     page = new HomePage();
//                 //     break;
//                 // Add more cases for other pages as needed
//                 default:
//                     // Handle the case when an unknown pageName is provided
//                     return;
//             }

//             // Pass the parameter to the page if needed
//             if (page is IParametrizedPage parametrizedPage)
//             {
//                 parametrizedPage.SetParameter(parameter);
//             }

//             // Navigate to the page
//             Application.Current.MainPage.Navigation.PushAsync(page);
//         }

//         public void ClearBackStack(string pageName)
//         {
//             var mainPage = Application.Current.MainPage as NavigationPage;
//             if (mainPage != null)
//             {
//                 for (int i = 0; i < mainPage.Navigation.NavigationStack.Count - 1; i++)
//                 {
//                     var page = mainPage.Navigation.NavigationStack[i];
//                     if (page.GetType().Name == pageName)
//                     {
//                         mainPage.Navigation.RemovePage(page);
//                         i--;
//                     }
//                 }
//             }
//         }
//     }
// }
