# RichTextBoxScroller

This is a small modification to the C# RichTextBox control. Its intended purpose is to display output from another process, like in the build output window in Visual Studio. The features are:

1. The number of lines should be bounded.
2. By default it should scroll to the bottom when new lines are added.
3. It must be possible to stop the autoscrolling behavior, so that when new lines are added, the current view is kept in place.

Note that 2 and 3 can be done trivially using an ordinary textbox, but 1 and 3 together are not so easy. To my knowledge this can't be implemented with an ordinary TextBox due to some weird bug in GetCharIndexFromPosition which causes it to return the wrong position.

# Usage

The code for the control is in "RichTextBoxScroller.cs". It is a drop-in replacement for the ordinary RichTextBox control. Its public methods are:

* AppendLine and AppendLines - these are the functions which must be used when adding text in order to get the proper scrolling behavior.
* SetAutomaticScrollToBottom - change the autoscrolling behavior. The default behavior is to automatically scroll to the bottom when new lines are appended.
* SetMaxLines - set the maximum number of lines the control displays.

# Example

There is a sample project in the repo which shows how to use the control. Pressing "Add lines" will add 25 new lines. If you add more than 150 lines (e.g. by pressing the button 7 times), you can observe how the first entries are discarded. Pressing "Start random adds" will start a thread which adds random lines to the textbox. This simulates displaying the output from another process.