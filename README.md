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

