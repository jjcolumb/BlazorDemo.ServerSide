The Flyout recalculates its position when certain page elements are changed (for instance, when the page is scrolled or resized).  Use the [RestrictionMode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxFlyout.RestrictionMode) property to restrict the Flyout position. 

In this demo, the [RestrictionMode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxFlyout.RestrictionMode) property is set to **TargetElement** and the flyout window position is restricted by the target element's boundaries ([RestrictionTarget](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxFlyout.RestrictionTarget)).

The [FitToRestriction](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxFlyout.FitToRestriction) property specifies whether the Flyout can overlap restriction boundaries. When the component does not meet the position restrictions, it can be hidden or closed, based on the [CloseMode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxFlyout.CloseMode) property value.
