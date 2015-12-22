using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Drawing;

namespace DataGridWithFilter
{
    public class DataGridFilterHeader : DataGridViewColumnHeaderCell
    {
        ComboBoxState _currentState = ComboBoxState.Normal;
        Point _cellLocation;
        Rectangle _buttonRect;
        private const int Width = 20;

        public event EventHandler<ColumnFilterClickedEventArg> FilterButtonClicked;

        protected override void OnDataGridViewChanged()
        {
            try
            {
                var dropDownPadding = new Padding(0, 0, 20, 0);
                this.Style.Padding = Padding.Add(this.InheritedStyle.Padding, dropDownPadding);
            }
            catch { }
            base.OnDataGridViewChanged();
        }
        protected override void Paint(Graphics graphics,
                                      Rectangle clipBounds,
                                      Rectangle cellBounds,
                                      int rowIndex,
                                      DataGridViewElementStates dataGridViewElementState,
                                      object value,
                                      object formattedValue,
                                      string errorText,
                                      DataGridViewCellStyle cellStyle,
                                      DataGridViewAdvancedBorderStyle advancedBorderStyle,
                                      DataGridViewPaintParts paintParts)
        {
            base.Paint(graphics, clipBounds,
                       cellBounds, rowIndex,
                       dataGridViewElementState, value,
                       formattedValue, errorText,
                       cellStyle, advancedBorderStyle, paintParts);

            _buttonRect = new Rectangle(cellBounds.X + cellBounds.Width - Width, cellBounds.Y, Width, cellBounds.Height);
            _cellLocation = cellBounds.Location;
            ComboBoxRenderer.DrawDropDownButton(graphics, _buttonRect, _currentState);
        }
        protected override void OnMouseDown(DataGridViewCellMouseEventArgs e)
        {
            if (this.IsMouseOverButton(e.Location))
                _currentState = ComboBoxState.Pressed;
            base.OnMouseDown(e);
        }
        protected override void OnMouseUp(DataGridViewCellMouseEventArgs e)
        {
            if (this.IsMouseOverButton(e.Location))
            {
                _currentState = ComboBoxState.Normal;
                this.OnFilterButtonClicked();
            }
            base.OnMouseUp(e);
        }
        private bool IsMouseOverButton(Point e)
        {
            var p = new Point(e.X + _cellLocation.X, e.Y + _cellLocation.Y);
            return p.X >= _buttonRect.X && p.X <= _buttonRect.X + _buttonRect.Width &&
                   p.Y >= _buttonRect.Y && p.Y <= _buttonRect.Y + _buttonRect.Height;
        }
        protected virtual void OnFilterButtonClicked()
        {
            if (this.FilterButtonClicked != null)
            {
                this.FilterButtonClicked(this, new ColumnFilterClickedEventArg(this.ColumnIndex, this._buttonRect));
            }
        }
    }
}
