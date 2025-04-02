# Puzzle #72 - Dynamic Bootstrap
Carl and Jeff want to know how to show select (dropdown list) elements in a bootstrap grid when the lists themselves and therefore the number of select elements are not known until runtime.

YouTube Video: https://youtu.be/

Blazor Puzzle Home Page: https://blazorpuzzle.com

## The Challenge

This is a .NET 9 Blazor Web App with Global Server Interactivity

We have several lists, some of which are shown to one customer but not another.

We want to arrange them, no matter how many there are, in a bootstrap grid of three columns per row with no gaps.

For demonstration purposes, we only have eight lists, but imagine there were 20 or more possible lists, each may be shown or not shown.

How can we make this UI dynamic, so that it only shows the lists that we want without leaving gaps in the grid. To get you started, we have created a dictionary that tells you whether or not to show a list.

This is really a puzzle of how to make bootstrap rows and columns dynamic. We don't know which lists, and therefore how many, need to be shown in the grid at runtime.

## The Solution

The simple solution is to move the `<div class="col">` tags inside the ShowList test.

From this:

```html
<div class="col-4">
    @if (ShowList["Colors"])
    { ...
```

To this:

```html
@if (ShowList["Colors"])
{ 
    <div class="col-4">
    ...
```

We also have to remove the extra row divs. Remove these:

```html
    </div>
    <div class="row mb-3">
```

Jeff took this solution to another level by wrapping the entire column div into a Blazor component.

*MyList.razor*:

```c#
@typeparam TItem
@if (ShowList)
{
	<div class="col">
		<label for="@Title.ToLowerInvariant()">@Title</label>
		<br />
		<select id="@Title.ToLowerInvariant()" class="form-select" @onchange="OnSelected">
			<option value="0">None</option>
			@foreach (var item in Items)
			{
				<option value="@ItemValue(item)"
					selected="@(SelectedItem is not null && ItemValue(SelectedItem) == ItemValue(item) ? "selected" : null)">
					@ItemText(item)
				</option>
			}
		</select>
	</div>
}

@code {

	[Parameter] public bool ShowList { get; set; }
	[Parameter] public string Title { get; set; }
	[Parameter] public IEnumerable<TItem> Items { get; set; }
	[Parameter] public EventCallback<ChangeEventArgs> OnSelected { get; set; }
	[Parameter] public TItem SelectedItem { get; set; }
	[Parameter] public Func<TItem, string> ItemText { get; set; }
	[Parameter] public Func<TItem, string> ItemValue { get; set; }
}
```

Then you can just add components for each model inside the row:

```xml
<div class="container mt-4">
    <div class="row row-cols-1 row-cols-md-3 g-4">
        <MyList ShowList="@ShowList["Colors"]" 
                Title="Colors" Items="@Colors.List" 
                OnSelected="ColorSelected" 
                SelectedItem="@SelectedColor" 
                ItemText="c => c.Name" 
                ItemValue="c => c.Id.ToString()" />

        <MyList ShowList="@ShowList["Episodes"]" 
                Title="Episodes" Items="@Episodes.List" 
                OnSelected="EpisodeSelected" 
                SelectedItem="@SelectedEpisode" 
                ItemText="e => e.Title" 
                ItemValue="e => e.Number.ToString()" />
...
```

Boom!
