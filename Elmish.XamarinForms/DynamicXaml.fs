namespace rec Elmish.XamarinForms.DynamicViews

#nowarn "67" // cast always holds

    /// Produce a new visual element with an adjusted attribute
[<AutoOpen>]
module XamlElementExtensions = 

    type XamlElement with

        /// Create a Xamarin.Forms.Element from the view description
        member x.CreateAsElement() : Xamarin.Forms.Element = (x.Create() :?> Xamarin.Forms.Element)

        /// Create a Xamarin.Forms.VisualElement from the view description
        member x.CreateAsVisualElement() : Xamarin.Forms.VisualElement = (x.Create() :?> Xamarin.Forms.VisualElement)

        /// Create a Xamarin.Forms.View from the view description
        member x.CreateAsView() : Xamarin.Forms.View = (x.Create() :?> Xamarin.Forms.View)

        /// Create a Xamarin.Forms.IGestureRecognizer from the view description
        member x.CreateAsIGestureRecognizer() : Xamarin.Forms.IGestureRecognizer = (x.Create() :?> Xamarin.Forms.IGestureRecognizer)

        /// Create a Xamarin.Forms.PanGestureRecognizer from the view description
        member x.CreateAsPanGestureRecognizer() : Xamarin.Forms.PanGestureRecognizer = (x.Create() :?> Xamarin.Forms.PanGestureRecognizer)

        /// Create a Xamarin.Forms.TapGestureRecognizer from the view description
        member x.CreateAsTapGestureRecognizer() : Xamarin.Forms.TapGestureRecognizer = (x.Create() :?> Xamarin.Forms.TapGestureRecognizer)

        /// Create a Xamarin.Forms.ClickGestureRecognizer from the view description
        member x.CreateAsClickGestureRecognizer() : Xamarin.Forms.ClickGestureRecognizer = (x.Create() :?> Xamarin.Forms.ClickGestureRecognizer)

        /// Create a Xamarin.Forms.PinchGestureRecognizer from the view description
        member x.CreateAsPinchGestureRecognizer() : Xamarin.Forms.PinchGestureRecognizer = (x.Create() :?> Xamarin.Forms.PinchGestureRecognizer)

        /// Create a Xamarin.Forms.ActivityIndicator from the view description
        member x.CreateAsActivityIndicator() : Xamarin.Forms.ActivityIndicator = (x.Create() :?> Xamarin.Forms.ActivityIndicator)

        /// Create a Xamarin.Forms.BoxView from the view description
        member x.CreateAsBoxView() : Xamarin.Forms.BoxView = (x.Create() :?> Xamarin.Forms.BoxView)

        /// Create a Xamarin.Forms.ProgressBar from the view description
        member x.CreateAsProgressBar() : Xamarin.Forms.ProgressBar = (x.Create() :?> Xamarin.Forms.ProgressBar)

        /// Create a Xamarin.Forms.ScrollView from the view description
        member x.CreateAsScrollView() : Xamarin.Forms.ScrollView = (x.Create() :?> Xamarin.Forms.ScrollView)

        /// Create a Xamarin.Forms.SearchBar from the view description
        member x.CreateAsSearchBar() : Xamarin.Forms.SearchBar = (x.Create() :?> Xamarin.Forms.SearchBar)

        /// Create a Xamarin.Forms.Button from the view description
        member x.CreateAsButton() : Xamarin.Forms.Button = (x.Create() :?> Xamarin.Forms.Button)

        /// Create a Xamarin.Forms.Slider from the view description
        member x.CreateAsSlider() : Xamarin.Forms.Slider = (x.Create() :?> Xamarin.Forms.Slider)

        /// Create a Xamarin.Forms.Stepper from the view description
        member x.CreateAsStepper() : Xamarin.Forms.Stepper = (x.Create() :?> Xamarin.Forms.Stepper)

        /// Create a Xamarin.Forms.Switch from the view description
        member x.CreateAsSwitch() : Xamarin.Forms.Switch = (x.Create() :?> Xamarin.Forms.Switch)

        /// Create a Xamarin.Forms.SwitchCell from the view description
        member x.CreateAsSwitchCell() : Xamarin.Forms.SwitchCell = (x.Create() :?> Xamarin.Forms.SwitchCell)

        /// Create a Xamarin.Forms.Grid from the view description
        member x.CreateAsGrid() : Xamarin.Forms.Grid = (x.Create() :?> Xamarin.Forms.Grid)

        /// Create a Xamarin.Forms.AbsoluteLayout from the view description
        member x.CreateAsAbsoluteLayout() : Xamarin.Forms.AbsoluteLayout = (x.Create() :?> Xamarin.Forms.AbsoluteLayout)

        /// Create a Xamarin.Forms.RelativeLayout from the view description
        member x.CreateAsRelativeLayout() : Xamarin.Forms.RelativeLayout = (x.Create() :?> Xamarin.Forms.RelativeLayout)

        /// Create a Xamarin.Forms.RowDefinition from the view description
        member x.CreateAsRowDefinition() : Xamarin.Forms.RowDefinition = (x.Create() :?> Xamarin.Forms.RowDefinition)

        /// Create a Xamarin.Forms.ColumnDefinition from the view description
        member x.CreateAsColumnDefinition() : Xamarin.Forms.ColumnDefinition = (x.Create() :?> Xamarin.Forms.ColumnDefinition)

        /// Create a Xamarin.Forms.ContentView from the view description
        member x.CreateAsContentView() : Xamarin.Forms.ContentView = (x.Create() :?> Xamarin.Forms.ContentView)

        /// Create a Xamarin.Forms.TemplatedView from the view description
        member x.CreateAsTemplatedView() : Xamarin.Forms.TemplatedView = (x.Create() :?> Xamarin.Forms.TemplatedView)

        /// Create a Xamarin.Forms.DatePicker from the view description
        member x.CreateAsDatePicker() : Xamarin.Forms.DatePicker = (x.Create() :?> Xamarin.Forms.DatePicker)

        /// Create a Xamarin.Forms.Picker from the view description
        member x.CreateAsPicker() : Xamarin.Forms.Picker = (x.Create() :?> Xamarin.Forms.Picker)

        /// Create a Xamarin.Forms.Frame from the view description
        member x.CreateAsFrame() : Xamarin.Forms.Frame = (x.Create() :?> Xamarin.Forms.Frame)

        /// Create a Xamarin.Forms.Image from the view description
        member x.CreateAsImage() : Xamarin.Forms.Image = (x.Create() :?> Xamarin.Forms.Image)

        /// Create a Xamarin.Forms.InputView from the view description
        member x.CreateAsInputView() : Xamarin.Forms.InputView = (x.Create() :?> Xamarin.Forms.InputView)

        /// Create a Xamarin.Forms.Editor from the view description
        member x.CreateAsEditor() : Xamarin.Forms.Editor = (x.Create() :?> Xamarin.Forms.Editor)

        /// Create a Xamarin.Forms.Entry from the view description
        member x.CreateAsEntry() : Xamarin.Forms.Entry = (x.Create() :?> Xamarin.Forms.Entry)

        /// Create a Xamarin.Forms.Label from the view description
        member x.CreateAsLabel() : Xamarin.Forms.Label = (x.Create() :?> Xamarin.Forms.Label)

        /// Create a Xamarin.Forms.Layout from the view description
        member x.CreateAsLayout() : Xamarin.Forms.Layout = (x.Create() :?> Xamarin.Forms.Layout)

        /// Create a Xamarin.Forms.StackLayout from the view description
        member x.CreateAsStackLayout() : Xamarin.Forms.StackLayout = (x.Create() :?> Xamarin.Forms.StackLayout)

        /// Create a Xamarin.Forms.Span from the view description
        member x.CreateAsSpan() : Xamarin.Forms.Span = (x.Create() :?> Xamarin.Forms.Span)

        /// Create a Xamarin.Forms.TimePicker from the view description
        member x.CreateAsTimePicker() : Xamarin.Forms.TimePicker = (x.Create() :?> Xamarin.Forms.TimePicker)

        /// Create a Xamarin.Forms.WebView from the view description
        member x.CreateAsWebView() : Xamarin.Forms.WebView = (x.Create() :?> Xamarin.Forms.WebView)

        /// Create a Xamarin.Forms.Page from the view description
        member x.CreateAsPage() : Xamarin.Forms.Page = (x.Create() :?> Xamarin.Forms.Page)

        /// Create a Xamarin.Forms.CarouselPage from the view description
        member x.CreateAsCarouselPage() : Xamarin.Forms.CarouselPage = (x.Create() :?> Xamarin.Forms.CarouselPage)

        /// Create a Xamarin.Forms.NavigationPage from the view description
        member x.CreateAsNavigationPage() : Xamarin.Forms.NavigationPage = (x.Create() :?> Xamarin.Forms.NavigationPage)

        /// Create a Xamarin.Forms.TabbedPage from the view description
        member x.CreateAsTabbedPage() : Xamarin.Forms.TabbedPage = (x.Create() :?> Xamarin.Forms.TabbedPage)

        /// Create a Xamarin.Forms.ContentPage from the view description
        member x.CreateAsContentPage() : Xamarin.Forms.ContentPage = (x.Create() :?> Xamarin.Forms.ContentPage)

        /// Create a Xamarin.Forms.MasterDetailPage from the view description
        member x.CreateAsMasterDetailPage() : Xamarin.Forms.MasterDetailPage = (x.Create() :?> Xamarin.Forms.MasterDetailPage)

        /// Create a Xamarin.Forms.Cell from the view description
        member x.CreateAsCell() : Xamarin.Forms.Cell = (x.Create() :?> Xamarin.Forms.Cell)

        /// Create a Xamarin.Forms.TextCell from the view description
        member x.CreateAsTextCell() : Xamarin.Forms.TextCell = (x.Create() :?> Xamarin.Forms.TextCell)

        /// Create a Xamarin.Forms.ImageCell from the view description
        member x.CreateAsImageCell() : Xamarin.Forms.ImageCell = (x.Create() :?> Xamarin.Forms.ImageCell)

        /// Create a Xamarin.Forms.ViewCell from the view description
        member x.CreateAsViewCell() : Xamarin.Forms.ViewCell = (x.Create() :?> Xamarin.Forms.ViewCell)

        /// Create a Xamarin.Forms.ListView from the view description
        member x.CreateAsListView() : Xamarin.Forms.ListView = (x.Create() :?> Xamarin.Forms.ListView)


        /// Try to get the ClassId property in the visual element
        member x.TryClassId = match x.Attributes.TryFind("ClassId") with Some v -> Some(unbox<string>(v)) | None -> None

        /// Try to get the StyleId property in the visual element
        member x.TryStyleId = match x.Attributes.TryFind("StyleId") with Some v -> Some(unbox<string>(v)) | None -> None

        /// Try to get the AnchorX property in the visual element
        member x.TryAnchorX = match x.Attributes.TryFind("AnchorX") with Some v -> Some(unbox<double>(v)) | None -> None

        /// Try to get the AnchorY property in the visual element
        member x.TryAnchorY = match x.Attributes.TryFind("AnchorY") with Some v -> Some(unbox<double>(v)) | None -> None

        /// Try to get the BackgroundColor property in the visual element
        member x.TryBackgroundColor = match x.Attributes.TryFind("BackgroundColor") with Some v -> Some(unbox<Xamarin.Forms.Color>(v)) | None -> None

        /// Try to get the HeightRequest property in the visual element
        member x.TryHeightRequest = match x.Attributes.TryFind("HeightRequest") with Some v -> Some(unbox<double>(v)) | None -> None

        /// Try to get the InputTransparent property in the visual element
        member x.TryInputTransparent = match x.Attributes.TryFind("InputTransparent") with Some v -> Some(unbox<bool>(v)) | None -> None

        /// Try to get the IsEnabled property in the visual element
        member x.TryIsEnabled = match x.Attributes.TryFind("IsEnabled") with Some v -> Some(unbox<bool>(v)) | None -> None

        /// Try to get the IsVisible property in the visual element
        member x.TryIsVisible = match x.Attributes.TryFind("IsVisible") with Some v -> Some(unbox<bool>(v)) | None -> None

        /// Try to get the MinimumHeightRequest property in the visual element
        member x.TryMinimumHeightRequest = match x.Attributes.TryFind("MinimumHeightRequest") with Some v -> Some(unbox<double>(v)) | None -> None

        /// Try to get the MinimumWidthRequest property in the visual element
        member x.TryMinimumWidthRequest = match x.Attributes.TryFind("MinimumWidthRequest") with Some v -> Some(unbox<double>(v)) | None -> None

        /// Try to get the Opacity property in the visual element
        member x.TryOpacity = match x.Attributes.TryFind("Opacity") with Some v -> Some(unbox<double>(v)) | None -> None

        /// Try to get the Rotation property in the visual element
        member x.TryRotation = match x.Attributes.TryFind("Rotation") with Some v -> Some(unbox<double>(v)) | None -> None

        /// Try to get the RotationX property in the visual element
        member x.TryRotationX = match x.Attributes.TryFind("RotationX") with Some v -> Some(unbox<double>(v)) | None -> None

        /// Try to get the RotationY property in the visual element
        member x.TryRotationY = match x.Attributes.TryFind("RotationY") with Some v -> Some(unbox<double>(v)) | None -> None

        /// Try to get the Scale property in the visual element
        member x.TryScale = match x.Attributes.TryFind("Scale") with Some v -> Some(unbox<double>(v)) | None -> None

        /// Try to get the Style property in the visual element
        member x.TryStyle = match x.Attributes.TryFind("Style") with Some v -> Some(unbox<Xamarin.Forms.Style>(v)) | None -> None

        /// Try to get the TranslationX property in the visual element
        member x.TryTranslationX = match x.Attributes.TryFind("TranslationX") with Some v -> Some(unbox<double>(v)) | None -> None

        /// Try to get the TranslationY property in the visual element
        member x.TryTranslationY = match x.Attributes.TryFind("TranslationY") with Some v -> Some(unbox<double>(v)) | None -> None

        /// Try to get the WidthRequest property in the visual element
        member x.TryWidthRequest = match x.Attributes.TryFind("WidthRequest") with Some v -> Some(unbox<double>(v)) | None -> None

        /// Try to get the HorizontalOptions property in the visual element
        member x.TryHorizontalOptions = match x.Attributes.TryFind("HorizontalOptions") with Some v -> Some(unbox<Xamarin.Forms.LayoutOptions>(v)) | None -> None

        /// Try to get the VerticalOptions property in the visual element
        member x.TryVerticalOptions = match x.Attributes.TryFind("VerticalOptions") with Some v -> Some(unbox<Xamarin.Forms.LayoutOptions>(v)) | None -> None

        /// Try to get the Margin property in the visual element
        member x.TryMargin = match x.Attributes.TryFind("Margin") with Some v -> Some(unbox<Xamarin.Forms.Thickness>(v)) | None -> None

        /// Try to get the GestureRecognizers property in the visual element
        member x.TryGestureRecognizers = match x.Attributes.TryFind("GestureRecognizers") with Some v -> Some(unbox<XamlElement[]>(v)) | None -> None

        /// Try to get the TouchPoints property in the visual element
        member x.TryTouchPoints = match x.Attributes.TryFind("TouchPoints") with Some v -> Some(unbox<int>(v)) | None -> None

        /// Try to get the PanUpdated property in the visual element
        member x.TryPanUpdated = match x.Attributes.TryFind("PanUpdated") with Some v -> Some(unbox<System.EventHandler<Xamarin.Forms.PanUpdatedEventArgs>>(v)) | None -> None

        /// Try to get the Command property in the visual element
        member x.TryCommand = match x.Attributes.TryFind("Command") with Some v -> Some(unbox<System.Windows.Input.ICommand>(v)) | None -> None

        /// Try to get the NumberOfTapsRequired property in the visual element
        member x.TryNumberOfTapsRequired = match x.Attributes.TryFind("NumberOfTapsRequired") with Some v -> Some(unbox<int>(v)) | None -> None

        /// Try to get the NumberOfClicksRequired property in the visual element
        member x.TryNumberOfClicksRequired = match x.Attributes.TryFind("NumberOfClicksRequired") with Some v -> Some(unbox<int>(v)) | None -> None

        /// Try to get the Buttons property in the visual element
        member x.TryButtons = match x.Attributes.TryFind("Buttons") with Some v -> Some(unbox<Xamarin.Forms.ButtonsMask>(v)) | None -> None

        /// Try to get the IsPinching property in the visual element
        member x.TryIsPinching = match x.Attributes.TryFind("IsPinching") with Some v -> Some(unbox<bool>(v)) | None -> None

        /// Try to get the PinchUpdated property in the visual element
        member x.TryPinchUpdated = match x.Attributes.TryFind("PinchUpdated") with Some v -> Some(unbox<System.EventHandler<Xamarin.Forms.PinchGestureUpdatedEventArgs>>(v)) | None -> None

        /// Try to get the Color property in the visual element
        member x.TryColor = match x.Attributes.TryFind("Color") with Some v -> Some(unbox<Xamarin.Forms.Color>(v)) | None -> None

        /// Try to get the IsRunning property in the visual element
        member x.TryIsRunning = match x.Attributes.TryFind("IsRunning") with Some v -> Some(unbox<bool>(v)) | None -> None

        /// Try to get the Progress property in the visual element
        member x.TryProgress = match x.Attributes.TryFind("Progress") with Some v -> Some(unbox<double>(v)) | None -> None

        /// Try to get the Content property in the visual element
        member x.TryContent = match x.Attributes.TryFind("Content") with Some v -> Some(unbox<XamlElement>(v)) | None -> None

        /// Try to get the ScrollOrientation property in the visual element
        member x.TryScrollOrientation = match x.Attributes.TryFind("ScrollOrientation") with Some v -> Some(unbox<Xamarin.Forms.ScrollOrientation>(v)) | None -> None

        /// Try to get the CancelButtonColor property in the visual element
        member x.TryCancelButtonColor = match x.Attributes.TryFind("CancelButtonColor") with Some v -> Some(unbox<Xamarin.Forms.Color>(v)) | None -> None

        /// Try to get the FontFamily property in the visual element
        member x.TryFontFamily = match x.Attributes.TryFind("FontFamily") with Some v -> Some(unbox<string>(v)) | None -> None

        /// Try to get the FontAttributes property in the visual element
        member x.TryFontAttributes = match x.Attributes.TryFind("FontAttributes") with Some v -> Some(unbox<Xamarin.Forms.FontAttributes>(v)) | None -> None

        /// Try to get the FontSize property in the visual element
        member x.TryFontSize = match x.Attributes.TryFind("FontSize") with Some v -> Some(unbox<double>(v)) | None -> None

        /// Try to get the HorizontalTextAlignment property in the visual element
        member x.TryHorizontalTextAlignment = match x.Attributes.TryFind("HorizontalTextAlignment") with Some v -> Some(unbox<Xamarin.Forms.TextAlignment>(v)) | None -> None

        /// Try to get the Placeholder property in the visual element
        member x.TryPlaceholder = match x.Attributes.TryFind("Placeholder") with Some v -> Some(unbox<string>(v)) | None -> None

        /// Try to get the PlaceholderColor property in the visual element
        member x.TryPlaceholderColor = match x.Attributes.TryFind("PlaceholderColor") with Some v -> Some(unbox<Xamarin.Forms.Color>(v)) | None -> None

        /// Try to get the SearchCommand property in the visual element
        member x.TrySearchCommand = match x.Attributes.TryFind("SearchCommand") with Some v -> Some(unbox<System.Windows.Input.ICommand>(v)) | None -> None

        /// Try to get the Text property in the visual element
        member x.TryText = match x.Attributes.TryFind("Text") with Some v -> Some(unbox<string>(v)) | None -> None

        /// Try to get the TextColor property in the visual element
        member x.TryTextColor = match x.Attributes.TryFind("TextColor") with Some v -> Some(unbox<Xamarin.Forms.Color>(v)) | None -> None

        /// Try to get the BorderColor property in the visual element
        member x.TryBorderColor = match x.Attributes.TryFind("BorderColor") with Some v -> Some(unbox<Xamarin.Forms.Color>(v)) | None -> None

        /// Try to get the BorderWidth property in the visual element
        member x.TryBorderWidth = match x.Attributes.TryFind("BorderWidth") with Some v -> Some(unbox<double>(v)) | None -> None

        /// Try to get the CommandParameter property in the visual element
        member x.TryCommandParameter = match x.Attributes.TryFind("CommandParameter") with Some v -> Some(unbox<System.Object>(v)) | None -> None

        /// Try to get the ContentLayout property in the visual element
        member x.TryContentLayout = match x.Attributes.TryFind("ContentLayout") with Some v -> Some(unbox<Xamarin.Forms.Button.ButtonContentLayout>(v)) | None -> None

        /// Try to get the ButtonCornerRadius property in the visual element
        member x.TryButtonCornerRadius = match x.Attributes.TryFind("ButtonCornerRadius") with Some v -> Some(unbox<int>(v)) | None -> None

        /// Try to get the ButtonImageSource property in the visual element
        member x.TryButtonImageSource = match x.Attributes.TryFind("ButtonImageSource") with Some v -> Some(unbox<Xamarin.Forms.FileImageSource>(v)) | None -> None

        /// Try to get the Minimum property in the visual element
        member x.TryMinimum = match x.Attributes.TryFind("Minimum") with Some v -> Some(unbox<double>(v)) | None -> None

        /// Try to get the Maximum property in the visual element
        member x.TryMaximum = match x.Attributes.TryFind("Maximum") with Some v -> Some(unbox<double>(v)) | None -> None

        /// Try to get the Value property in the visual element
        member x.TryValue = match x.Attributes.TryFind("Value") with Some v -> Some(unbox<double>(v)) | None -> None

        /// Try to get the ValueChanged property in the visual element
        member x.TryValueChanged = match x.Attributes.TryFind("ValueChanged") with Some v -> Some(unbox<System.EventHandler<Xamarin.Forms.ValueChangedEventArgs>>(v)) | None -> None

        /// Try to get the Increment property in the visual element
        member x.TryIncrement = match x.Attributes.TryFind("Increment") with Some v -> Some(unbox<double>(v)) | None -> None

        /// Try to get the IsToggled property in the visual element
        member x.TryIsToggled = match x.Attributes.TryFind("IsToggled") with Some v -> Some(unbox<bool>(v)) | None -> None

        /// Try to get the Toggled property in the visual element
        member x.TryToggled = match x.Attributes.TryFind("Toggled") with Some v -> Some(unbox<System.EventHandler<Xamarin.Forms.ToggledEventArgs>>(v)) | None -> None

        /// Try to get the On property in the visual element
        member x.TryOn = match x.Attributes.TryFind("On") with Some v -> Some(unbox<bool>(v)) | None -> None

        /// Try to get the OnChanged property in the visual element
        member x.TryOnChanged = match x.Attributes.TryFind("OnChanged") with Some v -> Some(unbox<System.EventHandler<Xamarin.Forms.ToggledEventArgs>>(v)) | None -> None

        /// Try to get the GridRowDefinitions property in the visual element
        member x.TryGridRowDefinitions = match x.Attributes.TryFind("GridRowDefinitions") with Some v -> Some(unbox<XamlElement[]>(v)) | None -> None

        /// Try to get the GridColumnDefinitions property in the visual element
        member x.TryGridColumnDefinitions = match x.Attributes.TryFind("GridColumnDefinitions") with Some v -> Some(unbox<XamlElement[]>(v)) | None -> None

        /// Try to get the RowSpacing property in the visual element
        member x.TryRowSpacing = match x.Attributes.TryFind("RowSpacing") with Some v -> Some(unbox<double>(v)) | None -> None

        /// Try to get the ColumnSpacing property in the visual element
        member x.TryColumnSpacing = match x.Attributes.TryFind("ColumnSpacing") with Some v -> Some(unbox<double>(v)) | None -> None

        /// Try to get the Children property in the visual element
        member x.TryChildren = match x.Attributes.TryFind("Children") with Some v -> Some(unbox<XamlElement[]>(v)) | None -> None

        /// Try to get the GridRow property in the visual element
        member x.TryGridRow = match x.Attributes.TryFind("GridRow") with Some v -> Some(unbox<int>(v)) | None -> None

        /// Try to get the GridRowSpan property in the visual element
        member x.TryGridRowSpan = match x.Attributes.TryFind("GridRowSpan") with Some v -> Some(unbox<int>(v)) | None -> None

        /// Try to get the GridColumn property in the visual element
        member x.TryGridColumn = match x.Attributes.TryFind("GridColumn") with Some v -> Some(unbox<int>(v)) | None -> None

        /// Try to get the GridColumnSpan property in the visual element
        member x.TryGridColumnSpan = match x.Attributes.TryFind("GridColumnSpan") with Some v -> Some(unbox<int>(v)) | None -> None

        /// Try to get the AbsoluteLayoutBounds property in the visual element
        member x.TryAbsoluteLayoutBounds = match x.Attributes.TryFind("AbsoluteLayoutBounds") with Some v -> Some(unbox<Xamarin.Forms.Rectangle>(v)) | None -> None

        /// Try to get the AbsoluteLayoutFlags property in the visual element
        member x.TryAbsoluteLayoutFlags = match x.Attributes.TryFind("AbsoluteLayoutFlags") with Some v -> Some(unbox<Xamarin.Forms.AbsoluteLayoutFlags>(v)) | None -> None

        /// Try to get the BoundsConstraint property in the visual element
        member x.TryBoundsConstraint = match x.Attributes.TryFind("BoundsConstraint") with Some v -> Some(unbox<Xamarin.Forms.BoundsConstraint>(v)) | None -> None

        /// Try to get the HeightConstraint property in the visual element
        member x.TryHeightConstraint = match x.Attributes.TryFind("HeightConstraint") with Some v -> Some(unbox<Xamarin.Forms.Constraint>(v)) | None -> None

        /// Try to get the WidthConstraint property in the visual element
        member x.TryWidthConstraint = match x.Attributes.TryFind("WidthConstraint") with Some v -> Some(unbox<Xamarin.Forms.Constraint>(v)) | None -> None

        /// Try to get the XConstraint property in the visual element
        member x.TryXConstraint = match x.Attributes.TryFind("XConstraint") with Some v -> Some(unbox<Xamarin.Forms.Constraint>(v)) | None -> None

        /// Try to get the YConstraint property in the visual element
        member x.TryYConstraint = match x.Attributes.TryFind("YConstraint") with Some v -> Some(unbox<Xamarin.Forms.Constraint>(v)) | None -> None

        /// Try to get the RowDefinitionHeight property in the visual element
        member x.TryRowDefinitionHeight = match x.Attributes.TryFind("RowDefinitionHeight") with Some v -> Some(unbox<Xamarin.Forms.GridLength>(v)) | None -> None

        /// Try to get the ColumnDefinitionWidth property in the visual element
        member x.TryColumnDefinitionWidth = match x.Attributes.TryFind("ColumnDefinitionWidth") with Some v -> Some(unbox<Xamarin.Forms.GridLength>(v)) | None -> None

        /// Try to get the Date property in the visual element
        member x.TryDate = match x.Attributes.TryFind("Date") with Some v -> Some(unbox<System.DateTime>(v)) | None -> None

        /// Try to get the Format property in the visual element
        member x.TryFormat = match x.Attributes.TryFind("Format") with Some v -> Some(unbox<string>(v)) | None -> None

        /// Try to get the MinimumDate property in the visual element
        member x.TryMinimumDate = match x.Attributes.TryFind("MinimumDate") with Some v -> Some(unbox<System.DateTime>(v)) | None -> None

        /// Try to get the MaximumDate property in the visual element
        member x.TryMaximumDate = match x.Attributes.TryFind("MaximumDate") with Some v -> Some(unbox<System.DateTime>(v)) | None -> None

        /// Try to get the DateSelected property in the visual element
        member x.TryDateSelected = match x.Attributes.TryFind("DateSelected") with Some v -> Some(unbox<System.EventHandler<Xamarin.Forms.DateChangedEventArgs>>(v)) | None -> None

        /// Try to get the PickerItemsSource property in the visual element
        member x.TryPickerItemsSource = match x.Attributes.TryFind("PickerItemsSource") with Some v -> Some(unbox<System.Collections.IList>(v)) | None -> None

        /// Try to get the SelectedIndex property in the visual element
        member x.TrySelectedIndex = match x.Attributes.TryFind("SelectedIndex") with Some v -> Some(unbox<int>(v)) | None -> None

        /// Try to get the Title property in the visual element
        member x.TryTitle = match x.Attributes.TryFind("Title") with Some v -> Some(unbox<string>(v)) | None -> None

        /// Try to get the SelectedIndexChanged property in the visual element
        member x.TrySelectedIndexChanged = match x.Attributes.TryFind("SelectedIndexChanged") with Some v -> Some(unbox<System.EventHandler>(v)) | None -> None

        /// Try to get the OutlineColor property in the visual element
        member x.TryOutlineColor = match x.Attributes.TryFind("OutlineColor") with Some v -> Some(unbox<Xamarin.Forms.Color>(v)) | None -> None

        /// Try to get the FrameCornerRadius property in the visual element
        member x.TryFrameCornerRadius = match x.Attributes.TryFind("FrameCornerRadius") with Some v -> Some(unbox<single>(v)) | None -> None

        /// Try to get the HasShadow property in the visual element
        member x.TryHasShadow = match x.Attributes.TryFind("HasShadow") with Some v -> Some(unbox<bool>(v)) | None -> None

        /// Try to get the ImageSource property in the visual element
        member x.TryImageSource = match x.Attributes.TryFind("ImageSource") with Some v -> Some(unbox<Xamarin.Forms.ImageSource>(v)) | None -> None

        /// Try to get the Aspect property in the visual element
        member x.TryAspect = match x.Attributes.TryFind("Aspect") with Some v -> Some(unbox<Xamarin.Forms.Aspect>(v)) | None -> None

        /// Try to get the IsOpaque property in the visual element
        member x.TryIsOpaque = match x.Attributes.TryFind("IsOpaque") with Some v -> Some(unbox<bool>(v)) | None -> None

        /// Try to get the Keyboard property in the visual element
        member x.TryKeyboard = match x.Attributes.TryFind("Keyboard") with Some v -> Some(unbox<Xamarin.Forms.Keyboard>(v)) | None -> None

        /// Try to get the EditorCompleted property in the visual element
        member x.TryEditorCompleted = match x.Attributes.TryFind("EditorCompleted") with Some v -> Some(unbox<System.EventHandler>(v)) | None -> None

        /// Try to get the TextChanged property in the visual element
        member x.TryTextChanged = match x.Attributes.TryFind("TextChanged") with Some v -> Some(unbox<System.EventHandler<Xamarin.Forms.TextChangedEventArgs>>(v)) | None -> None

        /// Try to get the IsPassword property in the visual element
        member x.TryIsPassword = match x.Attributes.TryFind("IsPassword") with Some v -> Some(unbox<bool>(v)) | None -> None

        /// Try to get the EntryCompleted property in the visual element
        member x.TryEntryCompleted = match x.Attributes.TryFind("EntryCompleted") with Some v -> Some(unbox<System.EventHandler>(v)) | None -> None

        /// Try to get the VerticalTextAlignment property in the visual element
        member x.TryVerticalTextAlignment = match x.Attributes.TryFind("VerticalTextAlignment") with Some v -> Some(unbox<Xamarin.Forms.TextAlignment>(v)) | None -> None

        /// Try to get the IsClippedToBounds property in the visual element
        member x.TryIsClippedToBounds = match x.Attributes.TryFind("IsClippedToBounds") with Some v -> Some(unbox<bool>(v)) | None -> None

        /// Try to get the Padding property in the visual element
        member x.TryPadding = match x.Attributes.TryFind("Padding") with Some v -> Some(unbox<Xamarin.Forms.Thickness>(v)) | None -> None

        /// Try to get the StackOrientation property in the visual element
        member x.TryStackOrientation = match x.Attributes.TryFind("StackOrientation") with Some v -> Some(unbox<Xamarin.Forms.StackOrientation>(v)) | None -> None

        /// Try to get the Spacing property in the visual element
        member x.TrySpacing = match x.Attributes.TryFind("Spacing") with Some v -> Some(unbox<double>(v)) | None -> None

        /// Try to get the ForegroundColor property in the visual element
        member x.TryForegroundColor = match x.Attributes.TryFind("ForegroundColor") with Some v -> Some(unbox<Xamarin.Forms.Color>(v)) | None -> None

        /// Try to get the PropertyChanged property in the visual element
        member x.TryPropertyChanged = match x.Attributes.TryFind("PropertyChanged") with Some v -> Some(unbox<System.ComponentModel.PropertyChangedEventHandler>(v)) | None -> None

        /// Try to get the Time property in the visual element
        member x.TryTime = match x.Attributes.TryFind("Time") with Some v -> Some(unbox<System.TimeSpan>(v)) | None -> None

        /// Try to get the WebSource property in the visual element
        member x.TryWebSource = match x.Attributes.TryFind("WebSource") with Some v -> Some(unbox<Xamarin.Forms.WebViewSource>(v)) | None -> None

        /// Try to get the Navigated property in the visual element
        member x.TryNavigated = match x.Attributes.TryFind("Navigated") with Some v -> Some(unbox<System.EventHandler<Xamarin.Forms.WebNavigatedEventArgs>>(v)) | None -> None

        /// Try to get the Navigating property in the visual element
        member x.TryNavigating = match x.Attributes.TryFind("Navigating") with Some v -> Some(unbox<System.EventHandler<Xamarin.Forms.WebNavigatingEventArgs>>(v)) | None -> None

        /// Try to get the ItemsSource property in the visual element
        member x.TryItemsSource = match x.Attributes.TryFind("ItemsSource") with Some v -> Some(unbox<System.Collections.Generic.IList<obj>>(v)) | None -> None

        /// Try to get the ItemTemplate property in the visual element
        member x.TryItemTemplate = match x.Attributes.TryFind("ItemTemplate") with Some v -> Some(unbox<Xamarin.Forms.DataTemplate>(v)) | None -> None

        /// Try to get the CarouselPage_SelectedItem property in the visual element
        member x.TryCarouselPage_SelectedItem = match x.Attributes.TryFind("CarouselPage_SelectedItem") with Some v -> Some(unbox<System.Object>(v)) | None -> None

        /// Try to get the CurrentPage property in the visual element
        member x.TryCurrentPage = match x.Attributes.TryFind("CurrentPage") with Some v -> Some(unbox<XamlElement>(v)) | None -> None

        /// Try to get the CurrentPageChanged property in the visual element
        member x.TryCurrentPageChanged = match x.Attributes.TryFind("CurrentPageChanged") with Some v -> Some(unbox<System.EventHandler>(v)) | None -> None

        /// Try to get the BarBackgroundColor property in the visual element
        member x.TryBarBackgroundColor = match x.Attributes.TryFind("BarBackgroundColor") with Some v -> Some(unbox<Xamarin.Forms.Color>(v)) | None -> None

        /// Try to get the BarTextColor property in the visual element
        member x.TryBarTextColor = match x.Attributes.TryFind("BarTextColor") with Some v -> Some(unbox<Xamarin.Forms.Color>(v)) | None -> None

        /// Try to get the Popped property in the visual element
        member x.TryPopped = match x.Attributes.TryFind("Popped") with Some v -> Some(unbox<System.EventHandler<Xamarin.Forms.NavigationEventArgs>>(v)) | None -> None

        /// Try to get the PoppedToRoot property in the visual element
        member x.TryPoppedToRoot = match x.Attributes.TryFind("PoppedToRoot") with Some v -> Some(unbox<System.EventHandler<Xamarin.Forms.NavigationEventArgs>>(v)) | None -> None

        /// Try to get the Pushed property in the visual element
        member x.TryPushed = match x.Attributes.TryFind("Pushed") with Some v -> Some(unbox<System.EventHandler<Xamarin.Forms.NavigationEventArgs>>(v)) | None -> None

        /// Try to get the Master property in the visual element
        member x.TryMaster = match x.Attributes.TryFind("Master") with Some v -> Some(unbox<XamlElement>(v)) | None -> None

        /// Try to get the Detail property in the visual element
        member x.TryDetail = match x.Attributes.TryFind("Detail") with Some v -> Some(unbox<XamlElement>(v)) | None -> None

        /// Try to get the IsGestureEnabled property in the visual element
        member x.TryIsGestureEnabled = match x.Attributes.TryFind("IsGestureEnabled") with Some v -> Some(unbox<bool>(v)) | None -> None

        /// Try to get the IsPresented property in the visual element
        member x.TryIsPresented = match x.Attributes.TryFind("IsPresented") with Some v -> Some(unbox<bool>(v)) | None -> None

        /// Try to get the MasterBehavior property in the visual element
        member x.TryMasterBehavior = match x.Attributes.TryFind("MasterBehavior") with Some v -> Some(unbox<Xamarin.Forms.MasterBehavior>(v)) | None -> None

        /// Try to get the IsPresentedChanged property in the visual element
        member x.TryIsPresentedChanged = match x.Attributes.TryFind("IsPresentedChanged") with Some v -> Some(unbox<System.EventHandler>(v)) | None -> None

        /// Try to get the Height property in the visual element
        member x.TryHeight = match x.Attributes.TryFind("Height") with Some v -> Some(unbox<double>(v)) | None -> None

        /// Try to get the TextDetail property in the visual element
        member x.TryTextDetail = match x.Attributes.TryFind("TextDetail") with Some v -> Some(unbox<string>(v)) | None -> None

        /// Try to get the TextDetailColor property in the visual element
        member x.TryTextDetailColor = match x.Attributes.TryFind("TextDetailColor") with Some v -> Some(unbox<Xamarin.Forms.Color>(v)) | None -> None

        /// Try to get the View property in the visual element
        member x.TryView = match x.Attributes.TryFind("View") with Some v -> Some(unbox<XamlElement>(v)) | None -> None

        /// Try to get the ListViewItems property in the visual element
        member x.TryListViewItems = match x.Attributes.TryFind("ListViewItems") with Some v -> Some(unbox<XamlElement[]>(v)) | None -> None

        /// Try to get the Footer property in the visual element
        member x.TryFooter = match x.Attributes.TryFind("Footer") with Some v -> Some(unbox<System.Object>(v)) | None -> None

        /// Try to get the HasUnevenRows property in the visual element
        member x.TryHasUnevenRows = match x.Attributes.TryFind("HasUnevenRows") with Some v -> Some(unbox<bool>(v)) | None -> None

        /// Try to get the Header property in the visual element
        member x.TryHeader = match x.Attributes.TryFind("Header") with Some v -> Some(unbox<System.Object>(v)) | None -> None

        /// Try to get the HeaderTemplate property in the visual element
        member x.TryHeaderTemplate = match x.Attributes.TryFind("HeaderTemplate") with Some v -> Some(unbox<Xamarin.Forms.DataTemplate>(v)) | None -> None

        /// Try to get the IsGroupingEnabled property in the visual element
        member x.TryIsGroupingEnabled = match x.Attributes.TryFind("IsGroupingEnabled") with Some v -> Some(unbox<bool>(v)) | None -> None

        /// Try to get the IsPullToRefreshEnabled property in the visual element
        member x.TryIsPullToRefreshEnabled = match x.Attributes.TryFind("IsPullToRefreshEnabled") with Some v -> Some(unbox<bool>(v)) | None -> None

        /// Try to get the IsRefreshing property in the visual element
        member x.TryIsRefreshing = match x.Attributes.TryFind("IsRefreshing") with Some v -> Some(unbox<bool>(v)) | None -> None

        /// Try to get the RefreshCommand property in the visual element
        member x.TryRefreshCommand = match x.Attributes.TryFind("RefreshCommand") with Some v -> Some(unbox<System.Windows.Input.ICommand>(v)) | None -> None

        /// Try to get the RowHeight property in the visual element
        member x.TryRowHeight = match x.Attributes.TryFind("RowHeight") with Some v -> Some(unbox<int>(v)) | None -> None

        /// Try to get the ListView_SelectedItem property in the visual element
        member x.TryListView_SelectedItem = match x.Attributes.TryFind("ListView_SelectedItem") with Some v -> Some(unbox<int option>(v)) | None -> None

        /// Try to get the SeparatorVisibility property in the visual element
        member x.TrySeparatorVisibility = match x.Attributes.TryFind("SeparatorVisibility") with Some v -> Some(unbox<Xamarin.Forms.SeparatorVisibility>(v)) | None -> None

        /// Try to get the SeparatorColor property in the visual element
        member x.TrySeparatorColor = match x.Attributes.TryFind("SeparatorColor") with Some v -> Some(unbox<Xamarin.Forms.Color>(v)) | None -> None

        /// Try to get the ItemAppearing property in the visual element
        member x.TryItemAppearing = match x.Attributes.TryFind("ItemAppearing") with Some v -> Some(unbox<System.EventHandler<Xamarin.Forms.ItemVisibilityEventArgs>>(v)) | None -> None

        /// Try to get the ItemDisappearing property in the visual element
        member x.TryItemDisappearing = match x.Attributes.TryFind("ItemDisappearing") with Some v -> Some(unbox<System.EventHandler<Xamarin.Forms.ItemVisibilityEventArgs>>(v)) | None -> None

        /// Try to get the ListView_ItemSelected property in the visual element
        member x.TryListView_ItemSelected = match x.Attributes.TryFind("ListView_ItemSelected") with Some v -> Some(unbox<System.EventHandler<Xamarin.Forms.SelectedItemChangedEventArgs>>(v)) | None -> None

        /// Try to get the ItemTapped property in the visual element
        member x.TryItemTapped = match x.Attributes.TryFind("ItemTapped") with Some v -> Some(unbox<System.EventHandler<Xamarin.Forms.ItemTappedEventArgs>>(v)) | None -> None

        /// Try to get the Refreshing property in the visual element
        member x.TryRefreshing = match x.Attributes.TryFind("Refreshing") with Some v -> Some(unbox<System.EventHandler>(v)) | None -> None

        /// Try to get the GroupListViewItemsSource property in the visual element
        member x.TryGroupListViewItemsSource = match x.Attributes.TryFind("GroupListViewItemsSource") with Some v -> Some(unbox<(XamlElement * XamlElement[])[]>(v)) | None -> None

        /// Try to get the ListViewGrouped_SelectedItem property in the visual element
        member x.TryListViewGrouped_SelectedItem = match x.Attributes.TryFind("ListViewGrouped_SelectedItem") with Some v -> Some(unbox<(int * int) option>(v)) | None -> None

        /// Try to get the ListViewGrouped_ItemSelected property in the visual element
        member x.TryListViewGrouped_ItemSelected = match x.Attributes.TryFind("ListViewGrouped_ItemSelected") with Some v -> Some(unbox<System.EventHandler<Xamarin.Forms.SelectedItemChangedEventArgs>>(v)) | None -> None

        /// Adjusts the ClassId property in the visual element
        member x.ClassId(value: string) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("ClassId", box ((value))))

        /// Adjusts the StyleId property in the visual element
        member x.StyleId(value: string) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("StyleId", box ((value))))

        /// Adjusts the AnchorX property in the visual element
        member x.AnchorX(value: double) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("AnchorX", box ((value))))

        /// Adjusts the AnchorY property in the visual element
        member x.AnchorY(value: double) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("AnchorY", box ((value))))

        /// Adjusts the BackgroundColor property in the visual element
        member x.BackgroundColor(value: Xamarin.Forms.Color) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("BackgroundColor", box ((value))))

        /// Adjusts the HeightRequest property in the visual element
        member x.HeightRequest(value: double) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("HeightRequest", box ((value))))

        /// Adjusts the InputTransparent property in the visual element
        member x.InputTransparent(value: bool) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("InputTransparent", box ((value))))

        /// Adjusts the IsEnabled property in the visual element
        member x.IsEnabled(value: bool) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("IsEnabled", box ((value))))

        /// Adjusts the IsVisible property in the visual element
        member x.IsVisible(value: bool) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("IsVisible", box ((value))))

        /// Adjusts the MinimumHeightRequest property in the visual element
        member x.MinimumHeightRequest(value: double) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("MinimumHeightRequest", box ((value))))

        /// Adjusts the MinimumWidthRequest property in the visual element
        member x.MinimumWidthRequest(value: double) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("MinimumWidthRequest", box ((value))))

        /// Adjusts the Opacity property in the visual element
        member x.Opacity(value: double) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("Opacity", box ((value))))

        /// Adjusts the Rotation property in the visual element
        member x.Rotation(value: double) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("Rotation", box ((value))))

        /// Adjusts the RotationX property in the visual element
        member x.RotationX(value: double) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("RotationX", box ((value))))

        /// Adjusts the RotationY property in the visual element
        member x.RotationY(value: double) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("RotationY", box ((value))))

        /// Adjusts the Scale property in the visual element
        member x.Scale(value: double) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("Scale", box ((value))))

        /// Adjusts the Style property in the visual element
        member x.Style(value: Xamarin.Forms.Style) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("Style", box ((value))))

        /// Adjusts the TranslationX property in the visual element
        member x.TranslationX(value: double) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("TranslationX", box ((value))))

        /// Adjusts the TranslationY property in the visual element
        member x.TranslationY(value: double) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("TranslationY", box ((value))))

        /// Adjusts the WidthRequest property in the visual element
        member x.WidthRequest(value: double) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("WidthRequest", box ((value))))

        /// Adjusts the HorizontalOptions property in the visual element
        member x.HorizontalOptions(value: Xamarin.Forms.LayoutOptions) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("HorizontalOptions", box ((value))))

        /// Adjusts the VerticalOptions property in the visual element
        member x.VerticalOptions(value: Xamarin.Forms.LayoutOptions) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("VerticalOptions", box ((value))))

        /// Adjusts the Margin property in the visual element
        member x.Margin(value: obj) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("Margin", box (makeThickness(value))))

        /// Adjusts the GestureRecognizers property in the visual element
        member x.GestureRecognizers(value: XamlElement list) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("GestureRecognizers", box (Array.ofList(value))))

        /// Adjusts the TouchPoints property in the visual element
        member x.TouchPoints(value: int) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("TouchPoints", box ((value))))

        /// Adjusts the PanUpdated property in the visual element
        member x.PanUpdated(value: Xamarin.Forms.PanUpdatedEventArgs -> unit) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("PanUpdated", box ((fun f -> System.EventHandler<Xamarin.Forms.PanUpdatedEventArgs>(fun _sender args -> f args))(value))))

        /// Adjusts the Command property in the visual element
        member x.Command(value: unit -> unit) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("Command", box (makeCommand(value))))

        /// Adjusts the NumberOfTapsRequired property in the visual element
        member x.NumberOfTapsRequired(value: int) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("NumberOfTapsRequired", box ((value))))

        /// Adjusts the NumberOfClicksRequired property in the visual element
        member x.NumberOfClicksRequired(value: int) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("NumberOfClicksRequired", box ((value))))

        /// Adjusts the Buttons property in the visual element
        member x.Buttons(value: Xamarin.Forms.ButtonsMask) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("Buttons", box ((value))))

        /// Adjusts the IsPinching property in the visual element
        member x.IsPinching(value: bool) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("IsPinching", box ((value))))

        /// Adjusts the PinchUpdated property in the visual element
        member x.PinchUpdated(value: Xamarin.Forms.PinchGestureUpdatedEventArgs -> unit) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("PinchUpdated", box ((fun f -> System.EventHandler<Xamarin.Forms.PinchGestureUpdatedEventArgs>(fun _sender args -> f args))(value))))

        /// Adjusts the Color property in the visual element
        member x.Color(value: Xamarin.Forms.Color) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("Color", box ((value))))

        /// Adjusts the IsRunning property in the visual element
        member x.IsRunning(value: bool) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("IsRunning", box ((value))))

        /// Adjusts the Progress property in the visual element
        member x.Progress(value: double) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("Progress", box ((value))))

        /// Adjusts the Content property in the visual element
        member x.Content(value: XamlElement) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("Content", box ((value))))

        /// Adjusts the ScrollOrientation property in the visual element
        member x.ScrollOrientation(value: Xamarin.Forms.ScrollOrientation) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("ScrollOrientation", box ((value))))

        /// Adjusts the CancelButtonColor property in the visual element
        member x.CancelButtonColor(value: Xamarin.Forms.Color) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("CancelButtonColor", box ((value))))

        /// Adjusts the FontFamily property in the visual element
        member x.FontFamily(value: string) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("FontFamily", box ((value))))

        /// Adjusts the FontAttributes property in the visual element
        member x.FontAttributes(value: Xamarin.Forms.FontAttributes) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("FontAttributes", box ((value))))

        /// Adjusts the FontSize property in the visual element
        member x.FontSize(value: obj) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("FontSize", box (makeFontSize(value))))

        /// Adjusts the HorizontalTextAlignment property in the visual element
        member x.HorizontalTextAlignment(value: Xamarin.Forms.TextAlignment) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("HorizontalTextAlignment", box ((value))))

        /// Adjusts the Placeholder property in the visual element
        member x.Placeholder(value: string) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("Placeholder", box ((value))))

        /// Adjusts the PlaceholderColor property in the visual element
        member x.PlaceholderColor(value: Xamarin.Forms.Color) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("PlaceholderColor", box ((value))))

        /// Adjusts the SearchCommand property in the visual element
        member x.SearchCommand(value: unit -> unit) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("SearchCommand", box (makeCommand(value))))

        /// Adjusts the Text property in the visual element
        member x.Text(value: string) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("Text", box ((value))))

        /// Adjusts the TextColor property in the visual element
        member x.TextColor(value: Xamarin.Forms.Color) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("TextColor", box ((value))))

        /// Adjusts the BorderColor property in the visual element
        member x.BorderColor(value: Xamarin.Forms.Color) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("BorderColor", box ((value))))

        /// Adjusts the BorderWidth property in the visual element
        member x.BorderWidth(value: double) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("BorderWidth", box ((value))))

        /// Adjusts the CommandParameter property in the visual element
        member x.CommandParameter(value: System.Object) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("CommandParameter", box ((value))))

        /// Adjusts the ContentLayout property in the visual element
        member x.ContentLayout(value: Xamarin.Forms.Button.ButtonContentLayout) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("ContentLayout", box ((value))))

        /// Adjusts the ButtonCornerRadius property in the visual element
        member x.ButtonCornerRadius(value: int) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("ButtonCornerRadius", box ((value))))

        /// Adjusts the ButtonImageSource property in the visual element
        member x.ButtonImageSource(value: string) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("ButtonImageSource", box (makeFileImageSource(value))))

        /// Adjusts the Minimum property in the visual element
        member x.Minimum(value: double) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("Minimum", box ((value))))

        /// Adjusts the Maximum property in the visual element
        member x.Maximum(value: double) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("Maximum", box ((value))))

        /// Adjusts the Value property in the visual element
        member x.Value(value: double) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("Value", box ((value))))

        /// Adjusts the ValueChanged property in the visual element
        member x.ValueChanged(value: Xamarin.Forms.ValueChangedEventArgs -> unit) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("ValueChanged", box ((fun f -> System.EventHandler<Xamarin.Forms.ValueChangedEventArgs>(fun _sender args -> f args))(value))))

        /// Adjusts the Increment property in the visual element
        member x.Increment(value: double) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("Increment", box ((value))))

        /// Adjusts the IsToggled property in the visual element
        member x.IsToggled(value: bool) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("IsToggled", box ((value))))

        /// Adjusts the Toggled property in the visual element
        member x.Toggled(value: Xamarin.Forms.ToggledEventArgs -> unit) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("Toggled", box ((fun f -> System.EventHandler<Xamarin.Forms.ToggledEventArgs>(fun _sender args -> f args))(value))))

        /// Adjusts the On property in the visual element
        member x.On(value: bool) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("On", box ((value))))

        /// Adjusts the OnChanged property in the visual element
        member x.OnChanged(value: Xamarin.Forms.ToggledEventArgs -> unit) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("OnChanged", box ((fun f -> System.EventHandler<Xamarin.Forms.ToggledEventArgs>(fun _sender args -> f args))(value))))

        /// Adjusts the GridRowDefinitions property in the visual element
        member x.GridRowDefinitions(value: obj list) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("GridRowDefinitions", box ((fun es -> es |> Array.ofList |> Array.map (fun h -> Xaml.RowDefinition(height=h)))(value))))

        /// Adjusts the GridColumnDefinitions property in the visual element
        member x.GridColumnDefinitions(value: obj list) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("GridColumnDefinitions", box ((fun es -> es |> Array.ofList |> Array.map (fun h -> Xaml.ColumnDefinition(width=h)))(value))))

        /// Adjusts the RowSpacing property in the visual element
        member x.RowSpacing(value: double) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("RowSpacing", box ((value))))

        /// Adjusts the ColumnSpacing property in the visual element
        member x.ColumnSpacing(value: double) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("ColumnSpacing", box ((value))))

        /// Adjusts the Children property in the visual element
        member x.Children(value: XamlElement list) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("Children", box (Array.ofList(value))))

        /// Adjusts the GridRow property in the visual element
        member x.GridRow(value: int) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("GridRow", box ((value))))

        /// Adjusts the GridRowSpan property in the visual element
        member x.GridRowSpan(value: int) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("GridRowSpan", box ((value))))

        /// Adjusts the GridColumn property in the visual element
        member x.GridColumn(value: int) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("GridColumn", box ((value))))

        /// Adjusts the GridColumnSpan property in the visual element
        member x.GridColumnSpan(value: int) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("GridColumnSpan", box ((value))))

        /// Adjusts the AbsoluteLayoutBounds property in the visual element
        member x.AbsoluteLayoutBounds(value: Xamarin.Forms.Rectangle) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("AbsoluteLayoutBounds", box ((value))))

        /// Adjusts the AbsoluteLayoutFlags property in the visual element
        member x.AbsoluteLayoutFlags(value: Xamarin.Forms.AbsoluteLayoutFlags) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("AbsoluteLayoutFlags", box ((value))))

        /// Adjusts the BoundsConstraint property in the visual element
        member x.BoundsConstraint(value: Xamarin.Forms.BoundsConstraint) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("BoundsConstraint", box ((value))))

        /// Adjusts the HeightConstraint property in the visual element
        member x.HeightConstraint(value: Xamarin.Forms.Constraint) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("HeightConstraint", box ((value))))

        /// Adjusts the WidthConstraint property in the visual element
        member x.WidthConstraint(value: Xamarin.Forms.Constraint) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("WidthConstraint", box ((value))))

        /// Adjusts the XConstraint property in the visual element
        member x.XConstraint(value: Xamarin.Forms.Constraint) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("XConstraint", box ((value))))

        /// Adjusts the YConstraint property in the visual element
        member x.YConstraint(value: Xamarin.Forms.Constraint) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("YConstraint", box ((value))))

        /// Adjusts the RowDefinitionHeight property in the visual element
        member x.RowDefinitionHeight(value: obj) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("RowDefinitionHeight", box (makeGridLength(value))))

        /// Adjusts the ColumnDefinitionWidth property in the visual element
        member x.ColumnDefinitionWidth(value: obj) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("ColumnDefinitionWidth", box (makeGridLength(value))))

        /// Adjusts the Date property in the visual element
        member x.Date(value: System.DateTime) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("Date", box ((value))))

        /// Adjusts the Format property in the visual element
        member x.Format(value: string) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("Format", box ((value))))

        /// Adjusts the MinimumDate property in the visual element
        member x.MinimumDate(value: System.DateTime) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("MinimumDate", box ((value))))

        /// Adjusts the MaximumDate property in the visual element
        member x.MaximumDate(value: System.DateTime) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("MaximumDate", box ((value))))

        /// Adjusts the DateSelected property in the visual element
        member x.DateSelected(value: Xamarin.Forms.DateChangedEventArgs -> unit) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("DateSelected", box ((fun f -> System.EventHandler<Xamarin.Forms.DateChangedEventArgs>(fun _sender args -> f args))(value))))

        /// Adjusts the PickerItemsSource property in the visual element
        member x.PickerItemsSource(value: 'T list) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("PickerItemsSource", box ((fun es -> es |> Array.ofList :> System.Collections.IList)(value))))

        /// Adjusts the SelectedIndex property in the visual element
        member x.SelectedIndex(value: int) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("SelectedIndex", box ((value))))

        /// Adjusts the Title property in the visual element
        member x.Title(value: string) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("Title", box ((value))))

        /// Adjusts the SelectedIndexChanged property in the visual element
        member x.SelectedIndexChanged(value: (int * 'T option) -> unit) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("SelectedIndexChanged", box ((fun f -> System.EventHandler(fun sender args -> let picker = (sender :?> Xamarin.Forms.Picker) in f (picker.SelectedIndex, (picker.SelectedItem |> Option.ofObj |> Option.map unbox<'T>))))(value))))

        /// Adjusts the OutlineColor property in the visual element
        member x.OutlineColor(value: Xamarin.Forms.Color) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("OutlineColor", box ((value))))

        /// Adjusts the FrameCornerRadius property in the visual element
        member x.FrameCornerRadius(value: single) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("FrameCornerRadius", box ((value))))

        /// Adjusts the HasShadow property in the visual element
        member x.HasShadow(value: bool) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("HasShadow", box ((value))))

        /// Adjusts the ImageSource property in the visual element
        member x.ImageSource(value: string) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("ImageSource", box (makeImageSource(value))))

        /// Adjusts the Aspect property in the visual element
        member x.Aspect(value: Xamarin.Forms.Aspect) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("Aspect", box ((value))))

        /// Adjusts the IsOpaque property in the visual element
        member x.IsOpaque(value: bool) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("IsOpaque", box ((value))))

        /// Adjusts the Keyboard property in the visual element
        member x.Keyboard(value: Xamarin.Forms.Keyboard) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("Keyboard", box ((value))))

        /// Adjusts the EditorCompleted property in the visual element
        member x.EditorCompleted(value: string -> unit) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("EditorCompleted", box ((fun f -> System.EventHandler(fun sender args -> f (sender :?> Xamarin.Forms.Editor).Text))(value))))

        /// Adjusts the TextChanged property in the visual element
        member x.TextChanged(value: Xamarin.Forms.TextChangedEventArgs -> unit) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("TextChanged", box ((fun f -> System.EventHandler<Xamarin.Forms.TextChangedEventArgs>(fun _sender args -> f args))(value))))

        /// Adjusts the IsPassword property in the visual element
        member x.IsPassword(value: bool) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("IsPassword", box ((value))))

        /// Adjusts the EntryCompleted property in the visual element
        member x.EntryCompleted(value: string -> unit) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("EntryCompleted", box ((fun f -> System.EventHandler(fun sender args -> f (sender :?> Xamarin.Forms.Entry).Text))(value))))

        /// Adjusts the VerticalTextAlignment property in the visual element
        member x.VerticalTextAlignment(value: Xamarin.Forms.TextAlignment) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("VerticalTextAlignment", box ((value))))

        /// Adjusts the IsClippedToBounds property in the visual element
        member x.IsClippedToBounds(value: bool) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("IsClippedToBounds", box ((value))))

        /// Adjusts the Padding property in the visual element
        member x.Padding(value: double) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("Padding", box (makeThickness(value))))

        /// Adjusts the StackOrientation property in the visual element
        member x.StackOrientation(value: Xamarin.Forms.StackOrientation) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("StackOrientation", box ((value))))

        /// Adjusts the Spacing property in the visual element
        member x.Spacing(value: double) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("Spacing", box ((value))))

        /// Adjusts the ForegroundColor property in the visual element
        member x.ForegroundColor(value: Xamarin.Forms.Color) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("ForegroundColor", box ((value))))

        /// Adjusts the PropertyChanged property in the visual element
        member x.PropertyChanged(value: System.ComponentModel.PropertyChangedEventArgs -> unit) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("PropertyChanged", box ((fun f -> System.EventHandler<System.ComponentModel.PropertyChangedEventArgs>(fun _sender args -> f args))(value))))

        /// Adjusts the Time property in the visual element
        member x.Time(value: System.TimeSpan) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("Time", box ((value))))

        /// Adjusts the WebSource property in the visual element
        member x.WebSource(value: Xamarin.Forms.WebViewSource) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("WebSource", box ((value))))

        /// Adjusts the Navigated property in the visual element
        member x.Navigated(value: Xamarin.Forms.WebNavigatedEventArgs -> unit) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("Navigated", box ((fun f -> System.EventHandler<Xamarin.Forms.WebNavigatedEventArgs>(fun _sender args -> f args))(value))))

        /// Adjusts the Navigating property in the visual element
        member x.Navigating(value: Xamarin.Forms.WebNavigatingEventArgs -> unit) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("Navigating", box ((fun f -> System.EventHandler<Xamarin.Forms.WebNavigatingEventArgs>(fun _sender args -> f args))(value))))

        /// Adjusts the ItemsSource property in the visual element
        member x.ItemsSource(value: 'T list) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("ItemsSource", box ((fun es -> es |> Array.ofList |> Array.map box :> System.Collections.Generic.IList<obj>)(value))))

        /// Adjusts the ItemTemplate property in the visual element
        member x.ItemTemplate(value: Xamarin.Forms.DataTemplate) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("ItemTemplate", box ((value))))

        /// Adjusts the CarouselPage_SelectedItem property in the visual element
        member x.CarouselPage_SelectedItem(value: System.Object) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("CarouselPage_SelectedItem", box ((value))))

        /// Adjusts the CurrentPage property in the visual element
        member x.CurrentPage(value: XamlElement) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("CurrentPage", box ((value))))

        /// Adjusts the CurrentPageChanged property in the visual element
        member x.CurrentPageChanged(value: 'T option -> unit) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("CurrentPageChanged", box ((fun f -> System.EventHandler(fun sender args -> f ((sender :?> Xamarin.Forms.CarouselPage).SelectedItem |> Option.ofObj |> Option.map unbox<'T>)))(value))))

        /// Adjusts the BarBackgroundColor property in the visual element
        member x.BarBackgroundColor(value: Xamarin.Forms.Color) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("BarBackgroundColor", box ((value))))

        /// Adjusts the BarTextColor property in the visual element
        member x.BarTextColor(value: Xamarin.Forms.Color) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("BarTextColor", box ((value))))

        /// Adjusts the Popped property in the visual element
        member x.Popped(value: Xamarin.Forms.NavigationEventArgs -> unit) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("Popped", box ((fun f -> System.EventHandler<Xamarin.Forms.NavigationEventArgs>(fun sender args -> f args))(value))))

        /// Adjusts the PoppedToRoot property in the visual element
        member x.PoppedToRoot(value: Xamarin.Forms.NavigationEventArgs -> unit) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("PoppedToRoot", box ((fun f -> System.EventHandler<Xamarin.Forms.NavigationEventArgs>(fun sender args -> f args))(value))))

        /// Adjusts the Pushed property in the visual element
        member x.Pushed(value: Xamarin.Forms.NavigationEventArgs -> unit) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("Pushed", box ((fun f -> System.EventHandler<Xamarin.Forms.NavigationEventArgs>(fun sender args -> f args))(value))))

        /// Adjusts the Master property in the visual element
        member x.Master(value: XamlElement) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("Master", box ((value))))

        /// Adjusts the Detail property in the visual element
        member x.Detail(value: XamlElement) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("Detail", box ((value))))

        /// Adjusts the IsGestureEnabled property in the visual element
        member x.IsGestureEnabled(value: bool) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("IsGestureEnabled", box ((value))))

        /// Adjusts the IsPresented property in the visual element
        member x.IsPresented(value: bool) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("IsPresented", box ((value))))

        /// Adjusts the MasterBehavior property in the visual element
        member x.MasterBehavior(value: Xamarin.Forms.MasterBehavior) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("MasterBehavior", box ((value))))

        /// Adjusts the IsPresentedChanged property in the visual element
        member x.IsPresentedChanged(value: bool -> unit) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("IsPresentedChanged", box ((fun f -> System.EventHandler(fun sender args -> f (sender :?> Xamarin.Forms.MasterDetailPage).IsPresented))(value))))

        /// Adjusts the Height property in the visual element
        member x.Height(value: double) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("Height", box ((value))))

        /// Adjusts the TextDetail property in the visual element
        member x.TextDetail(value: string) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("TextDetail", box ((value))))

        /// Adjusts the TextDetailColor property in the visual element
        member x.TextDetailColor(value: Xamarin.Forms.Color) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("TextDetailColor", box ((value))))

        /// Adjusts the View property in the visual element
        member x.View(value: XamlElement) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("View", box ((value))))

        /// Adjusts the ListViewItems property in the visual element
        member x.ListViewItems(value: XamlElement list) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("ListViewItems", box (Array.ofList(value))))

        /// Adjusts the Footer property in the visual element
        member x.Footer(value: System.Object) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("Footer", box ((value))))

        /// Adjusts the HasUnevenRows property in the visual element
        member x.HasUnevenRows(value: bool) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("HasUnevenRows", box ((value))))

        /// Adjusts the Header property in the visual element
        member x.Header(value: System.Object) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("Header", box ((value))))

        /// Adjusts the HeaderTemplate property in the visual element
        member x.HeaderTemplate(value: Xamarin.Forms.DataTemplate) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("HeaderTemplate", box ((value))))

        /// Adjusts the IsGroupingEnabled property in the visual element
        member x.IsGroupingEnabled(value: bool) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("IsGroupingEnabled", box ((value))))

        /// Adjusts the IsPullToRefreshEnabled property in the visual element
        member x.IsPullToRefreshEnabled(value: bool) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("IsPullToRefreshEnabled", box ((value))))

        /// Adjusts the IsRefreshing property in the visual element
        member x.IsRefreshing(value: bool) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("IsRefreshing", box ((value))))

        /// Adjusts the RefreshCommand property in the visual element
        member x.RefreshCommand(value: unit -> unit) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("RefreshCommand", box (makeCommand(value))))

        /// Adjusts the RowHeight property in the visual element
        member x.RowHeight(value: int) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("RowHeight", box ((value))))

        /// Adjusts the ListView_SelectedItem property in the visual element
        member x.ListView_SelectedItem(value: int option) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("ListView_SelectedItem", box ((value))))

        /// Adjusts the SeparatorVisibility property in the visual element
        member x.SeparatorVisibility(value: Xamarin.Forms.SeparatorVisibility) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("SeparatorVisibility", box ((value))))

        /// Adjusts the SeparatorColor property in the visual element
        member x.SeparatorColor(value: Xamarin.Forms.Color) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("SeparatorColor", box ((value))))

        /// Adjusts the ItemAppearing property in the visual element
        member x.ItemAppearing(value: Xamarin.Forms.ItemVisibilityEventArgs -> unit) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("ItemAppearing", box ((fun f -> System.EventHandler<Xamarin.Forms.ItemVisibilityEventArgs>(fun _sender args -> f args))(value))))

        /// Adjusts the ItemDisappearing property in the visual element
        member x.ItemDisappearing(value: Xamarin.Forms.ItemVisibilityEventArgs -> unit) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("ItemDisappearing", box ((fun f -> System.EventHandler<Xamarin.Forms.ItemVisibilityEventArgs>(fun _sender args -> f args))(value))))

        /// Adjusts the ListView_ItemSelected property in the visual element
        member x.ListView_ItemSelected(value: int option -> unit) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("ListView_ItemSelected", box ((fun f -> System.EventHandler<Xamarin.Forms.SelectedItemChangedEventArgs>(fun sender args -> f (args.SelectedItem |> Option.ofObj |> Option.map unbox<ListElementData<XamlElement>> |> Option.bind (fun item -> let items = (sender :?> Xamarin.Forms.ListView).ItemsSource :?> System.Collections.Generic.IList<ListElementData<XamlElement>> in items |> Seq.tryFindIndex (fun item2 -> System.Object.ReferenceEquals(item.Key, item2.Key))))))(value))))

        /// Adjusts the ItemTapped property in the visual element
        member x.ItemTapped(value: Xamarin.Forms.ItemTappedEventArgs -> unit) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("ItemTapped", box ((fun f -> System.EventHandler<Xamarin.Forms.ItemTappedEventArgs>(fun _sender args -> f args))(value))))

        /// Adjusts the Refreshing property in the visual element
        member x.Refreshing(value: unit -> unit) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("Refreshing", box ((fun f -> System.EventHandler(fun sender args -> f ()))(value))))

        /// Adjusts the GroupListViewItemsSource property in the visual element
        member x.GroupListViewItemsSource(value: (XamlElement * XamlElement list) list) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("GroupListViewItemsSource", box ((fun es -> es |> Array.ofList |> Array.map (fun (e,l) -> (e, Array.ofList l)))(value))))

        /// Adjusts the ListViewGrouped_SelectedItem property in the visual element
        member x.ListViewGrouped_SelectedItem(value: (int * int) option) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("ListViewGrouped_SelectedItem", box ((value))))

        /// Adjusts the ListViewGrouped_ItemSelected property in the visual element
        member x.ListViewGrouped_ItemSelected(value: (int * int) option -> unit) = XamlElement(x.TargetType, x.CreateMethod, x.ApplyMethod, x.Attributes.Add("ListViewGrouped_ItemSelected", box ((fun f -> System.EventHandler<Xamarin.Forms.SelectedItemChangedEventArgs>(fun sender args -> f (args.SelectedItem |> Option.ofObj |> Option.map unbox<ListElementData<XamlElement>> |> Option.bind (fun item -> let items = (sender :?> Xamarin.Forms.ListView).ItemsSource :?> System.Collections.Generic.IList<ListGroupData<XamlElement>> in Seq.indexed items |> Seq.tryPick (fun (i,items2) -> Seq.indexed items2 |> Seq.tryPick (fun (j,item2) -> if System.Object.ReferenceEquals(item.Key, item2.Key) then Some (i,j) else None))))))(value))))


    /// Adjusts the ClassId property in the visual element
    let withClassId (value: string) (x: XamlElement) = x.ClassId(value)

    /// Adjusts the ClassId property in the visual element
    let classId (value: string) (x: XamlElement) = x.ClassId(value)

    /// Adjusts the StyleId property in the visual element
    let withStyleId (value: string) (x: XamlElement) = x.StyleId(value)

    /// Adjusts the StyleId property in the visual element
    let styleId (value: string) (x: XamlElement) = x.StyleId(value)

    /// Adjusts the AnchorX property in the visual element
    let withAnchorX (value: double) (x: XamlElement) = x.AnchorX(value)

    /// Adjusts the AnchorX property in the visual element
    let anchorX (value: double) (x: XamlElement) = x.AnchorX(value)

    /// Adjusts the AnchorY property in the visual element
    let withAnchorY (value: double) (x: XamlElement) = x.AnchorY(value)

    /// Adjusts the AnchorY property in the visual element
    let anchorY (value: double) (x: XamlElement) = x.AnchorY(value)

    /// Adjusts the BackgroundColor property in the visual element
    let withBackgroundColor (value: Xamarin.Forms.Color) (x: XamlElement) = x.BackgroundColor(value)

    /// Adjusts the BackgroundColor property in the visual element
    let backgroundColor (value: Xamarin.Forms.Color) (x: XamlElement) = x.BackgroundColor(value)

    /// Adjusts the HeightRequest property in the visual element
    let withHeightRequest (value: double) (x: XamlElement) = x.HeightRequest(value)

    /// Adjusts the HeightRequest property in the visual element
    let heightRequest (value: double) (x: XamlElement) = x.HeightRequest(value)

    /// Adjusts the InputTransparent property in the visual element
    let withInputTransparent (value: bool) (x: XamlElement) = x.InputTransparent(value)

    /// Adjusts the InputTransparent property in the visual element
    let inputTransparent (value: bool) (x: XamlElement) = x.InputTransparent(value)

    /// Adjusts the IsEnabled property in the visual element
    let withIsEnabled (value: bool) (x: XamlElement) = x.IsEnabled(value)

    /// Adjusts the IsEnabled property in the visual element
    let isEnabled (value: bool) (x: XamlElement) = x.IsEnabled(value)

    /// Adjusts the IsVisible property in the visual element
    let withIsVisible (value: bool) (x: XamlElement) = x.IsVisible(value)

    /// Adjusts the IsVisible property in the visual element
    let isVisible (value: bool) (x: XamlElement) = x.IsVisible(value)

    /// Adjusts the MinimumHeightRequest property in the visual element
    let withMinimumHeightRequest (value: double) (x: XamlElement) = x.MinimumHeightRequest(value)

    /// Adjusts the MinimumHeightRequest property in the visual element
    let minimumHeightRequest (value: double) (x: XamlElement) = x.MinimumHeightRequest(value)

    /// Adjusts the MinimumWidthRequest property in the visual element
    let withMinimumWidthRequest (value: double) (x: XamlElement) = x.MinimumWidthRequest(value)

    /// Adjusts the MinimumWidthRequest property in the visual element
    let minimumWidthRequest (value: double) (x: XamlElement) = x.MinimumWidthRequest(value)

    /// Adjusts the Opacity property in the visual element
    let withOpacity (value: double) (x: XamlElement) = x.Opacity(value)

    /// Adjusts the Opacity property in the visual element
    let opacity (value: double) (x: XamlElement) = x.Opacity(value)

    /// Adjusts the Rotation property in the visual element
    let withRotation (value: double) (x: XamlElement) = x.Rotation(value)

    /// Adjusts the Rotation property in the visual element
    let rotation (value: double) (x: XamlElement) = x.Rotation(value)

    /// Adjusts the RotationX property in the visual element
    let withRotationX (value: double) (x: XamlElement) = x.RotationX(value)

    /// Adjusts the RotationX property in the visual element
    let rotationX (value: double) (x: XamlElement) = x.RotationX(value)

    /// Adjusts the RotationY property in the visual element
    let withRotationY (value: double) (x: XamlElement) = x.RotationY(value)

    /// Adjusts the RotationY property in the visual element
    let rotationY (value: double) (x: XamlElement) = x.RotationY(value)

    /// Adjusts the Scale property in the visual element
    let withScale (value: double) (x: XamlElement) = x.Scale(value)

    /// Adjusts the Scale property in the visual element
    let scale (value: double) (x: XamlElement) = x.Scale(value)

    /// Adjusts the Style property in the visual element
    let withStyle (value: Xamarin.Forms.Style) (x: XamlElement) = x.Style(value)

    /// Adjusts the Style property in the visual element
    let style (value: Xamarin.Forms.Style) (x: XamlElement) = x.Style(value)

    /// Adjusts the TranslationX property in the visual element
    let withTranslationX (value: double) (x: XamlElement) = x.TranslationX(value)

    /// Adjusts the TranslationX property in the visual element
    let translationX (value: double) (x: XamlElement) = x.TranslationX(value)

    /// Adjusts the TranslationY property in the visual element
    let withTranslationY (value: double) (x: XamlElement) = x.TranslationY(value)

    /// Adjusts the TranslationY property in the visual element
    let translationY (value: double) (x: XamlElement) = x.TranslationY(value)

    /// Adjusts the WidthRequest property in the visual element
    let withWidthRequest (value: double) (x: XamlElement) = x.WidthRequest(value)

    /// Adjusts the WidthRequest property in the visual element
    let widthRequest (value: double) (x: XamlElement) = x.WidthRequest(value)

    /// Adjusts the HorizontalOptions property in the visual element
    let withHorizontalOptions (value: Xamarin.Forms.LayoutOptions) (x: XamlElement) = x.HorizontalOptions(value)

    /// Adjusts the HorizontalOptions property in the visual element
    let horizontalOptions (value: Xamarin.Forms.LayoutOptions) (x: XamlElement) = x.HorizontalOptions(value)

    /// Adjusts the VerticalOptions property in the visual element
    let withVerticalOptions (value: Xamarin.Forms.LayoutOptions) (x: XamlElement) = x.VerticalOptions(value)

    /// Adjusts the VerticalOptions property in the visual element
    let verticalOptions (value: Xamarin.Forms.LayoutOptions) (x: XamlElement) = x.VerticalOptions(value)

    /// Adjusts the Margin property in the visual element
    let withMargin (value: obj) (x: XamlElement) = x.Margin(value)

    /// Adjusts the Margin property in the visual element
    let margin (value: obj) (x: XamlElement) = x.Margin(value)

    /// Adjusts the GestureRecognizers property in the visual element
    let withGestureRecognizers (value: XamlElement list) (x: XamlElement) = x.GestureRecognizers(value)

    /// Adjusts the GestureRecognizers property in the visual element
    let gestureRecognizers (value: XamlElement list) (x: XamlElement) = x.GestureRecognizers(value)

    /// Adjusts the TouchPoints property in the visual element
    let withTouchPoints (value: int) (x: XamlElement) = x.TouchPoints(value)

    /// Adjusts the TouchPoints property in the visual element
    let touchPoints (value: int) (x: XamlElement) = x.TouchPoints(value)

    /// Adjusts the PanUpdated property in the visual element
    let withPanUpdated (value: Xamarin.Forms.PanUpdatedEventArgs -> unit) (x: XamlElement) = x.PanUpdated(value)

    /// Adjusts the PanUpdated property in the visual element
    let panUpdated (value: Xamarin.Forms.PanUpdatedEventArgs -> unit) (x: XamlElement) = x.PanUpdated(value)

    /// Adjusts the Command property in the visual element
    let withCommand (value: unit -> unit) (x: XamlElement) = x.Command(value)

    /// Adjusts the Command property in the visual element
    let command (value: unit -> unit) (x: XamlElement) = x.Command(value)

    /// Adjusts the NumberOfTapsRequired property in the visual element
    let withNumberOfTapsRequired (value: int) (x: XamlElement) = x.NumberOfTapsRequired(value)

    /// Adjusts the NumberOfTapsRequired property in the visual element
    let numberOfTapsRequired (value: int) (x: XamlElement) = x.NumberOfTapsRequired(value)

    /// Adjusts the NumberOfClicksRequired property in the visual element
    let withNumberOfClicksRequired (value: int) (x: XamlElement) = x.NumberOfClicksRequired(value)

    /// Adjusts the NumberOfClicksRequired property in the visual element
    let numberOfClicksRequired (value: int) (x: XamlElement) = x.NumberOfClicksRequired(value)

    /// Adjusts the Buttons property in the visual element
    let withButtons (value: Xamarin.Forms.ButtonsMask) (x: XamlElement) = x.Buttons(value)

    /// Adjusts the Buttons property in the visual element
    let buttons (value: Xamarin.Forms.ButtonsMask) (x: XamlElement) = x.Buttons(value)

    /// Adjusts the IsPinching property in the visual element
    let withIsPinching (value: bool) (x: XamlElement) = x.IsPinching(value)

    /// Adjusts the IsPinching property in the visual element
    let isPinching (value: bool) (x: XamlElement) = x.IsPinching(value)

    /// Adjusts the PinchUpdated property in the visual element
    let withPinchUpdated (value: Xamarin.Forms.PinchGestureUpdatedEventArgs -> unit) (x: XamlElement) = x.PinchUpdated(value)

    /// Adjusts the PinchUpdated property in the visual element
    let pinchUpdated (value: Xamarin.Forms.PinchGestureUpdatedEventArgs -> unit) (x: XamlElement) = x.PinchUpdated(value)

    /// Adjusts the Color property in the visual element
    let withColor (value: Xamarin.Forms.Color) (x: XamlElement) = x.Color(value)

    /// Adjusts the Color property in the visual element
    let color (value: Xamarin.Forms.Color) (x: XamlElement) = x.Color(value)

    /// Adjusts the IsRunning property in the visual element
    let withIsRunning (value: bool) (x: XamlElement) = x.IsRunning(value)

    /// Adjusts the IsRunning property in the visual element
    let isRunning (value: bool) (x: XamlElement) = x.IsRunning(value)

    /// Adjusts the Progress property in the visual element
    let withProgress (value: double) (x: XamlElement) = x.Progress(value)

    /// Adjusts the Progress property in the visual element
    let progress (value: double) (x: XamlElement) = x.Progress(value)

    /// Adjusts the Content property in the visual element
    let withContent (value: XamlElement) (x: XamlElement) = x.Content(value)

    /// Adjusts the Content property in the visual element
    let content (value: XamlElement) (x: XamlElement) = x.Content(value)

    /// Adjusts the ScrollOrientation property in the visual element
    let withScrollOrientation (value: Xamarin.Forms.ScrollOrientation) (x: XamlElement) = x.ScrollOrientation(value)

    /// Adjusts the ScrollOrientation property in the visual element
    let scrollOrientation (value: Xamarin.Forms.ScrollOrientation) (x: XamlElement) = x.ScrollOrientation(value)

    /// Adjusts the CancelButtonColor property in the visual element
    let withCancelButtonColor (value: Xamarin.Forms.Color) (x: XamlElement) = x.CancelButtonColor(value)

    /// Adjusts the CancelButtonColor property in the visual element
    let cancelButtonColor (value: Xamarin.Forms.Color) (x: XamlElement) = x.CancelButtonColor(value)

    /// Adjusts the FontFamily property in the visual element
    let withFontFamily (value: string) (x: XamlElement) = x.FontFamily(value)

    /// Adjusts the FontFamily property in the visual element
    let fontFamily (value: string) (x: XamlElement) = x.FontFamily(value)

    /// Adjusts the FontAttributes property in the visual element
    let withFontAttributes (value: Xamarin.Forms.FontAttributes) (x: XamlElement) = x.FontAttributes(value)

    /// Adjusts the FontAttributes property in the visual element
    let fontAttributes (value: Xamarin.Forms.FontAttributes) (x: XamlElement) = x.FontAttributes(value)

    /// Adjusts the FontSize property in the visual element
    let withFontSize (value: obj) (x: XamlElement) = x.FontSize(value)

    /// Adjusts the FontSize property in the visual element
    let fontSize (value: obj) (x: XamlElement) = x.FontSize(value)

    /// Adjusts the HorizontalTextAlignment property in the visual element
    let withHorizontalTextAlignment (value: Xamarin.Forms.TextAlignment) (x: XamlElement) = x.HorizontalTextAlignment(value)

    /// Adjusts the HorizontalTextAlignment property in the visual element
    let horizontalTextAlignment (value: Xamarin.Forms.TextAlignment) (x: XamlElement) = x.HorizontalTextAlignment(value)

    /// Adjusts the Placeholder property in the visual element
    let withPlaceholder (value: string) (x: XamlElement) = x.Placeholder(value)

    /// Adjusts the Placeholder property in the visual element
    let placeholder (value: string) (x: XamlElement) = x.Placeholder(value)

    /// Adjusts the PlaceholderColor property in the visual element
    let withPlaceholderColor (value: Xamarin.Forms.Color) (x: XamlElement) = x.PlaceholderColor(value)

    /// Adjusts the PlaceholderColor property in the visual element
    let placeholderColor (value: Xamarin.Forms.Color) (x: XamlElement) = x.PlaceholderColor(value)

    /// Adjusts the SearchCommand property in the visual element
    let withSearchCommand (value: unit -> unit) (x: XamlElement) = x.SearchCommand(value)

    /// Adjusts the SearchCommand property in the visual element
    let searchCommand (value: unit -> unit) (x: XamlElement) = x.SearchCommand(value)

    /// Adjusts the Text property in the visual element
    let withText (value: string) (x: XamlElement) = x.Text(value)

    /// Adjusts the Text property in the visual element
    let text (value: string) (x: XamlElement) = x.Text(value)

    /// Adjusts the TextColor property in the visual element
    let withTextColor (value: Xamarin.Forms.Color) (x: XamlElement) = x.TextColor(value)

    /// Adjusts the TextColor property in the visual element
    let textColor (value: Xamarin.Forms.Color) (x: XamlElement) = x.TextColor(value)

    /// Adjusts the BorderColor property in the visual element
    let withBorderColor (value: Xamarin.Forms.Color) (x: XamlElement) = x.BorderColor(value)

    /// Adjusts the BorderColor property in the visual element
    let borderColor (value: Xamarin.Forms.Color) (x: XamlElement) = x.BorderColor(value)

    /// Adjusts the BorderWidth property in the visual element
    let withBorderWidth (value: double) (x: XamlElement) = x.BorderWidth(value)

    /// Adjusts the BorderWidth property in the visual element
    let borderWidth (value: double) (x: XamlElement) = x.BorderWidth(value)

    /// Adjusts the CommandParameter property in the visual element
    let withCommandParameter (value: System.Object) (x: XamlElement) = x.CommandParameter(value)

    /// Adjusts the CommandParameter property in the visual element
    let commandParameter (value: System.Object) (x: XamlElement) = x.CommandParameter(value)

    /// Adjusts the ContentLayout property in the visual element
    let withContentLayout (value: Xamarin.Forms.Button.ButtonContentLayout) (x: XamlElement) = x.ContentLayout(value)

    /// Adjusts the ContentLayout property in the visual element
    let contentLayout (value: Xamarin.Forms.Button.ButtonContentLayout) (x: XamlElement) = x.ContentLayout(value)

    /// Adjusts the ButtonCornerRadius property in the visual element
    let withButtonCornerRadius (value: int) (x: XamlElement) = x.ButtonCornerRadius(value)

    /// Adjusts the ButtonCornerRadius property in the visual element
    let buttonCornerRadius (value: int) (x: XamlElement) = x.ButtonCornerRadius(value)

    /// Adjusts the ButtonImageSource property in the visual element
    let withButtonImageSource (value: string) (x: XamlElement) = x.ButtonImageSource(value)

    /// Adjusts the ButtonImageSource property in the visual element
    let buttonImageSource (value: string) (x: XamlElement) = x.ButtonImageSource(value)

    /// Adjusts the Minimum property in the visual element
    let withMinimum (value: double) (x: XamlElement) = x.Minimum(value)

    /// Adjusts the Minimum property in the visual element
    let minimum (value: double) (x: XamlElement) = x.Minimum(value)

    /// Adjusts the Maximum property in the visual element
    let withMaximum (value: double) (x: XamlElement) = x.Maximum(value)

    /// Adjusts the Maximum property in the visual element
    let maximum (value: double) (x: XamlElement) = x.Maximum(value)

    /// Adjusts the Value property in the visual element
    let withValue (value: double) (x: XamlElement) = x.Value(value)

    /// Adjusts the Value property in the visual element
    let value (value: double) (x: XamlElement) = x.Value(value)

    /// Adjusts the ValueChanged property in the visual element
    let withValueChanged (value: Xamarin.Forms.ValueChangedEventArgs -> unit) (x: XamlElement) = x.ValueChanged(value)

    /// Adjusts the ValueChanged property in the visual element
    let valueChanged (value: Xamarin.Forms.ValueChangedEventArgs -> unit) (x: XamlElement) = x.ValueChanged(value)

    /// Adjusts the Increment property in the visual element
    let withIncrement (value: double) (x: XamlElement) = x.Increment(value)

    /// Adjusts the Increment property in the visual element
    let increment (value: double) (x: XamlElement) = x.Increment(value)

    /// Adjusts the IsToggled property in the visual element
    let withIsToggled (value: bool) (x: XamlElement) = x.IsToggled(value)

    /// Adjusts the IsToggled property in the visual element
    let isToggled (value: bool) (x: XamlElement) = x.IsToggled(value)

    /// Adjusts the Toggled property in the visual element
    let withToggled (value: Xamarin.Forms.ToggledEventArgs -> unit) (x: XamlElement) = x.Toggled(value)

    /// Adjusts the Toggled property in the visual element
    let toggled (value: Xamarin.Forms.ToggledEventArgs -> unit) (x: XamlElement) = x.Toggled(value)

    /// Adjusts the On property in the visual element
    let withOn (value: bool) (x: XamlElement) = x.On(value)

    /// Adjusts the On property in the visual element
    let on (value: bool) (x: XamlElement) = x.On(value)

    /// Adjusts the OnChanged property in the visual element
    let withOnChanged (value: Xamarin.Forms.ToggledEventArgs -> unit) (x: XamlElement) = x.OnChanged(value)

    /// Adjusts the OnChanged property in the visual element
    let onChanged (value: Xamarin.Forms.ToggledEventArgs -> unit) (x: XamlElement) = x.OnChanged(value)

    /// Adjusts the GridRowDefinitions property in the visual element
    let withGridRowDefinitions (value: obj list) (x: XamlElement) = x.GridRowDefinitions(value)

    /// Adjusts the GridRowDefinitions property in the visual element
    let gridRowDefinitions (value: obj list) (x: XamlElement) = x.GridRowDefinitions(value)

    /// Adjusts the GridColumnDefinitions property in the visual element
    let withGridColumnDefinitions (value: obj list) (x: XamlElement) = x.GridColumnDefinitions(value)

    /// Adjusts the GridColumnDefinitions property in the visual element
    let gridColumnDefinitions (value: obj list) (x: XamlElement) = x.GridColumnDefinitions(value)

    /// Adjusts the RowSpacing property in the visual element
    let withRowSpacing (value: double) (x: XamlElement) = x.RowSpacing(value)

    /// Adjusts the RowSpacing property in the visual element
    let rowSpacing (value: double) (x: XamlElement) = x.RowSpacing(value)

    /// Adjusts the ColumnSpacing property in the visual element
    let withColumnSpacing (value: double) (x: XamlElement) = x.ColumnSpacing(value)

    /// Adjusts the ColumnSpacing property in the visual element
    let columnSpacing (value: double) (x: XamlElement) = x.ColumnSpacing(value)

    /// Adjusts the Children property in the visual element
    let withChildren (value: XamlElement list) (x: XamlElement) = x.Children(value)

    /// Adjusts the Children property in the visual element
    let children (value: XamlElement list) (x: XamlElement) = x.Children(value)

    /// Adjusts the GridRow property in the visual element
    let withGridRow (value: int) (x: XamlElement) = x.GridRow(value)

    /// Adjusts the GridRow property in the visual element
    let gridRow (value: int) (x: XamlElement) = x.GridRow(value)

    /// Adjusts the GridRowSpan property in the visual element
    let withGridRowSpan (value: int) (x: XamlElement) = x.GridRowSpan(value)

    /// Adjusts the GridRowSpan property in the visual element
    let gridRowSpan (value: int) (x: XamlElement) = x.GridRowSpan(value)

    /// Adjusts the GridColumn property in the visual element
    let withGridColumn (value: int) (x: XamlElement) = x.GridColumn(value)

    /// Adjusts the GridColumn property in the visual element
    let gridColumn (value: int) (x: XamlElement) = x.GridColumn(value)

    /// Adjusts the GridColumnSpan property in the visual element
    let withGridColumnSpan (value: int) (x: XamlElement) = x.GridColumnSpan(value)

    /// Adjusts the GridColumnSpan property in the visual element
    let gridColumnSpan (value: int) (x: XamlElement) = x.GridColumnSpan(value)

    /// Adjusts the AbsoluteLayoutBounds property in the visual element
    let withAbsoluteLayoutBounds (value: Xamarin.Forms.Rectangle) (x: XamlElement) = x.AbsoluteLayoutBounds(value)

    /// Adjusts the AbsoluteLayoutBounds property in the visual element
    let absoluteLayoutBounds (value: Xamarin.Forms.Rectangle) (x: XamlElement) = x.AbsoluteLayoutBounds(value)

    /// Adjusts the AbsoluteLayoutFlags property in the visual element
    let withAbsoluteLayoutFlags (value: Xamarin.Forms.AbsoluteLayoutFlags) (x: XamlElement) = x.AbsoluteLayoutFlags(value)

    /// Adjusts the AbsoluteLayoutFlags property in the visual element
    let absoluteLayoutFlags (value: Xamarin.Forms.AbsoluteLayoutFlags) (x: XamlElement) = x.AbsoluteLayoutFlags(value)

    /// Adjusts the BoundsConstraint property in the visual element
    let withBoundsConstraint (value: Xamarin.Forms.BoundsConstraint) (x: XamlElement) = x.BoundsConstraint(value)

    /// Adjusts the BoundsConstraint property in the visual element
    let boundsConstraint (value: Xamarin.Forms.BoundsConstraint) (x: XamlElement) = x.BoundsConstraint(value)

    /// Adjusts the HeightConstraint property in the visual element
    let withHeightConstraint (value: Xamarin.Forms.Constraint) (x: XamlElement) = x.HeightConstraint(value)

    /// Adjusts the HeightConstraint property in the visual element
    let heightConstraint (value: Xamarin.Forms.Constraint) (x: XamlElement) = x.HeightConstraint(value)

    /// Adjusts the WidthConstraint property in the visual element
    let withWidthConstraint (value: Xamarin.Forms.Constraint) (x: XamlElement) = x.WidthConstraint(value)

    /// Adjusts the WidthConstraint property in the visual element
    let widthConstraint (value: Xamarin.Forms.Constraint) (x: XamlElement) = x.WidthConstraint(value)

    /// Adjusts the XConstraint property in the visual element
    let withXConstraint (value: Xamarin.Forms.Constraint) (x: XamlElement) = x.XConstraint(value)

    /// Adjusts the XConstraint property in the visual element
    let xConstraint (value: Xamarin.Forms.Constraint) (x: XamlElement) = x.XConstraint(value)

    /// Adjusts the YConstraint property in the visual element
    let withYConstraint (value: Xamarin.Forms.Constraint) (x: XamlElement) = x.YConstraint(value)

    /// Adjusts the YConstraint property in the visual element
    let yConstraint (value: Xamarin.Forms.Constraint) (x: XamlElement) = x.YConstraint(value)

    /// Adjusts the RowDefinitionHeight property in the visual element
    let withRowDefinitionHeight (value: obj) (x: XamlElement) = x.RowDefinitionHeight(value)

    /// Adjusts the RowDefinitionHeight property in the visual element
    let rowDefinitionHeight (value: obj) (x: XamlElement) = x.RowDefinitionHeight(value)

    /// Adjusts the ColumnDefinitionWidth property in the visual element
    let withColumnDefinitionWidth (value: obj) (x: XamlElement) = x.ColumnDefinitionWidth(value)

    /// Adjusts the ColumnDefinitionWidth property in the visual element
    let columnDefinitionWidth (value: obj) (x: XamlElement) = x.ColumnDefinitionWidth(value)

    /// Adjusts the Date property in the visual element
    let withDate (value: System.DateTime) (x: XamlElement) = x.Date(value)

    /// Adjusts the Date property in the visual element
    let date (value: System.DateTime) (x: XamlElement) = x.Date(value)

    /// Adjusts the Format property in the visual element
    let withFormat (value: string) (x: XamlElement) = x.Format(value)

    /// Adjusts the Format property in the visual element
    let format (value: string) (x: XamlElement) = x.Format(value)

    /// Adjusts the MinimumDate property in the visual element
    let withMinimumDate (value: System.DateTime) (x: XamlElement) = x.MinimumDate(value)

    /// Adjusts the MinimumDate property in the visual element
    let minimumDate (value: System.DateTime) (x: XamlElement) = x.MinimumDate(value)

    /// Adjusts the MaximumDate property in the visual element
    let withMaximumDate (value: System.DateTime) (x: XamlElement) = x.MaximumDate(value)

    /// Adjusts the MaximumDate property in the visual element
    let maximumDate (value: System.DateTime) (x: XamlElement) = x.MaximumDate(value)

    /// Adjusts the DateSelected property in the visual element
    let withDateSelected (value: Xamarin.Forms.DateChangedEventArgs -> unit) (x: XamlElement) = x.DateSelected(value)

    /// Adjusts the DateSelected property in the visual element
    let dateSelected (value: Xamarin.Forms.DateChangedEventArgs -> unit) (x: XamlElement) = x.DateSelected(value)

    /// Adjusts the PickerItemsSource property in the visual element
    let withPickerItemsSource (value: 'T list) (x: XamlElement) = x.PickerItemsSource(value)

    /// Adjusts the PickerItemsSource property in the visual element
    let pickerItemsSource (value: 'T list) (x: XamlElement) = x.PickerItemsSource(value)

    /// Adjusts the SelectedIndex property in the visual element
    let withSelectedIndex (value: int) (x: XamlElement) = x.SelectedIndex(value)

    /// Adjusts the SelectedIndex property in the visual element
    let selectedIndex (value: int) (x: XamlElement) = x.SelectedIndex(value)

    /// Adjusts the Title property in the visual element
    let withTitle (value: string) (x: XamlElement) = x.Title(value)

    /// Adjusts the Title property in the visual element
    let title (value: string) (x: XamlElement) = x.Title(value)

    /// Adjusts the SelectedIndexChanged property in the visual element
    let withSelectedIndexChanged (value: (int * 'T option) -> unit) (x: XamlElement) = x.SelectedIndexChanged(value)

    /// Adjusts the SelectedIndexChanged property in the visual element
    let selectedIndexChanged (value: (int * 'T option) -> unit) (x: XamlElement) = x.SelectedIndexChanged(value)

    /// Adjusts the OutlineColor property in the visual element
    let withOutlineColor (value: Xamarin.Forms.Color) (x: XamlElement) = x.OutlineColor(value)

    /// Adjusts the OutlineColor property in the visual element
    let outlineColor (value: Xamarin.Forms.Color) (x: XamlElement) = x.OutlineColor(value)

    /// Adjusts the FrameCornerRadius property in the visual element
    let withFrameCornerRadius (value: single) (x: XamlElement) = x.FrameCornerRadius(value)

    /// Adjusts the FrameCornerRadius property in the visual element
    let frameCornerRadius (value: single) (x: XamlElement) = x.FrameCornerRadius(value)

    /// Adjusts the HasShadow property in the visual element
    let withHasShadow (value: bool) (x: XamlElement) = x.HasShadow(value)

    /// Adjusts the HasShadow property in the visual element
    let hasShadow (value: bool) (x: XamlElement) = x.HasShadow(value)

    /// Adjusts the ImageSource property in the visual element
    let withImageSource (value: string) (x: XamlElement) = x.ImageSource(value)

    /// Adjusts the ImageSource property in the visual element
    let imageSource (value: string) (x: XamlElement) = x.ImageSource(value)

    /// Adjusts the Aspect property in the visual element
    let withAspect (value: Xamarin.Forms.Aspect) (x: XamlElement) = x.Aspect(value)

    /// Adjusts the Aspect property in the visual element
    let aspect (value: Xamarin.Forms.Aspect) (x: XamlElement) = x.Aspect(value)

    /// Adjusts the IsOpaque property in the visual element
    let withIsOpaque (value: bool) (x: XamlElement) = x.IsOpaque(value)

    /// Adjusts the IsOpaque property in the visual element
    let isOpaque (value: bool) (x: XamlElement) = x.IsOpaque(value)

    /// Adjusts the Keyboard property in the visual element
    let withKeyboard (value: Xamarin.Forms.Keyboard) (x: XamlElement) = x.Keyboard(value)

    /// Adjusts the Keyboard property in the visual element
    let keyboard (value: Xamarin.Forms.Keyboard) (x: XamlElement) = x.Keyboard(value)

    /// Adjusts the EditorCompleted property in the visual element
    let withEditorCompleted (value: string -> unit) (x: XamlElement) = x.EditorCompleted(value)

    /// Adjusts the EditorCompleted property in the visual element
    let editorCompleted (value: string -> unit) (x: XamlElement) = x.EditorCompleted(value)

    /// Adjusts the TextChanged property in the visual element
    let withTextChanged (value: Xamarin.Forms.TextChangedEventArgs -> unit) (x: XamlElement) = x.TextChanged(value)

    /// Adjusts the TextChanged property in the visual element
    let textChanged (value: Xamarin.Forms.TextChangedEventArgs -> unit) (x: XamlElement) = x.TextChanged(value)

    /// Adjusts the IsPassword property in the visual element
    let withIsPassword (value: bool) (x: XamlElement) = x.IsPassword(value)

    /// Adjusts the IsPassword property in the visual element
    let isPassword (value: bool) (x: XamlElement) = x.IsPassword(value)

    /// Adjusts the EntryCompleted property in the visual element
    let withEntryCompleted (value: string -> unit) (x: XamlElement) = x.EntryCompleted(value)

    /// Adjusts the EntryCompleted property in the visual element
    let entryCompleted (value: string -> unit) (x: XamlElement) = x.EntryCompleted(value)

    /// Adjusts the VerticalTextAlignment property in the visual element
    let withVerticalTextAlignment (value: Xamarin.Forms.TextAlignment) (x: XamlElement) = x.VerticalTextAlignment(value)

    /// Adjusts the VerticalTextAlignment property in the visual element
    let verticalTextAlignment (value: Xamarin.Forms.TextAlignment) (x: XamlElement) = x.VerticalTextAlignment(value)

    /// Adjusts the IsClippedToBounds property in the visual element
    let withIsClippedToBounds (value: bool) (x: XamlElement) = x.IsClippedToBounds(value)

    /// Adjusts the IsClippedToBounds property in the visual element
    let isClippedToBounds (value: bool) (x: XamlElement) = x.IsClippedToBounds(value)

    /// Adjusts the Padding property in the visual element
    let withPadding (value: double) (x: XamlElement) = x.Padding(value)

    /// Adjusts the Padding property in the visual element
    let padding (value: double) (x: XamlElement) = x.Padding(value)

    /// Adjusts the StackOrientation property in the visual element
    let withStackOrientation (value: Xamarin.Forms.StackOrientation) (x: XamlElement) = x.StackOrientation(value)

    /// Adjusts the StackOrientation property in the visual element
    let stackOrientation (value: Xamarin.Forms.StackOrientation) (x: XamlElement) = x.StackOrientation(value)

    /// Adjusts the Spacing property in the visual element
    let withSpacing (value: double) (x: XamlElement) = x.Spacing(value)

    /// Adjusts the Spacing property in the visual element
    let spacing (value: double) (x: XamlElement) = x.Spacing(value)

    /// Adjusts the ForegroundColor property in the visual element
    let withForegroundColor (value: Xamarin.Forms.Color) (x: XamlElement) = x.ForegroundColor(value)

    /// Adjusts the ForegroundColor property in the visual element
    let foregroundColor (value: Xamarin.Forms.Color) (x: XamlElement) = x.ForegroundColor(value)

    /// Adjusts the PropertyChanged property in the visual element
    let withPropertyChanged (value: System.ComponentModel.PropertyChangedEventArgs -> unit) (x: XamlElement) = x.PropertyChanged(value)

    /// Adjusts the PropertyChanged property in the visual element
    let propertyChanged (value: System.ComponentModel.PropertyChangedEventArgs -> unit) (x: XamlElement) = x.PropertyChanged(value)

    /// Adjusts the Time property in the visual element
    let withTime (value: System.TimeSpan) (x: XamlElement) = x.Time(value)

    /// Adjusts the Time property in the visual element
    let time (value: System.TimeSpan) (x: XamlElement) = x.Time(value)

    /// Adjusts the WebSource property in the visual element
    let withWebSource (value: Xamarin.Forms.WebViewSource) (x: XamlElement) = x.WebSource(value)

    /// Adjusts the WebSource property in the visual element
    let webSource (value: Xamarin.Forms.WebViewSource) (x: XamlElement) = x.WebSource(value)

    /// Adjusts the Navigated property in the visual element
    let withNavigated (value: Xamarin.Forms.WebNavigatedEventArgs -> unit) (x: XamlElement) = x.Navigated(value)

    /// Adjusts the Navigated property in the visual element
    let navigated (value: Xamarin.Forms.WebNavigatedEventArgs -> unit) (x: XamlElement) = x.Navigated(value)

    /// Adjusts the Navigating property in the visual element
    let withNavigating (value: Xamarin.Forms.WebNavigatingEventArgs -> unit) (x: XamlElement) = x.Navigating(value)

    /// Adjusts the Navigating property in the visual element
    let navigating (value: Xamarin.Forms.WebNavigatingEventArgs -> unit) (x: XamlElement) = x.Navigating(value)

    /// Adjusts the ItemsSource property in the visual element
    let withItemsSource (value: 'T list) (x: XamlElement) = x.ItemsSource(value)

    /// Adjusts the ItemsSource property in the visual element
    let itemsSource (value: 'T list) (x: XamlElement) = x.ItemsSource(value)

    /// Adjusts the ItemTemplate property in the visual element
    let withItemTemplate (value: Xamarin.Forms.DataTemplate) (x: XamlElement) = x.ItemTemplate(value)

    /// Adjusts the ItemTemplate property in the visual element
    let itemTemplate (value: Xamarin.Forms.DataTemplate) (x: XamlElement) = x.ItemTemplate(value)

    /// Adjusts the CarouselPage_SelectedItem property in the visual element
    let withCarouselPage_SelectedItem (value: System.Object) (x: XamlElement) = x.CarouselPage_SelectedItem(value)

    /// Adjusts the CarouselPage_SelectedItem property in the visual element
    let carouselPage_SelectedItem (value: System.Object) (x: XamlElement) = x.CarouselPage_SelectedItem(value)

    /// Adjusts the CurrentPage property in the visual element
    let withCurrentPage (value: XamlElement) (x: XamlElement) = x.CurrentPage(value)

    /// Adjusts the CurrentPage property in the visual element
    let currentPage (value: XamlElement) (x: XamlElement) = x.CurrentPage(value)

    /// Adjusts the CurrentPageChanged property in the visual element
    let withCurrentPageChanged (value: 'T option -> unit) (x: XamlElement) = x.CurrentPageChanged(value)

    /// Adjusts the CurrentPageChanged property in the visual element
    let currentPageChanged (value: 'T option -> unit) (x: XamlElement) = x.CurrentPageChanged(value)

    /// Adjusts the BarBackgroundColor property in the visual element
    let withBarBackgroundColor (value: Xamarin.Forms.Color) (x: XamlElement) = x.BarBackgroundColor(value)

    /// Adjusts the BarBackgroundColor property in the visual element
    let barBackgroundColor (value: Xamarin.Forms.Color) (x: XamlElement) = x.BarBackgroundColor(value)

    /// Adjusts the BarTextColor property in the visual element
    let withBarTextColor (value: Xamarin.Forms.Color) (x: XamlElement) = x.BarTextColor(value)

    /// Adjusts the BarTextColor property in the visual element
    let barTextColor (value: Xamarin.Forms.Color) (x: XamlElement) = x.BarTextColor(value)

    /// Adjusts the Popped property in the visual element
    let withPopped (value: Xamarin.Forms.NavigationEventArgs -> unit) (x: XamlElement) = x.Popped(value)

    /// Adjusts the Popped property in the visual element
    let popped (value: Xamarin.Forms.NavigationEventArgs -> unit) (x: XamlElement) = x.Popped(value)

    /// Adjusts the PoppedToRoot property in the visual element
    let withPoppedToRoot (value: Xamarin.Forms.NavigationEventArgs -> unit) (x: XamlElement) = x.PoppedToRoot(value)

    /// Adjusts the PoppedToRoot property in the visual element
    let poppedToRoot (value: Xamarin.Forms.NavigationEventArgs -> unit) (x: XamlElement) = x.PoppedToRoot(value)

    /// Adjusts the Pushed property in the visual element
    let withPushed (value: Xamarin.Forms.NavigationEventArgs -> unit) (x: XamlElement) = x.Pushed(value)

    /// Adjusts the Pushed property in the visual element
    let pushed (value: Xamarin.Forms.NavigationEventArgs -> unit) (x: XamlElement) = x.Pushed(value)

    /// Adjusts the Master property in the visual element
    let withMaster (value: XamlElement) (x: XamlElement) = x.Master(value)

    /// Adjusts the Master property in the visual element
    let master (value: XamlElement) (x: XamlElement) = x.Master(value)

    /// Adjusts the Detail property in the visual element
    let withDetail (value: XamlElement) (x: XamlElement) = x.Detail(value)

    /// Adjusts the Detail property in the visual element
    let detail (value: XamlElement) (x: XamlElement) = x.Detail(value)

    /// Adjusts the IsGestureEnabled property in the visual element
    let withIsGestureEnabled (value: bool) (x: XamlElement) = x.IsGestureEnabled(value)

    /// Adjusts the IsGestureEnabled property in the visual element
    let isGestureEnabled (value: bool) (x: XamlElement) = x.IsGestureEnabled(value)

    /// Adjusts the IsPresented property in the visual element
    let withIsPresented (value: bool) (x: XamlElement) = x.IsPresented(value)

    /// Adjusts the IsPresented property in the visual element
    let isPresented (value: bool) (x: XamlElement) = x.IsPresented(value)

    /// Adjusts the MasterBehavior property in the visual element
    let withMasterBehavior (value: Xamarin.Forms.MasterBehavior) (x: XamlElement) = x.MasterBehavior(value)

    /// Adjusts the MasterBehavior property in the visual element
    let masterBehavior (value: Xamarin.Forms.MasterBehavior) (x: XamlElement) = x.MasterBehavior(value)

    /// Adjusts the IsPresentedChanged property in the visual element
    let withIsPresentedChanged (value: bool -> unit) (x: XamlElement) = x.IsPresentedChanged(value)

    /// Adjusts the IsPresentedChanged property in the visual element
    let isPresentedChanged (value: bool -> unit) (x: XamlElement) = x.IsPresentedChanged(value)

    /// Adjusts the Height property in the visual element
    let withHeight (value: double) (x: XamlElement) = x.Height(value)

    /// Adjusts the Height property in the visual element
    let height (value: double) (x: XamlElement) = x.Height(value)

    /// Adjusts the TextDetail property in the visual element
    let withTextDetail (value: string) (x: XamlElement) = x.TextDetail(value)

    /// Adjusts the TextDetail property in the visual element
    let textDetail (value: string) (x: XamlElement) = x.TextDetail(value)

    /// Adjusts the TextDetailColor property in the visual element
    let withTextDetailColor (value: Xamarin.Forms.Color) (x: XamlElement) = x.TextDetailColor(value)

    /// Adjusts the TextDetailColor property in the visual element
    let textDetailColor (value: Xamarin.Forms.Color) (x: XamlElement) = x.TextDetailColor(value)

    /// Adjusts the View property in the visual element
    let withView (value: XamlElement) (x: XamlElement) = x.View(value)

    /// Adjusts the View property in the visual element
    let view (value: XamlElement) (x: XamlElement) = x.View(value)

    /// Adjusts the ListViewItems property in the visual element
    let withListViewItems (value: XamlElement list) (x: XamlElement) = x.ListViewItems(value)

    /// Adjusts the ListViewItems property in the visual element
    let listViewItems (value: XamlElement list) (x: XamlElement) = x.ListViewItems(value)

    /// Adjusts the Footer property in the visual element
    let withFooter (value: System.Object) (x: XamlElement) = x.Footer(value)

    /// Adjusts the Footer property in the visual element
    let footer (value: System.Object) (x: XamlElement) = x.Footer(value)

    /// Adjusts the HasUnevenRows property in the visual element
    let withHasUnevenRows (value: bool) (x: XamlElement) = x.HasUnevenRows(value)

    /// Adjusts the HasUnevenRows property in the visual element
    let hasUnevenRows (value: bool) (x: XamlElement) = x.HasUnevenRows(value)

    /// Adjusts the Header property in the visual element
    let withHeader (value: System.Object) (x: XamlElement) = x.Header(value)

    /// Adjusts the Header property in the visual element
    let header (value: System.Object) (x: XamlElement) = x.Header(value)

    /// Adjusts the HeaderTemplate property in the visual element
    let withHeaderTemplate (value: Xamarin.Forms.DataTemplate) (x: XamlElement) = x.HeaderTemplate(value)

    /// Adjusts the HeaderTemplate property in the visual element
    let headerTemplate (value: Xamarin.Forms.DataTemplate) (x: XamlElement) = x.HeaderTemplate(value)

    /// Adjusts the IsGroupingEnabled property in the visual element
    let withIsGroupingEnabled (value: bool) (x: XamlElement) = x.IsGroupingEnabled(value)

    /// Adjusts the IsGroupingEnabled property in the visual element
    let isGroupingEnabled (value: bool) (x: XamlElement) = x.IsGroupingEnabled(value)

    /// Adjusts the IsPullToRefreshEnabled property in the visual element
    let withIsPullToRefreshEnabled (value: bool) (x: XamlElement) = x.IsPullToRefreshEnabled(value)

    /// Adjusts the IsPullToRefreshEnabled property in the visual element
    let isPullToRefreshEnabled (value: bool) (x: XamlElement) = x.IsPullToRefreshEnabled(value)

    /// Adjusts the IsRefreshing property in the visual element
    let withIsRefreshing (value: bool) (x: XamlElement) = x.IsRefreshing(value)

    /// Adjusts the IsRefreshing property in the visual element
    let isRefreshing (value: bool) (x: XamlElement) = x.IsRefreshing(value)

    /// Adjusts the RefreshCommand property in the visual element
    let withRefreshCommand (value: unit -> unit) (x: XamlElement) = x.RefreshCommand(value)

    /// Adjusts the RefreshCommand property in the visual element
    let refreshCommand (value: unit -> unit) (x: XamlElement) = x.RefreshCommand(value)

    /// Adjusts the RowHeight property in the visual element
    let withRowHeight (value: int) (x: XamlElement) = x.RowHeight(value)

    /// Adjusts the RowHeight property in the visual element
    let rowHeight (value: int) (x: XamlElement) = x.RowHeight(value)

    /// Adjusts the ListView_SelectedItem property in the visual element
    let withListView_SelectedItem (value: int option) (x: XamlElement) = x.ListView_SelectedItem(value)

    /// Adjusts the ListView_SelectedItem property in the visual element
    let listView_SelectedItem (value: int option) (x: XamlElement) = x.ListView_SelectedItem(value)

    /// Adjusts the SeparatorVisibility property in the visual element
    let withSeparatorVisibility (value: Xamarin.Forms.SeparatorVisibility) (x: XamlElement) = x.SeparatorVisibility(value)

    /// Adjusts the SeparatorVisibility property in the visual element
    let separatorVisibility (value: Xamarin.Forms.SeparatorVisibility) (x: XamlElement) = x.SeparatorVisibility(value)

    /// Adjusts the SeparatorColor property in the visual element
    let withSeparatorColor (value: Xamarin.Forms.Color) (x: XamlElement) = x.SeparatorColor(value)

    /// Adjusts the SeparatorColor property in the visual element
    let separatorColor (value: Xamarin.Forms.Color) (x: XamlElement) = x.SeparatorColor(value)

    /// Adjusts the ItemAppearing property in the visual element
    let withItemAppearing (value: Xamarin.Forms.ItemVisibilityEventArgs -> unit) (x: XamlElement) = x.ItemAppearing(value)

    /// Adjusts the ItemAppearing property in the visual element
    let itemAppearing (value: Xamarin.Forms.ItemVisibilityEventArgs -> unit) (x: XamlElement) = x.ItemAppearing(value)

    /// Adjusts the ItemDisappearing property in the visual element
    let withItemDisappearing (value: Xamarin.Forms.ItemVisibilityEventArgs -> unit) (x: XamlElement) = x.ItemDisappearing(value)

    /// Adjusts the ItemDisappearing property in the visual element
    let itemDisappearing (value: Xamarin.Forms.ItemVisibilityEventArgs -> unit) (x: XamlElement) = x.ItemDisappearing(value)

    /// Adjusts the ListView_ItemSelected property in the visual element
    let withListView_ItemSelected (value: int option -> unit) (x: XamlElement) = x.ListView_ItemSelected(value)

    /// Adjusts the ListView_ItemSelected property in the visual element
    let listView_ItemSelected (value: int option -> unit) (x: XamlElement) = x.ListView_ItemSelected(value)

    /// Adjusts the ItemTapped property in the visual element
    let withItemTapped (value: Xamarin.Forms.ItemTappedEventArgs -> unit) (x: XamlElement) = x.ItemTapped(value)

    /// Adjusts the ItemTapped property in the visual element
    let itemTapped (value: Xamarin.Forms.ItemTappedEventArgs -> unit) (x: XamlElement) = x.ItemTapped(value)

    /// Adjusts the Refreshing property in the visual element
    let withRefreshing (value: unit -> unit) (x: XamlElement) = x.Refreshing(value)

    /// Adjusts the Refreshing property in the visual element
    let refreshing (value: unit -> unit) (x: XamlElement) = x.Refreshing(value)

    /// Adjusts the GroupListViewItemsSource property in the visual element
    let withGroupListViewItemsSource (value: (XamlElement * XamlElement list) list) (x: XamlElement) = x.GroupListViewItemsSource(value)

    /// Adjusts the GroupListViewItemsSource property in the visual element
    let groupListViewItemsSource (value: (XamlElement * XamlElement list) list) (x: XamlElement) = x.GroupListViewItemsSource(value)

    /// Adjusts the ListViewGrouped_SelectedItem property in the visual element
    let withListViewGrouped_SelectedItem (value: (int * int) option) (x: XamlElement) = x.ListViewGrouped_SelectedItem(value)

    /// Adjusts the ListViewGrouped_SelectedItem property in the visual element
    let listViewGrouped_SelectedItem (value: (int * int) option) (x: XamlElement) = x.ListViewGrouped_SelectedItem(value)

    /// Adjusts the ListViewGrouped_ItemSelected property in the visual element
    let withListViewGrouped_ItemSelected (value: (int * int) option -> unit) (x: XamlElement) = x.ListViewGrouped_ItemSelected(value)

    /// Adjusts the ListViewGrouped_ItemSelected property in the visual element
    let listViewGrouped_ItemSelected (value: (int * int) option -> unit) (x: XamlElement) = x.ListViewGrouped_ItemSelected(value)

type Xaml() =

    /// Describes a Element in the view
    static member Element(?classId: string, ?styleId: string) = 
        let attribs = [| 
            match classId with None -> () | Some v -> yield ("ClassId", box ((v))) 
            match styleId with None -> () | Some v -> yield ("StyleId", box ((v))) 
          |]

        let create () =
            failwith "can'tdef create Xamarin.Forms.Element"

        let apply (prevOpt: XamlElement option) (source: XamlElement) (target:obj) = 
            let target = (target :?> Xamarin.Forms.Element)
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryClassId
            match prevValueOpt, source.TryClassId with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.ClassId <- value
            | Some _, None -> target.ClassId <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryStyleId
            match prevValueOpt, source.TryStyleId with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.StyleId <- value
            | Some _, None -> target.StyleId <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
        new XamlElement(typeof<Xamarin.Forms.Element>, create, apply, Map.ofArray attribs)

    /// Describes a VisualElement in the view
    static member VisualElement(?anchorX: double, ?anchorY: double, ?backgroundColor: Xamarin.Forms.Color, ?heightRequest: double, ?inputTransparent: bool, ?isEnabled: bool, ?isVisible: bool, ?minimumHeightRequest: double, ?minimumWidthRequest: double, ?opacity: double, ?rotation: double, ?rotationX: double, ?rotationY: double, ?scale: double, ?style: Xamarin.Forms.Style, ?translationX: double, ?translationY: double, ?widthRequest: double, ?classId: string, ?styleId: string) = 
        let attribs = [| 
            match anchorX with None -> () | Some v -> yield ("AnchorX", box ((v))) 
            match anchorY with None -> () | Some v -> yield ("AnchorY", box ((v))) 
            match backgroundColor with None -> () | Some v -> yield ("BackgroundColor", box ((v))) 
            match heightRequest with None -> () | Some v -> yield ("HeightRequest", box ((v))) 
            match inputTransparent with None -> () | Some v -> yield ("InputTransparent", box ((v))) 
            match isEnabled with None -> () | Some v -> yield ("IsEnabled", box ((v))) 
            match isVisible with None -> () | Some v -> yield ("IsVisible", box ((v))) 
            match minimumHeightRequest with None -> () | Some v -> yield ("MinimumHeightRequest", box ((v))) 
            match minimumWidthRequest with None -> () | Some v -> yield ("MinimumWidthRequest", box ((v))) 
            match opacity with None -> () | Some v -> yield ("Opacity", box ((v))) 
            match rotation with None -> () | Some v -> yield ("Rotation", box ((v))) 
            match rotationX with None -> () | Some v -> yield ("RotationX", box ((v))) 
            match rotationY with None -> () | Some v -> yield ("RotationY", box ((v))) 
            match scale with None -> () | Some v -> yield ("Scale", box ((v))) 
            match style with None -> () | Some v -> yield ("Style", box ((v))) 
            match translationX with None -> () | Some v -> yield ("TranslationX", box ((v))) 
            match translationY with None -> () | Some v -> yield ("TranslationY", box ((v))) 
            match widthRequest with None -> () | Some v -> yield ("WidthRequest", box ((v))) 
            match classId with None -> () | Some v -> yield ("ClassId", box ((v))) 
            match styleId with None -> () | Some v -> yield ("StyleId", box ((v))) 
          |]

        let create () =
            failwith "can'tdef create Xamarin.Forms.VisualElement"

        let apply (prevOpt: XamlElement option) (source: XamlElement) (target:obj) = 
            let target = (target :?> Xamarin.Forms.VisualElement)
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryAnchorX
            match prevValueOpt, source.TryAnchorX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.AnchorX <- value
            | Some _, None -> target.AnchorX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryAnchorY
            match prevValueOpt, source.TryAnchorY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.AnchorY <- value
            | Some _, None -> target.AnchorY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryBackgroundColor
            match prevValueOpt, source.TryBackgroundColor with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.BackgroundColor <- value
            | Some _, None -> target.BackgroundColor <- Xamarin.Forms.Color.Default // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryHeightRequest
            match prevValueOpt, source.TryHeightRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.HeightRequest <- value
            | Some _, None -> target.HeightRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryInputTransparent
            match prevValueOpt, source.TryInputTransparent with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.InputTransparent <- value
            | Some _, None -> target.InputTransparent <- false // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsEnabled
            match prevValueOpt, source.TryIsEnabled with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsEnabled <- value
            | Some _, None -> target.IsEnabled <- true // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsVisible
            match prevValueOpt, source.TryIsVisible with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsVisible <- value
            | Some _, None -> target.IsVisible <- true // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMinimumHeightRequest
            match prevValueOpt, source.TryMinimumHeightRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.MinimumHeightRequest <- value
            | Some _, None -> target.MinimumHeightRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMinimumWidthRequest
            match prevValueOpt, source.TryMinimumWidthRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.MinimumWidthRequest <- value
            | Some _, None -> target.MinimumWidthRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryOpacity
            match prevValueOpt, source.TryOpacity with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Opacity <- value
            | Some _, None -> target.Opacity <- 1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotation
            match prevValueOpt, source.TryRotation with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Rotation <- value
            | Some _, None -> target.Rotation <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotationX
            match prevValueOpt, source.TryRotationX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.RotationX <- value
            | Some _, None -> target.RotationX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotationY
            match prevValueOpt, source.TryRotationY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.RotationY <- value
            | Some _, None -> target.RotationY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryScale
            match prevValueOpt, source.TryScale with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Scale <- value
            | Some _, None -> target.Scale <- 1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryStyle
            match prevValueOpt, source.TryStyle with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Style <- value
            | Some _, None -> target.Style <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryTranslationX
            match prevValueOpt, source.TryTranslationX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.TranslationX <- value
            | Some _, None -> target.TranslationX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryTranslationY
            match prevValueOpt, source.TryTranslationY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.TranslationY <- value
            | Some _, None -> target.TranslationY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryWidthRequest
            match prevValueOpt, source.TryWidthRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.WidthRequest <- value
            | Some _, None -> target.WidthRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryClassId
            match prevValueOpt, source.TryClassId with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.ClassId <- value
            | Some _, None -> target.ClassId <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryStyleId
            match prevValueOpt, source.TryStyleId with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.StyleId <- value
            | Some _, None -> target.StyleId <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
        new XamlElement(typeof<Xamarin.Forms.VisualElement>, create, apply, Map.ofArray attribs)

    /// Describes a View in the view
    static member View(?horizontalOptions: Xamarin.Forms.LayoutOptions, ?verticalOptions: Xamarin.Forms.LayoutOptions, ?margin: obj, ?gestureRecognizers: XamlElement list, ?anchorX: double, ?anchorY: double, ?backgroundColor: Xamarin.Forms.Color, ?heightRequest: double, ?inputTransparent: bool, ?isEnabled: bool, ?isVisible: bool, ?minimumHeightRequest: double, ?minimumWidthRequest: double, ?opacity: double, ?rotation: double, ?rotationX: double, ?rotationY: double, ?scale: double, ?style: Xamarin.Forms.Style, ?translationX: double, ?translationY: double, ?widthRequest: double, ?classId: string, ?styleId: string) = 
        let attribs = [| 
            match horizontalOptions with None -> () | Some v -> yield ("HorizontalOptions", box ((v))) 
            match verticalOptions with None -> () | Some v -> yield ("VerticalOptions", box ((v))) 
            match margin with None -> () | Some v -> yield ("Margin", box (makeThickness(v))) 
            match gestureRecognizers with None -> () | Some v -> yield ("GestureRecognizers", box (Array.ofList(v))) 
            match anchorX with None -> () | Some v -> yield ("AnchorX", box ((v))) 
            match anchorY with None -> () | Some v -> yield ("AnchorY", box ((v))) 
            match backgroundColor with None -> () | Some v -> yield ("BackgroundColor", box ((v))) 
            match heightRequest with None -> () | Some v -> yield ("HeightRequest", box ((v))) 
            match inputTransparent with None -> () | Some v -> yield ("InputTransparent", box ((v))) 
            match isEnabled with None -> () | Some v -> yield ("IsEnabled", box ((v))) 
            match isVisible with None -> () | Some v -> yield ("IsVisible", box ((v))) 
            match minimumHeightRequest with None -> () | Some v -> yield ("MinimumHeightRequest", box ((v))) 
            match minimumWidthRequest with None -> () | Some v -> yield ("MinimumWidthRequest", box ((v))) 
            match opacity with None -> () | Some v -> yield ("Opacity", box ((v))) 
            match rotation with None -> () | Some v -> yield ("Rotation", box ((v))) 
            match rotationX with None -> () | Some v -> yield ("RotationX", box ((v))) 
            match rotationY with None -> () | Some v -> yield ("RotationY", box ((v))) 
            match scale with None -> () | Some v -> yield ("Scale", box ((v))) 
            match style with None -> () | Some v -> yield ("Style", box ((v))) 
            match translationX with None -> () | Some v -> yield ("TranslationX", box ((v))) 
            match translationY with None -> () | Some v -> yield ("TranslationY", box ((v))) 
            match widthRequest with None -> () | Some v -> yield ("WidthRequest", box ((v))) 
            match classId with None -> () | Some v -> yield ("ClassId", box ((v))) 
            match styleId with None -> () | Some v -> yield ("StyleId", box ((v))) 
          |]

        let create () =
            failwith "can'tdef create Xamarin.Forms.View"

        let apply (prevOpt: XamlElement option) (source: XamlElement) (target:obj) = 
            let target = (target :?> Xamarin.Forms.View)
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryHorizontalOptions
            match prevValueOpt, source.TryHorizontalOptions with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.HorizontalOptions <- value
            | Some _, None -> target.HorizontalOptions <- Unchecked.defaultof<Xamarin.Forms.LayoutOptions> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryVerticalOptions
            match prevValueOpt, source.TryVerticalOptions with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.VerticalOptions <- value
            | Some _, None -> target.VerticalOptions <- Unchecked.defaultof<Xamarin.Forms.LayoutOptions> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMargin
            match prevValueOpt, source.TryMargin with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Margin <- value
            | Some _, None -> target.Margin <- Unchecked.defaultof<Xamarin.Forms.Thickness> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevCollOpt = match prevOpt with None -> None | Some prev -> prev.TryGestureRecognizers
            match prevCollOpt, source.TryGestureRecognizers with
            // For structured objects, amortize on reference equality
            | Some prevColl, Some newColl when System.Object.ReferenceEquals(prevColl, newColl) -> ()
            | _, Some coll when coll <> null && coll.Length > 0 ->
                applyToIList
                    prevCollOpt
                    coll
                    target.GestureRecognizers
                    (fun (x:XamlElement) -> x.CreateAsIGestureRecognizer())
                    (fun _ _ _ -> ())
                    (fun (prevChild:XamlElement) (newChild:XamlElement) -> prevChild.TargetType = newChild.TargetType)
                    (fun prevChild newChild targetChild -> newChild.ApplyIncremental(prevChild, targetChild))
            | _ -> target.GestureRecognizers.Clear()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryAnchorX
            match prevValueOpt, source.TryAnchorX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.AnchorX <- value
            | Some _, None -> target.AnchorX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryAnchorY
            match prevValueOpt, source.TryAnchorY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.AnchorY <- value
            | Some _, None -> target.AnchorY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryBackgroundColor
            match prevValueOpt, source.TryBackgroundColor with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.BackgroundColor <- value
            | Some _, None -> target.BackgroundColor <- Xamarin.Forms.Color.Default // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryHeightRequest
            match prevValueOpt, source.TryHeightRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.HeightRequest <- value
            | Some _, None -> target.HeightRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryInputTransparent
            match prevValueOpt, source.TryInputTransparent with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.InputTransparent <- value
            | Some _, None -> target.InputTransparent <- false // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsEnabled
            match prevValueOpt, source.TryIsEnabled with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsEnabled <- value
            | Some _, None -> target.IsEnabled <- true // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsVisible
            match prevValueOpt, source.TryIsVisible with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsVisible <- value
            | Some _, None -> target.IsVisible <- true // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMinimumHeightRequest
            match prevValueOpt, source.TryMinimumHeightRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.MinimumHeightRequest <- value
            | Some _, None -> target.MinimumHeightRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMinimumWidthRequest
            match prevValueOpt, source.TryMinimumWidthRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.MinimumWidthRequest <- value
            | Some _, None -> target.MinimumWidthRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryOpacity
            match prevValueOpt, source.TryOpacity with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Opacity <- value
            | Some _, None -> target.Opacity <- 1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotation
            match prevValueOpt, source.TryRotation with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Rotation <- value
            | Some _, None -> target.Rotation <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotationX
            match prevValueOpt, source.TryRotationX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.RotationX <- value
            | Some _, None -> target.RotationX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotationY
            match prevValueOpt, source.TryRotationY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.RotationY <- value
            | Some _, None -> target.RotationY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryScale
            match prevValueOpt, source.TryScale with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Scale <- value
            | Some _, None -> target.Scale <- 1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryStyle
            match prevValueOpt, source.TryStyle with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Style <- value
            | Some _, None -> target.Style <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryTranslationX
            match prevValueOpt, source.TryTranslationX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.TranslationX <- value
            | Some _, None -> target.TranslationX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryTranslationY
            match prevValueOpt, source.TryTranslationY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.TranslationY <- value
            | Some _, None -> target.TranslationY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryWidthRequest
            match prevValueOpt, source.TryWidthRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.WidthRequest <- value
            | Some _, None -> target.WidthRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryClassId
            match prevValueOpt, source.TryClassId with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.ClassId <- value
            | Some _, None -> target.ClassId <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryStyleId
            match prevValueOpt, source.TryStyleId with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.StyleId <- value
            | Some _, None -> target.StyleId <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
        new XamlElement(typeof<Xamarin.Forms.View>, create, apply, Map.ofArray attribs)

    /// Describes a IGestureRecognizer in the view
    static member IGestureRecognizer() = 
        let attribs = [| 
          |]

        let create () =
            failwith "can'tdef create Xamarin.Forms.IGestureRecognizer"

        let apply (prevOpt: XamlElement option) (source: XamlElement) (target:obj) = 
            ()
        new XamlElement(typeof<Xamarin.Forms.IGestureRecognizer>, create, apply, Map.ofArray attribs)

    /// Describes a PanGestureRecognizer in the view
    static member PanGestureRecognizer(?touchPoints: int, ?panUpdated: Xamarin.Forms.PanUpdatedEventArgs -> unit, ?classId: string, ?styleId: string) = 
        let attribs = [| 
            match touchPoints with None -> () | Some v -> yield ("TouchPoints", box ((v))) 
            match panUpdated with None -> () | Some v -> yield ("PanUpdated", box ((fun f -> System.EventHandler<Xamarin.Forms.PanUpdatedEventArgs>(fun _sender args -> f args))(v))) 
            match classId with None -> () | Some v -> yield ("ClassId", box ((v))) 
            match styleId with None -> () | Some v -> yield ("StyleId", box ((v))) 
          |]

        let create () =
            box (new Xamarin.Forms.PanGestureRecognizer())

        let apply (prevOpt: XamlElement option) (source: XamlElement) (target:obj) = 
            let target = (target :?> Xamarin.Forms.PanGestureRecognizer)
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryTouchPoints
            match prevValueOpt, source.TryTouchPoints with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.TouchPoints <- value
            | Some _, None -> target.TouchPoints <- 1 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryPanUpdated
            match prevValueOpt, source.TryPanUpdated with
            | Some prevValue, Some value when System.Object.ReferenceEquals(prevValue, value) -> ()
            | Some prevValue, Some value -> target.PanUpdated.RemoveHandler(prevValue); target.PanUpdated.AddHandler(value)
            | None, Some value -> target.PanUpdated.AddHandler(value)
            | Some prevValue, None -> target.PanUpdated.RemoveHandler(prevValue)
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryClassId
            match prevValueOpt, source.TryClassId with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.ClassId <- value
            | Some _, None -> target.ClassId <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryStyleId
            match prevValueOpt, source.TryStyleId with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.StyleId <- value
            | Some _, None -> target.StyleId <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
        new XamlElement(typeof<Xamarin.Forms.PanGestureRecognizer>, create, apply, Map.ofArray attribs)

    /// Describes a TapGestureRecognizer in the view
    static member TapGestureRecognizer(?command: unit -> unit, ?numberOfTapsRequired: int, ?classId: string, ?styleId: string) = 
        let attribs = [| 
            match command with None -> () | Some v -> yield ("Command", box (makeCommand(v))) 
            match numberOfTapsRequired with None -> () | Some v -> yield ("NumberOfTapsRequired", box ((v))) 
            match classId with None -> () | Some v -> yield ("ClassId", box ((v))) 
            match styleId with None -> () | Some v -> yield ("StyleId", box ((v))) 
          |]

        let create () =
            box (new Xamarin.Forms.TapGestureRecognizer())

        let apply (prevOpt: XamlElement option) (source: XamlElement) (target:obj) = 
            let target = (target :?> Xamarin.Forms.TapGestureRecognizer)
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryCommand
            match prevValueOpt, source.TryCommand with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Command <- value
            | Some _, None -> target.Command <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryNumberOfTapsRequired
            match prevValueOpt, source.TryNumberOfTapsRequired with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.NumberOfTapsRequired <- value
            | Some _, None -> target.NumberOfTapsRequired <- 1 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryClassId
            match prevValueOpt, source.TryClassId with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.ClassId <- value
            | Some _, None -> target.ClassId <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryStyleId
            match prevValueOpt, source.TryStyleId with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.StyleId <- value
            | Some _, None -> target.StyleId <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
        new XamlElement(typeof<Xamarin.Forms.TapGestureRecognizer>, create, apply, Map.ofArray attribs)

    /// Describes a ClickGestureRecognizer in the view
    static member ClickGestureRecognizer(?command: unit -> unit, ?numberOfClicksRequired: int, ?buttons: Xamarin.Forms.ButtonsMask, ?classId: string, ?styleId: string) = 
        let attribs = [| 
            match command with None -> () | Some v -> yield ("Command", box (makeCommand(v))) 
            match numberOfClicksRequired with None -> () | Some v -> yield ("NumberOfClicksRequired", box ((v))) 
            match buttons with None -> () | Some v -> yield ("Buttons", box ((v))) 
            match classId with None -> () | Some v -> yield ("ClassId", box ((v))) 
            match styleId with None -> () | Some v -> yield ("StyleId", box ((v))) 
          |]

        let create () =
            box (new Xamarin.Forms.ClickGestureRecognizer())

        let apply (prevOpt: XamlElement option) (source: XamlElement) (target:obj) = 
            let target = (target :?> Xamarin.Forms.ClickGestureRecognizer)
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryCommand
            match prevValueOpt, source.TryCommand with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Command <- value
            | Some _, None -> target.Command <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryNumberOfClicksRequired
            match prevValueOpt, source.TryNumberOfClicksRequired with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.NumberOfClicksRequired <- value
            | Some _, None -> target.NumberOfClicksRequired <- 1 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryButtons
            match prevValueOpt, source.TryButtons with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Buttons <- value
            | Some _, None -> target.Buttons <- Xamarin.Forms.ButtonsMask.Primary // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryClassId
            match prevValueOpt, source.TryClassId with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.ClassId <- value
            | Some _, None -> target.ClassId <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryStyleId
            match prevValueOpt, source.TryStyleId with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.StyleId <- value
            | Some _, None -> target.StyleId <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
        new XamlElement(typeof<Xamarin.Forms.ClickGestureRecognizer>, create, apply, Map.ofArray attribs)

    /// Describes a PinchGestureRecognizer in the view
    static member PinchGestureRecognizer(?isPinching: bool, ?pinchUpdated: Xamarin.Forms.PinchGestureUpdatedEventArgs -> unit, ?classId: string, ?styleId: string) = 
        let attribs = [| 
            match isPinching with None -> () | Some v -> yield ("IsPinching", box ((v))) 
            match pinchUpdated with None -> () | Some v -> yield ("PinchUpdated", box ((fun f -> System.EventHandler<Xamarin.Forms.PinchGestureUpdatedEventArgs>(fun _sender args -> f args))(v))) 
            match classId with None -> () | Some v -> yield ("ClassId", box ((v))) 
            match styleId with None -> () | Some v -> yield ("StyleId", box ((v))) 
          |]

        let create () =
            box (new Xamarin.Forms.PinchGestureRecognizer())

        let apply (prevOpt: XamlElement option) (source: XamlElement) (target:obj) = 
            let target = (target :?> Xamarin.Forms.PinchGestureRecognizer)
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsPinching
            match prevValueOpt, source.TryIsPinching with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsPinching <- value
            | Some _, None -> target.IsPinching <- false // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryPinchUpdated
            match prevValueOpt, source.TryPinchUpdated with
            | Some prevValue, Some value when System.Object.ReferenceEquals(prevValue, value) -> ()
            | Some prevValue, Some value -> target.PinchUpdated.RemoveHandler(prevValue); target.PinchUpdated.AddHandler(value)
            | None, Some value -> target.PinchUpdated.AddHandler(value)
            | Some prevValue, None -> target.PinchUpdated.RemoveHandler(prevValue)
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryClassId
            match prevValueOpt, source.TryClassId with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.ClassId <- value
            | Some _, None -> target.ClassId <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryStyleId
            match prevValueOpt, source.TryStyleId with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.StyleId <- value
            | Some _, None -> target.StyleId <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
        new XamlElement(typeof<Xamarin.Forms.PinchGestureRecognizer>, create, apply, Map.ofArray attribs)

    /// Describes a ActivityIndicator in the view
    static member ActivityIndicator(?color: Xamarin.Forms.Color, ?isRunning: bool, ?horizontalOptions: Xamarin.Forms.LayoutOptions, ?verticalOptions: Xamarin.Forms.LayoutOptions, ?margin: obj, ?gestureRecognizers: XamlElement list, ?anchorX: double, ?anchorY: double, ?backgroundColor: Xamarin.Forms.Color, ?heightRequest: double, ?inputTransparent: bool, ?isEnabled: bool, ?isVisible: bool, ?minimumHeightRequest: double, ?minimumWidthRequest: double, ?opacity: double, ?rotation: double, ?rotationX: double, ?rotationY: double, ?scale: double, ?style: Xamarin.Forms.Style, ?translationX: double, ?translationY: double, ?widthRequest: double, ?classId: string, ?styleId: string) = 
        let attribs = [| 
            match color with None -> () | Some v -> yield ("Color", box ((v))) 
            match isRunning with None -> () | Some v -> yield ("IsRunning", box ((v))) 
            match horizontalOptions with None -> () | Some v -> yield ("HorizontalOptions", box ((v))) 
            match verticalOptions with None -> () | Some v -> yield ("VerticalOptions", box ((v))) 
            match margin with None -> () | Some v -> yield ("Margin", box (makeThickness(v))) 
            match gestureRecognizers with None -> () | Some v -> yield ("GestureRecognizers", box (Array.ofList(v))) 
            match anchorX with None -> () | Some v -> yield ("AnchorX", box ((v))) 
            match anchorY with None -> () | Some v -> yield ("AnchorY", box ((v))) 
            match backgroundColor with None -> () | Some v -> yield ("BackgroundColor", box ((v))) 
            match heightRequest with None -> () | Some v -> yield ("HeightRequest", box ((v))) 
            match inputTransparent with None -> () | Some v -> yield ("InputTransparent", box ((v))) 
            match isEnabled with None -> () | Some v -> yield ("IsEnabled", box ((v))) 
            match isVisible with None -> () | Some v -> yield ("IsVisible", box ((v))) 
            match minimumHeightRequest with None -> () | Some v -> yield ("MinimumHeightRequest", box ((v))) 
            match minimumWidthRequest with None -> () | Some v -> yield ("MinimumWidthRequest", box ((v))) 
            match opacity with None -> () | Some v -> yield ("Opacity", box ((v))) 
            match rotation with None -> () | Some v -> yield ("Rotation", box ((v))) 
            match rotationX with None -> () | Some v -> yield ("RotationX", box ((v))) 
            match rotationY with None -> () | Some v -> yield ("RotationY", box ((v))) 
            match scale with None -> () | Some v -> yield ("Scale", box ((v))) 
            match style with None -> () | Some v -> yield ("Style", box ((v))) 
            match translationX with None -> () | Some v -> yield ("TranslationX", box ((v))) 
            match translationY with None -> () | Some v -> yield ("TranslationY", box ((v))) 
            match widthRequest with None -> () | Some v -> yield ("WidthRequest", box ((v))) 
            match classId with None -> () | Some v -> yield ("ClassId", box ((v))) 
            match styleId with None -> () | Some v -> yield ("StyleId", box ((v))) 
          |]

        let create () =
            box (new Xamarin.Forms.ActivityIndicator())

        let apply (prevOpt: XamlElement option) (source: XamlElement) (target:obj) = 
            let target = (target :?> Xamarin.Forms.ActivityIndicator)
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryColor
            match prevValueOpt, source.TryColor with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Color <- value
            | Some _, None -> target.Color <- Xamarin.Forms.Color.Default // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsRunning
            match prevValueOpt, source.TryIsRunning with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsRunning <- value
            | Some _, None -> target.IsRunning <- false // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryHorizontalOptions
            match prevValueOpt, source.TryHorizontalOptions with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.HorizontalOptions <- value
            | Some _, None -> target.HorizontalOptions <- Unchecked.defaultof<Xamarin.Forms.LayoutOptions> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryVerticalOptions
            match prevValueOpt, source.TryVerticalOptions with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.VerticalOptions <- value
            | Some _, None -> target.VerticalOptions <- Unchecked.defaultof<Xamarin.Forms.LayoutOptions> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMargin
            match prevValueOpt, source.TryMargin with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Margin <- value
            | Some _, None -> target.Margin <- Unchecked.defaultof<Xamarin.Forms.Thickness> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevCollOpt = match prevOpt with None -> None | Some prev -> prev.TryGestureRecognizers
            match prevCollOpt, source.TryGestureRecognizers with
            // For structured objects, amortize on reference equality
            | Some prevColl, Some newColl when System.Object.ReferenceEquals(prevColl, newColl) -> ()
            | _, Some coll when coll <> null && coll.Length > 0 ->
                applyToIList
                    prevCollOpt
                    coll
                    target.GestureRecognizers
                    (fun (x:XamlElement) -> x.CreateAsIGestureRecognizer())
                    (fun _ _ _ -> ())
                    (fun (prevChild:XamlElement) (newChild:XamlElement) -> prevChild.TargetType = newChild.TargetType)
                    (fun prevChild newChild targetChild -> newChild.ApplyIncremental(prevChild, targetChild))
            | _ -> target.GestureRecognizers.Clear()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryAnchorX
            match prevValueOpt, source.TryAnchorX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.AnchorX <- value
            | Some _, None -> target.AnchorX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryAnchorY
            match prevValueOpt, source.TryAnchorY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.AnchorY <- value
            | Some _, None -> target.AnchorY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryBackgroundColor
            match prevValueOpt, source.TryBackgroundColor with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.BackgroundColor <- value
            | Some _, None -> target.BackgroundColor <- Xamarin.Forms.Color.Default // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryHeightRequest
            match prevValueOpt, source.TryHeightRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.HeightRequest <- value
            | Some _, None -> target.HeightRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryInputTransparent
            match prevValueOpt, source.TryInputTransparent with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.InputTransparent <- value
            | Some _, None -> target.InputTransparent <- false // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsEnabled
            match prevValueOpt, source.TryIsEnabled with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsEnabled <- value
            | Some _, None -> target.IsEnabled <- true // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsVisible
            match prevValueOpt, source.TryIsVisible with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsVisible <- value
            | Some _, None -> target.IsVisible <- true // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMinimumHeightRequest
            match prevValueOpt, source.TryMinimumHeightRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.MinimumHeightRequest <- value
            | Some _, None -> target.MinimumHeightRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMinimumWidthRequest
            match prevValueOpt, source.TryMinimumWidthRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.MinimumWidthRequest <- value
            | Some _, None -> target.MinimumWidthRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryOpacity
            match prevValueOpt, source.TryOpacity with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Opacity <- value
            | Some _, None -> target.Opacity <- 1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotation
            match prevValueOpt, source.TryRotation with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Rotation <- value
            | Some _, None -> target.Rotation <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotationX
            match prevValueOpt, source.TryRotationX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.RotationX <- value
            | Some _, None -> target.RotationX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotationY
            match prevValueOpt, source.TryRotationY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.RotationY <- value
            | Some _, None -> target.RotationY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryScale
            match prevValueOpt, source.TryScale with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Scale <- value
            | Some _, None -> target.Scale <- 1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryStyle
            match prevValueOpt, source.TryStyle with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Style <- value
            | Some _, None -> target.Style <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryTranslationX
            match prevValueOpt, source.TryTranslationX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.TranslationX <- value
            | Some _, None -> target.TranslationX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryTranslationY
            match prevValueOpt, source.TryTranslationY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.TranslationY <- value
            | Some _, None -> target.TranslationY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryWidthRequest
            match prevValueOpt, source.TryWidthRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.WidthRequest <- value
            | Some _, None -> target.WidthRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryClassId
            match prevValueOpt, source.TryClassId with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.ClassId <- value
            | Some _, None -> target.ClassId <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryStyleId
            match prevValueOpt, source.TryStyleId with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.StyleId <- value
            | Some _, None -> target.StyleId <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
        new XamlElement(typeof<Xamarin.Forms.ActivityIndicator>, create, apply, Map.ofArray attribs)

    /// Describes a BoxView in the view
    static member BoxView(?color: Xamarin.Forms.Color, ?horizontalOptions: Xamarin.Forms.LayoutOptions, ?verticalOptions: Xamarin.Forms.LayoutOptions, ?margin: obj, ?gestureRecognizers: XamlElement list, ?anchorX: double, ?anchorY: double, ?backgroundColor: Xamarin.Forms.Color, ?heightRequest: double, ?inputTransparent: bool, ?isEnabled: bool, ?isVisible: bool, ?minimumHeightRequest: double, ?minimumWidthRequest: double, ?opacity: double, ?rotation: double, ?rotationX: double, ?rotationY: double, ?scale: double, ?style: Xamarin.Forms.Style, ?translationX: double, ?translationY: double, ?widthRequest: double, ?classId: string, ?styleId: string) = 
        let attribs = [| 
            match color with None -> () | Some v -> yield ("Color", box ((v))) 
            match horizontalOptions with None -> () | Some v -> yield ("HorizontalOptions", box ((v))) 
            match verticalOptions with None -> () | Some v -> yield ("VerticalOptions", box ((v))) 
            match margin with None -> () | Some v -> yield ("Margin", box (makeThickness(v))) 
            match gestureRecognizers with None -> () | Some v -> yield ("GestureRecognizers", box (Array.ofList(v))) 
            match anchorX with None -> () | Some v -> yield ("AnchorX", box ((v))) 
            match anchorY with None -> () | Some v -> yield ("AnchorY", box ((v))) 
            match backgroundColor with None -> () | Some v -> yield ("BackgroundColor", box ((v))) 
            match heightRequest with None -> () | Some v -> yield ("HeightRequest", box ((v))) 
            match inputTransparent with None -> () | Some v -> yield ("InputTransparent", box ((v))) 
            match isEnabled with None -> () | Some v -> yield ("IsEnabled", box ((v))) 
            match isVisible with None -> () | Some v -> yield ("IsVisible", box ((v))) 
            match minimumHeightRequest with None -> () | Some v -> yield ("MinimumHeightRequest", box ((v))) 
            match minimumWidthRequest with None -> () | Some v -> yield ("MinimumWidthRequest", box ((v))) 
            match opacity with None -> () | Some v -> yield ("Opacity", box ((v))) 
            match rotation with None -> () | Some v -> yield ("Rotation", box ((v))) 
            match rotationX with None -> () | Some v -> yield ("RotationX", box ((v))) 
            match rotationY with None -> () | Some v -> yield ("RotationY", box ((v))) 
            match scale with None -> () | Some v -> yield ("Scale", box ((v))) 
            match style with None -> () | Some v -> yield ("Style", box ((v))) 
            match translationX with None -> () | Some v -> yield ("TranslationX", box ((v))) 
            match translationY with None -> () | Some v -> yield ("TranslationY", box ((v))) 
            match widthRequest with None -> () | Some v -> yield ("WidthRequest", box ((v))) 
            match classId with None -> () | Some v -> yield ("ClassId", box ((v))) 
            match styleId with None -> () | Some v -> yield ("StyleId", box ((v))) 
          |]

        let create () =
            box (new Xamarin.Forms.BoxView())

        let apply (prevOpt: XamlElement option) (source: XamlElement) (target:obj) = 
            let target = (target :?> Xamarin.Forms.BoxView)
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryColor
            match prevValueOpt, source.TryColor with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Color <- value
            | Some _, None -> target.Color <- Xamarin.Forms.Color.Default // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryHorizontalOptions
            match prevValueOpt, source.TryHorizontalOptions with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.HorizontalOptions <- value
            | Some _, None -> target.HorizontalOptions <- Unchecked.defaultof<Xamarin.Forms.LayoutOptions> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryVerticalOptions
            match prevValueOpt, source.TryVerticalOptions with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.VerticalOptions <- value
            | Some _, None -> target.VerticalOptions <- Unchecked.defaultof<Xamarin.Forms.LayoutOptions> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMargin
            match prevValueOpt, source.TryMargin with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Margin <- value
            | Some _, None -> target.Margin <- Unchecked.defaultof<Xamarin.Forms.Thickness> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevCollOpt = match prevOpt with None -> None | Some prev -> prev.TryGestureRecognizers
            match prevCollOpt, source.TryGestureRecognizers with
            // For structured objects, amortize on reference equality
            | Some prevColl, Some newColl when System.Object.ReferenceEquals(prevColl, newColl) -> ()
            | _, Some coll when coll <> null && coll.Length > 0 ->
                applyToIList
                    prevCollOpt
                    coll
                    target.GestureRecognizers
                    (fun (x:XamlElement) -> x.CreateAsIGestureRecognizer())
                    (fun _ _ _ -> ())
                    (fun (prevChild:XamlElement) (newChild:XamlElement) -> prevChild.TargetType = newChild.TargetType)
                    (fun prevChild newChild targetChild -> newChild.ApplyIncremental(prevChild, targetChild))
            | _ -> target.GestureRecognizers.Clear()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryAnchorX
            match prevValueOpt, source.TryAnchorX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.AnchorX <- value
            | Some _, None -> target.AnchorX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryAnchorY
            match prevValueOpt, source.TryAnchorY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.AnchorY <- value
            | Some _, None -> target.AnchorY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryBackgroundColor
            match prevValueOpt, source.TryBackgroundColor with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.BackgroundColor <- value
            | Some _, None -> target.BackgroundColor <- Xamarin.Forms.Color.Default // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryHeightRequest
            match prevValueOpt, source.TryHeightRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.HeightRequest <- value
            | Some _, None -> target.HeightRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryInputTransparent
            match prevValueOpt, source.TryInputTransparent with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.InputTransparent <- value
            | Some _, None -> target.InputTransparent <- false // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsEnabled
            match prevValueOpt, source.TryIsEnabled with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsEnabled <- value
            | Some _, None -> target.IsEnabled <- true // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsVisible
            match prevValueOpt, source.TryIsVisible with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsVisible <- value
            | Some _, None -> target.IsVisible <- true // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMinimumHeightRequest
            match prevValueOpt, source.TryMinimumHeightRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.MinimumHeightRequest <- value
            | Some _, None -> target.MinimumHeightRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMinimumWidthRequest
            match prevValueOpt, source.TryMinimumWidthRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.MinimumWidthRequest <- value
            | Some _, None -> target.MinimumWidthRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryOpacity
            match prevValueOpt, source.TryOpacity with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Opacity <- value
            | Some _, None -> target.Opacity <- 1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotation
            match prevValueOpt, source.TryRotation with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Rotation <- value
            | Some _, None -> target.Rotation <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotationX
            match prevValueOpt, source.TryRotationX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.RotationX <- value
            | Some _, None -> target.RotationX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotationY
            match prevValueOpt, source.TryRotationY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.RotationY <- value
            | Some _, None -> target.RotationY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryScale
            match prevValueOpt, source.TryScale with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Scale <- value
            | Some _, None -> target.Scale <- 1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryStyle
            match prevValueOpt, source.TryStyle with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Style <- value
            | Some _, None -> target.Style <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryTranslationX
            match prevValueOpt, source.TryTranslationX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.TranslationX <- value
            | Some _, None -> target.TranslationX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryTranslationY
            match prevValueOpt, source.TryTranslationY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.TranslationY <- value
            | Some _, None -> target.TranslationY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryWidthRequest
            match prevValueOpt, source.TryWidthRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.WidthRequest <- value
            | Some _, None -> target.WidthRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryClassId
            match prevValueOpt, source.TryClassId with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.ClassId <- value
            | Some _, None -> target.ClassId <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryStyleId
            match prevValueOpt, source.TryStyleId with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.StyleId <- value
            | Some _, None -> target.StyleId <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
        new XamlElement(typeof<Xamarin.Forms.BoxView>, create, apply, Map.ofArray attribs)

    /// Describes a ProgressBar in the view
    static member ProgressBar(?progress: double, ?horizontalOptions: Xamarin.Forms.LayoutOptions, ?verticalOptions: Xamarin.Forms.LayoutOptions, ?margin: obj, ?gestureRecognizers: XamlElement list, ?anchorX: double, ?anchorY: double, ?backgroundColor: Xamarin.Forms.Color, ?heightRequest: double, ?inputTransparent: bool, ?isEnabled: bool, ?isVisible: bool, ?minimumHeightRequest: double, ?minimumWidthRequest: double, ?opacity: double, ?rotation: double, ?rotationX: double, ?rotationY: double, ?scale: double, ?style: Xamarin.Forms.Style, ?translationX: double, ?translationY: double, ?widthRequest: double, ?classId: string, ?styleId: string) = 
        let attribs = [| 
            match progress with None -> () | Some v -> yield ("Progress", box ((v))) 
            match horizontalOptions with None -> () | Some v -> yield ("HorizontalOptions", box ((v))) 
            match verticalOptions with None -> () | Some v -> yield ("VerticalOptions", box ((v))) 
            match margin with None -> () | Some v -> yield ("Margin", box (makeThickness(v))) 
            match gestureRecognizers with None -> () | Some v -> yield ("GestureRecognizers", box (Array.ofList(v))) 
            match anchorX with None -> () | Some v -> yield ("AnchorX", box ((v))) 
            match anchorY with None -> () | Some v -> yield ("AnchorY", box ((v))) 
            match backgroundColor with None -> () | Some v -> yield ("BackgroundColor", box ((v))) 
            match heightRequest with None -> () | Some v -> yield ("HeightRequest", box ((v))) 
            match inputTransparent with None -> () | Some v -> yield ("InputTransparent", box ((v))) 
            match isEnabled with None -> () | Some v -> yield ("IsEnabled", box ((v))) 
            match isVisible with None -> () | Some v -> yield ("IsVisible", box ((v))) 
            match minimumHeightRequest with None -> () | Some v -> yield ("MinimumHeightRequest", box ((v))) 
            match minimumWidthRequest with None -> () | Some v -> yield ("MinimumWidthRequest", box ((v))) 
            match opacity with None -> () | Some v -> yield ("Opacity", box ((v))) 
            match rotation with None -> () | Some v -> yield ("Rotation", box ((v))) 
            match rotationX with None -> () | Some v -> yield ("RotationX", box ((v))) 
            match rotationY with None -> () | Some v -> yield ("RotationY", box ((v))) 
            match scale with None -> () | Some v -> yield ("Scale", box ((v))) 
            match style with None -> () | Some v -> yield ("Style", box ((v))) 
            match translationX with None -> () | Some v -> yield ("TranslationX", box ((v))) 
            match translationY with None -> () | Some v -> yield ("TranslationY", box ((v))) 
            match widthRequest with None -> () | Some v -> yield ("WidthRequest", box ((v))) 
            match classId with None -> () | Some v -> yield ("ClassId", box ((v))) 
            match styleId with None -> () | Some v -> yield ("StyleId", box ((v))) 
          |]

        let create () =
            box (new Xamarin.Forms.ProgressBar())

        let apply (prevOpt: XamlElement option) (source: XamlElement) (target:obj) = 
            let target = (target :?> Xamarin.Forms.ProgressBar)
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryProgress
            match prevValueOpt, source.TryProgress with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Progress <- value
            | Some _, None -> target.Progress <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryHorizontalOptions
            match prevValueOpt, source.TryHorizontalOptions with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.HorizontalOptions <- value
            | Some _, None -> target.HorizontalOptions <- Unchecked.defaultof<Xamarin.Forms.LayoutOptions> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryVerticalOptions
            match prevValueOpt, source.TryVerticalOptions with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.VerticalOptions <- value
            | Some _, None -> target.VerticalOptions <- Unchecked.defaultof<Xamarin.Forms.LayoutOptions> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMargin
            match prevValueOpt, source.TryMargin with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Margin <- value
            | Some _, None -> target.Margin <- Unchecked.defaultof<Xamarin.Forms.Thickness> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevCollOpt = match prevOpt with None -> None | Some prev -> prev.TryGestureRecognizers
            match prevCollOpt, source.TryGestureRecognizers with
            // For structured objects, amortize on reference equality
            | Some prevColl, Some newColl when System.Object.ReferenceEquals(prevColl, newColl) -> ()
            | _, Some coll when coll <> null && coll.Length > 0 ->
                applyToIList
                    prevCollOpt
                    coll
                    target.GestureRecognizers
                    (fun (x:XamlElement) -> x.CreateAsIGestureRecognizer())
                    (fun _ _ _ -> ())
                    (fun (prevChild:XamlElement) (newChild:XamlElement) -> prevChild.TargetType = newChild.TargetType)
                    (fun prevChild newChild targetChild -> newChild.ApplyIncremental(prevChild, targetChild))
            | _ -> target.GestureRecognizers.Clear()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryAnchorX
            match prevValueOpt, source.TryAnchorX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.AnchorX <- value
            | Some _, None -> target.AnchorX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryAnchorY
            match prevValueOpt, source.TryAnchorY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.AnchorY <- value
            | Some _, None -> target.AnchorY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryBackgroundColor
            match prevValueOpt, source.TryBackgroundColor with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.BackgroundColor <- value
            | Some _, None -> target.BackgroundColor <- Xamarin.Forms.Color.Default // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryHeightRequest
            match prevValueOpt, source.TryHeightRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.HeightRequest <- value
            | Some _, None -> target.HeightRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryInputTransparent
            match prevValueOpt, source.TryInputTransparent with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.InputTransparent <- value
            | Some _, None -> target.InputTransparent <- false // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsEnabled
            match prevValueOpt, source.TryIsEnabled with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsEnabled <- value
            | Some _, None -> target.IsEnabled <- true // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsVisible
            match prevValueOpt, source.TryIsVisible with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsVisible <- value
            | Some _, None -> target.IsVisible <- true // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMinimumHeightRequest
            match prevValueOpt, source.TryMinimumHeightRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.MinimumHeightRequest <- value
            | Some _, None -> target.MinimumHeightRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMinimumWidthRequest
            match prevValueOpt, source.TryMinimumWidthRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.MinimumWidthRequest <- value
            | Some _, None -> target.MinimumWidthRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryOpacity
            match prevValueOpt, source.TryOpacity with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Opacity <- value
            | Some _, None -> target.Opacity <- 1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotation
            match prevValueOpt, source.TryRotation with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Rotation <- value
            | Some _, None -> target.Rotation <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotationX
            match prevValueOpt, source.TryRotationX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.RotationX <- value
            | Some _, None -> target.RotationX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotationY
            match prevValueOpt, source.TryRotationY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.RotationY <- value
            | Some _, None -> target.RotationY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryScale
            match prevValueOpt, source.TryScale with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Scale <- value
            | Some _, None -> target.Scale <- 1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryStyle
            match prevValueOpt, source.TryStyle with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Style <- value
            | Some _, None -> target.Style <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryTranslationX
            match prevValueOpt, source.TryTranslationX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.TranslationX <- value
            | Some _, None -> target.TranslationX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryTranslationY
            match prevValueOpt, source.TryTranslationY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.TranslationY <- value
            | Some _, None -> target.TranslationY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryWidthRequest
            match prevValueOpt, source.TryWidthRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.WidthRequest <- value
            | Some _, None -> target.WidthRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryClassId
            match prevValueOpt, source.TryClassId with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.ClassId <- value
            | Some _, None -> target.ClassId <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryStyleId
            match prevValueOpt, source.TryStyleId with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.StyleId <- value
            | Some _, None -> target.StyleId <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
        new XamlElement(typeof<Xamarin.Forms.ProgressBar>, create, apply, Map.ofArray attribs)

    /// Describes a ScrollView in the view
    static member ScrollView(?content: XamlElement, ?orientation: Xamarin.Forms.ScrollOrientation, ?isClippedToBounds: bool, ?padding: double, ?horizontalOptions: Xamarin.Forms.LayoutOptions, ?verticalOptions: Xamarin.Forms.LayoutOptions, ?margin: obj, ?gestureRecognizers: XamlElement list, ?anchorX: double, ?anchorY: double, ?backgroundColor: Xamarin.Forms.Color, ?heightRequest: double, ?inputTransparent: bool, ?isEnabled: bool, ?isVisible: bool, ?minimumHeightRequest: double, ?minimumWidthRequest: double, ?opacity: double, ?rotation: double, ?rotationX: double, ?rotationY: double, ?scale: double, ?style: Xamarin.Forms.Style, ?translationX: double, ?translationY: double, ?widthRequest: double, ?classId: string, ?styleId: string) = 
        let attribs = [| 
            match content with None -> () | Some v -> yield ("Content", box ((v))) 
            match orientation with None -> () | Some v -> yield ("ScrollOrientation", box ((v))) 
            match isClippedToBounds with None -> () | Some v -> yield ("IsClippedToBounds", box ((v))) 
            match padding with None -> () | Some v -> yield ("Padding", box (makeThickness(v))) 
            match horizontalOptions with None -> () | Some v -> yield ("HorizontalOptions", box ((v))) 
            match verticalOptions with None -> () | Some v -> yield ("VerticalOptions", box ((v))) 
            match margin with None -> () | Some v -> yield ("Margin", box (makeThickness(v))) 
            match gestureRecognizers with None -> () | Some v -> yield ("GestureRecognizers", box (Array.ofList(v))) 
            match anchorX with None -> () | Some v -> yield ("AnchorX", box ((v))) 
            match anchorY with None -> () | Some v -> yield ("AnchorY", box ((v))) 
            match backgroundColor with None -> () | Some v -> yield ("BackgroundColor", box ((v))) 
            match heightRequest with None -> () | Some v -> yield ("HeightRequest", box ((v))) 
            match inputTransparent with None -> () | Some v -> yield ("InputTransparent", box ((v))) 
            match isEnabled with None -> () | Some v -> yield ("IsEnabled", box ((v))) 
            match isVisible with None -> () | Some v -> yield ("IsVisible", box ((v))) 
            match minimumHeightRequest with None -> () | Some v -> yield ("MinimumHeightRequest", box ((v))) 
            match minimumWidthRequest with None -> () | Some v -> yield ("MinimumWidthRequest", box ((v))) 
            match opacity with None -> () | Some v -> yield ("Opacity", box ((v))) 
            match rotation with None -> () | Some v -> yield ("Rotation", box ((v))) 
            match rotationX with None -> () | Some v -> yield ("RotationX", box ((v))) 
            match rotationY with None -> () | Some v -> yield ("RotationY", box ((v))) 
            match scale with None -> () | Some v -> yield ("Scale", box ((v))) 
            match style with None -> () | Some v -> yield ("Style", box ((v))) 
            match translationX with None -> () | Some v -> yield ("TranslationX", box ((v))) 
            match translationY with None -> () | Some v -> yield ("TranslationY", box ((v))) 
            match widthRequest with None -> () | Some v -> yield ("WidthRequest", box ((v))) 
            match classId with None -> () | Some v -> yield ("ClassId", box ((v))) 
            match styleId with None -> () | Some v -> yield ("StyleId", box ((v))) 
          |]

        let create () =
            box (new Xamarin.Forms.ScrollView())

        let apply (prevOpt: XamlElement option) (source: XamlElement) (target:obj) = 
            let target = (target :?> Xamarin.Forms.ScrollView)
            let prevChildOpt = match prevOpt with None -> None | Some prev -> prev.TryContent
            match prevChildOpt, source.TryContent with
            // For structured objects, amortize on reference equality
            | Some prevChild, Some newChild when System.Object.ReferenceEquals(prevChild, newChild) -> ()
            | Some prevChild, Some newChild ->
                newChild.ApplyIncremental(prevChild, target.Content)
            | None, Some newChild ->
                target.Content <- newChild.CreateAsView()
            | Some _, None ->
                target.Content <- null;
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryScrollOrientation
            match prevValueOpt, source.TryScrollOrientation with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Orientation <- value
            | Some _, None -> target.Orientation <- Unchecked.defaultof<Xamarin.Forms.ScrollOrientation> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsClippedToBounds
            match prevValueOpt, source.TryIsClippedToBounds with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsClippedToBounds <- value
            | Some _, None -> target.IsClippedToBounds <- false // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryPadding
            match prevValueOpt, source.TryPadding with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Padding <- value
            | Some _, None -> target.Padding <- Unchecked.defaultof<Xamarin.Forms.Thickness> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryHorizontalOptions
            match prevValueOpt, source.TryHorizontalOptions with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.HorizontalOptions <- value
            | Some _, None -> target.HorizontalOptions <- Unchecked.defaultof<Xamarin.Forms.LayoutOptions> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryVerticalOptions
            match prevValueOpt, source.TryVerticalOptions with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.VerticalOptions <- value
            | Some _, None -> target.VerticalOptions <- Unchecked.defaultof<Xamarin.Forms.LayoutOptions> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMargin
            match prevValueOpt, source.TryMargin with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Margin <- value
            | Some _, None -> target.Margin <- Unchecked.defaultof<Xamarin.Forms.Thickness> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevCollOpt = match prevOpt with None -> None | Some prev -> prev.TryGestureRecognizers
            match prevCollOpt, source.TryGestureRecognizers with
            // For structured objects, amortize on reference equality
            | Some prevColl, Some newColl when System.Object.ReferenceEquals(prevColl, newColl) -> ()
            | _, Some coll when coll <> null && coll.Length > 0 ->
                applyToIList
                    prevCollOpt
                    coll
                    target.GestureRecognizers
                    (fun (x:XamlElement) -> x.CreateAsIGestureRecognizer())
                    (fun _ _ _ -> ())
                    (fun (prevChild:XamlElement) (newChild:XamlElement) -> prevChild.TargetType = newChild.TargetType)
                    (fun prevChild newChild targetChild -> newChild.ApplyIncremental(prevChild, targetChild))
            | _ -> target.GestureRecognizers.Clear()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryAnchorX
            match prevValueOpt, source.TryAnchorX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.AnchorX <- value
            | Some _, None -> target.AnchorX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryAnchorY
            match prevValueOpt, source.TryAnchorY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.AnchorY <- value
            | Some _, None -> target.AnchorY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryBackgroundColor
            match prevValueOpt, source.TryBackgroundColor with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.BackgroundColor <- value
            | Some _, None -> target.BackgroundColor <- Xamarin.Forms.Color.Default // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryHeightRequest
            match prevValueOpt, source.TryHeightRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.HeightRequest <- value
            | Some _, None -> target.HeightRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryInputTransparent
            match prevValueOpt, source.TryInputTransparent with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.InputTransparent <- value
            | Some _, None -> target.InputTransparent <- false // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsEnabled
            match prevValueOpt, source.TryIsEnabled with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsEnabled <- value
            | Some _, None -> target.IsEnabled <- true // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsVisible
            match prevValueOpt, source.TryIsVisible with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsVisible <- value
            | Some _, None -> target.IsVisible <- true // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMinimumHeightRequest
            match prevValueOpt, source.TryMinimumHeightRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.MinimumHeightRequest <- value
            | Some _, None -> target.MinimumHeightRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMinimumWidthRequest
            match prevValueOpt, source.TryMinimumWidthRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.MinimumWidthRequest <- value
            | Some _, None -> target.MinimumWidthRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryOpacity
            match prevValueOpt, source.TryOpacity with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Opacity <- value
            | Some _, None -> target.Opacity <- 1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotation
            match prevValueOpt, source.TryRotation with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Rotation <- value
            | Some _, None -> target.Rotation <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotationX
            match prevValueOpt, source.TryRotationX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.RotationX <- value
            | Some _, None -> target.RotationX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotationY
            match prevValueOpt, source.TryRotationY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.RotationY <- value
            | Some _, None -> target.RotationY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryScale
            match prevValueOpt, source.TryScale with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Scale <- value
            | Some _, None -> target.Scale <- 1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryStyle
            match prevValueOpt, source.TryStyle with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Style <- value
            | Some _, None -> target.Style <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryTranslationX
            match prevValueOpt, source.TryTranslationX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.TranslationX <- value
            | Some _, None -> target.TranslationX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryTranslationY
            match prevValueOpt, source.TryTranslationY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.TranslationY <- value
            | Some _, None -> target.TranslationY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryWidthRequest
            match prevValueOpt, source.TryWidthRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.WidthRequest <- value
            | Some _, None -> target.WidthRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryClassId
            match prevValueOpt, source.TryClassId with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.ClassId <- value
            | Some _, None -> target.ClassId <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryStyleId
            match prevValueOpt, source.TryStyleId with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.StyleId <- value
            | Some _, None -> target.StyleId <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
        new XamlElement(typeof<Xamarin.Forms.ScrollView>, create, apply, Map.ofArray attribs)

    /// Describes a SearchBar in the view
    static member SearchBar(?cancelButtonColor: Xamarin.Forms.Color, ?fontFamily: string, ?fontAttributes: Xamarin.Forms.FontAttributes, ?fontSize: obj, ?horizontalTextAlignment: Xamarin.Forms.TextAlignment, ?placeholder: string, ?placeholderColor: Xamarin.Forms.Color, ?searchCommand: unit -> unit, ?text: string, ?textColor: Xamarin.Forms.Color, ?horizontalOptions: Xamarin.Forms.LayoutOptions, ?verticalOptions: Xamarin.Forms.LayoutOptions, ?margin: obj, ?gestureRecognizers: XamlElement list, ?anchorX: double, ?anchorY: double, ?backgroundColor: Xamarin.Forms.Color, ?heightRequest: double, ?inputTransparent: bool, ?isEnabled: bool, ?isVisible: bool, ?minimumHeightRequest: double, ?minimumWidthRequest: double, ?opacity: double, ?rotation: double, ?rotationX: double, ?rotationY: double, ?scale: double, ?style: Xamarin.Forms.Style, ?translationX: double, ?translationY: double, ?widthRequest: double, ?classId: string, ?styleId: string) = 
        let attribs = [| 
            match cancelButtonColor with None -> () | Some v -> yield ("CancelButtonColor", box ((v))) 
            match fontFamily with None -> () | Some v -> yield ("FontFamily", box ((v))) 
            match fontAttributes with None -> () | Some v -> yield ("FontAttributes", box ((v))) 
            match fontSize with None -> () | Some v -> yield ("FontSize", box (makeFontSize(v))) 
            match horizontalTextAlignment with None -> () | Some v -> yield ("HorizontalTextAlignment", box ((v))) 
            match placeholder with None -> () | Some v -> yield ("Placeholder", box ((v))) 
            match placeholderColor with None -> () | Some v -> yield ("PlaceholderColor", box ((v))) 
            match searchCommand with None -> () | Some v -> yield ("SearchCommand", box (makeCommand(v))) 
            match text with None -> () | Some v -> yield ("Text", box ((v))) 
            match textColor with None -> () | Some v -> yield ("TextColor", box ((v))) 
            match horizontalOptions with None -> () | Some v -> yield ("HorizontalOptions", box ((v))) 
            match verticalOptions with None -> () | Some v -> yield ("VerticalOptions", box ((v))) 
            match margin with None -> () | Some v -> yield ("Margin", box (makeThickness(v))) 
            match gestureRecognizers with None -> () | Some v -> yield ("GestureRecognizers", box (Array.ofList(v))) 
            match anchorX with None -> () | Some v -> yield ("AnchorX", box ((v))) 
            match anchorY with None -> () | Some v -> yield ("AnchorY", box ((v))) 
            match backgroundColor with None -> () | Some v -> yield ("BackgroundColor", box ((v))) 
            match heightRequest with None -> () | Some v -> yield ("HeightRequest", box ((v))) 
            match inputTransparent with None -> () | Some v -> yield ("InputTransparent", box ((v))) 
            match isEnabled with None -> () | Some v -> yield ("IsEnabled", box ((v))) 
            match isVisible with None -> () | Some v -> yield ("IsVisible", box ((v))) 
            match minimumHeightRequest with None -> () | Some v -> yield ("MinimumHeightRequest", box ((v))) 
            match minimumWidthRequest with None -> () | Some v -> yield ("MinimumWidthRequest", box ((v))) 
            match opacity with None -> () | Some v -> yield ("Opacity", box ((v))) 
            match rotation with None -> () | Some v -> yield ("Rotation", box ((v))) 
            match rotationX with None -> () | Some v -> yield ("RotationX", box ((v))) 
            match rotationY with None -> () | Some v -> yield ("RotationY", box ((v))) 
            match scale with None -> () | Some v -> yield ("Scale", box ((v))) 
            match style with None -> () | Some v -> yield ("Style", box ((v))) 
            match translationX with None -> () | Some v -> yield ("TranslationX", box ((v))) 
            match translationY with None -> () | Some v -> yield ("TranslationY", box ((v))) 
            match widthRequest with None -> () | Some v -> yield ("WidthRequest", box ((v))) 
            match classId with None -> () | Some v -> yield ("ClassId", box ((v))) 
            match styleId with None -> () | Some v -> yield ("StyleId", box ((v))) 
          |]

        let create () =
            box (new Xamarin.Forms.SearchBar())

        let apply (prevOpt: XamlElement option) (source: XamlElement) (target:obj) = 
            let target = (target :?> Xamarin.Forms.SearchBar)
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryCancelButtonColor
            match prevValueOpt, source.TryCancelButtonColor with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.CancelButtonColor <- value
            | Some _, None -> target.CancelButtonColor <- Xamarin.Forms.Color.Default // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryFontFamily
            match prevValueOpt, source.TryFontFamily with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.FontFamily <- value
            | Some _, None -> target.FontFamily <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryFontAttributes
            match prevValueOpt, source.TryFontAttributes with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.FontAttributes <- value
            | Some _, None -> target.FontAttributes <- Xamarin.Forms.FontAttributes.None // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryFontSize
            match prevValueOpt, source.TryFontSize with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.FontSize <- value
            | Some _, None -> target.FontSize <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryHorizontalTextAlignment
            match prevValueOpt, source.TryHorizontalTextAlignment with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.HorizontalTextAlignment <- value
            | Some _, None -> target.HorizontalTextAlignment <- Xamarin.Forms.TextAlignment.Start // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryPlaceholder
            match prevValueOpt, source.TryPlaceholder with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Placeholder <- value
            | Some _, None -> target.Placeholder <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryPlaceholderColor
            match prevValueOpt, source.TryPlaceholderColor with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.PlaceholderColor <- value
            | Some _, None -> target.PlaceholderColor <- Xamarin.Forms.Color.Default // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TrySearchCommand
            match prevValueOpt, source.TrySearchCommand with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.SearchCommand <- value
            | Some _, None -> target.SearchCommand <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryText
            match prevValueOpt, source.TryText with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Text <- value
            | Some _, None -> target.Text <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryTextColor
            match prevValueOpt, source.TryTextColor with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.TextColor <- value
            | Some _, None -> target.TextColor <- Xamarin.Forms.Color.Default // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryHorizontalOptions
            match prevValueOpt, source.TryHorizontalOptions with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.HorizontalOptions <- value
            | Some _, None -> target.HorizontalOptions <- Unchecked.defaultof<Xamarin.Forms.LayoutOptions> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryVerticalOptions
            match prevValueOpt, source.TryVerticalOptions with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.VerticalOptions <- value
            | Some _, None -> target.VerticalOptions <- Unchecked.defaultof<Xamarin.Forms.LayoutOptions> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMargin
            match prevValueOpt, source.TryMargin with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Margin <- value
            | Some _, None -> target.Margin <- Unchecked.defaultof<Xamarin.Forms.Thickness> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevCollOpt = match prevOpt with None -> None | Some prev -> prev.TryGestureRecognizers
            match prevCollOpt, source.TryGestureRecognizers with
            // For structured objects, amortize on reference equality
            | Some prevColl, Some newColl when System.Object.ReferenceEquals(prevColl, newColl) -> ()
            | _, Some coll when coll <> null && coll.Length > 0 ->
                applyToIList
                    prevCollOpt
                    coll
                    target.GestureRecognizers
                    (fun (x:XamlElement) -> x.CreateAsIGestureRecognizer())
                    (fun _ _ _ -> ())
                    (fun (prevChild:XamlElement) (newChild:XamlElement) -> prevChild.TargetType = newChild.TargetType)
                    (fun prevChild newChild targetChild -> newChild.ApplyIncremental(prevChild, targetChild))
            | _ -> target.GestureRecognizers.Clear()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryAnchorX
            match prevValueOpt, source.TryAnchorX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.AnchorX <- value
            | Some _, None -> target.AnchorX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryAnchorY
            match prevValueOpt, source.TryAnchorY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.AnchorY <- value
            | Some _, None -> target.AnchorY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryBackgroundColor
            match prevValueOpt, source.TryBackgroundColor with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.BackgroundColor <- value
            | Some _, None -> target.BackgroundColor <- Xamarin.Forms.Color.Default // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryHeightRequest
            match prevValueOpt, source.TryHeightRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.HeightRequest <- value
            | Some _, None -> target.HeightRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryInputTransparent
            match prevValueOpt, source.TryInputTransparent with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.InputTransparent <- value
            | Some _, None -> target.InputTransparent <- false // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsEnabled
            match prevValueOpt, source.TryIsEnabled with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsEnabled <- value
            | Some _, None -> target.IsEnabled <- true // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsVisible
            match prevValueOpt, source.TryIsVisible with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsVisible <- value
            | Some _, None -> target.IsVisible <- true // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMinimumHeightRequest
            match prevValueOpt, source.TryMinimumHeightRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.MinimumHeightRequest <- value
            | Some _, None -> target.MinimumHeightRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMinimumWidthRequest
            match prevValueOpt, source.TryMinimumWidthRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.MinimumWidthRequest <- value
            | Some _, None -> target.MinimumWidthRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryOpacity
            match prevValueOpt, source.TryOpacity with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Opacity <- value
            | Some _, None -> target.Opacity <- 1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotation
            match prevValueOpt, source.TryRotation with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Rotation <- value
            | Some _, None -> target.Rotation <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotationX
            match prevValueOpt, source.TryRotationX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.RotationX <- value
            | Some _, None -> target.RotationX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotationY
            match prevValueOpt, source.TryRotationY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.RotationY <- value
            | Some _, None -> target.RotationY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryScale
            match prevValueOpt, source.TryScale with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Scale <- value
            | Some _, None -> target.Scale <- 1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryStyle
            match prevValueOpt, source.TryStyle with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Style <- value
            | Some _, None -> target.Style <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryTranslationX
            match prevValueOpt, source.TryTranslationX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.TranslationX <- value
            | Some _, None -> target.TranslationX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryTranslationY
            match prevValueOpt, source.TryTranslationY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.TranslationY <- value
            | Some _, None -> target.TranslationY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryWidthRequest
            match prevValueOpt, source.TryWidthRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.WidthRequest <- value
            | Some _, None -> target.WidthRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryClassId
            match prevValueOpt, source.TryClassId with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.ClassId <- value
            | Some _, None -> target.ClassId <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryStyleId
            match prevValueOpt, source.TryStyleId with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.StyleId <- value
            | Some _, None -> target.StyleId <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
        new XamlElement(typeof<Xamarin.Forms.SearchBar>, create, apply, Map.ofArray attribs)

    /// Describes a Button in the view
    static member Button(?text: string, ?command: unit -> unit, ?borderColor: Xamarin.Forms.Color, ?borderWidth: double, ?commandParameter: System.Object, ?contentLayout: Xamarin.Forms.Button.ButtonContentLayout, ?cornerRadius: int, ?fontFamily: string, ?fontAttributes: Xamarin.Forms.FontAttributes, ?fontSize: obj, ?image: string, ?textColor: Xamarin.Forms.Color, ?horizontalOptions: Xamarin.Forms.LayoutOptions, ?verticalOptions: Xamarin.Forms.LayoutOptions, ?margin: obj, ?gestureRecognizers: XamlElement list, ?anchorX: double, ?anchorY: double, ?backgroundColor: Xamarin.Forms.Color, ?heightRequest: double, ?inputTransparent: bool, ?isEnabled: bool, ?isVisible: bool, ?minimumHeightRequest: double, ?minimumWidthRequest: double, ?opacity: double, ?rotation: double, ?rotationX: double, ?rotationY: double, ?scale: double, ?style: Xamarin.Forms.Style, ?translationX: double, ?translationY: double, ?widthRequest: double, ?classId: string, ?styleId: string) = 
        let attribs = [| 
            match text with None -> () | Some v -> yield ("Text", box ((v))) 
            match command with None -> () | Some v -> yield ("Command", box (makeCommand(v))) 
            match borderColor with None -> () | Some v -> yield ("BorderColor", box ((v))) 
            match borderWidth with None -> () | Some v -> yield ("BorderWidth", box ((v))) 
            match commandParameter with None -> () | Some v -> yield ("CommandParameter", box ((v))) 
            match contentLayout with None -> () | Some v -> yield ("ContentLayout", box ((v))) 
            match cornerRadius with None -> () | Some v -> yield ("ButtonCornerRadius", box ((v))) 
            match fontFamily with None -> () | Some v -> yield ("FontFamily", box ((v))) 
            match fontAttributes with None -> () | Some v -> yield ("FontAttributes", box ((v))) 
            match fontSize with None -> () | Some v -> yield ("FontSize", box (makeFontSize(v))) 
            match image with None -> () | Some v -> yield ("ButtonImageSource", box (makeFileImageSource(v))) 
            match textColor with None -> () | Some v -> yield ("TextColor", box ((v))) 
            match horizontalOptions with None -> () | Some v -> yield ("HorizontalOptions", box ((v))) 
            match verticalOptions with None -> () | Some v -> yield ("VerticalOptions", box ((v))) 
            match margin with None -> () | Some v -> yield ("Margin", box (makeThickness(v))) 
            match gestureRecognizers with None -> () | Some v -> yield ("GestureRecognizers", box (Array.ofList(v))) 
            match anchorX with None -> () | Some v -> yield ("AnchorX", box ((v))) 
            match anchorY with None -> () | Some v -> yield ("AnchorY", box ((v))) 
            match backgroundColor with None -> () | Some v -> yield ("BackgroundColor", box ((v))) 
            match heightRequest with None -> () | Some v -> yield ("HeightRequest", box ((v))) 
            match inputTransparent with None -> () | Some v -> yield ("InputTransparent", box ((v))) 
            match isEnabled with None -> () | Some v -> yield ("IsEnabled", box ((v))) 
            match isVisible with None -> () | Some v -> yield ("IsVisible", box ((v))) 
            match minimumHeightRequest with None -> () | Some v -> yield ("MinimumHeightRequest", box ((v))) 
            match minimumWidthRequest with None -> () | Some v -> yield ("MinimumWidthRequest", box ((v))) 
            match opacity with None -> () | Some v -> yield ("Opacity", box ((v))) 
            match rotation with None -> () | Some v -> yield ("Rotation", box ((v))) 
            match rotationX with None -> () | Some v -> yield ("RotationX", box ((v))) 
            match rotationY with None -> () | Some v -> yield ("RotationY", box ((v))) 
            match scale with None -> () | Some v -> yield ("Scale", box ((v))) 
            match style with None -> () | Some v -> yield ("Style", box ((v))) 
            match translationX with None -> () | Some v -> yield ("TranslationX", box ((v))) 
            match translationY with None -> () | Some v -> yield ("TranslationY", box ((v))) 
            match widthRequest with None -> () | Some v -> yield ("WidthRequest", box ((v))) 
            match classId with None -> () | Some v -> yield ("ClassId", box ((v))) 
            match styleId with None -> () | Some v -> yield ("StyleId", box ((v))) 
          |]

        let create () =
            box (new Xamarin.Forms.Button())

        let apply (prevOpt: XamlElement option) (source: XamlElement) (target:obj) = 
            let target = (target :?> Xamarin.Forms.Button)
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryText
            match prevValueOpt, source.TryText with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Text <- value
            | Some _, None -> target.Text <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryCommand
            match prevValueOpt, source.TryCommand with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Command <- value
            | Some _, None -> target.Command <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryBorderColor
            match prevValueOpt, source.TryBorderColor with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.BorderColor <- value
            | Some _, None -> target.BorderColor <- Xamarin.Forms.Color.Default // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryBorderWidth
            match prevValueOpt, source.TryBorderWidth with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.BorderWidth <- value
            | Some _, None -> target.BorderWidth <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryCommandParameter
            match prevValueOpt, source.TryCommandParameter with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.CommandParameter <- value
            | Some _, None -> target.CommandParameter <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryContentLayout
            match prevValueOpt, source.TryContentLayout with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.ContentLayout <- value
            | Some _, None -> target.ContentLayout <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryButtonCornerRadius
            match prevValueOpt, source.TryButtonCornerRadius with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.CornerRadius <- value
            | Some _, None -> target.CornerRadius <- 0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryFontFamily
            match prevValueOpt, source.TryFontFamily with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.FontFamily <- value
            | Some _, None -> target.FontFamily <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryFontAttributes
            match prevValueOpt, source.TryFontAttributes with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.FontAttributes <- value
            | Some _, None -> target.FontAttributes <- Xamarin.Forms.FontAttributes.None // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryFontSize
            match prevValueOpt, source.TryFontSize with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.FontSize <- value
            | Some _, None -> target.FontSize <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryButtonImageSource
            match prevValueOpt, source.TryButtonImageSource with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Image <- value
            | Some _, None -> target.Image <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryTextColor
            match prevValueOpt, source.TryTextColor with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.TextColor <- value
            | Some _, None -> target.TextColor <- Xamarin.Forms.Color.Default // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryHorizontalOptions
            match prevValueOpt, source.TryHorizontalOptions with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.HorizontalOptions <- value
            | Some _, None -> target.HorizontalOptions <- Unchecked.defaultof<Xamarin.Forms.LayoutOptions> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryVerticalOptions
            match prevValueOpt, source.TryVerticalOptions with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.VerticalOptions <- value
            | Some _, None -> target.VerticalOptions <- Unchecked.defaultof<Xamarin.Forms.LayoutOptions> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMargin
            match prevValueOpt, source.TryMargin with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Margin <- value
            | Some _, None -> target.Margin <- Unchecked.defaultof<Xamarin.Forms.Thickness> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevCollOpt = match prevOpt with None -> None | Some prev -> prev.TryGestureRecognizers
            match prevCollOpt, source.TryGestureRecognizers with
            // For structured objects, amortize on reference equality
            | Some prevColl, Some newColl when System.Object.ReferenceEquals(prevColl, newColl) -> ()
            | _, Some coll when coll <> null && coll.Length > 0 ->
                applyToIList
                    prevCollOpt
                    coll
                    target.GestureRecognizers
                    (fun (x:XamlElement) -> x.CreateAsIGestureRecognizer())
                    (fun _ _ _ -> ())
                    (fun (prevChild:XamlElement) (newChild:XamlElement) -> prevChild.TargetType = newChild.TargetType)
                    (fun prevChild newChild targetChild -> newChild.ApplyIncremental(prevChild, targetChild))
            | _ -> target.GestureRecognizers.Clear()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryAnchorX
            match prevValueOpt, source.TryAnchorX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.AnchorX <- value
            | Some _, None -> target.AnchorX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryAnchorY
            match prevValueOpt, source.TryAnchorY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.AnchorY <- value
            | Some _, None -> target.AnchorY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryBackgroundColor
            match prevValueOpt, source.TryBackgroundColor with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.BackgroundColor <- value
            | Some _, None -> target.BackgroundColor <- Xamarin.Forms.Color.Default // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryHeightRequest
            match prevValueOpt, source.TryHeightRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.HeightRequest <- value
            | Some _, None -> target.HeightRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryInputTransparent
            match prevValueOpt, source.TryInputTransparent with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.InputTransparent <- value
            | Some _, None -> target.InputTransparent <- false // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsEnabled
            match prevValueOpt, source.TryIsEnabled with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsEnabled <- value
            | Some _, None -> target.IsEnabled <- true // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsVisible
            match prevValueOpt, source.TryIsVisible with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsVisible <- value
            | Some _, None -> target.IsVisible <- true // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMinimumHeightRequest
            match prevValueOpt, source.TryMinimumHeightRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.MinimumHeightRequest <- value
            | Some _, None -> target.MinimumHeightRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMinimumWidthRequest
            match prevValueOpt, source.TryMinimumWidthRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.MinimumWidthRequest <- value
            | Some _, None -> target.MinimumWidthRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryOpacity
            match prevValueOpt, source.TryOpacity with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Opacity <- value
            | Some _, None -> target.Opacity <- 1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotation
            match prevValueOpt, source.TryRotation with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Rotation <- value
            | Some _, None -> target.Rotation <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotationX
            match prevValueOpt, source.TryRotationX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.RotationX <- value
            | Some _, None -> target.RotationX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotationY
            match prevValueOpt, source.TryRotationY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.RotationY <- value
            | Some _, None -> target.RotationY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryScale
            match prevValueOpt, source.TryScale with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Scale <- value
            | Some _, None -> target.Scale <- 1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryStyle
            match prevValueOpt, source.TryStyle with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Style <- value
            | Some _, None -> target.Style <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryTranslationX
            match prevValueOpt, source.TryTranslationX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.TranslationX <- value
            | Some _, None -> target.TranslationX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryTranslationY
            match prevValueOpt, source.TryTranslationY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.TranslationY <- value
            | Some _, None -> target.TranslationY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryWidthRequest
            match prevValueOpt, source.TryWidthRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.WidthRequest <- value
            | Some _, None -> target.WidthRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryClassId
            match prevValueOpt, source.TryClassId with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.ClassId <- value
            | Some _, None -> target.ClassId <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryStyleId
            match prevValueOpt, source.TryStyleId with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.StyleId <- value
            | Some _, None -> target.StyleId <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
        new XamlElement(typeof<Xamarin.Forms.Button>, create, apply, Map.ofArray attribs)

    /// Describes a Slider in the view
    static member Slider(?minimum: double, ?maximum: double, ?value: double, ?valueChanged: Xamarin.Forms.ValueChangedEventArgs -> unit, ?horizontalOptions: Xamarin.Forms.LayoutOptions, ?verticalOptions: Xamarin.Forms.LayoutOptions, ?margin: obj, ?gestureRecognizers: XamlElement list, ?anchorX: double, ?anchorY: double, ?backgroundColor: Xamarin.Forms.Color, ?heightRequest: double, ?inputTransparent: bool, ?isEnabled: bool, ?isVisible: bool, ?minimumHeightRequest: double, ?minimumWidthRequest: double, ?opacity: double, ?rotation: double, ?rotationX: double, ?rotationY: double, ?scale: double, ?style: Xamarin.Forms.Style, ?translationX: double, ?translationY: double, ?widthRequest: double, ?classId: string, ?styleId: string) = 
        let attribs = [| 
            match minimum with None -> () | Some v -> yield ("Minimum", box ((v))) 
            match maximum with None -> () | Some v -> yield ("Maximum", box ((v))) 
            match value with None -> () | Some v -> yield ("Value", box ((v))) 
            match valueChanged with None -> () | Some v -> yield ("ValueChanged", box ((fun f -> System.EventHandler<Xamarin.Forms.ValueChangedEventArgs>(fun _sender args -> f args))(v))) 
            match horizontalOptions with None -> () | Some v -> yield ("HorizontalOptions", box ((v))) 
            match verticalOptions with None -> () | Some v -> yield ("VerticalOptions", box ((v))) 
            match margin with None -> () | Some v -> yield ("Margin", box (makeThickness(v))) 
            match gestureRecognizers with None -> () | Some v -> yield ("GestureRecognizers", box (Array.ofList(v))) 
            match anchorX with None -> () | Some v -> yield ("AnchorX", box ((v))) 
            match anchorY with None -> () | Some v -> yield ("AnchorY", box ((v))) 
            match backgroundColor with None -> () | Some v -> yield ("BackgroundColor", box ((v))) 
            match heightRequest with None -> () | Some v -> yield ("HeightRequest", box ((v))) 
            match inputTransparent with None -> () | Some v -> yield ("InputTransparent", box ((v))) 
            match isEnabled with None -> () | Some v -> yield ("IsEnabled", box ((v))) 
            match isVisible with None -> () | Some v -> yield ("IsVisible", box ((v))) 
            match minimumHeightRequest with None -> () | Some v -> yield ("MinimumHeightRequest", box ((v))) 
            match minimumWidthRequest with None -> () | Some v -> yield ("MinimumWidthRequest", box ((v))) 
            match opacity with None -> () | Some v -> yield ("Opacity", box ((v))) 
            match rotation with None -> () | Some v -> yield ("Rotation", box ((v))) 
            match rotationX with None -> () | Some v -> yield ("RotationX", box ((v))) 
            match rotationY with None -> () | Some v -> yield ("RotationY", box ((v))) 
            match scale with None -> () | Some v -> yield ("Scale", box ((v))) 
            match style with None -> () | Some v -> yield ("Style", box ((v))) 
            match translationX with None -> () | Some v -> yield ("TranslationX", box ((v))) 
            match translationY with None -> () | Some v -> yield ("TranslationY", box ((v))) 
            match widthRequest with None -> () | Some v -> yield ("WidthRequest", box ((v))) 
            match classId with None -> () | Some v -> yield ("ClassId", box ((v))) 
            match styleId with None -> () | Some v -> yield ("StyleId", box ((v))) 
          |]

        let create () =
            box (new Xamarin.Forms.Slider())

        let apply (prevOpt: XamlElement option) (source: XamlElement) (target:obj) = 
            let target = (target :?> Xamarin.Forms.Slider)
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMinimum
            match prevValueOpt, source.TryMinimum with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Minimum <- value
            | Some _, None -> target.Minimum <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMaximum
            match prevValueOpt, source.TryMaximum with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Maximum <- value
            | Some _, None -> target.Maximum <- 1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryValue
            match prevValueOpt, source.TryValue with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Value <- value
            | Some _, None -> target.Value <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryValueChanged
            match prevValueOpt, source.TryValueChanged with
            | Some prevValue, Some value when System.Object.ReferenceEquals(prevValue, value) -> ()
            | Some prevValue, Some value -> target.ValueChanged.RemoveHandler(prevValue); target.ValueChanged.AddHandler(value)
            | None, Some value -> target.ValueChanged.AddHandler(value)
            | Some prevValue, None -> target.ValueChanged.RemoveHandler(prevValue)
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryHorizontalOptions
            match prevValueOpt, source.TryHorizontalOptions with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.HorizontalOptions <- value
            | Some _, None -> target.HorizontalOptions <- Unchecked.defaultof<Xamarin.Forms.LayoutOptions> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryVerticalOptions
            match prevValueOpt, source.TryVerticalOptions with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.VerticalOptions <- value
            | Some _, None -> target.VerticalOptions <- Unchecked.defaultof<Xamarin.Forms.LayoutOptions> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMargin
            match prevValueOpt, source.TryMargin with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Margin <- value
            | Some _, None -> target.Margin <- Unchecked.defaultof<Xamarin.Forms.Thickness> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevCollOpt = match prevOpt with None -> None | Some prev -> prev.TryGestureRecognizers
            match prevCollOpt, source.TryGestureRecognizers with
            // For structured objects, amortize on reference equality
            | Some prevColl, Some newColl when System.Object.ReferenceEquals(prevColl, newColl) -> ()
            | _, Some coll when coll <> null && coll.Length > 0 ->
                applyToIList
                    prevCollOpt
                    coll
                    target.GestureRecognizers
                    (fun (x:XamlElement) -> x.CreateAsIGestureRecognizer())
                    (fun _ _ _ -> ())
                    (fun (prevChild:XamlElement) (newChild:XamlElement) -> prevChild.TargetType = newChild.TargetType)
                    (fun prevChild newChild targetChild -> newChild.ApplyIncremental(prevChild, targetChild))
            | _ -> target.GestureRecognizers.Clear()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryAnchorX
            match prevValueOpt, source.TryAnchorX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.AnchorX <- value
            | Some _, None -> target.AnchorX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryAnchorY
            match prevValueOpt, source.TryAnchorY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.AnchorY <- value
            | Some _, None -> target.AnchorY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryBackgroundColor
            match prevValueOpt, source.TryBackgroundColor with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.BackgroundColor <- value
            | Some _, None -> target.BackgroundColor <- Xamarin.Forms.Color.Default // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryHeightRequest
            match prevValueOpt, source.TryHeightRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.HeightRequest <- value
            | Some _, None -> target.HeightRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryInputTransparent
            match prevValueOpt, source.TryInputTransparent with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.InputTransparent <- value
            | Some _, None -> target.InputTransparent <- false // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsEnabled
            match prevValueOpt, source.TryIsEnabled with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsEnabled <- value
            | Some _, None -> target.IsEnabled <- true // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsVisible
            match prevValueOpt, source.TryIsVisible with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsVisible <- value
            | Some _, None -> target.IsVisible <- true // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMinimumHeightRequest
            match prevValueOpt, source.TryMinimumHeightRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.MinimumHeightRequest <- value
            | Some _, None -> target.MinimumHeightRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMinimumWidthRequest
            match prevValueOpt, source.TryMinimumWidthRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.MinimumWidthRequest <- value
            | Some _, None -> target.MinimumWidthRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryOpacity
            match prevValueOpt, source.TryOpacity with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Opacity <- value
            | Some _, None -> target.Opacity <- 1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotation
            match prevValueOpt, source.TryRotation with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Rotation <- value
            | Some _, None -> target.Rotation <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotationX
            match prevValueOpt, source.TryRotationX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.RotationX <- value
            | Some _, None -> target.RotationX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotationY
            match prevValueOpt, source.TryRotationY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.RotationY <- value
            | Some _, None -> target.RotationY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryScale
            match prevValueOpt, source.TryScale with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Scale <- value
            | Some _, None -> target.Scale <- 1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryStyle
            match prevValueOpt, source.TryStyle with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Style <- value
            | Some _, None -> target.Style <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryTranslationX
            match prevValueOpt, source.TryTranslationX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.TranslationX <- value
            | Some _, None -> target.TranslationX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryTranslationY
            match prevValueOpt, source.TryTranslationY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.TranslationY <- value
            | Some _, None -> target.TranslationY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryWidthRequest
            match prevValueOpt, source.TryWidthRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.WidthRequest <- value
            | Some _, None -> target.WidthRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryClassId
            match prevValueOpt, source.TryClassId with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.ClassId <- value
            | Some _, None -> target.ClassId <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryStyleId
            match prevValueOpt, source.TryStyleId with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.StyleId <- value
            | Some _, None -> target.StyleId <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
        new XamlElement(typeof<Xamarin.Forms.Slider>, create, apply, Map.ofArray attribs)

    /// Describes a Stepper in the view
    static member Stepper(?minimum: double, ?maximum: double, ?value: double, ?increment: double, ?valueChanged: Xamarin.Forms.ValueChangedEventArgs -> unit, ?horizontalOptions: Xamarin.Forms.LayoutOptions, ?verticalOptions: Xamarin.Forms.LayoutOptions, ?margin: obj, ?gestureRecognizers: XamlElement list, ?anchorX: double, ?anchorY: double, ?backgroundColor: Xamarin.Forms.Color, ?heightRequest: double, ?inputTransparent: bool, ?isEnabled: bool, ?isVisible: bool, ?minimumHeightRequest: double, ?minimumWidthRequest: double, ?opacity: double, ?rotation: double, ?rotationX: double, ?rotationY: double, ?scale: double, ?style: Xamarin.Forms.Style, ?translationX: double, ?translationY: double, ?widthRequest: double, ?classId: string, ?styleId: string) = 
        let attribs = [| 
            match minimum with None -> () | Some v -> yield ("Minimum", box ((v))) 
            match maximum with None -> () | Some v -> yield ("Maximum", box ((v))) 
            match value with None -> () | Some v -> yield ("Value", box ((v))) 
            match increment with None -> () | Some v -> yield ("Increment", box ((v))) 
            match valueChanged with None -> () | Some v -> yield ("ValueChanged", box ((fun f -> System.EventHandler<Xamarin.Forms.ValueChangedEventArgs>(fun _sender args -> f args))(v))) 
            match horizontalOptions with None -> () | Some v -> yield ("HorizontalOptions", box ((v))) 
            match verticalOptions with None -> () | Some v -> yield ("VerticalOptions", box ((v))) 
            match margin with None -> () | Some v -> yield ("Margin", box (makeThickness(v))) 
            match gestureRecognizers with None -> () | Some v -> yield ("GestureRecognizers", box (Array.ofList(v))) 
            match anchorX with None -> () | Some v -> yield ("AnchorX", box ((v))) 
            match anchorY with None -> () | Some v -> yield ("AnchorY", box ((v))) 
            match backgroundColor with None -> () | Some v -> yield ("BackgroundColor", box ((v))) 
            match heightRequest with None -> () | Some v -> yield ("HeightRequest", box ((v))) 
            match inputTransparent with None -> () | Some v -> yield ("InputTransparent", box ((v))) 
            match isEnabled with None -> () | Some v -> yield ("IsEnabled", box ((v))) 
            match isVisible with None -> () | Some v -> yield ("IsVisible", box ((v))) 
            match minimumHeightRequest with None -> () | Some v -> yield ("MinimumHeightRequest", box ((v))) 
            match minimumWidthRequest with None -> () | Some v -> yield ("MinimumWidthRequest", box ((v))) 
            match opacity with None -> () | Some v -> yield ("Opacity", box ((v))) 
            match rotation with None -> () | Some v -> yield ("Rotation", box ((v))) 
            match rotationX with None -> () | Some v -> yield ("RotationX", box ((v))) 
            match rotationY with None -> () | Some v -> yield ("RotationY", box ((v))) 
            match scale with None -> () | Some v -> yield ("Scale", box ((v))) 
            match style with None -> () | Some v -> yield ("Style", box ((v))) 
            match translationX with None -> () | Some v -> yield ("TranslationX", box ((v))) 
            match translationY with None -> () | Some v -> yield ("TranslationY", box ((v))) 
            match widthRequest with None -> () | Some v -> yield ("WidthRequest", box ((v))) 
            match classId with None -> () | Some v -> yield ("ClassId", box ((v))) 
            match styleId with None -> () | Some v -> yield ("StyleId", box ((v))) 
          |]

        let create () =
            box (new Xamarin.Forms.Stepper())

        let apply (prevOpt: XamlElement option) (source: XamlElement) (target:obj) = 
            let target = (target :?> Xamarin.Forms.Stepper)
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMinimum
            match prevValueOpt, source.TryMinimum with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Minimum <- value
            | Some _, None -> target.Minimum <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMaximum
            match prevValueOpt, source.TryMaximum with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Maximum <- value
            | Some _, None -> target.Maximum <- 1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryValue
            match prevValueOpt, source.TryValue with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Value <- value
            | Some _, None -> target.Value <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIncrement
            match prevValueOpt, source.TryIncrement with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Increment <- value
            | Some _, None -> target.Increment <- 1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryValueChanged
            match prevValueOpt, source.TryValueChanged with
            | Some prevValue, Some value when System.Object.ReferenceEquals(prevValue, value) -> ()
            | Some prevValue, Some value -> target.ValueChanged.RemoveHandler(prevValue); target.ValueChanged.AddHandler(value)
            | None, Some value -> target.ValueChanged.AddHandler(value)
            | Some prevValue, None -> target.ValueChanged.RemoveHandler(prevValue)
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryHorizontalOptions
            match prevValueOpt, source.TryHorizontalOptions with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.HorizontalOptions <- value
            | Some _, None -> target.HorizontalOptions <- Unchecked.defaultof<Xamarin.Forms.LayoutOptions> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryVerticalOptions
            match prevValueOpt, source.TryVerticalOptions with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.VerticalOptions <- value
            | Some _, None -> target.VerticalOptions <- Unchecked.defaultof<Xamarin.Forms.LayoutOptions> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMargin
            match prevValueOpt, source.TryMargin with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Margin <- value
            | Some _, None -> target.Margin <- Unchecked.defaultof<Xamarin.Forms.Thickness> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevCollOpt = match prevOpt with None -> None | Some prev -> prev.TryGestureRecognizers
            match prevCollOpt, source.TryGestureRecognizers with
            // For structured objects, amortize on reference equality
            | Some prevColl, Some newColl when System.Object.ReferenceEquals(prevColl, newColl) -> ()
            | _, Some coll when coll <> null && coll.Length > 0 ->
                applyToIList
                    prevCollOpt
                    coll
                    target.GestureRecognizers
                    (fun (x:XamlElement) -> x.CreateAsIGestureRecognizer())
                    (fun _ _ _ -> ())
                    (fun (prevChild:XamlElement) (newChild:XamlElement) -> prevChild.TargetType = newChild.TargetType)
                    (fun prevChild newChild targetChild -> newChild.ApplyIncremental(prevChild, targetChild))
            | _ -> target.GestureRecognizers.Clear()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryAnchorX
            match prevValueOpt, source.TryAnchorX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.AnchorX <- value
            | Some _, None -> target.AnchorX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryAnchorY
            match prevValueOpt, source.TryAnchorY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.AnchorY <- value
            | Some _, None -> target.AnchorY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryBackgroundColor
            match prevValueOpt, source.TryBackgroundColor with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.BackgroundColor <- value
            | Some _, None -> target.BackgroundColor <- Xamarin.Forms.Color.Default // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryHeightRequest
            match prevValueOpt, source.TryHeightRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.HeightRequest <- value
            | Some _, None -> target.HeightRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryInputTransparent
            match prevValueOpt, source.TryInputTransparent with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.InputTransparent <- value
            | Some _, None -> target.InputTransparent <- false // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsEnabled
            match prevValueOpt, source.TryIsEnabled with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsEnabled <- value
            | Some _, None -> target.IsEnabled <- true // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsVisible
            match prevValueOpt, source.TryIsVisible with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsVisible <- value
            | Some _, None -> target.IsVisible <- true // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMinimumHeightRequest
            match prevValueOpt, source.TryMinimumHeightRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.MinimumHeightRequest <- value
            | Some _, None -> target.MinimumHeightRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMinimumWidthRequest
            match prevValueOpt, source.TryMinimumWidthRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.MinimumWidthRequest <- value
            | Some _, None -> target.MinimumWidthRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryOpacity
            match prevValueOpt, source.TryOpacity with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Opacity <- value
            | Some _, None -> target.Opacity <- 1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotation
            match prevValueOpt, source.TryRotation with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Rotation <- value
            | Some _, None -> target.Rotation <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotationX
            match prevValueOpt, source.TryRotationX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.RotationX <- value
            | Some _, None -> target.RotationX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotationY
            match prevValueOpt, source.TryRotationY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.RotationY <- value
            | Some _, None -> target.RotationY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryScale
            match prevValueOpt, source.TryScale with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Scale <- value
            | Some _, None -> target.Scale <- 1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryStyle
            match prevValueOpt, source.TryStyle with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Style <- value
            | Some _, None -> target.Style <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryTranslationX
            match prevValueOpt, source.TryTranslationX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.TranslationX <- value
            | Some _, None -> target.TranslationX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryTranslationY
            match prevValueOpt, source.TryTranslationY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.TranslationY <- value
            | Some _, None -> target.TranslationY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryWidthRequest
            match prevValueOpt, source.TryWidthRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.WidthRequest <- value
            | Some _, None -> target.WidthRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryClassId
            match prevValueOpt, source.TryClassId with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.ClassId <- value
            | Some _, None -> target.ClassId <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryStyleId
            match prevValueOpt, source.TryStyleId with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.StyleId <- value
            | Some _, None -> target.StyleId <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
        new XamlElement(typeof<Xamarin.Forms.Stepper>, create, apply, Map.ofArray attribs)

    /// Describes a Switch in the view
    static member Switch(?isToggled: bool, ?toggled: Xamarin.Forms.ToggledEventArgs -> unit, ?horizontalOptions: Xamarin.Forms.LayoutOptions, ?verticalOptions: Xamarin.Forms.LayoutOptions, ?margin: obj, ?gestureRecognizers: XamlElement list, ?anchorX: double, ?anchorY: double, ?backgroundColor: Xamarin.Forms.Color, ?heightRequest: double, ?inputTransparent: bool, ?isEnabled: bool, ?isVisible: bool, ?minimumHeightRequest: double, ?minimumWidthRequest: double, ?opacity: double, ?rotation: double, ?rotationX: double, ?rotationY: double, ?scale: double, ?style: Xamarin.Forms.Style, ?translationX: double, ?translationY: double, ?widthRequest: double, ?classId: string, ?styleId: string) = 
        let attribs = [| 
            match isToggled with None -> () | Some v -> yield ("IsToggled", box ((v))) 
            match toggled with None -> () | Some v -> yield ("Toggled", box ((fun f -> System.EventHandler<Xamarin.Forms.ToggledEventArgs>(fun _sender args -> f args))(v))) 
            match horizontalOptions with None -> () | Some v -> yield ("HorizontalOptions", box ((v))) 
            match verticalOptions with None -> () | Some v -> yield ("VerticalOptions", box ((v))) 
            match margin with None -> () | Some v -> yield ("Margin", box (makeThickness(v))) 
            match gestureRecognizers with None -> () | Some v -> yield ("GestureRecognizers", box (Array.ofList(v))) 
            match anchorX with None -> () | Some v -> yield ("AnchorX", box ((v))) 
            match anchorY with None -> () | Some v -> yield ("AnchorY", box ((v))) 
            match backgroundColor with None -> () | Some v -> yield ("BackgroundColor", box ((v))) 
            match heightRequest with None -> () | Some v -> yield ("HeightRequest", box ((v))) 
            match inputTransparent with None -> () | Some v -> yield ("InputTransparent", box ((v))) 
            match isEnabled with None -> () | Some v -> yield ("IsEnabled", box ((v))) 
            match isVisible with None -> () | Some v -> yield ("IsVisible", box ((v))) 
            match minimumHeightRequest with None -> () | Some v -> yield ("MinimumHeightRequest", box ((v))) 
            match minimumWidthRequest with None -> () | Some v -> yield ("MinimumWidthRequest", box ((v))) 
            match opacity with None -> () | Some v -> yield ("Opacity", box ((v))) 
            match rotation with None -> () | Some v -> yield ("Rotation", box ((v))) 
            match rotationX with None -> () | Some v -> yield ("RotationX", box ((v))) 
            match rotationY with None -> () | Some v -> yield ("RotationY", box ((v))) 
            match scale with None -> () | Some v -> yield ("Scale", box ((v))) 
            match style with None -> () | Some v -> yield ("Style", box ((v))) 
            match translationX with None -> () | Some v -> yield ("TranslationX", box ((v))) 
            match translationY with None -> () | Some v -> yield ("TranslationY", box ((v))) 
            match widthRequest with None -> () | Some v -> yield ("WidthRequest", box ((v))) 
            match classId with None -> () | Some v -> yield ("ClassId", box ((v))) 
            match styleId with None -> () | Some v -> yield ("StyleId", box ((v))) 
          |]

        let create () =
            box (new Xamarin.Forms.Switch())

        let apply (prevOpt: XamlElement option) (source: XamlElement) (target:obj) = 
            let target = (target :?> Xamarin.Forms.Switch)
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsToggled
            match prevValueOpt, source.TryIsToggled with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsToggled <- value
            | Some _, None -> target.IsToggled <- false // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryToggled
            match prevValueOpt, source.TryToggled with
            | Some prevValue, Some value when System.Object.ReferenceEquals(prevValue, value) -> ()
            | Some prevValue, Some value -> target.Toggled.RemoveHandler(prevValue); target.Toggled.AddHandler(value)
            | None, Some value -> target.Toggled.AddHandler(value)
            | Some prevValue, None -> target.Toggled.RemoveHandler(prevValue)
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryHorizontalOptions
            match prevValueOpt, source.TryHorizontalOptions with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.HorizontalOptions <- value
            | Some _, None -> target.HorizontalOptions <- Unchecked.defaultof<Xamarin.Forms.LayoutOptions> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryVerticalOptions
            match prevValueOpt, source.TryVerticalOptions with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.VerticalOptions <- value
            | Some _, None -> target.VerticalOptions <- Unchecked.defaultof<Xamarin.Forms.LayoutOptions> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMargin
            match prevValueOpt, source.TryMargin with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Margin <- value
            | Some _, None -> target.Margin <- Unchecked.defaultof<Xamarin.Forms.Thickness> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevCollOpt = match prevOpt with None -> None | Some prev -> prev.TryGestureRecognizers
            match prevCollOpt, source.TryGestureRecognizers with
            // For structured objects, amortize on reference equality
            | Some prevColl, Some newColl when System.Object.ReferenceEquals(prevColl, newColl) -> ()
            | _, Some coll when coll <> null && coll.Length > 0 ->
                applyToIList
                    prevCollOpt
                    coll
                    target.GestureRecognizers
                    (fun (x:XamlElement) -> x.CreateAsIGestureRecognizer())
                    (fun _ _ _ -> ())
                    (fun (prevChild:XamlElement) (newChild:XamlElement) -> prevChild.TargetType = newChild.TargetType)
                    (fun prevChild newChild targetChild -> newChild.ApplyIncremental(prevChild, targetChild))
            | _ -> target.GestureRecognizers.Clear()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryAnchorX
            match prevValueOpt, source.TryAnchorX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.AnchorX <- value
            | Some _, None -> target.AnchorX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryAnchorY
            match prevValueOpt, source.TryAnchorY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.AnchorY <- value
            | Some _, None -> target.AnchorY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryBackgroundColor
            match prevValueOpt, source.TryBackgroundColor with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.BackgroundColor <- value
            | Some _, None -> target.BackgroundColor <- Xamarin.Forms.Color.Default // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryHeightRequest
            match prevValueOpt, source.TryHeightRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.HeightRequest <- value
            | Some _, None -> target.HeightRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryInputTransparent
            match prevValueOpt, source.TryInputTransparent with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.InputTransparent <- value
            | Some _, None -> target.InputTransparent <- false // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsEnabled
            match prevValueOpt, source.TryIsEnabled with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsEnabled <- value
            | Some _, None -> target.IsEnabled <- true // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsVisible
            match prevValueOpt, source.TryIsVisible with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsVisible <- value
            | Some _, None -> target.IsVisible <- true // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMinimumHeightRequest
            match prevValueOpt, source.TryMinimumHeightRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.MinimumHeightRequest <- value
            | Some _, None -> target.MinimumHeightRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMinimumWidthRequest
            match prevValueOpt, source.TryMinimumWidthRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.MinimumWidthRequest <- value
            | Some _, None -> target.MinimumWidthRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryOpacity
            match prevValueOpt, source.TryOpacity with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Opacity <- value
            | Some _, None -> target.Opacity <- 1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotation
            match prevValueOpt, source.TryRotation with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Rotation <- value
            | Some _, None -> target.Rotation <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotationX
            match prevValueOpt, source.TryRotationX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.RotationX <- value
            | Some _, None -> target.RotationX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotationY
            match prevValueOpt, source.TryRotationY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.RotationY <- value
            | Some _, None -> target.RotationY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryScale
            match prevValueOpt, source.TryScale with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Scale <- value
            | Some _, None -> target.Scale <- 1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryStyle
            match prevValueOpt, source.TryStyle with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Style <- value
            | Some _, None -> target.Style <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryTranslationX
            match prevValueOpt, source.TryTranslationX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.TranslationX <- value
            | Some _, None -> target.TranslationX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryTranslationY
            match prevValueOpt, source.TryTranslationY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.TranslationY <- value
            | Some _, None -> target.TranslationY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryWidthRequest
            match prevValueOpt, source.TryWidthRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.WidthRequest <- value
            | Some _, None -> target.WidthRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryClassId
            match prevValueOpt, source.TryClassId with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.ClassId <- value
            | Some _, None -> target.ClassId <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryStyleId
            match prevValueOpt, source.TryStyleId with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.StyleId <- value
            | Some _, None -> target.StyleId <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
        new XamlElement(typeof<Xamarin.Forms.Switch>, create, apply, Map.ofArray attribs)

    /// Describes a SwitchCell in the view
    static member SwitchCell(?on: bool, ?text: string, ?onChanged: Xamarin.Forms.ToggledEventArgs -> unit, ?height: double, ?isEnabled: bool, ?classId: string, ?styleId: string) = 
        let attribs = [| 
            match on with None -> () | Some v -> yield ("On", box ((v))) 
            match text with None -> () | Some v -> yield ("Text", box ((v))) 
            match onChanged with None -> () | Some v -> yield ("OnChanged", box ((fun f -> System.EventHandler<Xamarin.Forms.ToggledEventArgs>(fun _sender args -> f args))(v))) 
            match height with None -> () | Some v -> yield ("Height", box ((v))) 
            match isEnabled with None -> () | Some v -> yield ("IsEnabled", box ((v))) 
            match classId with None -> () | Some v -> yield ("ClassId", box ((v))) 
            match styleId with None -> () | Some v -> yield ("StyleId", box ((v))) 
          |]

        let create () =
            box (new Xamarin.Forms.SwitchCell())

        let apply (prevOpt: XamlElement option) (source: XamlElement) (target:obj) = 
            let target = (target :?> Xamarin.Forms.SwitchCell)
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryOn
            match prevValueOpt, source.TryOn with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.On <- value
            | Some _, None -> target.On <- false // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryText
            match prevValueOpt, source.TryText with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Text <- value
            | Some _, None -> target.Text <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryOnChanged
            match prevValueOpt, source.TryOnChanged with
            | Some prevValue, Some value when System.Object.ReferenceEquals(prevValue, value) -> ()
            | Some prevValue, Some value -> target.OnChanged.RemoveHandler(prevValue); target.OnChanged.AddHandler(value)
            | None, Some value -> target.OnChanged.AddHandler(value)
            | Some prevValue, None -> target.OnChanged.RemoveHandler(prevValue)
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryHeight
            match prevValueOpt, source.TryHeight with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Height <- value
            | Some _, None -> target.Height <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsEnabled
            match prevValueOpt, source.TryIsEnabled with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsEnabled <- value
            | Some _, None -> target.IsEnabled <- true // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryClassId
            match prevValueOpt, source.TryClassId with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.ClassId <- value
            | Some _, None -> target.ClassId <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryStyleId
            match prevValueOpt, source.TryStyleId with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.StyleId <- value
            | Some _, None -> target.StyleId <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
        new XamlElement(typeof<Xamarin.Forms.SwitchCell>, create, apply, Map.ofArray attribs)

    /// Describes a Grid in the view
    static member Grid(?rowdefs: obj list, ?coldefs: obj list, ?rowSpacing: double, ?columnSpacing: double, ?children: XamlElement list, ?isClippedToBounds: bool, ?padding: double, ?horizontalOptions: Xamarin.Forms.LayoutOptions, ?verticalOptions: Xamarin.Forms.LayoutOptions, ?margin: obj, ?gestureRecognizers: XamlElement list, ?anchorX: double, ?anchorY: double, ?backgroundColor: Xamarin.Forms.Color, ?heightRequest: double, ?inputTransparent: bool, ?isEnabled: bool, ?isVisible: bool, ?minimumHeightRequest: double, ?minimumWidthRequest: double, ?opacity: double, ?rotation: double, ?rotationX: double, ?rotationY: double, ?scale: double, ?style: Xamarin.Forms.Style, ?translationX: double, ?translationY: double, ?widthRequest: double, ?classId: string, ?styleId: string) = 
        let attribs = [| 
            match rowdefs with None -> () | Some v -> yield ("GridRowDefinitions", box ((fun es -> es |> Array.ofList |> Array.map (fun h -> Xaml.RowDefinition(height=h)))(v))) 
            match coldefs with None -> () | Some v -> yield ("GridColumnDefinitions", box ((fun es -> es |> Array.ofList |> Array.map (fun h -> Xaml.ColumnDefinition(width=h)))(v))) 
            match rowSpacing with None -> () | Some v -> yield ("RowSpacing", box ((v))) 
            match columnSpacing with None -> () | Some v -> yield ("ColumnSpacing", box ((v))) 
            match children with None -> () | Some v -> yield ("Children", box (Array.ofList(v))) 
            match isClippedToBounds with None -> () | Some v -> yield ("IsClippedToBounds", box ((v))) 
            match padding with None -> () | Some v -> yield ("Padding", box (makeThickness(v))) 
            match horizontalOptions with None -> () | Some v -> yield ("HorizontalOptions", box ((v))) 
            match verticalOptions with None -> () | Some v -> yield ("VerticalOptions", box ((v))) 
            match margin with None -> () | Some v -> yield ("Margin", box (makeThickness(v))) 
            match gestureRecognizers with None -> () | Some v -> yield ("GestureRecognizers", box (Array.ofList(v))) 
            match anchorX with None -> () | Some v -> yield ("AnchorX", box ((v))) 
            match anchorY with None -> () | Some v -> yield ("AnchorY", box ((v))) 
            match backgroundColor with None -> () | Some v -> yield ("BackgroundColor", box ((v))) 
            match heightRequest with None -> () | Some v -> yield ("HeightRequest", box ((v))) 
            match inputTransparent with None -> () | Some v -> yield ("InputTransparent", box ((v))) 
            match isEnabled with None -> () | Some v -> yield ("IsEnabled", box ((v))) 
            match isVisible with None -> () | Some v -> yield ("IsVisible", box ((v))) 
            match minimumHeightRequest with None -> () | Some v -> yield ("MinimumHeightRequest", box ((v))) 
            match minimumWidthRequest with None -> () | Some v -> yield ("MinimumWidthRequest", box ((v))) 
            match opacity with None -> () | Some v -> yield ("Opacity", box ((v))) 
            match rotation with None -> () | Some v -> yield ("Rotation", box ((v))) 
            match rotationX with None -> () | Some v -> yield ("RotationX", box ((v))) 
            match rotationY with None -> () | Some v -> yield ("RotationY", box ((v))) 
            match scale with None -> () | Some v -> yield ("Scale", box ((v))) 
            match style with None -> () | Some v -> yield ("Style", box ((v))) 
            match translationX with None -> () | Some v -> yield ("TranslationX", box ((v))) 
            match translationY with None -> () | Some v -> yield ("TranslationY", box ((v))) 
            match widthRequest with None -> () | Some v -> yield ("WidthRequest", box ((v))) 
            match classId with None -> () | Some v -> yield ("ClassId", box ((v))) 
            match styleId with None -> () | Some v -> yield ("StyleId", box ((v))) 
          |]

        let create () =
            box (new Xamarin.Forms.Grid())

        let apply (prevOpt: XamlElement option) (source: XamlElement) (target:obj) = 
            let target = (target :?> Xamarin.Forms.Grid)
            let prevCollOpt = match prevOpt with None -> None | Some prev -> prev.TryGridRowDefinitions
            match prevCollOpt, source.TryGridRowDefinitions with
            // For structured objects, amortize on reference equality
            | Some prevColl, Some newColl when System.Object.ReferenceEquals(prevColl, newColl) -> ()
            | _, Some coll when coll <> null && coll.Length > 0 ->
                applyToIList
                    prevCollOpt
                    coll
                    target.RowDefinitions
                    (fun (x:XamlElement) -> x.CreateAsRowDefinition())
                    (fun _ _ _ -> ())
                    (fun (prevChild:XamlElement) (newChild:XamlElement) -> prevChild.TargetType = newChild.TargetType)
                    (fun prevChild newChild targetChild -> newChild.ApplyIncremental(prevChild, targetChild))
            | _ -> target.RowDefinitions.Clear()
            let prevCollOpt = match prevOpt with None -> None | Some prev -> prev.TryGridColumnDefinitions
            match prevCollOpt, source.TryGridColumnDefinitions with
            // For structured objects, amortize on reference equality
            | Some prevColl, Some newColl when System.Object.ReferenceEquals(prevColl, newColl) -> ()
            | _, Some coll when coll <> null && coll.Length > 0 ->
                applyToIList
                    prevCollOpt
                    coll
                    target.ColumnDefinitions
                    (fun (x:XamlElement) -> x.CreateAsColumnDefinition())
                    (fun _ _ _ -> ())
                    (fun (prevChild:XamlElement) (newChild:XamlElement) -> prevChild.TargetType = newChild.TargetType)
                    (fun prevChild newChild targetChild -> newChild.ApplyIncremental(prevChild, targetChild))
            | _ -> target.ColumnDefinitions.Clear()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRowSpacing
            match prevValueOpt, source.TryRowSpacing with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.RowSpacing <- value
            | Some _, None -> target.RowSpacing <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryColumnSpacing
            match prevValueOpt, source.TryColumnSpacing with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.ColumnSpacing <- value
            | Some _, None -> target.ColumnSpacing <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevCollOpt = match prevOpt with None -> None | Some prev -> prev.TryChildren
            match prevCollOpt, source.TryChildren with
            // For structured objects, amortize on reference equality
            | Some prevColl, Some newColl when System.Object.ReferenceEquals(prevColl, newColl) -> ()
            | _, Some coll when coll <> null && coll.Length > 0 ->
                applyToIList
                    prevCollOpt
                    coll
                    target.Children
                    (fun (x:XamlElement) -> x.CreateAsView())
                    (fun prevChildOpt newChild targetChild -> 
                        // Adjust the attached properties
                        match (match prevChildOpt with None -> None | Some prevChild -> prevChild.TryGridRow), newChild.TryGridRow with
                        | Some prev, Some v when prev = v -> ()
                        | prevOpt, Some value -> Xamarin.Forms.Grid.SetRow(targetChild, value)
                        | Some _, None -> Xamarin.Forms.Grid.SetRow(targetChild, 0) // TODO: not always perfect, should set back to original default?
                        | _ -> ()
                        // Adjust the attached properties
                        match (match prevChildOpt with None -> None | Some prevChild -> prevChild.TryGridRowSpan), newChild.TryGridRowSpan with
                        | Some prev, Some v when prev = v -> ()
                        | prevOpt, Some value -> Xamarin.Forms.Grid.SetRowSpan(targetChild, value)
                        | Some _, None -> Xamarin.Forms.Grid.SetRowSpan(targetChild, 0) // TODO: not always perfect, should set back to original default?
                        | _ -> ()
                        // Adjust the attached properties
                        match (match prevChildOpt with None -> None | Some prevChild -> prevChild.TryGridColumn), newChild.TryGridColumn with
                        | Some prev, Some v when prev = v -> ()
                        | prevOpt, Some value -> Xamarin.Forms.Grid.SetColumn(targetChild, value)
                        | Some _, None -> Xamarin.Forms.Grid.SetColumn(targetChild, 0) // TODO: not always perfect, should set back to original default?
                        | _ -> ()
                        // Adjust the attached properties
                        match (match prevChildOpt with None -> None | Some prevChild -> prevChild.TryGridColumnSpan), newChild.TryGridColumnSpan with
                        | Some prev, Some v when prev = v -> ()
                        | prevOpt, Some value -> Xamarin.Forms.Grid.SetColumnSpan(targetChild, value)
                        | Some _, None -> Xamarin.Forms.Grid.SetColumnSpan(targetChild, 0) // TODO: not always perfect, should set back to original default?
                        | _ -> ()
                        ())
                    (fun (prevChild:XamlElement) (newChild:XamlElement) -> prevChild.TargetType = newChild.TargetType)
                    (fun prevChild newChild targetChild -> newChild.ApplyIncremental(prevChild, targetChild))
            | _ -> target.Children.Clear()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsClippedToBounds
            match prevValueOpt, source.TryIsClippedToBounds with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsClippedToBounds <- value
            | Some _, None -> target.IsClippedToBounds <- false // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryPadding
            match prevValueOpt, source.TryPadding with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Padding <- value
            | Some _, None -> target.Padding <- Unchecked.defaultof<Xamarin.Forms.Thickness> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryHorizontalOptions
            match prevValueOpt, source.TryHorizontalOptions with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.HorizontalOptions <- value
            | Some _, None -> target.HorizontalOptions <- Unchecked.defaultof<Xamarin.Forms.LayoutOptions> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryVerticalOptions
            match prevValueOpt, source.TryVerticalOptions with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.VerticalOptions <- value
            | Some _, None -> target.VerticalOptions <- Unchecked.defaultof<Xamarin.Forms.LayoutOptions> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMargin
            match prevValueOpt, source.TryMargin with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Margin <- value
            | Some _, None -> target.Margin <- Unchecked.defaultof<Xamarin.Forms.Thickness> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevCollOpt = match prevOpt with None -> None | Some prev -> prev.TryGestureRecognizers
            match prevCollOpt, source.TryGestureRecognizers with
            // For structured objects, amortize on reference equality
            | Some prevColl, Some newColl when System.Object.ReferenceEquals(prevColl, newColl) -> ()
            | _, Some coll when coll <> null && coll.Length > 0 ->
                applyToIList
                    prevCollOpt
                    coll
                    target.GestureRecognizers
                    (fun (x:XamlElement) -> x.CreateAsIGestureRecognizer())
                    (fun _ _ _ -> ())
                    (fun (prevChild:XamlElement) (newChild:XamlElement) -> prevChild.TargetType = newChild.TargetType)
                    (fun prevChild newChild targetChild -> newChild.ApplyIncremental(prevChild, targetChild))
            | _ -> target.GestureRecognizers.Clear()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryAnchorX
            match prevValueOpt, source.TryAnchorX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.AnchorX <- value
            | Some _, None -> target.AnchorX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryAnchorY
            match prevValueOpt, source.TryAnchorY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.AnchorY <- value
            | Some _, None -> target.AnchorY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryBackgroundColor
            match prevValueOpt, source.TryBackgroundColor with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.BackgroundColor <- value
            | Some _, None -> target.BackgroundColor <- Xamarin.Forms.Color.Default // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryHeightRequest
            match prevValueOpt, source.TryHeightRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.HeightRequest <- value
            | Some _, None -> target.HeightRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryInputTransparent
            match prevValueOpt, source.TryInputTransparent with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.InputTransparent <- value
            | Some _, None -> target.InputTransparent <- false // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsEnabled
            match prevValueOpt, source.TryIsEnabled with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsEnabled <- value
            | Some _, None -> target.IsEnabled <- true // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsVisible
            match prevValueOpt, source.TryIsVisible with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsVisible <- value
            | Some _, None -> target.IsVisible <- true // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMinimumHeightRequest
            match prevValueOpt, source.TryMinimumHeightRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.MinimumHeightRequest <- value
            | Some _, None -> target.MinimumHeightRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMinimumWidthRequest
            match prevValueOpt, source.TryMinimumWidthRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.MinimumWidthRequest <- value
            | Some _, None -> target.MinimumWidthRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryOpacity
            match prevValueOpt, source.TryOpacity with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Opacity <- value
            | Some _, None -> target.Opacity <- 1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotation
            match prevValueOpt, source.TryRotation with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Rotation <- value
            | Some _, None -> target.Rotation <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotationX
            match prevValueOpt, source.TryRotationX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.RotationX <- value
            | Some _, None -> target.RotationX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotationY
            match prevValueOpt, source.TryRotationY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.RotationY <- value
            | Some _, None -> target.RotationY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryScale
            match prevValueOpt, source.TryScale with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Scale <- value
            | Some _, None -> target.Scale <- 1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryStyle
            match prevValueOpt, source.TryStyle with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Style <- value
            | Some _, None -> target.Style <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryTranslationX
            match prevValueOpt, source.TryTranslationX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.TranslationX <- value
            | Some _, None -> target.TranslationX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryTranslationY
            match prevValueOpt, source.TryTranslationY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.TranslationY <- value
            | Some _, None -> target.TranslationY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryWidthRequest
            match prevValueOpt, source.TryWidthRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.WidthRequest <- value
            | Some _, None -> target.WidthRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryClassId
            match prevValueOpt, source.TryClassId with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.ClassId <- value
            | Some _, None -> target.ClassId <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryStyleId
            match prevValueOpt, source.TryStyleId with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.StyleId <- value
            | Some _, None -> target.StyleId <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
        new XamlElement(typeof<Xamarin.Forms.Grid>, create, apply, Map.ofArray attribs)

    /// Describes a AbsoluteLayout in the view
    static member AbsoluteLayout(?children: XamlElement list, ?isClippedToBounds: bool, ?padding: double, ?horizontalOptions: Xamarin.Forms.LayoutOptions, ?verticalOptions: Xamarin.Forms.LayoutOptions, ?margin: obj, ?gestureRecognizers: XamlElement list, ?anchorX: double, ?anchorY: double, ?backgroundColor: Xamarin.Forms.Color, ?heightRequest: double, ?inputTransparent: bool, ?isEnabled: bool, ?isVisible: bool, ?minimumHeightRequest: double, ?minimumWidthRequest: double, ?opacity: double, ?rotation: double, ?rotationX: double, ?rotationY: double, ?scale: double, ?style: Xamarin.Forms.Style, ?translationX: double, ?translationY: double, ?widthRequest: double, ?classId: string, ?styleId: string) = 
        let attribs = [| 
            match children with None -> () | Some v -> yield ("Children", box (Array.ofList(v))) 
            match isClippedToBounds with None -> () | Some v -> yield ("IsClippedToBounds", box ((v))) 
            match padding with None -> () | Some v -> yield ("Padding", box (makeThickness(v))) 
            match horizontalOptions with None -> () | Some v -> yield ("HorizontalOptions", box ((v))) 
            match verticalOptions with None -> () | Some v -> yield ("VerticalOptions", box ((v))) 
            match margin with None -> () | Some v -> yield ("Margin", box (makeThickness(v))) 
            match gestureRecognizers with None -> () | Some v -> yield ("GestureRecognizers", box (Array.ofList(v))) 
            match anchorX with None -> () | Some v -> yield ("AnchorX", box ((v))) 
            match anchorY with None -> () | Some v -> yield ("AnchorY", box ((v))) 
            match backgroundColor with None -> () | Some v -> yield ("BackgroundColor", box ((v))) 
            match heightRequest with None -> () | Some v -> yield ("HeightRequest", box ((v))) 
            match inputTransparent with None -> () | Some v -> yield ("InputTransparent", box ((v))) 
            match isEnabled with None -> () | Some v -> yield ("IsEnabled", box ((v))) 
            match isVisible with None -> () | Some v -> yield ("IsVisible", box ((v))) 
            match minimumHeightRequest with None -> () | Some v -> yield ("MinimumHeightRequest", box ((v))) 
            match minimumWidthRequest with None -> () | Some v -> yield ("MinimumWidthRequest", box ((v))) 
            match opacity with None -> () | Some v -> yield ("Opacity", box ((v))) 
            match rotation with None -> () | Some v -> yield ("Rotation", box ((v))) 
            match rotationX with None -> () | Some v -> yield ("RotationX", box ((v))) 
            match rotationY with None -> () | Some v -> yield ("RotationY", box ((v))) 
            match scale with None -> () | Some v -> yield ("Scale", box ((v))) 
            match style with None -> () | Some v -> yield ("Style", box ((v))) 
            match translationX with None -> () | Some v -> yield ("TranslationX", box ((v))) 
            match translationY with None -> () | Some v -> yield ("TranslationY", box ((v))) 
            match widthRequest with None -> () | Some v -> yield ("WidthRequest", box ((v))) 
            match classId with None -> () | Some v -> yield ("ClassId", box ((v))) 
            match styleId with None -> () | Some v -> yield ("StyleId", box ((v))) 
          |]

        let create () =
            box (new Xamarin.Forms.AbsoluteLayout())

        let apply (prevOpt: XamlElement option) (source: XamlElement) (target:obj) = 
            let target = (target :?> Xamarin.Forms.AbsoluteLayout)
            let prevCollOpt = match prevOpt with None -> None | Some prev -> prev.TryChildren
            match prevCollOpt, source.TryChildren with
            // For structured objects, amortize on reference equality
            | Some prevColl, Some newColl when System.Object.ReferenceEquals(prevColl, newColl) -> ()
            | _, Some coll when coll <> null && coll.Length > 0 ->
                applyToIList
                    prevCollOpt
                    coll
                    target.Children
                    (fun (x:XamlElement) -> x.CreateAsView())
                    (fun prevChildOpt newChild targetChild -> 
                        // Adjust the attached properties
                        match (match prevChildOpt with None -> None | Some prevChild -> prevChild.TryAbsoluteLayoutBounds), newChild.TryAbsoluteLayoutBounds with
                        | Some prev, Some v when prev = v -> ()
                        | prevOpt, Some value -> Xamarin.Forms.AbsoluteLayout.SetLayoutBounds(targetChild, value)
                        | Some _, None -> Xamarin.Forms.AbsoluteLayout.SetLayoutBounds(targetChild, Xamarin.Forms.Rectangle.Zero) // TODO: not always perfect, should set back to original default?
                        | _ -> ()
                        // Adjust the attached properties
                        match (match prevChildOpt with None -> None | Some prevChild -> prevChild.TryAbsoluteLayoutFlags), newChild.TryAbsoluteLayoutFlags with
                        | Some prev, Some v when prev = v -> ()
                        | prevOpt, Some value -> Xamarin.Forms.AbsoluteLayout.SetLayoutFlags(targetChild, value)
                        | Some _, None -> Xamarin.Forms.AbsoluteLayout.SetLayoutFlags(targetChild, Xamarin.Forms.AbsoluteLayoutFlags.None) // TODO: not always perfect, should set back to original default?
                        | _ -> ()
                        ())
                    (fun (prevChild:XamlElement) (newChild:XamlElement) -> prevChild.TargetType = newChild.TargetType)
                    (fun prevChild newChild targetChild -> newChild.ApplyIncremental(prevChild, targetChild))
            | _ -> target.Children.Clear()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsClippedToBounds
            match prevValueOpt, source.TryIsClippedToBounds with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsClippedToBounds <- value
            | Some _, None -> target.IsClippedToBounds <- false // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryPadding
            match prevValueOpt, source.TryPadding with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Padding <- value
            | Some _, None -> target.Padding <- Unchecked.defaultof<Xamarin.Forms.Thickness> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryHorizontalOptions
            match prevValueOpt, source.TryHorizontalOptions with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.HorizontalOptions <- value
            | Some _, None -> target.HorizontalOptions <- Unchecked.defaultof<Xamarin.Forms.LayoutOptions> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryVerticalOptions
            match prevValueOpt, source.TryVerticalOptions with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.VerticalOptions <- value
            | Some _, None -> target.VerticalOptions <- Unchecked.defaultof<Xamarin.Forms.LayoutOptions> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMargin
            match prevValueOpt, source.TryMargin with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Margin <- value
            | Some _, None -> target.Margin <- Unchecked.defaultof<Xamarin.Forms.Thickness> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevCollOpt = match prevOpt with None -> None | Some prev -> prev.TryGestureRecognizers
            match prevCollOpt, source.TryGestureRecognizers with
            // For structured objects, amortize on reference equality
            | Some prevColl, Some newColl when System.Object.ReferenceEquals(prevColl, newColl) -> ()
            | _, Some coll when coll <> null && coll.Length > 0 ->
                applyToIList
                    prevCollOpt
                    coll
                    target.GestureRecognizers
                    (fun (x:XamlElement) -> x.CreateAsIGestureRecognizer())
                    (fun _ _ _ -> ())
                    (fun (prevChild:XamlElement) (newChild:XamlElement) -> prevChild.TargetType = newChild.TargetType)
                    (fun prevChild newChild targetChild -> newChild.ApplyIncremental(prevChild, targetChild))
            | _ -> target.GestureRecognizers.Clear()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryAnchorX
            match prevValueOpt, source.TryAnchorX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.AnchorX <- value
            | Some _, None -> target.AnchorX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryAnchorY
            match prevValueOpt, source.TryAnchorY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.AnchorY <- value
            | Some _, None -> target.AnchorY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryBackgroundColor
            match prevValueOpt, source.TryBackgroundColor with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.BackgroundColor <- value
            | Some _, None -> target.BackgroundColor <- Xamarin.Forms.Color.Default // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryHeightRequest
            match prevValueOpt, source.TryHeightRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.HeightRequest <- value
            | Some _, None -> target.HeightRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryInputTransparent
            match prevValueOpt, source.TryInputTransparent with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.InputTransparent <- value
            | Some _, None -> target.InputTransparent <- false // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsEnabled
            match prevValueOpt, source.TryIsEnabled with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsEnabled <- value
            | Some _, None -> target.IsEnabled <- true // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsVisible
            match prevValueOpt, source.TryIsVisible with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsVisible <- value
            | Some _, None -> target.IsVisible <- true // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMinimumHeightRequest
            match prevValueOpt, source.TryMinimumHeightRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.MinimumHeightRequest <- value
            | Some _, None -> target.MinimumHeightRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMinimumWidthRequest
            match prevValueOpt, source.TryMinimumWidthRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.MinimumWidthRequest <- value
            | Some _, None -> target.MinimumWidthRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryOpacity
            match prevValueOpt, source.TryOpacity with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Opacity <- value
            | Some _, None -> target.Opacity <- 1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotation
            match prevValueOpt, source.TryRotation with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Rotation <- value
            | Some _, None -> target.Rotation <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotationX
            match prevValueOpt, source.TryRotationX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.RotationX <- value
            | Some _, None -> target.RotationX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotationY
            match prevValueOpt, source.TryRotationY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.RotationY <- value
            | Some _, None -> target.RotationY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryScale
            match prevValueOpt, source.TryScale with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Scale <- value
            | Some _, None -> target.Scale <- 1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryStyle
            match prevValueOpt, source.TryStyle with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Style <- value
            | Some _, None -> target.Style <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryTranslationX
            match prevValueOpt, source.TryTranslationX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.TranslationX <- value
            | Some _, None -> target.TranslationX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryTranslationY
            match prevValueOpt, source.TryTranslationY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.TranslationY <- value
            | Some _, None -> target.TranslationY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryWidthRequest
            match prevValueOpt, source.TryWidthRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.WidthRequest <- value
            | Some _, None -> target.WidthRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryClassId
            match prevValueOpt, source.TryClassId with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.ClassId <- value
            | Some _, None -> target.ClassId <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryStyleId
            match prevValueOpt, source.TryStyleId with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.StyleId <- value
            | Some _, None -> target.StyleId <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
        new XamlElement(typeof<Xamarin.Forms.AbsoluteLayout>, create, apply, Map.ofArray attribs)

    /// Describes a RelativeLayout in the view
    static member RelativeLayout(?children: XamlElement list, ?isClippedToBounds: bool, ?padding: double, ?horizontalOptions: Xamarin.Forms.LayoutOptions, ?verticalOptions: Xamarin.Forms.LayoutOptions, ?margin: obj, ?gestureRecognizers: XamlElement list, ?anchorX: double, ?anchorY: double, ?backgroundColor: Xamarin.Forms.Color, ?heightRequest: double, ?inputTransparent: bool, ?isEnabled: bool, ?isVisible: bool, ?minimumHeightRequest: double, ?minimumWidthRequest: double, ?opacity: double, ?rotation: double, ?rotationX: double, ?rotationY: double, ?scale: double, ?style: Xamarin.Forms.Style, ?translationX: double, ?translationY: double, ?widthRequest: double, ?classId: string, ?styleId: string) = 
        let attribs = [| 
            match children with None -> () | Some v -> yield ("Children", box (Array.ofList(v))) 
            match isClippedToBounds with None -> () | Some v -> yield ("IsClippedToBounds", box ((v))) 
            match padding with None -> () | Some v -> yield ("Padding", box (makeThickness(v))) 
            match horizontalOptions with None -> () | Some v -> yield ("HorizontalOptions", box ((v))) 
            match verticalOptions with None -> () | Some v -> yield ("VerticalOptions", box ((v))) 
            match margin with None -> () | Some v -> yield ("Margin", box (makeThickness(v))) 
            match gestureRecognizers with None -> () | Some v -> yield ("GestureRecognizers", box (Array.ofList(v))) 
            match anchorX with None -> () | Some v -> yield ("AnchorX", box ((v))) 
            match anchorY with None -> () | Some v -> yield ("AnchorY", box ((v))) 
            match backgroundColor with None -> () | Some v -> yield ("BackgroundColor", box ((v))) 
            match heightRequest with None -> () | Some v -> yield ("HeightRequest", box ((v))) 
            match inputTransparent with None -> () | Some v -> yield ("InputTransparent", box ((v))) 
            match isEnabled with None -> () | Some v -> yield ("IsEnabled", box ((v))) 
            match isVisible with None -> () | Some v -> yield ("IsVisible", box ((v))) 
            match minimumHeightRequest with None -> () | Some v -> yield ("MinimumHeightRequest", box ((v))) 
            match minimumWidthRequest with None -> () | Some v -> yield ("MinimumWidthRequest", box ((v))) 
            match opacity with None -> () | Some v -> yield ("Opacity", box ((v))) 
            match rotation with None -> () | Some v -> yield ("Rotation", box ((v))) 
            match rotationX with None -> () | Some v -> yield ("RotationX", box ((v))) 
            match rotationY with None -> () | Some v -> yield ("RotationY", box ((v))) 
            match scale with None -> () | Some v -> yield ("Scale", box ((v))) 
            match style with None -> () | Some v -> yield ("Style", box ((v))) 
            match translationX with None -> () | Some v -> yield ("TranslationX", box ((v))) 
            match translationY with None -> () | Some v -> yield ("TranslationY", box ((v))) 
            match widthRequest with None -> () | Some v -> yield ("WidthRequest", box ((v))) 
            match classId with None -> () | Some v -> yield ("ClassId", box ((v))) 
            match styleId with None -> () | Some v -> yield ("StyleId", box ((v))) 
          |]

        let create () =
            box (new Xamarin.Forms.RelativeLayout())

        let apply (prevOpt: XamlElement option) (source: XamlElement) (target:obj) = 
            let target = (target :?> Xamarin.Forms.RelativeLayout)
            let prevCollOpt = match prevOpt with None -> None | Some prev -> prev.TryChildren
            match prevCollOpt, source.TryChildren with
            // For structured objects, amortize on reference equality
            | Some prevColl, Some newColl when System.Object.ReferenceEquals(prevColl, newColl) -> ()
            | _, Some coll when coll <> null && coll.Length > 0 ->
                applyToIList
                    prevCollOpt
                    coll
                    target.Children
                    (fun (x:XamlElement) -> x.CreateAsView())
                    (fun prevChildOpt newChild targetChild -> 
                        // Adjust the attached properties
                        match (match prevChildOpt with None -> None | Some prevChild -> prevChild.TryBoundsConstraint), newChild.TryBoundsConstraint with
                        | Some prev, Some v when prev = v -> ()
                        | prevOpt, Some value -> Xamarin.Forms.RelativeLayout.SetBoundsConstraint(targetChild, value)
                        | Some _, None -> Xamarin.Forms.RelativeLayout.SetBoundsConstraint(targetChild, null) // TODO: not always perfect, should set back to original default?
                        | _ -> ()
                        // Adjust the attached properties
                        match (match prevChildOpt with None -> None | Some prevChild -> prevChild.TryHeightConstraint), newChild.TryHeightConstraint with
                        | Some prev, Some v when prev = v -> ()
                        | prevOpt, Some value -> Xamarin.Forms.RelativeLayout.SetHeightConstraint(targetChild, value)
                        | Some _, None -> Xamarin.Forms.RelativeLayout.SetHeightConstraint(targetChild, null) // TODO: not always perfect, should set back to original default?
                        | _ -> ()
                        // Adjust the attached properties
                        match (match prevChildOpt with None -> None | Some prevChild -> prevChild.TryWidthConstraint), newChild.TryWidthConstraint with
                        | Some prev, Some v when prev = v -> ()
                        | prevOpt, Some value -> Xamarin.Forms.RelativeLayout.SetWidthConstraint(targetChild, value)
                        | Some _, None -> Xamarin.Forms.RelativeLayout.SetWidthConstraint(targetChild, null) // TODO: not always perfect, should set back to original default?
                        | _ -> ()
                        // Adjust the attached properties
                        match (match prevChildOpt with None -> None | Some prevChild -> prevChild.TryXConstraint), newChild.TryXConstraint with
                        | Some prev, Some v when prev = v -> ()
                        | prevOpt, Some value -> Xamarin.Forms.RelativeLayout.SetXConstraint(targetChild, value)
                        | Some _, None -> Xamarin.Forms.RelativeLayout.SetXConstraint(targetChild, null) // TODO: not always perfect, should set back to original default?
                        | _ -> ()
                        // Adjust the attached properties
                        match (match prevChildOpt with None -> None | Some prevChild -> prevChild.TryYConstraint), newChild.TryYConstraint with
                        | Some prev, Some v when prev = v -> ()
                        | prevOpt, Some value -> Xamarin.Forms.RelativeLayout.SetYConstraint(targetChild, value)
                        | Some _, None -> Xamarin.Forms.RelativeLayout.SetYConstraint(targetChild, null) // TODO: not always perfect, should set back to original default?
                        | _ -> ()
                        ())
                    (fun (prevChild:XamlElement) (newChild:XamlElement) -> prevChild.TargetType = newChild.TargetType)
                    (fun prevChild newChild targetChild -> newChild.ApplyIncremental(prevChild, targetChild))
            | _ -> target.Children.Clear()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsClippedToBounds
            match prevValueOpt, source.TryIsClippedToBounds with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsClippedToBounds <- value
            | Some _, None -> target.IsClippedToBounds <- false // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryPadding
            match prevValueOpt, source.TryPadding with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Padding <- value
            | Some _, None -> target.Padding <- Unchecked.defaultof<Xamarin.Forms.Thickness> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryHorizontalOptions
            match prevValueOpt, source.TryHorizontalOptions with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.HorizontalOptions <- value
            | Some _, None -> target.HorizontalOptions <- Unchecked.defaultof<Xamarin.Forms.LayoutOptions> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryVerticalOptions
            match prevValueOpt, source.TryVerticalOptions with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.VerticalOptions <- value
            | Some _, None -> target.VerticalOptions <- Unchecked.defaultof<Xamarin.Forms.LayoutOptions> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMargin
            match prevValueOpt, source.TryMargin with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Margin <- value
            | Some _, None -> target.Margin <- Unchecked.defaultof<Xamarin.Forms.Thickness> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevCollOpt = match prevOpt with None -> None | Some prev -> prev.TryGestureRecognizers
            match prevCollOpt, source.TryGestureRecognizers with
            // For structured objects, amortize on reference equality
            | Some prevColl, Some newColl when System.Object.ReferenceEquals(prevColl, newColl) -> ()
            | _, Some coll when coll <> null && coll.Length > 0 ->
                applyToIList
                    prevCollOpt
                    coll
                    target.GestureRecognizers
                    (fun (x:XamlElement) -> x.CreateAsIGestureRecognizer())
                    (fun _ _ _ -> ())
                    (fun (prevChild:XamlElement) (newChild:XamlElement) -> prevChild.TargetType = newChild.TargetType)
                    (fun prevChild newChild targetChild -> newChild.ApplyIncremental(prevChild, targetChild))
            | _ -> target.GestureRecognizers.Clear()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryAnchorX
            match prevValueOpt, source.TryAnchorX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.AnchorX <- value
            | Some _, None -> target.AnchorX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryAnchorY
            match prevValueOpt, source.TryAnchorY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.AnchorY <- value
            | Some _, None -> target.AnchorY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryBackgroundColor
            match prevValueOpt, source.TryBackgroundColor with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.BackgroundColor <- value
            | Some _, None -> target.BackgroundColor <- Xamarin.Forms.Color.Default // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryHeightRequest
            match prevValueOpt, source.TryHeightRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.HeightRequest <- value
            | Some _, None -> target.HeightRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryInputTransparent
            match prevValueOpt, source.TryInputTransparent with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.InputTransparent <- value
            | Some _, None -> target.InputTransparent <- false // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsEnabled
            match prevValueOpt, source.TryIsEnabled with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsEnabled <- value
            | Some _, None -> target.IsEnabled <- true // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsVisible
            match prevValueOpt, source.TryIsVisible with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsVisible <- value
            | Some _, None -> target.IsVisible <- true // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMinimumHeightRequest
            match prevValueOpt, source.TryMinimumHeightRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.MinimumHeightRequest <- value
            | Some _, None -> target.MinimumHeightRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMinimumWidthRequest
            match prevValueOpt, source.TryMinimumWidthRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.MinimumWidthRequest <- value
            | Some _, None -> target.MinimumWidthRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryOpacity
            match prevValueOpt, source.TryOpacity with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Opacity <- value
            | Some _, None -> target.Opacity <- 1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotation
            match prevValueOpt, source.TryRotation with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Rotation <- value
            | Some _, None -> target.Rotation <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotationX
            match prevValueOpt, source.TryRotationX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.RotationX <- value
            | Some _, None -> target.RotationX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotationY
            match prevValueOpt, source.TryRotationY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.RotationY <- value
            | Some _, None -> target.RotationY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryScale
            match prevValueOpt, source.TryScale with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Scale <- value
            | Some _, None -> target.Scale <- 1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryStyle
            match prevValueOpt, source.TryStyle with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Style <- value
            | Some _, None -> target.Style <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryTranslationX
            match prevValueOpt, source.TryTranslationX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.TranslationX <- value
            | Some _, None -> target.TranslationX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryTranslationY
            match prevValueOpt, source.TryTranslationY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.TranslationY <- value
            | Some _, None -> target.TranslationY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryWidthRequest
            match prevValueOpt, source.TryWidthRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.WidthRequest <- value
            | Some _, None -> target.WidthRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryClassId
            match prevValueOpt, source.TryClassId with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.ClassId <- value
            | Some _, None -> target.ClassId <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryStyleId
            match prevValueOpt, source.TryStyleId with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.StyleId <- value
            | Some _, None -> target.StyleId <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
        new XamlElement(typeof<Xamarin.Forms.RelativeLayout>, create, apply, Map.ofArray attribs)

    /// Describes a RowDefinition in the view
    static member RowDefinition(?height: obj) = 
        let attribs = [| 
            match height with None -> () | Some v -> yield ("RowDefinitionHeight", box (makeGridLength(v))) 
          |]

        let create () =
            box (new Xamarin.Forms.RowDefinition())

        let apply (prevOpt: XamlElement option) (source: XamlElement) (target:obj) = 
            let target = (target :?> Xamarin.Forms.RowDefinition)
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRowDefinitionHeight
            match prevValueOpt, source.TryRowDefinitionHeight with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Height <- value
            | Some _, None -> target.Height <- Xamarin.Forms.GridLength.Auto // TODO: not always perfect, should set back to original default?
            | None, None -> ()
        new XamlElement(typeof<Xamarin.Forms.RowDefinition>, create, apply, Map.ofArray attribs)

    /// Describes a ColumnDefinition in the view
    static member ColumnDefinition(?width: obj) = 
        let attribs = [| 
            match width with None -> () | Some v -> yield ("ColumnDefinitionWidth", box (makeGridLength(v))) 
          |]

        let create () =
            box (new Xamarin.Forms.ColumnDefinition())

        let apply (prevOpt: XamlElement option) (source: XamlElement) (target:obj) = 
            let target = (target :?> Xamarin.Forms.ColumnDefinition)
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryColumnDefinitionWidth
            match prevValueOpt, source.TryColumnDefinitionWidth with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Width <- value
            | Some _, None -> target.Width <- Xamarin.Forms.GridLength.Auto // TODO: not always perfect, should set back to original default?
            | None, None -> ()
        new XamlElement(typeof<Xamarin.Forms.ColumnDefinition>, create, apply, Map.ofArray attribs)

    /// Describes a ContentView in the view
    static member ContentView(?content: XamlElement, ?isClippedToBounds: bool, ?padding: double, ?horizontalOptions: Xamarin.Forms.LayoutOptions, ?verticalOptions: Xamarin.Forms.LayoutOptions, ?margin: obj, ?gestureRecognizers: XamlElement list, ?anchorX: double, ?anchorY: double, ?backgroundColor: Xamarin.Forms.Color, ?heightRequest: double, ?inputTransparent: bool, ?isEnabled: bool, ?isVisible: bool, ?minimumHeightRequest: double, ?minimumWidthRequest: double, ?opacity: double, ?rotation: double, ?rotationX: double, ?rotationY: double, ?scale: double, ?style: Xamarin.Forms.Style, ?translationX: double, ?translationY: double, ?widthRequest: double, ?classId: string, ?styleId: string) = 
        let attribs = [| 
            match content with None -> () | Some v -> yield ("Content", box ((v))) 
            match isClippedToBounds with None -> () | Some v -> yield ("IsClippedToBounds", box ((v))) 
            match padding with None -> () | Some v -> yield ("Padding", box (makeThickness(v))) 
            match horizontalOptions with None -> () | Some v -> yield ("HorizontalOptions", box ((v))) 
            match verticalOptions with None -> () | Some v -> yield ("VerticalOptions", box ((v))) 
            match margin with None -> () | Some v -> yield ("Margin", box (makeThickness(v))) 
            match gestureRecognizers with None -> () | Some v -> yield ("GestureRecognizers", box (Array.ofList(v))) 
            match anchorX with None -> () | Some v -> yield ("AnchorX", box ((v))) 
            match anchorY with None -> () | Some v -> yield ("AnchorY", box ((v))) 
            match backgroundColor with None -> () | Some v -> yield ("BackgroundColor", box ((v))) 
            match heightRequest with None -> () | Some v -> yield ("HeightRequest", box ((v))) 
            match inputTransparent with None -> () | Some v -> yield ("InputTransparent", box ((v))) 
            match isEnabled with None -> () | Some v -> yield ("IsEnabled", box ((v))) 
            match isVisible with None -> () | Some v -> yield ("IsVisible", box ((v))) 
            match minimumHeightRequest with None -> () | Some v -> yield ("MinimumHeightRequest", box ((v))) 
            match minimumWidthRequest with None -> () | Some v -> yield ("MinimumWidthRequest", box ((v))) 
            match opacity with None -> () | Some v -> yield ("Opacity", box ((v))) 
            match rotation with None -> () | Some v -> yield ("Rotation", box ((v))) 
            match rotationX with None -> () | Some v -> yield ("RotationX", box ((v))) 
            match rotationY with None -> () | Some v -> yield ("RotationY", box ((v))) 
            match scale with None -> () | Some v -> yield ("Scale", box ((v))) 
            match style with None -> () | Some v -> yield ("Style", box ((v))) 
            match translationX with None -> () | Some v -> yield ("TranslationX", box ((v))) 
            match translationY with None -> () | Some v -> yield ("TranslationY", box ((v))) 
            match widthRequest with None -> () | Some v -> yield ("WidthRequest", box ((v))) 
            match classId with None -> () | Some v -> yield ("ClassId", box ((v))) 
            match styleId with None -> () | Some v -> yield ("StyleId", box ((v))) 
          |]

        let create () =
            box (new Xamarin.Forms.ContentView())

        let apply (prevOpt: XamlElement option) (source: XamlElement) (target:obj) = 
            let target = (target :?> Xamarin.Forms.ContentView)
            let prevChildOpt = match prevOpt with None -> None | Some prev -> prev.TryContent
            match prevChildOpt, source.TryContent with
            // For structured objects, amortize on reference equality
            | Some prevChild, Some newChild when System.Object.ReferenceEquals(prevChild, newChild) -> ()
            | Some prevChild, Some newChild ->
                newChild.ApplyIncremental(prevChild, target.Content)
            | None, Some newChild ->
                target.Content <- newChild.CreateAsView()
            | Some _, None ->
                target.Content <- null;
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsClippedToBounds
            match prevValueOpt, source.TryIsClippedToBounds with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsClippedToBounds <- value
            | Some _, None -> target.IsClippedToBounds <- false // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryPadding
            match prevValueOpt, source.TryPadding with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Padding <- value
            | Some _, None -> target.Padding <- Unchecked.defaultof<Xamarin.Forms.Thickness> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryHorizontalOptions
            match prevValueOpt, source.TryHorizontalOptions with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.HorizontalOptions <- value
            | Some _, None -> target.HorizontalOptions <- Unchecked.defaultof<Xamarin.Forms.LayoutOptions> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryVerticalOptions
            match prevValueOpt, source.TryVerticalOptions with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.VerticalOptions <- value
            | Some _, None -> target.VerticalOptions <- Unchecked.defaultof<Xamarin.Forms.LayoutOptions> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMargin
            match prevValueOpt, source.TryMargin with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Margin <- value
            | Some _, None -> target.Margin <- Unchecked.defaultof<Xamarin.Forms.Thickness> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevCollOpt = match prevOpt with None -> None | Some prev -> prev.TryGestureRecognizers
            match prevCollOpt, source.TryGestureRecognizers with
            // For structured objects, amortize on reference equality
            | Some prevColl, Some newColl when System.Object.ReferenceEquals(prevColl, newColl) -> ()
            | _, Some coll when coll <> null && coll.Length > 0 ->
                applyToIList
                    prevCollOpt
                    coll
                    target.GestureRecognizers
                    (fun (x:XamlElement) -> x.CreateAsIGestureRecognizer())
                    (fun _ _ _ -> ())
                    (fun (prevChild:XamlElement) (newChild:XamlElement) -> prevChild.TargetType = newChild.TargetType)
                    (fun prevChild newChild targetChild -> newChild.ApplyIncremental(prevChild, targetChild))
            | _ -> target.GestureRecognizers.Clear()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryAnchorX
            match prevValueOpt, source.TryAnchorX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.AnchorX <- value
            | Some _, None -> target.AnchorX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryAnchorY
            match prevValueOpt, source.TryAnchorY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.AnchorY <- value
            | Some _, None -> target.AnchorY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryBackgroundColor
            match prevValueOpt, source.TryBackgroundColor with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.BackgroundColor <- value
            | Some _, None -> target.BackgroundColor <- Xamarin.Forms.Color.Default // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryHeightRequest
            match prevValueOpt, source.TryHeightRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.HeightRequest <- value
            | Some _, None -> target.HeightRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryInputTransparent
            match prevValueOpt, source.TryInputTransparent with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.InputTransparent <- value
            | Some _, None -> target.InputTransparent <- false // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsEnabled
            match prevValueOpt, source.TryIsEnabled with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsEnabled <- value
            | Some _, None -> target.IsEnabled <- true // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsVisible
            match prevValueOpt, source.TryIsVisible with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsVisible <- value
            | Some _, None -> target.IsVisible <- true // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMinimumHeightRequest
            match prevValueOpt, source.TryMinimumHeightRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.MinimumHeightRequest <- value
            | Some _, None -> target.MinimumHeightRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMinimumWidthRequest
            match prevValueOpt, source.TryMinimumWidthRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.MinimumWidthRequest <- value
            | Some _, None -> target.MinimumWidthRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryOpacity
            match prevValueOpt, source.TryOpacity with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Opacity <- value
            | Some _, None -> target.Opacity <- 1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotation
            match prevValueOpt, source.TryRotation with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Rotation <- value
            | Some _, None -> target.Rotation <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotationX
            match prevValueOpt, source.TryRotationX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.RotationX <- value
            | Some _, None -> target.RotationX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotationY
            match prevValueOpt, source.TryRotationY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.RotationY <- value
            | Some _, None -> target.RotationY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryScale
            match prevValueOpt, source.TryScale with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Scale <- value
            | Some _, None -> target.Scale <- 1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryStyle
            match prevValueOpt, source.TryStyle with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Style <- value
            | Some _, None -> target.Style <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryTranslationX
            match prevValueOpt, source.TryTranslationX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.TranslationX <- value
            | Some _, None -> target.TranslationX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryTranslationY
            match prevValueOpt, source.TryTranslationY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.TranslationY <- value
            | Some _, None -> target.TranslationY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryWidthRequest
            match prevValueOpt, source.TryWidthRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.WidthRequest <- value
            | Some _, None -> target.WidthRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryClassId
            match prevValueOpt, source.TryClassId with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.ClassId <- value
            | Some _, None -> target.ClassId <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryStyleId
            match prevValueOpt, source.TryStyleId with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.StyleId <- value
            | Some _, None -> target.StyleId <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
        new XamlElement(typeof<Xamarin.Forms.ContentView>, create, apply, Map.ofArray attribs)

    /// Describes a TemplatedView in the view
    static member TemplatedView(?isClippedToBounds: bool, ?padding: double, ?horizontalOptions: Xamarin.Forms.LayoutOptions, ?verticalOptions: Xamarin.Forms.LayoutOptions, ?margin: obj, ?gestureRecognizers: XamlElement list, ?anchorX: double, ?anchorY: double, ?backgroundColor: Xamarin.Forms.Color, ?heightRequest: double, ?inputTransparent: bool, ?isEnabled: bool, ?isVisible: bool, ?minimumHeightRequest: double, ?minimumWidthRequest: double, ?opacity: double, ?rotation: double, ?rotationX: double, ?rotationY: double, ?scale: double, ?style: Xamarin.Forms.Style, ?translationX: double, ?translationY: double, ?widthRequest: double, ?classId: string, ?styleId: string) = 
        let attribs = [| 
            match isClippedToBounds with None -> () | Some v -> yield ("IsClippedToBounds", box ((v))) 
            match padding with None -> () | Some v -> yield ("Padding", box (makeThickness(v))) 
            match horizontalOptions with None -> () | Some v -> yield ("HorizontalOptions", box ((v))) 
            match verticalOptions with None -> () | Some v -> yield ("VerticalOptions", box ((v))) 
            match margin with None -> () | Some v -> yield ("Margin", box (makeThickness(v))) 
            match gestureRecognizers with None -> () | Some v -> yield ("GestureRecognizers", box (Array.ofList(v))) 
            match anchorX with None -> () | Some v -> yield ("AnchorX", box ((v))) 
            match anchorY with None -> () | Some v -> yield ("AnchorY", box ((v))) 
            match backgroundColor with None -> () | Some v -> yield ("BackgroundColor", box ((v))) 
            match heightRequest with None -> () | Some v -> yield ("HeightRequest", box ((v))) 
            match inputTransparent with None -> () | Some v -> yield ("InputTransparent", box ((v))) 
            match isEnabled with None -> () | Some v -> yield ("IsEnabled", box ((v))) 
            match isVisible with None -> () | Some v -> yield ("IsVisible", box ((v))) 
            match minimumHeightRequest with None -> () | Some v -> yield ("MinimumHeightRequest", box ((v))) 
            match minimumWidthRequest with None -> () | Some v -> yield ("MinimumWidthRequest", box ((v))) 
            match opacity with None -> () | Some v -> yield ("Opacity", box ((v))) 
            match rotation with None -> () | Some v -> yield ("Rotation", box ((v))) 
            match rotationX with None -> () | Some v -> yield ("RotationX", box ((v))) 
            match rotationY with None -> () | Some v -> yield ("RotationY", box ((v))) 
            match scale with None -> () | Some v -> yield ("Scale", box ((v))) 
            match style with None -> () | Some v -> yield ("Style", box ((v))) 
            match translationX with None -> () | Some v -> yield ("TranslationX", box ((v))) 
            match translationY with None -> () | Some v -> yield ("TranslationY", box ((v))) 
            match widthRequest with None -> () | Some v -> yield ("WidthRequest", box ((v))) 
            match classId with None -> () | Some v -> yield ("ClassId", box ((v))) 
            match styleId with None -> () | Some v -> yield ("StyleId", box ((v))) 
          |]

        let create () =
            box (new Xamarin.Forms.TemplatedView())

        let apply (prevOpt: XamlElement option) (source: XamlElement) (target:obj) = 
            let target = (target :?> Xamarin.Forms.TemplatedView)
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsClippedToBounds
            match prevValueOpt, source.TryIsClippedToBounds with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsClippedToBounds <- value
            | Some _, None -> target.IsClippedToBounds <- false // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryPadding
            match prevValueOpt, source.TryPadding with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Padding <- value
            | Some _, None -> target.Padding <- Unchecked.defaultof<Xamarin.Forms.Thickness> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryHorizontalOptions
            match prevValueOpt, source.TryHorizontalOptions with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.HorizontalOptions <- value
            | Some _, None -> target.HorizontalOptions <- Unchecked.defaultof<Xamarin.Forms.LayoutOptions> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryVerticalOptions
            match prevValueOpt, source.TryVerticalOptions with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.VerticalOptions <- value
            | Some _, None -> target.VerticalOptions <- Unchecked.defaultof<Xamarin.Forms.LayoutOptions> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMargin
            match prevValueOpt, source.TryMargin with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Margin <- value
            | Some _, None -> target.Margin <- Unchecked.defaultof<Xamarin.Forms.Thickness> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevCollOpt = match prevOpt with None -> None | Some prev -> prev.TryGestureRecognizers
            match prevCollOpt, source.TryGestureRecognizers with
            // For structured objects, amortize on reference equality
            | Some prevColl, Some newColl when System.Object.ReferenceEquals(prevColl, newColl) -> ()
            | _, Some coll when coll <> null && coll.Length > 0 ->
                applyToIList
                    prevCollOpt
                    coll
                    target.GestureRecognizers
                    (fun (x:XamlElement) -> x.CreateAsIGestureRecognizer())
                    (fun _ _ _ -> ())
                    (fun (prevChild:XamlElement) (newChild:XamlElement) -> prevChild.TargetType = newChild.TargetType)
                    (fun prevChild newChild targetChild -> newChild.ApplyIncremental(prevChild, targetChild))
            | _ -> target.GestureRecognizers.Clear()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryAnchorX
            match prevValueOpt, source.TryAnchorX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.AnchorX <- value
            | Some _, None -> target.AnchorX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryAnchorY
            match prevValueOpt, source.TryAnchorY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.AnchorY <- value
            | Some _, None -> target.AnchorY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryBackgroundColor
            match prevValueOpt, source.TryBackgroundColor with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.BackgroundColor <- value
            | Some _, None -> target.BackgroundColor <- Xamarin.Forms.Color.Default // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryHeightRequest
            match prevValueOpt, source.TryHeightRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.HeightRequest <- value
            | Some _, None -> target.HeightRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryInputTransparent
            match prevValueOpt, source.TryInputTransparent with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.InputTransparent <- value
            | Some _, None -> target.InputTransparent <- false // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsEnabled
            match prevValueOpt, source.TryIsEnabled with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsEnabled <- value
            | Some _, None -> target.IsEnabled <- true // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsVisible
            match prevValueOpt, source.TryIsVisible with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsVisible <- value
            | Some _, None -> target.IsVisible <- true // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMinimumHeightRequest
            match prevValueOpt, source.TryMinimumHeightRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.MinimumHeightRequest <- value
            | Some _, None -> target.MinimumHeightRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMinimumWidthRequest
            match prevValueOpt, source.TryMinimumWidthRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.MinimumWidthRequest <- value
            | Some _, None -> target.MinimumWidthRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryOpacity
            match prevValueOpt, source.TryOpacity with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Opacity <- value
            | Some _, None -> target.Opacity <- 1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotation
            match prevValueOpt, source.TryRotation with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Rotation <- value
            | Some _, None -> target.Rotation <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotationX
            match prevValueOpt, source.TryRotationX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.RotationX <- value
            | Some _, None -> target.RotationX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotationY
            match prevValueOpt, source.TryRotationY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.RotationY <- value
            | Some _, None -> target.RotationY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryScale
            match prevValueOpt, source.TryScale with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Scale <- value
            | Some _, None -> target.Scale <- 1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryStyle
            match prevValueOpt, source.TryStyle with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Style <- value
            | Some _, None -> target.Style <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryTranslationX
            match prevValueOpt, source.TryTranslationX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.TranslationX <- value
            | Some _, None -> target.TranslationX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryTranslationY
            match prevValueOpt, source.TryTranslationY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.TranslationY <- value
            | Some _, None -> target.TranslationY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryWidthRequest
            match prevValueOpt, source.TryWidthRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.WidthRequest <- value
            | Some _, None -> target.WidthRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryClassId
            match prevValueOpt, source.TryClassId with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.ClassId <- value
            | Some _, None -> target.ClassId <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryStyleId
            match prevValueOpt, source.TryStyleId with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.StyleId <- value
            | Some _, None -> target.StyleId <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
        new XamlElement(typeof<Xamarin.Forms.TemplatedView>, create, apply, Map.ofArray attribs)

    /// Describes a DatePicker in the view
    static member DatePicker(?date: System.DateTime, ?format: string, ?minimumDate: System.DateTime, ?maximumDate: System.DateTime, ?dateSelected: Xamarin.Forms.DateChangedEventArgs -> unit, ?horizontalOptions: Xamarin.Forms.LayoutOptions, ?verticalOptions: Xamarin.Forms.LayoutOptions, ?margin: obj, ?gestureRecognizers: XamlElement list, ?anchorX: double, ?anchorY: double, ?backgroundColor: Xamarin.Forms.Color, ?heightRequest: double, ?inputTransparent: bool, ?isEnabled: bool, ?isVisible: bool, ?minimumHeightRequest: double, ?minimumWidthRequest: double, ?opacity: double, ?rotation: double, ?rotationX: double, ?rotationY: double, ?scale: double, ?style: Xamarin.Forms.Style, ?translationX: double, ?translationY: double, ?widthRequest: double, ?classId: string, ?styleId: string) = 
        let attribs = [| 
            match date with None -> () | Some v -> yield ("Date", box ((v))) 
            match format with None -> () | Some v -> yield ("Format", box ((v))) 
            match minimumDate with None -> () | Some v -> yield ("MinimumDate", box ((v))) 
            match maximumDate with None -> () | Some v -> yield ("MaximumDate", box ((v))) 
            match dateSelected with None -> () | Some v -> yield ("DateSelected", box ((fun f -> System.EventHandler<Xamarin.Forms.DateChangedEventArgs>(fun _sender args -> f args))(v))) 
            match horizontalOptions with None -> () | Some v -> yield ("HorizontalOptions", box ((v))) 
            match verticalOptions with None -> () | Some v -> yield ("VerticalOptions", box ((v))) 
            match margin with None -> () | Some v -> yield ("Margin", box (makeThickness(v))) 
            match gestureRecognizers with None -> () | Some v -> yield ("GestureRecognizers", box (Array.ofList(v))) 
            match anchorX with None -> () | Some v -> yield ("AnchorX", box ((v))) 
            match anchorY with None -> () | Some v -> yield ("AnchorY", box ((v))) 
            match backgroundColor with None -> () | Some v -> yield ("BackgroundColor", box ((v))) 
            match heightRequest with None -> () | Some v -> yield ("HeightRequest", box ((v))) 
            match inputTransparent with None -> () | Some v -> yield ("InputTransparent", box ((v))) 
            match isEnabled with None -> () | Some v -> yield ("IsEnabled", box ((v))) 
            match isVisible with None -> () | Some v -> yield ("IsVisible", box ((v))) 
            match minimumHeightRequest with None -> () | Some v -> yield ("MinimumHeightRequest", box ((v))) 
            match minimumWidthRequest with None -> () | Some v -> yield ("MinimumWidthRequest", box ((v))) 
            match opacity with None -> () | Some v -> yield ("Opacity", box ((v))) 
            match rotation with None -> () | Some v -> yield ("Rotation", box ((v))) 
            match rotationX with None -> () | Some v -> yield ("RotationX", box ((v))) 
            match rotationY with None -> () | Some v -> yield ("RotationY", box ((v))) 
            match scale with None -> () | Some v -> yield ("Scale", box ((v))) 
            match style with None -> () | Some v -> yield ("Style", box ((v))) 
            match translationX with None -> () | Some v -> yield ("TranslationX", box ((v))) 
            match translationY with None -> () | Some v -> yield ("TranslationY", box ((v))) 
            match widthRequest with None -> () | Some v -> yield ("WidthRequest", box ((v))) 
            match classId with None -> () | Some v -> yield ("ClassId", box ((v))) 
            match styleId with None -> () | Some v -> yield ("StyleId", box ((v))) 
          |]

        let create () =
            box (new Xamarin.Forms.DatePicker())

        let apply (prevOpt: XamlElement option) (source: XamlElement) (target:obj) = 
            let target = (target :?> Xamarin.Forms.DatePicker)
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryDate
            match prevValueOpt, source.TryDate with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Date <- value
            | Some _, None -> target.Date <- Unchecked.defaultof<System.DateTime> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryFormat
            match prevValueOpt, source.TryFormat with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Format <- value
            | Some _, None -> target.Format <- "d" // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMinimumDate
            match prevValueOpt, source.TryMinimumDate with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.MinimumDate <- value
            | Some _, None -> target.MinimumDate <- new System.DateTime(1900, 1, 1) // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMaximumDate
            match prevValueOpt, source.TryMaximumDate with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.MaximumDate <- value
            | Some _, None -> target.MaximumDate <- new System.DateTime(2100, 12, 31) // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryDateSelected
            match prevValueOpt, source.TryDateSelected with
            | Some prevValue, Some value when System.Object.ReferenceEquals(prevValue, value) -> ()
            | Some prevValue, Some value -> target.DateSelected.RemoveHandler(prevValue); target.DateSelected.AddHandler(value)
            | None, Some value -> target.DateSelected.AddHandler(value)
            | Some prevValue, None -> target.DateSelected.RemoveHandler(prevValue)
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryHorizontalOptions
            match prevValueOpt, source.TryHorizontalOptions with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.HorizontalOptions <- value
            | Some _, None -> target.HorizontalOptions <- Unchecked.defaultof<Xamarin.Forms.LayoutOptions> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryVerticalOptions
            match prevValueOpt, source.TryVerticalOptions with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.VerticalOptions <- value
            | Some _, None -> target.VerticalOptions <- Unchecked.defaultof<Xamarin.Forms.LayoutOptions> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMargin
            match prevValueOpt, source.TryMargin with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Margin <- value
            | Some _, None -> target.Margin <- Unchecked.defaultof<Xamarin.Forms.Thickness> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevCollOpt = match prevOpt with None -> None | Some prev -> prev.TryGestureRecognizers
            match prevCollOpt, source.TryGestureRecognizers with
            // For structured objects, amortize on reference equality
            | Some prevColl, Some newColl when System.Object.ReferenceEquals(prevColl, newColl) -> ()
            | _, Some coll when coll <> null && coll.Length > 0 ->
                applyToIList
                    prevCollOpt
                    coll
                    target.GestureRecognizers
                    (fun (x:XamlElement) -> x.CreateAsIGestureRecognizer())
                    (fun _ _ _ -> ())
                    (fun (prevChild:XamlElement) (newChild:XamlElement) -> prevChild.TargetType = newChild.TargetType)
                    (fun prevChild newChild targetChild -> newChild.ApplyIncremental(prevChild, targetChild))
            | _ -> target.GestureRecognizers.Clear()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryAnchorX
            match prevValueOpt, source.TryAnchorX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.AnchorX <- value
            | Some _, None -> target.AnchorX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryAnchorY
            match prevValueOpt, source.TryAnchorY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.AnchorY <- value
            | Some _, None -> target.AnchorY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryBackgroundColor
            match prevValueOpt, source.TryBackgroundColor with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.BackgroundColor <- value
            | Some _, None -> target.BackgroundColor <- Xamarin.Forms.Color.Default // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryHeightRequest
            match prevValueOpt, source.TryHeightRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.HeightRequest <- value
            | Some _, None -> target.HeightRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryInputTransparent
            match prevValueOpt, source.TryInputTransparent with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.InputTransparent <- value
            | Some _, None -> target.InputTransparent <- false // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsEnabled
            match prevValueOpt, source.TryIsEnabled with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsEnabled <- value
            | Some _, None -> target.IsEnabled <- true // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsVisible
            match prevValueOpt, source.TryIsVisible with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsVisible <- value
            | Some _, None -> target.IsVisible <- true // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMinimumHeightRequest
            match prevValueOpt, source.TryMinimumHeightRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.MinimumHeightRequest <- value
            | Some _, None -> target.MinimumHeightRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMinimumWidthRequest
            match prevValueOpt, source.TryMinimumWidthRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.MinimumWidthRequest <- value
            | Some _, None -> target.MinimumWidthRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryOpacity
            match prevValueOpt, source.TryOpacity with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Opacity <- value
            | Some _, None -> target.Opacity <- 1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotation
            match prevValueOpt, source.TryRotation with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Rotation <- value
            | Some _, None -> target.Rotation <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotationX
            match prevValueOpt, source.TryRotationX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.RotationX <- value
            | Some _, None -> target.RotationX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotationY
            match prevValueOpt, source.TryRotationY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.RotationY <- value
            | Some _, None -> target.RotationY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryScale
            match prevValueOpt, source.TryScale with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Scale <- value
            | Some _, None -> target.Scale <- 1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryStyle
            match prevValueOpt, source.TryStyle with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Style <- value
            | Some _, None -> target.Style <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryTranslationX
            match prevValueOpt, source.TryTranslationX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.TranslationX <- value
            | Some _, None -> target.TranslationX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryTranslationY
            match prevValueOpt, source.TryTranslationY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.TranslationY <- value
            | Some _, None -> target.TranslationY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryWidthRequest
            match prevValueOpt, source.TryWidthRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.WidthRequest <- value
            | Some _, None -> target.WidthRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryClassId
            match prevValueOpt, source.TryClassId with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.ClassId <- value
            | Some _, None -> target.ClassId <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryStyleId
            match prevValueOpt, source.TryStyleId with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.StyleId <- value
            | Some _, None -> target.StyleId <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
        new XamlElement(typeof<Xamarin.Forms.DatePicker>, create, apply, Map.ofArray attribs)

    /// Describes a Picker in the view
    static member Picker(?itemsSource: 'T list, ?selectedIndex: int, ?title: string, ?textColor: Xamarin.Forms.Color, ?selectedIndexChanged: (int * 'T option) -> unit, ?horizontalOptions: Xamarin.Forms.LayoutOptions, ?verticalOptions: Xamarin.Forms.LayoutOptions, ?margin: obj, ?gestureRecognizers: XamlElement list, ?anchorX: double, ?anchorY: double, ?backgroundColor: Xamarin.Forms.Color, ?heightRequest: double, ?inputTransparent: bool, ?isEnabled: bool, ?isVisible: bool, ?minimumHeightRequest: double, ?minimumWidthRequest: double, ?opacity: double, ?rotation: double, ?rotationX: double, ?rotationY: double, ?scale: double, ?style: Xamarin.Forms.Style, ?translationX: double, ?translationY: double, ?widthRequest: double, ?classId: string, ?styleId: string) = 
        let attribs = [| 
            match itemsSource with None -> () | Some v -> yield ("PickerItemsSource", box ((fun es -> es |> Array.ofList :> System.Collections.IList)(v))) 
            match selectedIndex with None -> () | Some v -> yield ("SelectedIndex", box ((v))) 
            match title with None -> () | Some v -> yield ("Title", box ((v))) 
            match textColor with None -> () | Some v -> yield ("TextColor", box ((v))) 
            match selectedIndexChanged with None -> () | Some v -> yield ("SelectedIndexChanged", box ((fun f -> System.EventHandler(fun sender args -> let picker = (sender :?> Xamarin.Forms.Picker) in f (picker.SelectedIndex, (picker.SelectedItem |> Option.ofObj |> Option.map unbox<'T>))))(v))) 
            match horizontalOptions with None -> () | Some v -> yield ("HorizontalOptions", box ((v))) 
            match verticalOptions with None -> () | Some v -> yield ("VerticalOptions", box ((v))) 
            match margin with None -> () | Some v -> yield ("Margin", box (makeThickness(v))) 
            match gestureRecognizers with None -> () | Some v -> yield ("GestureRecognizers", box (Array.ofList(v))) 
            match anchorX with None -> () | Some v -> yield ("AnchorX", box ((v))) 
            match anchorY with None -> () | Some v -> yield ("AnchorY", box ((v))) 
            match backgroundColor with None -> () | Some v -> yield ("BackgroundColor", box ((v))) 
            match heightRequest with None -> () | Some v -> yield ("HeightRequest", box ((v))) 
            match inputTransparent with None -> () | Some v -> yield ("InputTransparent", box ((v))) 
            match isEnabled with None -> () | Some v -> yield ("IsEnabled", box ((v))) 
            match isVisible with None -> () | Some v -> yield ("IsVisible", box ((v))) 
            match minimumHeightRequest with None -> () | Some v -> yield ("MinimumHeightRequest", box ((v))) 
            match minimumWidthRequest with None -> () | Some v -> yield ("MinimumWidthRequest", box ((v))) 
            match opacity with None -> () | Some v -> yield ("Opacity", box ((v))) 
            match rotation with None -> () | Some v -> yield ("Rotation", box ((v))) 
            match rotationX with None -> () | Some v -> yield ("RotationX", box ((v))) 
            match rotationY with None -> () | Some v -> yield ("RotationY", box ((v))) 
            match scale with None -> () | Some v -> yield ("Scale", box ((v))) 
            match style with None -> () | Some v -> yield ("Style", box ((v))) 
            match translationX with None -> () | Some v -> yield ("TranslationX", box ((v))) 
            match translationY with None -> () | Some v -> yield ("TranslationY", box ((v))) 
            match widthRequest with None -> () | Some v -> yield ("WidthRequest", box ((v))) 
            match classId with None -> () | Some v -> yield ("ClassId", box ((v))) 
            match styleId with None -> () | Some v -> yield ("StyleId", box ((v))) 
          |]

        let create () =
            box (new Xamarin.Forms.Picker())

        let apply (prevOpt: XamlElement option) (source: XamlElement) (target:obj) = 
            let target = (target :?> Xamarin.Forms.Picker)
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryPickerItemsSource
            match prevValueOpt, source.TryPickerItemsSource with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.ItemsSource <- value
            | Some _, None -> target.ItemsSource <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TrySelectedIndex
            match prevValueOpt, source.TrySelectedIndex with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.SelectedIndex <- value
            | Some _, None -> target.SelectedIndex <- 0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryTitle
            match prevValueOpt, source.TryTitle with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Title <- value
            | Some _, None -> target.Title <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryTextColor
            match prevValueOpt, source.TryTextColor with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.TextColor <- value
            | Some _, None -> target.TextColor <- Xamarin.Forms.Color.Default // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TrySelectedIndexChanged
            match prevValueOpt, source.TrySelectedIndexChanged with
            | Some prevValue, Some value when System.Object.ReferenceEquals(prevValue, value) -> ()
            | Some prevValue, Some value -> target.SelectedIndexChanged.RemoveHandler(prevValue); target.SelectedIndexChanged.AddHandler(value)
            | None, Some value -> target.SelectedIndexChanged.AddHandler(value)
            | Some prevValue, None -> target.SelectedIndexChanged.RemoveHandler(prevValue)
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryHorizontalOptions
            match prevValueOpt, source.TryHorizontalOptions with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.HorizontalOptions <- value
            | Some _, None -> target.HorizontalOptions <- Unchecked.defaultof<Xamarin.Forms.LayoutOptions> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryVerticalOptions
            match prevValueOpt, source.TryVerticalOptions with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.VerticalOptions <- value
            | Some _, None -> target.VerticalOptions <- Unchecked.defaultof<Xamarin.Forms.LayoutOptions> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMargin
            match prevValueOpt, source.TryMargin with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Margin <- value
            | Some _, None -> target.Margin <- Unchecked.defaultof<Xamarin.Forms.Thickness> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevCollOpt = match prevOpt with None -> None | Some prev -> prev.TryGestureRecognizers
            match prevCollOpt, source.TryGestureRecognizers with
            // For structured objects, amortize on reference equality
            | Some prevColl, Some newColl when System.Object.ReferenceEquals(prevColl, newColl) -> ()
            | _, Some coll when coll <> null && coll.Length > 0 ->
                applyToIList
                    prevCollOpt
                    coll
                    target.GestureRecognizers
                    (fun (x:XamlElement) -> x.CreateAsIGestureRecognizer())
                    (fun _ _ _ -> ())
                    (fun (prevChild:XamlElement) (newChild:XamlElement) -> prevChild.TargetType = newChild.TargetType)
                    (fun prevChild newChild targetChild -> newChild.ApplyIncremental(prevChild, targetChild))
            | _ -> target.GestureRecognizers.Clear()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryAnchorX
            match prevValueOpt, source.TryAnchorX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.AnchorX <- value
            | Some _, None -> target.AnchorX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryAnchorY
            match prevValueOpt, source.TryAnchorY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.AnchorY <- value
            | Some _, None -> target.AnchorY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryBackgroundColor
            match prevValueOpt, source.TryBackgroundColor with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.BackgroundColor <- value
            | Some _, None -> target.BackgroundColor <- Xamarin.Forms.Color.Default // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryHeightRequest
            match prevValueOpt, source.TryHeightRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.HeightRequest <- value
            | Some _, None -> target.HeightRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryInputTransparent
            match prevValueOpt, source.TryInputTransparent with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.InputTransparent <- value
            | Some _, None -> target.InputTransparent <- false // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsEnabled
            match prevValueOpt, source.TryIsEnabled with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsEnabled <- value
            | Some _, None -> target.IsEnabled <- true // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsVisible
            match prevValueOpt, source.TryIsVisible with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsVisible <- value
            | Some _, None -> target.IsVisible <- true // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMinimumHeightRequest
            match prevValueOpt, source.TryMinimumHeightRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.MinimumHeightRequest <- value
            | Some _, None -> target.MinimumHeightRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMinimumWidthRequest
            match prevValueOpt, source.TryMinimumWidthRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.MinimumWidthRequest <- value
            | Some _, None -> target.MinimumWidthRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryOpacity
            match prevValueOpt, source.TryOpacity with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Opacity <- value
            | Some _, None -> target.Opacity <- 1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotation
            match prevValueOpt, source.TryRotation with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Rotation <- value
            | Some _, None -> target.Rotation <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotationX
            match prevValueOpt, source.TryRotationX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.RotationX <- value
            | Some _, None -> target.RotationX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotationY
            match prevValueOpt, source.TryRotationY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.RotationY <- value
            | Some _, None -> target.RotationY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryScale
            match prevValueOpt, source.TryScale with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Scale <- value
            | Some _, None -> target.Scale <- 1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryStyle
            match prevValueOpt, source.TryStyle with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Style <- value
            | Some _, None -> target.Style <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryTranslationX
            match prevValueOpt, source.TryTranslationX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.TranslationX <- value
            | Some _, None -> target.TranslationX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryTranslationY
            match prevValueOpt, source.TryTranslationY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.TranslationY <- value
            | Some _, None -> target.TranslationY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryWidthRequest
            match prevValueOpt, source.TryWidthRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.WidthRequest <- value
            | Some _, None -> target.WidthRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryClassId
            match prevValueOpt, source.TryClassId with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.ClassId <- value
            | Some _, None -> target.ClassId <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryStyleId
            match prevValueOpt, source.TryStyleId with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.StyleId <- value
            | Some _, None -> target.StyleId <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
        new XamlElement(typeof<Xamarin.Forms.Picker>, create, apply, Map.ofArray attribs)

    /// Describes a Frame in the view
    static member Frame(?outlineColor: Xamarin.Forms.Color, ?cornerRadius: single, ?hasShadow: bool, ?content: XamlElement, ?isClippedToBounds: bool, ?padding: double, ?horizontalOptions: Xamarin.Forms.LayoutOptions, ?verticalOptions: Xamarin.Forms.LayoutOptions, ?margin: obj, ?gestureRecognizers: XamlElement list, ?anchorX: double, ?anchorY: double, ?backgroundColor: Xamarin.Forms.Color, ?heightRequest: double, ?inputTransparent: bool, ?isEnabled: bool, ?isVisible: bool, ?minimumHeightRequest: double, ?minimumWidthRequest: double, ?opacity: double, ?rotation: double, ?rotationX: double, ?rotationY: double, ?scale: double, ?style: Xamarin.Forms.Style, ?translationX: double, ?translationY: double, ?widthRequest: double, ?classId: string, ?styleId: string) = 
        let attribs = [| 
            match outlineColor with None -> () | Some v -> yield ("OutlineColor", box ((v))) 
            match cornerRadius with None -> () | Some v -> yield ("FrameCornerRadius", box ((v))) 
            match hasShadow with None -> () | Some v -> yield ("HasShadow", box ((v))) 
            match content with None -> () | Some v -> yield ("Content", box ((v))) 
            match isClippedToBounds with None -> () | Some v -> yield ("IsClippedToBounds", box ((v))) 
            match padding with None -> () | Some v -> yield ("Padding", box (makeThickness(v))) 
            match horizontalOptions with None -> () | Some v -> yield ("HorizontalOptions", box ((v))) 
            match verticalOptions with None -> () | Some v -> yield ("VerticalOptions", box ((v))) 
            match margin with None -> () | Some v -> yield ("Margin", box (makeThickness(v))) 
            match gestureRecognizers with None -> () | Some v -> yield ("GestureRecognizers", box (Array.ofList(v))) 
            match anchorX with None -> () | Some v -> yield ("AnchorX", box ((v))) 
            match anchorY with None -> () | Some v -> yield ("AnchorY", box ((v))) 
            match backgroundColor with None -> () | Some v -> yield ("BackgroundColor", box ((v))) 
            match heightRequest with None -> () | Some v -> yield ("HeightRequest", box ((v))) 
            match inputTransparent with None -> () | Some v -> yield ("InputTransparent", box ((v))) 
            match isEnabled with None -> () | Some v -> yield ("IsEnabled", box ((v))) 
            match isVisible with None -> () | Some v -> yield ("IsVisible", box ((v))) 
            match minimumHeightRequest with None -> () | Some v -> yield ("MinimumHeightRequest", box ((v))) 
            match minimumWidthRequest with None -> () | Some v -> yield ("MinimumWidthRequest", box ((v))) 
            match opacity with None -> () | Some v -> yield ("Opacity", box ((v))) 
            match rotation with None -> () | Some v -> yield ("Rotation", box ((v))) 
            match rotationX with None -> () | Some v -> yield ("RotationX", box ((v))) 
            match rotationY with None -> () | Some v -> yield ("RotationY", box ((v))) 
            match scale with None -> () | Some v -> yield ("Scale", box ((v))) 
            match style with None -> () | Some v -> yield ("Style", box ((v))) 
            match translationX with None -> () | Some v -> yield ("TranslationX", box ((v))) 
            match translationY with None -> () | Some v -> yield ("TranslationY", box ((v))) 
            match widthRequest with None -> () | Some v -> yield ("WidthRequest", box ((v))) 
            match classId with None -> () | Some v -> yield ("ClassId", box ((v))) 
            match styleId with None -> () | Some v -> yield ("StyleId", box ((v))) 
          |]

        let create () =
            box (new Xamarin.Forms.Frame())

        let apply (prevOpt: XamlElement option) (source: XamlElement) (target:obj) = 
            let target = (target :?> Xamarin.Forms.Frame)
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryOutlineColor
            match prevValueOpt, source.TryOutlineColor with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.OutlineColor <- value
            | Some _, None -> target.OutlineColor <- Xamarin.Forms.Color.Default // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryFrameCornerRadius
            match prevValueOpt, source.TryFrameCornerRadius with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.CornerRadius <- value
            | Some _, None -> target.CornerRadius <- -1.0f // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryHasShadow
            match prevValueOpt, source.TryHasShadow with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.HasShadow <- value
            | Some _, None -> target.HasShadow <- true // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevChildOpt = match prevOpt with None -> None | Some prev -> prev.TryContent
            match prevChildOpt, source.TryContent with
            // For structured objects, amortize on reference equality
            | Some prevChild, Some newChild when System.Object.ReferenceEquals(prevChild, newChild) -> ()
            | Some prevChild, Some newChild ->
                newChild.ApplyIncremental(prevChild, target.Content)
            | None, Some newChild ->
                target.Content <- newChild.CreateAsView()
            | Some _, None ->
                target.Content <- null;
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsClippedToBounds
            match prevValueOpt, source.TryIsClippedToBounds with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsClippedToBounds <- value
            | Some _, None -> target.IsClippedToBounds <- false // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryPadding
            match prevValueOpt, source.TryPadding with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Padding <- value
            | Some _, None -> target.Padding <- Unchecked.defaultof<Xamarin.Forms.Thickness> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryHorizontalOptions
            match prevValueOpt, source.TryHorizontalOptions with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.HorizontalOptions <- value
            | Some _, None -> target.HorizontalOptions <- Unchecked.defaultof<Xamarin.Forms.LayoutOptions> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryVerticalOptions
            match prevValueOpt, source.TryVerticalOptions with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.VerticalOptions <- value
            | Some _, None -> target.VerticalOptions <- Unchecked.defaultof<Xamarin.Forms.LayoutOptions> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMargin
            match prevValueOpt, source.TryMargin with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Margin <- value
            | Some _, None -> target.Margin <- Unchecked.defaultof<Xamarin.Forms.Thickness> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevCollOpt = match prevOpt with None -> None | Some prev -> prev.TryGestureRecognizers
            match prevCollOpt, source.TryGestureRecognizers with
            // For structured objects, amortize on reference equality
            | Some prevColl, Some newColl when System.Object.ReferenceEquals(prevColl, newColl) -> ()
            | _, Some coll when coll <> null && coll.Length > 0 ->
                applyToIList
                    prevCollOpt
                    coll
                    target.GestureRecognizers
                    (fun (x:XamlElement) -> x.CreateAsIGestureRecognizer())
                    (fun _ _ _ -> ())
                    (fun (prevChild:XamlElement) (newChild:XamlElement) -> prevChild.TargetType = newChild.TargetType)
                    (fun prevChild newChild targetChild -> newChild.ApplyIncremental(prevChild, targetChild))
            | _ -> target.GestureRecognizers.Clear()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryAnchorX
            match prevValueOpt, source.TryAnchorX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.AnchorX <- value
            | Some _, None -> target.AnchorX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryAnchorY
            match prevValueOpt, source.TryAnchorY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.AnchorY <- value
            | Some _, None -> target.AnchorY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryBackgroundColor
            match prevValueOpt, source.TryBackgroundColor with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.BackgroundColor <- value
            | Some _, None -> target.BackgroundColor <- Xamarin.Forms.Color.Default // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryHeightRequest
            match prevValueOpt, source.TryHeightRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.HeightRequest <- value
            | Some _, None -> target.HeightRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryInputTransparent
            match prevValueOpt, source.TryInputTransparent with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.InputTransparent <- value
            | Some _, None -> target.InputTransparent <- false // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsEnabled
            match prevValueOpt, source.TryIsEnabled with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsEnabled <- value
            | Some _, None -> target.IsEnabled <- true // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsVisible
            match prevValueOpt, source.TryIsVisible with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsVisible <- value
            | Some _, None -> target.IsVisible <- true // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMinimumHeightRequest
            match prevValueOpt, source.TryMinimumHeightRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.MinimumHeightRequest <- value
            | Some _, None -> target.MinimumHeightRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMinimumWidthRequest
            match prevValueOpt, source.TryMinimumWidthRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.MinimumWidthRequest <- value
            | Some _, None -> target.MinimumWidthRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryOpacity
            match prevValueOpt, source.TryOpacity with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Opacity <- value
            | Some _, None -> target.Opacity <- 1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotation
            match prevValueOpt, source.TryRotation with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Rotation <- value
            | Some _, None -> target.Rotation <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotationX
            match prevValueOpt, source.TryRotationX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.RotationX <- value
            | Some _, None -> target.RotationX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotationY
            match prevValueOpt, source.TryRotationY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.RotationY <- value
            | Some _, None -> target.RotationY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryScale
            match prevValueOpt, source.TryScale with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Scale <- value
            | Some _, None -> target.Scale <- 1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryStyle
            match prevValueOpt, source.TryStyle with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Style <- value
            | Some _, None -> target.Style <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryTranslationX
            match prevValueOpt, source.TryTranslationX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.TranslationX <- value
            | Some _, None -> target.TranslationX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryTranslationY
            match prevValueOpt, source.TryTranslationY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.TranslationY <- value
            | Some _, None -> target.TranslationY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryWidthRequest
            match prevValueOpt, source.TryWidthRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.WidthRequest <- value
            | Some _, None -> target.WidthRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryClassId
            match prevValueOpt, source.TryClassId with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.ClassId <- value
            | Some _, None -> target.ClassId <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryStyleId
            match prevValueOpt, source.TryStyleId with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.StyleId <- value
            | Some _, None -> target.StyleId <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
        new XamlElement(typeof<Xamarin.Forms.Frame>, create, apply, Map.ofArray attribs)

    /// Describes a Image in the view
    static member Image(?source: string, ?aspect: Xamarin.Forms.Aspect, ?isOpaque: bool, ?horizontalOptions: Xamarin.Forms.LayoutOptions, ?verticalOptions: Xamarin.Forms.LayoutOptions, ?margin: obj, ?gestureRecognizers: XamlElement list, ?anchorX: double, ?anchorY: double, ?backgroundColor: Xamarin.Forms.Color, ?heightRequest: double, ?inputTransparent: bool, ?isEnabled: bool, ?isVisible: bool, ?minimumHeightRequest: double, ?minimumWidthRequest: double, ?opacity: double, ?rotation: double, ?rotationX: double, ?rotationY: double, ?scale: double, ?style: Xamarin.Forms.Style, ?translationX: double, ?translationY: double, ?widthRequest: double, ?classId: string, ?styleId: string) = 
        let attribs = [| 
            match source with None -> () | Some v -> yield ("ImageSource", box (makeImageSource(v))) 
            match aspect with None -> () | Some v -> yield ("Aspect", box ((v))) 
            match isOpaque with None -> () | Some v -> yield ("IsOpaque", box ((v))) 
            match horizontalOptions with None -> () | Some v -> yield ("HorizontalOptions", box ((v))) 
            match verticalOptions with None -> () | Some v -> yield ("VerticalOptions", box ((v))) 
            match margin with None -> () | Some v -> yield ("Margin", box (makeThickness(v))) 
            match gestureRecognizers with None -> () | Some v -> yield ("GestureRecognizers", box (Array.ofList(v))) 
            match anchorX with None -> () | Some v -> yield ("AnchorX", box ((v))) 
            match anchorY with None -> () | Some v -> yield ("AnchorY", box ((v))) 
            match backgroundColor with None -> () | Some v -> yield ("BackgroundColor", box ((v))) 
            match heightRequest with None -> () | Some v -> yield ("HeightRequest", box ((v))) 
            match inputTransparent with None -> () | Some v -> yield ("InputTransparent", box ((v))) 
            match isEnabled with None -> () | Some v -> yield ("IsEnabled", box ((v))) 
            match isVisible with None -> () | Some v -> yield ("IsVisible", box ((v))) 
            match minimumHeightRequest with None -> () | Some v -> yield ("MinimumHeightRequest", box ((v))) 
            match minimumWidthRequest with None -> () | Some v -> yield ("MinimumWidthRequest", box ((v))) 
            match opacity with None -> () | Some v -> yield ("Opacity", box ((v))) 
            match rotation with None -> () | Some v -> yield ("Rotation", box ((v))) 
            match rotationX with None -> () | Some v -> yield ("RotationX", box ((v))) 
            match rotationY with None -> () | Some v -> yield ("RotationY", box ((v))) 
            match scale with None -> () | Some v -> yield ("Scale", box ((v))) 
            match style with None -> () | Some v -> yield ("Style", box ((v))) 
            match translationX with None -> () | Some v -> yield ("TranslationX", box ((v))) 
            match translationY with None -> () | Some v -> yield ("TranslationY", box ((v))) 
            match widthRequest with None -> () | Some v -> yield ("WidthRequest", box ((v))) 
            match classId with None -> () | Some v -> yield ("ClassId", box ((v))) 
            match styleId with None -> () | Some v -> yield ("StyleId", box ((v))) 
          |]

        let create () =
            box (new Xamarin.Forms.Image())

        let apply (prevOpt: XamlElement option) (source: XamlElement) (target:obj) = 
            let target = (target :?> Xamarin.Forms.Image)
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryImageSource
            match prevValueOpt, source.TryImageSource with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Source <- value
            | Some _, None -> target.Source <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryAspect
            match prevValueOpt, source.TryAspect with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Aspect <- value
            | Some _, None -> target.Aspect <- Xamarin.Forms.Aspect.AspectFit // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsOpaque
            match prevValueOpt, source.TryIsOpaque with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsOpaque <- value
            | Some _, None -> target.IsOpaque <- true // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryHorizontalOptions
            match prevValueOpt, source.TryHorizontalOptions with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.HorizontalOptions <- value
            | Some _, None -> target.HorizontalOptions <- Unchecked.defaultof<Xamarin.Forms.LayoutOptions> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryVerticalOptions
            match prevValueOpt, source.TryVerticalOptions with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.VerticalOptions <- value
            | Some _, None -> target.VerticalOptions <- Unchecked.defaultof<Xamarin.Forms.LayoutOptions> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMargin
            match prevValueOpt, source.TryMargin with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Margin <- value
            | Some _, None -> target.Margin <- Unchecked.defaultof<Xamarin.Forms.Thickness> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevCollOpt = match prevOpt with None -> None | Some prev -> prev.TryGestureRecognizers
            match prevCollOpt, source.TryGestureRecognizers with
            // For structured objects, amortize on reference equality
            | Some prevColl, Some newColl when System.Object.ReferenceEquals(prevColl, newColl) -> ()
            | _, Some coll when coll <> null && coll.Length > 0 ->
                applyToIList
                    prevCollOpt
                    coll
                    target.GestureRecognizers
                    (fun (x:XamlElement) -> x.CreateAsIGestureRecognizer())
                    (fun _ _ _ -> ())
                    (fun (prevChild:XamlElement) (newChild:XamlElement) -> prevChild.TargetType = newChild.TargetType)
                    (fun prevChild newChild targetChild -> newChild.ApplyIncremental(prevChild, targetChild))
            | _ -> target.GestureRecognizers.Clear()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryAnchorX
            match prevValueOpt, source.TryAnchorX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.AnchorX <- value
            | Some _, None -> target.AnchorX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryAnchorY
            match prevValueOpt, source.TryAnchorY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.AnchorY <- value
            | Some _, None -> target.AnchorY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryBackgroundColor
            match prevValueOpt, source.TryBackgroundColor with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.BackgroundColor <- value
            | Some _, None -> target.BackgroundColor <- Xamarin.Forms.Color.Default // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryHeightRequest
            match prevValueOpt, source.TryHeightRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.HeightRequest <- value
            | Some _, None -> target.HeightRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryInputTransparent
            match prevValueOpt, source.TryInputTransparent with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.InputTransparent <- value
            | Some _, None -> target.InputTransparent <- false // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsEnabled
            match prevValueOpt, source.TryIsEnabled with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsEnabled <- value
            | Some _, None -> target.IsEnabled <- true // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsVisible
            match prevValueOpt, source.TryIsVisible with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsVisible <- value
            | Some _, None -> target.IsVisible <- true // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMinimumHeightRequest
            match prevValueOpt, source.TryMinimumHeightRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.MinimumHeightRequest <- value
            | Some _, None -> target.MinimumHeightRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMinimumWidthRequest
            match prevValueOpt, source.TryMinimumWidthRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.MinimumWidthRequest <- value
            | Some _, None -> target.MinimumWidthRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryOpacity
            match prevValueOpt, source.TryOpacity with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Opacity <- value
            | Some _, None -> target.Opacity <- 1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotation
            match prevValueOpt, source.TryRotation with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Rotation <- value
            | Some _, None -> target.Rotation <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotationX
            match prevValueOpt, source.TryRotationX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.RotationX <- value
            | Some _, None -> target.RotationX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotationY
            match prevValueOpt, source.TryRotationY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.RotationY <- value
            | Some _, None -> target.RotationY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryScale
            match prevValueOpt, source.TryScale with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Scale <- value
            | Some _, None -> target.Scale <- 1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryStyle
            match prevValueOpt, source.TryStyle with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Style <- value
            | Some _, None -> target.Style <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryTranslationX
            match prevValueOpt, source.TryTranslationX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.TranslationX <- value
            | Some _, None -> target.TranslationX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryTranslationY
            match prevValueOpt, source.TryTranslationY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.TranslationY <- value
            | Some _, None -> target.TranslationY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryWidthRequest
            match prevValueOpt, source.TryWidthRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.WidthRequest <- value
            | Some _, None -> target.WidthRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryClassId
            match prevValueOpt, source.TryClassId with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.ClassId <- value
            | Some _, None -> target.ClassId <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryStyleId
            match prevValueOpt, source.TryStyleId with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.StyleId <- value
            | Some _, None -> target.StyleId <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
        new XamlElement(typeof<Xamarin.Forms.Image>, create, apply, Map.ofArray attribs)

    /// Describes a InputView in the view
    static member InputView(?keyboard: Xamarin.Forms.Keyboard, ?horizontalOptions: Xamarin.Forms.LayoutOptions, ?verticalOptions: Xamarin.Forms.LayoutOptions, ?margin: obj, ?gestureRecognizers: XamlElement list, ?anchorX: double, ?anchorY: double, ?backgroundColor: Xamarin.Forms.Color, ?heightRequest: double, ?inputTransparent: bool, ?isEnabled: bool, ?isVisible: bool, ?minimumHeightRequest: double, ?minimumWidthRequest: double, ?opacity: double, ?rotation: double, ?rotationX: double, ?rotationY: double, ?scale: double, ?style: Xamarin.Forms.Style, ?translationX: double, ?translationY: double, ?widthRequest: double, ?classId: string, ?styleId: string) = 
        let attribs = [| 
            match keyboard with None -> () | Some v -> yield ("Keyboard", box ((v))) 
            match horizontalOptions with None -> () | Some v -> yield ("HorizontalOptions", box ((v))) 
            match verticalOptions with None -> () | Some v -> yield ("VerticalOptions", box ((v))) 
            match margin with None -> () | Some v -> yield ("Margin", box (makeThickness(v))) 
            match gestureRecognizers with None -> () | Some v -> yield ("GestureRecognizers", box (Array.ofList(v))) 
            match anchorX with None -> () | Some v -> yield ("AnchorX", box ((v))) 
            match anchorY with None -> () | Some v -> yield ("AnchorY", box ((v))) 
            match backgroundColor with None -> () | Some v -> yield ("BackgroundColor", box ((v))) 
            match heightRequest with None -> () | Some v -> yield ("HeightRequest", box ((v))) 
            match inputTransparent with None -> () | Some v -> yield ("InputTransparent", box ((v))) 
            match isEnabled with None -> () | Some v -> yield ("IsEnabled", box ((v))) 
            match isVisible with None -> () | Some v -> yield ("IsVisible", box ((v))) 
            match minimumHeightRequest with None -> () | Some v -> yield ("MinimumHeightRequest", box ((v))) 
            match minimumWidthRequest with None -> () | Some v -> yield ("MinimumWidthRequest", box ((v))) 
            match opacity with None -> () | Some v -> yield ("Opacity", box ((v))) 
            match rotation with None -> () | Some v -> yield ("Rotation", box ((v))) 
            match rotationX with None -> () | Some v -> yield ("RotationX", box ((v))) 
            match rotationY with None -> () | Some v -> yield ("RotationY", box ((v))) 
            match scale with None -> () | Some v -> yield ("Scale", box ((v))) 
            match style with None -> () | Some v -> yield ("Style", box ((v))) 
            match translationX with None -> () | Some v -> yield ("TranslationX", box ((v))) 
            match translationY with None -> () | Some v -> yield ("TranslationY", box ((v))) 
            match widthRequest with None -> () | Some v -> yield ("WidthRequest", box ((v))) 
            match classId with None -> () | Some v -> yield ("ClassId", box ((v))) 
            match styleId with None -> () | Some v -> yield ("StyleId", box ((v))) 
          |]

        let create () =
            failwith "can'tdef create Xamarin.Forms.InputView"

        let apply (prevOpt: XamlElement option) (source: XamlElement) (target:obj) = 
            let target = (target :?> Xamarin.Forms.InputView)
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryKeyboard
            match prevValueOpt, source.TryKeyboard with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Keyboard <- value
            | Some _, None -> target.Keyboard <- Xamarin.Forms.Keyboard.Default // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryHorizontalOptions
            match prevValueOpt, source.TryHorizontalOptions with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.HorizontalOptions <- value
            | Some _, None -> target.HorizontalOptions <- Unchecked.defaultof<Xamarin.Forms.LayoutOptions> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryVerticalOptions
            match prevValueOpt, source.TryVerticalOptions with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.VerticalOptions <- value
            | Some _, None -> target.VerticalOptions <- Unchecked.defaultof<Xamarin.Forms.LayoutOptions> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMargin
            match prevValueOpt, source.TryMargin with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Margin <- value
            | Some _, None -> target.Margin <- Unchecked.defaultof<Xamarin.Forms.Thickness> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevCollOpt = match prevOpt with None -> None | Some prev -> prev.TryGestureRecognizers
            match prevCollOpt, source.TryGestureRecognizers with
            // For structured objects, amortize on reference equality
            | Some prevColl, Some newColl when System.Object.ReferenceEquals(prevColl, newColl) -> ()
            | _, Some coll when coll <> null && coll.Length > 0 ->
                applyToIList
                    prevCollOpt
                    coll
                    target.GestureRecognizers
                    (fun (x:XamlElement) -> x.CreateAsIGestureRecognizer())
                    (fun _ _ _ -> ())
                    (fun (prevChild:XamlElement) (newChild:XamlElement) -> prevChild.TargetType = newChild.TargetType)
                    (fun prevChild newChild targetChild -> newChild.ApplyIncremental(prevChild, targetChild))
            | _ -> target.GestureRecognizers.Clear()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryAnchorX
            match prevValueOpt, source.TryAnchorX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.AnchorX <- value
            | Some _, None -> target.AnchorX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryAnchorY
            match prevValueOpt, source.TryAnchorY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.AnchorY <- value
            | Some _, None -> target.AnchorY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryBackgroundColor
            match prevValueOpt, source.TryBackgroundColor with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.BackgroundColor <- value
            | Some _, None -> target.BackgroundColor <- Xamarin.Forms.Color.Default // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryHeightRequest
            match prevValueOpt, source.TryHeightRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.HeightRequest <- value
            | Some _, None -> target.HeightRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryInputTransparent
            match prevValueOpt, source.TryInputTransparent with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.InputTransparent <- value
            | Some _, None -> target.InputTransparent <- false // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsEnabled
            match prevValueOpt, source.TryIsEnabled with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsEnabled <- value
            | Some _, None -> target.IsEnabled <- true // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsVisible
            match prevValueOpt, source.TryIsVisible with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsVisible <- value
            | Some _, None -> target.IsVisible <- true // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMinimumHeightRequest
            match prevValueOpt, source.TryMinimumHeightRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.MinimumHeightRequest <- value
            | Some _, None -> target.MinimumHeightRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMinimumWidthRequest
            match prevValueOpt, source.TryMinimumWidthRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.MinimumWidthRequest <- value
            | Some _, None -> target.MinimumWidthRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryOpacity
            match prevValueOpt, source.TryOpacity with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Opacity <- value
            | Some _, None -> target.Opacity <- 1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotation
            match prevValueOpt, source.TryRotation with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Rotation <- value
            | Some _, None -> target.Rotation <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotationX
            match prevValueOpt, source.TryRotationX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.RotationX <- value
            | Some _, None -> target.RotationX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotationY
            match prevValueOpt, source.TryRotationY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.RotationY <- value
            | Some _, None -> target.RotationY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryScale
            match prevValueOpt, source.TryScale with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Scale <- value
            | Some _, None -> target.Scale <- 1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryStyle
            match prevValueOpt, source.TryStyle with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Style <- value
            | Some _, None -> target.Style <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryTranslationX
            match prevValueOpt, source.TryTranslationX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.TranslationX <- value
            | Some _, None -> target.TranslationX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryTranslationY
            match prevValueOpt, source.TryTranslationY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.TranslationY <- value
            | Some _, None -> target.TranslationY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryWidthRequest
            match prevValueOpt, source.TryWidthRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.WidthRequest <- value
            | Some _, None -> target.WidthRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryClassId
            match prevValueOpt, source.TryClassId with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.ClassId <- value
            | Some _, None -> target.ClassId <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryStyleId
            match prevValueOpt, source.TryStyleId with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.StyleId <- value
            | Some _, None -> target.StyleId <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
        new XamlElement(typeof<Xamarin.Forms.InputView>, create, apply, Map.ofArray attribs)

    /// Describes a Editor in the view
    static member Editor(?text: string, ?fontSize: obj, ?fontFamily: string, ?fontAttributes: Xamarin.Forms.FontAttributes, ?textColor: Xamarin.Forms.Color, ?completed: string -> unit, ?textChanged: Xamarin.Forms.TextChangedEventArgs -> unit, ?keyboard: Xamarin.Forms.Keyboard, ?horizontalOptions: Xamarin.Forms.LayoutOptions, ?verticalOptions: Xamarin.Forms.LayoutOptions, ?margin: obj, ?gestureRecognizers: XamlElement list, ?anchorX: double, ?anchorY: double, ?backgroundColor: Xamarin.Forms.Color, ?heightRequest: double, ?inputTransparent: bool, ?isEnabled: bool, ?isVisible: bool, ?minimumHeightRequest: double, ?minimumWidthRequest: double, ?opacity: double, ?rotation: double, ?rotationX: double, ?rotationY: double, ?scale: double, ?style: Xamarin.Forms.Style, ?translationX: double, ?translationY: double, ?widthRequest: double, ?classId: string, ?styleId: string) = 
        let attribs = [| 
            match text with None -> () | Some v -> yield ("Text", box ((v))) 
            match fontSize with None -> () | Some v -> yield ("FontSize", box (makeFontSize(v))) 
            match fontFamily with None -> () | Some v -> yield ("FontFamily", box ((v))) 
            match fontAttributes with None -> () | Some v -> yield ("FontAttributes", box ((v))) 
            match textColor with None -> () | Some v -> yield ("TextColor", box ((v))) 
            match completed with None -> () | Some v -> yield ("EditorCompleted", box ((fun f -> System.EventHandler(fun sender args -> f (sender :?> Xamarin.Forms.Editor).Text))(v))) 
            match textChanged with None -> () | Some v -> yield ("TextChanged", box ((fun f -> System.EventHandler<Xamarin.Forms.TextChangedEventArgs>(fun _sender args -> f args))(v))) 
            match keyboard with None -> () | Some v -> yield ("Keyboard", box ((v))) 
            match horizontalOptions with None -> () | Some v -> yield ("HorizontalOptions", box ((v))) 
            match verticalOptions with None -> () | Some v -> yield ("VerticalOptions", box ((v))) 
            match margin with None -> () | Some v -> yield ("Margin", box (makeThickness(v))) 
            match gestureRecognizers with None -> () | Some v -> yield ("GestureRecognizers", box (Array.ofList(v))) 
            match anchorX with None -> () | Some v -> yield ("AnchorX", box ((v))) 
            match anchorY with None -> () | Some v -> yield ("AnchorY", box ((v))) 
            match backgroundColor with None -> () | Some v -> yield ("BackgroundColor", box ((v))) 
            match heightRequest with None -> () | Some v -> yield ("HeightRequest", box ((v))) 
            match inputTransparent with None -> () | Some v -> yield ("InputTransparent", box ((v))) 
            match isEnabled with None -> () | Some v -> yield ("IsEnabled", box ((v))) 
            match isVisible with None -> () | Some v -> yield ("IsVisible", box ((v))) 
            match minimumHeightRequest with None -> () | Some v -> yield ("MinimumHeightRequest", box ((v))) 
            match minimumWidthRequest with None -> () | Some v -> yield ("MinimumWidthRequest", box ((v))) 
            match opacity with None -> () | Some v -> yield ("Opacity", box ((v))) 
            match rotation with None -> () | Some v -> yield ("Rotation", box ((v))) 
            match rotationX with None -> () | Some v -> yield ("RotationX", box ((v))) 
            match rotationY with None -> () | Some v -> yield ("RotationY", box ((v))) 
            match scale with None -> () | Some v -> yield ("Scale", box ((v))) 
            match style with None -> () | Some v -> yield ("Style", box ((v))) 
            match translationX with None -> () | Some v -> yield ("TranslationX", box ((v))) 
            match translationY with None -> () | Some v -> yield ("TranslationY", box ((v))) 
            match widthRequest with None -> () | Some v -> yield ("WidthRequest", box ((v))) 
            match classId with None -> () | Some v -> yield ("ClassId", box ((v))) 
            match styleId with None -> () | Some v -> yield ("StyleId", box ((v))) 
          |]

        let create () =
            box (new Xamarin.Forms.Editor())

        let apply (prevOpt: XamlElement option) (source: XamlElement) (target:obj) = 
            let target = (target :?> Xamarin.Forms.Editor)
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryText
            match prevValueOpt, source.TryText with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Text <- value
            | Some _, None -> target.Text <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryFontSize
            match prevValueOpt, source.TryFontSize with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.FontSize <- value
            | Some _, None -> target.FontSize <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryFontFamily
            match prevValueOpt, source.TryFontFamily with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.FontFamily <- value
            | Some _, None -> target.FontFamily <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryFontAttributes
            match prevValueOpt, source.TryFontAttributes with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.FontAttributes <- value
            | Some _, None -> target.FontAttributes <- Xamarin.Forms.FontAttributes.None // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryTextColor
            match prevValueOpt, source.TryTextColor with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.TextColor <- value
            | Some _, None -> target.TextColor <- Xamarin.Forms.Color.Default // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryEditorCompleted
            match prevValueOpt, source.TryEditorCompleted with
            | Some prevValue, Some value when System.Object.ReferenceEquals(prevValue, value) -> ()
            | Some prevValue, Some value -> target.Completed.RemoveHandler(prevValue); target.Completed.AddHandler(value)
            | None, Some value -> target.Completed.AddHandler(value)
            | Some prevValue, None -> target.Completed.RemoveHandler(prevValue)
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryTextChanged
            match prevValueOpt, source.TryTextChanged with
            | Some prevValue, Some value when System.Object.ReferenceEquals(prevValue, value) -> ()
            | Some prevValue, Some value -> target.TextChanged.RemoveHandler(prevValue); target.TextChanged.AddHandler(value)
            | None, Some value -> target.TextChanged.AddHandler(value)
            | Some prevValue, None -> target.TextChanged.RemoveHandler(prevValue)
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryKeyboard
            match prevValueOpt, source.TryKeyboard with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Keyboard <- value
            | Some _, None -> target.Keyboard <- Xamarin.Forms.Keyboard.Default // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryHorizontalOptions
            match prevValueOpt, source.TryHorizontalOptions with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.HorizontalOptions <- value
            | Some _, None -> target.HorizontalOptions <- Unchecked.defaultof<Xamarin.Forms.LayoutOptions> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryVerticalOptions
            match prevValueOpt, source.TryVerticalOptions with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.VerticalOptions <- value
            | Some _, None -> target.VerticalOptions <- Unchecked.defaultof<Xamarin.Forms.LayoutOptions> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMargin
            match prevValueOpt, source.TryMargin with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Margin <- value
            | Some _, None -> target.Margin <- Unchecked.defaultof<Xamarin.Forms.Thickness> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevCollOpt = match prevOpt with None -> None | Some prev -> prev.TryGestureRecognizers
            match prevCollOpt, source.TryGestureRecognizers with
            // For structured objects, amortize on reference equality
            | Some prevColl, Some newColl when System.Object.ReferenceEquals(prevColl, newColl) -> ()
            | _, Some coll when coll <> null && coll.Length > 0 ->
                applyToIList
                    prevCollOpt
                    coll
                    target.GestureRecognizers
                    (fun (x:XamlElement) -> x.CreateAsIGestureRecognizer())
                    (fun _ _ _ -> ())
                    (fun (prevChild:XamlElement) (newChild:XamlElement) -> prevChild.TargetType = newChild.TargetType)
                    (fun prevChild newChild targetChild -> newChild.ApplyIncremental(prevChild, targetChild))
            | _ -> target.GestureRecognizers.Clear()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryAnchorX
            match prevValueOpt, source.TryAnchorX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.AnchorX <- value
            | Some _, None -> target.AnchorX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryAnchorY
            match prevValueOpt, source.TryAnchorY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.AnchorY <- value
            | Some _, None -> target.AnchorY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryBackgroundColor
            match prevValueOpt, source.TryBackgroundColor with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.BackgroundColor <- value
            | Some _, None -> target.BackgroundColor <- Xamarin.Forms.Color.Default // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryHeightRequest
            match prevValueOpt, source.TryHeightRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.HeightRequest <- value
            | Some _, None -> target.HeightRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryInputTransparent
            match prevValueOpt, source.TryInputTransparent with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.InputTransparent <- value
            | Some _, None -> target.InputTransparent <- false // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsEnabled
            match prevValueOpt, source.TryIsEnabled with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsEnabled <- value
            | Some _, None -> target.IsEnabled <- true // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsVisible
            match prevValueOpt, source.TryIsVisible with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsVisible <- value
            | Some _, None -> target.IsVisible <- true // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMinimumHeightRequest
            match prevValueOpt, source.TryMinimumHeightRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.MinimumHeightRequest <- value
            | Some _, None -> target.MinimumHeightRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMinimumWidthRequest
            match prevValueOpt, source.TryMinimumWidthRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.MinimumWidthRequest <- value
            | Some _, None -> target.MinimumWidthRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryOpacity
            match prevValueOpt, source.TryOpacity with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Opacity <- value
            | Some _, None -> target.Opacity <- 1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotation
            match prevValueOpt, source.TryRotation with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Rotation <- value
            | Some _, None -> target.Rotation <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotationX
            match prevValueOpt, source.TryRotationX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.RotationX <- value
            | Some _, None -> target.RotationX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotationY
            match prevValueOpt, source.TryRotationY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.RotationY <- value
            | Some _, None -> target.RotationY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryScale
            match prevValueOpt, source.TryScale with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Scale <- value
            | Some _, None -> target.Scale <- 1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryStyle
            match prevValueOpt, source.TryStyle with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Style <- value
            | Some _, None -> target.Style <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryTranslationX
            match prevValueOpt, source.TryTranslationX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.TranslationX <- value
            | Some _, None -> target.TranslationX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryTranslationY
            match prevValueOpt, source.TryTranslationY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.TranslationY <- value
            | Some _, None -> target.TranslationY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryWidthRequest
            match prevValueOpt, source.TryWidthRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.WidthRequest <- value
            | Some _, None -> target.WidthRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryClassId
            match prevValueOpt, source.TryClassId with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.ClassId <- value
            | Some _, None -> target.ClassId <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryStyleId
            match prevValueOpt, source.TryStyleId with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.StyleId <- value
            | Some _, None -> target.StyleId <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
        new XamlElement(typeof<Xamarin.Forms.Editor>, create, apply, Map.ofArray attribs)

    /// Describes a Entry in the view
    static member Entry(?text: string, ?placeholder: string, ?horizontalTextAlignment: Xamarin.Forms.TextAlignment, ?fontSize: obj, ?fontFamily: string, ?fontAttributes: Xamarin.Forms.FontAttributes, ?textColor: Xamarin.Forms.Color, ?placeholderColor: Xamarin.Forms.Color, ?isPassword: bool, ?completed: string -> unit, ?textChanged: Xamarin.Forms.TextChangedEventArgs -> unit, ?keyboard: Xamarin.Forms.Keyboard, ?horizontalOptions: Xamarin.Forms.LayoutOptions, ?verticalOptions: Xamarin.Forms.LayoutOptions, ?margin: obj, ?gestureRecognizers: XamlElement list, ?anchorX: double, ?anchorY: double, ?backgroundColor: Xamarin.Forms.Color, ?heightRequest: double, ?inputTransparent: bool, ?isEnabled: bool, ?isVisible: bool, ?minimumHeightRequest: double, ?minimumWidthRequest: double, ?opacity: double, ?rotation: double, ?rotationX: double, ?rotationY: double, ?scale: double, ?style: Xamarin.Forms.Style, ?translationX: double, ?translationY: double, ?widthRequest: double, ?classId: string, ?styleId: string) = 
        let attribs = [| 
            match text with None -> () | Some v -> yield ("Text", box ((v))) 
            match placeholder with None -> () | Some v -> yield ("Placeholder", box ((v))) 
            match horizontalTextAlignment with None -> () | Some v -> yield ("HorizontalTextAlignment", box ((v))) 
            match fontSize with None -> () | Some v -> yield ("FontSize", box (makeFontSize(v))) 
            match fontFamily with None -> () | Some v -> yield ("FontFamily", box ((v))) 
            match fontAttributes with None -> () | Some v -> yield ("FontAttributes", box ((v))) 
            match textColor with None -> () | Some v -> yield ("TextColor", box ((v))) 
            match placeholderColor with None -> () | Some v -> yield ("PlaceholderColor", box ((v))) 
            match isPassword with None -> () | Some v -> yield ("IsPassword", box ((v))) 
            match completed with None -> () | Some v -> yield ("EntryCompleted", box ((fun f -> System.EventHandler(fun sender args -> f (sender :?> Xamarin.Forms.Entry).Text))(v))) 
            match textChanged with None -> () | Some v -> yield ("TextChanged", box ((fun f -> System.EventHandler<Xamarin.Forms.TextChangedEventArgs>(fun _sender args -> f args))(v))) 
            match keyboard with None -> () | Some v -> yield ("Keyboard", box ((v))) 
            match horizontalOptions with None -> () | Some v -> yield ("HorizontalOptions", box ((v))) 
            match verticalOptions with None -> () | Some v -> yield ("VerticalOptions", box ((v))) 
            match margin with None -> () | Some v -> yield ("Margin", box (makeThickness(v))) 
            match gestureRecognizers with None -> () | Some v -> yield ("GestureRecognizers", box (Array.ofList(v))) 
            match anchorX with None -> () | Some v -> yield ("AnchorX", box ((v))) 
            match anchorY with None -> () | Some v -> yield ("AnchorY", box ((v))) 
            match backgroundColor with None -> () | Some v -> yield ("BackgroundColor", box ((v))) 
            match heightRequest with None -> () | Some v -> yield ("HeightRequest", box ((v))) 
            match inputTransparent with None -> () | Some v -> yield ("InputTransparent", box ((v))) 
            match isEnabled with None -> () | Some v -> yield ("IsEnabled", box ((v))) 
            match isVisible with None -> () | Some v -> yield ("IsVisible", box ((v))) 
            match minimumHeightRequest with None -> () | Some v -> yield ("MinimumHeightRequest", box ((v))) 
            match minimumWidthRequest with None -> () | Some v -> yield ("MinimumWidthRequest", box ((v))) 
            match opacity with None -> () | Some v -> yield ("Opacity", box ((v))) 
            match rotation with None -> () | Some v -> yield ("Rotation", box ((v))) 
            match rotationX with None -> () | Some v -> yield ("RotationX", box ((v))) 
            match rotationY with None -> () | Some v -> yield ("RotationY", box ((v))) 
            match scale with None -> () | Some v -> yield ("Scale", box ((v))) 
            match style with None -> () | Some v -> yield ("Style", box ((v))) 
            match translationX with None -> () | Some v -> yield ("TranslationX", box ((v))) 
            match translationY with None -> () | Some v -> yield ("TranslationY", box ((v))) 
            match widthRequest with None -> () | Some v -> yield ("WidthRequest", box ((v))) 
            match classId with None -> () | Some v -> yield ("ClassId", box ((v))) 
            match styleId with None -> () | Some v -> yield ("StyleId", box ((v))) 
          |]

        let create () =
            box (new Xamarin.Forms.Entry())

        let apply (prevOpt: XamlElement option) (source: XamlElement) (target:obj) = 
            let target = (target :?> Xamarin.Forms.Entry)
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryText
            match prevValueOpt, source.TryText with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Text <- value
            | Some _, None -> target.Text <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryPlaceholder
            match prevValueOpt, source.TryPlaceholder with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Placeholder <- value
            | Some _, None -> target.Placeholder <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryHorizontalTextAlignment
            match prevValueOpt, source.TryHorizontalTextAlignment with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.HorizontalTextAlignment <- value
            | Some _, None -> target.HorizontalTextAlignment <- Xamarin.Forms.TextAlignment.Start // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryFontSize
            match prevValueOpt, source.TryFontSize with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.FontSize <- value
            | Some _, None -> target.FontSize <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryFontFamily
            match prevValueOpt, source.TryFontFamily with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.FontFamily <- value
            | Some _, None -> target.FontFamily <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryFontAttributes
            match prevValueOpt, source.TryFontAttributes with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.FontAttributes <- value
            | Some _, None -> target.FontAttributes <- Xamarin.Forms.FontAttributes.None // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryTextColor
            match prevValueOpt, source.TryTextColor with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.TextColor <- value
            | Some _, None -> target.TextColor <- Xamarin.Forms.Color.Default // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryPlaceholderColor
            match prevValueOpt, source.TryPlaceholderColor with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.PlaceholderColor <- value
            | Some _, None -> target.PlaceholderColor <- Xamarin.Forms.Color.Default // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsPassword
            match prevValueOpt, source.TryIsPassword with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsPassword <- value
            | Some _, None -> target.IsPassword <- false // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryEntryCompleted
            match prevValueOpt, source.TryEntryCompleted with
            | Some prevValue, Some value when System.Object.ReferenceEquals(prevValue, value) -> ()
            | Some prevValue, Some value -> target.Completed.RemoveHandler(prevValue); target.Completed.AddHandler(value)
            | None, Some value -> target.Completed.AddHandler(value)
            | Some prevValue, None -> target.Completed.RemoveHandler(prevValue)
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryTextChanged
            match prevValueOpt, source.TryTextChanged with
            | Some prevValue, Some value when System.Object.ReferenceEquals(prevValue, value) -> ()
            | Some prevValue, Some value -> target.TextChanged.RemoveHandler(prevValue); target.TextChanged.AddHandler(value)
            | None, Some value -> target.TextChanged.AddHandler(value)
            | Some prevValue, None -> target.TextChanged.RemoveHandler(prevValue)
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryKeyboard
            match prevValueOpt, source.TryKeyboard with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Keyboard <- value
            | Some _, None -> target.Keyboard <- Xamarin.Forms.Keyboard.Default // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryHorizontalOptions
            match prevValueOpt, source.TryHorizontalOptions with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.HorizontalOptions <- value
            | Some _, None -> target.HorizontalOptions <- Unchecked.defaultof<Xamarin.Forms.LayoutOptions> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryVerticalOptions
            match prevValueOpt, source.TryVerticalOptions with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.VerticalOptions <- value
            | Some _, None -> target.VerticalOptions <- Unchecked.defaultof<Xamarin.Forms.LayoutOptions> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMargin
            match prevValueOpt, source.TryMargin with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Margin <- value
            | Some _, None -> target.Margin <- Unchecked.defaultof<Xamarin.Forms.Thickness> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevCollOpt = match prevOpt with None -> None | Some prev -> prev.TryGestureRecognizers
            match prevCollOpt, source.TryGestureRecognizers with
            // For structured objects, amortize on reference equality
            | Some prevColl, Some newColl when System.Object.ReferenceEquals(prevColl, newColl) -> ()
            | _, Some coll when coll <> null && coll.Length > 0 ->
                applyToIList
                    prevCollOpt
                    coll
                    target.GestureRecognizers
                    (fun (x:XamlElement) -> x.CreateAsIGestureRecognizer())
                    (fun _ _ _ -> ())
                    (fun (prevChild:XamlElement) (newChild:XamlElement) -> prevChild.TargetType = newChild.TargetType)
                    (fun prevChild newChild targetChild -> newChild.ApplyIncremental(prevChild, targetChild))
            | _ -> target.GestureRecognizers.Clear()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryAnchorX
            match prevValueOpt, source.TryAnchorX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.AnchorX <- value
            | Some _, None -> target.AnchorX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryAnchorY
            match prevValueOpt, source.TryAnchorY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.AnchorY <- value
            | Some _, None -> target.AnchorY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryBackgroundColor
            match prevValueOpt, source.TryBackgroundColor with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.BackgroundColor <- value
            | Some _, None -> target.BackgroundColor <- Xamarin.Forms.Color.Default // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryHeightRequest
            match prevValueOpt, source.TryHeightRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.HeightRequest <- value
            | Some _, None -> target.HeightRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryInputTransparent
            match prevValueOpt, source.TryInputTransparent with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.InputTransparent <- value
            | Some _, None -> target.InputTransparent <- false // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsEnabled
            match prevValueOpt, source.TryIsEnabled with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsEnabled <- value
            | Some _, None -> target.IsEnabled <- true // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsVisible
            match prevValueOpt, source.TryIsVisible with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsVisible <- value
            | Some _, None -> target.IsVisible <- true // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMinimumHeightRequest
            match prevValueOpt, source.TryMinimumHeightRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.MinimumHeightRequest <- value
            | Some _, None -> target.MinimumHeightRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMinimumWidthRequest
            match prevValueOpt, source.TryMinimumWidthRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.MinimumWidthRequest <- value
            | Some _, None -> target.MinimumWidthRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryOpacity
            match prevValueOpt, source.TryOpacity with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Opacity <- value
            | Some _, None -> target.Opacity <- 1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotation
            match prevValueOpt, source.TryRotation with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Rotation <- value
            | Some _, None -> target.Rotation <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotationX
            match prevValueOpt, source.TryRotationX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.RotationX <- value
            | Some _, None -> target.RotationX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotationY
            match prevValueOpt, source.TryRotationY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.RotationY <- value
            | Some _, None -> target.RotationY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryScale
            match prevValueOpt, source.TryScale with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Scale <- value
            | Some _, None -> target.Scale <- 1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryStyle
            match prevValueOpt, source.TryStyle with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Style <- value
            | Some _, None -> target.Style <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryTranslationX
            match prevValueOpt, source.TryTranslationX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.TranslationX <- value
            | Some _, None -> target.TranslationX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryTranslationY
            match prevValueOpt, source.TryTranslationY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.TranslationY <- value
            | Some _, None -> target.TranslationY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryWidthRequest
            match prevValueOpt, source.TryWidthRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.WidthRequest <- value
            | Some _, None -> target.WidthRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryClassId
            match prevValueOpt, source.TryClassId with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.ClassId <- value
            | Some _, None -> target.ClassId <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryStyleId
            match prevValueOpt, source.TryStyleId with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.StyleId <- value
            | Some _, None -> target.StyleId <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
        new XamlElement(typeof<Xamarin.Forms.Entry>, create, apply, Map.ofArray attribs)

    /// Describes a Label in the view
    static member Label(?text: string, ?horizontalTextAlignment: Xamarin.Forms.TextAlignment, ?verticalTextAlignment: Xamarin.Forms.TextAlignment, ?fontSize: obj, ?fontFamily: string, ?fontAttributes: Xamarin.Forms.FontAttributes, ?textColor: Xamarin.Forms.Color, ?horizontalOptions: Xamarin.Forms.LayoutOptions, ?verticalOptions: Xamarin.Forms.LayoutOptions, ?margin: obj, ?gestureRecognizers: XamlElement list, ?anchorX: double, ?anchorY: double, ?backgroundColor: Xamarin.Forms.Color, ?heightRequest: double, ?inputTransparent: bool, ?isEnabled: bool, ?isVisible: bool, ?minimumHeightRequest: double, ?minimumWidthRequest: double, ?opacity: double, ?rotation: double, ?rotationX: double, ?rotationY: double, ?scale: double, ?style: Xamarin.Forms.Style, ?translationX: double, ?translationY: double, ?widthRequest: double, ?classId: string, ?styleId: string) = 
        let attribs = [| 
            match text with None -> () | Some v -> yield ("Text", box ((v))) 
            match horizontalTextAlignment with None -> () | Some v -> yield ("HorizontalTextAlignment", box ((v))) 
            match verticalTextAlignment with None -> () | Some v -> yield ("VerticalTextAlignment", box ((v))) 
            match fontSize with None -> () | Some v -> yield ("FontSize", box (makeFontSize(v))) 
            match fontFamily with None -> () | Some v -> yield ("FontFamily", box ((v))) 
            match fontAttributes with None -> () | Some v -> yield ("FontAttributes", box ((v))) 
            match textColor with None -> () | Some v -> yield ("TextColor", box ((v))) 
            match horizontalOptions with None -> () | Some v -> yield ("HorizontalOptions", box ((v))) 
            match verticalOptions with None -> () | Some v -> yield ("VerticalOptions", box ((v))) 
            match margin with None -> () | Some v -> yield ("Margin", box (makeThickness(v))) 
            match gestureRecognizers with None -> () | Some v -> yield ("GestureRecognizers", box (Array.ofList(v))) 
            match anchorX with None -> () | Some v -> yield ("AnchorX", box ((v))) 
            match anchorY with None -> () | Some v -> yield ("AnchorY", box ((v))) 
            match backgroundColor with None -> () | Some v -> yield ("BackgroundColor", box ((v))) 
            match heightRequest with None -> () | Some v -> yield ("HeightRequest", box ((v))) 
            match inputTransparent with None -> () | Some v -> yield ("InputTransparent", box ((v))) 
            match isEnabled with None -> () | Some v -> yield ("IsEnabled", box ((v))) 
            match isVisible with None -> () | Some v -> yield ("IsVisible", box ((v))) 
            match minimumHeightRequest with None -> () | Some v -> yield ("MinimumHeightRequest", box ((v))) 
            match minimumWidthRequest with None -> () | Some v -> yield ("MinimumWidthRequest", box ((v))) 
            match opacity with None -> () | Some v -> yield ("Opacity", box ((v))) 
            match rotation with None -> () | Some v -> yield ("Rotation", box ((v))) 
            match rotationX with None -> () | Some v -> yield ("RotationX", box ((v))) 
            match rotationY with None -> () | Some v -> yield ("RotationY", box ((v))) 
            match scale with None -> () | Some v -> yield ("Scale", box ((v))) 
            match style with None -> () | Some v -> yield ("Style", box ((v))) 
            match translationX with None -> () | Some v -> yield ("TranslationX", box ((v))) 
            match translationY with None -> () | Some v -> yield ("TranslationY", box ((v))) 
            match widthRequest with None -> () | Some v -> yield ("WidthRequest", box ((v))) 
            match classId with None -> () | Some v -> yield ("ClassId", box ((v))) 
            match styleId with None -> () | Some v -> yield ("StyleId", box ((v))) 
          |]

        let create () =
            box (new Xamarin.Forms.Label())

        let apply (prevOpt: XamlElement option) (source: XamlElement) (target:obj) = 
            let target = (target :?> Xamarin.Forms.Label)
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryText
            match prevValueOpt, source.TryText with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Text <- value
            | Some _, None -> target.Text <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryHorizontalTextAlignment
            match prevValueOpt, source.TryHorizontalTextAlignment with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.HorizontalTextAlignment <- value
            | Some _, None -> target.HorizontalTextAlignment <- Xamarin.Forms.TextAlignment.Start // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryVerticalTextAlignment
            match prevValueOpt, source.TryVerticalTextAlignment with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.VerticalTextAlignment <- value
            | Some _, None -> target.VerticalTextAlignment <- Xamarin.Forms.TextAlignment.Start // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryFontSize
            match prevValueOpt, source.TryFontSize with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.FontSize <- value
            | Some _, None -> target.FontSize <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryFontFamily
            match prevValueOpt, source.TryFontFamily with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.FontFamily <- value
            | Some _, None -> target.FontFamily <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryFontAttributes
            match prevValueOpt, source.TryFontAttributes with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.FontAttributes <- value
            | Some _, None -> target.FontAttributes <- Xamarin.Forms.FontAttributes.None // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryTextColor
            match prevValueOpt, source.TryTextColor with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.TextColor <- value
            | Some _, None -> target.TextColor <- Xamarin.Forms.Color.Default // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryHorizontalOptions
            match prevValueOpt, source.TryHorizontalOptions with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.HorizontalOptions <- value
            | Some _, None -> target.HorizontalOptions <- Unchecked.defaultof<Xamarin.Forms.LayoutOptions> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryVerticalOptions
            match prevValueOpt, source.TryVerticalOptions with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.VerticalOptions <- value
            | Some _, None -> target.VerticalOptions <- Unchecked.defaultof<Xamarin.Forms.LayoutOptions> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMargin
            match prevValueOpt, source.TryMargin with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Margin <- value
            | Some _, None -> target.Margin <- Unchecked.defaultof<Xamarin.Forms.Thickness> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevCollOpt = match prevOpt with None -> None | Some prev -> prev.TryGestureRecognizers
            match prevCollOpt, source.TryGestureRecognizers with
            // For structured objects, amortize on reference equality
            | Some prevColl, Some newColl when System.Object.ReferenceEquals(prevColl, newColl) -> ()
            | _, Some coll when coll <> null && coll.Length > 0 ->
                applyToIList
                    prevCollOpt
                    coll
                    target.GestureRecognizers
                    (fun (x:XamlElement) -> x.CreateAsIGestureRecognizer())
                    (fun _ _ _ -> ())
                    (fun (prevChild:XamlElement) (newChild:XamlElement) -> prevChild.TargetType = newChild.TargetType)
                    (fun prevChild newChild targetChild -> newChild.ApplyIncremental(prevChild, targetChild))
            | _ -> target.GestureRecognizers.Clear()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryAnchorX
            match prevValueOpt, source.TryAnchorX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.AnchorX <- value
            | Some _, None -> target.AnchorX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryAnchorY
            match prevValueOpt, source.TryAnchorY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.AnchorY <- value
            | Some _, None -> target.AnchorY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryBackgroundColor
            match prevValueOpt, source.TryBackgroundColor with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.BackgroundColor <- value
            | Some _, None -> target.BackgroundColor <- Xamarin.Forms.Color.Default // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryHeightRequest
            match prevValueOpt, source.TryHeightRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.HeightRequest <- value
            | Some _, None -> target.HeightRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryInputTransparent
            match prevValueOpt, source.TryInputTransparent with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.InputTransparent <- value
            | Some _, None -> target.InputTransparent <- false // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsEnabled
            match prevValueOpt, source.TryIsEnabled with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsEnabled <- value
            | Some _, None -> target.IsEnabled <- true // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsVisible
            match prevValueOpt, source.TryIsVisible with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsVisible <- value
            | Some _, None -> target.IsVisible <- true // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMinimumHeightRequest
            match prevValueOpt, source.TryMinimumHeightRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.MinimumHeightRequest <- value
            | Some _, None -> target.MinimumHeightRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMinimumWidthRequest
            match prevValueOpt, source.TryMinimumWidthRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.MinimumWidthRequest <- value
            | Some _, None -> target.MinimumWidthRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryOpacity
            match prevValueOpt, source.TryOpacity with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Opacity <- value
            | Some _, None -> target.Opacity <- 1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotation
            match prevValueOpt, source.TryRotation with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Rotation <- value
            | Some _, None -> target.Rotation <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotationX
            match prevValueOpt, source.TryRotationX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.RotationX <- value
            | Some _, None -> target.RotationX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotationY
            match prevValueOpt, source.TryRotationY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.RotationY <- value
            | Some _, None -> target.RotationY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryScale
            match prevValueOpt, source.TryScale with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Scale <- value
            | Some _, None -> target.Scale <- 1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryStyle
            match prevValueOpt, source.TryStyle with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Style <- value
            | Some _, None -> target.Style <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryTranslationX
            match prevValueOpt, source.TryTranslationX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.TranslationX <- value
            | Some _, None -> target.TranslationX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryTranslationY
            match prevValueOpt, source.TryTranslationY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.TranslationY <- value
            | Some _, None -> target.TranslationY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryWidthRequest
            match prevValueOpt, source.TryWidthRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.WidthRequest <- value
            | Some _, None -> target.WidthRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryClassId
            match prevValueOpt, source.TryClassId with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.ClassId <- value
            | Some _, None -> target.ClassId <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryStyleId
            match prevValueOpt, source.TryStyleId with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.StyleId <- value
            | Some _, None -> target.StyleId <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
        new XamlElement(typeof<Xamarin.Forms.Label>, create, apply, Map.ofArray attribs)

    /// Describes a Layout in the view
    static member Layout(?isClippedToBounds: bool, ?padding: double, ?horizontalOptions: Xamarin.Forms.LayoutOptions, ?verticalOptions: Xamarin.Forms.LayoutOptions, ?margin: obj, ?gestureRecognizers: XamlElement list, ?anchorX: double, ?anchorY: double, ?backgroundColor: Xamarin.Forms.Color, ?heightRequest: double, ?inputTransparent: bool, ?isEnabled: bool, ?isVisible: bool, ?minimumHeightRequest: double, ?minimumWidthRequest: double, ?opacity: double, ?rotation: double, ?rotationX: double, ?rotationY: double, ?scale: double, ?style: Xamarin.Forms.Style, ?translationX: double, ?translationY: double, ?widthRequest: double, ?classId: string, ?styleId: string) = 
        let attribs = [| 
            match isClippedToBounds with None -> () | Some v -> yield ("IsClippedToBounds", box ((v))) 
            match padding with None -> () | Some v -> yield ("Padding", box (makeThickness(v))) 
            match horizontalOptions with None -> () | Some v -> yield ("HorizontalOptions", box ((v))) 
            match verticalOptions with None -> () | Some v -> yield ("VerticalOptions", box ((v))) 
            match margin with None -> () | Some v -> yield ("Margin", box (makeThickness(v))) 
            match gestureRecognizers with None -> () | Some v -> yield ("GestureRecognizers", box (Array.ofList(v))) 
            match anchorX with None -> () | Some v -> yield ("AnchorX", box ((v))) 
            match anchorY with None -> () | Some v -> yield ("AnchorY", box ((v))) 
            match backgroundColor with None -> () | Some v -> yield ("BackgroundColor", box ((v))) 
            match heightRequest with None -> () | Some v -> yield ("HeightRequest", box ((v))) 
            match inputTransparent with None -> () | Some v -> yield ("InputTransparent", box ((v))) 
            match isEnabled with None -> () | Some v -> yield ("IsEnabled", box ((v))) 
            match isVisible with None -> () | Some v -> yield ("IsVisible", box ((v))) 
            match minimumHeightRequest with None -> () | Some v -> yield ("MinimumHeightRequest", box ((v))) 
            match minimumWidthRequest with None -> () | Some v -> yield ("MinimumWidthRequest", box ((v))) 
            match opacity with None -> () | Some v -> yield ("Opacity", box ((v))) 
            match rotation with None -> () | Some v -> yield ("Rotation", box ((v))) 
            match rotationX with None -> () | Some v -> yield ("RotationX", box ((v))) 
            match rotationY with None -> () | Some v -> yield ("RotationY", box ((v))) 
            match scale with None -> () | Some v -> yield ("Scale", box ((v))) 
            match style with None -> () | Some v -> yield ("Style", box ((v))) 
            match translationX with None -> () | Some v -> yield ("TranslationX", box ((v))) 
            match translationY with None -> () | Some v -> yield ("TranslationY", box ((v))) 
            match widthRequest with None -> () | Some v -> yield ("WidthRequest", box ((v))) 
            match classId with None -> () | Some v -> yield ("ClassId", box ((v))) 
            match styleId with None -> () | Some v -> yield ("StyleId", box ((v))) 
          |]

        let create () =
            failwith "can'tdef create Xamarin.Forms.Layout"

        let apply (prevOpt: XamlElement option) (source: XamlElement) (target:obj) = 
            let target = (target :?> Xamarin.Forms.Layout)
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsClippedToBounds
            match prevValueOpt, source.TryIsClippedToBounds with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsClippedToBounds <- value
            | Some _, None -> target.IsClippedToBounds <- false // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryPadding
            match prevValueOpt, source.TryPadding with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Padding <- value
            | Some _, None -> target.Padding <- Unchecked.defaultof<Xamarin.Forms.Thickness> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryHorizontalOptions
            match prevValueOpt, source.TryHorizontalOptions with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.HorizontalOptions <- value
            | Some _, None -> target.HorizontalOptions <- Unchecked.defaultof<Xamarin.Forms.LayoutOptions> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryVerticalOptions
            match prevValueOpt, source.TryVerticalOptions with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.VerticalOptions <- value
            | Some _, None -> target.VerticalOptions <- Unchecked.defaultof<Xamarin.Forms.LayoutOptions> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMargin
            match prevValueOpt, source.TryMargin with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Margin <- value
            | Some _, None -> target.Margin <- Unchecked.defaultof<Xamarin.Forms.Thickness> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevCollOpt = match prevOpt with None -> None | Some prev -> prev.TryGestureRecognizers
            match prevCollOpt, source.TryGestureRecognizers with
            // For structured objects, amortize on reference equality
            | Some prevColl, Some newColl when System.Object.ReferenceEquals(prevColl, newColl) -> ()
            | _, Some coll when coll <> null && coll.Length > 0 ->
                applyToIList
                    prevCollOpt
                    coll
                    target.GestureRecognizers
                    (fun (x:XamlElement) -> x.CreateAsIGestureRecognizer())
                    (fun _ _ _ -> ())
                    (fun (prevChild:XamlElement) (newChild:XamlElement) -> prevChild.TargetType = newChild.TargetType)
                    (fun prevChild newChild targetChild -> newChild.ApplyIncremental(prevChild, targetChild))
            | _ -> target.GestureRecognizers.Clear()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryAnchorX
            match prevValueOpt, source.TryAnchorX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.AnchorX <- value
            | Some _, None -> target.AnchorX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryAnchorY
            match prevValueOpt, source.TryAnchorY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.AnchorY <- value
            | Some _, None -> target.AnchorY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryBackgroundColor
            match prevValueOpt, source.TryBackgroundColor with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.BackgroundColor <- value
            | Some _, None -> target.BackgroundColor <- Xamarin.Forms.Color.Default // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryHeightRequest
            match prevValueOpt, source.TryHeightRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.HeightRequest <- value
            | Some _, None -> target.HeightRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryInputTransparent
            match prevValueOpt, source.TryInputTransparent with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.InputTransparent <- value
            | Some _, None -> target.InputTransparent <- false // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsEnabled
            match prevValueOpt, source.TryIsEnabled with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsEnabled <- value
            | Some _, None -> target.IsEnabled <- true // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsVisible
            match prevValueOpt, source.TryIsVisible with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsVisible <- value
            | Some _, None -> target.IsVisible <- true // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMinimumHeightRequest
            match prevValueOpt, source.TryMinimumHeightRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.MinimumHeightRequest <- value
            | Some _, None -> target.MinimumHeightRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMinimumWidthRequest
            match prevValueOpt, source.TryMinimumWidthRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.MinimumWidthRequest <- value
            | Some _, None -> target.MinimumWidthRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryOpacity
            match prevValueOpt, source.TryOpacity with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Opacity <- value
            | Some _, None -> target.Opacity <- 1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotation
            match prevValueOpt, source.TryRotation with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Rotation <- value
            | Some _, None -> target.Rotation <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotationX
            match prevValueOpt, source.TryRotationX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.RotationX <- value
            | Some _, None -> target.RotationX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotationY
            match prevValueOpt, source.TryRotationY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.RotationY <- value
            | Some _, None -> target.RotationY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryScale
            match prevValueOpt, source.TryScale with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Scale <- value
            | Some _, None -> target.Scale <- 1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryStyle
            match prevValueOpt, source.TryStyle with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Style <- value
            | Some _, None -> target.Style <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryTranslationX
            match prevValueOpt, source.TryTranslationX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.TranslationX <- value
            | Some _, None -> target.TranslationX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryTranslationY
            match prevValueOpt, source.TryTranslationY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.TranslationY <- value
            | Some _, None -> target.TranslationY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryWidthRequest
            match prevValueOpt, source.TryWidthRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.WidthRequest <- value
            | Some _, None -> target.WidthRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryClassId
            match prevValueOpt, source.TryClassId with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.ClassId <- value
            | Some _, None -> target.ClassId <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryStyleId
            match prevValueOpt, source.TryStyleId with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.StyleId <- value
            | Some _, None -> target.StyleId <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
        new XamlElement(typeof<Xamarin.Forms.Layout>, create, apply, Map.ofArray attribs)

    /// Describes a StackLayout in the view
    static member StackLayout(?children: XamlElement list, ?orientation: Xamarin.Forms.StackOrientation, ?spacing: double, ?isClippedToBounds: bool, ?padding: double, ?horizontalOptions: Xamarin.Forms.LayoutOptions, ?verticalOptions: Xamarin.Forms.LayoutOptions, ?margin: obj, ?gestureRecognizers: XamlElement list, ?anchorX: double, ?anchorY: double, ?backgroundColor: Xamarin.Forms.Color, ?heightRequest: double, ?inputTransparent: bool, ?isEnabled: bool, ?isVisible: bool, ?minimumHeightRequest: double, ?minimumWidthRequest: double, ?opacity: double, ?rotation: double, ?rotationX: double, ?rotationY: double, ?scale: double, ?style: Xamarin.Forms.Style, ?translationX: double, ?translationY: double, ?widthRequest: double, ?classId: string, ?styleId: string) = 
        let attribs = [| 
            match children with None -> () | Some v -> yield ("Children", box (Array.ofList(v))) 
            match orientation with None -> () | Some v -> yield ("StackOrientation", box ((v))) 
            match spacing with None -> () | Some v -> yield ("Spacing", box ((v))) 
            match isClippedToBounds with None -> () | Some v -> yield ("IsClippedToBounds", box ((v))) 
            match padding with None -> () | Some v -> yield ("Padding", box (makeThickness(v))) 
            match horizontalOptions with None -> () | Some v -> yield ("HorizontalOptions", box ((v))) 
            match verticalOptions with None -> () | Some v -> yield ("VerticalOptions", box ((v))) 
            match margin with None -> () | Some v -> yield ("Margin", box (makeThickness(v))) 
            match gestureRecognizers with None -> () | Some v -> yield ("GestureRecognizers", box (Array.ofList(v))) 
            match anchorX with None -> () | Some v -> yield ("AnchorX", box ((v))) 
            match anchorY with None -> () | Some v -> yield ("AnchorY", box ((v))) 
            match backgroundColor with None -> () | Some v -> yield ("BackgroundColor", box ((v))) 
            match heightRequest with None -> () | Some v -> yield ("HeightRequest", box ((v))) 
            match inputTransparent with None -> () | Some v -> yield ("InputTransparent", box ((v))) 
            match isEnabled with None -> () | Some v -> yield ("IsEnabled", box ((v))) 
            match isVisible with None -> () | Some v -> yield ("IsVisible", box ((v))) 
            match minimumHeightRequest with None -> () | Some v -> yield ("MinimumHeightRequest", box ((v))) 
            match minimumWidthRequest with None -> () | Some v -> yield ("MinimumWidthRequest", box ((v))) 
            match opacity with None -> () | Some v -> yield ("Opacity", box ((v))) 
            match rotation with None -> () | Some v -> yield ("Rotation", box ((v))) 
            match rotationX with None -> () | Some v -> yield ("RotationX", box ((v))) 
            match rotationY with None -> () | Some v -> yield ("RotationY", box ((v))) 
            match scale with None -> () | Some v -> yield ("Scale", box ((v))) 
            match style with None -> () | Some v -> yield ("Style", box ((v))) 
            match translationX with None -> () | Some v -> yield ("TranslationX", box ((v))) 
            match translationY with None -> () | Some v -> yield ("TranslationY", box ((v))) 
            match widthRequest with None -> () | Some v -> yield ("WidthRequest", box ((v))) 
            match classId with None -> () | Some v -> yield ("ClassId", box ((v))) 
            match styleId with None -> () | Some v -> yield ("StyleId", box ((v))) 
          |]

        let create () =
            box (new Xamarin.Forms.StackLayout())

        let apply (prevOpt: XamlElement option) (source: XamlElement) (target:obj) = 
            let target = (target :?> Xamarin.Forms.StackLayout)
            let prevCollOpt = match prevOpt with None -> None | Some prev -> prev.TryChildren
            match prevCollOpt, source.TryChildren with
            // For structured objects, amortize on reference equality
            | Some prevColl, Some newColl when System.Object.ReferenceEquals(prevColl, newColl) -> ()
            | _, Some coll when coll <> null && coll.Length > 0 ->
                applyToIList
                    prevCollOpt
                    coll
                    target.Children
                    (fun (x:XamlElement) -> x.CreateAsView())
                    (fun _ _ _ -> ())
                    (fun (prevChild:XamlElement) (newChild:XamlElement) -> prevChild.TargetType = newChild.TargetType)
                    (fun prevChild newChild targetChild -> newChild.ApplyIncremental(prevChild, targetChild))
            | _ -> target.Children.Clear()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryStackOrientation
            match prevValueOpt, source.TryStackOrientation with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Orientation <- value
            | Some _, None -> target.Orientation <- Xamarin.Forms.StackOrientation.Vertical // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TrySpacing
            match prevValueOpt, source.TrySpacing with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Spacing <- value
            | Some _, None -> target.Spacing <- 6.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsClippedToBounds
            match prevValueOpt, source.TryIsClippedToBounds with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsClippedToBounds <- value
            | Some _, None -> target.IsClippedToBounds <- false // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryPadding
            match prevValueOpt, source.TryPadding with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Padding <- value
            | Some _, None -> target.Padding <- Unchecked.defaultof<Xamarin.Forms.Thickness> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryHorizontalOptions
            match prevValueOpt, source.TryHorizontalOptions with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.HorizontalOptions <- value
            | Some _, None -> target.HorizontalOptions <- Unchecked.defaultof<Xamarin.Forms.LayoutOptions> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryVerticalOptions
            match prevValueOpt, source.TryVerticalOptions with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.VerticalOptions <- value
            | Some _, None -> target.VerticalOptions <- Unchecked.defaultof<Xamarin.Forms.LayoutOptions> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMargin
            match prevValueOpt, source.TryMargin with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Margin <- value
            | Some _, None -> target.Margin <- Unchecked.defaultof<Xamarin.Forms.Thickness> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevCollOpt = match prevOpt with None -> None | Some prev -> prev.TryGestureRecognizers
            match prevCollOpt, source.TryGestureRecognizers with
            // For structured objects, amortize on reference equality
            | Some prevColl, Some newColl when System.Object.ReferenceEquals(prevColl, newColl) -> ()
            | _, Some coll when coll <> null && coll.Length > 0 ->
                applyToIList
                    prevCollOpt
                    coll
                    target.GestureRecognizers
                    (fun (x:XamlElement) -> x.CreateAsIGestureRecognizer())
                    (fun _ _ _ -> ())
                    (fun (prevChild:XamlElement) (newChild:XamlElement) -> prevChild.TargetType = newChild.TargetType)
                    (fun prevChild newChild targetChild -> newChild.ApplyIncremental(prevChild, targetChild))
            | _ -> target.GestureRecognizers.Clear()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryAnchorX
            match prevValueOpt, source.TryAnchorX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.AnchorX <- value
            | Some _, None -> target.AnchorX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryAnchorY
            match prevValueOpt, source.TryAnchorY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.AnchorY <- value
            | Some _, None -> target.AnchorY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryBackgroundColor
            match prevValueOpt, source.TryBackgroundColor with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.BackgroundColor <- value
            | Some _, None -> target.BackgroundColor <- Xamarin.Forms.Color.Default // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryHeightRequest
            match prevValueOpt, source.TryHeightRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.HeightRequest <- value
            | Some _, None -> target.HeightRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryInputTransparent
            match prevValueOpt, source.TryInputTransparent with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.InputTransparent <- value
            | Some _, None -> target.InputTransparent <- false // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsEnabled
            match prevValueOpt, source.TryIsEnabled with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsEnabled <- value
            | Some _, None -> target.IsEnabled <- true // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsVisible
            match prevValueOpt, source.TryIsVisible with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsVisible <- value
            | Some _, None -> target.IsVisible <- true // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMinimumHeightRequest
            match prevValueOpt, source.TryMinimumHeightRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.MinimumHeightRequest <- value
            | Some _, None -> target.MinimumHeightRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMinimumWidthRequest
            match prevValueOpt, source.TryMinimumWidthRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.MinimumWidthRequest <- value
            | Some _, None -> target.MinimumWidthRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryOpacity
            match prevValueOpt, source.TryOpacity with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Opacity <- value
            | Some _, None -> target.Opacity <- 1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotation
            match prevValueOpt, source.TryRotation with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Rotation <- value
            | Some _, None -> target.Rotation <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotationX
            match prevValueOpt, source.TryRotationX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.RotationX <- value
            | Some _, None -> target.RotationX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotationY
            match prevValueOpt, source.TryRotationY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.RotationY <- value
            | Some _, None -> target.RotationY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryScale
            match prevValueOpt, source.TryScale with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Scale <- value
            | Some _, None -> target.Scale <- 1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryStyle
            match prevValueOpt, source.TryStyle with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Style <- value
            | Some _, None -> target.Style <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryTranslationX
            match prevValueOpt, source.TryTranslationX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.TranslationX <- value
            | Some _, None -> target.TranslationX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryTranslationY
            match prevValueOpt, source.TryTranslationY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.TranslationY <- value
            | Some _, None -> target.TranslationY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryWidthRequest
            match prevValueOpt, source.TryWidthRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.WidthRequest <- value
            | Some _, None -> target.WidthRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryClassId
            match prevValueOpt, source.TryClassId with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.ClassId <- value
            | Some _, None -> target.ClassId <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryStyleId
            match prevValueOpt, source.TryStyleId with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.StyleId <- value
            | Some _, None -> target.StyleId <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
        new XamlElement(typeof<Xamarin.Forms.StackLayout>, create, apply, Map.ofArray attribs)

    /// Describes a Span in the view
    static member Span(?fontFamily: string, ?fontAttributes: Xamarin.Forms.FontAttributes, ?fontSize: obj, ?backgroundColor: Xamarin.Forms.Color, ?foregroundColor: Xamarin.Forms.Color, ?text: string, ?propertyChanged: System.ComponentModel.PropertyChangedEventArgs -> unit) = 
        let attribs = [| 
            match fontFamily with None -> () | Some v -> yield ("FontFamily", box ((v))) 
            match fontAttributes with None -> () | Some v -> yield ("FontAttributes", box ((v))) 
            match fontSize with None -> () | Some v -> yield ("FontSize", box (makeFontSize(v))) 
            match backgroundColor with None -> () | Some v -> yield ("BackgroundColor", box ((v))) 
            match foregroundColor with None -> () | Some v -> yield ("ForegroundColor", box ((v))) 
            match text with None -> () | Some v -> yield ("Text", box ((v))) 
            match propertyChanged with None -> () | Some v -> yield ("PropertyChanged", box ((fun f -> System.EventHandler<System.ComponentModel.PropertyChangedEventArgs>(fun _sender args -> f args))(v))) 
          |]

        let create () =
            box (new Xamarin.Forms.Span())

        let apply (prevOpt: XamlElement option) (source: XamlElement) (target:obj) = 
            let target = (target :?> Xamarin.Forms.Span)
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryFontFamily
            match prevValueOpt, source.TryFontFamily with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.FontFamily <- value
            | Some _, None -> target.FontFamily <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryFontAttributes
            match prevValueOpt, source.TryFontAttributes with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.FontAttributes <- value
            | Some _, None -> target.FontAttributes <- Xamarin.Forms.FontAttributes.None // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryFontSize
            match prevValueOpt, source.TryFontSize with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.FontSize <- value
            | Some _, None -> target.FontSize <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryBackgroundColor
            match prevValueOpt, source.TryBackgroundColor with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.BackgroundColor <- value
            | Some _, None -> target.BackgroundColor <- Xamarin.Forms.Color.Default // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryForegroundColor
            match prevValueOpt, source.TryForegroundColor with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.ForegroundColor <- value
            | Some _, None -> target.ForegroundColor <- Xamarin.Forms.Color.Default // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryText
            match prevValueOpt, source.TryText with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Text <- value
            | Some _, None -> target.Text <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryPropertyChanged
            match prevValueOpt, source.TryPropertyChanged with
            | Some prevValue, Some value when System.Object.ReferenceEquals(prevValue, value) -> ()
            | Some prevValue, Some value -> target.PropertyChanged.RemoveHandler(prevValue); target.PropertyChanged.AddHandler(value)
            | None, Some value -> target.PropertyChanged.AddHandler(value)
            | Some prevValue, None -> target.PropertyChanged.RemoveHandler(prevValue)
            | None, None -> ()
        new XamlElement(typeof<Xamarin.Forms.Span>, create, apply, Map.ofArray attribs)

    /// Describes a TimePicker in the view
    static member TimePicker(?time: System.TimeSpan, ?format: string, ?textColor: Xamarin.Forms.Color, ?horizontalOptions: Xamarin.Forms.LayoutOptions, ?verticalOptions: Xamarin.Forms.LayoutOptions, ?margin: obj, ?gestureRecognizers: XamlElement list, ?anchorX: double, ?anchorY: double, ?backgroundColor: Xamarin.Forms.Color, ?heightRequest: double, ?inputTransparent: bool, ?isEnabled: bool, ?isVisible: bool, ?minimumHeightRequest: double, ?minimumWidthRequest: double, ?opacity: double, ?rotation: double, ?rotationX: double, ?rotationY: double, ?scale: double, ?style: Xamarin.Forms.Style, ?translationX: double, ?translationY: double, ?widthRequest: double, ?classId: string, ?styleId: string) = 
        let attribs = [| 
            match time with None -> () | Some v -> yield ("Time", box ((v))) 
            match format with None -> () | Some v -> yield ("Format", box ((v))) 
            match textColor with None -> () | Some v -> yield ("TextColor", box ((v))) 
            match horizontalOptions with None -> () | Some v -> yield ("HorizontalOptions", box ((v))) 
            match verticalOptions with None -> () | Some v -> yield ("VerticalOptions", box ((v))) 
            match margin with None -> () | Some v -> yield ("Margin", box (makeThickness(v))) 
            match gestureRecognizers with None -> () | Some v -> yield ("GestureRecognizers", box (Array.ofList(v))) 
            match anchorX with None -> () | Some v -> yield ("AnchorX", box ((v))) 
            match anchorY with None -> () | Some v -> yield ("AnchorY", box ((v))) 
            match backgroundColor with None -> () | Some v -> yield ("BackgroundColor", box ((v))) 
            match heightRequest with None -> () | Some v -> yield ("HeightRequest", box ((v))) 
            match inputTransparent with None -> () | Some v -> yield ("InputTransparent", box ((v))) 
            match isEnabled with None -> () | Some v -> yield ("IsEnabled", box ((v))) 
            match isVisible with None -> () | Some v -> yield ("IsVisible", box ((v))) 
            match minimumHeightRequest with None -> () | Some v -> yield ("MinimumHeightRequest", box ((v))) 
            match minimumWidthRequest with None -> () | Some v -> yield ("MinimumWidthRequest", box ((v))) 
            match opacity with None -> () | Some v -> yield ("Opacity", box ((v))) 
            match rotation with None -> () | Some v -> yield ("Rotation", box ((v))) 
            match rotationX with None -> () | Some v -> yield ("RotationX", box ((v))) 
            match rotationY with None -> () | Some v -> yield ("RotationY", box ((v))) 
            match scale with None -> () | Some v -> yield ("Scale", box ((v))) 
            match style with None -> () | Some v -> yield ("Style", box ((v))) 
            match translationX with None -> () | Some v -> yield ("TranslationX", box ((v))) 
            match translationY with None -> () | Some v -> yield ("TranslationY", box ((v))) 
            match widthRequest with None -> () | Some v -> yield ("WidthRequest", box ((v))) 
            match classId with None -> () | Some v -> yield ("ClassId", box ((v))) 
            match styleId with None -> () | Some v -> yield ("StyleId", box ((v))) 
          |]

        let create () =
            box (new Xamarin.Forms.TimePicker())

        let apply (prevOpt: XamlElement option) (source: XamlElement) (target:obj) = 
            let target = (target :?> Xamarin.Forms.TimePicker)
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryTime
            match prevValueOpt, source.TryTime with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Time <- value
            | Some _, None -> target.Time <- new System.TimeSpan() // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryFormat
            match prevValueOpt, source.TryFormat with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Format <- value
            | Some _, None -> target.Format <- "t" // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryTextColor
            match prevValueOpt, source.TryTextColor with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.TextColor <- value
            | Some _, None -> target.TextColor <- Xamarin.Forms.Color.Default // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryHorizontalOptions
            match prevValueOpt, source.TryHorizontalOptions with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.HorizontalOptions <- value
            | Some _, None -> target.HorizontalOptions <- Unchecked.defaultof<Xamarin.Forms.LayoutOptions> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryVerticalOptions
            match prevValueOpt, source.TryVerticalOptions with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.VerticalOptions <- value
            | Some _, None -> target.VerticalOptions <- Unchecked.defaultof<Xamarin.Forms.LayoutOptions> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMargin
            match prevValueOpt, source.TryMargin with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Margin <- value
            | Some _, None -> target.Margin <- Unchecked.defaultof<Xamarin.Forms.Thickness> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevCollOpt = match prevOpt with None -> None | Some prev -> prev.TryGestureRecognizers
            match prevCollOpt, source.TryGestureRecognizers with
            // For structured objects, amortize on reference equality
            | Some prevColl, Some newColl when System.Object.ReferenceEquals(prevColl, newColl) -> ()
            | _, Some coll when coll <> null && coll.Length > 0 ->
                applyToIList
                    prevCollOpt
                    coll
                    target.GestureRecognizers
                    (fun (x:XamlElement) -> x.CreateAsIGestureRecognizer())
                    (fun _ _ _ -> ())
                    (fun (prevChild:XamlElement) (newChild:XamlElement) -> prevChild.TargetType = newChild.TargetType)
                    (fun prevChild newChild targetChild -> newChild.ApplyIncremental(prevChild, targetChild))
            | _ -> target.GestureRecognizers.Clear()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryAnchorX
            match prevValueOpt, source.TryAnchorX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.AnchorX <- value
            | Some _, None -> target.AnchorX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryAnchorY
            match prevValueOpt, source.TryAnchorY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.AnchorY <- value
            | Some _, None -> target.AnchorY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryBackgroundColor
            match prevValueOpt, source.TryBackgroundColor with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.BackgroundColor <- value
            | Some _, None -> target.BackgroundColor <- Xamarin.Forms.Color.Default // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryHeightRequest
            match prevValueOpt, source.TryHeightRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.HeightRequest <- value
            | Some _, None -> target.HeightRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryInputTransparent
            match prevValueOpt, source.TryInputTransparent with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.InputTransparent <- value
            | Some _, None -> target.InputTransparent <- false // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsEnabled
            match prevValueOpt, source.TryIsEnabled with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsEnabled <- value
            | Some _, None -> target.IsEnabled <- true // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsVisible
            match prevValueOpt, source.TryIsVisible with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsVisible <- value
            | Some _, None -> target.IsVisible <- true // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMinimumHeightRequest
            match prevValueOpt, source.TryMinimumHeightRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.MinimumHeightRequest <- value
            | Some _, None -> target.MinimumHeightRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMinimumWidthRequest
            match prevValueOpt, source.TryMinimumWidthRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.MinimumWidthRequest <- value
            | Some _, None -> target.MinimumWidthRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryOpacity
            match prevValueOpt, source.TryOpacity with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Opacity <- value
            | Some _, None -> target.Opacity <- 1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotation
            match prevValueOpt, source.TryRotation with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Rotation <- value
            | Some _, None -> target.Rotation <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotationX
            match prevValueOpt, source.TryRotationX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.RotationX <- value
            | Some _, None -> target.RotationX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotationY
            match prevValueOpt, source.TryRotationY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.RotationY <- value
            | Some _, None -> target.RotationY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryScale
            match prevValueOpt, source.TryScale with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Scale <- value
            | Some _, None -> target.Scale <- 1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryStyle
            match prevValueOpt, source.TryStyle with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Style <- value
            | Some _, None -> target.Style <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryTranslationX
            match prevValueOpt, source.TryTranslationX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.TranslationX <- value
            | Some _, None -> target.TranslationX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryTranslationY
            match prevValueOpt, source.TryTranslationY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.TranslationY <- value
            | Some _, None -> target.TranslationY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryWidthRequest
            match prevValueOpt, source.TryWidthRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.WidthRequest <- value
            | Some _, None -> target.WidthRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryClassId
            match prevValueOpt, source.TryClassId with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.ClassId <- value
            | Some _, None -> target.ClassId <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryStyleId
            match prevValueOpt, source.TryStyleId with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.StyleId <- value
            | Some _, None -> target.StyleId <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
        new XamlElement(typeof<Xamarin.Forms.TimePicker>, create, apply, Map.ofArray attribs)

    /// Describes a WebView in the view
    static member WebView(?source: Xamarin.Forms.WebViewSource, ?navigated: Xamarin.Forms.WebNavigatedEventArgs -> unit, ?navigating: Xamarin.Forms.WebNavigatingEventArgs -> unit, ?horizontalOptions: Xamarin.Forms.LayoutOptions, ?verticalOptions: Xamarin.Forms.LayoutOptions, ?margin: obj, ?gestureRecognizers: XamlElement list, ?anchorX: double, ?anchorY: double, ?backgroundColor: Xamarin.Forms.Color, ?heightRequest: double, ?inputTransparent: bool, ?isEnabled: bool, ?isVisible: bool, ?minimumHeightRequest: double, ?minimumWidthRequest: double, ?opacity: double, ?rotation: double, ?rotationX: double, ?rotationY: double, ?scale: double, ?style: Xamarin.Forms.Style, ?translationX: double, ?translationY: double, ?widthRequest: double, ?classId: string, ?styleId: string) = 
        let attribs = [| 
            match source with None -> () | Some v -> yield ("WebSource", box ((v))) 
            match navigated with None -> () | Some v -> yield ("Navigated", box ((fun f -> System.EventHandler<Xamarin.Forms.WebNavigatedEventArgs>(fun _sender args -> f args))(v))) 
            match navigating with None -> () | Some v -> yield ("Navigating", box ((fun f -> System.EventHandler<Xamarin.Forms.WebNavigatingEventArgs>(fun _sender args -> f args))(v))) 
            match horizontalOptions with None -> () | Some v -> yield ("HorizontalOptions", box ((v))) 
            match verticalOptions with None -> () | Some v -> yield ("VerticalOptions", box ((v))) 
            match margin with None -> () | Some v -> yield ("Margin", box (makeThickness(v))) 
            match gestureRecognizers with None -> () | Some v -> yield ("GestureRecognizers", box (Array.ofList(v))) 
            match anchorX with None -> () | Some v -> yield ("AnchorX", box ((v))) 
            match anchorY with None -> () | Some v -> yield ("AnchorY", box ((v))) 
            match backgroundColor with None -> () | Some v -> yield ("BackgroundColor", box ((v))) 
            match heightRequest with None -> () | Some v -> yield ("HeightRequest", box ((v))) 
            match inputTransparent with None -> () | Some v -> yield ("InputTransparent", box ((v))) 
            match isEnabled with None -> () | Some v -> yield ("IsEnabled", box ((v))) 
            match isVisible with None -> () | Some v -> yield ("IsVisible", box ((v))) 
            match minimumHeightRequest with None -> () | Some v -> yield ("MinimumHeightRequest", box ((v))) 
            match minimumWidthRequest with None -> () | Some v -> yield ("MinimumWidthRequest", box ((v))) 
            match opacity with None -> () | Some v -> yield ("Opacity", box ((v))) 
            match rotation with None -> () | Some v -> yield ("Rotation", box ((v))) 
            match rotationX with None -> () | Some v -> yield ("RotationX", box ((v))) 
            match rotationY with None -> () | Some v -> yield ("RotationY", box ((v))) 
            match scale with None -> () | Some v -> yield ("Scale", box ((v))) 
            match style with None -> () | Some v -> yield ("Style", box ((v))) 
            match translationX with None -> () | Some v -> yield ("TranslationX", box ((v))) 
            match translationY with None -> () | Some v -> yield ("TranslationY", box ((v))) 
            match widthRequest with None -> () | Some v -> yield ("WidthRequest", box ((v))) 
            match classId with None -> () | Some v -> yield ("ClassId", box ((v))) 
            match styleId with None -> () | Some v -> yield ("StyleId", box ((v))) 
          |]

        let create () =
            box (new Xamarin.Forms.WebView())

        let apply (prevOpt: XamlElement option) (source: XamlElement) (target:obj) = 
            let target = (target :?> Xamarin.Forms.WebView)
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryWebSource
            match prevValueOpt, source.TryWebSource with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Source <- value
            | Some _, None -> target.Source <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryNavigated
            match prevValueOpt, source.TryNavigated with
            | Some prevValue, Some value when System.Object.ReferenceEquals(prevValue, value) -> ()
            | Some prevValue, Some value -> target.Navigated.RemoveHandler(prevValue); target.Navigated.AddHandler(value)
            | None, Some value -> target.Navigated.AddHandler(value)
            | Some prevValue, None -> target.Navigated.RemoveHandler(prevValue)
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryNavigating
            match prevValueOpt, source.TryNavigating with
            | Some prevValue, Some value when System.Object.ReferenceEquals(prevValue, value) -> ()
            | Some prevValue, Some value -> target.Navigating.RemoveHandler(prevValue); target.Navigating.AddHandler(value)
            | None, Some value -> target.Navigating.AddHandler(value)
            | Some prevValue, None -> target.Navigating.RemoveHandler(prevValue)
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryHorizontalOptions
            match prevValueOpt, source.TryHorizontalOptions with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.HorizontalOptions <- value
            | Some _, None -> target.HorizontalOptions <- Unchecked.defaultof<Xamarin.Forms.LayoutOptions> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryVerticalOptions
            match prevValueOpt, source.TryVerticalOptions with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.VerticalOptions <- value
            | Some _, None -> target.VerticalOptions <- Unchecked.defaultof<Xamarin.Forms.LayoutOptions> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMargin
            match prevValueOpt, source.TryMargin with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Margin <- value
            | Some _, None -> target.Margin <- Unchecked.defaultof<Xamarin.Forms.Thickness> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevCollOpt = match prevOpt with None -> None | Some prev -> prev.TryGestureRecognizers
            match prevCollOpt, source.TryGestureRecognizers with
            // For structured objects, amortize on reference equality
            | Some prevColl, Some newColl when System.Object.ReferenceEquals(prevColl, newColl) -> ()
            | _, Some coll when coll <> null && coll.Length > 0 ->
                applyToIList
                    prevCollOpt
                    coll
                    target.GestureRecognizers
                    (fun (x:XamlElement) -> x.CreateAsIGestureRecognizer())
                    (fun _ _ _ -> ())
                    (fun (prevChild:XamlElement) (newChild:XamlElement) -> prevChild.TargetType = newChild.TargetType)
                    (fun prevChild newChild targetChild -> newChild.ApplyIncremental(prevChild, targetChild))
            | _ -> target.GestureRecognizers.Clear()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryAnchorX
            match prevValueOpt, source.TryAnchorX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.AnchorX <- value
            | Some _, None -> target.AnchorX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryAnchorY
            match prevValueOpt, source.TryAnchorY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.AnchorY <- value
            | Some _, None -> target.AnchorY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryBackgroundColor
            match prevValueOpt, source.TryBackgroundColor with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.BackgroundColor <- value
            | Some _, None -> target.BackgroundColor <- Xamarin.Forms.Color.Default // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryHeightRequest
            match prevValueOpt, source.TryHeightRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.HeightRequest <- value
            | Some _, None -> target.HeightRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryInputTransparent
            match prevValueOpt, source.TryInputTransparent with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.InputTransparent <- value
            | Some _, None -> target.InputTransparent <- false // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsEnabled
            match prevValueOpt, source.TryIsEnabled with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsEnabled <- value
            | Some _, None -> target.IsEnabled <- true // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsVisible
            match prevValueOpt, source.TryIsVisible with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsVisible <- value
            | Some _, None -> target.IsVisible <- true // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMinimumHeightRequest
            match prevValueOpt, source.TryMinimumHeightRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.MinimumHeightRequest <- value
            | Some _, None -> target.MinimumHeightRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMinimumWidthRequest
            match prevValueOpt, source.TryMinimumWidthRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.MinimumWidthRequest <- value
            | Some _, None -> target.MinimumWidthRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryOpacity
            match prevValueOpt, source.TryOpacity with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Opacity <- value
            | Some _, None -> target.Opacity <- 1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotation
            match prevValueOpt, source.TryRotation with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Rotation <- value
            | Some _, None -> target.Rotation <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotationX
            match prevValueOpt, source.TryRotationX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.RotationX <- value
            | Some _, None -> target.RotationX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotationY
            match prevValueOpt, source.TryRotationY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.RotationY <- value
            | Some _, None -> target.RotationY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryScale
            match prevValueOpt, source.TryScale with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Scale <- value
            | Some _, None -> target.Scale <- 1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryStyle
            match prevValueOpt, source.TryStyle with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Style <- value
            | Some _, None -> target.Style <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryTranslationX
            match prevValueOpt, source.TryTranslationX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.TranslationX <- value
            | Some _, None -> target.TranslationX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryTranslationY
            match prevValueOpt, source.TryTranslationY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.TranslationY <- value
            | Some _, None -> target.TranslationY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryWidthRequest
            match prevValueOpt, source.TryWidthRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.WidthRequest <- value
            | Some _, None -> target.WidthRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryClassId
            match prevValueOpt, source.TryClassId with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.ClassId <- value
            | Some _, None -> target.ClassId <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryStyleId
            match prevValueOpt, source.TryStyleId with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.StyleId <- value
            | Some _, None -> target.StyleId <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
        new XamlElement(typeof<Xamarin.Forms.WebView>, create, apply, Map.ofArray attribs)

    /// Describes a Page in the view
    static member Page(?title: string, ?padding: double, ?anchorX: double, ?anchorY: double, ?backgroundColor: Xamarin.Forms.Color, ?heightRequest: double, ?inputTransparent: bool, ?isEnabled: bool, ?isVisible: bool, ?minimumHeightRequest: double, ?minimumWidthRequest: double, ?opacity: double, ?rotation: double, ?rotationX: double, ?rotationY: double, ?scale: double, ?style: Xamarin.Forms.Style, ?translationX: double, ?translationY: double, ?widthRequest: double, ?classId: string, ?styleId: string) = 
        let attribs = [| 
            match title with None -> () | Some v -> yield ("Title", box ((v))) 
            match padding with None -> () | Some v -> yield ("Padding", box (makeThickness(v))) 
            match anchorX with None -> () | Some v -> yield ("AnchorX", box ((v))) 
            match anchorY with None -> () | Some v -> yield ("AnchorY", box ((v))) 
            match backgroundColor with None -> () | Some v -> yield ("BackgroundColor", box ((v))) 
            match heightRequest with None -> () | Some v -> yield ("HeightRequest", box ((v))) 
            match inputTransparent with None -> () | Some v -> yield ("InputTransparent", box ((v))) 
            match isEnabled with None -> () | Some v -> yield ("IsEnabled", box ((v))) 
            match isVisible with None -> () | Some v -> yield ("IsVisible", box ((v))) 
            match minimumHeightRequest with None -> () | Some v -> yield ("MinimumHeightRequest", box ((v))) 
            match minimumWidthRequest with None -> () | Some v -> yield ("MinimumWidthRequest", box ((v))) 
            match opacity with None -> () | Some v -> yield ("Opacity", box ((v))) 
            match rotation with None -> () | Some v -> yield ("Rotation", box ((v))) 
            match rotationX with None -> () | Some v -> yield ("RotationX", box ((v))) 
            match rotationY with None -> () | Some v -> yield ("RotationY", box ((v))) 
            match scale with None -> () | Some v -> yield ("Scale", box ((v))) 
            match style with None -> () | Some v -> yield ("Style", box ((v))) 
            match translationX with None -> () | Some v -> yield ("TranslationX", box ((v))) 
            match translationY with None -> () | Some v -> yield ("TranslationY", box ((v))) 
            match widthRequest with None -> () | Some v -> yield ("WidthRequest", box ((v))) 
            match classId with None -> () | Some v -> yield ("ClassId", box ((v))) 
            match styleId with None -> () | Some v -> yield ("StyleId", box ((v))) 
          |]

        let create () =
            box (new Xamarin.Forms.Page())

        let apply (prevOpt: XamlElement option) (source: XamlElement) (target:obj) = 
            let target = (target :?> Xamarin.Forms.Page)
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryTitle
            match prevValueOpt, source.TryTitle with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Title <- value
            | Some _, None -> target.Title <- "" // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryPadding
            match prevValueOpt, source.TryPadding with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Padding <- value
            | Some _, None -> target.Padding <- Unchecked.defaultof<Xamarin.Forms.Thickness> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryAnchorX
            match prevValueOpt, source.TryAnchorX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.AnchorX <- value
            | Some _, None -> target.AnchorX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryAnchorY
            match prevValueOpt, source.TryAnchorY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.AnchorY <- value
            | Some _, None -> target.AnchorY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryBackgroundColor
            match prevValueOpt, source.TryBackgroundColor with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.BackgroundColor <- value
            | Some _, None -> target.BackgroundColor <- Xamarin.Forms.Color.Default // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryHeightRequest
            match prevValueOpt, source.TryHeightRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.HeightRequest <- value
            | Some _, None -> target.HeightRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryInputTransparent
            match prevValueOpt, source.TryInputTransparent with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.InputTransparent <- value
            | Some _, None -> target.InputTransparent <- false // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsEnabled
            match prevValueOpt, source.TryIsEnabled with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsEnabled <- value
            | Some _, None -> target.IsEnabled <- true // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsVisible
            match prevValueOpt, source.TryIsVisible with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsVisible <- value
            | Some _, None -> target.IsVisible <- true // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMinimumHeightRequest
            match prevValueOpt, source.TryMinimumHeightRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.MinimumHeightRequest <- value
            | Some _, None -> target.MinimumHeightRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMinimumWidthRequest
            match prevValueOpt, source.TryMinimumWidthRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.MinimumWidthRequest <- value
            | Some _, None -> target.MinimumWidthRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryOpacity
            match prevValueOpt, source.TryOpacity with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Opacity <- value
            | Some _, None -> target.Opacity <- 1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotation
            match prevValueOpt, source.TryRotation with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Rotation <- value
            | Some _, None -> target.Rotation <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotationX
            match prevValueOpt, source.TryRotationX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.RotationX <- value
            | Some _, None -> target.RotationX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotationY
            match prevValueOpt, source.TryRotationY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.RotationY <- value
            | Some _, None -> target.RotationY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryScale
            match prevValueOpt, source.TryScale with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Scale <- value
            | Some _, None -> target.Scale <- 1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryStyle
            match prevValueOpt, source.TryStyle with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Style <- value
            | Some _, None -> target.Style <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryTranslationX
            match prevValueOpt, source.TryTranslationX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.TranslationX <- value
            | Some _, None -> target.TranslationX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryTranslationY
            match prevValueOpt, source.TryTranslationY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.TranslationY <- value
            | Some _, None -> target.TranslationY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryWidthRequest
            match prevValueOpt, source.TryWidthRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.WidthRequest <- value
            | Some _, None -> target.WidthRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryClassId
            match prevValueOpt, source.TryClassId with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.ClassId <- value
            | Some _, None -> target.ClassId <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryStyleId
            match prevValueOpt, source.TryStyleId with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.StyleId <- value
            | Some _, None -> target.StyleId <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
        new XamlElement(typeof<Xamarin.Forms.Page>, create, apply, Map.ofArray attribs)

    /// Describes a CarouselPage in the view
    static member CarouselPage(?children: XamlElement list, ?itemsSource: 'T list, ?itemTemplate: Xamarin.Forms.DataTemplate, ?selectedItem: System.Object, ?currentPage: XamlElement, ?currentPageChanged: 'T option -> unit, ?title: string, ?padding: double, ?anchorX: double, ?anchorY: double, ?backgroundColor: Xamarin.Forms.Color, ?heightRequest: double, ?inputTransparent: bool, ?isEnabled: bool, ?isVisible: bool, ?minimumHeightRequest: double, ?minimumWidthRequest: double, ?opacity: double, ?rotation: double, ?rotationX: double, ?rotationY: double, ?scale: double, ?style: Xamarin.Forms.Style, ?translationX: double, ?translationY: double, ?widthRequest: double, ?classId: string, ?styleId: string) = 
        let attribs = [| 
            match children with None -> () | Some v -> yield ("Children", box (Array.ofList(v))) 
            match itemsSource with None -> () | Some v -> yield ("ItemsSource", box ((fun es -> es |> Array.ofList |> Array.map box :> System.Collections.Generic.IList<obj>)(v))) 
            match itemTemplate with None -> () | Some v -> yield ("ItemTemplate", box ((v))) 
            match selectedItem with None -> () | Some v -> yield ("CarouselPage_SelectedItem", box ((v))) 
            match currentPage with None -> () | Some v -> yield ("CurrentPage", box ((v))) 
            match currentPageChanged with None -> () | Some v -> yield ("CurrentPageChanged", box ((fun f -> System.EventHandler(fun sender args -> f ((sender :?> Xamarin.Forms.CarouselPage).SelectedItem |> Option.ofObj |> Option.map unbox<'T>)))(v))) 
            match title with None -> () | Some v -> yield ("Title", box ((v))) 
            match padding with None -> () | Some v -> yield ("Padding", box (makeThickness(v))) 
            match anchorX with None -> () | Some v -> yield ("AnchorX", box ((v))) 
            match anchorY with None -> () | Some v -> yield ("AnchorY", box ((v))) 
            match backgroundColor with None -> () | Some v -> yield ("BackgroundColor", box ((v))) 
            match heightRequest with None -> () | Some v -> yield ("HeightRequest", box ((v))) 
            match inputTransparent with None -> () | Some v -> yield ("InputTransparent", box ((v))) 
            match isEnabled with None -> () | Some v -> yield ("IsEnabled", box ((v))) 
            match isVisible with None -> () | Some v -> yield ("IsVisible", box ((v))) 
            match minimumHeightRequest with None -> () | Some v -> yield ("MinimumHeightRequest", box ((v))) 
            match minimumWidthRequest with None -> () | Some v -> yield ("MinimumWidthRequest", box ((v))) 
            match opacity with None -> () | Some v -> yield ("Opacity", box ((v))) 
            match rotation with None -> () | Some v -> yield ("Rotation", box ((v))) 
            match rotationX with None -> () | Some v -> yield ("RotationX", box ((v))) 
            match rotationY with None -> () | Some v -> yield ("RotationY", box ((v))) 
            match scale with None -> () | Some v -> yield ("Scale", box ((v))) 
            match style with None -> () | Some v -> yield ("Style", box ((v))) 
            match translationX with None -> () | Some v -> yield ("TranslationX", box ((v))) 
            match translationY with None -> () | Some v -> yield ("TranslationY", box ((v))) 
            match widthRequest with None -> () | Some v -> yield ("WidthRequest", box ((v))) 
            match classId with None -> () | Some v -> yield ("ClassId", box ((v))) 
            match styleId with None -> () | Some v -> yield ("StyleId", box ((v))) 
          |]

        let create () =
            box (new Xamarin.Forms.CarouselPage())

        let apply (prevOpt: XamlElement option) (source: XamlElement) (target:obj) = 
            let target = (target :?> Xamarin.Forms.CarouselPage)
            let prevCollOpt = match prevOpt with None -> None | Some prev -> prev.TryChildren
            match prevCollOpt, source.TryChildren with
            // For structured objects, amortize on reference equality
            | Some prevColl, Some newColl when System.Object.ReferenceEquals(prevColl, newColl) -> ()
            | _, Some coll when coll <> null && coll.Length > 0 ->
                applyToIList
                    prevCollOpt
                    coll
                    target.Children
                    (fun (x:XamlElement) -> x.CreateAsContentPage())
                    (fun _ _ _ -> ())
                    (fun (prevChild:XamlElement) (newChild:XamlElement) -> prevChild.TargetType = newChild.TargetType)
                    (fun prevChild newChild targetChild -> newChild.ApplyIncremental(prevChild, targetChild))
            | _ -> target.Children.Clear()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryItemsSource
            match prevValueOpt, source.TryItemsSource with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.ItemsSource <- value
            | Some _, None -> target.ItemsSource <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryItemTemplate
            match prevValueOpt, source.TryItemTemplate with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.ItemTemplate <- value
            | Some _, None -> target.ItemTemplate <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryCarouselPage_SelectedItem
            match prevValueOpt, source.TryCarouselPage_SelectedItem with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.SelectedItem <- value
            | Some _, None -> target.SelectedItem <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevChildOpt = match prevOpt with None -> None | Some prev -> prev.TryCurrentPage
            match prevChildOpt, source.TryCurrentPage with
            // For structured objects, amortize on reference equality
            | Some prevChild, Some newChild when System.Object.ReferenceEquals(prevChild, newChild) -> ()
            | Some prevChild, Some newChild ->
                newChild.ApplyIncremental(prevChild, target.CurrentPage)
            | None, Some newChild ->
                target.CurrentPage <- newChild.CreateAsContentPage()
            | Some _, None ->
                target.CurrentPage <- null;
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryCurrentPageChanged
            match prevValueOpt, source.TryCurrentPageChanged with
            | Some prevValue, Some value when System.Object.ReferenceEquals(prevValue, value) -> ()
            | Some prevValue, Some value -> target.CurrentPageChanged.RemoveHandler(prevValue); target.CurrentPageChanged.AddHandler(value)
            | None, Some value -> target.CurrentPageChanged.AddHandler(value)
            | Some prevValue, None -> target.CurrentPageChanged.RemoveHandler(prevValue)
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryTitle
            match prevValueOpt, source.TryTitle with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Title <- value
            | Some _, None -> target.Title <- "" // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryPadding
            match prevValueOpt, source.TryPadding with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Padding <- value
            | Some _, None -> target.Padding <- Unchecked.defaultof<Xamarin.Forms.Thickness> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryAnchorX
            match prevValueOpt, source.TryAnchorX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.AnchorX <- value
            | Some _, None -> target.AnchorX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryAnchorY
            match prevValueOpt, source.TryAnchorY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.AnchorY <- value
            | Some _, None -> target.AnchorY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryBackgroundColor
            match prevValueOpt, source.TryBackgroundColor with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.BackgroundColor <- value
            | Some _, None -> target.BackgroundColor <- Xamarin.Forms.Color.Default // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryHeightRequest
            match prevValueOpt, source.TryHeightRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.HeightRequest <- value
            | Some _, None -> target.HeightRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryInputTransparent
            match prevValueOpt, source.TryInputTransparent with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.InputTransparent <- value
            | Some _, None -> target.InputTransparent <- false // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsEnabled
            match prevValueOpt, source.TryIsEnabled with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsEnabled <- value
            | Some _, None -> target.IsEnabled <- true // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsVisible
            match prevValueOpt, source.TryIsVisible with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsVisible <- value
            | Some _, None -> target.IsVisible <- true // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMinimumHeightRequest
            match prevValueOpt, source.TryMinimumHeightRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.MinimumHeightRequest <- value
            | Some _, None -> target.MinimumHeightRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMinimumWidthRequest
            match prevValueOpt, source.TryMinimumWidthRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.MinimumWidthRequest <- value
            | Some _, None -> target.MinimumWidthRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryOpacity
            match prevValueOpt, source.TryOpacity with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Opacity <- value
            | Some _, None -> target.Opacity <- 1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotation
            match prevValueOpt, source.TryRotation with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Rotation <- value
            | Some _, None -> target.Rotation <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotationX
            match prevValueOpt, source.TryRotationX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.RotationX <- value
            | Some _, None -> target.RotationX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotationY
            match prevValueOpt, source.TryRotationY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.RotationY <- value
            | Some _, None -> target.RotationY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryScale
            match prevValueOpt, source.TryScale with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Scale <- value
            | Some _, None -> target.Scale <- 1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryStyle
            match prevValueOpt, source.TryStyle with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Style <- value
            | Some _, None -> target.Style <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryTranslationX
            match prevValueOpt, source.TryTranslationX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.TranslationX <- value
            | Some _, None -> target.TranslationX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryTranslationY
            match prevValueOpt, source.TryTranslationY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.TranslationY <- value
            | Some _, None -> target.TranslationY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryWidthRequest
            match prevValueOpt, source.TryWidthRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.WidthRequest <- value
            | Some _, None -> target.WidthRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryClassId
            match prevValueOpt, source.TryClassId with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.ClassId <- value
            | Some _, None -> target.ClassId <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryStyleId
            match prevValueOpt, source.TryStyleId with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.StyleId <- value
            | Some _, None -> target.StyleId <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
        new XamlElement(typeof<Xamarin.Forms.CarouselPage>, create, apply, Map.ofArray attribs)

    /// Describes a NavigationPage in the view
    static member NavigationPage(?barBackgroundColor: Xamarin.Forms.Color, ?barTextColor: Xamarin.Forms.Color, ?popped: Xamarin.Forms.NavigationEventArgs -> unit, ?poppedToRoot: Xamarin.Forms.NavigationEventArgs -> unit, ?pushed: Xamarin.Forms.NavigationEventArgs -> unit, ?title: string, ?padding: double, ?anchorX: double, ?anchorY: double, ?backgroundColor: Xamarin.Forms.Color, ?heightRequest: double, ?inputTransparent: bool, ?isEnabled: bool, ?isVisible: bool, ?minimumHeightRequest: double, ?minimumWidthRequest: double, ?opacity: double, ?rotation: double, ?rotationX: double, ?rotationY: double, ?scale: double, ?style: Xamarin.Forms.Style, ?translationX: double, ?translationY: double, ?widthRequest: double, ?classId: string, ?styleId: string) = 
        let attribs = [| 
            match barBackgroundColor with None -> () | Some v -> yield ("BarBackgroundColor", box ((v))) 
            match barTextColor with None -> () | Some v -> yield ("BarTextColor", box ((v))) 
            match popped with None -> () | Some v -> yield ("Popped", box ((fun f -> System.EventHandler<Xamarin.Forms.NavigationEventArgs>(fun sender args -> f args))(v))) 
            match poppedToRoot with None -> () | Some v -> yield ("PoppedToRoot", box ((fun f -> System.EventHandler<Xamarin.Forms.NavigationEventArgs>(fun sender args -> f args))(v))) 
            match pushed with None -> () | Some v -> yield ("Pushed", box ((fun f -> System.EventHandler<Xamarin.Forms.NavigationEventArgs>(fun sender args -> f args))(v))) 
            match title with None -> () | Some v -> yield ("Title", box ((v))) 
            match padding with None -> () | Some v -> yield ("Padding", box (makeThickness(v))) 
            match anchorX with None -> () | Some v -> yield ("AnchorX", box ((v))) 
            match anchorY with None -> () | Some v -> yield ("AnchorY", box ((v))) 
            match backgroundColor with None -> () | Some v -> yield ("BackgroundColor", box ((v))) 
            match heightRequest with None -> () | Some v -> yield ("HeightRequest", box ((v))) 
            match inputTransparent with None -> () | Some v -> yield ("InputTransparent", box ((v))) 
            match isEnabled with None -> () | Some v -> yield ("IsEnabled", box ((v))) 
            match isVisible with None -> () | Some v -> yield ("IsVisible", box ((v))) 
            match minimumHeightRequest with None -> () | Some v -> yield ("MinimumHeightRequest", box ((v))) 
            match minimumWidthRequest with None -> () | Some v -> yield ("MinimumWidthRequest", box ((v))) 
            match opacity with None -> () | Some v -> yield ("Opacity", box ((v))) 
            match rotation with None -> () | Some v -> yield ("Rotation", box ((v))) 
            match rotationX with None -> () | Some v -> yield ("RotationX", box ((v))) 
            match rotationY with None -> () | Some v -> yield ("RotationY", box ((v))) 
            match scale with None -> () | Some v -> yield ("Scale", box ((v))) 
            match style with None -> () | Some v -> yield ("Style", box ((v))) 
            match translationX with None -> () | Some v -> yield ("TranslationX", box ((v))) 
            match translationY with None -> () | Some v -> yield ("TranslationY", box ((v))) 
            match widthRequest with None -> () | Some v -> yield ("WidthRequest", box ((v))) 
            match classId with None -> () | Some v -> yield ("ClassId", box ((v))) 
            match styleId with None -> () | Some v -> yield ("StyleId", box ((v))) 
          |]

        let create () =
            box (new Xamarin.Forms.NavigationPage())

        let apply (prevOpt: XamlElement option) (source: XamlElement) (target:obj) = 
            let target = (target :?> Xamarin.Forms.NavigationPage)
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryBarBackgroundColor
            match prevValueOpt, source.TryBarBackgroundColor with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.BarBackgroundColor <- value
            | Some _, None -> target.BarBackgroundColor <- Xamarin.Forms.Color.Default // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryBarTextColor
            match prevValueOpt, source.TryBarTextColor with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.BarTextColor <- value
            | Some _, None -> target.BarTextColor <- Xamarin.Forms.Color.Default // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryPopped
            match prevValueOpt, source.TryPopped with
            | Some prevValue, Some value when System.Object.ReferenceEquals(prevValue, value) -> ()
            | Some prevValue, Some value -> target.Popped.RemoveHandler(prevValue); target.Popped.AddHandler(value)
            | None, Some value -> target.Popped.AddHandler(value)
            | Some prevValue, None -> target.Popped.RemoveHandler(prevValue)
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryPoppedToRoot
            match prevValueOpt, source.TryPoppedToRoot with
            | Some prevValue, Some value when System.Object.ReferenceEquals(prevValue, value) -> ()
            | Some prevValue, Some value -> target.PoppedToRoot.RemoveHandler(prevValue); target.PoppedToRoot.AddHandler(value)
            | None, Some value -> target.PoppedToRoot.AddHandler(value)
            | Some prevValue, None -> target.PoppedToRoot.RemoveHandler(prevValue)
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryPushed
            match prevValueOpt, source.TryPushed with
            | Some prevValue, Some value when System.Object.ReferenceEquals(prevValue, value) -> ()
            | Some prevValue, Some value -> target.Pushed.RemoveHandler(prevValue); target.Pushed.AddHandler(value)
            | None, Some value -> target.Pushed.AddHandler(value)
            | Some prevValue, None -> target.Pushed.RemoveHandler(prevValue)
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryTitle
            match prevValueOpt, source.TryTitle with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Title <- value
            | Some _, None -> target.Title <- "" // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryPadding
            match prevValueOpt, source.TryPadding with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Padding <- value
            | Some _, None -> target.Padding <- Unchecked.defaultof<Xamarin.Forms.Thickness> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryAnchorX
            match prevValueOpt, source.TryAnchorX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.AnchorX <- value
            | Some _, None -> target.AnchorX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryAnchorY
            match prevValueOpt, source.TryAnchorY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.AnchorY <- value
            | Some _, None -> target.AnchorY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryBackgroundColor
            match prevValueOpt, source.TryBackgroundColor with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.BackgroundColor <- value
            | Some _, None -> target.BackgroundColor <- Xamarin.Forms.Color.Default // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryHeightRequest
            match prevValueOpt, source.TryHeightRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.HeightRequest <- value
            | Some _, None -> target.HeightRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryInputTransparent
            match prevValueOpt, source.TryInputTransparent with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.InputTransparent <- value
            | Some _, None -> target.InputTransparent <- false // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsEnabled
            match prevValueOpt, source.TryIsEnabled with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsEnabled <- value
            | Some _, None -> target.IsEnabled <- true // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsVisible
            match prevValueOpt, source.TryIsVisible with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsVisible <- value
            | Some _, None -> target.IsVisible <- true // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMinimumHeightRequest
            match prevValueOpt, source.TryMinimumHeightRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.MinimumHeightRequest <- value
            | Some _, None -> target.MinimumHeightRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMinimumWidthRequest
            match prevValueOpt, source.TryMinimumWidthRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.MinimumWidthRequest <- value
            | Some _, None -> target.MinimumWidthRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryOpacity
            match prevValueOpt, source.TryOpacity with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Opacity <- value
            | Some _, None -> target.Opacity <- 1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotation
            match prevValueOpt, source.TryRotation with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Rotation <- value
            | Some _, None -> target.Rotation <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotationX
            match prevValueOpt, source.TryRotationX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.RotationX <- value
            | Some _, None -> target.RotationX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotationY
            match prevValueOpt, source.TryRotationY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.RotationY <- value
            | Some _, None -> target.RotationY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryScale
            match prevValueOpt, source.TryScale with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Scale <- value
            | Some _, None -> target.Scale <- 1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryStyle
            match prevValueOpt, source.TryStyle with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Style <- value
            | Some _, None -> target.Style <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryTranslationX
            match prevValueOpt, source.TryTranslationX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.TranslationX <- value
            | Some _, None -> target.TranslationX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryTranslationY
            match prevValueOpt, source.TryTranslationY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.TranslationY <- value
            | Some _, None -> target.TranslationY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryWidthRequest
            match prevValueOpt, source.TryWidthRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.WidthRequest <- value
            | Some _, None -> target.WidthRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryClassId
            match prevValueOpt, source.TryClassId with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.ClassId <- value
            | Some _, None -> target.ClassId <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryStyleId
            match prevValueOpt, source.TryStyleId with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.StyleId <- value
            | Some _, None -> target.StyleId <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
        new XamlElement(typeof<Xamarin.Forms.NavigationPage>, create, apply, Map.ofArray attribs)

    /// Describes a TabbedPage in the view
    static member TabbedPage(?children: XamlElement list, ?barBackgroundColor: Xamarin.Forms.Color, ?barTextColor: Xamarin.Forms.Color, ?title: string, ?padding: double, ?anchorX: double, ?anchorY: double, ?backgroundColor: Xamarin.Forms.Color, ?heightRequest: double, ?inputTransparent: bool, ?isEnabled: bool, ?isVisible: bool, ?minimumHeightRequest: double, ?minimumWidthRequest: double, ?opacity: double, ?rotation: double, ?rotationX: double, ?rotationY: double, ?scale: double, ?style: Xamarin.Forms.Style, ?translationX: double, ?translationY: double, ?widthRequest: double, ?classId: string, ?styleId: string) = 
        let attribs = [| 
            match children with None -> () | Some v -> yield ("Children", box (Array.ofList(v))) 
            match barBackgroundColor with None -> () | Some v -> yield ("BarBackgroundColor", box ((v))) 
            match barTextColor with None -> () | Some v -> yield ("BarTextColor", box ((v))) 
            match title with None -> () | Some v -> yield ("Title", box ((v))) 
            match padding with None -> () | Some v -> yield ("Padding", box (makeThickness(v))) 
            match anchorX with None -> () | Some v -> yield ("AnchorX", box ((v))) 
            match anchorY with None -> () | Some v -> yield ("AnchorY", box ((v))) 
            match backgroundColor with None -> () | Some v -> yield ("BackgroundColor", box ((v))) 
            match heightRequest with None -> () | Some v -> yield ("HeightRequest", box ((v))) 
            match inputTransparent with None -> () | Some v -> yield ("InputTransparent", box ((v))) 
            match isEnabled with None -> () | Some v -> yield ("IsEnabled", box ((v))) 
            match isVisible with None -> () | Some v -> yield ("IsVisible", box ((v))) 
            match minimumHeightRequest with None -> () | Some v -> yield ("MinimumHeightRequest", box ((v))) 
            match minimumWidthRequest with None -> () | Some v -> yield ("MinimumWidthRequest", box ((v))) 
            match opacity with None -> () | Some v -> yield ("Opacity", box ((v))) 
            match rotation with None -> () | Some v -> yield ("Rotation", box ((v))) 
            match rotationX with None -> () | Some v -> yield ("RotationX", box ((v))) 
            match rotationY with None -> () | Some v -> yield ("RotationY", box ((v))) 
            match scale with None -> () | Some v -> yield ("Scale", box ((v))) 
            match style with None -> () | Some v -> yield ("Style", box ((v))) 
            match translationX with None -> () | Some v -> yield ("TranslationX", box ((v))) 
            match translationY with None -> () | Some v -> yield ("TranslationY", box ((v))) 
            match widthRequest with None -> () | Some v -> yield ("WidthRequest", box ((v))) 
            match classId with None -> () | Some v -> yield ("ClassId", box ((v))) 
            match styleId with None -> () | Some v -> yield ("StyleId", box ((v))) 
          |]

        let create () =
            box (new Xamarin.Forms.TabbedPage())

        let apply (prevOpt: XamlElement option) (source: XamlElement) (target:obj) = 
            let target = (target :?> Xamarin.Forms.TabbedPage)
            let prevCollOpt = match prevOpt with None -> None | Some prev -> prev.TryChildren
            match prevCollOpt, source.TryChildren with
            // For structured objects, amortize on reference equality
            | Some prevColl, Some newColl when System.Object.ReferenceEquals(prevColl, newColl) -> ()
            | _, Some coll when coll <> null && coll.Length > 0 ->
                applyToIList
                    prevCollOpt
                    coll
                    target.Children
                    (fun (x:XamlElement) -> x.CreateAsPage())
                    (fun _ _ _ -> ())
                    (fun (prevChild:XamlElement) (newChild:XamlElement) -> prevChild.TargetType = newChild.TargetType)
                    (fun prevChild newChild targetChild -> newChild.ApplyIncremental(prevChild, targetChild))
            | _ -> target.Children.Clear()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryBarBackgroundColor
            match prevValueOpt, source.TryBarBackgroundColor with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.BarBackgroundColor <- value
            | Some _, None -> target.BarBackgroundColor <- Xamarin.Forms.Color.Default // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryBarTextColor
            match prevValueOpt, source.TryBarTextColor with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.BarTextColor <- value
            | Some _, None -> target.BarTextColor <- Xamarin.Forms.Color.Default // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryTitle
            match prevValueOpt, source.TryTitle with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Title <- value
            | Some _, None -> target.Title <- "" // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryPadding
            match prevValueOpt, source.TryPadding with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Padding <- value
            | Some _, None -> target.Padding <- Unchecked.defaultof<Xamarin.Forms.Thickness> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryAnchorX
            match prevValueOpt, source.TryAnchorX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.AnchorX <- value
            | Some _, None -> target.AnchorX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryAnchorY
            match prevValueOpt, source.TryAnchorY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.AnchorY <- value
            | Some _, None -> target.AnchorY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryBackgroundColor
            match prevValueOpt, source.TryBackgroundColor with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.BackgroundColor <- value
            | Some _, None -> target.BackgroundColor <- Xamarin.Forms.Color.Default // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryHeightRequest
            match prevValueOpt, source.TryHeightRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.HeightRequest <- value
            | Some _, None -> target.HeightRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryInputTransparent
            match prevValueOpt, source.TryInputTransparent with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.InputTransparent <- value
            | Some _, None -> target.InputTransparent <- false // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsEnabled
            match prevValueOpt, source.TryIsEnabled with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsEnabled <- value
            | Some _, None -> target.IsEnabled <- true // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsVisible
            match prevValueOpt, source.TryIsVisible with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsVisible <- value
            | Some _, None -> target.IsVisible <- true // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMinimumHeightRequest
            match prevValueOpt, source.TryMinimumHeightRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.MinimumHeightRequest <- value
            | Some _, None -> target.MinimumHeightRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMinimumWidthRequest
            match prevValueOpt, source.TryMinimumWidthRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.MinimumWidthRequest <- value
            | Some _, None -> target.MinimumWidthRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryOpacity
            match prevValueOpt, source.TryOpacity with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Opacity <- value
            | Some _, None -> target.Opacity <- 1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotation
            match prevValueOpt, source.TryRotation with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Rotation <- value
            | Some _, None -> target.Rotation <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotationX
            match prevValueOpt, source.TryRotationX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.RotationX <- value
            | Some _, None -> target.RotationX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotationY
            match prevValueOpt, source.TryRotationY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.RotationY <- value
            | Some _, None -> target.RotationY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryScale
            match prevValueOpt, source.TryScale with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Scale <- value
            | Some _, None -> target.Scale <- 1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryStyle
            match prevValueOpt, source.TryStyle with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Style <- value
            | Some _, None -> target.Style <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryTranslationX
            match prevValueOpt, source.TryTranslationX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.TranslationX <- value
            | Some _, None -> target.TranslationX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryTranslationY
            match prevValueOpt, source.TryTranslationY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.TranslationY <- value
            | Some _, None -> target.TranslationY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryWidthRequest
            match prevValueOpt, source.TryWidthRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.WidthRequest <- value
            | Some _, None -> target.WidthRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryClassId
            match prevValueOpt, source.TryClassId with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.ClassId <- value
            | Some _, None -> target.ClassId <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryStyleId
            match prevValueOpt, source.TryStyleId with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.StyleId <- value
            | Some _, None -> target.StyleId <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
        new XamlElement(typeof<Xamarin.Forms.TabbedPage>, create, apply, Map.ofArray attribs)

    /// Describes a ContentPage in the view
    static member ContentPage(?content: XamlElement, ?title: string, ?padding: double, ?anchorX: double, ?anchorY: double, ?backgroundColor: Xamarin.Forms.Color, ?heightRequest: double, ?inputTransparent: bool, ?isEnabled: bool, ?isVisible: bool, ?minimumHeightRequest: double, ?minimumWidthRequest: double, ?opacity: double, ?rotation: double, ?rotationX: double, ?rotationY: double, ?scale: double, ?style: Xamarin.Forms.Style, ?translationX: double, ?translationY: double, ?widthRequest: double, ?classId: string, ?styleId: string) = 
        let attribs = [| 
            match content with None -> () | Some v -> yield ("Content", box ((v))) 
            match title with None -> () | Some v -> yield ("Title", box ((v))) 
            match padding with None -> () | Some v -> yield ("Padding", box (makeThickness(v))) 
            match anchorX with None -> () | Some v -> yield ("AnchorX", box ((v))) 
            match anchorY with None -> () | Some v -> yield ("AnchorY", box ((v))) 
            match backgroundColor with None -> () | Some v -> yield ("BackgroundColor", box ((v))) 
            match heightRequest with None -> () | Some v -> yield ("HeightRequest", box ((v))) 
            match inputTransparent with None -> () | Some v -> yield ("InputTransparent", box ((v))) 
            match isEnabled with None -> () | Some v -> yield ("IsEnabled", box ((v))) 
            match isVisible with None -> () | Some v -> yield ("IsVisible", box ((v))) 
            match minimumHeightRequest with None -> () | Some v -> yield ("MinimumHeightRequest", box ((v))) 
            match minimumWidthRequest with None -> () | Some v -> yield ("MinimumWidthRequest", box ((v))) 
            match opacity with None -> () | Some v -> yield ("Opacity", box ((v))) 
            match rotation with None -> () | Some v -> yield ("Rotation", box ((v))) 
            match rotationX with None -> () | Some v -> yield ("RotationX", box ((v))) 
            match rotationY with None -> () | Some v -> yield ("RotationY", box ((v))) 
            match scale with None -> () | Some v -> yield ("Scale", box ((v))) 
            match style with None -> () | Some v -> yield ("Style", box ((v))) 
            match translationX with None -> () | Some v -> yield ("TranslationX", box ((v))) 
            match translationY with None -> () | Some v -> yield ("TranslationY", box ((v))) 
            match widthRequest with None -> () | Some v -> yield ("WidthRequest", box ((v))) 
            match classId with None -> () | Some v -> yield ("ClassId", box ((v))) 
            match styleId with None -> () | Some v -> yield ("StyleId", box ((v))) 
          |]

        let create () =
            box (new Xamarin.Forms.ContentPage())

        let apply (prevOpt: XamlElement option) (source: XamlElement) (target:obj) = 
            let target = (target :?> Xamarin.Forms.ContentPage)
            let prevChildOpt = match prevOpt with None -> None | Some prev -> prev.TryContent
            match prevChildOpt, source.TryContent with
            // For structured objects, amortize on reference equality
            | Some prevChild, Some newChild when System.Object.ReferenceEquals(prevChild, newChild) -> ()
            | Some prevChild, Some newChild ->
                newChild.ApplyIncremental(prevChild, target.Content)
            | None, Some newChild ->
                target.Content <- newChild.CreateAsView()
            | Some _, None ->
                target.Content <- null;
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryTitle
            match prevValueOpt, source.TryTitle with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Title <- value
            | Some _, None -> target.Title <- "" // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryPadding
            match prevValueOpt, source.TryPadding with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Padding <- value
            | Some _, None -> target.Padding <- Unchecked.defaultof<Xamarin.Forms.Thickness> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryAnchorX
            match prevValueOpt, source.TryAnchorX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.AnchorX <- value
            | Some _, None -> target.AnchorX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryAnchorY
            match prevValueOpt, source.TryAnchorY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.AnchorY <- value
            | Some _, None -> target.AnchorY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryBackgroundColor
            match prevValueOpt, source.TryBackgroundColor with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.BackgroundColor <- value
            | Some _, None -> target.BackgroundColor <- Xamarin.Forms.Color.Default // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryHeightRequest
            match prevValueOpt, source.TryHeightRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.HeightRequest <- value
            | Some _, None -> target.HeightRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryInputTransparent
            match prevValueOpt, source.TryInputTransparent with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.InputTransparent <- value
            | Some _, None -> target.InputTransparent <- false // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsEnabled
            match prevValueOpt, source.TryIsEnabled with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsEnabled <- value
            | Some _, None -> target.IsEnabled <- true // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsVisible
            match prevValueOpt, source.TryIsVisible with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsVisible <- value
            | Some _, None -> target.IsVisible <- true // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMinimumHeightRequest
            match prevValueOpt, source.TryMinimumHeightRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.MinimumHeightRequest <- value
            | Some _, None -> target.MinimumHeightRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMinimumWidthRequest
            match prevValueOpt, source.TryMinimumWidthRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.MinimumWidthRequest <- value
            | Some _, None -> target.MinimumWidthRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryOpacity
            match prevValueOpt, source.TryOpacity with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Opacity <- value
            | Some _, None -> target.Opacity <- 1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotation
            match prevValueOpt, source.TryRotation with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Rotation <- value
            | Some _, None -> target.Rotation <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotationX
            match prevValueOpt, source.TryRotationX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.RotationX <- value
            | Some _, None -> target.RotationX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotationY
            match prevValueOpt, source.TryRotationY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.RotationY <- value
            | Some _, None -> target.RotationY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryScale
            match prevValueOpt, source.TryScale with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Scale <- value
            | Some _, None -> target.Scale <- 1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryStyle
            match prevValueOpt, source.TryStyle with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Style <- value
            | Some _, None -> target.Style <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryTranslationX
            match prevValueOpt, source.TryTranslationX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.TranslationX <- value
            | Some _, None -> target.TranslationX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryTranslationY
            match prevValueOpt, source.TryTranslationY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.TranslationY <- value
            | Some _, None -> target.TranslationY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryWidthRequest
            match prevValueOpt, source.TryWidthRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.WidthRequest <- value
            | Some _, None -> target.WidthRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryClassId
            match prevValueOpt, source.TryClassId with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.ClassId <- value
            | Some _, None -> target.ClassId <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryStyleId
            match prevValueOpt, source.TryStyleId with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.StyleId <- value
            | Some _, None -> target.StyleId <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
        new XamlElement(typeof<Xamarin.Forms.ContentPage>, create, apply, Map.ofArray attribs)

    /// Describes a MasterDetailPage in the view
    static member MasterDetailPage(?master: XamlElement, ?detail: XamlElement, ?isGestureEnabled: bool, ?isPresented: bool, ?masterBehavior: Xamarin.Forms.MasterBehavior, ?isPresentedChanged: bool -> unit, ?title: string, ?padding: double, ?anchorX: double, ?anchorY: double, ?backgroundColor: Xamarin.Forms.Color, ?heightRequest: double, ?inputTransparent: bool, ?isEnabled: bool, ?isVisible: bool, ?minimumHeightRequest: double, ?minimumWidthRequest: double, ?opacity: double, ?rotation: double, ?rotationX: double, ?rotationY: double, ?scale: double, ?style: Xamarin.Forms.Style, ?translationX: double, ?translationY: double, ?widthRequest: double, ?classId: string, ?styleId: string) = 
        let attribs = [| 
            match master with None -> () | Some v -> yield ("Master", box ((v))) 
            match detail with None -> () | Some v -> yield ("Detail", box ((v))) 
            match isGestureEnabled with None -> () | Some v -> yield ("IsGestureEnabled", box ((v))) 
            match isPresented with None -> () | Some v -> yield ("IsPresented", box ((v))) 
            match masterBehavior with None -> () | Some v -> yield ("MasterBehavior", box ((v))) 
            match isPresentedChanged with None -> () | Some v -> yield ("IsPresentedChanged", box ((fun f -> System.EventHandler(fun sender args -> f (sender :?> Xamarin.Forms.MasterDetailPage).IsPresented))(v))) 
            match title with None -> () | Some v -> yield ("Title", box ((v))) 
            match padding with None -> () | Some v -> yield ("Padding", box (makeThickness(v))) 
            match anchorX with None -> () | Some v -> yield ("AnchorX", box ((v))) 
            match anchorY with None -> () | Some v -> yield ("AnchorY", box ((v))) 
            match backgroundColor with None -> () | Some v -> yield ("BackgroundColor", box ((v))) 
            match heightRequest with None -> () | Some v -> yield ("HeightRequest", box ((v))) 
            match inputTransparent with None -> () | Some v -> yield ("InputTransparent", box ((v))) 
            match isEnabled with None -> () | Some v -> yield ("IsEnabled", box ((v))) 
            match isVisible with None -> () | Some v -> yield ("IsVisible", box ((v))) 
            match minimumHeightRequest with None -> () | Some v -> yield ("MinimumHeightRequest", box ((v))) 
            match minimumWidthRequest with None -> () | Some v -> yield ("MinimumWidthRequest", box ((v))) 
            match opacity with None -> () | Some v -> yield ("Opacity", box ((v))) 
            match rotation with None -> () | Some v -> yield ("Rotation", box ((v))) 
            match rotationX with None -> () | Some v -> yield ("RotationX", box ((v))) 
            match rotationY with None -> () | Some v -> yield ("RotationY", box ((v))) 
            match scale with None -> () | Some v -> yield ("Scale", box ((v))) 
            match style with None -> () | Some v -> yield ("Style", box ((v))) 
            match translationX with None -> () | Some v -> yield ("TranslationX", box ((v))) 
            match translationY with None -> () | Some v -> yield ("TranslationY", box ((v))) 
            match widthRequest with None -> () | Some v -> yield ("WidthRequest", box ((v))) 
            match classId with None -> () | Some v -> yield ("ClassId", box ((v))) 
            match styleId with None -> () | Some v -> yield ("StyleId", box ((v))) 
          |]

        let create () =
            box (new Xamarin.Forms.MasterDetailPage())

        let apply (prevOpt: XamlElement option) (source: XamlElement) (target:obj) = 
            let target = (target :?> Xamarin.Forms.MasterDetailPage)
            let prevChildOpt = match prevOpt with None -> None | Some prev -> prev.TryMaster
            match prevChildOpt, source.TryMaster with
            // For structured objects, amortize on reference equality
            | Some prevChild, Some newChild when System.Object.ReferenceEquals(prevChild, newChild) -> ()
            | Some prevChild, Some newChild ->
                newChild.ApplyIncremental(prevChild, target.Master)
            | None, Some newChild ->
                target.Master <- newChild.CreateAsPage()
            | Some _, None ->
                target.Master <- null;
            | None, None -> ()
            let prevChildOpt = match prevOpt with None -> None | Some prev -> prev.TryDetail
            match prevChildOpt, source.TryDetail with
            // For structured objects, amortize on reference equality
            | Some prevChild, Some newChild when System.Object.ReferenceEquals(prevChild, newChild) -> ()
            | Some prevChild, Some newChild ->
                newChild.ApplyIncremental(prevChild, target.Detail)
            | None, Some newChild ->
                target.Detail <- newChild.CreateAsPage()
            | Some _, None ->
                target.Detail <- null;
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsGestureEnabled
            match prevValueOpt, source.TryIsGestureEnabled with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsGestureEnabled <- value
            | Some _, None -> target.IsGestureEnabled <- true // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsPresented
            match prevValueOpt, source.TryIsPresented with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsPresented <- value
            | Some _, None -> target.IsPresented <- true // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMasterBehavior
            match prevValueOpt, source.TryMasterBehavior with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.MasterBehavior <- value
            | Some _, None -> target.MasterBehavior <- Xamarin.Forms.MasterBehavior.Default // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsPresentedChanged
            match prevValueOpt, source.TryIsPresentedChanged with
            | Some prevValue, Some value when System.Object.ReferenceEquals(prevValue, value) -> ()
            | Some prevValue, Some value -> target.IsPresentedChanged.RemoveHandler(prevValue); target.IsPresentedChanged.AddHandler(value)
            | None, Some value -> target.IsPresentedChanged.AddHandler(value)
            | Some prevValue, None -> target.IsPresentedChanged.RemoveHandler(prevValue)
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryTitle
            match prevValueOpt, source.TryTitle with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Title <- value
            | Some _, None -> target.Title <- "" // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryPadding
            match prevValueOpt, source.TryPadding with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Padding <- value
            | Some _, None -> target.Padding <- Unchecked.defaultof<Xamarin.Forms.Thickness> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryAnchorX
            match prevValueOpt, source.TryAnchorX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.AnchorX <- value
            | Some _, None -> target.AnchorX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryAnchorY
            match prevValueOpt, source.TryAnchorY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.AnchorY <- value
            | Some _, None -> target.AnchorY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryBackgroundColor
            match prevValueOpt, source.TryBackgroundColor with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.BackgroundColor <- value
            | Some _, None -> target.BackgroundColor <- Xamarin.Forms.Color.Default // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryHeightRequest
            match prevValueOpt, source.TryHeightRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.HeightRequest <- value
            | Some _, None -> target.HeightRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryInputTransparent
            match prevValueOpt, source.TryInputTransparent with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.InputTransparent <- value
            | Some _, None -> target.InputTransparent <- false // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsEnabled
            match prevValueOpt, source.TryIsEnabled with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsEnabled <- value
            | Some _, None -> target.IsEnabled <- true // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsVisible
            match prevValueOpt, source.TryIsVisible with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsVisible <- value
            | Some _, None -> target.IsVisible <- true // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMinimumHeightRequest
            match prevValueOpt, source.TryMinimumHeightRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.MinimumHeightRequest <- value
            | Some _, None -> target.MinimumHeightRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMinimumWidthRequest
            match prevValueOpt, source.TryMinimumWidthRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.MinimumWidthRequest <- value
            | Some _, None -> target.MinimumWidthRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryOpacity
            match prevValueOpt, source.TryOpacity with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Opacity <- value
            | Some _, None -> target.Opacity <- 1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotation
            match prevValueOpt, source.TryRotation with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Rotation <- value
            | Some _, None -> target.Rotation <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotationX
            match prevValueOpt, source.TryRotationX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.RotationX <- value
            | Some _, None -> target.RotationX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotationY
            match prevValueOpt, source.TryRotationY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.RotationY <- value
            | Some _, None -> target.RotationY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryScale
            match prevValueOpt, source.TryScale with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Scale <- value
            | Some _, None -> target.Scale <- 1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryStyle
            match prevValueOpt, source.TryStyle with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Style <- value
            | Some _, None -> target.Style <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryTranslationX
            match prevValueOpt, source.TryTranslationX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.TranslationX <- value
            | Some _, None -> target.TranslationX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryTranslationY
            match prevValueOpt, source.TryTranslationY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.TranslationY <- value
            | Some _, None -> target.TranslationY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryWidthRequest
            match prevValueOpt, source.TryWidthRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.WidthRequest <- value
            | Some _, None -> target.WidthRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryClassId
            match prevValueOpt, source.TryClassId with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.ClassId <- value
            | Some _, None -> target.ClassId <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryStyleId
            match prevValueOpt, source.TryStyleId with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.StyleId <- value
            | Some _, None -> target.StyleId <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
        new XamlElement(typeof<Xamarin.Forms.MasterDetailPage>, create, apply, Map.ofArray attribs)

    /// Describes a Cell in the view
    static member Cell(?height: double, ?isEnabled: bool, ?classId: string, ?styleId: string) = 
        let attribs = [| 
            match height with None -> () | Some v -> yield ("Height", box ((v))) 
            match isEnabled with None -> () | Some v -> yield ("IsEnabled", box ((v))) 
            match classId with None -> () | Some v -> yield ("ClassId", box ((v))) 
            match styleId with None -> () | Some v -> yield ("StyleId", box ((v))) 
          |]

        let create () =
            failwith "can'tdef create Xamarin.Forms.Cell"

        let apply (prevOpt: XamlElement option) (source: XamlElement) (target:obj) = 
            let target = (target :?> Xamarin.Forms.Cell)
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryHeight
            match prevValueOpt, source.TryHeight with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Height <- value
            | Some _, None -> target.Height <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsEnabled
            match prevValueOpt, source.TryIsEnabled with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsEnabled <- value
            | Some _, None -> target.IsEnabled <- true // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryClassId
            match prevValueOpt, source.TryClassId with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.ClassId <- value
            | Some _, None -> target.ClassId <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryStyleId
            match prevValueOpt, source.TryStyleId with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.StyleId <- value
            | Some _, None -> target.StyleId <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
        new XamlElement(typeof<Xamarin.Forms.Cell>, create, apply, Map.ofArray attribs)

    /// Describes a TextCell in the view
    static member TextCell(?text: string, ?detail: string, ?textColor: Xamarin.Forms.Color, ?detailColor: Xamarin.Forms.Color, ?command: unit -> unit, ?commandParameter: System.Object, ?height: double, ?isEnabled: bool, ?classId: string, ?styleId: string) = 
        let attribs = [| 
            match text with None -> () | Some v -> yield ("Text", box ((v))) 
            match detail with None -> () | Some v -> yield ("TextDetail", box ((v))) 
            match textColor with None -> () | Some v -> yield ("TextColor", box ((v))) 
            match detailColor with None -> () | Some v -> yield ("TextDetailColor", box ((v))) 
            match command with None -> () | Some v -> yield ("Command", box (makeCommand(v))) 
            match commandParameter with None -> () | Some v -> yield ("CommandParameter", box ((v))) 
            match height with None -> () | Some v -> yield ("Height", box ((v))) 
            match isEnabled with None -> () | Some v -> yield ("IsEnabled", box ((v))) 
            match classId with None -> () | Some v -> yield ("ClassId", box ((v))) 
            match styleId with None -> () | Some v -> yield ("StyleId", box ((v))) 
          |]

        let create () =
            box (new Xamarin.Forms.TextCell())

        let apply (prevOpt: XamlElement option) (source: XamlElement) (target:obj) = 
            let target = (target :?> Xamarin.Forms.TextCell)
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryText
            match prevValueOpt, source.TryText with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Text <- value
            | Some _, None -> target.Text <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryTextDetail
            match prevValueOpt, source.TryTextDetail with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Detail <- value
            | Some _, None -> target.Detail <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryTextColor
            match prevValueOpt, source.TryTextColor with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.TextColor <- value
            | Some _, None -> target.TextColor <- Xamarin.Forms.Color.Default // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryTextDetailColor
            match prevValueOpt, source.TryTextDetailColor with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.DetailColor <- value
            | Some _, None -> target.DetailColor <- Xamarin.Forms.Color.Default // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryCommand
            match prevValueOpt, source.TryCommand with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Command <- value
            | Some _, None -> target.Command <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryCommandParameter
            match prevValueOpt, source.TryCommandParameter with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.CommandParameter <- value
            | Some _, None -> target.CommandParameter <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryHeight
            match prevValueOpt, source.TryHeight with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Height <- value
            | Some _, None -> target.Height <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsEnabled
            match prevValueOpt, source.TryIsEnabled with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsEnabled <- value
            | Some _, None -> target.IsEnabled <- true // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryClassId
            match prevValueOpt, source.TryClassId with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.ClassId <- value
            | Some _, None -> target.ClassId <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryStyleId
            match prevValueOpt, source.TryStyleId with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.StyleId <- value
            | Some _, None -> target.StyleId <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
        new XamlElement(typeof<Xamarin.Forms.TextCell>, create, apply, Map.ofArray attribs)

    /// Describes a ImageCell in the view
    static member ImageCell(?imageSource: Xamarin.Forms.ImageSource, ?text: string, ?detail: string, ?textColor: Xamarin.Forms.Color, ?detailColor: Xamarin.Forms.Color, ?command: unit -> unit, ?commandParameter: System.Object, ?height: double, ?isEnabled: bool, ?classId: string, ?styleId: string) = 
        let attribs = [| 
            match imageSource with None -> () | Some v -> yield ("ImageSource", box ((v))) 
            match text with None -> () | Some v -> yield ("Text", box ((v))) 
            match detail with None -> () | Some v -> yield ("TextDetail", box ((v))) 
            match textColor with None -> () | Some v -> yield ("TextColor", box ((v))) 
            match detailColor with None -> () | Some v -> yield ("TextDetailColor", box ((v))) 
            match command with None -> () | Some v -> yield ("Command", box (makeCommand(v))) 
            match commandParameter with None -> () | Some v -> yield ("CommandParameter", box ((v))) 
            match height with None -> () | Some v -> yield ("Height", box ((v))) 
            match isEnabled with None -> () | Some v -> yield ("IsEnabled", box ((v))) 
            match classId with None -> () | Some v -> yield ("ClassId", box ((v))) 
            match styleId with None -> () | Some v -> yield ("StyleId", box ((v))) 
          |]

        let create () =
            box (new Xamarin.Forms.ImageCell())

        let apply (prevOpt: XamlElement option) (source: XamlElement) (target:obj) = 
            let target = (target :?> Xamarin.Forms.ImageCell)
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryImageSource
            match prevValueOpt, source.TryImageSource with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.ImageSource <- value
            | Some _, None -> target.ImageSource <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryText
            match prevValueOpt, source.TryText with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Text <- value
            | Some _, None -> target.Text <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryTextDetail
            match prevValueOpt, source.TryTextDetail with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Detail <- value
            | Some _, None -> target.Detail <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryTextColor
            match prevValueOpt, source.TryTextColor with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.TextColor <- value
            | Some _, None -> target.TextColor <- Xamarin.Forms.Color.Default // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryTextDetailColor
            match prevValueOpt, source.TryTextDetailColor with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.DetailColor <- value
            | Some _, None -> target.DetailColor <- Xamarin.Forms.Color.Default // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryCommand
            match prevValueOpt, source.TryCommand with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Command <- value
            | Some _, None -> target.Command <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryCommandParameter
            match prevValueOpt, source.TryCommandParameter with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.CommandParameter <- value
            | Some _, None -> target.CommandParameter <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryHeight
            match prevValueOpt, source.TryHeight with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Height <- value
            | Some _, None -> target.Height <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsEnabled
            match prevValueOpt, source.TryIsEnabled with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsEnabled <- value
            | Some _, None -> target.IsEnabled <- true // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryClassId
            match prevValueOpt, source.TryClassId with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.ClassId <- value
            | Some _, None -> target.ClassId <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryStyleId
            match prevValueOpt, source.TryStyleId with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.StyleId <- value
            | Some _, None -> target.StyleId <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
        new XamlElement(typeof<Xamarin.Forms.ImageCell>, create, apply, Map.ofArray attribs)

    /// Describes a ViewCell in the view
    static member ViewCell(?view: XamlElement, ?height: double, ?isEnabled: bool, ?classId: string, ?styleId: string) = 
        let attribs = [| 
            match view with None -> () | Some v -> yield ("View", box ((v))) 
            match height with None -> () | Some v -> yield ("Height", box ((v))) 
            match isEnabled with None -> () | Some v -> yield ("IsEnabled", box ((v))) 
            match classId with None -> () | Some v -> yield ("ClassId", box ((v))) 
            match styleId with None -> () | Some v -> yield ("StyleId", box ((v))) 
          |]

        let create () =
            box (new Xamarin.Forms.ViewCell())

        let apply (prevOpt: XamlElement option) (source: XamlElement) (target:obj) = 
            let target = (target :?> Xamarin.Forms.ViewCell)
            let prevChildOpt = match prevOpt with None -> None | Some prev -> prev.TryView
            match prevChildOpt, source.TryView with
            // For structured objects, amortize on reference equality
            | Some prevChild, Some newChild when System.Object.ReferenceEquals(prevChild, newChild) -> ()
            | Some prevChild, Some newChild ->
                newChild.ApplyIncremental(prevChild, target.View)
            | None, Some newChild ->
                target.View <- newChild.CreateAsView()
            | Some _, None ->
                target.View <- null;
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryHeight
            match prevValueOpt, source.TryHeight with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Height <- value
            | Some _, None -> target.Height <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsEnabled
            match prevValueOpt, source.TryIsEnabled with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsEnabled <- value
            | Some _, None -> target.IsEnabled <- true // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryClassId
            match prevValueOpt, source.TryClassId with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.ClassId <- value
            | Some _, None -> target.ClassId <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryStyleId
            match prevValueOpt, source.TryStyleId with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.StyleId <- value
            | Some _, None -> target.StyleId <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
        new XamlElement(typeof<Xamarin.Forms.ViewCell>, create, apply, Map.ofArray attribs)

    /// Describes a ListView in the view
    static member ListView(?items: XamlElement list, ?footer: System.Object, ?hasUnevenRows: bool, ?header: System.Object, ?headerTemplate: Xamarin.Forms.DataTemplate, ?isGroupingEnabled: bool, ?isPullToRefreshEnabled: bool, ?isRefreshing: bool, ?refreshCommand: unit -> unit, ?rowHeight: int, ?selectedItem: int option, ?separatorVisibility: Xamarin.Forms.SeparatorVisibility, ?separatorColor: Xamarin.Forms.Color, ?itemAppearing: Xamarin.Forms.ItemVisibilityEventArgs -> unit, ?itemDisappearing: Xamarin.Forms.ItemVisibilityEventArgs -> unit, ?itemSelected: int option -> unit, ?itemTapped: Xamarin.Forms.ItemTappedEventArgs -> unit, ?refreshing: unit -> unit, ?horizontalOptions: Xamarin.Forms.LayoutOptions, ?verticalOptions: Xamarin.Forms.LayoutOptions, ?margin: obj, ?gestureRecognizers: XamlElement list, ?anchorX: double, ?anchorY: double, ?backgroundColor: Xamarin.Forms.Color, ?heightRequest: double, ?inputTransparent: bool, ?isEnabled: bool, ?isVisible: bool, ?minimumHeightRequest: double, ?minimumWidthRequest: double, ?opacity: double, ?rotation: double, ?rotationX: double, ?rotationY: double, ?scale: double, ?style: Xamarin.Forms.Style, ?translationX: double, ?translationY: double, ?widthRequest: double, ?classId: string, ?styleId: string) = 
        let attribs = [| 
            match items with None -> () | Some v -> yield ("ListViewItems", box (Array.ofList(v))) 
            match footer with None -> () | Some v -> yield ("Footer", box ((v))) 
            match hasUnevenRows with None -> () | Some v -> yield ("HasUnevenRows", box ((v))) 
            match header with None -> () | Some v -> yield ("Header", box ((v))) 
            match headerTemplate with None -> () | Some v -> yield ("HeaderTemplate", box ((v))) 
            match isGroupingEnabled with None -> () | Some v -> yield ("IsGroupingEnabled", box ((v))) 
            match isPullToRefreshEnabled with None -> () | Some v -> yield ("IsPullToRefreshEnabled", box ((v))) 
            match isRefreshing with None -> () | Some v -> yield ("IsRefreshing", box ((v))) 
            match refreshCommand with None -> () | Some v -> yield ("RefreshCommand", box (makeCommand(v))) 
            match rowHeight with None -> () | Some v -> yield ("RowHeight", box ((v))) 
            match selectedItem with None -> () | Some v -> yield ("ListView_SelectedItem", box ((v))) 
            match separatorVisibility with None -> () | Some v -> yield ("SeparatorVisibility", box ((v))) 
            match separatorColor with None -> () | Some v -> yield ("SeparatorColor", box ((v))) 
            match itemAppearing with None -> () | Some v -> yield ("ItemAppearing", box ((fun f -> System.EventHandler<Xamarin.Forms.ItemVisibilityEventArgs>(fun _sender args -> f args))(v))) 
            match itemDisappearing with None -> () | Some v -> yield ("ItemDisappearing", box ((fun f -> System.EventHandler<Xamarin.Forms.ItemVisibilityEventArgs>(fun _sender args -> f args))(v))) 
            match itemSelected with None -> () | Some v -> yield ("ListView_ItemSelected", box ((fun f -> System.EventHandler<Xamarin.Forms.SelectedItemChangedEventArgs>(fun sender args -> f (args.SelectedItem |> Option.ofObj |> Option.map unbox<ListElementData<XamlElement>> |> Option.bind (fun item -> let items = (sender :?> Xamarin.Forms.ListView).ItemsSource :?> System.Collections.Generic.IList<ListElementData<XamlElement>> in items |> Seq.tryFindIndex (fun item2 -> System.Object.ReferenceEquals(item.Key, item2.Key))))))(v))) 
            match itemTapped with None -> () | Some v -> yield ("ItemTapped", box ((fun f -> System.EventHandler<Xamarin.Forms.ItemTappedEventArgs>(fun _sender args -> f args))(v))) 
            match refreshing with None -> () | Some v -> yield ("Refreshing", box ((fun f -> System.EventHandler(fun sender args -> f ()))(v))) 
            match horizontalOptions with None -> () | Some v -> yield ("HorizontalOptions", box ((v))) 
            match verticalOptions with None -> () | Some v -> yield ("VerticalOptions", box ((v))) 
            match margin with None -> () | Some v -> yield ("Margin", box (makeThickness(v))) 
            match gestureRecognizers with None -> () | Some v -> yield ("GestureRecognizers", box (Array.ofList(v))) 
            match anchorX with None -> () | Some v -> yield ("AnchorX", box ((v))) 
            match anchorY with None -> () | Some v -> yield ("AnchorY", box ((v))) 
            match backgroundColor with None -> () | Some v -> yield ("BackgroundColor", box ((v))) 
            match heightRequest with None -> () | Some v -> yield ("HeightRequest", box ((v))) 
            match inputTransparent with None -> () | Some v -> yield ("InputTransparent", box ((v))) 
            match isEnabled with None -> () | Some v -> yield ("IsEnabled", box ((v))) 
            match isVisible with None -> () | Some v -> yield ("IsVisible", box ((v))) 
            match minimumHeightRequest with None -> () | Some v -> yield ("MinimumHeightRequest", box ((v))) 
            match minimumWidthRequest with None -> () | Some v -> yield ("MinimumWidthRequest", box ((v))) 
            match opacity with None -> () | Some v -> yield ("Opacity", box ((v))) 
            match rotation with None -> () | Some v -> yield ("Rotation", box ((v))) 
            match rotationX with None -> () | Some v -> yield ("RotationX", box ((v))) 
            match rotationY with None -> () | Some v -> yield ("RotationY", box ((v))) 
            match scale with None -> () | Some v -> yield ("Scale", box ((v))) 
            match style with None -> () | Some v -> yield ("Style", box ((v))) 
            match translationX with None -> () | Some v -> yield ("TranslationX", box ((v))) 
            match translationY with None -> () | Some v -> yield ("TranslationY", box ((v))) 
            match widthRequest with None -> () | Some v -> yield ("WidthRequest", box ((v))) 
            match classId with None -> () | Some v -> yield ("ClassId", box ((v))) 
            match styleId with None -> () | Some v -> yield ("StyleId", box ((v))) 
          |]

        let create () =
            box (new Elmish.XamarinForms.DynamicViews.CustomListView())

        let apply (prevOpt: XamlElement option) (source: XamlElement) (target:obj) = 
            let target = (target :?> Xamarin.Forms.ListView)
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryListViewItems
            match prevValueOpt, source.TryListViewItems with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> applyToListViewItems prevValueOpt value target
            | Some _, None -> target.ItemsSource <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryFooter
            match prevValueOpt, source.TryFooter with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Footer <- value
            | Some _, None -> target.Footer <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryHasUnevenRows
            match prevValueOpt, source.TryHasUnevenRows with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.HasUnevenRows <- value
            | Some _, None -> target.HasUnevenRows <- false // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryHeader
            match prevValueOpt, source.TryHeader with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Header <- value
            | Some _, None -> target.Header <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryHeaderTemplate
            match prevValueOpt, source.TryHeaderTemplate with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.HeaderTemplate <- value
            | Some _, None -> target.HeaderTemplate <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsGroupingEnabled
            match prevValueOpt, source.TryIsGroupingEnabled with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsGroupingEnabled <- value
            | Some _, None -> target.IsGroupingEnabled <- false // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsPullToRefreshEnabled
            match prevValueOpt, source.TryIsPullToRefreshEnabled with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsPullToRefreshEnabled <- value
            | Some _, None -> target.IsPullToRefreshEnabled <- false // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsRefreshing
            match prevValueOpt, source.TryIsRefreshing with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsRefreshing <- value
            | Some _, None -> target.IsRefreshing <- false // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRefreshCommand
            match prevValueOpt, source.TryRefreshCommand with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.RefreshCommand <- value
            | Some _, None -> target.RefreshCommand <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRowHeight
            match prevValueOpt, source.TryRowHeight with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.RowHeight <- value
            | Some _, None -> target.RowHeight <- -1 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryListView_SelectedItem
            match prevValueOpt, source.TryListView_SelectedItem with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.SelectedItem <- (match value with None -> null | Some i -> let items = target.ItemsSource :?> System.Collections.Generic.IList<ListElementData<XamlElement>> in if i >= 0 && i < items.Count then items.[i] else null)
            | Some _, None -> target.SelectedItem <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TrySeparatorVisibility
            match prevValueOpt, source.TrySeparatorVisibility with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.SeparatorVisibility <- value
            | Some _, None -> target.SeparatorVisibility <- Xamarin.Forms.SeparatorVisibility.Default // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TrySeparatorColor
            match prevValueOpt, source.TrySeparatorColor with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.SeparatorColor <- value
            | Some _, None -> target.SeparatorColor <- Xamarin.Forms.Color.Default // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryItemAppearing
            match prevValueOpt, source.TryItemAppearing with
            | Some prevValue, Some value when System.Object.ReferenceEquals(prevValue, value) -> ()
            | Some prevValue, Some value -> target.ItemAppearing.RemoveHandler(prevValue); target.ItemAppearing.AddHandler(value)
            | None, Some value -> target.ItemAppearing.AddHandler(value)
            | Some prevValue, None -> target.ItemAppearing.RemoveHandler(prevValue)
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryItemDisappearing
            match prevValueOpt, source.TryItemDisappearing with
            | Some prevValue, Some value when System.Object.ReferenceEquals(prevValue, value) -> ()
            | Some prevValue, Some value -> target.ItemDisappearing.RemoveHandler(prevValue); target.ItemDisappearing.AddHandler(value)
            | None, Some value -> target.ItemDisappearing.AddHandler(value)
            | Some prevValue, None -> target.ItemDisappearing.RemoveHandler(prevValue)
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryListView_ItemSelected
            match prevValueOpt, source.TryListView_ItemSelected with
            | Some prevValue, Some value when System.Object.ReferenceEquals(prevValue, value) -> ()
            | Some prevValue, Some value -> target.ItemSelected.RemoveHandler(prevValue); target.ItemSelected.AddHandler(value)
            | None, Some value -> target.ItemSelected.AddHandler(value)
            | Some prevValue, None -> target.ItemSelected.RemoveHandler(prevValue)
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryItemTapped
            match prevValueOpt, source.TryItemTapped with
            | Some prevValue, Some value when System.Object.ReferenceEquals(prevValue, value) -> ()
            | Some prevValue, Some value -> target.ItemTapped.RemoveHandler(prevValue); target.ItemTapped.AddHandler(value)
            | None, Some value -> target.ItemTapped.AddHandler(value)
            | Some prevValue, None -> target.ItemTapped.RemoveHandler(prevValue)
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRefreshing
            match prevValueOpt, source.TryRefreshing with
            | Some prevValue, Some value when System.Object.ReferenceEquals(prevValue, value) -> ()
            | Some prevValue, Some value -> target.Refreshing.RemoveHandler(prevValue); target.Refreshing.AddHandler(value)
            | None, Some value -> target.Refreshing.AddHandler(value)
            | Some prevValue, None -> target.Refreshing.RemoveHandler(prevValue)
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryHorizontalOptions
            match prevValueOpt, source.TryHorizontalOptions with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.HorizontalOptions <- value
            | Some _, None -> target.HorizontalOptions <- Unchecked.defaultof<Xamarin.Forms.LayoutOptions> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryVerticalOptions
            match prevValueOpt, source.TryVerticalOptions with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.VerticalOptions <- value
            | Some _, None -> target.VerticalOptions <- Unchecked.defaultof<Xamarin.Forms.LayoutOptions> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMargin
            match prevValueOpt, source.TryMargin with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Margin <- value
            | Some _, None -> target.Margin <- Unchecked.defaultof<Xamarin.Forms.Thickness> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevCollOpt = match prevOpt with None -> None | Some prev -> prev.TryGestureRecognizers
            match prevCollOpt, source.TryGestureRecognizers with
            // For structured objects, amortize on reference equality
            | Some prevColl, Some newColl when System.Object.ReferenceEquals(prevColl, newColl) -> ()
            | _, Some coll when coll <> null && coll.Length > 0 ->
                applyToIList
                    prevCollOpt
                    coll
                    target.GestureRecognizers
                    (fun (x:XamlElement) -> x.CreateAsIGestureRecognizer())
                    (fun _ _ _ -> ())
                    (fun (prevChild:XamlElement) (newChild:XamlElement) -> prevChild.TargetType = newChild.TargetType)
                    (fun prevChild newChild targetChild -> newChild.ApplyIncremental(prevChild, targetChild))
            | _ -> target.GestureRecognizers.Clear()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryAnchorX
            match prevValueOpt, source.TryAnchorX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.AnchorX <- value
            | Some _, None -> target.AnchorX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryAnchorY
            match prevValueOpt, source.TryAnchorY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.AnchorY <- value
            | Some _, None -> target.AnchorY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryBackgroundColor
            match prevValueOpt, source.TryBackgroundColor with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.BackgroundColor <- value
            | Some _, None -> target.BackgroundColor <- Xamarin.Forms.Color.Default // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryHeightRequest
            match prevValueOpt, source.TryHeightRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.HeightRequest <- value
            | Some _, None -> target.HeightRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryInputTransparent
            match prevValueOpt, source.TryInputTransparent with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.InputTransparent <- value
            | Some _, None -> target.InputTransparent <- false // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsEnabled
            match prevValueOpt, source.TryIsEnabled with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsEnabled <- value
            | Some _, None -> target.IsEnabled <- true // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsVisible
            match prevValueOpt, source.TryIsVisible with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsVisible <- value
            | Some _, None -> target.IsVisible <- true // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMinimumHeightRequest
            match prevValueOpt, source.TryMinimumHeightRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.MinimumHeightRequest <- value
            | Some _, None -> target.MinimumHeightRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMinimumWidthRequest
            match prevValueOpt, source.TryMinimumWidthRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.MinimumWidthRequest <- value
            | Some _, None -> target.MinimumWidthRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryOpacity
            match prevValueOpt, source.TryOpacity with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Opacity <- value
            | Some _, None -> target.Opacity <- 1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotation
            match prevValueOpt, source.TryRotation with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Rotation <- value
            | Some _, None -> target.Rotation <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotationX
            match prevValueOpt, source.TryRotationX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.RotationX <- value
            | Some _, None -> target.RotationX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotationY
            match prevValueOpt, source.TryRotationY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.RotationY <- value
            | Some _, None -> target.RotationY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryScale
            match prevValueOpt, source.TryScale with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Scale <- value
            | Some _, None -> target.Scale <- 1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryStyle
            match prevValueOpt, source.TryStyle with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Style <- value
            | Some _, None -> target.Style <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryTranslationX
            match prevValueOpt, source.TryTranslationX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.TranslationX <- value
            | Some _, None -> target.TranslationX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryTranslationY
            match prevValueOpt, source.TryTranslationY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.TranslationY <- value
            | Some _, None -> target.TranslationY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryWidthRequest
            match prevValueOpt, source.TryWidthRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.WidthRequest <- value
            | Some _, None -> target.WidthRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryClassId
            match prevValueOpt, source.TryClassId with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.ClassId <- value
            | Some _, None -> target.ClassId <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryStyleId
            match prevValueOpt, source.TryStyleId with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.StyleId <- value
            | Some _, None -> target.StyleId <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
        new XamlElement(typeof<Xamarin.Forms.ListView>, create, apply, Map.ofArray attribs)

    /// Describes a ListViewGrouped in the view
    static member ListViewGrouped(?items: (XamlElement * XamlElement list) list, ?footer: System.Object, ?hasUnevenRows: bool, ?header: System.Object, ?isGroupingEnabled: bool, ?isPullToRefreshEnabled: bool, ?isRefreshing: bool, ?refreshCommand: unit -> unit, ?rowHeight: int, ?selectedItem: (int * int) option, ?separatorVisibility: Xamarin.Forms.SeparatorVisibility, ?separatorColor: Xamarin.Forms.Color, ?itemAppearing: Xamarin.Forms.ItemVisibilityEventArgs -> unit, ?itemDisappearing: Xamarin.Forms.ItemVisibilityEventArgs -> unit, ?itemSelected: (int * int) option -> unit, ?itemTapped: Xamarin.Forms.ItemTappedEventArgs -> unit, ?refreshing: unit -> unit, ?horizontalOptions: Xamarin.Forms.LayoutOptions, ?verticalOptions: Xamarin.Forms.LayoutOptions, ?margin: obj, ?gestureRecognizers: XamlElement list, ?anchorX: double, ?anchorY: double, ?backgroundColor: Xamarin.Forms.Color, ?heightRequest: double, ?inputTransparent: bool, ?isEnabled: bool, ?isVisible: bool, ?minimumHeightRequest: double, ?minimumWidthRequest: double, ?opacity: double, ?rotation: double, ?rotationX: double, ?rotationY: double, ?scale: double, ?style: Xamarin.Forms.Style, ?translationX: double, ?translationY: double, ?widthRequest: double, ?classId: string, ?styleId: string) = 
        let attribs = [| 
            match items with None -> () | Some v -> yield ("GroupListViewItemsSource", box ((fun es -> es |> Array.ofList |> Array.map (fun (e,l) -> (e, Array.ofList l)))(v))) 
            match footer with None -> () | Some v -> yield ("Footer", box ((v))) 
            match hasUnevenRows with None -> () | Some v -> yield ("HasUnevenRows", box ((v))) 
            match header with None -> () | Some v -> yield ("Header", box ((v))) 
            match isGroupingEnabled with None -> () | Some v -> yield ("IsGroupingEnabled", box ((v))) 
            match isPullToRefreshEnabled with None -> () | Some v -> yield ("IsPullToRefreshEnabled", box ((v))) 
            match isRefreshing with None -> () | Some v -> yield ("IsRefreshing", box ((v))) 
            match refreshCommand with None -> () | Some v -> yield ("RefreshCommand", box (makeCommand(v))) 
            match rowHeight with None -> () | Some v -> yield ("RowHeight", box ((v))) 
            match selectedItem with None -> () | Some v -> yield ("ListViewGrouped_SelectedItem", box ((v))) 
            match separatorVisibility with None -> () | Some v -> yield ("SeparatorVisibility", box ((v))) 
            match separatorColor with None -> () | Some v -> yield ("SeparatorColor", box ((v))) 
            match itemAppearing with None -> () | Some v -> yield ("ItemAppearing", box ((fun f -> System.EventHandler<Xamarin.Forms.ItemVisibilityEventArgs>(fun _sender args -> f args))(v))) 
            match itemDisappearing with None -> () | Some v -> yield ("ItemDisappearing", box ((fun f -> System.EventHandler<Xamarin.Forms.ItemVisibilityEventArgs>(fun _sender args -> f args))(v))) 
            match itemSelected with None -> () | Some v -> yield ("ListViewGrouped_ItemSelected", box ((fun f -> System.EventHandler<Xamarin.Forms.SelectedItemChangedEventArgs>(fun sender args -> f (args.SelectedItem |> Option.ofObj |> Option.map unbox<ListElementData<XamlElement>> |> Option.bind (fun item -> let items = (sender :?> Xamarin.Forms.ListView).ItemsSource :?> System.Collections.Generic.IList<ListGroupData<XamlElement>> in Seq.indexed items |> Seq.tryPick (fun (i,items2) -> Seq.indexed items2 |> Seq.tryPick (fun (j,item2) -> if System.Object.ReferenceEquals(item.Key, item2.Key) then Some (i,j) else None))))))(v))) 
            match itemTapped with None -> () | Some v -> yield ("ItemTapped", box ((fun f -> System.EventHandler<Xamarin.Forms.ItemTappedEventArgs>(fun _sender args -> f args))(v))) 
            match refreshing with None -> () | Some v -> yield ("Refreshing", box ((fun f -> System.EventHandler(fun sender args -> f ()))(v))) 
            match horizontalOptions with None -> () | Some v -> yield ("HorizontalOptions", box ((v))) 
            match verticalOptions with None -> () | Some v -> yield ("VerticalOptions", box ((v))) 
            match margin with None -> () | Some v -> yield ("Margin", box (makeThickness(v))) 
            match gestureRecognizers with None -> () | Some v -> yield ("GestureRecognizers", box (Array.ofList(v))) 
            match anchorX with None -> () | Some v -> yield ("AnchorX", box ((v))) 
            match anchorY with None -> () | Some v -> yield ("AnchorY", box ((v))) 
            match backgroundColor with None -> () | Some v -> yield ("BackgroundColor", box ((v))) 
            match heightRequest with None -> () | Some v -> yield ("HeightRequest", box ((v))) 
            match inputTransparent with None -> () | Some v -> yield ("InputTransparent", box ((v))) 
            match isEnabled with None -> () | Some v -> yield ("IsEnabled", box ((v))) 
            match isVisible with None -> () | Some v -> yield ("IsVisible", box ((v))) 
            match minimumHeightRequest with None -> () | Some v -> yield ("MinimumHeightRequest", box ((v))) 
            match minimumWidthRequest with None -> () | Some v -> yield ("MinimumWidthRequest", box ((v))) 
            match opacity with None -> () | Some v -> yield ("Opacity", box ((v))) 
            match rotation with None -> () | Some v -> yield ("Rotation", box ((v))) 
            match rotationX with None -> () | Some v -> yield ("RotationX", box ((v))) 
            match rotationY with None -> () | Some v -> yield ("RotationY", box ((v))) 
            match scale with None -> () | Some v -> yield ("Scale", box ((v))) 
            match style with None -> () | Some v -> yield ("Style", box ((v))) 
            match translationX with None -> () | Some v -> yield ("TranslationX", box ((v))) 
            match translationY with None -> () | Some v -> yield ("TranslationY", box ((v))) 
            match widthRequest with None -> () | Some v -> yield ("WidthRequest", box ((v))) 
            match classId with None -> () | Some v -> yield ("ClassId", box ((v))) 
            match styleId with None -> () | Some v -> yield ("StyleId", box ((v))) 
          |]

        let create () =
            box (new Elmish.XamarinForms.DynamicViews.CustomGroupListView())

        let apply (prevOpt: XamlElement option) (source: XamlElement) (target:obj) = 
            let target = (target :?> Xamarin.Forms.ListView)
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryGroupListViewItemsSource
            match prevValueOpt, source.TryGroupListViewItemsSource with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> applyToListViewGroupedItems prevValueOpt value target
            | Some _, None -> target.ItemsSource <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryFooter
            match prevValueOpt, source.TryFooter with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Footer <- value
            | Some _, None -> target.Footer <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryHasUnevenRows
            match prevValueOpt, source.TryHasUnevenRows with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.HasUnevenRows <- value
            | Some _, None -> target.HasUnevenRows <- false // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryHeader
            match prevValueOpt, source.TryHeader with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Header <- value
            | Some _, None -> target.Header <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsGroupingEnabled
            match prevValueOpt, source.TryIsGroupingEnabled with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsGroupingEnabled <- value
            | Some _, None -> target.IsGroupingEnabled <- false // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsPullToRefreshEnabled
            match prevValueOpt, source.TryIsPullToRefreshEnabled with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsPullToRefreshEnabled <- value
            | Some _, None -> target.IsPullToRefreshEnabled <- false // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsRefreshing
            match prevValueOpt, source.TryIsRefreshing with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsRefreshing <- value
            | Some _, None -> target.IsRefreshing <- false // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRefreshCommand
            match prevValueOpt, source.TryRefreshCommand with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.RefreshCommand <- value
            | Some _, None -> target.RefreshCommand <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRowHeight
            match prevValueOpt, source.TryRowHeight with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.RowHeight <- value
            | Some _, None -> target.RowHeight <- -1 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryListViewGrouped_SelectedItem
            match prevValueOpt, source.TryListViewGrouped_SelectedItem with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.SelectedItem <- (match value with None -> null | Some (i,j) -> let items = target.ItemsSource :?> System.Collections.Generic.IList<ListGroupData<XamlElement>> in (if i >= 0 && i < items.Count then (let items2 = items.[i] in if j >= 0 && j < items2.Count then items2.[j] else null) else null))
            | Some _, None -> target.SelectedItem <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TrySeparatorVisibility
            match prevValueOpt, source.TrySeparatorVisibility with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.SeparatorVisibility <- value
            | Some _, None -> target.SeparatorVisibility <- Xamarin.Forms.SeparatorVisibility.Default // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TrySeparatorColor
            match prevValueOpt, source.TrySeparatorColor with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.SeparatorColor <- value
            | Some _, None -> target.SeparatorColor <- Xamarin.Forms.Color.Default // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryItemAppearing
            match prevValueOpt, source.TryItemAppearing with
            | Some prevValue, Some value when System.Object.ReferenceEquals(prevValue, value) -> ()
            | Some prevValue, Some value -> target.ItemAppearing.RemoveHandler(prevValue); target.ItemAppearing.AddHandler(value)
            | None, Some value -> target.ItemAppearing.AddHandler(value)
            | Some prevValue, None -> target.ItemAppearing.RemoveHandler(prevValue)
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryItemDisappearing
            match prevValueOpt, source.TryItemDisappearing with
            | Some prevValue, Some value when System.Object.ReferenceEquals(prevValue, value) -> ()
            | Some prevValue, Some value -> target.ItemDisappearing.RemoveHandler(prevValue); target.ItemDisappearing.AddHandler(value)
            | None, Some value -> target.ItemDisappearing.AddHandler(value)
            | Some prevValue, None -> target.ItemDisappearing.RemoveHandler(prevValue)
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryListViewGrouped_ItemSelected
            match prevValueOpt, source.TryListViewGrouped_ItemSelected with
            | Some prevValue, Some value when System.Object.ReferenceEquals(prevValue, value) -> ()
            | Some prevValue, Some value -> target.ItemSelected.RemoveHandler(prevValue); target.ItemSelected.AddHandler(value)
            | None, Some value -> target.ItemSelected.AddHandler(value)
            | Some prevValue, None -> target.ItemSelected.RemoveHandler(prevValue)
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryItemTapped
            match prevValueOpt, source.TryItemTapped with
            | Some prevValue, Some value when System.Object.ReferenceEquals(prevValue, value) -> ()
            | Some prevValue, Some value -> target.ItemTapped.RemoveHandler(prevValue); target.ItemTapped.AddHandler(value)
            | None, Some value -> target.ItemTapped.AddHandler(value)
            | Some prevValue, None -> target.ItemTapped.RemoveHandler(prevValue)
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRefreshing
            match prevValueOpt, source.TryRefreshing with
            | Some prevValue, Some value when System.Object.ReferenceEquals(prevValue, value) -> ()
            | Some prevValue, Some value -> target.Refreshing.RemoveHandler(prevValue); target.Refreshing.AddHandler(value)
            | None, Some value -> target.Refreshing.AddHandler(value)
            | Some prevValue, None -> target.Refreshing.RemoveHandler(prevValue)
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryHorizontalOptions
            match prevValueOpt, source.TryHorizontalOptions with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.HorizontalOptions <- value
            | Some _, None -> target.HorizontalOptions <- Unchecked.defaultof<Xamarin.Forms.LayoutOptions> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryVerticalOptions
            match prevValueOpt, source.TryVerticalOptions with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.VerticalOptions <- value
            | Some _, None -> target.VerticalOptions <- Unchecked.defaultof<Xamarin.Forms.LayoutOptions> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMargin
            match prevValueOpt, source.TryMargin with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Margin <- value
            | Some _, None -> target.Margin <- Unchecked.defaultof<Xamarin.Forms.Thickness> // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevCollOpt = match prevOpt with None -> None | Some prev -> prev.TryGestureRecognizers
            match prevCollOpt, source.TryGestureRecognizers with
            // For structured objects, amortize on reference equality
            | Some prevColl, Some newColl when System.Object.ReferenceEquals(prevColl, newColl) -> ()
            | _, Some coll when coll <> null && coll.Length > 0 ->
                applyToIList
                    prevCollOpt
                    coll
                    target.GestureRecognizers
                    (fun (x:XamlElement) -> x.CreateAsIGestureRecognizer())
                    (fun _ _ _ -> ())
                    (fun (prevChild:XamlElement) (newChild:XamlElement) -> prevChild.TargetType = newChild.TargetType)
                    (fun prevChild newChild targetChild -> newChild.ApplyIncremental(prevChild, targetChild))
            | _ -> target.GestureRecognizers.Clear()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryAnchorX
            match prevValueOpt, source.TryAnchorX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.AnchorX <- value
            | Some _, None -> target.AnchorX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryAnchorY
            match prevValueOpt, source.TryAnchorY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.AnchorY <- value
            | Some _, None -> target.AnchorY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryBackgroundColor
            match prevValueOpt, source.TryBackgroundColor with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.BackgroundColor <- value
            | Some _, None -> target.BackgroundColor <- Xamarin.Forms.Color.Default // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryHeightRequest
            match prevValueOpt, source.TryHeightRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.HeightRequest <- value
            | Some _, None -> target.HeightRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryInputTransparent
            match prevValueOpt, source.TryInputTransparent with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.InputTransparent <- value
            | Some _, None -> target.InputTransparent <- false // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsEnabled
            match prevValueOpt, source.TryIsEnabled with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsEnabled <- value
            | Some _, None -> target.IsEnabled <- true // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryIsVisible
            match prevValueOpt, source.TryIsVisible with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.IsVisible <- value
            | Some _, None -> target.IsVisible <- true // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMinimumHeightRequest
            match prevValueOpt, source.TryMinimumHeightRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.MinimumHeightRequest <- value
            | Some _, None -> target.MinimumHeightRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryMinimumWidthRequest
            match prevValueOpt, source.TryMinimumWidthRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.MinimumWidthRequest <- value
            | Some _, None -> target.MinimumWidthRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryOpacity
            match prevValueOpt, source.TryOpacity with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Opacity <- value
            | Some _, None -> target.Opacity <- 1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotation
            match prevValueOpt, source.TryRotation with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Rotation <- value
            | Some _, None -> target.Rotation <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotationX
            match prevValueOpt, source.TryRotationX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.RotationX <- value
            | Some _, None -> target.RotationX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryRotationY
            match prevValueOpt, source.TryRotationY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.RotationY <- value
            | Some _, None -> target.RotationY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryScale
            match prevValueOpt, source.TryScale with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Scale <- value
            | Some _, None -> target.Scale <- 1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryStyle
            match prevValueOpt, source.TryStyle with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.Style <- value
            | Some _, None -> target.Style <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryTranslationX
            match prevValueOpt, source.TryTranslationX with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.TranslationX <- value
            | Some _, None -> target.TranslationX <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryTranslationY
            match prevValueOpt, source.TryTranslationY with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.TranslationY <- value
            | Some _, None -> target.TranslationY <- 0.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryWidthRequest
            match prevValueOpt, source.TryWidthRequest with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.WidthRequest <- value
            | Some _, None -> target.WidthRequest <- -1.0 // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryClassId
            match prevValueOpt, source.TryClassId with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.ClassId <- value
            | Some _, None -> target.ClassId <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
            let prevValueOpt = match prevOpt with None -> None | Some prev -> prev.TryStyleId
            match prevValueOpt, source.TryStyleId with
            | Some prevValue, Some value when prevValue = value -> ()
            | prevOpt, Some value -> target.StyleId <- value
            | Some _, None -> target.StyleId <- null // TODO: not always perfect, should set back to original default?
            | None, None -> ()
        new XamlElement(typeof<Xamarin.Forms.ListView>, create, apply, Map.ofArray attribs)
[<AutoOpen>]
module XamlCreateExtensions = 

    /// Specifies a PanGestureRecognizer in the view description, initially with default attributes
    let panGestureRecognizer = Xaml.PanGestureRecognizer()

    /// Specifies a TapGestureRecognizer in the view description, initially with default attributes
    let tapGestureRecognizer = Xaml.TapGestureRecognizer()

    /// Specifies a ClickGestureRecognizer in the view description, initially with default attributes
    let clickGestureRecognizer = Xaml.ClickGestureRecognizer()

    /// Specifies a PinchGestureRecognizer in the view description, initially with default attributes
    let pinchGestureRecognizer = Xaml.PinchGestureRecognizer()

    /// Specifies a ActivityIndicator in the view description, initially with default attributes
    let activityIndicator = Xaml.ActivityIndicator()

    /// Specifies a BoxView in the view description, initially with default attributes
    let boxView = Xaml.BoxView()

    /// Specifies a ProgressBar in the view description, initially with default attributes
    let progressBar = Xaml.ProgressBar()

    /// Specifies a ScrollView in the view description, initially with default attributes
    let scrollView = Xaml.ScrollView()

    /// Specifies a SearchBar in the view description, initially with default attributes
    let searchBar = Xaml.SearchBar()

    /// Specifies a Button in the view description, initially with default attributes
    let button = Xaml.Button()

    /// Specifies a Slider in the view description, initially with default attributes
    let slider = Xaml.Slider()

    /// Specifies a Stepper in the view description, initially with default attributes
    let stepper = Xaml.Stepper()

    /// Specifies a Switch in the view description, initially with default attributes
    let switch = Xaml.Switch()

    /// Specifies a SwitchCell in the view description, initially with default attributes
    let switchCell = Xaml.SwitchCell()

    /// Specifies a Grid in the view description, initially with default attributes
    let grid = Xaml.Grid()

    /// Specifies a AbsoluteLayout in the view description, initially with default attributes
    let absoluteLayout = Xaml.AbsoluteLayout()

    /// Specifies a RelativeLayout in the view description, initially with default attributes
    let relativeLayout = Xaml.RelativeLayout()

    /// Specifies a RowDefinition in the view description, initially with default attributes
    let rowDefinition = Xaml.RowDefinition()

    /// Specifies a ColumnDefinition in the view description, initially with default attributes
    let columnDefinition = Xaml.ColumnDefinition()

    /// Specifies a ContentView in the view description, initially with default attributes
    let contentView = Xaml.ContentView()

    /// Specifies a TemplatedView in the view description, initially with default attributes
    let templatedView = Xaml.TemplatedView()

    /// Specifies a DatePicker in the view description, initially with default attributes
    let datePicker = Xaml.DatePicker()

    /// Specifies a Picker in the view description, initially with default attributes
    let picker = Xaml.Picker()

    /// Specifies a Frame in the view description, initially with default attributes
    let frame = Xaml.Frame()

    /// Specifies a Image in the view description, initially with default attributes
    let image = Xaml.Image()

    /// Specifies a Editor in the view description, initially with default attributes
    let editor = Xaml.Editor()

    /// Specifies a Entry in the view description, initially with default attributes
    let entry = Xaml.Entry()

    /// Specifies a Label in the view description, initially with default attributes
    let label = Xaml.Label()

    /// Specifies a StackLayout in the view description, initially with default attributes
    let stackLayout = Xaml.StackLayout()

    /// Specifies a Span in the view description, initially with default attributes
    let span = Xaml.Span()

    /// Specifies a TimePicker in the view description, initially with default attributes
    let timePicker = Xaml.TimePicker()

    /// Specifies a WebView in the view description, initially with default attributes
    let webView = Xaml.WebView()

    /// Specifies a Page in the view description, initially with default attributes
    let page = Xaml.Page()

    /// Specifies a CarouselPage in the view description, initially with default attributes
    let carouselPage = Xaml.CarouselPage()

    /// Specifies a NavigationPage in the view description, initially with default attributes
    let navigationPage = Xaml.NavigationPage()

    /// Specifies a TabbedPage in the view description, initially with default attributes
    let tabbedPage = Xaml.TabbedPage()

    /// Specifies a ContentPage in the view description, initially with default attributes
    let contentPage = Xaml.ContentPage()

    /// Specifies a MasterDetailPage in the view description, initially with default attributes
    let masterDetailPage = Xaml.MasterDetailPage()

    /// Specifies a TextCell in the view description, initially with default attributes
    let textCell = Xaml.TextCell()

    /// Specifies a ImageCell in the view description, initially with default attributes
    let imageCell = Xaml.ImageCell()

    /// Specifies a ViewCell in the view description, initially with default attributes
    let viewCell = Xaml.ViewCell()

    /// Specifies a ListView in the view description, initially with default attributes
    let listView = Xaml.ListView()

    /// Specifies a ListViewGrouped in the view description, initially with default attributes
    let listViewGrouped = Xaml.ListViewGrouped()
