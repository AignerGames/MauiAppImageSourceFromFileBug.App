


Bug #1 Canvas Exception
- Run on a Android (Tablet?) device
- Select the first list entry, so the image is shown
- Change to the other tab
- Change back to the previous tab -> Exception

Hint: It looks like the Image size plays a role, becuse setting the Image to a smaller size doesn't cause the exception,
so maybe try to use a larger image if it doesn't happen on your device?


Bug #2 ImageSource Null
- Open MainPage.xaml and remove the MyNullConverter on the Image Binding
- Run on a Android (Tablet?) device
- Select the first list entry, so the image is shown
- Select the "Empty" entry -> Old ImageSource is still shown