using Syncfusion.UI.Xaml.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Syncfusion.UI.Xaml.Grid.Helpers;
namespace SelectionDemo
{
    /// <summary>
    /// Used to done the basic operation in SfdataGrid.
    /// </summary>
    public class SfDataGridExt : SfDataGrid
    {
        #region Ctor
        /// <summary>
        /// Initialize the instance of <see cref="SelectionDemo.SfDataGridExt"/> class.
        /// </summary>
        public SfDataGridExt() : base()
        {

        }
        #endregion Ctor

        #region Overrides
        /// <summary>
        /// Invoked when the <c>PreviewMouseUp</c> attached event reaches an element in its route that is derived from this class. 
        /// Implement this method to add class handling for this event.
        /// </summary>
        /// <param name="e">
        /// The <see cref="System.Windows.Input.MouseButtonEventArgs"/> that contains event data.
        /// </param>
        protected override void OnPreviewMouseDown(MouseButtonEventArgs e)
        {
            base.OnPreviewMouseDown(e);
            var dataGrid = e.Source as SfDataGridExt;
            var visualContainer = dataGrid.GetVisualContainer();
            var rowcolumnindex = visualContainer.PointToCellRowColumnIndex(e.GetPosition(visualContainer));
            if(rowcolumnindex.RowIndex == -1 || rowcolumnindex.RowIndex > 0 || rowcolumnindex.ColumnIndex == -1 || rowcolumnindex.ColumnIndex > 0)
            {
                return;
            }
            var viewModel = this.DataContext as ViewModel;
            if (this.SelectedItems.Count == 0)
            {
                foreach (var order in viewModel.OrderDetails)
                {
                    this.SelectedItems.Add(order);
                }
            }
            else
            {
                foreach (var order in viewModel.OrderDetails)
                {
                    this.SelectedItems.Remove(order);
                }

            }
        }
        #endregion Overrides
    }
}
