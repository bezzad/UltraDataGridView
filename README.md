# UltraDataGridView
A Win32 DataGridView by columns filtering features.

### How to Use:

1. Add the `UltraDataGridView.dll` to your references;

2. Add in using: `using UltraDataGridView;`

3. Add a UltraDataGridView control in a form and rename to dgv.

3. Add demo code for add data to grid:

	    dgv.Bounds = new Rectangle(10, 10, 445, 420);
	    dgv.Anchor = ((AnchorStyles)(((AnchorStyles.Top | AnchorStyles.Left) | AnchorStyles.Right | AnchorStyles.Bottom)));
	    dgv.AllowUserToAddRows = false;
	
	    var dt = new DataTable();
	    dt.Columns.Add("Number", typeof(int));
	    dt.Columns.Add("FirstName");
	    dt.Columns.Add("LastName");
	    dt.Columns.Add("Ver");
	    dt.Columns.Add("Date", typeof(DateTime));
	    dt.Rows.Add("1", "Behzad", "Khosravifar", "13.10.2011");
	    dt.Rows.Add("2", "Behzad kh", "Khosravi", "18.10.2012");
	    dt.Rows.Add("3", "Behzad", "Khosravifar", "13.10.2011");
	    dt.Rows.Add("4", "Behzad", "Khosravifar", "13.10.2011");
	    dt.Rows.Add("5", "Behzad", "Khosravifar", "13.10.2011");
	    dt.Rows.Add("6", "Behzad", "Khosravifar", "13.10.2014");
	    dt.Rows.Add("7", "Behzad", "Khosravifar", "13.10.2013");
	    dt.Rows.Add("8", "Behzad", "Khosravifar", "13.10.2011");
	    dt.Rows.Add("9", "Behzad", "Khosravifar", "13.10.2011");
	    dt.Rows.Add("10", "Behzad", "Khosravifar", "13.10.2011");
	    dt.Rows.Add("11", "Behzad kh", "Khosravi", "18.10.2012");
	
	    dgv.DataSource = dt;
		
		
		
### Screenshots
