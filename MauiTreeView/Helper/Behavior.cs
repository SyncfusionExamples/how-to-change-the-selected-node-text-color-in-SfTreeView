using Syncfusion.Maui.TreeView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiTreeView
{
    public class Behavior : Behavior<SfTreeView>
    {
        SfTreeView TreeView;
        protected override void OnAttachedTo(SfTreeView treeView)
        {
            TreeView = treeView;
            TreeView.SelectionChanging += OnTreeView_SelectionChanging;
            base.OnAttachedTo(treeView);
        }
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
        protected override void OnDetachingFrom(SfTreeView bindable)
        {
            TreeView.SelectionChanging -= OnTreeView_SelectionChanging;
            TreeView = null;
            base.OnDetachingFrom(bindable);
        }
    }
}
