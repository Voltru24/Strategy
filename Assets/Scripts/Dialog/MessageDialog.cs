
public class MessageDialog : IObjectDialog
{
    public string Text { get; private set; }
    public Person @Person { get; private set; }

    public MessageDialog(string text, Person person)
    {
        Text = text;

        @Person = person;
    }

    public void Execute(DialogUI dialogUI)
    {
        dialogUI.ShowMessage(this);
    }
}
