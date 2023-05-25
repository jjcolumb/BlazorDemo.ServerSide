Our Blazor [Grid](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid) uses the standard [DataAnnotationsValidator](https://docs.microsoft.com/en-us/aspnet/core/blazor/forms-validation#data-annotations-validator-component-and-custom-validation-1) to validate user input (based on [data annotation attributes](https://docs.microsoft.com/en-us/aspnet/core/mvc/models/validation) defined in an edit model). Once a user removes focus from data editors or attempts to submit the edit form, editors are marked with colored outlines: green indicates valid values, red - invalid values.

When you define the [EditFormTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.EditFormTemplate), you can use any of the following approaches to display validation messages:

* Use the template context's `EditContext` property to access the validation message(s) and display it manually.
* Use Blazor's standard [ValidationMessage](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.components.forms.validationmessage-1) component to display messages for individual data editors.
* Use the [ValidationSummary](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.components.forms.validationsummary) component to summarize validation messages.

You can also implement your custom validator components and declare them in the [CustomValidators](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.CustomValidators) template. To disable input validation, set the [ValidationEnabled](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.ValidationEnabled) option to `false`.
