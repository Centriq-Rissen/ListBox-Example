This solution shows the advantages of using bcl functionality to improve data binding
in WPF.

The first solution "NormalListBox" contains a collection of objects just bound to a listbox.
  --result is not stunning

The second solution "BetterListBox" overrides the ToString() method of the System.Object which 
the Employee class inherits from.  Just by using this bcl functionality we get a vast improvement in UI

The third solution "BestListBox" is using Data Template in WPF to give a MUCH better experience 