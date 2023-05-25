You can populate the DevExpress TreeView's nodes with data from a source. This demo demonstrates how to bind the TreeView to the collection of flat data items. 

The code above does the following: 

1. Uses the TreeView's [Data](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeView.Data) property to specify a data source. 
2. Adds the [\<DataMappings>](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeView.DataMappings) tag to the component markup. 
3. Creates the [DxTreeViewDataMapping](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeViewDataMapping) instance and maps [node properties](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeViewDataMapping._members#properties) to data source fields. Mappings are used to adjust the TreeView's data model to the data source. For flat data, the [Key](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.DxDataMappingBase-1.Key) and [ParentKey](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.DxDataMappingBase-1.ParentKey) properties are required. 
