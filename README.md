# how-to-change-the-selected-node-text-color-in-SfTreeView

This repository contains a sample demonstrating how to change the selected node text color in .NET MAUI TreeView (SfTreeView).

## Sample

```csharp
private void OnTreeView_SelectionChanging(object sender, Syncfusion.Maui.TreeView.ItemSelectionChangingEventArgs e)
{
    if (TreeView.SelectionMode == Syncfusion.Maui.TreeView.TreeViewSelectionMode.Single)
    {
        if (e.AddedItems.Count > 0)
        {
            var item = e.AddedItems[0] as FileManager;
            item.LabelColor = Colors.Red;
        }
        if (e.RemovedItems.Count > 0)
        {
            var item = e.RemovedItems[0] as FileManager;
            item.LabelColor = Colors.Black;
        }
    }
}
```
## Requirements to run the demo

To run the demo, refer to [System Requirements for .NET MAUI](https://help.syncfusion.com/maui/system-requirements).

Make sure that you have the compatible versions of [Visual Studio 2022](https://visualstudio.microsoft.com/downloads/ ) with the Dot NET MAUI workload and [.NET Core SDK 7.0](https://dotnet.microsoft.com/en-us/download/dotnet/7.0) or later version in your machine before starting to work on this project.

## Troubleshooting:
### Path too long exception

If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

## License

Syncfusion� has no liability for any damage or consequence that may arise from using or viewing the samples. The samples are for demonstrative purposes. If you choose to use or access the samples, you agree to not hold Syncfusion� liable, in any form, for any damage related to use, for accessing, or viewing the samples. By accessing, viewing, or seeing the samples, you acknowledge and agree Syncfusion�'s samples will not allow you seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize, or otherwise do anything with Syncfusion�'s samples.